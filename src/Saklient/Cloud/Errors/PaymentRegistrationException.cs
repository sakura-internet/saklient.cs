using HttpPaymentRequiredException = Saklient.Errors.HttpPaymentRequiredException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求を受け付けできません。支払情報が未登録です。会員メニューから支払、クレジットカードの情報を登録してください
	/// </summary>
	public class PaymentRegistrationException : HttpPaymentRequiredException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public PaymentRegistrationException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求を受け付けできません。支払情報が未登録です。会員メニューから支払、クレジットカードの情報を登録してください" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
