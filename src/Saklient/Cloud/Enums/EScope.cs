using Util = Saklient.Util;

namespace Saklient.Cloud.Enums
{

	/// <summary>リソースの公開範囲を表す列挙子。
	/// </summary>
	public class EScope
	{
		
		static System.Collections.Generic.Dictionary<string, long?> _map_ = new System.Collections.Generic.Dictionary<string, long?>()
		{
			{ USER, 100 },
			{ SHARED, 200 }
		};
		
		/// <summary>USER
		/// </summary>
		public static string USER = "user";
		
		/// <summary>SHARED
		/// </summary>
		public static string SHARED = "shared";
		
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
