using HttpPaymentRequiredException = Saklient.Errors.HttpPaymentRequiredException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求を受け付けできません。電話認証を先に実行してください。
	 */
	public class PaymentTelCertificationException : HttpPaymentRequiredException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public PaymentTelCertificationException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求を受け付けできません。電話認証を先に実行してください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
