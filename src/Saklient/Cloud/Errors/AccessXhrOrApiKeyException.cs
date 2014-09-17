using HttpForbiddenException = Saklient.Errors.HttpForbiddenException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作は許可されていません。XHRまたはAPIキーによるアクセスのみ許可されています。
	 */
	class AccessXhrOrApiKeyException : HttpForbiddenException
	{
		
		/**
		 * @member saklient.cloud.errors.AccessXhrOrApiKeyException#DefaultMessage
		 * @default "要求された操作は許可されていません。XHRまたはAPIキーによるアクセスのみ許可されています。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作は許可されていません。XHRまたはAPIキーによるアクセスのみ許可されています。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public AccessXhrOrApiKeyException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
