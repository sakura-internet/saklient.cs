using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求を受け付けできません。契約コードを発行することができません。メンテナンス情報、サポートサイトをご確認ください。
	 */
	class ContractCreationException : HttpServiceUnavailableException
	{
		
		/**
		 * @member saklient.cloud.errors.ContractCreationException#DefaultMessage
		 * @default "要求を受け付けできません。契約コードを発行することができません。メンテナンス情報、サポートサイトをご確認ください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求を受け付けできません。契約コードを発行することができません。メンテナンス情報、サポートサイトをご確認ください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ContractCreationException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
