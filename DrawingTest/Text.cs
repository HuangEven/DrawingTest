using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace DrawingTest
{
    public partial class Text : Form
    {
        private string path = "";
        private Thread timeThread;
        private bool isTextChanged;
        public Text()
        {
            InitializeComponent();
            //bm = new Bitmap(panel1.Width, panel1.Height);
        }

        private void Text_Load(object sender, EventArgs e)
        {
            //初始化，撤销、剪切、复制、删除 不可用
            撤销ToolStripMenuItem.Enabled = false;
            剪切ToolStripMenuItem.Enabled = false;
            复制ToolStripMenuItem.Enabled = false;
            删除ToolStripMenuItem.Enabled = false;

            if (richTextBox.Equals(""))
            {
                查找ToolStripMenuItem.Enabled = false;
                查找下一个ToolStripMenuItem.Enabled = false;
            }
            else
            {
                查找ToolStripMenuItem.Enabled = true;
                查找下一个ToolStripMenuItem.Enabled = true;
            }

            if (Clipboard.ContainsText())
                粘贴ToolStripMenuItem.Enabled = true;
            else
                粘贴ToolStripMenuItem.Enabled = false;

            toolStripStatusLabel1.Text = "第 1 行，第 1 列";
            timeThread = new Thread(new ThreadStart(flash));
            timeThread.Start();
        }

        private void flash()
        {
            while(true)
            {
                toolStripStatusLabel2.Text = "   当前时间:" + DateTime.Now.ToString();
                Thread.Sleep(1000);
            }
        }

        private void 页面设置_Click(object sender, EventArgs e)
        {
            this.pageSetupDialog1.Document = this.printDocument1;
            pageSetupDialog1.ShowDialog();
        }

        #region 文件

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //如果输入框文字发生变动
            if (isTextChanged)
            {
                saveFileDialog1.FileName = "*.txt";
                DialogResult dr = MessageBox.Show("是否将更改保存到 " + this.Text + "?", "记事本",
                    MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    //获取或设置指定要在 SaveFileDialog 中显示的文件类型和说明的筛选器字符串
                    saveFileDialog1.Filter = @"文本文档(*.txt)|*.txt|所有格式|*.txt;*.doc;*.cs;*.rtf;*.sln";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                        richTextBox.Text = "";
                        path = "";
                    }
                }
                else if (dr == DialogResult.No)
                {
                    richTextBox.Text = "";
                    path = "";
                }
            }
            else
            {
                richTextBox.Text = "";
                this.Text = "无标题 - 记事本";
                path = "";
            }
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            isTextChanged = true;
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isTextChanged)
            {
                saveFileDialog1.FileName = "*.txt";
                DialogResult dr = MessageBox.Show("是否将更改保存到 " + this.Text + "?", "记事本",
                    MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    //获取或设置指定要在 SaveFileDialog 中显示的文件类型和说明的筛选器字符串
                    saveFileDialog1.Filter = @"文本文档(*.txt)|*.txt|所有格式|*.txt;*.doc;*.cs;*.rtf;*.sln";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                        Text = saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.LastIndexOf("\\") + 1) +
                            " - 记事本";
                    }
                }
            }

            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                Text = path.Substring(path.LastIndexOf("\\") + 1) + " - 记事本";
                Console.WriteLine("path={0}", path);
                richTextBox.LoadFile(path, RichTextBoxStreamType.PlainText);
                isTextChanged = false;
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(path == ""))
            {
                richTextBox.SaveFile(path, RichTextBoxStreamType.PlainText);
                isTextChanged = false;
            }
            else
            {
                saveFileDialog1.Filter = @"文本文档(*.txt)|*.txt|所有格式|*.txt;*.doc;*.cs;*.rtf;*.sln";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    path = saveFileDialog1.FileName;
                    this.Text = path.Substring(path.LastIndexOf("\\") + 1) + " - 记事本";
                    isTextChanged = false;
                }
            }
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = @"文本文档(*.txt)|*.txt|所有格式|*.txt;*.doc;*.cs;*.rtf;*.sln";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                path = saveFileDialog1.FileName;
                this.Text = path.Substring(path.LastIndexOf("\\") + 1) + " - 记事本";
                isTextChanged = false;
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 退出时应提示用户是否保存当前文本文件
            DialogResult result = MessageBox.Show("是否将更改保存？", "温馨提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                if (!(path == ""))
                {
                    richTextBox.SaveFile(path, RichTextBoxStreamType.PlainText);
                    isTextChanged = false;
                }
                else
                {
                    saveFileDialog1.Filter = @"文本文档(*.txt)|*.txt|所有格式|*.txt;*.doc;*.cs;*.rtf;*.sln";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                        path = saveFileDialog1.FileName;
                        this.Text = path.Substring(path.LastIndexOf("\\") + 1) + " - 记事本";
                        isTextChanged = false;
                    }
                }
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        #endregion
        #region 编辑
        //热键设置
        private void 编辑EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.CanUndo)
                撤销ToolStripMenuItem.Enabled = true;

            if (richTextBox.SelectionLength > 0)
            {
                剪切ToolStripMenuItem.Enabled = true;
                复制ToolStripMenuItem.Enabled = true;
                删除ToolStripMenuItem.Enabled = true;
            }
            else
            {
                剪切ToolStripMenuItem.Enabled = false;
                复制ToolStripMenuItem.Enabled = false;
                删除ToolStripMenuItem.Enabled = false;
            }

            if (richTextBox.Equals(""))
            {
                查找ToolStripMenuItem.Enabled = false;
                查找下一个ToolStripMenuItem.Enabled = false;
            }
            else
            {
                查找ToolStripMenuItem.Enabled = true;
                查找下一个ToolStripMenuItem.Enabled = true;
            }

            if (Clipboard.ContainsText())
                粘贴ToolStripMenuItem.Enabled = true;
            else
                粘贴ToolStripMenuItem.Enabled = false;
        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Undo();
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectedText = "";
        }

        private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Owner = this;
            search.Show();
        }

        private void 查找下一个ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Owner = this;
            search.Show();
        }

        private void 替换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change change = new Change();
            change.Owner = this;
            change.Show();
        }

        private void 转到ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Goto gt = new Goto();
            gt.Owner = this;
            gt.Show();
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
        }

        private void 时间日期ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string front = richTextBox.Text.Substring(0, richTextBox.SelectionStart);
            string back = richTextBox.Text.Substring(richTextBox.SelectionStart,
                richTextBox.Text.Length - richTextBox.SelectionStart);
            richTextBox.Text = front + DateTime.Now.ToString() + back;
        }

        #endregion
        #region 格式

        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.WordWrap)
            {
                自动换行ToolStripMenuItem.Checked = false;
                richTextBox.WordWrap = false;
            }
            else
            {
                自动换行ToolStripMenuItem.Checked = true;
                richTextBox.WordWrap = true;
            }
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox.SelectionFont = fontDialog1.Font;
        }
        #endregion

        private void 状态栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (状态栏ToolStripMenuItem.Checked)
            {
                状态栏ToolStripMenuItem.Checked = false;
                statusStrip1.Visible = false;
            }
            else
            {
                状态栏ToolStripMenuItem.Checked = true;
                statusStrip1.Visible = true;
            }
        }

        private void richTextBox_SelectionChanged(object sender,EventArgs e)
        {
            string[] str = richTextBox.Text.Split('\r', '\n');
            int row = 1, column = 1, pos = richTextBox.SelectionStart;

            foreach (string s in str)
                Console.WriteLine(s);
            Console.WriteLine("pos={0}", pos);

            for (int i = 0; i < str.Length && pos - str[i].Length > 0; i++)
            {
                pos = pos - str[i].Length - 1;
                row = i + 2;
            }
            column = pos + 1;
            toolStripStatusLabel1.Text = "第 " + row + " 行，第 " + column + " 列   ";
        }
    }
}
