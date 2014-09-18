namespace Saklient.Errors
{

	/**
	 * @module saklient.errors.HttpException
	 * @class HttpException
	 * @constructor
	 * @extends System.Exception
	 */
	public class HttpException : System.Exception
	{
		
		/**
		 * @member saklient.errors.HttpException#Status
		 * @type long
		 * @public
		 */
		public long Status;
		
		/**
		 * @member saklient.errors.HttpException#Code
		 * @type string
		 * @public
		 */
		public string Code;
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpException(long status, string code=null, string message="") : base(message)
		{
			/*!base!*/;
			this.Status = status;
			this.Code = code;
		}
		
	}
	
}
