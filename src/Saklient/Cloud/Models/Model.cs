using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using QueryParams = Saklient.Cloud.Models.QueryParams;
using SaklientException = Saklient.Errors.SaklientException;

namespace Saklient.Cloud.Models
{

	/**
	 * @ignore
	 * @module saklient.cloud.models.Model
	 * @class Model
	 * @constructor
	 */
	public class Model
	{
		
		/**
		 * @private
		 * @member saklient.cloud.models.Model#_Client
		 * @type Client
		 * @internal
		 * @ignore
		 */
		internal Client _Client;
		
		/**
		 * @method Get_client
		 * @internal
		 * @ignore
		 * @return {Client}
		 */
		internal Client Get_client()
		{
			return this._Client;
		}
		
		/**
		 * @property Client
		 * @type Client
		 * @readOnly
		 * @public
		 */
		public Client Client
		{
			get { return this.Get_client(); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.models.Model#_Query
		 * @type QueryParams
		 * @internal
		 * @ignore
		 */
		internal QueryParams _Query;
		
		/**
		 * @method Get_query
		 * @internal
		 * @ignore
		 * @return {QueryParams}
		 */
		internal QueryParams Get_query()
		{
			return this._Query;
		}
		
		/**
		 * @property Query
		 * @type QueryParams
		 * @readOnly
		 * @public
		 */
		public QueryParams Query
		{
			get { return this.Get_query(); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.models.Model#_Total
		 * @type long?
		 * @internal
		 * @ignore
		 */
		internal long? _Total;
		
		/**
		 * @method Get_total
		 * @internal
		 * @ignore
		 * @return {long?}
		 */
		internal long? Get_total()
		{
			return this._Total;
		}
		
		/**
		 * @property Total
		 * @type long?
		 * @readOnly
		 * @public
		 */
		public long? Total
		{
			get { return this.Get_total(); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.models.Model#_Count
		 * @type long?
		 * @internal
		 * @ignore
		 */
		internal long? _Count;
		
		/**
		 * @method Get_count
		 * @internal
		 * @ignore
		 * @return {long?}
		 */
		internal long? Get_count()
		{
			return this._Count;
		}
		
		/**
		 * @property Count
		 * @type long?
		 * @readOnly
		 * @public
		 */
		public long? Count
		{
			get { return this.Get_count(); }
		}
		
		/**
		 * @private
		 * @method _ApiPath
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal virtual string _ApiPath()
		{
			return null;
		}
		
		/**
		 * @private
		 * @method _RootKey
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal virtual string _RootKey()
		{
			return null;
		}
		
		/**
		 * @private
		 * @method _RootKeyM
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal virtual string _RootKeyM()
		{
			return null;
		}
		
		/**
		 * @private
		 * @method _ClassName
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal virtual string _ClassName()
		{
			return null;
		}
		
		/**
		 * @constructor
		 * @public
		 * @param {Client} client
		 */
		public Model(Client client)
		{
			this._Client = client;
			this._Reset();
		}
		
		/**
		 * 次に取得するリストの開始オフセットを指定します。
		 * 
		 * @private
		 * @method _Offset
		 * @chainable
		 * @internal
		 * @ignore
		 * @param {long} offset オフセット
		 * @return {Model} this
		 */
		internal Model _Offset(long offset)
		{
			this._Query.Begin = offset;
			return this;
		}
		
		/**
		 * 次に取得するリストの上限レコード数を指定します。
		 * 
		 * @private
		 * @method _Limit
		 * @chainable
		 * @internal
		 * @ignore
		 * @param {long} count 上限レコード数
		 * @return {Model} this
		 */
		internal Model _Limit(long count)
		{
			this._Query.Count = count;
			return this;
		}
		
		/**
		 * 次に取得するリストのソートカラムを指定します。
		 * 
		 * @private
		 * @method _Sort
		 * @chainable
		 * @internal
		 * @ignore
		 * @param {string} column カラム名
		 * @param {bool} reverse=false
		 * @return {Model} this
		 */
		internal Model _Sort(string column, bool reverse=false)
		{
			string op = reverse ? "-" : "";
			(this._Query.Sort as System.Collections.IList).Add(op + column);
			return this;
		}
		
		/**
		 * Web APIのフィルタリング設定を直接指定します。
		 * 
		 * @private
		 * @method _FilterBy
		 * @chainable
		 * @internal
		 * @ignore
		 * @param {string} key キー
		 * @param {object} value 値
		 * @param {bool} multiple=false valueに配列を与え、OR条件で完全一致検索する場合にtrueを指定します。通常、valueはスカラ値であいまい検索されます。
		 * @return {Model}
		 */
		internal Model _FilterBy(string key, object value, bool multiple=false)
		{
			object filter = this._Query.Filter;
			if (multiple) {
				if (!(filter as System.Collections.Generic.Dictionary<string, object>).ContainsKey(key)) {
					(filter as System.Collections.Generic.Dictionary<string, object>)[key] = new System.Collections.Generic.List<object> {  };
				}
				System.Collections.Generic.List<object> values = ((System.Collections.Generic.List<object>)((filter as System.Collections.Generic.Dictionary<string, object>)[key]));
				(values as System.Collections.IList).Add(value);
			}
			else {
				if ((filter as System.Collections.Generic.Dictionary<string, object>).ContainsKey(key)) {
					throw new SaklientException("filter_duplicated", "The same filter key can be specified only once (by calling the same method 'withFooBar')");
				}
				(filter as System.Collections.Generic.Dictionary<string, object>)[key] = value;
			}
			return this;
		}
		
		/**
		 * 次のリクエストのために設定されているステートをすべて破棄します。
		 * 
		 * @private
		 * @method _Reset
		 * @chainable
		 * @internal
		 * @ignore
		 * @return {Model} this
		 */
		internal Model _Reset()
		{
			this._Query = new QueryParams();
			this._Total = 0;
			this._Count = 0;
			return this;
		}
		
		/**
		 * 新規リソース作成用のオブジェクトを用意します。
		 * 
		 * 返り値のオブジェクトにパラメータを設定し、save() を呼ぶことで実際のリソースが作成されます。
		 * 
		 * @private
		 * @method _Create
		 * @internal
		 * @ignore
		 * @return {Resource} リソースオブジェクト
		 */
		internal Resource _Create()
		{
			System.Collections.Generic.List<object> a = new System.Collections.Generic.List<object> { this._Client, null, false };
			return ((Resource)(Util.CreateClassInstance("saklient.cloud.resources." + this._ClassName(), a)));
		}
		
		/**
		 * 指定したIDを持つ唯一のリソースを取得します。
		 * 
		 * @private
		 * @method _GetById
		 * @internal
		 * @ignore
		 * @param {string} id
		 * @return {Resource} リソースオブジェクト
		 */
		internal Resource _GetById(string id)
		{
			object query = this._Query.Build();
			this._Reset();
			object result = this._Client.Request("GET", this._ApiPath() + "/" + Util.UrlEncode(id), query);
			this._Total = 1;
			this._Count = 1;
			System.Collections.Generic.List<object> a = new System.Collections.Generic.List<object> { this._Client, result, true };
			return ((Resource)(Util.CreateClassInstance("saklient.cloud.resources." + this._ClassName(), a)));
		}
		
		/**
		 * リソースの検索リクエストを実行し、結果をリストで取得します。
		 * 
		 * @private
		 * @method _Find
		 * @internal
		 * @ignore
		 * @return {System.Collections.Generic.List<Resource>} リソースオブジェクトの配列
		 */
		internal System.Collections.Generic.List<Resource> _Find()
		{
			object query = this._Query.Build();
			this._Reset();
			object result = this._Client.Request("GET", this._ApiPath(), query);
			this._Total = System.Convert.ToInt64((result as System.Collections.Generic.Dictionary<string, object>)["Total"]);
			this._Count = System.Convert.ToInt64((result as System.Collections.Generic.Dictionary<string, object>)["Count"]);
			System.Collections.Generic.List<Resource> data = new System.Collections.Generic.List<Resource> {  };
			System.Collections.Generic.List<object> records = ((System.Collections.Generic.List<object>)((result as System.Collections.Generic.Dictionary<string, object>)[this._RootKeyM()]));
			for (int __it1=0; __it1 < (records as System.Collections.IList).Count; __it1++) {
				var record = records[__it1];
				System.Collections.Generic.List<object> a = new System.Collections.Generic.List<object> { this._Client, record, false };
				Resource i = ((Resource)(Util.CreateClassInstance("saklient.cloud.resources." + this._ClassName(), a)));
				(data as System.Collections.IList).Add(i);
			}
			return ((System.Collections.Generic.List<Resource>)(data));
		}
		
		/**
		 * リソースの検索リクエストを実行し、唯一のリソースを取得します。
		 * 
		 * @private
		 * @method _FindOne
		 * @internal
		 * @ignore
		 * @return {Resource} リソースオブジェクト
		 */
		internal Resource _FindOne()
		{
			object query = this._Query.Build();
			this._Reset();
			object result = this._Client.Request("GET", this._ApiPath(), query);
			this._Total = System.Convert.ToInt64((result as System.Collections.Generic.Dictionary<string, object>)["Total"]);
			this._Count = System.Convert.ToInt64((result as System.Collections.Generic.Dictionary<string, object>)["Count"]);
			if (this._Total == 0) {
				return null;
			}
			System.Collections.Generic.List<object> records = ((System.Collections.Generic.List<object>)((result as System.Collections.Generic.Dictionary<string, object>)[this._RootKeyM()]));
			System.Collections.Generic.List<object> a = new System.Collections.Generic.List<object> { this._Client, records[System.Convert.ToInt32(0)], false };
			return ((Resource)(Util.CreateClassInstance("saklient.cloud.resources." + this._ClassName(), a)));
		}
		
		/**
		 * 指定した文字列を名前に含むリソースに絞り込みます。
		 * 
		 * 大文字・小文字は区別されません。
		 * 半角スペースで区切られた複数の文字列は、それらをすべて含むことが条件とみなされます。
		 * 
		 * @private
		 * @todo Implement test case
		 * @method _WithNameLike
		 * @chainable
		 * @internal
		 * @ignore
		 * @param {string} name
		 * @return {Model}
		 */
		internal Model _WithNameLike(string name)
		{
			return this._FilterBy("Name", name);
		}
		
		/**
		 * 指定したタグを持つリソースに絞り込みます。
		 * 
		 * 複数のタグを指定する場合は withTags() を利用してください。
		 * 
		 * @private
		 * @todo Implement test case
		 * @method _WithTag
		 * @chainable
		 * @internal
		 * @ignore
		 * @param {string} tag
		 * @return {Model}
		 */
		internal Model _WithTag(string tag)
		{
			return this._FilterBy("Tags.Name", new System.Collections.Generic.List<object> { tag });
		}
		
		/**
		 * 指定したすべてのタグを持つリソースに絞り込みます。
		 * 
		 * @private
		 * @todo Implement test case
		 * @method _WithTags
		 * @chainable
		 * @internal
		 * @ignore
		 * @param {System.Collections.Generic.List<string>} tags
		 * @return {Model}
		 */
		internal Model _WithTags(System.Collections.Generic.List<string> tags)
		{
			return this._FilterBy("Tags.Name", new System.Collections.Generic.List<object> { tags });
		}
		
		/**
		 * 指定したDNFに合致するタグを持つリソースに絞り込みます。
		 * 
		 * @private
		 * @todo Implement test case
		 * @method _WithTagDnf
		 * @chainable
		 * @internal
		 * @ignore
		 * @param {System.Collections.Generic.List<System.Collections.Generic.List<string>>} dnf
		 * @return {Model}
		 */
		internal Model _WithTagDnf(System.Collections.Generic.List<System.Collections.Generic.List<string>> dnf)
		{
			return this._FilterBy("Tags.Name", dnf);
		}
		
		/**
		 * 名前でソートします。
		 * 
		 * @private
		 * @todo Implement test case
		 * @method _SortByName
		 * @chainable
		 * @internal
		 * @ignore
		 * @param {bool} reverse=false
		 * @return {Model}
		 */
		internal Model _SortByName(bool reverse=false)
		{
			return this._Sort("Name", reverse);
		}
		
	}
	
}
