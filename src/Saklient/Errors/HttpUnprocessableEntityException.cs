using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Unprocessable Entity.
	 */
	public class HttpUnprocessableEntityException : HttpException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpUnprocessableEntityException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Unprocessable Entity." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
