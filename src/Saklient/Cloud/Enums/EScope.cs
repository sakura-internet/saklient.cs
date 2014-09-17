using Util = Saklient.Util;

namespace Saklient.Cloud.Enums
{

	/**
	 * リソースの公開範囲を表す列挙子。
	 * 
	 * @module saklient.cloud.enums.EScope
	 * @class EScope
	 */
	class EScope
	{
		
		static System.Collections.Generic.Dictionary<string, int> _map_ = new System.Collections.Generic.Dictionary<string, int>()
		{
			{ "User", 100 },
			{ "Shared", 200 }
		};
		
		/**
		 * @property User
		 * @default "User"
		 * @type string
		 * @static
		 * @public
		 */
		public static string User = "User";
		
		/**
		 * @property Shared
		 * @default "Shared"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Shared = "Shared";
		
		public static int? Compare(string lhs, string rhs)
		{
			int? l = EScope._map_[lhs];
			int? r = EScope._map_[rhs];
			if (l==null || r==null) return null;
			int ret = (int)l - (int)r;
			return 0 < ret ? 1 : (ret < 0 ? -1 : 0);
		}
		
	}
	
}
