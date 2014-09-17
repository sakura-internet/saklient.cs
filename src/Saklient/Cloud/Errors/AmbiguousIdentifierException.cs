using HttpNotFoundException = Saklient.Errors.HttpNotFoundException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 対象が見つかりません。識別名から一意にリソースを特定できません。
	 */
	class AmbiguousIdentifierException : HttpNotFoundException
	{
		
		/**
		 * @member saklient.cloud.errors.AmbiguousIdentifierException#DefaultMessage
		 * @default "対象が見つかりません。識別名から一意にリソースを特定できません。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "対象が見つかりません。識別名から一意にリソースを特定できません。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public AmbiguousIdentifierException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
