using Util = Saklient.Util;

namespace Saklient.Cloud.Enums
{

	/**
	 * アプライアンスのクラスを表す列挙子。
	 * 
	 * @module saklient.cloud.enums.EApplianceClass
	 * @class EApplianceClass
	 */
	class EApplianceClass
	{
		
		static System.Collections.Generic.Dictionary<string, int> _map_ = new System.Collections.Generic.Dictionary<string, int>()
		{
			{ "Loadbalancer", 10 },
			{ "Vpcrouter", 20 }
		};
		
		/**
		 * @property Loadbalancer
		 * @default "Loadbalancer"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Loadbalancer = "Loadbalancer";
		
		/**
		 * @property Vpcrouter
		 * @default "Vpcrouter"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Vpcrouter = "Vpcrouter";
		
		public static int? Compare(string lhs, string rhs)
		{
			int? l = EApplianceClass._map_[lhs];
			int? r = EApplianceClass._map_[rhs];
			if (l==null || r==null) return null;
			int ret = (int)l - (int)r;
			return 0 < ret ? 1 : (ret < 0 ? -1 : 0);
		}
		
	}
	
}
