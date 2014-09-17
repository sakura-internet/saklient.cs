using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。ハイブリッド接続されているスイッチに対して、この操作はできません。
	 */
	class SwitchHybridConnectedException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.SwitchHybridConnectedException#DefaultMessage
		 * @default "要求された操作を行えません。ハイブリッド接続されているスイッチに対して、この操作はできません。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。ハイブリッド接続されているスイッチに対して、この操作はできません。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public SwitchHybridConnectedException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
