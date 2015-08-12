using Util = Saklient.Util;
using Activity = Saklient.Cloud.Resources.Activity;
using RouterActivitySample = Saklient.Cloud.Resources.RouterActivitySample;

namespace Saklient.Cloud.Resources
{

	public class RouterActivity : Activity
	{
		
		internal System.Collections.Generic.List<RouterActivitySample> _Samples;
		
		internal System.Collections.Generic.List<RouterActivitySample> Get_samples()
		{
			return this._Samples;
		}
		
		/// <summary>サンプル列
		/// </summary>
		public System.Collections.Generic.List<RouterActivitySample> Samples
		{
			get { return this.Get_samples(); }
		}
		
		internal override string _ApiPathPrefix()
		{
			return "/internet";
		}
		
		public RouterActivity(Client client) : base(client)
		{
			/*!base!*/;
		}
		
		internal override void _AddSample(string atStr, object data)
		{
			(this._Samples as System.Collections.IList).Add(new RouterActivitySample(atStr, data));
		}
		
		/// <summary>現在の最新のアクティビティ情報を取得し、samplesに格納します。
		///  
		///  	 * @return this
		/// 
		/// <param name="startDate" />
		/// <param name="endDate" />
		/// </summary>
		public RouterActivity Fetch(System.DateTime? startDate=null, System.DateTime? endDate=null)
		{
			this._Samples = new System.Collections.Generic.List<RouterActivitySample> {  };
			return ((RouterActivity)(this._Fetch(startDate, endDate)));
		}
		
	}
	
}
