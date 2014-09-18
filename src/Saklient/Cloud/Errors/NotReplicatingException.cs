using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。このストレージ上への指定リソースの複製は実行されていません。
	 */
	public class NotReplicatingException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public NotReplicatingException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。このストレージ上への指定リソースの複製は実行されていません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
