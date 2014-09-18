using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。同一ゾーン内の他のリソースが既にこのリソースを使用中です。
	 */
	public class ResUsedInZoneException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ResUsedInZoneException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。同一ゾーン内の他のリソースが既にこのリソースを使用中です。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
