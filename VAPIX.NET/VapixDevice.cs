using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;

namespace VAPIX.NET
{
	public class VapixDevice
	{
		public Uri Host { get; }
		public HttpClient Connection { get; }

		public VapixDevice(Uri host, string username, string password)
		{
			Host = host;

			Connection = new HttpClient(new HttpClientHandler
			{
				Credentials = new NetworkCredential(username, password)
			});
		}
	}
}