using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/// <summary>サービスが利用できません。ストレージの操作に失敗しました。サーバが混雑している可能性があります。
	/// </summary>
	public class StorageOperationFailureException : HttpServiceUnavailableException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public StorageOperationFailureException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "サービスが利用できません。ストレージの操作に失敗しました。サーバが混雑している可能性があります。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
