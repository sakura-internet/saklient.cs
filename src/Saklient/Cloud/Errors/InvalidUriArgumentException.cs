using HttpNotFoundException = Saklient.Errors.HttpNotFoundException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 対象が見つかりません。パスに使用できない文字が含まれています。
	 */
	class InvalidUriArgumentException : HttpNotFoundException
	{
		
		/**
		 * @member saklient.cloud.errors.InvalidUriArgumentException#DefaultMessage
		 * @default "対象が見つかりません。パスに使用できない文字が含まれています。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "対象が見つかりません。パスに使用できない文字が含まれています。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public InvalidUriArgumentException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
