using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。テンプレートのFTP共有を終了後に実行してください。
	 */
	public class TemplateFtpIsOpenException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public TemplateFtpIsOpenException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。テンプレートのFTP共有を終了後に実行してください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
