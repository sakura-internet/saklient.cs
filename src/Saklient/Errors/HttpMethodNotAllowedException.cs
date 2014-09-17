using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * 要求されたHTTPメソッドは対応していません。
	 */
	class HttpMethodNotAllowedException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpMethodNotAllowedException#DefaultMessage
		 * @default "要求されたHTTPメソッドは対応していません。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求されたHTTPメソッドは対応していません。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpMethodNotAllowedException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
