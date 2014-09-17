using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web.Script.Serialization;

namespace Saklient {
	
	using Hash = Dictionary<string, object>;
	
	public class Util
	{

		private static JavaScriptSerializer serializer = new JavaScriptSerializer();

		public static object DecodeJson(string json)
		{
			return serializer.Deserialize<Hash>(json);
		}

		public static string EncodeJson(object obj)
		{
			return serializer.Serialize(obj);
		}
		
		public static bool ExistsPath(object obj, string path)
		{
			string[] aPath = path.Split('.');
			foreach (string key in aPath)
			{
				if (obj == null) return false;
				if (key == "") continue;
				if (Regex.IsMatch(key, @"^\d+$"))
				{
					int idx = Convert.ToInt32(key);
					ArrayList arr = obj as ArrayList;
					if (arr==null || arr.Count <= idx) return false;
					obj = arr[idx];
				}
				else
				{
					Hash dic = obj as Hash;
					if (dic==null || !dic.ContainsKey(key)) return false;
					obj = dic[key];
				}
			}
			return true;
		}

		public static object GetByPath(object obj, string path)
		{
			string[] aPath = path.Split('.');
			foreach (string key in aPath)
			{
				if (obj == null) return null;
				if (key == "") continue;
				if (Regex.IsMatch(key, @"^\d+$"))
				{
					int idx = Convert.ToInt32(key);
					ArrayList arr = obj as ArrayList;
					if (arr==null || arr.Count <= idx) return null;
					obj = arr[idx];
				}
				else
				{
					Hash dic = obj as Hash;
					if (dic==null || !dic.ContainsKey(key)) return null;
					obj = dic[key];
				}
			}
			return obj;
		}

		public static void SetByPath(object obj, string path, object value)
		{
			string[] aPath = path.Split('.');
			int n = aPath.Length;
			while (0 < n && aPath[n-1] == "") n--;
			for (int i=0; i<n; i++)
			{
				string key = aPath[i];
				if (key == "") continue;
				if (Regex.IsMatch(key, @"^\d+$"))
				{
					int idx = Convert.ToInt32(key);
					ArrayList arr = obj as ArrayList;
					if (i==n-1) arr[idx] = value; else obj = arr[idx];
				}
				else
				{
					Hash dic = obj as Hash;
					if (i==n-1)
					{
						dic[key] = value;
					}
					else
					{
						if (!dic.ContainsKey(key))
						{
							bool isNum = Regex.IsMatch(aPath[i+1], @"^\d+$");
							dic[key] = isNum ? (object)(new ArrayList {}) : (object)(new Hash {});
						}
						obj = dic[key];
					}
				}
			}
		}
		
		public static object CreateClassInstance(string classPath, object[] args)
		{
			return Activator.CreateInstance(Type.GetType(classPath), args);
		}

		public static DateTime Str2date(string s)
		{
			return DateTime.Parse(s);
		}

		public static string Date2str(DateTime? d)
		{
			return d==null ? null : ((DateTime)d).ToString("s");
		}
		
		public static string UrlEncode(string s)
		{
			return Uri.EscapeDataString(s);
		}

		public static void Sleep(int sec)
		{
			Thread.Sleep(1000 * sec);
		}

		public static void ValidateArgCount(int actual, int expected)
		{
		}

		public static void ValidateType(object value, string typeName, bool force=false)
		{
		}
		
		public static U[] CastArray<T, U>(T[] a, U dummy)
		{
			U[] ret = new U[a.Length];
			a.CopyTo(ret, 0);
			return ret;
		}
		
		public static string[] DictionaryKeys(dynamic d)
		{
			var dict = d as System.Collections.Generic.Dictionary<string, object>;
			string[] ret = new string[dict.Keys.Count];
			dict.Keys.CopyTo(ret, 0);
			return ret;
		}
		
	}
	
}
