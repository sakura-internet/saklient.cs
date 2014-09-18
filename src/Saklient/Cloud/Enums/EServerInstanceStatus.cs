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
		
		static System.Collections.Generic.Dictionary<string, long> _map_ = new System.Collections.Generic.Dictionary<string, long>()
		{
			{ "down", 0 },
			{ "cleaning", 5 },
			{ "up", 100 }
		};
		
		/**
		 * @property Down
		 * @default "down"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Down = "down";
		
		/**
		 * @property Cleaning
		 * @default "cleaning"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Cleaning = "cleaning";
		
		/**
		 * @property Up
		 * @default "up"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Up = "up";
		
		public static long? Compare(string lhs, string rhs)
		{
			long? l = EServerInstanceStatus._map_[lhs];
			long? r = EServerInstanceStatus._map_[rhs];
			if (l==null || r==null) return null;
			long ret = (long)l - (long)r;
			return 0 < ret ? 1 : (ret < 0 ? -1 : 0);
		}
		
	}
	
}
