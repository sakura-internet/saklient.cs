using HttpPaymentRequiredException = Saklient.Errors.HttpPaymentRequiredException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求を受け付けできません。クレジットカードの使用期限、利用限度額をご確認ください。
	 */
	class PaymentCreditCardException : HttpPaymentRequiredException
	{
		
		/**
		 * @member saklient.cloud.errors.PaymentCreditCardException#DefaultMessage
		 * @default "要求を受け付けできません。クレジットカードの使用期限、利用限度額をご確認ください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求を受け付けできません。クレジットカードの使用期限、利用限度額をご確認ください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public PaymentCreditCardException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
