using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。このストレージには指定リソースの複製が既に存在します。
	 */
	class ReplicaAlreadyExistsException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.ReplicaAlreadyExistsException#DefaultMessage
		 * @default "要求された操作を行えません。このストレージには指定リソースの複製が既に存在します。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。このストレージには指定リソースの複製が既に存在します。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ReplicaAlreadyExistsException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
