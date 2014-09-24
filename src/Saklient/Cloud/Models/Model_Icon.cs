using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Model = Saklient.Cloud.Models.Model;
using Icon = Saklient.Cloud.Resources.Icon;
using EScope = Saklient.Cloud.Enums.EScope;

namespace Saklient.Cloud.Models
{

	/// <summary>アイコンを検索・作成するための機能を備えたクラス。
	/// </summary>
	public class Model_Icon : Model
	{
		
		internal override string _ApiPath()
		{
			return "/icon";
		}
		
		internal override string _RootKey()
		{
			return "Icon";
		}
		
		internal override string _RootKeyM()
		{
			return "Icons";
		}
		
		internal override string _ClassName()
		{
			return "Icon";
		}
		
		/// <summary>次に取得するリストの開始オフセットを指定します。
		/// 
		/// <param name="offset">オフセット</param>
		/// <returns>this</returns>
		/// </summary>
		public Model_Icon Offset(long offset)
		{
			return ((Model_Icon)(this._Offset(offset)));
		}
		
		/// <summary>次に取得するリストの上限レコード数を指定します。
		/// 
		/// <param name="count">上限レコード数</param>
		/// <returns>this</returns>
		/// </summary>
		public Model_Icon Limit(long count)
		{
			return ((Model_Icon)(this._Limit(count)));
		}
		
		/// <summary>Web APIのフィルタリング設定を直接指定します。
		/// 
		/// <param name="key">キー</param>
		/// <param name="value">値</param>
		/// <param name="multiple">valueに配列を与え、OR条件で完全一致検索する場合にtrueを指定します。通常、valueはスカラ値であいまい検索されます。</param>
		/// </summary>
		public Model_Icon FilterBy(string key, object value, bool multiple=false)
		{
			return ((Model_Icon)(this._FilterBy(key, value, multiple)));
		}
		
		/// <summary>次のリクエストのために設定されているステートをすべて破棄します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Model_Icon Reset()
		{
			return ((Model_Icon)(this._Reset()));
		}
		
		/// <summary>指定したIDを持つ唯一のリソースを取得します。
		/// 
		/// <param name="id" />
		/// <returns>リソースオブジェクト</returns>
		/// </summary>
		public Icon GetById(string id)
		{
			return ((Icon)(this._GetById(id)));
		}
		
		/// <summary>リソースの検索リクエストを実行し、結果をリストで取得します。
		/// 
		/// <returns>リソースオブジェクトの配列</returns>
		/// </summary>
		public System.Collections.Generic.List<Icon> Find()
		{
			return Util.CastArray(this._Find(), ((Icon)(null)));
		}
		
		/// <summary>指定した文字列を名前に含むリソースに絞り込みます。
		/// 
		/// 大文字・小文字は区別されません。
		/// 半角スペースで区切られた複数の文字列は、それらをすべて含むことが条件とみなされます。
		/// 
		/// 
		/// <param name="name" />
		/// </summary>
		public Model_Icon WithNameLike(string name)
		{
			return ((Model_Icon)(this._WithNameLike(name)));
		}
		
		/// <summary>指定したタグを持つリソースに絞り込みます。
		/// 
		/// 複数のタグを指定する場合は withTags() を利用してください。
		/// 
		/// 
		/// <param name="tag" />
		/// </summary>
		public Model_Icon WithTag(string tag)
		{
			return ((Model_Icon)(this._WithTag(tag)));
		}
		
		/// <summary>指定したすべてのタグを持つリソースに絞り込みます。
		/// 
		/// 
		/// <param name="tags" />
		/// </summary>
		public Model_Icon WithTags(System.Collections.Generic.List<string> tags)
		{
			return ((Model_Icon)(this._WithTags(tags)));
		}
		
		/// <summary>指定したDNFに合致するタグを持つリソースに絞り込みます。
		/// 
		/// 
		/// <param name="dnf" />
		/// </summary>
		public Model_Icon WithTagDnf(System.Collections.Generic.List<System.Collections.Generic.List<string>> dnf)
		{
			return ((Model_Icon)(this._WithTagDnf(dnf)));
		}
		
		/// <summary>名前でソートします。
		/// 
		/// 
		/// <param name="reverse" />
		/// </summary>
		public Model_Icon SortByName(bool reverse=false)
		{
			return ((Model_Icon)(this._SortByName(reverse)));
		}
		
		public Model_Icon(Client client) : base(client)
		{
			/*!base!*/;
		}
		
		/// <summary>パブリックアイコンに絞り込みます。
		/// </summary>
		public Model_Icon WithSharedScope()
		{
			this._FilterBy("Scope", new System.Collections.Generic.List<object> { EScope.SHARED });
			return this;
		}
		
		/// <summary>プライベートアイコンに絞り込みます。
		/// </summary>
		public Model_Icon WithUserScope()
		{
			this._FilterBy("Scope", new System.Collections.Generic.List<object> { EScope.USER });
			return this;
		}
		
	}
	
}
