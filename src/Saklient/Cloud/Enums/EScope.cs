using Util = Saklient.Util;

namespace Saklient.Cloud.Enums
{

	/**
	 * リソースの公開範囲を表す列挙子。
	 * 
	 * @module saklient.cloud.enums.EScope
	 * @class EScope
	 */
	public class EScope
	{
		
		static System.Collections.Generic.Dictionary<string, long> _map_ = new System.Collections.Generic.Dictionary<string, long>()
		{
			{ "user", 100 },
			{ "shared", 200 }
		};
		
		/**
		 * @property User
		 * @default "user"
		 * @type string
		 * @static
		 * @public
		 */
		public static string User = "user";
		
		/**
		 * @property Shared
		 * @default "shared"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Shared = "shared";
		
		public static long? Compare(string lhs, string rhs)
		{
			long? l = EScope._map_[lhs];
			long? r = EScope._map_[rhs];
			if (l==null || r==null) return null;
			long ret = (long)l - (long)r;
			return 0 < ret ? 1 : (ret < 0 ? -1 : 0);
		}
		
	}
	
}
