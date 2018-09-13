using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。ルータを削除する前に、IPv6ネットワークの割当を解除してください。
	/// </summary>
	public class DeleteIpV6NetsFirstException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public DeleteIpV6NetsFirstException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作を行えません。ルータを削除する前に、IPv6ネットワークの割当を解除してください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
