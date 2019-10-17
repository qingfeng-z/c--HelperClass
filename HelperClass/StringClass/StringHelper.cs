
namespace HelperClass.StringClass
{
    #region region

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    #endregion

    /// <summary>
    /// The string helper.
    /// </summary>
    public static class StringHelper
    {
        /// <summary>
        /// 字符串反转
        /// </summary>
        /// <param name="str">
        /// The str.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string Reverse(this string str)
        {
            var arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        /// <summary>
        /// 把字符串按照分隔符转换成 List
        /// </summary>
        /// <param name="str">
        /// 源字符串.
        /// </param>
        /// <param name="c">
        /// 分隔符.
        /// </param>
        /// <param name="isToLower">
        /// 是否转换为小写.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public static List<string> GetStrList(string str, string c, bool isToLower)
        {
            var list = new List<string>();
            if (string.IsNullOrWhiteSpace(str)) return list;

            var strArr = str.Split(c);
            if (strArr[0] == str)
            {
                list.Add(strArr[0].StringToLower(isToLower));
                return list;
            }

            foreach (var s in strArr)
            {
                s.StringToLower(isToLower);
                list.Add(s.StringToLower(isToLower));
            }

            return list;
        }

        /// <summary>
        /// 把字符串按照分隔符转换成 List
        /// </summary>
        /// <param name="str">源字符串</param>
        /// <param name="speater">分隔符</param>
        /// <param name="toLower">是否转换为小写</param>
        /// <returns></returns>
        public static List<string> GetStrList(string str, string c)
        {
            return GetStrList(str, c, false);
        }

        /// <summary>
        /// 字符串是否小写
        /// </summary>
        /// <param name="str">
        /// 字符.
        /// </param>
        /// <param name="isToLower">
        /// 是否小写.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string StringToLower(this string str, bool isToLower)
        {
            return isToLower ? str.ToLower() : str;
        }

        /// <summary>
        /// 把 List<string> 按照分隔符组装成 string
        /// </summary>
        /// <param name="list"> 字符列表</param>
        /// <param name="str">分隔符</param>
        /// <returns></returns>
        public static string Tostring(this List<string> list, string str)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < list.Count; i++)
            {
                if (i != list.Count - 1)
                {
                    sb.Append(list[i]);
                    sb.Append(str);
                }
                else
                {
                    sb.Append(list[i]);
                }
            }

            return sb.ToString();
        }
    }
}
