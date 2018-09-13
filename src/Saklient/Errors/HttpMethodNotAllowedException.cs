using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>要求されたHTTPメソッドは対応していません。
	/// </summary>
	public class HttpMethodNotAllowedException : HttpException
	{

        /// <summary>
        /// </summary>
        /// <param name="status" />
        /// <param name="code" />
        /// <param name="message" />
        public HttpMethodNotAllowedException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求されたHTTPメソッドは対応していません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
