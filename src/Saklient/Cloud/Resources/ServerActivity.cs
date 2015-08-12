using Util = Saklient.Util;
using Activity = Saklient.Cloud.Resources.Activity;
using ServerActivitySample = Saklient.Cloud.Resources.ServerActivitySample;

namespace Saklient.Cloud.Resources
{

	public class ServerActivity : Activity
	{
		
		internal System.Collections.Generic.List<ServerActivitySample> _Samples;
		
		internal System.Collections.Generic.List<ServerActivitySample> Get_samples()
		{
			return this._Samples;
		}
		
		/// <summary>サンプル列
		/// </summary>
		public System.Collections.Generic.List<ServerActivitySample> Samples
		{
			get { return this.Get_samples(); }
		}
		
		internal override string _ApiPathPrefix()
		{
			return "/server";
		}
		
		public ServerActivity(Client client) : base(client)
		{
			/*!base!*/;
		}
		
		internal override void _AddSample(string atStr, object data)
		{
			(this._Samples as System.Collections.IList).Add(new ServerActivitySample(atStr, data));
		}
		
		/// <summary>現在の最新のアクティビティ情報を取得し、samplesに格納します。
		///  
		///  	 * @return this
		/// 
		/// <param name="startDate" />
		/// <param name="endDate" />
		/// </summary>
		public ServerActivity Fetch(System.DateTime? startDate=null, System.DateTime? endDate=null)
		{
			this._Samples = new System.Collections.Generic.List<ServerActivitySample> {  };
			return ((ServerActivity)(this._Fetch(startDate, endDate)));
		}
		
	}
	
}
