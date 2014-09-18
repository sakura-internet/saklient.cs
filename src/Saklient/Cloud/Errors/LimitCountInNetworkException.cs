using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求を受け付けできません。ネットワーク内リソース数上限により、リソースの割り当てに失敗しました。
	 */
	public class LimitCountInNetworkException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public LimitCountInNetworkException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求を受け付けできません。ネットワーク内リソース数上限により、リソースの割り当てに失敗しました。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
