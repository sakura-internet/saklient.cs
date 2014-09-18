using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Failed Dependency.
	 */
	public class HttpFailedDependencyException : HttpException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpFailedDependencyException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Failed Dependency." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
