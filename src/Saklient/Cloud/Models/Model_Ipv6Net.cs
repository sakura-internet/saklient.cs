using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Model = Saklient.Cloud.Models.Model;
using Resource = Saklient.Cloud.Resources.Resource;
using Ipv6Net = Saklient.Cloud.Resources.Ipv6Net;

namespace Saklient.Cloud.Models
{

	/// <summary>IPv6ネットワークを検索するための機能を備えたクラス。
	/// </summary>
	public class Model_Ipv6Net : Model
	{
		
		internal override string _ApiPath()
		{
			return "/ipv6net";
		}
		
		internal override string _RootKey()
		{
			return "IPv6Net";
		}
		
		internal override string _RootKeyM()
		{
			return "IPv6Nets";
		}
		
		internal override string _ClassName()
		{
			return "IPv6Net";
		}
		
		internal override Resource _CreateResourceImpl(object obj, bool wrapped=false)
		{
			return new Ipv6Net(this._Client, obj, wrapped);
		}
		
		/// <summary>次に取得するリストの開始オフセットを指定します。
		/// 
		/// <param name="offset">オフセット</param>
		/// <returns>this</returns>
		/// </summary>
		public Model_Ipv6Net Offset(long offset)
		{
			return ((Model_Ipv6Net)(this._Offset(offset)));
		}
		
		/// <summary>次に取得するリストの上限レコード数を指定します。
		/// 
		/// <param name="count">上限レコード数</param>
		/// <returns>this</returns>
		/// </summary>
		public Model_Ipv6Net Limit(long count)
		{
			return ((Model_Ipv6Net)(this._Limit(count)));
		}
		
		/// <summary>Web APIのフィルタリング設定を直接指定します。
		/// 
		/// <param name="key">キー</param>
		/// <param name="value">値</param>
		/// <param name="multiple">valueに配列を与え、OR条件で完全一致検索する場合にtrueを指定します。通常、valueはスカラ値であいまい検索されます。</param>
		/// </summary>
		public Model_Ipv6Net FilterBy(string key, object value, bool multiple=false)
		{
			return ((Model_Ipv6Net)(this._FilterBy(key, value, multiple)));
		}
		
		/// <summary>次のリクエストのために設定されているステートをすべて破棄します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Model_Ipv6Net Reset()
		{
			return ((Model_Ipv6Net)(this._Reset()));
		}
		
		/// <summary>指定したIDを持つ唯一のリソースを取得します。
		/// 
		/// <param name="id" />
		/// <returns>リソースオブジェクト</returns>
		/// </summary>
		public Ipv6Net GetById(string id)
		{
			return ((Ipv6Net)(this._GetById(id)));
		}
		
		/// <summary>リソースの検索リクエストを実行し、結果をリストで取得します。
		/// 
		/// <returns>リソースオブジェクトの配列</returns>
		/// </summary>
		public System.Collections.Generic.List<Ipv6Net> Find()
		{
			return Util.CastArray(this._Find(), ((Ipv6Net)(null)));
		}
		
		public Model_Ipv6Net(Client client) : base(client)
		{
			/*!base!*/;
		}
		
	}
	
}
