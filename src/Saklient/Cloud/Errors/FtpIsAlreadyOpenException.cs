using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。FTP共有は既に開始されています。
	 */
	public class FtpIsAlreadyOpenException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public FtpIsAlreadyOpenException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。FTP共有は既に開始されています。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
