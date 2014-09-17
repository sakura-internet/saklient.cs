using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。このIDのリソースは既に存在します。
	 */
	class ResAlreadyExistsException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.ResAlreadyExistsException#DefaultMessage
		 * @default "要求された操作を行えません。このIDのリソースは既に存在します。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。このIDのリソースは既に存在します。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ResAlreadyExistsException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
