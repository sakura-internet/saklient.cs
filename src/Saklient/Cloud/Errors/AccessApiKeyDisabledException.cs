using HttpForbiddenException = Saklient.Errors.HttpForbiddenException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作は許可されていません。APIキーによるアクセスはできません。
	 */
	public class AccessApiKeyDisabledException : HttpForbiddenException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public AccessApiKeyDisabledException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作は許可されていません。APIキーによるアクセスはできません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
