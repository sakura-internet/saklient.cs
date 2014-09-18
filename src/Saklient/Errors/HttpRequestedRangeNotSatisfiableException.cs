using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Requested Range Not Satisfiable.
	 */
	public class HttpRequestedRangeNotSatisfiableException : HttpException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpRequestedRangeNotSatisfiableException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Requested Range Not Satisfiable." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
