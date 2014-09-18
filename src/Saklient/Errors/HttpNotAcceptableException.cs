using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * 要求を受け付けできません。サポートサイトやメンテナンス情報をご確認ください。
	 */
	public class HttpNotAcceptableException : HttpException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpNotAcceptableException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求を受け付けできません。サポートサイトやメンテナンス情報をご確認ください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
