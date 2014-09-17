using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。ルータには適用できません。
	 */
	class NotForRouterException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.NotForRouterException#DefaultMessage
		 * @default "要求された操作を行えません。ルータには適用できません。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。ルータには適用できません。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public NotForRouterException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
