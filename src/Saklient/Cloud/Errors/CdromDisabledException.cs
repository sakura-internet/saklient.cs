using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。ISOイメージが無効化されています。排出後に再度お試しください。
	 */
	public class CdromDisabledException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public CdromDisabledException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。ISOイメージが無効化されています。排出後に再度お試しください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
