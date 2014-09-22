using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Model = Saklient.Cloud.Models.Model;
using IsoImage = Saklient.Cloud.Resources.IsoImage;
using EScope = Saklient.Cloud.Enums.EScope;

namespace Saklient.Cloud.Models
{

	/**
	 * ISOイメージを検索・作成するための機能を備えたクラス。
	 * 
	 * @module saklient.cloud.models.Model_IsoImage
	 * @class Model_IsoImage
	 * @constructor
	 * @extends Model
	 */
	public class Model_IsoImage : Model
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
			return "/cdrom";
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
			return "CDROM";
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
			return "CDROMs";
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
			return "IsoImage";
		}
		
		/**
		 * 次に取得するリストの開始オフセットを指定します。
		 * 
		 * @method Offset
		 * @chainable
		 * @public
		 * @param {long} offset オフセット
		 * @return {Model_IsoImage} this
		 */
		public Model_IsoImage Offset(long offset)
		{
			return ((Model_IsoImage)(this._offset(offset)));
		}
		
		/**
		 * 次に取得するリストの上限レコード数を指定します。
		 * 
		 * @method Limit
		 * @chainable
		 * @public
		 * @param {long} count 上限レコード数
		 * @return {Model_IsoImage} this
		 */
		public Model_IsoImage Limit(long count)
		{
			return ((Model_IsoImage)(this._limit(count)));
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
		 * @return {Model_IsoImage}
		 */
		public Model_IsoImage FilterBy(string key, object value, bool multiple=false)
		{
			return ((Model_IsoImage)(this._filterBy(key, value, multiple)));
		}
		
		/**
		 * 次のリクエストのために設定されているステートをすべて破棄します。
		 * 
		 * @method Reset
		 * @chainable
		 * @public
		 * @return {Model_IsoImage} this
		 */
		public Model_IsoImage Reset()
		{
			return ((Model_IsoImage)(this._reset()));
		}
		
		/**
		 * 新規リソース作成用のオブジェクトを用意します。
		 * 
		 * 返り値のオブジェクトにパラメータを設定し、save() を呼ぶことで実際のリソースが作成されます。
		 * 
		 * @method Create
		 * @public
		 * @return {IsoImage} リソースオブジェクト
		 */
		public IsoImage Create()
		{
			return ((IsoImage)(this._create()));
		}
		
		/**
		 * 指定したIDを持つ唯一のリソースを取得します。
		 * 
		 * @method GetById
		 * @public
		 * @param {string} id
		 * @return {IsoImage} リソースオブジェクト
		 */
		public IsoImage GetById(string id)
		{
			return ((IsoImage)(this._getById(id)));
		}
		
		/**
		 * リソースの検索リクエストを実行し、結果をリストで取得します。
		 * 
		 * @method Find
		 * @public
		 * @return {System.Collections.Generic.List<IsoImage>} リソースオブジェクトの配列
		 */
		public System.Collections.Generic.List<IsoImage> Find()
		{
			return Util.CastArray(this._find(), ((IsoImage)(null)));
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
		 * @return {Model_IsoImage}
		 */
		public Model_IsoImage WithNameLike(string name)
		{
			return ((Model_IsoImage)(this._withNameLike(name)));
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
		 * @return {Model_IsoImage}
		 */
		public Model_IsoImage WithTag(string tag)
		{
			return ((Model_IsoImage)(this._withTag(tag)));
		}
		
		/**
		 * 指定したすべてのタグを持つリソースに絞り込みます。
		 * 
		 * @todo Implement test case
		 * @method WithTags
		 * @chainable
		 * @public
		 * @param {System.Collections.Generic.List<string>} tags
		 * @return {Model_IsoImage}
		 */
		public Model_IsoImage WithTags(System.Collections.Generic.List<string> tags)
		{
			return ((Model_IsoImage)(this._withTags(tags)));
		}
		
		/**
		 * 指定したDNFに合致するタグを持つリソースに絞り込みます。
		 * 
		 * @todo Implement test case
		 * @method WithTagDnf
		 * @chainable
		 * @public
		 * @param {System.Collections.Generic.List<System.Collections.Generic.List<string>>} dnf
		 * @return {Model_IsoImage}
		 */
		public Model_IsoImage WithTagDnf(System.Collections.Generic.List<System.Collections.Generic.List<string>> dnf)
		{
			return ((Model_IsoImage)(this._withTagDnf(dnf)));
		}
		
		/**
		 * 名前でソートします。
		 * 
		 * @todo Implement test case
		 * @method SortByName
		 * @chainable
		 * @public
		 * @param {bool} reverse=false
		 * @return {Model_IsoImage}
		 */
		public Model_IsoImage SortByName(bool reverse=false)
		{
			return ((Model_IsoImage)(this._sortByName(reverse)));
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 */
		public Model_IsoImage(Client client) : base(client)
		{
			/*!base!*/;
		}
		
		/**
		 * 指定したサイズのISOイメージに絞り込みます。
		 * 
		 * @method WithSizeGib
		 * @chainable
		 * @public
		 * @param {long} sizeGib
		 * @return {Model_IsoImage}
		 */
		public Model_IsoImage WithSizeGib(long sizeGib)
		{
			this._filterBy("SizeMB", new System.Collections.Generic.List<object> { sizeGib * 1024 });
			return this;
		}
		
		/**
		 * パブリックISOイメージに絞り込みます。
		 * 
		 * @method WithSharedScope
		 * @chainable
		 * @public
		 * @return {Model_IsoImage}
		 */
		public Model_IsoImage WithSharedScope()
		{
			this._filterBy("Scope", new System.Collections.Generic.List<object> { EScope.Shared });
			return this;
		}
		
		/**
		 * プライベートISOイメージに絞り込みます。
		 * 
		 * @method WithUserScope
		 * @chainable
		 * @public
		 * @return {Model_IsoImage}
		 */
		public Model_IsoImage WithUserScope()
		{
			this._filterBy("Scope", new System.Collections.Generic.List<object> { EScope.User });
			return this;
		}
		
		/**
		 * サイズでソートします。
		 * 
		 * @method SortBySize
		 * @chainable
		 * @public
		 * @param {bool} reverse=false
		 * @return {Model_IsoImage}
		 */
		public Model_IsoImage SortBySize(bool reverse=false)
		{
			this._sort("SizeMB", reverse);
			return this;
		}
		
	}
	
}
