using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。FTP共有は既に開始されています。
	 */
	class FtpIsAlreadyOpenException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.FtpIsAlreadyOpenException#DefaultMessage
		 * @default "要求された操作を行えません。FTP共有は既に開始されています。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。FTP共有は既に開始されています。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public FtpIsAlreadyOpenException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
