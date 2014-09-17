using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。このディスク または このディスクのスナップショットから他のリソースへのコピー処理が進行中です。完了後に再度お試しください。
	 */
	class DiskOrSsInMigrationException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.DiskOrSsInMigrationException#DefaultMessage
		 * @default "要求された操作を行えません。このディスク または このディスクのスナップショットから他のリソースへのコピー処理が進行中です。完了後に再度お試しください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。このディスク または このディスクのスナップショットから他のリソースへのコピー処理が進行中です。完了後に再度お試しください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DiskOrSsInMigrationException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
