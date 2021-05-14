using System.Linq;
using System.Threading.Tasks;

namespace VAPIX.NET
{
	public static class PtzInquiries
	{
		private const string BaseUrl = "axis-cgi/com/ptz.cgi";

		/// <summary>
		/// Returns the name of the system-configured device driver.
		/// </summary>
		/// <param name="device"></param>
		/// <returns></returns>
		public static async Task<string[]> WhoAmI(VapixDevice device)
		{
			var cmd = await new CommandBuilder(BaseUrl)
				.WithParameter(new StringRequestParameter("whoami", "1"))
				.Send(device);
			return cmd.ReadLines().ToArray();
		}
	}
}