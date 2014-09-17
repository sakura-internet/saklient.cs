using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。リソースのFTP共有を終了した後に実行してください。
	 */
	class FtpMustBeClosedException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.FtpMustBeClosedException#DefaultMessage
		 * @default "要求された操作を行えません。リソースのFTP共有を終了した後に実行してください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。リソースのFTP共有を終了した後に実行してください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public FtpMustBeClosedException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
