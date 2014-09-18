using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求を受け付けできません。アカウント数上限により作成失敗しました。
	 */
	public class LimitCountInMemberException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public LimitCountInMemberException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求を受け付けできません。アカウント数上限により作成失敗しました。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
