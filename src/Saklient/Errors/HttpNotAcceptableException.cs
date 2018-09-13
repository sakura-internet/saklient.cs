using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>要求を受け付けできません。サポートサイトやメンテナンス情報をご確認ください。
	/// </summary>
	public class HttpNotAcceptableException : HttpException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public HttpNotAcceptableException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求を受け付けできません。サポートサイトやメンテナンス情報をご確認ください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
