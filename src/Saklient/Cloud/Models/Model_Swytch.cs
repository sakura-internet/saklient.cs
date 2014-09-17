using Util = Saklient.Util;
using Model = Saklient.Cloud.Models.Model;
using Swytch = Saklient.Cloud.Resources.Swytch;

namespace Saklient.Cloud.Models
{

	/**
	 * スイッチを検索・作成するための機能を備えたクラス。
	 * 
	 * @module saklient.cloud.models.Model_Swytch
	 * @class Model_Swytch
	 * @constructor
	 * @extends Model
	 */
	class Model_Swytch : Model
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
			return "/switch";
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
			return "Switch";
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
			return "Switches";
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
			return "Swytch";
		}
		
		/**
		 * 次に取得するリストの開始オフセットを指定します。
		 * 
		 * @method Offset
		 * @chainable
		 * @public
		 * @param {int} offset オフセット
		 * @return {Model_Swytch} this
		 */
		public Model_Swytch Offset(int offset)
		{
			Util.ValidateType(offset, "int");
			return ((Model_Swytch)(dynamic)(this._offset(offset)));
		}
		
		/**
		 * 次に取得するリストの上限レコード数を指定します。
		 * 
		 * @method Limit
		 * @chainable
		 * @public
		 * @param {int} count 上限レコード数
		 * @return {Model_Swytch} this
		 */
		public Model_Swytch Limit(int count)
		{
			Util.ValidateType(count, "int");
			return ((Model_Swytch)(dynamic)(this._limit(count)));
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
		 * @return {Model_Swytch}
		 */
		public Model_Swytch FilterBy(string key, dynamic value, bool multiple=false)
		{
			Util.ValidateType(key, "string");
			Util.ValidateType(value, "dynamic");
			Util.ValidateType(multiple, "bool");
			return ((Model_Swytch)(dynamic)(this._filterBy(key, value, multiple)));
		}
		
		/**
		 * 次のリクエストのために設定されているステートをすべて破棄します。
		 * 
		 * @method Reset
		 * @chainable
		 * @public
		 * @return {Model_Swytch} this
		 */
		public Model_Swytch Reset()
		{
			return ((Model_Swytch)(dynamic)(this._reset()));
		}
		
		/**
		 * 新規リソース作成用のオブジェクトを用意します。
		 * 
		 * 返り値のオブジェクトにパラメータを設定し、save() を呼ぶことで実際のリソースが作成されます。
		 * 
		 * @method Create
		 * @public
		 * @return {Swytch} リソースオブジェクト
		 */
		public Swytch Create()
		{
			return ((Swytch)(dynamic)(this._create()));
		}
		
		/**
		 * 指定したIDを持つ唯一のリソースを取得します。
		 * 
		 * @method GetById
		 * @public
		 * @param {string} id
		 * @return {Swytch} リソースオブジェクト
		 */
		public Swytch GetById(string id)
		{
			Util.ValidateType(id, "string");
			return ((Swytch)(dynamic)(this._getById(id)));
		}
		
		/**
		 * リソースの検索リクエストを実行し、結果をリストで取得します。
		 * 
		 * @method Find
		 * @public
		 * @return {Swytch[]} リソースオブジェクトの配列
		 */
		public Swytch[] Find()
		{
			return Util.CastArray(this._find(), ((Swytch)(dynamic)(null)));
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
		 * @return {Model_Swytch}
		 */
		public Model_Swytch WithNameLike(string name)
		{
			Util.ValidateType(name, "string");
			return ((Model_Swytch)(dynamic)(this._withNameLike(name)));
		}
		
		/**
		 * 名前でソートします。
		 * 
		 * @todo Implement test case
		 * @method SortByName
		 * @chainable
		 * @public
		 * @param {bool} reverse=false
		 * @return {Model_Swytch}
		 */
		public Model_Swytch SortByName(bool reverse=false)
		{
			Util.ValidateType(reverse, "bool");
			return ((Model_Swytch)(dynamic)(this._sortByName(reverse)));
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 */
		public Model_Swytch(Client client) : base(client)
		{
			/*!base!*/;
			Util.ValidateType(client, "Client");
		}
		
	}
	
}
