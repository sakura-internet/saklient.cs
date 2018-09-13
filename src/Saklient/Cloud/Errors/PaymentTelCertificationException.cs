using HttpPaymentRequiredException = Saklient.Errors.HttpPaymentRequiredException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求を受け付けできません。電話認証を先に実行してください。
	/// </summary>
	public class PaymentTelCertificationException : HttpPaymentRequiredException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public PaymentTelCertificationException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求を受け付けできません。電話認証を先に実行してください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
