namespace Saklient.Errors
{

	public class SaklientException : System.Exception
	{
		
		public string Code;

        /// <summary>
        /// </summary>
        /// <param name="code" />
        /// <param name="message" />
        public SaklientException(string code=null, string message="") : base(message)
		{
			/*!base!*/;
			this.Code = code;
		}
		
	}
	
}
