using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>HTTPエラー。Precondition Failed.
	/// </summary>
	public class HttpPreconditionFailedException : HttpException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public HttpPreconditionFailedException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Precondition Failed." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
