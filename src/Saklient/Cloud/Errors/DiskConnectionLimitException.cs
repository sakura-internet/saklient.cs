using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。この接続インタフェースにこれ以上のディスクを接続することができません。
	 */
	class DiskConnectionLimitException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.DiskConnectionLimitException#DefaultMessage
		 * @default "要求された操作を行えません。この接続インタフェースにこれ以上のディスクを接続することができません。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。この接続インタフェースにこれ以上のディスクを接続することができません。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DiskConnectionLimitException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
