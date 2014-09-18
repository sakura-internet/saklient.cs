using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。FTP共有によりアップロードされたファイルを操作できません。ファイル名等をご確認ください。
	 */
	public class FtpCannotCloseException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public FtpCannotCloseException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。FTP共有によりアップロードされたファイルを操作できません。ファイル名等をご確認ください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
