using HttpForbiddenException = Saklient.Errors.HttpForbiddenException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作は許可されていません。このゾーンではこの操作は禁止されています。他のゾーンでお試しください。
	 */
	public class DisabledInSandboxException : HttpForbiddenException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DisabledInSandboxException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作は許可されていません。このゾーンではこの操作は禁止されています。他のゾーンでお試しください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
