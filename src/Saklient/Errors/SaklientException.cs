namespace Saklient.Errors
{

	/**
	 * @module saklient.errors.SaklientException
	 * @class SaklientException
	 * @constructor
	 * @extends System.Exception
	 */
	public class SaklientException : System.Exception
	{
		
		/**
		 * @member saklient.errors.SaklientException#Code
		 * @type string
		 * @public
		 */
		public string Code;
		
		/**
		 * @constructor
		 * @public
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public SaklientException(string code=null, string message="") : base(message)
		{
			/*!base!*/;
			this.Code = code;
		}
		
	}
	
}
