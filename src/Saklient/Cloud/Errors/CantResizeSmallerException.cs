using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。現在の容量よりも小さくリサイズすることはできません。
	 */
	class CantResizeSmallerException : HttpBadRequestException
	{
		
		/**
		 * @member saklient.cloud.errors.CantResizeSmallerException#DefaultMessage
		 * @default "不適切な要求です。現在の容量よりも小さくリサイズすることはできません。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "不適切な要求です。現在の容量よりも小さくリサイズすることはできません。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public CantResizeSmallerException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
