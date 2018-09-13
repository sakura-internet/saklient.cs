using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>HTTPエラー。Unprocessable Entity.
	/// </summary>
	public class HttpUnprocessableEntityException : HttpException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public HttpUnprocessableEntityException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "HTTPエラー。Unprocessable Entity." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
