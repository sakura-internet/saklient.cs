using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>HTTPエラー。Requested Range Not Satisfiable.
	/// </summary>
	public class HttpRequestedRangeNotSatisfiableException : HttpException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public HttpRequestedRangeNotSatisfiableException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "HTTPエラー。Requested Range Not Satisfiable." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
