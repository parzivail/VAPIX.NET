namespace VAPIX.NET
{
	public class OnOffAutoRequestParameter : RequestParameter
	{
		public bool? Value { get; }

		public OnOffAutoRequestParameter(string requestKey, bool? value) : base(requestKey)
		{
			Value = value;
		}

		protected override string SerializeValue()
		{
			return Value.HasValue ? (Value.Value ? "on" : "off") : "auto";
		}
	}
}