using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。同一ゾーン内の他のリソースが既にこのリソースを使用中です。
	 */
	class ResUsedInZoneException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.ResUsedInZoneException#DefaultMessage
		 * @default "要求された操作を行えません。同一ゾーン内の他のリソースが既にこのリソースを使用中です。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。同一ゾーン内の他のリソースが既にこのリソースを使用中です。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ResUsedInZoneException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
