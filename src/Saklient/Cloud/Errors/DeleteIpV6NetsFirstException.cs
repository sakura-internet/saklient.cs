using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。ルータを削除する前に、IPv6ネットワークの割当を解除してください。
	 */
	public class DeleteIpV6NetsFirstException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DeleteIpV6NetsFirstException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。ルータを削除する前に、IPv6ネットワークの割当を解除してください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
