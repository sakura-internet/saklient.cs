using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。起動中のサーバに対して変更されたパケットフィルタを反映するタスクが既に実行中です。
	/// </summary>
	public class PacketFilterApplyingException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public PacketFilterApplyingException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作を行えません。起動中のサーバに対して変更されたパケットフィルタを反映するタスクが既に実行中です。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
