using HttpForbiddenException = Saklient.Errors.HttpForbiddenException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作は許可されていません。このAPIはユーザを特定できる認証方法でアクセスする必要があります。
	 */
	class UserNotSpecifiedException : HttpForbiddenException
	{
		
		/**
		 * @member saklient.cloud.errors.UserNotSpecifiedException#DefaultMessage
		 * @default "要求された操作は許可されていません。このAPIはユーザを特定できる認証方法でアクセスする必要があります。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作は許可されていません。このAPIはユーザを特定できる認証方法でアクセスする必要があります。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public UserNotSpecifiedException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
