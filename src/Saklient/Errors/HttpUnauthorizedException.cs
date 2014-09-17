using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * この操作は認証が必要です。IDまたはパスワードが誤っている可能性があります。
	 */
	class HttpUnauthorizedException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpUnauthorizedException#DefaultMessage
		 * @default "この操作は認証が必要です。IDまたはパスワードが誤っている可能性があります。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "この操作は認証が必要です。IDまたはパスワードが誤っている可能性があります。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpUnauthorizedException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
