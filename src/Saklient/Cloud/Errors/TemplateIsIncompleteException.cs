using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。このテンプレートは不完全です。複製処理等の完了後に再度お試しください。
	 */
	public class TemplateIsIncompleteException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public TemplateIsIncompleteException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。このテンプレートは不完全です。複製処理等の完了後に再度お試しください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
