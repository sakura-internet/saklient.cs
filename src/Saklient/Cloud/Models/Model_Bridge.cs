using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Model = Saklient.Cloud.Models.Model;
using Resource = Saklient.Cloud.Resources.Resource;
using Bridge = Saklient.Cloud.Resources.Bridge;

namespace Saklient.Cloud.Models
{

	/// <summary>ブリッジを検索・作成するための機能を備えたクラス。
	/// </summary>
	public class Model_Bridge : Model
	{
		
		internal override string _ApiPath()
		{
			return "/bridge";
		}
		
		internal override string _RootKey()
		{
			return "Bridge";
		}
		
		internal override string _RootKeyM()
		{
			return "Bridges";
		}
		
		internal override string _ClassName()
		{
			return "Bridge";
		}
		
		internal override Resource _CreateResourceImpl(object obj, bool wrapped=false)
		{
			return new Bridge(this._Client, obj, wrapped);
		}
		
		/// <summary>次に取得するリストの開始オフセットを指定します。
		/// 
		/// <param name="offset">オフセット</param>
		/// <returns>this</returns>
		/// </summary>
		public Model_Bridge Offset(long offset)
		{
			return ((Model_Bridge)(this._Offset(offset)));
		}
		
		/// <summary>次に取得するリストの上限レコード数を指定します。
		/// 
		/// <param name="count">上限レコード数</param>
		/// <returns>this</returns>
		/// </summary>
		public Model_Bridge Limit(long count)
		{
			return ((Model_Bridge)(this._Limit(count)));
		}
		
		/// <summary>Web APIのフィルタリング設定を直接指定します。
		/// 
		/// <param name="key">キー</param>
		/// <param name="value">値</param>
		/// <param name="multiple">valueに配列を与え、OR条件で完全一致検索する場合にtrueを指定します。通常、valueはスカラ値であいまい検索されます。</param>
		/// </summary>
		public Model_Bridge FilterBy(string key, object value, bool multiple=false)
		{
			return ((Model_Bridge)(this._FilterBy(key, value, multiple)));
		}
		
		/// <summary>次のリクエストのために設定されているステートをすべて破棄します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Model_Bridge Reset()
		{
			return ((Model_Bridge)(this._Reset()));
		}
		
		/// <summary>新規リソース作成用のオブジェクトを用意します。
		/// 
		/// 返り値のオブジェクトにパラメータを設定し、save() を呼ぶことで実際のリソースが作成されます。
		/// 
		/// <returns>リソースオブジェクト</returns>
		/// </summary>
		public Bridge Create()
		{
			return ((Bridge)(this._Create()));
		}
		
		/// <summary>指定したIDを持つ唯一のリソースを取得します。
		/// 
		/// <param name="id" />
		/// <returns>リソースオブジェクト</returns>
		/// </summary>
		public Bridge GetById(string id)
		{
			return ((Bridge)(this._GetById(id)));
		}
		
		/// <summary>リソースの検索リクエストを実行し、結果をリストで取得します。
		/// 
		/// <returns>リソースオブジェクトの配列</returns>
		/// </summary>
		public System.Collections.Generic.List<Bridge> Find()
		{
			return Util.CastArray(this._Find(), ((Bridge)(null)));
		}
		
		/// <summary>指定した文字列を名前に含むリソースに絞り込みます。
		/// 
		/// 大文字・小文字は区別されません。
		/// 半角スペースで区切られた複数の文字列は、それらをすべて含むことが条件とみなされます。
		/// 
		/// 
		/// <param name="name" />
		/// </summary>
		public Model_Bridge WithNameLike(string name)
		{
			return ((Model_Bridge)(this._WithNameLike(name)));
		}
		
		/// <summary>名前でソートします。
		/// 
		/// 
		/// <param name="reverse" />
		/// </summary>
		public Model_Bridge SortByName(bool reverse=false)
		{
			return ((Model_Bridge)(this._SortByName(reverse)));
		}
		
		public Model_Bridge(Client client) : base(client)
		{
			/*!base!*/;
		}
		
	}
	
}
