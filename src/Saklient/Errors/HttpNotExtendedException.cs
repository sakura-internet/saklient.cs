using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>HTTPエラー。Not Extended.
	/// </summary>
	public class HttpNotExtendedException : HttpException
	{

        /// <summary>
        /// </summary>
        /// <param name="status" />
        /// <param name="code" />
        /// <param name="message" />
        public HttpNotExtendedException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Not Extended." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
