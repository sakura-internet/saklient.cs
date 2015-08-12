using Util = Saklient.Util;
using Activity = Saklient.Cloud.Resources.Activity;
using DiskActivitySample = Saklient.Cloud.Resources.DiskActivitySample;

namespace Saklient.Cloud.Resources
{

	public class DiskActivity : Activity
	{
		
		internal System.Collections.Generic.List<DiskActivitySample> _Samples;
		
		internal System.Collections.Generic.List<DiskActivitySample> Get_samples()
		{
			return this._Samples;
		}
		
		/// <summary>サンプル列
		/// </summary>
		public System.Collections.Generic.List<DiskActivitySample> Samples
		{
			get { return this.Get_samples(); }
		}
		
		internal override string _ApiPathPrefix()
		{
			return "/disk";
		}
		
		public DiskActivity(Client client) : base(client)
		{
			/*!base!*/;
		}
		
		internal override void _AddSample(string atStr, object data)
		{
			(this._Samples as System.Collections.IList).Add(new DiskActivitySample(atStr, data));
		}
		
		/// <summary>現在の最新のアクティビティ情報を取得し、samplesに格納します。
		///  
		///  	 * @return this
		/// 
		/// <param name="startDate" />
		/// <param name="endDate" />
		/// </summary>
		public DiskActivity Fetch(System.DateTime? startDate=null, System.DateTime? endDate=null)
		{
			this._Samples = new System.Collections.Generic.List<DiskActivitySample> {  };
			return ((DiskActivity)(this._Fetch(startDate, endDate)));
		}
		
	}
	
}
