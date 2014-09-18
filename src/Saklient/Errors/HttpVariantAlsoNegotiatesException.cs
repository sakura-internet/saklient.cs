using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Variant Also Negotiates.
	 */
	public class HttpVariantAlsoNegotiatesException : HttpException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpVariantAlsoNegotiatesException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Variant Also Negotiates." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
