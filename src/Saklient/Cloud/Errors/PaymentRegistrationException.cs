using HttpPaymentRequiredException = Saklient.Errors.HttpPaymentRequiredException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求を受け付けできません。支払情報が未登録です。会員メニューから支払、クレジットカードの情報を登録してください
	 */
	public class PaymentRegistrationException : HttpPaymentRequiredException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public PaymentRegistrationException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求を受け付けできません。支払情報が未登録です。会員メニューから支払、クレジットカードの情報を登録してください" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
