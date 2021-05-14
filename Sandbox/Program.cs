using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using VAPIX.NET;

namespace Sandbox
{
	class Program
	{
		static async Task Main(string[] args)
		{
			var camera = new VapixDevice(new Uri("http://192.168.1.90/"), "webremote", "QhV16!$24#7tUP&hI&o%8VPu");

			await new PtzCommandBuilder()
				.AutoFocus(true)
				.AutoIris(true)
				.RBrightness(0)
				.RFocus(0)
				.RIris(0)
				.RPan(0)
				.RTilt(0)
				.RZoom(0)
				.Send(camera);
		}
	}
}