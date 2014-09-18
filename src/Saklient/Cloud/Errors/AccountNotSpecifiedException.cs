using HttpForbiddenException = Saklient.Errors.HttpForbiddenException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作は許可されていません。このAPIはアカウントを特定できる認証方法でアクセスする必要があります。
	 */
	public class AccountNotSpecifiedException : HttpForbiddenException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public AccountNotSpecifiedException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作は許可されていません。このAPIはアカウントを特定できる認証方法でアクセスする必要があります。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
