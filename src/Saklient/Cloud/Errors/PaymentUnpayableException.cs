using HttpPaymentRequiredException = Saklient.Errors.HttpPaymentRequiredException;

namespace Saklient.Cloud.Errors
{

	/**
	 * お客様のご都合により操作を受け付けることができません。
	 */
	public class PaymentUnpayableException : HttpPaymentRequiredException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public PaymentUnpayableException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "お客様のご都合により操作を受け付けることができません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
