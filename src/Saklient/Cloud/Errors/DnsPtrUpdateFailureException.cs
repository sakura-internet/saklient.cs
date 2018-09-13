using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/// <summary>サービスが利用できません。PTRレコードを設定できません。
	/// </summary>
	public class DnsPtrUpdateFailureException : HttpServiceUnavailableException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public DnsPtrUpdateFailureException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "サービスが利用できません。PTRレコードを設定できません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
