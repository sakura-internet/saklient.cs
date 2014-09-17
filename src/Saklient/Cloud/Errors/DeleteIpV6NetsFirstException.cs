using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。ルータを削除する前に、IPv6ネットワークの割当を解除してください。
	 */
	class DeleteIpV6NetsFirstException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.DeleteIpV6NetsFirstException#DefaultMessage
		 * @default "要求された操作を行えません。ルータを削除する前に、IPv6ネットワークの割当を解除してください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。ルータを削除する前に、IPv6ネットワークの割当を解除してください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DeleteIpV6NetsFirstException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
