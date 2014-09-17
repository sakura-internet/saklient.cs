using Util = Saklient.Util;

namespace Saklient.Cloud.Enums
{

	/**
	 * ストレージのクラスを表す列挙子。
	 * 
	 * @module saklient.cloud.enums.EStorageClass
	 * @class EStorageClass
	 */
	class EStorageClass
	{
		
		static System.Collections.Generic.Dictionary<string, int> _map_ = new System.Collections.Generic.Dictionary<string, int>()
		{
			{ "Iscsi1204", 110 }
		};
		
		/**
		 * @property Iscsi1204
		 * @default "Iscsi1204"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Iscsi1204 = "Iscsi1204";
		
		public static int? Compare(string lhs, string rhs)
		{
			int? l = EStorageClass._map_[lhs];
			int? r = EStorageClass._map_[rhs];
			if (l==null || r==null) return null;
			int ret = (int)l - (int)r;
			return 0 < ret ? 1 : (ret < 0 ? -1 : 0);
		}
		
	}
	
}
