using System;
using System.Collections.Generic;
using System.Text;

namespace ReadGhost.src
{
    public class Page
    {
        /// <summary>
        /// 将文章转化为单词
        /// </summary>
        /// <param name="page">英文文章</param>
        /// <returns>单词列表</returns>
        public static List<string> PageToWords(string page)
        {
            bool flag = false;
            List<char> temp = new List<char>();
            StringBuilder resultString = new StringBuilder();
            List<string> words = new List<string>();
            foreach (char c in page.ToCharArray())
            {
                if (Char.IsLetter(c))
                {
                    temp.Add(c);
                    flag = true;
                }
                else
                {
                    if (flag)
                    {
                        temp.Add('#');
                        flag = false;
                    }
                }
            }
            foreach (char w in temp)
            {
                resultString = resultString.Append(w);
            }
            foreach (string str in resultString.ToString().Split('#'))
            {
                words.Add(str);
            }
            return words;
        }
    }
}
