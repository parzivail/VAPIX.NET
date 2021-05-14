namespace VAPIX.NET
{
	public class MoveDirection
	{
		public static readonly MoveDirection Home = new("home");
		public static readonly MoveDirection Up = new("up");
		public static readonly MoveDirection Down = new("down");
		public static readonly MoveDirection Left = new("left");
		public static readonly MoveDirection Right = new("right");
		public static readonly MoveDirection UpLeft = new("upleft");
		public static readonly MoveDirection UpRight = new("upright");
		public static readonly MoveDirection DownLeft = new("downleft");
		public static readonly MoveDirection DownRight = new("downright");
		public static readonly MoveDirection Stop = new("stop");
		
		private readonly string _value;

		private MoveDirection(string value)
		{
			_value = value;
		}

		public override string ToString()
		{
			return _value;
		}

		protected bool Equals(MoveDirection other)
		{
			return _value == other._value;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			return obj.GetType() == GetType() && Equals((MoveDirection)obj);
		}

		public override int GetHashCode()
		{
			return _value.GetHashCode();
		}

		public static bool operator ==(MoveDirection left, MoveDirection right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(MoveDirection left, MoveDirection right)
		{
			return !Equals(left, right);
		}
	}
}