using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/**
	 * サービスが利用できません。ストレージの操作に失敗しました。サーバが混雑している可能性があります。
	 */
	class StorageOperationFailureException : HttpServiceUnavailableException
	{
		
		/**
		 * @member saklient.cloud.errors.StorageOperationFailureException#DefaultMessage
		 * @default "サービスが利用できません。ストレージの操作に失敗しました。サーバが混雑している可能性があります。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "サービスが利用できません。ストレージの操作に失敗しました。サーバが混雑している可能性があります。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public StorageOperationFailureException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
