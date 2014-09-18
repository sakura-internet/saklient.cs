using HttpForbiddenException = Saklient.Errors.HttpForbiddenException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作は許可されていません。さくらインターネットの会員メニューより認証後に実行してください。
	 */
	public class AccessSakuraException : HttpForbiddenException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public AccessSakuraException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作は許可されていません。さくらインターネットの会員メニューより認証後に実行してください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
