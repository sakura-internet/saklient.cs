using HttpForbiddenException = Saklient.Errors.HttpForbiddenException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作は許可されていません。ゾーンをまたぐ一部のリソースは課金対象です。料金をご確認の上、他のゾーンで作成してください。
	 */
	class DontCreateInSandboxException : HttpForbiddenException
	{
		
		/**
		 * @member saklient.cloud.errors.DontCreateInSandboxException#DefaultMessage
		 * @default "要求された操作は許可されていません。ゾーンをまたぐ一部のリソースは課金対象です。料金をご確認の上、他のゾーンで作成してください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作は許可されていません。ゾーンをまたぐ一部のリソースは課金対象です。料金をご確認の上、他のゾーンで作成してください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DontCreateInSandboxException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
