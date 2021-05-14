namespace VAPIX.NET
{
	public class OnOffRequestParameter : RequestParameter
	{
		public bool Value { get; }

		public OnOffRequestParameter(string requestKey, bool value) : base(requestKey)
		{
			Value = value;
		}

		protected override string SerializeValue()
		{
			return Value ? "on" : "off";
		}
	}
}