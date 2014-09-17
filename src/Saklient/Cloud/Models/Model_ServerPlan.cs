using Util = Saklient.Util;
using Model = Saklient.Cloud.Models.Model;
using ServerPlan = Saklient.Cloud.Resources.ServerPlan;

namespace Saklient.Cloud.Models
{

	/**
	 * サーバプランを検索するための機能を備えたクラス。
	 * 
	 * @module saklient.cloud.models.Model_ServerPlan
	 * @class Model_ServerPlan
	 * @constructor
	 * @extends Model
	 */
	class Model_ServerPlan : Model
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
			return "/product/server";
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
			return "ServerPlan";
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
			return "ServerPlans";
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
			return "ServerPlan";
		}
		
		/**
		 * 次に取得するリストの開始オフセットを指定します。
		 * 
		 * @method Offset
		 * @chainable
		 * @public
		 * @param {int} offset オフセット
		 * @return {Model_ServerPlan} this
		 */
		public Model_ServerPlan Offset(int offset)
		{
			Util.ValidateType(offset, "int");
			return ((Model_ServerPlan)(dynamic)(this._offset(offset)));
		}
		
		/**
		 * 次に取得するリストの上限レコード数を指定します。
		 * 
		 * @method Limit
		 * @chainable
		 * @public
		 * @param {int} count 上限レコード数
		 * @return {Model_ServerPlan} this
		 */
		public Model_ServerPlan Limit(int count)
		{
			Util.ValidateType(count, "int");
			return ((Model_ServerPlan)(dynamic)(this._limit(count)));
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
		 * @return {Model_ServerPlan}
		 */
		public Model_ServerPlan FilterBy(string key, dynamic value, bool multiple=false)
		{
			Util.ValidateType(key, "string");
			Util.ValidateType(value, "dynamic");
			Util.ValidateType(multiple, "bool");
			return ((Model_ServerPlan)(dynamic)(this._filterBy(key, value, multiple)));
		}
		
		/**
		 * 次のリクエストのために設定されているステートをすべて破棄します。
		 * 
		 * @method Reset
		 * @chainable
		 * @public
		 * @return {Model_ServerPlan} this
		 */
		public Model_ServerPlan Reset()
		{
			return ((Model_ServerPlan)(dynamic)(this._reset()));
		}
		
		/**
		 * 指定したIDを持つ唯一のリソースを取得します。
		 * 
		 * @method GetById
		 * @public
		 * @param {string} id
		 * @return {ServerPlan} リソースオブジェクト
		 */
		public ServerPlan GetById(string id)
		{
			Util.ValidateType(id, "string");
			return ((ServerPlan)(dynamic)(this._getById(id)));
		}
		
		/**
		 * リソースの検索リクエストを実行し、結果をリストで取得します。
		 * 
		 * @method Find
		 * @public
		 * @return {ServerPlan[]} リソースオブジェクトの配列
		 */
		public ServerPlan[] Find()
		{
			return Util.CastArray(this._find(), ((ServerPlan)(dynamic)(null)));
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 */
		public Model_ServerPlan(Client client) : base(client)
		{
			/*!base!*/;
			Util.ValidateType(client, "Client");
		}
		
		/**
		 * 指定したスペックのプランを取得します。
		 * 
		 * @method GetBySpec
		 * @public
		 * @param {int} cores
		 * @param {int} memoryGib
		 * @return {ServerPlan}
		 */
		public ServerPlan GetBySpec(int cores, int memoryGib)
		{
			Util.ValidateType(cores, "int");
			Util.ValidateType(memoryGib, "int");
			this._filterBy("CPU", new object[] { cores });
			this._filterBy("MemoryMB", new object[] { memoryGib * 1024 });
			return ((ServerPlan)(dynamic)(this._findOne()));
		}
		
	}
	
}
