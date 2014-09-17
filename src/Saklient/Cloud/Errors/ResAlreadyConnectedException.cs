using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。このリソースは他のリソースと既に接続されています。
	 */
	class ResAlreadyConnectedException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.ResAlreadyConnectedException#DefaultMessage
		 * @default "要求された操作を行えません。このリソースは他のリソースと既に接続されています。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。このリソースは他のリソースと既に接続されています。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ResAlreadyConnectedException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
