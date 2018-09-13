using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>要求された操作は許可されていません。権限エラー。
	/// </summary>
	public class HttpForbiddenException : HttpException
	{

        /// <summary>
        /// </summary>
        /// <param name="status" />
        /// <param name="code" />
        /// <param name="message" />
        public HttpForbiddenException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作は許可されていません。権限エラー。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
