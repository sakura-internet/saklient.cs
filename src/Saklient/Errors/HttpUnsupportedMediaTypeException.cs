using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>HTTPエラー。Unsupported Media Type.
	/// </summary>
	public class HttpUnsupportedMediaTypeException : HttpException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public HttpUnsupportedMediaTypeException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "HTTPエラー。Unsupported Media Type." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
