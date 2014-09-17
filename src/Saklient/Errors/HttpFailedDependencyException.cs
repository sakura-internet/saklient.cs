using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Failed Dependency.
	 */
	class HttpFailedDependencyException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpFailedDependencyException#DefaultMessage
		 * @default "HTTPエラー。Failed Dependency."
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "HTTPエラー。Failed Dependency.";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpFailedDependencyException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
