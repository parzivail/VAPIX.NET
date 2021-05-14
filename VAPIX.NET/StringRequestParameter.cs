namespace VAPIX.NET
{
	public class StringRequestParameter : RequestParameter
	{
		public string Value { get; }

		public StringRequestParameter(string requestKey, string value) : base(requestKey)
		{
			Value = value;
		}

		protected override string SerializeValue()
		{
			return Value;
		}
	}
}