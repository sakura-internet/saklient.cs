using HttpNotFoundException = Saklient.Errors.HttpNotFoundException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 対象が見つかりません。このストレージには指定リソースの複製が存在しません。
	 */
	class ReplicaNotFoundException : HttpNotFoundException
	{
		
		/**
		 * @member saklient.cloud.errors.ReplicaNotFoundException#DefaultMessage
		 * @default "対象が見つかりません。このストレージには指定リソースの複製が存在しません。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "対象が見つかりません。このストレージには指定リソースの複製が存在しません。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ReplicaNotFoundException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
