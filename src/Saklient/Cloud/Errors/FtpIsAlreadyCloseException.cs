using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。FTP共有は既に終了されています。
	 */
	public class FtpIsAlreadyCloseException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public FtpIsAlreadyCloseException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。FTP共有は既に終了されています。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
