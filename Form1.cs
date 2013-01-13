using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ReadGhost.src;

namespace ReadGhost
{

    public partial class Form1 : Form
    {
        #region 公有属性
        public string page;
        public List<String> words = new List<string>();
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region 单击事件
        /// <summary>
        /// 将文章中可能是生词的单词选择出来
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_FindNewWords_Click(object sender, EventArgs e)
        {
            //保存用户输入的文章
            page = textBox_Page.Text.ToString().ToLower();
            //获得文章中的单词并绑定到listBox上
            words = Word.DeleteKownWord(Word.DeleteRepeatWord(Page.PageToWords(page)));
            //清空listBox
            listBox_NewWords.Items.Clear();
            //listBox_NewWords.Items.Clear();
            for (int x = 0; x < words.Count; x++)
            {
                listBox_NewWords.Items.Add(words[x]);
            }
            listBox_NewWords.EndUpdate();
        }

        /// <summary>
        /// 将选择的生词加入到生词本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddToBook_Click(object sender, EventArgs e)
        {
            List<string> words = new List<string>();
            int size = listBox_NewWords.SelectedItems.Count;
            for (int i = 0; i < size; i++)
            {
                words.Add(listBox_NewWords.SelectedItems[i].ToString());
            }
            textBox_Page.Text = words[0];
        }

        /// <summary>
        /// 使用微软翻译API翻译选择的生词
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_MSTranslate_Click(object sender, EventArgs e)
        {
            if (listBox_NewWords.SelectedItem == null)
            {
                MessageBox.Show("请选择要翻译的单词!");
            }
            else
            {
                string word = listBox_NewWords.SelectedItem.ToString();
                textBox_TranslateResult.Text = MicroSoftTranslateService.GetTranslateResult(word);
            }

        }
        /// <summary>
        /// 使用有道翻译API翻译选择的生词
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_YouDaoTranslate_Click(object sender, EventArgs e)
        {
            if (listBox_NewWords.SelectedItem == null)
            {
                MessageBox.Show("请选择要翻译的单词!");
            }
            else
            {
                string word = listBox_NewWords.SelectedItem.ToString();
                textBox_TranslateResult.Text = YouDaoTranslateService.GetTranslateResult(word);
            }

        }
        #endregion

        private void checkBox_SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_SelectAll.Checked)
            {
                for (int i = 0; i < listBox_NewWords.Items.Count; i++)
                {
                    listBox_NewWords.SetSelected(i, true);
                }
            }
            else
            {
                bool flag;
                for (int i = 0; i < listBox_NewWords.Items.Count; i++)
                {
                    flag = !listBox_NewWords.GetSelected(i);
                    listBox_NewWords.SetSelected(i, flag);
                }
            }
        }

    }
}
