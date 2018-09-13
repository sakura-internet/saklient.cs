using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>HTTPエラー。Length Required.
	/// </summary>
	public class HttpLengthRequiredException : HttpException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public HttpLengthRequiredException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "HTTPエラー。Length Required." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
