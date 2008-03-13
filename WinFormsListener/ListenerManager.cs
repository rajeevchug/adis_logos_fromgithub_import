﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace WinFormsListener
{
	class ListenerManager
	{
		static ChannelFactory<Adis.Log.Contract.IListenerContract> channel;
		static Adis.Log.Contract.IListenerContract listener;

		public static void StartService()
		{
				InstanceContext iContext;

				bool success = false;
			try
			{
				iContext = new InstanceContext(new WinFormsListener.ListenerCallback());

				channel = new DuplexChannelFactory<Adis.Log.Contract.IListenerContract>(iContext, "ListenerEndpoint");
				listener = channel.CreateChannel();
				success = listener.InitialiseLink();
			}
			catch (Exception e)
			{
				System.Windows.Forms.MessageBox.Show(e.ToString());
			}
			if (success && channel.State == CommunicationState.Opened)
			{
				Program.mainForm.StatusText = "Listener initialised. New events will appear here";
			}
			else
			{
				Program.mainForm.StatusText = "Listener failed to initialise a connection with the server.";
			}
		}

	}
}
