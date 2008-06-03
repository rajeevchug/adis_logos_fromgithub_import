﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adis.Log.Contract;
using System.ServiceModel;
using log4net;

namespace Adis.Log.Server
{
	class ListenerService : IListenerContract
	{
		private ILog _InternalLog;

		private ListenerImplementer listenerImplementer;
		
		public ListenerService()
		{
			listenerImplementer = new ListenerImplementer();
			_InternalLog = LogManager.GetLogger(this.GetType());
		}

		#region IListenerContract Members

		/// <summary>
		/// responds to a listener trying to initialise a link to this server. Adds the listeners details into callbackObjList
		/// </summary>
		/// <param name="requestFilter"></param>
		/// <returns></returns>
		public bool InitialiseLink(RequestFilter requestFilter)
		{
			try
			{
				return listenerImplementer.InitialiseLink(requestFilter,
					OperationContext.Current.GetCallbackChannel<IListenerCallbackContract>(),
					OperationContext.Current.Channel.RemoteAddress.Uri, OperationContext.Current.Channel, ListenerImplementer.CallbackObjList);
			}
			catch (Exception e)
			{
				_InternalLog.Error(String.Format("failed to initialise link for listener {0}", OperationContext.Current.Channel.RemoteAddress.Uri), e);
			}
			return false;
		}


		/// <summary>
		/// Notify all of the current listeners.
		/// </summary>
		/// <param name="logObject">The log that listeners are being notified of.</param>
		public static void NotifyListeners(LogTransportObject logObject)
		{
			try
			{
				ListenerImplementer.NotifyListeners(logObject, ListenerImplementer.CallbackObjList);
			}
			catch (Exception e)
			{
				ILog log = LogManager.GetLogger(typeof(ListenerService));
				log.Error(String.Format("Failed to notify (all) listeners of a new log. App: {0}",
					logObject != null ? logObject.Application : "{null}"),
					e);

			}
		}


		public List<LogTransportObject> GetRecords(RequestFilter filter, int skipFirst, int maxRecords)
		{
			try
			{
				return ReporterImplementer.GetRecords(filter, skipFirst, maxRecords,
					Repository.RepositoryInstance, OperationContext.Current.Channel.RemoteAddress.Uri, true);
			}
			catch (Exception e)
			{
				_InternalLog.Error(String.Format("Exception raised in GetRecords() for listener: {0}", 
					OperationContext.Current.Channel.RemoteAddress.Uri), e);
			}
			return null;
		}

		public void KeepAlive()
		{
			_InternalLog.DebugFormat("got keep alive message from listener:{0}", OperationContext.Current.Channel.RemoteAddress.Uri);
			return;
		}

		#endregion
	}
}
