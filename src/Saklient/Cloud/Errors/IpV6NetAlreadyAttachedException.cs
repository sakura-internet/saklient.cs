using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。ConnectedなIPv6ネットワークが既に割り当て済みです。
	/// </summary>
	public class IpV6NetAlreadyAttachedException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public IpV6NetAlreadyAttachedException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。ConnectedなIPv6ネットワークが既に割り当て済みです。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
