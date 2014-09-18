using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。ルータには適用できません。
	 */
	public class NotForRouterException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public NotForRouterException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。ルータには適用できません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
