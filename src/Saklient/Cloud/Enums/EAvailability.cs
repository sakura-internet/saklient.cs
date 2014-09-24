using Util = Saklient.Util;

namespace Saklient.Cloud.Enums
{

	/// <summary>リソースの有効性を表す列挙子。
	/// </summary>
	public class EAvailability
	{
		
		static System.Collections.Generic.Dictionary<string, long?> _map_ = new System.Collections.Generic.Dictionary<string, long?>()
		{
			{ "selectable", 69 },
			{ "migrating", 70 },
			{ "precreate", 71 },
			{ "replicating", 72 },
			{ "transfering", 73 },
			{ "stopped", 75 },
			{ "failed", 78 },
			{ "charged", 79 },
			{ "uploading", 80 },
			{ "available", 100 }
		};
		
		/// <summary>SELECTABLE
		/// </summary>
		public static string SELECTABLE = "selectable";
		
		/// <summary>MIGRATING
		/// </summary>
		public static string MIGRATING = "migrating";
		
		/// <summary>PRECREATE
		/// </summary>
		public static string PRECREATE = "precreate";
		
		/// <summary>REPLICATING
		/// </summary>
		public static string REPLICATING = "replicating";
		
		/// <summary>TRANSFERING
		/// </summary>
		public static string TRANSFERING = "transfering";
		
		/// <summary>STOPPED
		/// </summary>
		public static string STOPPED = "stopped";
		
		/// <summary>FAILED
		/// </summary>
		public static string FAILED = "failed";
		
		/// <summary>CHARGED
		/// </summary>
		public static string CHARGED = "charged";
		
		/// <summary>UPLOADING
		/// </summary>
		public static string UPLOADING = "uploading";
		
		/// <summary>AVAILABLE
		/// </summary>
		public static string AVAILABLE = "available";
		
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
