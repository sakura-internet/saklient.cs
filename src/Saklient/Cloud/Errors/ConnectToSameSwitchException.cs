using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。複数のインタフェースから同一のスイッチに接続することはできません。
	/// </summary>
	public class ConnectToSameSwitchException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public ConnectToSameSwitchException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作を行えません。複数のインタフェースから同一のスイッチに接続することはできません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
