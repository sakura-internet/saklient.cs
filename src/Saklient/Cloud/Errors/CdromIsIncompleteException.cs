using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。このISOイメージは不完全です。複製処理等の完了後に再度お試しください。
	 */
	class CdromIsIncompleteException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.CdromIsIncompleteException#DefaultMessage
		 * @default "要求された操作を行えません。このISOイメージは不完全です。複製処理等の完了後に再度お試しください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。このISOイメージは不完全です。複製処理等の完了後に再度お試しください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public CdromIsIncompleteException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
