using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。サーバと接続された状態では変更できない値が含まれています。
	 */
	public class DisconnectB4UpdateException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DisconnectB4UpdateException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。サーバと接続された状態では変更できない値が含まれています。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
