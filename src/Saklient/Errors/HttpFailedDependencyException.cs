using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>HTTPエラー。Failed Dependency.
	/// </summary>
	public class HttpFailedDependencyException : HttpException
	{

        /// <summary>
        /// </summary>
        /// <param name="status" />
        /// <param name="code" />
        /// <param name="message" />
        public HttpFailedDependencyException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Failed Dependency." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
