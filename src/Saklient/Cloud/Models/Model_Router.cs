using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Model = Saklient.Cloud.Models.Model;
using Router = Saklient.Cloud.Resources.Router;

namespace Saklient.Cloud.Models
{

	/**
	 * ルータを検索するための機能を備えたクラス。
	 * 
	 * @module saklient.cloud.models.Model_Router
	 * @class Model_Router
	 * @constructor
	 * @extends Model
	 */
	public class Model_Router : Model
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
			return "/internet";
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
			return "Internet";
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
			return "Internet";
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
			return "Router";
		}
		
		/**
		 * 次に取得するリストの開始オフセットを指定します。
		 * 
		 * @method Offset
		 * @chainable
		 * @public
		 * @param {long} offset オフセット
		 * @return {Model_Router} this
		 */
		public Model_Router Offset(long offset)
		{
			Util.ValidateType(offset, "long");
			return ((Model_Router)(this._offset(offset)));
		}
		
		/**
		 * 次に取得するリストの上限レコード数を指定します。
		 * 
		 * @method Limit
		 * @chainable
		 * @public
		 * @param {long} count 上限レコード数
		 * @return {Model_Router} this
		 */
		public Model_Router Limit(long count)
		{
			Util.ValidateType(count, "long");
			return ((Model_Router)(this._limit(count)));
		}
		
		/**
		 * Web APIのフィルタリング設定を直接指定します。
		 * 
		 * @method FilterBy
		 * @chainable
		 * @public
		 * @param {string} key キー
		 * @param {object} value 値
		 * @param {bool} multiple=false valueに配列を与え、OR条件で完全一致検索する場合にtrueを指定します。通常、valueはスカラ値であいまい検索されます。
		 * @return {Model_Router}
		 */
		public Model_Router FilterBy(string key, object value, bool multiple=false)
		{
			Util.ValidateType(key, "string");
			Util.ValidateType(value, "object");
			Util.ValidateType(multiple, "bool");
			return ((Model_Router)(this._filterBy(key, value, multiple)));
		}
		
		/**
		 * 次のリクエストのために設定されているステートをすべて破棄します。
		 * 
		 * @method Reset
		 * @chainable
		 * @public
		 * @return {Model_Router} this
		 */
		public Model_Router Reset()
		{
			return ((Model_Router)(this._reset()));
		}
		
		/**
		 * 新規リソース作成用のオブジェクトを用意します。
		 * 
		 * 返り値のオブジェクトにパラメータを設定し、save() を呼ぶことで実際のリソースが作成されます。
		 * 
		 * @method Create
		 * @public
		 * @return {Router} リソースオブジェクト
		 */
		public Router Create()
		{
			return ((Router)(this._create()));
		}
		
		/**
		 * 指定したIDを持つ唯一のリソースを取得します。
		 * 
		 * @method GetById
		 * @public
		 * @param {string} id
		 * @return {Router} リソースオブジェクト
		 */
		public Router GetById(string id)
		{
			Util.ValidateType(id, "string");
			return ((Router)(this._getById(id)));
		}
		
		/**
		 * リソースの検索リクエストを実行し、結果をリストで取得します。
		 * 
		 * @method Find
		 * @public
		 * @return {System.Collections.Generic.List<Router>} リソースオブジェクトの配列
		 */
		public System.Collections.Generic.List<Router> Find()
		{
			return Util.CastArray(this._find(), ((Router)(null)));
		}
		
		/**
		 * 指定した文字列を名前に含むリソースに絞り込みます。
		 * 
		 * 大文字・小文字は区別されません。
		 * 半角スペースで区切られた複数の文字列は、それらをすべて含むことが条件とみなされます。
		 * 
		 * @todo Implement test case
		 * @method WithNameLike
		 * @chainable
		 * @public
		 * @param {string} name
		 * @return {Model_Router}
		 */
		public Model_Router WithNameLike(string name)
		{
			Util.ValidateType(name, "string");
			return ((Model_Router)(this._withNameLike(name)));
		}
		
		/**
		 * 名前でソートします。
		 * 
		 * @todo Implement test case
		 * @method SortByName
		 * @chainable
		 * @public
		 * @param {bool} reverse=false
		 * @return {Model_Router}
		 */
		public Model_Router SortByName(bool reverse=false)
		{
			Util.ValidateType(reverse, "bool");
			return ((Model_Router)(this._sortByName(reverse)));
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 */
		public Model_Router(Client client) : base(client)
		{
			/*!base!*/;
			Util.ValidateType(client, "Saklient.Cloud.Client");
		}
		
		/**
		 * 指定した帯域幅のルータに絞り込みます。
		 * 
		 * @method WithBandWidthMbps
		 * @chainable
		 * @public
		 * @param {long} mbps
		 * @return {Model_Router}
		 */
		public Model_Router WithBandWidthMbps(long mbps)
		{
			Util.ValidateType(mbps, "long");
			this._filterBy("BandWidthMbps", new System.Collections.Generic.List<object> { mbps });
			return this;
		}
		
	}
	
}
