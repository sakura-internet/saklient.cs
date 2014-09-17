using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。現在のアカウントで使用している全てのリソースを削除した後に実行してください。
	 */
	class DeleteResB4AccountException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.DeleteResB4AccountException#DefaultMessage
		 * @default "要求された操作を行えません。現在のアカウントで使用している全てのリソースを削除した後に実行してください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。現在のアカウントで使用している全てのリソースを削除した後に実行してください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DeleteResB4AccountException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
