using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Model = Saklient.Cloud.Models.Model;
using Resource = Saklient.Cloud.Resources.Resource;
using Region = Saklient.Cloud.Resources.Region;

namespace Saklient.Cloud.Models
{

	/// <summary>リージョンを検索するための機能を備えたクラス。
	/// </summary>
	public class Model_Region : Model
	{
		
		internal override string _ApiPath()
		{
			return "/region";
		}
		
		internal override string _RootKey()
		{
			return "Region";
		}
		
		internal override string _RootKeyM()
		{
			return "Regions";
		}
		
		internal override string _ClassName()
		{
			return "Region";
		}
		
		internal override Resource _CreateResourceImpl(object obj, bool wrapped=false)
		{
			return new Region(this._Client, obj, wrapped);
		}
		
		/// <summary>次に取得するリストの開始オフセットを指定します。
		/// 
		/// <param name="offset">オフセット</param>
		/// <returns>this</returns>
		/// </summary>
		public Model_Region Offset(long offset)
		{
			return ((Model_Region)(this._Offset(offset)));
		}
		
		/// <summary>次に取得するリストの上限レコード数を指定します。
		/// 
		/// <param name="count">上限レコード数</param>
		/// <returns>this</returns>
		/// </summary>
		public Model_Region Limit(long count)
		{
			return ((Model_Region)(this._Limit(count)));
		}
		
		/// <summary>Web APIのフィルタリング設定を直接指定します。
		/// 
		/// <param name="key">キー</param>
		/// <param name="value">値</param>
		/// <param name="multiple">valueに配列を与え、OR条件で完全一致検索する場合にtrueを指定します。通常、valueはスカラ値であいまい検索されます。</param>
		/// </summary>
		public Model_Region FilterBy(string key, object value, bool multiple=false)
		{
			return ((Model_Region)(this._FilterBy(key, value, multiple)));
		}
		
		/// <summary>次のリクエストのために設定されているステートをすべて破棄します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Model_Region Reset()
		{
			return ((Model_Region)(this._Reset()));
		}
		
		/// <summary>指定したIDを持つ唯一のリソースを取得します。
		/// 
		/// <param name="id" />
		/// <returns>リソースオブジェクト</returns>
		/// </summary>
		public Region GetById(string id)
		{
			return ((Region)(this._GetById(id)));
		}
		
		/// <summary>リソースの検索リクエストを実行し、結果をリストで取得します。
		/// 
		/// <returns>リソースオブジェクトの配列</returns>
		/// </summary>
		public System.Collections.Generic.List<Region> Find()
		{
			return Util.CastArray(this._Find(), ((Region)(null)));
		}
		
		/// <summary>指定した文字列を名前に含むリソースに絞り込みます。
		/// 
		/// 大文字・小文字は区別されません。
		/// 半角スペースで区切られた複数の文字列は、それらをすべて含むことが条件とみなされます。
		/// 
		/// 
		/// <param name="name" />
		/// </summary>
		public Model_Region WithNameLike(string name)
		{
			return ((Model_Region)(this._WithNameLike(name)));
		}
		
		/// <summary>名前でソートします。
		/// 
		/// 
		/// <param name="reverse" />
		/// </summary>
		public Model_Region SortByName(bool reverse=false)
		{
			return ((Model_Region)(this._SortByName(reverse)));
		}
		
		public Model_Region(Client client) : base(client)
		{
			/*!base!*/;
		}
		
	}
	
}
