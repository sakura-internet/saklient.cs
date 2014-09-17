using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。サーバと接続された状態では変更できない値が含まれています。
	 */
	class DisconnectB4UpdateException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.DisconnectB4UpdateException#DefaultMessage
		 * @default "要求された操作を行えません。サーバと接続された状態では変更できない値が含まれています。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。サーバと接続された状態では変更できない値が含まれています。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DisconnectB4UpdateException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
