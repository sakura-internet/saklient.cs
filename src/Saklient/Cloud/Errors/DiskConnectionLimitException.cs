using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。この接続インタフェースにこれ以上のディスクを接続することができません。
	 */
	public class DiskConnectionLimitException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DiskConnectionLimitException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。この接続インタフェースにこれ以上のディスクを接続することができません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
