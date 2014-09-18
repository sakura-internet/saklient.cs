using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。リソースが既に存在するか、リソース同士が既に関連付けられています。
	 */
	public class DuplicateEntryException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DuplicateEntryException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。リソースが既に存在するか、リソース同士が既に関連付けられています。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
