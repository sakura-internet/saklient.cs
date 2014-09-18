using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * 対象が見つかりません。対象は利用できない状態か、IDまたはパスに誤りがあります。
	 */
	public class HttpNotFoundException : HttpException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpNotFoundException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "対象が見つかりません。対象は利用できない状態か、IDまたはパスに誤りがあります。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
