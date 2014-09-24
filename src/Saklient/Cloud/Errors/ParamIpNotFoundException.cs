using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/// <summary>不適切な要求です。パラメータで指定されたIPアドレスを含むネットワークが存在しません。
	/// </summary>
	public class ParamIpNotFoundException : HttpBadRequestException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public ParamIpNotFoundException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "不適切な要求です。パラメータで指定されたIPアドレスを含むネットワークが存在しません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
