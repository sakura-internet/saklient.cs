using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求を受け付けできません。ネットワーク内リソース数上限により、リソースの割り当てに失敗しました。
	/// </summary>
	public class LimitCountInNetworkException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public LimitCountInNetworkException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求を受け付けできません。ネットワーク内リソース数上限により、リソースの割り当てに失敗しました。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
