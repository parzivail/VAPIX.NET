using System.Globalization;

namespace VAPIX.NET
{
	public class FloatRequestParameter : RequestParameter
	{
		public float Value { get; }

		public FloatRequestParameter(string requestKey, float value) : base(requestKey)
		{
			Value = value;
		}

		protected override string SerializeValue()
		{
			return Value.ToString(CultureHelper.EnUs);
		}
	}
}