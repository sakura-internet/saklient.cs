using HttpForbiddenException = Saklient.Errors.HttpForbiddenException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作は許可されていません。このゾーンではこの操作は禁止されています。他のゾーンでお試しください。
	 */
	class DisabledInSandboxException : HttpForbiddenException
	{
		
		/**
		 * @member saklient.cloud.errors.DisabledInSandboxException#DefaultMessage
		 * @default "要求された操作は許可されていません。このゾーンではこの操作は禁止されています。他のゾーンでお試しください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作は許可されていません。このゾーンではこの操作は禁止されています。他のゾーンでお試しください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DisabledInSandboxException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
