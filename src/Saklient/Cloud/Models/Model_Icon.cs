using Util = Saklient.Util;
using Model = Saklient.Cloud.Models.Model;
using Icon = Saklient.Cloud.Resources.Icon;
using EScope = Saklient.Cloud.Enums.EScope;

namespace Saklient.Cloud.Models
{

	/**
	 * アイコンを検索・作成するための機能を備えたクラス。
	 * 
	 * @module saklient.cloud.models.Model_Icon
	 * @class Model_Icon
	 * @constructor
	 * @extends Model
	 */
	class Model_Icon : Model
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
			return "/icon";
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
			return "Icon";
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
			return "Icons";
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
			return "Icon";
		}
		
		/**
		 * 次に取得するリストの開始オフセットを指定します。
		 * 
		 * @method Offset
		 * @chainable
		 * @public
		 * @param {int} offset オフセット
		 * @return {Model_Icon} this
		 */
		public Model_Icon Offset(int offset)
		{
			Util.ValidateType(offset, "int");
			return ((Model_Icon)(dynamic)(this._offset(offset)));
		}
		
		/**
		 * 次に取得するリストの上限レコード数を指定します。
		 * 
		 * @method Limit
		 * @chainable
		 * @public
		 * @param {int} count 上限レコード数
		 * @return {Model_Icon} this
		 */
		public Model_Icon Limit(int count)
		{
			Util.ValidateType(count, "int");
			return ((Model_Icon)(dynamic)(this._limit(count)));
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
		 * @return {Model_Icon}
		 */
		public Model_Icon FilterBy(string key, dynamic value, bool multiple=false)
		{
			Util.ValidateType(key, "string");
			Util.ValidateType(value, "dynamic");
			Util.ValidateType(multiple, "bool");
			return ((Model_Icon)(dynamic)(this._filterBy(key, value, multiple)));
		}
		
		/**
		 * 次のリクエストのために設定されているステートをすべて破棄します。
		 * 
		 * @method Reset
		 * @chainable
		 * @public
		 * @return {Model_Icon} this
		 */
		public Model_Icon Reset()
		{
			return ((Model_Icon)(dynamic)(this._reset()));
		}
		
		/**
		 * 指定したIDを持つ唯一のリソースを取得します。
		 * 
		 * @method GetById
		 * @public
		 * @param {string} id
		 * @return {Icon} リソースオブジェクト
		 */
		public Icon GetById(string id)
		{
			Util.ValidateType(id, "string");
			return ((Icon)(dynamic)(this._getById(id)));
		}
		
		/**
		 * リソースの検索リクエストを実行し、結果をリストで取得します。
		 * 
		 * @method Find
		 * @public
		 * @return {Icon[]} リソースオブジェクトの配列
		 */
		public Icon[] Find()
		{
			return Util.CastArray(this._find(), ((Icon)(dynamic)(null)));
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
		 * @return {Model_Icon}
		 */
		public Model_Icon WithNameLike(string name)
		{
			Util.ValidateType(name, "string");
			return ((Model_Icon)(dynamic)(this._withNameLike(name)));
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
		 * @return {Model_Icon}
		 */
		public Model_Icon WithTag(string tag)
		{
			Util.ValidateType(tag, "string");
			return ((Model_Icon)(dynamic)(this._withTag(tag)));
		}
		
		/**
		 * 指定したすべてのタグを持つリソースに絞り込みます。
		 * 
		 * @todo Implement test case
		 * @method WithTags
		 * @chainable
		 * @public
		 * @param {string[]} tags
		 * @return {Model_Icon}
		 */
		public Model_Icon WithTags(string[] tags)
		{
			Util.ValidateType(tags, "System.Collections.ArrayList");
			return ((Model_Icon)(dynamic)(this._withTags(tags)));
		}
		
		/**
		 * 指定したDNFに合致するタグを持つリソースに絞り込みます。
		 * 
		 * @todo Implement test case
		 * @method WithTagDnf
		 * @chainable
		 * @public
		 * @param {string[][]} dnf
		 * @return {Model_Icon}
		 */
		public Model_Icon WithTagDnf(string[][] dnf)
		{
			Util.ValidateType(dnf, "System.Collections.ArrayList");
			return ((Model_Icon)(dynamic)(this._withTagDnf(dnf)));
		}
		
		/**
		 * 名前でソートします。
		 * 
		 * @todo Implement test case
		 * @method SortByName
		 * @chainable
		 * @public
		 * @param {bool} reverse=false
		 * @return {Model_Icon}
		 */
		public Model_Icon SortByName(bool reverse=false)
		{
			Util.ValidateType(reverse, "bool");
			return ((Model_Icon)(dynamic)(this._sortByName(reverse)));
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 */
		public Model_Icon(Client client) : base(client)
		{
			/*!base!*/;
			Util.ValidateType(client, "Client");
		}
		
		/**
		 * パブリックアイコンに絞り込みます。
		 * 
		 * @method WithSharedScope
		 * @chainable
		 * @public
		 * @return {Model_Icon}
		 */
		public Model_Icon WithSharedScope()
		{
			this._filterBy("Scope", new object[] { EScope.Shared });
			return this;
		}
		
		/**
		 * プライベートアイコンに絞り込みます。
		 * 
		 * @method WithUserScope
		 * @chainable
		 * @public
		 * @return {Model_Icon}
		 */
		public Model_Icon WithUserScope()
		{
			this._filterBy("Scope", new object[] { EScope.User });
			return this;
		}
		
	}
	
}
