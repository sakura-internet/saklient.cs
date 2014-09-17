using HttpForbiddenException = Saklient.Errors.HttpForbiddenException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作は許可されていません。権限エラー。
	 */
	class AccessStaffException : HttpForbiddenException
	{
		
		/**
		 * @member saklient.cloud.errors.AccessStaffException#DefaultMessage
		 * @default "要求された操作は許可されていません。権限エラー。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作は許可されていません。権限エラー。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public AccessStaffException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
