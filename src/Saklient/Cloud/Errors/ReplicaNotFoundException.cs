using HttpNotFoundException = Saklient.Errors.HttpNotFoundException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 対象が見つかりません。このストレージには指定リソースの複製が存在しません。
	 */
	public class ReplicaNotFoundException : HttpNotFoundException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ReplicaNotFoundException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "対象が見つかりません。このストレージには指定リソースの複製が存在しません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
