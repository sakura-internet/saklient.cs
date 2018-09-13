using Util = Saklient.Util;

namespace Saklient.Cloud.Resources
{

	/// <summary>
	/// 
	/// </summary>
	public class ServerActivitySample
	{
		
		internal System.DateTime _At;
		
		public System.DateTime Get_at()
		{
			return this._At;
		}
		
		/// <summary>記録日時
		/// </summary>
		public System.DateTime At
		{
			get { return this.Get_at(); }
		}
		
		internal bool _IsAvailable;
		
		public bool Get_isAvailable()
		{
			return this._IsAvailable;
		}
		
		/// <summary>有効な値のとき真
		/// </summary>
		public bool IsAvailable
		{
			get { return this.Get_isAvailable(); }
		}
		
		internal double _CpuTime;
		
		public double Get_cpuTime()
		{
			return this._CpuTime;
		}
		
		/// <summary>CPU時間
		/// </summary>
		public double CpuTime
		{
			get { return this.Get_cpuTime(); }
		}

        /// <summary>
        /// </summary>
        /// <param name="atStr" />
        /// <param name="data" />
        public ServerActivitySample(string atStr, object data)
		{
			this._At = ((System.DateTime)(Util.Str2date(atStr)));
			this._IsAvailable = false;
			object v = (data as System.Collections.Generic.Dictionary<string, object>)["CPU-TIME"];
			if (v != null) {
				this._IsAvailable = true;
				this._CpuTime = ((double)(v));
			}
		}
		
	}
	
}
