using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * 不適切な要求です。パラメータの指定誤り、入力規則違反です。入力内容をご確認ください。
	 */
	public class HttpBadRequestException : HttpException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpBadRequestException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "不適切な要求です。パラメータの指定誤り、入力規則違反です。入力内容をご確認ください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
