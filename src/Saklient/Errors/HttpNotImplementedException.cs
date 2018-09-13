using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>HTTPエラー。Not Implemented.
	/// </summary>
	public class HttpNotImplementedException : HttpException
	{

        /// <summary>
        /// </summary>
        /// <param name="status" />
        /// <param name="code" />
        /// <param name="message" />
        public HttpNotImplementedException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Not Implemented." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
