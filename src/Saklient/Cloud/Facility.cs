using Util = Saklient.Util;
using Model_Region = Saklient.Cloud.Models.Model_Region;
using Client = Saklient.Cloud.Client;

namespace Saklient.Cloud
{

	/// <summary>設備情報にアクセスするためのモデルを集めたクラス。
	/// </summary>
	public class Facility
	{
		
		internal Model_Region _Region;
		
		internal Model_Region Get_region()
		{
			return this._Region;
		}
		
		/// <summary>リージョン情報。
		/// </summary>
		public Model_Region Region
		{
			get { return this.Get_region(); }
		}

        /// <summary>
        /// </summary>
        /// <param name="client" />
        public Facility(Client client)
		{
			this._Region = new Model_Region(client);
		}
		
	}
	
}
