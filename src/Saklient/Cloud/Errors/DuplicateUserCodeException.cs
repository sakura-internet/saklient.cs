using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。同一ユーザ名で複数のユーザを作成することはできません。
	 */
	class DuplicateUserCodeException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.DuplicateUserCodeException#DefaultMessage
		 * @default "要求された操作を行えません。同一ユーザ名で複数のユーザを作成することはできません。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。同一ユーザ名で複数のユーザを作成することはできません。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DuplicateUserCodeException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
