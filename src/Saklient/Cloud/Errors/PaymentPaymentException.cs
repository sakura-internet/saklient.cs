using HttpPaymentRequiredException = Saklient.Errors.HttpPaymentRequiredException;

namespace Saklient.Cloud.Errors
{

	/**
	 * お客様のご都合により操作を受け付けることができません。
	 */
	class PaymentPaymentException : HttpPaymentRequiredException
	{
		
		/**
		 * @member saklient.cloud.errors.PaymentPaymentException#DefaultMessage
		 * @default "お客様のご都合により操作を受け付けることができません。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "お客様のご都合により操作を受け付けることができません。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public PaymentPaymentException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
