using Util = Saklient.Util;

namespace Saklient.Cloud.Enums
{

	/// <summary>ディスクの接続方式を表す列挙子。
	/// </summary>
	public class EDiskConnection
	{
		
		static System.Collections.Generic.Dictionary<string, long?> _map_ = new System.Collections.Generic.Dictionary<string, long?>()
		{
			{ IDE, 100 },
			{ VIRTIO, 300 }
		};
		
		/// <summary>IDE
		/// </summary>
		public static string IDE = "ide";
		
		/// <summary>VIRTIO
		/// </summary>
		public static string VIRTIO = "virtio";
		
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
