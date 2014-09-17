using HttpForbiddenException = Saklient.Errors.HttpForbiddenException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作は許可されていません。APIキーによるアクセスはできません。
	 */
	class AccessApiKeyDisabledException : HttpForbiddenException
	{
		
		/**
		 * @member saklient.cloud.errors.AccessApiKeyDisabledException#DefaultMessage
		 * @default "要求された操作は許可されていません。APIキーによるアクセスはできません。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作は許可されていません。APIキーによるアクセスはできません。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public AccessApiKeyDisabledException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
