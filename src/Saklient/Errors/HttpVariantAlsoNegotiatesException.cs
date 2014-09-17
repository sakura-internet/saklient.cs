using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Variant Also Negotiates.
	 */
	class HttpVariantAlsoNegotiatesException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpVariantAlsoNegotiatesException#DefaultMessage
		 * @default "HTTPエラー。Variant Also Negotiates."
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "HTTPエラー。Variant Also Negotiates.";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpVariantAlsoNegotiatesException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
