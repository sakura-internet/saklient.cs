using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。このストレージには指定リソースの複製が既に存在します。
	/// </summary>
	public class ReplicaAlreadyExistsException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public ReplicaAlreadyExistsException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作を行えません。このストレージには指定リソースの複製が既に存在します。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
