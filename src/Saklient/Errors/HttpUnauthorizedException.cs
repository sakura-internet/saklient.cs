using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * この操作は認証が必要です。IDまたはパスワードが誤っている可能性があります。
	 */
	public class HttpUnauthorizedException : HttpException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpUnauthorizedException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "この操作は認証が必要です。IDまたはパスワードが誤っている可能性があります。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
