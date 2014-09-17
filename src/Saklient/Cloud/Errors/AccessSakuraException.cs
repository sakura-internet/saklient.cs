using HttpForbiddenException = Saklient.Errors.HttpForbiddenException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作は許可されていません。さくらインターネットの会員メニューより認証後に実行してください。
	 */
	class AccessSakuraException : HttpForbiddenException
	{
		
		/**
		 * @member saklient.cloud.errors.AccessSakuraException#DefaultMessage
		 * @default "要求された操作は許可されていません。さくらインターネットの会員メニューより認証後に実行してください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作は許可されていません。さくらインターネットの会員メニューより認証後に実行してください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public AccessSakuraException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
