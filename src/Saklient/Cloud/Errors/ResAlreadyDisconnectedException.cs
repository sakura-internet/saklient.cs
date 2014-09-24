using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。このリソースは既に切断されています。
	/// </summary>
	public class ResAlreadyDisconnectedException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public ResAlreadyDisconnectedException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。このリソースは既に切断されています。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
