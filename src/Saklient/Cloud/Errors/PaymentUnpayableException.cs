using HttpPaymentRequiredException = Saklient.Errors.HttpPaymentRequiredException;

namespace Saklient.Cloud.Errors
{

	/// <summary>お客様のご都合により操作を受け付けることができません。
	/// </summary>
	public class PaymentUnpayableException : HttpPaymentRequiredException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public PaymentUnpayableException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "お客様のご都合により操作を受け付けることができません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
