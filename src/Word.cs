
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ReadGhost.src
{
    public class Word
    {
        /// <summary>
        /// 删除熟词本中存在的单词
        /// </summary>
        /// <returns>熟词列表</returns>
        public static List<string> DeleteKownWord(List<string> temp)
        {
            List<string> words = new List<string>();
            string path = @"D:\Project\ReadGhost\Words\MyWords.txt";
            StreamReader streamReader = new StreamReader(path);
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                words.Add(line);
            }
            foreach (string word in words)
            {
                if (temp.Contains(word))
                {
                    temp.Remove(word);
                }
            }
            streamReader.Close();
            return temp;
        }
        /// <summary>
        /// 单词唯一化
        /// </summary>
        /// <param name="words">文章中的单词</param>
        /// <returns>唯一化后的单词</returns>
        public static List<string> DeleteRepeatWord(List<string> words)
        {
            List<string> singleWords = new List<string>();
            foreach (string word in words)
            {
                if (!singleWords.Contains(word))
                {
                    singleWords.Add(word);
                }
            }
            return singleWords;
        }
    }
}
