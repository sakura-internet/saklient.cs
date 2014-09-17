using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。このリソースは既に切断されています。
	 */
	class ResAlreadyDisconnectedException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.ResAlreadyDisconnectedException#DefaultMessage
		 * @default "要求された操作を行えません。このリソースは既に切断されています。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。このリソースは既に切断されています。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ResAlreadyDisconnectedException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
