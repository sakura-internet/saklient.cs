using HttpPaymentRequiredException = Saklient.Errors.HttpPaymentRequiredException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求を受け付けできません。電話認証を先に実行してください。
	 */
	class PaymentTelCertificationException : HttpPaymentRequiredException
	{
		
		/**
		 * @member saklient.cloud.errors.PaymentTelCertificationException#DefaultMessage
		 * @default "要求を受け付けできません。電話認証を先に実行してください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求を受け付けできません。電話認証を先に実行してください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public PaymentTelCertificationException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
