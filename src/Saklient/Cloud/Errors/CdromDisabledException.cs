using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。ISOイメージが無効化されています。排出後に再度お試しください。
	 */
	class CdromDisabledException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.CdromDisabledException#DefaultMessage
		 * @default "要求された操作を行えません。ISOイメージが無効化されています。排出後に再度お試しください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。ISOイメージが無効化されています。排出後に再度お試しください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public CdromDisabledException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
