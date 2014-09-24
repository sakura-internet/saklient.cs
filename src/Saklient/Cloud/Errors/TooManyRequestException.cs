using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求を受け付けできません。リクエストの密度が高すぎます。
	/// </summary>
	public class TooManyRequestException : HttpServiceUnavailableException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public TooManyRequestException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求を受け付けできません。リクエストの密度が高すぎます。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
