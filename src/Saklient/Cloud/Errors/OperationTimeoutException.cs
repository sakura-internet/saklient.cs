using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/**
	 * サービスが利用できません。操作がタイムアウトしました。サーバが混雑している可能性があります。
	 */
	public class OperationTimeoutException : HttpServiceUnavailableException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public OperationTimeoutException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "サービスが利用できません。操作がタイムアウトしました。サーバが混雑している可能性があります。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
