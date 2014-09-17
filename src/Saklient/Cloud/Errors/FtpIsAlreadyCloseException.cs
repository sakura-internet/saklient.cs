using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。FTP共有は既に終了されています。
	 */
	class FtpIsAlreadyCloseException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.FtpIsAlreadyCloseException#DefaultMessage
		 * @default "要求された操作を行えません。FTP共有は既に終了されています。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。FTP共有は既に終了されています。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public FtpIsAlreadyCloseException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
