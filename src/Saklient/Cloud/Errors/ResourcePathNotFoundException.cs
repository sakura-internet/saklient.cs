using HttpNotFoundException = Saklient.Errors.HttpNotFoundException;

namespace Saklient.Cloud.Errors
{

	/// <summary>対象が見つかりません。パスに誤りがあります。
	/// </summary>
	public class ResourcePathNotFoundException : HttpNotFoundException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public ResourcePathNotFoundException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "対象が見つかりません。パスに誤りがあります。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
