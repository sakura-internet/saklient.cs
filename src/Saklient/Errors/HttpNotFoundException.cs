using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * 対象が見つかりません。対象は利用できない状態か、IDまたはパスに誤りがあります。
	 */
	class HttpNotFoundException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpNotFoundException#DefaultMessage
		 * @default "対象が見つかりません。対象は利用できない状態か、IDまたはパスに誤りがあります。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "対象が見つかりません。対象は利用できない状態か、IDまたはパスに誤りがあります。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpNotFoundException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
