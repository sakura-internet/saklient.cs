using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>HTTPエラー。Gone.
	/// </summary>
	public class HttpGoneException : HttpException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public HttpGoneException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "HTTPエラー。Gone." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
