using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。ハイブリッド接続されているスイッチに対して、この操作はできません。
	/// </summary>
	public class SwitchHybridConnectedException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public SwitchHybridConnectedException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。ハイブリッド接続されているスイッチに対して、この操作はできません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
