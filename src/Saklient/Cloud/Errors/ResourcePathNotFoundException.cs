using HttpNotFoundException = Saklient.Errors.HttpNotFoundException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 対象が見つかりません。パスに誤りがあります。
	 */
	public class ResourcePathNotFoundException : HttpNotFoundException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ResourcePathNotFoundException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "対象が見つかりません。パスに誤りがあります。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
