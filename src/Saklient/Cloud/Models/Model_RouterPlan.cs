using Util = Saklient.Util;
using Model = Saklient.Cloud.Models.Model;
using RouterPlan = Saklient.Cloud.Resources.RouterPlan;

namespace Saklient.Cloud.Models
{

	/**
	 * ルータ帯域プランを検索するための機能を備えたクラス。
	 * 
	 * @module saklient.cloud.models.Model_RouterPlan
	 * @class Model_RouterPlan
	 * @constructor
	 * @extends Model
	 */
	class Model_RouterPlan : Model
	{
		
		/**
		 * @private
		 * @method _apiPath
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal override string _apiPath()
		{
			return "/product/internet";
		}
		
		/**
		 * @private
		 * @method _rootKey
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal override string _rootKey()
		{
			return "InternetPlan";
		}
		
		/**
		 * @private
		 * @method _rootKeyM
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal override string _rootKeyM()
		{
			return "InternetPlans";
		}
		
		/**
		 * @private
		 * @method _className
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal override string _className()
		{
			return "RouterPlan";
		}
		
		/**
		 * 次に取得するリストの開始オフセットを指定します。
		 * 
		 * @method Offset
		 * @chainable
		 * @public
		 * @param {int} offset オフセット
		 * @return {Model_RouterPlan} this
		 */
		public Model_RouterPlan Offset(int offset)
		{
			Util.ValidateType(offset, "int");
			return ((Model_RouterPlan)(dynamic)(this._offset(offset)));
		}
		
		/**
		 * 次に取得するリストの上限レコード数を指定します。
		 * 
		 * @method Limit
		 * @chainable
		 * @public
		 * @param {int} count 上限レコード数
		 * @return {Model_RouterPlan} this
		 */
		public Model_RouterPlan Limit(int count)
		{
			Util.ValidateType(count, "int");
			return ((Model_RouterPlan)(dynamic)(this._limit(count)));
		}
		
		/**
		 * Web APIのフィルタリング設定を直接指定します。
		 * 
		 * @method FilterBy
		 * @chainable
		 * @public
		 * @param {string} key キー
		 * @param {dynamic} value 値
		 * @param {bool} multiple=false valueに配列を与え、OR条件で完全一致検索する場合にtrueを指定します。通常、valueはスカラ値であいまい検索されます。
		 * @return {Model_RouterPlan}
		 */
		public Model_RouterPlan FilterBy(string key, dynamic value, bool multiple=false)
		{
			Util.ValidateType(key, "string");
			Util.ValidateType(value, "dynamic");
			Util.ValidateType(multiple, "bool");
			return ((Model_RouterPlan)(dynamic)(this._filterBy(key, value, multiple)));
		}
		
		/**
		 * 次のリクエストのために設定されているステートをすべて破棄します。
		 * 
		 * @method Reset
		 * @chainable
		 * @public
		 * @return {Model_RouterPlan} this
		 */
		public Model_RouterPlan Reset()
		{
			return ((Model_RouterPlan)(dynamic)(this._reset()));
		}
		
		/**
		 * 指定したIDを持つ唯一のリソースを取得します。
		 * 
		 * @method GetById
		 * @public
		 * @param {string} id
		 * @return {RouterPlan} リソースオブジェクト
		 */
		public RouterPlan GetById(string id)
		{
			Util.ValidateType(id, "string");
			return ((RouterPlan)(dynamic)(this._getById(id)));
		}
		
		/**
		 * リソースの検索リクエストを実行し、結果をリストで取得します。
		 * 
		 * @method Find
		 * @public
		 * @return {RouterPlan[]} リソースオブジェクトの配列
		 */
		public RouterPlan[] Find()
		{
			return Util.CastArray(this._find(), ((RouterPlan)(dynamic)(null)));
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 */
		public Model_RouterPlan(Client client) : base(client)
		{
			/*!base!*/;
			Util.ValidateType(client, "Client");
		}
		
	}
	
}
