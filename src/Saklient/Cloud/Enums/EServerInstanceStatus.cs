using Util = Saklient.Util;

namespace Saklient.Cloud.Enums
{

	/// <summary>サーバの起動状態を表す列挙子。
	/// </summary>
	public class EServerInstanceStatus
	{
		
		static System.Collections.Generic.Dictionary<string, long?> _map_ = new System.Collections.Generic.Dictionary<string, long?>()
		{
			{ DOWN, 0 },
			{ CLEANING, 5 },
			{ UP, 100 }
		};
		
		/// <summary>DOWN
		/// </summary>
		public static string DOWN = "down";
		
		/// <summary>CLEANING
		/// </summary>
		public static string CLEANING = "cleaning";
		
		/// <summary>UP
		/// </summary>
		public static string UP = "up";
		
		public static long? Compare(string lhs, string rhs)
		{
			long? l = lhs!=null && _map_.ContainsKey(lhs) ? _map_[lhs] : null;
			long? r = rhs!=null && _map_.ContainsKey(rhs) ? _map_[rhs] : null;
			if (l==null || r==null) return null;
			long ret = (long)l - (long)r;
			return 0 < ret ? 1 : (ret < 0 ? -1 : 0);
		}
		
	}
	
}
