using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>HTTPエラー。Variant Also Negotiates.
	/// </summary>
	public class HttpVariantAlsoNegotiatesException : HttpException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public HttpVariantAlsoNegotiatesException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "HTTPエラー。Variant Also Negotiates." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
