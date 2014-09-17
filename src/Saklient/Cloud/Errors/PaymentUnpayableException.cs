using HttpPaymentRequiredException = Saklient.Errors.HttpPaymentRequiredException;

namespace Saklient.Cloud.Errors
{

	/**
	 * お客様のご都合により操作を受け付けることができません。
	 */
	class PaymentUnpayableException : HttpPaymentRequiredException
	{
		
		/**
		 * @member saklient.cloud.errors.PaymentUnpayableException#DefaultMessage
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
		public PaymentUnpayableException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
