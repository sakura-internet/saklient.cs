using HttpPaymentRequiredException = Saklient.Errors.HttpPaymentRequiredException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求を受け付けできません。クレジットカードの使用期限、利用限度額をご確認ください。
	 */
	public class PaymentCreditCardException : HttpPaymentRequiredException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public PaymentCreditCardException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求を受け付けできません。クレジットカードの使用期限、利用限度額をご確認ください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
