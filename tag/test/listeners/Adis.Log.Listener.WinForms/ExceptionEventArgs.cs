﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adis.Log.Listener.WinForms
{
	public class ExceptionEventArgs : EventArgs
	{
		public Exception Exception { get; set; }

		public ExceptionEventArgs(Exception e)
		{
			Exception = e;
		}

	}
}
