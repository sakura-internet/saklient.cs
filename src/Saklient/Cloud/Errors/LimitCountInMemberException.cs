using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求を受け付けできません。アカウント数上限により作成失敗しました。
	/// </summary>
	public class LimitCountInMemberException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public LimitCountInMemberException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求を受け付けできません。アカウント数上限により作成失敗しました。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
