namespace VAPIX.NET
{
	public class Point3RequestParameter : RequestParameter
	{
		public int X { get; }
		public int Y { get; }
		public int Z { get; }

		public Point3RequestParameter(string requestKey, int x, int y, int z) : base(requestKey)
		{
			X = x;
			Y = y;
			Z = z;
		}

		protected override string SerializeValue()
		{
			return $"{X.ToString(CultureHelper.EnUs)},{Y.ToString(CultureHelper.EnUs)},{Z.ToString(CultureHelper.EnUs)}";
		}
	}
}