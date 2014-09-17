using HttpNotFoundException = Saklient.Errors.HttpNotFoundException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 対象が見つかりません。パスに誤りがあります。
	 */
	class ResourcePathNotFoundException : HttpNotFoundException
	{
		
		/**
		 * @member saklient.cloud.errors.ResourcePathNotFoundException#DefaultMessage
		 * @default "対象が見つかりません。パスに誤りがあります。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "対象が見つかりません。パスに誤りがあります。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ResourcePathNotFoundException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
