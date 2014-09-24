using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Model = Saklient.Cloud.Models.Model;
using Iface = Saklient.Cloud.Resources.Iface;

namespace Saklient.Cloud.Models
{

	/// <summary>インタフェースを検索・作成するための機能を備えたクラス。
	/// </summary>
	public class Model_Iface : Model
	{
		
		internal override string _ApiPath()
		{
			return "/interface";
		}
		
		internal override string _RootKey()
		{
			return "Interface";
		}
		
		internal override string _RootKeyM()
		{
			return "Interfaces";
		}
		
		internal override string _ClassName()
		{
			return "Iface";
		}
		
		/// <summary>次に取得するリストの開始オフセットを指定します。
		/// 
		/// <param name="offset">オフセット</param>
		/// <returns>this</returns>
		/// </summary>
		public Model_Iface Offset(long offset)
		{
			return ((Model_Iface)(this._Offset(offset)));
		}
		
		/// <summary>次に取得するリストの上限レコード数を指定します。
		/// 
		/// <param name="count">上限レコード数</param>
		/// <returns>this</returns>
		/// </summary>
		public Model_Iface Limit(long count)
		{
			return ((Model_Iface)(this._Limit(count)));
		}
		
		/// <summary>Web APIのフィルタリング設定を直接指定します。
		/// 
		/// <param name="key">キー</param>
		/// <param name="value">値</param>
		/// <param name="multiple">valueに配列を与え、OR条件で完全一致検索する場合にtrueを指定します。通常、valueはスカラ値であいまい検索されます。</param>
		/// </summary>
		public Model_Iface FilterBy(string key, object value, bool multiple=false)
		{
			return ((Model_Iface)(this._FilterBy(key, value, multiple)));
		}
		
		/// <summary>次のリクエストのために設定されているステートをすべて破棄します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Model_Iface Reset()
		{
			return ((Model_Iface)(this._Reset()));
		}
		
		/// <summary>新規リソース作成用のオブジェクトを用意します。
		/// 
		/// 返り値のオブジェクトにパラメータを設定し、save() を呼ぶことで実際のリソースが作成されます。
		/// 
		/// <returns>リソースオブジェクト</returns>
		/// </summary>
		public Iface Create()
		{
			return ((Iface)(this._Create()));
		}
		
		/// <summary>指定したIDを持つ唯一のリソースを取得します。
		/// 
		/// <param name="id" />
		/// <returns>リソースオブジェクト</returns>
		/// </summary>
		public Iface GetById(string id)
		{
			return ((Iface)(this._GetById(id)));
		}
		
		/// <summary>リソースの検索リクエストを実行し、結果をリストで取得します。
		/// 
		/// <returns>リソースオブジェクトの配列</returns>
		/// </summary>
		public System.Collections.Generic.List<Iface> Find()
		{
			return Util.CastArray(this._Find(), ((Iface)(null)));
		}
		
		public Model_Iface(Client client) : base(client)
		{
			/*!base!*/;
		}
		
	}
	
}
