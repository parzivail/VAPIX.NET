using System;
using System.Text;
using System.Threading.Tasks;

namespace VAPIX.NET
{
	public class CommandBuilder
	{
		private readonly StringBuilder _builder = new();
		private bool _firstParam = true;

		public CommandBuilder(string baseUrl)
		{
			_builder
				.Append(baseUrl);
		}

		public CommandBuilder WithParameter(RequestParameter parameter)
		{
			_builder.Append(_firstParam ? '?' : '&');
			_builder.Append(parameter.Serialize());
			_firstParam = false;
			
			return this;
		}

		public async Task<string> Send(VapixDevice device)
		{
			var request = Build(device.Host);
			return await device.Connection.GetStringAsync(request);
		}

		public Uri Build(Uri baseUri)
		{
			return new Uri(baseUri, _builder.ToString());
		}
	}
}