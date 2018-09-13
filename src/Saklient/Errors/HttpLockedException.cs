using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>HTTPエラー。Locked.
	/// </summary>
	public class HttpLockedException : HttpException
	{

        /// <summary>
        /// </summary>
        /// <param name="status" />
        /// <param name="code" />
        /// <param name="message" />
        public HttpLockedException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Locked." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
