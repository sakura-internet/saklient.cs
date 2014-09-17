using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/**
	 * サービスが利用できません。ディスクにインストールされたOSが特定できないため、正しく修正できません。
	 */
	class UnknownOsTypeException : HttpServiceUnavailableException
	{
		
		/**
		 * @member saklient.cloud.errors.UnknownOsTypeException#DefaultMessage
		 * @default "サービスが利用できません。ディスクにインストールされたOSが特定できないため、正しく修正できません。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "サービスが利用できません。ディスクにインストールされたOSが特定できないため、正しく修正できません。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public UnknownOsTypeException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
