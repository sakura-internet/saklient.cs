using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Model = Saklient.Cloud.Models.Model;
using Appliance = Saklient.Cloud.Resources.Appliance;

namespace Saklient.Cloud.Models
{

	/**
	 * アプライアンスを検索・作成するための機能を備えたクラス。
	 * 
	 * @module saklient.cloud.models.Model_Appliance
	 * @class Model_Appliance
	 * @constructor
	 * @extends Model
	 */
	public class Model_Appliance : Model
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
			return "/appliance";
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
			return "Appliance";
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
			return "Appliances";
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
			return "Appliance";
		}
		
		/**
		 * 次に取得するリストの開始オフセットを指定します。
		 * 
		 * @method Offset
		 * @chainable
		 * @public
		 * @param {long} offset オフセット
		 * @return {Model_Appliance} this
		 */
		public Model_Appliance Offset(long offset)
		{
			return ((Model_Appliance)(this._offset(offset)));
		}
		
		/**
		 * 次に取得するリストの上限レコード数を指定します。
		 * 
		 * @method Limit
		 * @chainable
		 * @public
		 * @param {long} count 上限レコード数
		 * @return {Model_Appliance} this
		 */
		public Model_Appliance Limit(long count)
		{
			return ((Model_Appliance)(this._limit(count)));
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
		 * @return {Model_Appliance}
		 */
		public Model_Appliance FilterBy(string key, object value, bool multiple=false)
		{
			return ((Model_Appliance)(this._filterBy(key, value, multiple)));
		}
		
		/**
		 * 次のリクエストのために設定されているステートをすべて破棄します。
		 * 
		 * @method Reset
		 * @chainable
		 * @public
		 * @return {Model_Appliance} this
		 */
		public Model_Appliance Reset()
		{
			return ((Model_Appliance)(this._reset()));
		}
		
		/**
		 * 指定したIDを持つ唯一のリソースを取得します。
		 * 
		 * @method GetById
		 * @public
		 * @param {string} id
		 * @return {Appliance} リソースオブジェクト
		 */
		public Appliance GetById(string id)
		{
			return ((Appliance)(this._getById(id)));
		}
		
		/**
		 * リソースの検索リクエストを実行し、結果をリストで取得します。
		 * 
		 * @method Find
		 * @public
		 * @return {System.Collections.Generic.List<Appliance>} リソースオブジェクトの配列
		 */
		public System.Collections.Generic.List<Appliance> Find()
		{
			return Util.CastArray(this._find(), ((Appliance)(null)));
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
		 * @return {Model_Appliance}
		 */
		public Model_Appliance WithNameLike(string name)
		{
			return ((Model_Appliance)(this._withNameLike(name)));
		}
		
		/**
		 * 指定したタグを持つリソースに絞り込みます。
		 * 
		 * 複数のタグを指定する場合は withTags() を利用してください。
		 * 
		 * @todo Implement test case
		 * @method WithTag
		 * @chainable
		 * @public
		 * @param {string} tag
		 * @return {Model_Appliance}
		 */
		public Model_Appliance WithTag(string tag)
		{
			return ((Model_Appliance)(this._withTag(tag)));
		}
		
		/**
		 * 指定したすべてのタグを持つリソースに絞り込みます。
		 * 
		 * @todo Implement test case
		 * @method WithTags
		 * @chainable
		 * @public
		 * @param {System.Collections.Generic.List<string>} tags
		 * @return {Model_Appliance}
		 */
		public Model_Appliance WithTags(System.Collections.Generic.List<string> tags)
		{
			return ((Model_Appliance)(this._withTags(tags)));
		}
		
		/**
		 * 指定したDNFに合致するタグを持つリソースに絞り込みます。
		 * 
		 * @todo Implement test case
		 * @method WithTagDnf
		 * @chainable
		 * @public
		 * @param {System.Collections.Generic.List<System.Collections.Generic.List<string>>} dnf
		 * @return {Model_Appliance}
		 */
		public Model_Appliance WithTagDnf(System.Collections.Generic.List<System.Collections.Generic.List<string>> dnf)
		{
			return ((Model_Appliance)(this._withTagDnf(dnf)));
		}
		
		/**
		 * 名前でソートします。
		 * 
		 * @todo Implement test case
		 * @method SortByName
		 * @chainable
		 * @public
		 * @param {bool} reverse=false
		 * @return {Model_Appliance}
		 */
		public Model_Appliance SortByName(bool reverse=false)
		{
			return ((Model_Appliance)(this._sortByName(reverse)));
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 */
		public Model_Appliance(Client client) : base(client)
		{
			/*!base!*/;
		}
		
	}
	
}
