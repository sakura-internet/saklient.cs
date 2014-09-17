using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。自分自身をソースとするコピーはできません。
	 */
	class CopyToItselfException : HttpBadRequestException
	{
		
		/**
		 * @member saklient.cloud.errors.CopyToItselfException#DefaultMessage
		 * @default "不適切な要求です。自分自身をソースとするコピーはできません。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "不適切な要求です。自分自身をソースとするコピーはできません。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public CopyToItselfException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
