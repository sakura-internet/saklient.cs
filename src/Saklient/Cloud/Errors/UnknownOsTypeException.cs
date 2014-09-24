using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/// <summary>サービスが利用できません。ディスクにインストールされたOSが特定できないため、正しく修正できません。
	/// </summary>
	public class UnknownOsTypeException : HttpServiceUnavailableException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public UnknownOsTypeException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "サービスが利用できません。ディスクにインストールされたOSが特定できないため、正しく修正できません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
