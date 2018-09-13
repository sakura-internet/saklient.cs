using HttpPaymentRequiredException = Saklient.Errors.HttpPaymentRequiredException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求を受け付けできません。クレジットカードの使用期限、利用限度額をご確認ください。
	/// </summary>
	public class PaymentCreditCardException : HttpPaymentRequiredException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public PaymentCreditCardException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求を受け付けできません。クレジットカードの使用期限、利用限度額をご確認ください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
