using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>HTTPエラー。Length Required.
	/// </summary>
	public class HttpLengthRequiredException : HttpException
	{

        /// <summary>
        /// </summary>
        /// <param name="status" />
        /// <param name="code" />
        /// <param name="message" />
        public HttpLengthRequiredException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Length Required." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
