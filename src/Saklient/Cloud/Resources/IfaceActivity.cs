using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Activity = Saklient.Cloud.Resources.Activity;
using IfaceActivitySample = Saklient.Cloud.Resources.IfaceActivitySample;

namespace Saklient.Cloud.Resources
{

	public class IfaceActivity : Activity
	{
		
		internal System.Collections.Generic.List<IfaceActivitySample> _Samples;
		
		internal System.Collections.Generic.List<IfaceActivitySample> Get_samples()
		{
			return this._Samples;
		}
		
		/// <summary>サンプル列
		/// </summary>
		public System.Collections.Generic.List<IfaceActivitySample> Samples
		{
			get { return this.Get_samples(); }
		}
		
		internal override string _ApiPathPrefix()
		{
			return "/interface";
		}
		
		internal override string _ApiPathSuffix()
		{
			return "/monitor";
		}
		
		public IfaceActivity(Client client) : base(client)
		{
			/*!base!*/;
		}
		
		internal override void _AddSample(string atStr, object data)
		{
			(this._Samples as System.Collections.IList).Add(new IfaceActivitySample(atStr, data));
		}

        /// <summary>現在の最新のアクティビティ情報を取得し、samplesに格納します。
        /// </summary>
        /// <param name="startDate" />
        /// <param name="endDate" />
        /// <returns>this</returns>
        public IfaceActivity Fetch(System.DateTime? startDate=null, System.DateTime? endDate=null)
		{
			this._Samples = new System.Collections.Generic.List<IfaceActivitySample> {  };
			return ((IfaceActivity)(this._Fetch(startDate, endDate)));
		}
		
	}
	
}
