using HttpNotFoundException = Saklient.Errors.HttpNotFoundException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 対象が見つかりません。識別名から一意にリソースを特定できません。
	 */
	public class AmbiguousIdentifierException : HttpNotFoundException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public AmbiguousIdentifierException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "対象が見つかりません。識別名から一意にリソースを特定できません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
