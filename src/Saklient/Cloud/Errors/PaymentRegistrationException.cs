using HttpPaymentRequiredException = Saklient.Errors.HttpPaymentRequiredException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求を受け付けできません。支払情報が未登録です。会員メニューから支払、クレジットカードの情報を登録してください
	 */
	class PaymentRegistrationException : HttpPaymentRequiredException
	{
		
		/**
		 * @member saklient.cloud.errors.PaymentRegistrationException#DefaultMessage
		 * @default "要求を受け付けできません。支払情報が未登録です。会員メニューから支払、クレジットカードの情報を登録してください"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求を受け付けできません。支払情報が未登録です。会員メニューから支払、クレジットカードの情報を登録してください";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public PaymentRegistrationException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
