namespace VAPIX.NET
{
	public class Point2RequestParameter : RequestParameter
	{
		public int X { get; }
		public int Y { get; }

		public Point2RequestParameter(string requestKey, int x, int y) : base(requestKey)
		{
			X = x;
			Y = y;
		}

		protected override string SerializeValue()
		{
			return $"{X.ToString(CultureHelper.EnUs)},{Y.ToString(CultureHelper.EnUs)}";
		}
	}
}