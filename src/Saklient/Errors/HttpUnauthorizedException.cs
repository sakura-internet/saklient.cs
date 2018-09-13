using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>この操作は認証が必要です。IDまたはパスワードが誤っている可能性があります。
	/// </summary>
	public class HttpUnauthorizedException : HttpException
	{

        /// <summary>
        /// </summary>
        /// <param name="status" />
        /// <param name="code" />
        /// <param name="message" />
        public HttpUnauthorizedException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "この操作は認証が必要です。IDまたはパスワードが誤っている可能性があります。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
