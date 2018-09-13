using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>HTTPエラー。Insufficient Storage.
	/// </summary>
	public class HttpInsufficientStorageException : HttpException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public HttpInsufficientStorageException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "HTTPエラー。Insufficient Storage." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
