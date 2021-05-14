namespace VAPIX.NET
{
	public abstract class RequestParameter
	{
		public string RequestKey { get; set; }

		protected RequestParameter(string requestKey)
		{
			RequestKey = requestKey;
		}

		protected abstract string SerializeValue();

		public string Serialize()
		{
			return $"{RequestKey}={SerializeValue()}";
		}
	}
}