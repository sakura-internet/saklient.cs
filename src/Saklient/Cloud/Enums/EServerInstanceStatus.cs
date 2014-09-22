using Util = Saklient.Util;

namespace Saklient.Cloud.Enums
{

	/**
	 * サーバの起動状態を表す列挙子。
	 * 
	 * @module saklient.cloud.enums.EServerInstanceStatus
	 * @class EServerInstanceStatus
	 */
	public class EServerInstanceStatus
	{
		
		static System.Collections.Generic.Dictionary<string, long?> _map_ = new System.Collections.Generic.Dictionary<string, long?>()
		{
			{ "down", 0 },
			{ "cleaning", 5 },
			{ "up", 100 }
		};
		
		/**
		 * @property DOWN
		 * @default "down"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DOWN = "down";
		
		/**
		 * @property CLEANING
		 * @default "cleaning"
		 * @type string
		 * @static
		 * @public
		 */
		public static string CLEANING = "cleaning";
		
		/**
		 * @property UP
		 * @default "up"
		 * @type string
		 * @static
		 * @public
		 */
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
