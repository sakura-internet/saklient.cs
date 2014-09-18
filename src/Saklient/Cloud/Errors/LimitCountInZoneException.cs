using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求を受け付けできません。ゾーン内リソース数上限により、リソースの割り当てに失敗しました。
	 */
	public class LimitCountInZoneException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public LimitCountInZoneException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求を受け付けできません。ゾーン内リソース数上限により、リソースの割り当てに失敗しました。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
