using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。サーバと接続された状態では変更できない値が含まれています。
	/// </summary>
	public class DisconnectB4UpdateException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public DisconnectB4UpdateException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作を行えません。サーバと接続された状態では変更できない値が含まれています。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
