using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。リソースが既に存在するか、リソース同士が既に関連付けられています。
	/// </summary>
	public class DuplicateEntryException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public DuplicateEntryException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。リソースが既に存在するか、リソース同士が既に関連付けられています。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
