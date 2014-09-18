using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。現在のアカウントで使用している全てのリソースを削除した後に実行してください。
	 */
	public class DeleteResB4AccountException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DeleteResB4AccountException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。現在のアカウントで使用している全てのリソースを削除した後に実行してください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
