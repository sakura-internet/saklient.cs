using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。パラメータに含まれている値の範囲が一部不正です。
	 */
	class InvalidRangeException : HttpBadRequestException
	{
		
		/**
		 * @member saklient.cloud.errors.InvalidRangeException#DefaultMessage
		 * @default "不適切な要求です。パラメータに含まれている値の範囲が一部不正です。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "不適切な要求です。パラメータに含まれている値の範囲が一部不正です。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public InvalidRangeException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
