using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web.Script.Serialization;
using System.Net;
using System.Linq;

namespace Saklient {
	
	using Hash = Dictionary<string, object>;
	
	public class Util
	{

		private static JavaScriptSerializer serializer = new JavaScriptSerializer();

		public static object DecodeJson(string json)
		{
			return ArrayList2List(serializer.Deserialize<Hash>(json));
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
					List<object> arr = obj as List<object>;
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
					List<object> arr = obj as List<object>;
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
		
		public static object GetByPathAny(System.Collections.Generic.List<object> objects, System.Collections.Generic.List<string> pathes) {
			foreach (object obj in objects)
			{
				foreach (string path in pathes)
				{
					object ret = GetByPath(obj, path);
					if (ret != null) return ret;
				}
			}
			return null;
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
					List<object> arr = obj as List<object>;
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
							dic[key] = isNum ? (object)(new List<object> {}) : (object)(new Hash {});
						}
						obj = dic[key];
					}
				}
			}
		}
		
		public static object CreateClassInstance(string classPath, System.Collections.Generic.List<object> args)
		{
			string[] aPath = classPath.Split('.');
			for (int i=0; i<aPath.Length; i++) {
				aPath[i] = aPath[i].Substring(0, 1).ToUpper() + aPath[i].Substring(1);
			}
			classPath = string.Join(".", aPath);
			//Console.WriteLine("[CreateClassInstance] " + classPath + " " + EncodeJson(args));
			object[] a = new object[args.Count];
			args.CopyTo(a);
			return Activator.CreateInstance(Type.GetType(classPath), a);
		}

		public static DateTime? Str2date(string s)
		{
			return (DateTime?)DateTime.Parse(s);
		}

		public static string Date2str(DateTime? d)
		{
			return d==null ? null : ((DateTime)d).ToString("s");
		}
		
		public static long Ip2long(string str)
		{
			if (!Regex.IsMatch(str, @"^\d+\.\d+\.\d+\.\d+$")) return -1;
			IPAddress ip;
			if (!IPAddress.TryParse(str, out ip)) return -1;
			Byte[] b = ip.GetAddressBytes();
			return ((long)b[0])<<24 | ((long)b[1])<<16 | ((long)b[2])<<8 | ((long)b[3]);
		}
		
		public static string Long2ip(long val)
		{
			IPAddress ip;
			if (!IPAddress.TryParse(((UInt32)(long)val).ToString(), out ip)) return null;
			return ip.ToString();
		}
		
		public static string UrlEncode(string s)
		{
			return Uri.EscapeDataString(s);
		}
		
		public static System.Collections.Generic.List<T> SortArray<T>(System.Collections.Generic.List<T> src) {
			var ret = new List<T>(src);
			ret.Sort();
			return ret;
		}
		
		public static void Sleep(long sec)
		{
			Thread.Sleep(System.Convert.ToInt32(1000 * sec));
		}

		public static void ValidateArgCount(long actual, long expected)
		{
		}

		public static void ValidateType(object value, string typeName, bool force=false)
		{
		}
		
		public static System.Collections.Generic.List<U> CastArray<T, U>(System.Collections.Generic.List<T> a, U dummy)
		{
			return a.ConvertAll(new Converter<T, U>((T x) => {return (U)(object)x;}));
//			System.Collections.Generic.List<U> ret = new System.Collections.Generic.List<U>();
//			foreach (var t in a) ret.Add((U)(object)t);
//			return ret;
		}
		
		public static System.Collections.Generic.List<string> DictionaryKeys(dynamic d)
		{
			var dict = d as System.Collections.Generic.Dictionary<string, object>;
			string[] ret = new string[dict.Keys.Count];
			dict.Keys.CopyTo(ret, 0);
			return new System.Collections.Generic.List<string>(ret);
		}
		
		public static object ArrayList2List(object obj)
		{
			if (obj is ArrayList) {
				var list = obj as ArrayList;
				var ret = new List<object>();
				for (int i=0; i<list.Count; i++) {
					ret.Add(ArrayList2List(list[i]));
				}
				return ret;
			}
			else if (obj is Dictionary<string, object>) {
				var dict = obj as Dictionary<string, object>;
				List<string> keys = DictionaryKeys(dict);
				foreach (string key in keys) {
					dict[key] = ArrayList2List(dict[key]);
				}
				return dict;
			}
			return obj;
		}
		
		public static T Pop<T>(System.Collections.Generic.List<T> a)
		{
			int i = a.Count - 1;
			if (i<0) return default(T);
			T ret = a[i];
			a.RemoveAt(i);
			return ret;
		}
		
	}
	
}
