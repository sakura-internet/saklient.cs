using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。複数のインタフェースから同一のスイッチに接続することはできません。
	 */
	class ConnectToSameSwitchException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.ConnectToSameSwitchException#DefaultMessage
		 * @default "要求された操作を行えません。複数のインタフェースから同一のスイッチに接続することはできません。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。複数のインタフェースから同一のスイッチに接続することはできません。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ConnectToSameSwitchException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
