using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/**
	 * サービスが利用できません。サーバを停止できません。再度お試しください。
	 */
	class ServerCouldNotStopException : HttpServiceUnavailableException
	{
		
		/**
		 * @member saklient.cloud.errors.ServerCouldNotStopException#DefaultMessage
		 * @default "サービスが利用できません。サーバを停止できません。再度お試しください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "サービスが利用できません。サーバを停止できません。再度お試しください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ServerCouldNotStopException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
