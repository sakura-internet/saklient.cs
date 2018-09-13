using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。このリソースは他のリソースと既に接続されています。
	/// </summary>
	public class ResAlreadyConnectedException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public ResAlreadyConnectedException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作を行えません。このリソースは他のリソースと既に接続されています。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
