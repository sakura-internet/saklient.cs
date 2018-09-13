using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Model = Saklient.Cloud.Models.Model;
using Resource = Saklient.Cloud.Resources.Resource;
using RouterPlan = Saklient.Cloud.Resources.RouterPlan;

namespace Saklient.Cloud.Models
{

	/// <summary>ルータ帯域プランを検索するための機能を備えたクラス。
	/// </summary>
	public class Model_RouterPlan : Model
	{
		
		internal override string _ApiPath()
		{
			return "/product/internet";
		}
		
		internal override string _RootKey()
		{
			return "InternetPlan";
		}
		
		internal override string _RootKeyM()
		{
			return "InternetPlans";
		}
		
		internal override string _ClassName()
		{
			return "RouterPlan";
		}
		
		internal override Resource _CreateResourceImpl(object obj, bool wrapped=false)
		{
			return new RouterPlan(this._Client, obj, wrapped);
		}

        /// <summary>次に取得するリストの開始オフセットを指定します。
        /// </summary>
        /// <param name="offset">オフセット</param>
        /// <returns>this</returns>
        public Model_RouterPlan Offset(long offset)
		{
			return ((Model_RouterPlan)(this._Offset(offset)));
		}

        /// <summary>次に取得するリストの上限レコード数を指定します。
        /// </summary>
        /// <param name="count">上限レコード数</param>
        /// <returns>this</returns>
        public Model_RouterPlan Limit(long count)
		{
			return ((Model_RouterPlan)(this._Limit(count)));
		}

        /// <summary>Web APIのフィルタリング設定を直接指定します。
        /// </summary>
        /// <param name="key">キー</param>
        /// <param name="value">値</param>
        /// <param name="multiple">valueに配列を与え、OR条件で完全一致検索する場合にtrueを指定します。通常、valueはスカラ値であいまい検索されます。</param>
        public Model_RouterPlan FilterBy(string key, object value, bool multiple=false)
		{
			return ((Model_RouterPlan)(this._FilterBy(key, value, multiple)));
		}

        /// <summary>次のリクエストのために設定されているステートをすべて破棄します。
        /// </summary>
        /// <returns>this</returns>
        public Model_RouterPlan Reset()
		{
			return ((Model_RouterPlan)(this._Reset()));
		}

        /// <summary>指定したIDを持つ唯一のリソースを取得します。
        /// </summary>
        /// <param name="id" />
        /// <returns>リソースオブジェクト</returns>
        public RouterPlan GetById(string id)
		{
			return ((RouterPlan)(this._GetById(id)));
		}

        /// <summary>リソースの検索リクエストを実行し、結果をリストで取得します。
        /// </summary>
        /// <returns>リソースオブジェクトの配列</returns>
        public System.Collections.Generic.List<RouterPlan> Find()
		{
			return Util.CastArray(this._Find(), ((RouterPlan)(null)));
		}
		
		public Model_RouterPlan(Client client) : base(client)
		{
			/*!base!*/;
		}
		
	}
	
}
