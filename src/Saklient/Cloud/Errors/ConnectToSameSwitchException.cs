using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。複数のインタフェースから同一のスイッチに接続することはできません。
	 */
	public class ConnectToSameSwitchException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ConnectToSameSwitchException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。複数のインタフェースから同一のスイッチに接続することはできません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
