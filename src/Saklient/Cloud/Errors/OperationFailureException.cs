using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/**
	 * サービスが利用できません。操作に失敗しました。サーバが混雑している可能性があります。
	 */
	public class OperationFailureException : HttpServiceUnavailableException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public OperationFailureException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "サービスが利用できません。操作に失敗しました。サーバが混雑している可能性があります。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
