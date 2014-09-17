using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/**
	 * サービスが利用できません。操作に失敗しました。サーバが混雑している可能性があります。
	 */
	class OperationFailureException : HttpServiceUnavailableException
	{
		
		/**
		 * @member saklient.cloud.errors.OperationFailureException#DefaultMessage
		 * @default "サービスが利用できません。操作に失敗しました。サーバが混雑している可能性があります。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "サービスが利用できません。操作に失敗しました。サーバが混雑している可能性があります。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public OperationFailureException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
