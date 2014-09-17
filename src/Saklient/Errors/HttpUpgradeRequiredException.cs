using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Upgrade Required.
	 */
	class HttpUpgradeRequiredException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpUpgradeRequiredException#DefaultMessage
		 * @default "HTTPエラー。Upgrade Required."
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "HTTPエラー。Upgrade Required.";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpUpgradeRequiredException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
