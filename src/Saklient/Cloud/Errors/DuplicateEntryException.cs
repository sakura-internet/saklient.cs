using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。リソースが既に存在するか、リソース同士が既に関連付けられています。
	 */
	class DuplicateEntryException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.DuplicateEntryException#DefaultMessage
		 * @default "要求された操作を行えません。リソースが既に存在するか、リソース同士が既に関連付けられています。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。リソースが既に存在するか、リソース同士が既に関連付けられています。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DuplicateEntryException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
