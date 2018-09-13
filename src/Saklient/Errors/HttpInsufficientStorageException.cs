using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>HTTPエラー。Insufficient Storage.
	/// </summary>
	public class HttpInsufficientStorageException : HttpException
	{

        /// <summary>
        /// </summary>
        /// <param name="status" />
        /// <param name="code" />
        /// <param name="message" />
        public HttpInsufficientStorageException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Insufficient Storage." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
