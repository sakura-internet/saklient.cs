using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。指定されたネットワークに属するIPアドレスはすべて使用中です。
	/// </summary>
	public class RunOutOfIpAddressException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public RunOutOfIpAddressException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。指定されたネットワークに属するIPアドレスはすべて使用中です。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
