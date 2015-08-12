using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;

namespace Saklient.Cloud.Resources
{

	public class Activity
	{
		
		internal Client _Client;
		
		internal string _SourceId;
		
		internal virtual string _ApiPathPrefix()
		{
			return null;
		}
		
		internal virtual string _ApiPathSuffix()
		{
			return "/monitor";
		}
		
		internal virtual void _AddSample(string atStr, object data)
		{
			
		}
		
		public Activity(Client client)
		{
			this._Client = client;
		}
		
		public void SetSourceId(string id)
		{
			this._SourceId = id;
		}
		
		public Activity _Fetch(System.DateTime? startDate=null, System.DateTime? endDate=null)
		{
			object query = new System.Collections.Generic.Dictionary<string, object> {};
			if (startDate != null) {
				(query as System.Collections.Generic.Dictionary<string, object>)["Start"] = Util.Date2str(startDate);
			}
			if (endDate != null) {
				(query as System.Collections.Generic.Dictionary<string, object>)["End"] = Util.Date2str(endDate);
			}
			string path = this._ApiPathPrefix() + "/" + Util.UrlEncode(this._SourceId) + this._ApiPathSuffix();
			object data = this._Client.Request("GET", path);
			if (data == null) {
				return null;
			}
			data = (data as System.Collections.Generic.Dictionary<string, object>)["Data"];
			if (data == null) {
				return null;
			}
			System.Collections.Generic.List<string> dates = Util.DictionaryKeys(data);
			dates = Util.SortArray(dates);
			for (int __it1=0; __it1 < (dates as System.Collections.IList).Count; __it1++) {
				var date = dates[__it1];
				this._AddSample(date, (data as System.Collections.Generic.Dictionary<string, object>)[date]);
			}
			return this;
		}
		
	}
	
}
