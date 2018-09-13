using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>HTTPエラー。Gone.
	/// </summary>
	public class HttpGoneException : HttpException
	{

        /// <summary>
        /// </summary>
        /// <param name="status" />
        /// <param name="code" />
        /// <param name="message" />
        public HttpGoneException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Gone." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
