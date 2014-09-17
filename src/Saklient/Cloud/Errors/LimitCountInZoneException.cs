using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求を受け付けできません。ゾーン内リソース数上限により、リソースの割り当てに失敗しました。
	 */
	class LimitCountInZoneException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.LimitCountInZoneException#DefaultMessage
		 * @default "要求を受け付けできません。ゾーン内リソース数上限により、リソースの割り当てに失敗しました。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求を受け付けできません。ゾーン内リソース数上限により、リソースの割り当てに失敗しました。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public LimitCountInZoneException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
