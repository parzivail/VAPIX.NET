namespace VAPIX.NET
{
	public class MoveRequestParameter : RequestParameter
	{
		public MoveDirection Value { get; }

		public MoveRequestParameter(string requestKey, MoveDirection value) : base(requestKey)
		{
			Value = value;
		}

		protected override string SerializeValue()
		{
			return Value.ToString();
		}
	}
}