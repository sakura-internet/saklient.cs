using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/**
	 * サービスが利用できません。ストレージが問題が発生している可能性があります。このエラーが繰り返し発生する場合は、メンテナンス情報、サポートサイトをご確認ください。
	 */
	class StorageAbnormalException : HttpServiceUnavailableException
	{
		
		/**
		 * @member saklient.cloud.errors.StorageAbnormalException#DefaultMessage
		 * @default "サービスが利用できません。ストレージが問題が発生している可能性があります。このエラーが繰り返し発生する場合は、メンテナンス情報、サポートサイトをご確認ください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "サービスが利用できません。ストレージが問題が発生している可能性があります。このエラーが繰り返し発生する場合は、メンテナンス情報、サポートサイトをご確認ください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public StorageAbnormalException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
