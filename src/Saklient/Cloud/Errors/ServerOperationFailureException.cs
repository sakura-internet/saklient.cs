using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/**
	 * サービスが利用できません。サーバの操作に失敗しました。
	 */
	public class ServerOperationFailureException : HttpServiceUnavailableException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ServerOperationFailureException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "サービスが利用できません。サーバの操作に失敗しました。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
