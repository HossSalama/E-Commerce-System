using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_System
{

	public class EmailSender : INotificationSender
	{
		public void Send(string message)
		{
			Console.WriteLine($"[Email Sent]: {message}");
		}
	}

	public class SMSSender : INotificationSender
	{
		public void Send(string message)
		{
			Console.WriteLine($"[SMS Sent]: {message}");
		}
	}

}