using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。このストレージ上への指定リソースの複製は実行されていません。
	 */
	class NotReplicatingException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.NotReplicatingException#DefaultMessage
		 * @default "要求された操作を行えません。このストレージ上への指定リソースの複製は実行されていません。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。このストレージ上への指定リソースの複製は実行されていません。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public NotReplicatingException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
