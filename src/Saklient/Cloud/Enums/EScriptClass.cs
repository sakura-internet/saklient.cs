using Util = Saklient.Util;

namespace Saklient.Cloud.Enums
{

	/**
	 * スクリプトのクラスを表す列挙子。
	 * 
	 * @module saklient.cloud.enums.EScriptClass
	 * @class EScriptClass
	 */
	class EScriptClass
	{
		
		static System.Collections.Generic.Dictionary<string, int> _map_ = new System.Collections.Generic.Dictionary<string, int>()
		{
			{ "Shell", 200 },
			{ "Ansible", 300 }
		};
		
		/**
		 * @property Shell
		 * @default "Shell"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Shell = "Shell";
		
		/**
		 * @property Ansible
		 * @default "Ansible"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Ansible = "Ansible";
		
		public static int? Compare(string lhs, string rhs)
		{
			int? l = EScriptClass._map_[lhs];
			int? r = EScriptClass._map_[rhs];
			if (l==null || r==null) return null;
			int ret = (int)l - (int)r;
			return 0 < ret ? 1 : (ret < 0 ? -1 : 0);
		}
		
	}
	
}
