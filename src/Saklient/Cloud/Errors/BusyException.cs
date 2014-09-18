using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/**
	 * サービスが利用できません。サーバが混雑しています。しばらく時間をおいてから再度お試しください。
	 */
	public class BusyException : HttpServiceUnavailableException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public BusyException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "サービスが利用できません。サーバが混雑しています。しばらく時間をおいてから再度お試しください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
