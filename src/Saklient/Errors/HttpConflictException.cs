using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>要求された操作を行えません。現在の対象の状態では、この操作を受け付けできません。
	/// </summary>
	public class HttpConflictException : HttpException
	{

        /// <summary>
        /// </summary>
        /// <param name="status" />
        /// <param name="code" />
        /// <param name="message" />
        public HttpConflictException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。現在の対象の状態では、この操作を受け付けできません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
