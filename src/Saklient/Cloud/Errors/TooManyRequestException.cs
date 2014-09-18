using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求を受け付けできません。リクエストの密度が高すぎます。
	 */
	public class TooManyRequestException : HttpServiceUnavailableException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public TooManyRequestException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求を受け付けできません。リクエストの密度が高すぎます。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
