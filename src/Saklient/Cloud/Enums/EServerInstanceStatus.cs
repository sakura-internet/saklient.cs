using Util = Saklient.Util;

namespace Saklient.Cloud.Enums
{

	/**
	 * サーバの起動状態を表す列挙子。
	 * 
	 * @module saklient.cloud.enums.EServerInstanceStatus
	 * @class EServerInstanceStatus
	 */
	class EServerInstanceStatus
	{
		
		static System.Collections.Generic.Dictionary<string, int> _map_ = new System.Collections.Generic.Dictionary<string, int>()
		{
			{ "Down", 0 },
			{ "Cleaning", 5 },
			{ "Up", 100 }
		};
		
		/**
		 * @property Down
		 * @default "Down"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Down = "Down";
		
		/**
		 * @property Cleaning
		 * @default "Cleaning"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Cleaning = "Cleaning";
		
		/**
		 * @property Up
		 * @default "Up"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Up = "Up";
		
		public static int? Compare(string lhs, string rhs)
		{
			int? l = EServerInstanceStatus._map_[lhs];
			int? r = EServerInstanceStatus._map_[rhs];
			if (l==null || r==null) return null;
			int ret = (int)l - (int)r;
			return 0 < ret ? 1 : (ret < 0 ? -1 : 0);
		}
		
	}
	
}
