using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Model = Saklient.Cloud.Models.Model;
using ServerPlan = Saklient.Cloud.Resources.ServerPlan;

namespace Saklient.Cloud.Models
{

	/// <summary>サーバプランを検索するための機能を備えたクラス。
	/// </summary>
	public class Model_ServerPlan : Model
	{
		
		internal override string _ApiPath()
		{
			return "/product/server";
		}
		
		internal override string _RootKey()
		{
			return "ServerPlan";
		}
		
		internal override string _RootKeyM()
		{
			return "ServerPlans";
		}
		
		internal override string _ClassName()
		{
			return "ServerPlan";
		}
		
		/// <summary>次に取得するリストの開始オフセットを指定します。
		/// 
		/// <param name="offset">オフセット</param>
		/// <returns>this</returns>
		/// </summary>
		public Model_ServerPlan Offset(long offset)
		{
			return ((Model_ServerPlan)(this._Offset(offset)));
		}
		
		/// <summary>次に取得するリストの上限レコード数を指定します。
		/// 
		/// <param name="count">上限レコード数</param>
		/// <returns>this</returns>
		/// </summary>
		public Model_ServerPlan Limit(long count)
		{
			return ((Model_ServerPlan)(this._Limit(count)));
		}
		
		/// <summary>Web APIのフィルタリング設定を直接指定します。
		/// 
		/// <param name="key">キー</param>
		/// <param name="value">値</param>
		/// <param name="multiple">valueに配列を与え、OR条件で完全一致検索する場合にtrueを指定します。通常、valueはスカラ値であいまい検索されます。</param>
		/// </summary>
		public Model_ServerPlan FilterBy(string key, object value, bool multiple=false)
		{
			return ((Model_ServerPlan)(this._FilterBy(key, value, multiple)));
		}
		
		/// <summary>次のリクエストのために設定されているステートをすべて破棄します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Model_ServerPlan Reset()
		{
			return ((Model_ServerPlan)(this._Reset()));
		}
		
		/// <summary>指定したIDを持つ唯一のリソースを取得します。
		/// 
		/// <param name="id" />
		/// <returns>リソースオブジェクト</returns>
		/// </summary>
		public ServerPlan GetById(string id)
		{
			return ((ServerPlan)(this._GetById(id)));
		}
		
		/// <summary>リソースの検索リクエストを実行し、結果をリストで取得します。
		/// 
		/// <returns>リソースオブジェクトの配列</returns>
		/// </summary>
		public System.Collections.Generic.List<ServerPlan> Find()
		{
			return Util.CastArray(this._Find(), ((ServerPlan)(null)));
		}
		
		public Model_ServerPlan(Client client) : base(client)
		{
			/*!base!*/;
		}
		
		/// <summary>指定したスペックのプランを取得します。
		/// 
		/// <param name="cores" />
		/// <param name="memoryGib" />
		/// </summary>
		public ServerPlan GetBySpec(long cores, long memoryGib)
		{
			this._FilterBy("CPU", new System.Collections.Generic.List<object> { cores });
			this._FilterBy("MemoryMB", new System.Collections.Generic.List<object> { memoryGib * 1024 });
			return ((ServerPlan)(this._FindOne()));
		}
		
	}
	
}
