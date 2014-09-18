using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。ハイブリッド接続されているスイッチに対して、この操作はできません。
	 */
	public class SwitchHybridConnectedException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public SwitchHybridConnectedException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。ハイブリッド接続されているスイッチに対して、この操作はできません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
