using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Model = Saklient.Cloud.Models.Model;
using Resource = Saklient.Cloud.Resources.Resource;
using License = Saklient.Cloud.Resources.License;

namespace Saklient.Cloud.Models
{

	/// <summary>ライセンスを検索・作成するための機能を備えたクラス。
	/// </summary>
	public class Model_License : Model
	{
		
		internal override string _ApiPath()
		{
			return "/license";
		}
		
		internal override string _RootKey()
		{
			return "License";
		}
		
		internal override string _RootKeyM()
		{
			return "Licenses";
		}
		
		internal override string _ClassName()
		{
			return "License";
		}
		
		internal override Resource _CreateResourceImpl(object obj, bool wrapped=false)
		{
			return new License(this._Client, obj, wrapped);
		}

        /// <summary>次に取得するリストの開始オフセットを指定します。
        /// </summary>
        /// <param name="offset">オフセット</param>
        /// <returns>this</returns>
        public Model_License Offset(long offset)
		{
			return ((Model_License)(this._Offset(offset)));
		}

        /// <summary>次に取得するリストの上限レコード数を指定します。
        /// </summary>
        /// <param name="count">上限レコード数</param>
        /// <returns>this</returns>
        public Model_License Limit(long count)
		{
			return ((Model_License)(this._Limit(count)));
		}

        /// <summary>Web APIのフィルタリング設定を直接指定します。
        /// </summary>
        /// <param name="key">キー</param>
        /// <param name="value">値</param>
        /// <param name="multiple">valueに配列を与え、OR条件で完全一致検索する場合にtrueを指定します。通常、valueはスカラ値であいまい検索されます。</param>
        public Model_License FilterBy(string key, object value, bool multiple=false)
		{
			return ((Model_License)(this._FilterBy(key, value, multiple)));
		}

        /// <summary>次のリクエストのために設定されているステートをすべて破棄します。
        /// </summary>
        /// <returns>this</returns>
        public Model_License Reset()
		{
			return ((Model_License)(this._Reset()));
		}

        /// <summary>新規リソース作成用のオブジェクトを用意します。
        /// 返り値のオブジェクトにパラメータを設定し、save() を呼ぶことで実際のリソースが作成されます。
        /// </summary>
        /// <returns>リソースオブジェクト</returns>
        public License Create()
		{
			return ((License)(this._Create()));
		}

        /// <summary>指定したIDを持つ唯一のリソースを取得します。
        /// </summary>
        /// <param name="id" />
        /// <returns>リソースオブジェクト</returns>
        public License GetById(string id)
		{
			return ((License)(this._GetById(id)));
		}

        /// <summary>リソースの検索リクエストを実行し、結果をリストで取得します。
        /// </summary>
        /// <returns>リソースオブジェクトの配列</returns>
        public System.Collections.Generic.List<License> Find()
		{
			return Util.CastArray(this._Find(), ((License)(null)));
		}

        /// <summary>指定した文字列を名前に含むリソースに絞り込みます。
        /// 大文字・小文字は区別されません。
        /// 半角スペースで区切られた複数の文字列は、それらをすべて含むことが条件とみなされます。
        /// </summary>
        /// <param name="name" />
        public Model_License WithNameLike(string name)
		{
			return ((Model_License)(this._WithNameLike(name)));
		}

        /// <summary>名前でソートします。
        /// </summary>
        /// <param name="reverse" />
        public Model_License SortByName(bool reverse=false)
		{
			return ((Model_License)(this._SortByName(reverse)));
		}
		
		public Model_License(Client client) : base(client)
		{
			/*!base!*/;
		}
		
	}
	
}
