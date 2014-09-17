using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。同一アカウント名で複数のアカウントを作成することはできません。
	 */
	class DuplicateAccountCodeException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.DuplicateAccountCodeException#DefaultMessage
		 * @default "要求された操作を行えません。同一アカウント名で複数のアカウントを作成することはできません。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。同一アカウント名で複数のアカウントを作成することはできません。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DuplicateAccountCodeException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
