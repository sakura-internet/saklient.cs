using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>サービスが利用できません。対象は利用できない、またはサーバが混雑しています。このエラーが繰り返し発生する場合は、メンテナンス情報、サポートサイトをご確認ください。
	/// </summary>
	public class HttpServiceUnavailableException : HttpException
	{

        /// <summary>
        /// </summary>
        /// <param name="status" />
        /// <param name="code" />
        /// <param name="message" />
        public HttpServiceUnavailableException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "サービスが利用できません。対象は利用できない、またはサーバが混雑しています。このエラーが繰り返し発生する場合は、メンテナンス情報、サポートサイトをご確認ください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
