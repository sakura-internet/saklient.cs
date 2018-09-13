using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>HTTPエラー。Unprocessable Entity.
	/// </summary>
	public class HttpUnprocessableEntityException : HttpException
	{

        /// <summary>
        /// </summary>
        /// <param name="status" />
        /// <param name="code" />
        /// <param name="message" />
        public HttpUnprocessableEntityException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Unprocessable Entity." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
