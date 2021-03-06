using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/// <summary>サービスが利用できません。操作に失敗しました。サーバが混雑している可能性があります。
	/// </summary>
	public class OperationFailureException : HttpServiceUnavailableException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public OperationFailureException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "サービスが利用できません。操作に失敗しました。サーバが混雑している可能性があります。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
