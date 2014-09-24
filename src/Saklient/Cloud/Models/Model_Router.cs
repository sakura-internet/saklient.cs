using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Model = Saklient.Cloud.Models.Model;
using Router = Saklient.Cloud.Resources.Router;

namespace Saklient.Cloud.Models
{

	/// <summary>ルータを検索するための機能を備えたクラス。
	/// </summary>
	public class Model_Router : Model
	{
		
		internal override string _ApiPath()
		{
			return "/internet";
		}
		
		internal override string _RootKey()
		{
			return "Internet";
		}
		
		internal override string _RootKeyM()
		{
			return "Internet";
		}
		
		internal override string _ClassName()
		{
			return "Router";
		}
		
		/// <summary>次に取得するリストの開始オフセットを指定します。
		/// 
		/// <param name="offset">オフセット</param>
		/// <returns>this</returns>
		/// </summary>
		public Model_Router Offset(long offset)
		{
			return ((Model_Router)(this._Offset(offset)));
		}
		
		/// <summary>次に取得するリストの上限レコード数を指定します。
		/// 
		/// <param name="count">上限レコード数</param>
		/// <returns>this</returns>
		/// </summary>
		public Model_Router Limit(long count)
		{
			return ((Model_Router)(this._Limit(count)));
		}
		
		/// <summary>Web APIのフィルタリング設定を直接指定します。
		/// 
		/// <param name="key">キー</param>
		/// <param name="value">値</param>
		/// <param name="multiple">valueに配列を与え、OR条件で完全一致検索する場合にtrueを指定します。通常、valueはスカラ値であいまい検索されます。</param>
		/// </summary>
		public Model_Router FilterBy(string key, object value, bool multiple=false)
		{
			return ((Model_Router)(this._FilterBy(key, value, multiple)));
		}
		
		/// <summary>次のリクエストのために設定されているステートをすべて破棄します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Model_Router Reset()
		{
			return ((Model_Router)(this._Reset()));
		}
		
		/// <summary>新規リソース作成用のオブジェクトを用意します。
		/// 
		/// 返り値のオブジェクトにパラメータを設定し、save() を呼ぶことで実際のリソースが作成されます。
		/// 
		/// <returns>リソースオブジェクト</returns>
		/// </summary>
		public Router Create()
		{
			return ((Router)(this._Create()));
		}
		
		/// <summary>指定したIDを持つ唯一のリソースを取得します。
		/// 
		/// <param name="id" />
		/// <returns>リソースオブジェクト</returns>
		/// </summary>
		public Router GetById(string id)
		{
			return ((Router)(this._GetById(id)));
		}
		
		/// <summary>リソースの検索リクエストを実行し、結果をリストで取得します。
		/// 
		/// <returns>リソースオブジェクトの配列</returns>
		/// </summary>
		public System.Collections.Generic.List<Router> Find()
		{
			return Util.CastArray(this._Find(), ((Router)(null)));
		}
		
		/// <summary>指定した文字列を名前に含むリソースに絞り込みます。
		/// 
		/// 大文字・小文字は区別されません。
		/// 半角スペースで区切られた複数の文字列は、それらをすべて含むことが条件とみなされます。
		/// 
		/// 
		/// <param name="name" />
		/// </summary>
		public Model_Router WithNameLike(string name)
		{
			return ((Model_Router)(this._WithNameLike(name)));
		}
		
		/// <summary>名前でソートします。
		/// 
		/// 
		/// <param name="reverse" />
		/// </summary>
		public Model_Router SortByName(bool reverse=false)
		{
			return ((Model_Router)(this._SortByName(reverse)));
		}
		
		public Model_Router(Client client) : base(client)
		{
			/*!base!*/;
		}
		
		/// <summary>指定した帯域幅のルータに絞り込みます。
		/// 
		/// <param name="mbps" />
		/// </summary>
		public Model_Router WithBandWidthMbps(long mbps)
		{
			this._FilterBy("BandWidthMbps", new System.Collections.Generic.List<object> { mbps });
			return this;
		}
		
	}
	
}
