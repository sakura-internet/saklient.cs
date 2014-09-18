using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/**
	 * サービスが利用できません。サーバの画面が応答していません。
	 */
	public class NoDisplayResponseException : HttpServiceUnavailableException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public NoDisplayResponseException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "サービスが利用できません。サーバの画面が応答していません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
