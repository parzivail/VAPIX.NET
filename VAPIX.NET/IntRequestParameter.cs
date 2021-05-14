namespace VAPIX.NET
{
	public class IntRequestParameter : RequestParameter
	{
		public int Value { get; }

		public IntRequestParameter(string requestKey, int value) : base(requestKey)
		{
			Value = value;
		}

		protected override string SerializeValue()
		{
			return Value.ToString(CultureHelper.EnUs);
		}
	}
}