using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求を受け付けできません。ゾーン内リソース数上限により、リソースの割り当てに失敗しました。
	/// </summary>
	public class LimitCountInZoneException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public LimitCountInZoneException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求を受け付けできません。ゾーン内リソース数上限により、リソースの割り当てに失敗しました。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
