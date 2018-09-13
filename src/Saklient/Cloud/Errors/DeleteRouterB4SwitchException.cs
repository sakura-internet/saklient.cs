using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。ルータを削除することでスイッチは同時に削除されます。
	/// </summary>
	public class DeleteRouterB4SwitchException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public DeleteRouterB4SwitchException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作を行えません。ルータを削除することでスイッチは同時に削除されます。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
