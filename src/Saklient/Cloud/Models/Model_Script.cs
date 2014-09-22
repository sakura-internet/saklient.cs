using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Model = Saklient.Cloud.Models.Model;
using Script = Saklient.Cloud.Resources.Script;
using EScope = Saklient.Cloud.Enums.EScope;

namespace Saklient.Cloud.Models
{

	/**
	 * スクリプトを検索・作成するための機能を備えたクラス。
	 * 
	 * @module saklient.cloud.models.Model_Script
	 * @class Model_Script
	 * @constructor
	 * @extends Model
	 */
	public class Model_Script : Model
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
			return "/note";
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
			return "Note";
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
			return "Notes";
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
			return "Script";
		}
		
		/**
		 * 次に取得するリストの開始オフセットを指定します。
		 * 
		 * @method Offset
		 * @chainable
		 * @public
		 * @param {long} offset オフセット
		 * @return {Model_Script} this
		 */
		public Model_Script Offset(long offset)
		{
			return ((Model_Script)(this._offset(offset)));
		}
		
		/**
		 * 次に取得するリストの上限レコード数を指定します。
		 * 
		 * @method Limit
		 * @chainable
		 * @public
		 * @param {long} count 上限レコード数
		 * @return {Model_Script} this
		 */
		public Model_Script Limit(long count)
		{
			return ((Model_Script)(this._limit(count)));
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
		 * @return {Model_Script}
		 */
		public Model_Script FilterBy(string key, object value, bool multiple=false)
		{
			return ((Model_Script)(this._filterBy(key, value, multiple)));
		}
		
		/**
		 * 次のリクエストのために設定されているステートをすべて破棄します。
		 * 
		 * @method Reset
		 * @chainable
		 * @public
		 * @return {Model_Script} this
		 */
		public Model_Script Reset()
		{
			return ((Model_Script)(this._reset()));
		}
		
		/**
		 * 指定したIDを持つ唯一のリソースを取得します。
		 * 
		 * @method GetById
		 * @public
		 * @param {string} id
		 * @return {Script} リソースオブジェクト
		 */
		public Script GetById(string id)
		{
			return ((Script)(this._getById(id)));
		}
		
		/**
		 * リソースの検索リクエストを実行し、結果をリストで取得します。
		 * 
		 * @method Find
		 * @public
		 * @return {System.Collections.Generic.List<Script>} リソースオブジェクトの配列
		 */
		public System.Collections.Generic.List<Script> Find()
		{
			return Util.CastArray(this._find(), ((Script)(null)));
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
		 * @return {Model_Script}
		 */
		public Model_Script WithNameLike(string name)
		{
			return ((Model_Script)(this._withNameLike(name)));
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
		 * @return {Model_Script}
		 */
		public Model_Script WithTag(string tag)
		{
			return ((Model_Script)(this._withTag(tag)));
		}
		
		/**
		 * 指定したすべてのタグを持つリソースに絞り込みます。
		 * 
		 * @todo Implement test case
		 * @method WithTags
		 * @chainable
		 * @public
		 * @param {System.Collections.Generic.List<string>} tags
		 * @return {Model_Script}
		 */
		public Model_Script WithTags(System.Collections.Generic.List<string> tags)
		{
			return ((Model_Script)(this._withTags(tags)));
		}
		
		/**
		 * 指定したDNFに合致するタグを持つリソースに絞り込みます。
		 * 
		 * @todo Implement test case
		 * @method WithTagDnf
		 * @chainable
		 * @public
		 * @param {System.Collections.Generic.List<System.Collections.Generic.List<string>>} dnf
		 * @return {Model_Script}
		 */
		public Model_Script WithTagDnf(System.Collections.Generic.List<System.Collections.Generic.List<string>> dnf)
		{
			return ((Model_Script)(this._withTagDnf(dnf)));
		}
		
		/**
		 * 名前でソートします。
		 * 
		 * @todo Implement test case
		 * @method SortByName
		 * @chainable
		 * @public
		 * @param {bool} reverse=false
		 * @return {Model_Script}
		 */
		public Model_Script SortByName(bool reverse=false)
		{
			return ((Model_Script)(this._sortByName(reverse)));
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 */
		public Model_Script(Client client) : base(client)
		{
			/*!base!*/;
		}
		
		/**
		 * パブリックスクリプトに絞り込みます。
		 * 
		 * @method WithSharedScope
		 * @chainable
		 * @public
		 * @return {Model_Script}
		 */
		public Model_Script WithSharedScope()
		{
			this._filterBy("Scope", new System.Collections.Generic.List<object> { EScope.Shared });
			return this;
		}
		
		/**
		 * プライベートスクリプトに絞り込みます。
		 * 
		 * @method WithUserScope
		 * @chainable
		 * @public
		 * @return {Model_Script}
		 */
		public Model_Script WithUserScope()
		{
			this._filterBy("Scope", new System.Collections.Generic.List<object> { EScope.User });
			return this;
		}
		
	}
	
}
