using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。起動中のサーバが収容されているハイパーバイザとパケットフィルタのバージョンが合致しません。コントロールパネルまたはAPIからの操作によりサーバを一旦停止し、再度起動後にお試しください。
	/// </summary>
	public class PacketFilterVersionMismatchException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public PacketFilterVersionMismatchException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。起動中のサーバが収容されているハイパーバイザとパケットフィルタのバージョンが合致しません。コントロールパネルまたはAPIからの操作によりサーバを一旦停止し、再度起動後にお試しください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
