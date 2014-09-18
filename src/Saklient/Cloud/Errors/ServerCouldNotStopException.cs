using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/**
	 * サービスが利用できません。サーバを停止できません。再度お試しください。
	 */
	public class ServerCouldNotStopException : HttpServiceUnavailableException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ServerCouldNotStopException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "サービスが利用できません。サーバを停止できません。再度お試しください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
