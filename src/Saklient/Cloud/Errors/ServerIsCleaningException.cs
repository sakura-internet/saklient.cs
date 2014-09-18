using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。サーバが終了処理中です。しばらく時間をおいてから再度お試しください。
	 */
	public class ServerIsCleaningException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ServerIsCleaningException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。サーバが終了処理中です。しばらく時間をおいてから再度お試しください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
