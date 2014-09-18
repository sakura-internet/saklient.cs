using HttpNotFoundException = Saklient.Errors.HttpNotFoundException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 対象が見つかりません。パスに使用できない文字が含まれています。
	 */
	public class InvalidUriArgumentException : HttpNotFoundException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public InvalidUriArgumentException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "対象が見つかりません。パスに使用できない文字が含まれています。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
