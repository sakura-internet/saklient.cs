using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。このストレージには指定リソースの複製が既に存在します。
	 */
	public class ReplicaAlreadyExistsException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ReplicaAlreadyExistsException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。このストレージには指定リソースの複製が既に存在します。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
