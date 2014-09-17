using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。参照するリソースは同一ゾーンに存在しなければなりません。
	 */
	class MustBeOfSameZoneException : HttpBadRequestException
	{
		
		/**
		 * @member saklient.cloud.errors.MustBeOfSameZoneException#DefaultMessage
		 * @default "不適切な要求です。参照するリソースは同一ゾーンに存在しなければなりません。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "不適切な要求です。参照するリソースは同一ゾーンに存在しなければなりません。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public MustBeOfSameZoneException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
