using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class TextEditor : Form
    {
        private string fileName = "";

        public TextEditor()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void copyCtrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            SignUp signup = new SignUp();
            this.Hide();
            signup.Show();
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            AboutTextEditor aboutTextEditor = new AboutTextEditor();
            aboutTextEditor.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutTextEditor aboutTextEditor = new AboutTextEditor();
            aboutTextEditor.Show();
        }

        private void TextEditor_Load(object sender, EventArgs e)
        {
            userNameLabel.Text = "User Name: " + SignUp.GetUserAccount;

            string userType = SignUp.GetUserType;
            if (userType.Equals("View"))
            {
                this.newToolStripMenuItem.Enabled = false;
                this.saveCtrlSToolStripMenuItem.Enabled = false;
                this.saveToolStripMenuItem.Enabled = false;
                this.cutToolStripMenuItem.Enabled = false;
                this.copyCtrlToolStripMenuItem.Enabled = false;
                this.pasteToolStripMenuItem.Enabled = false;
                this.NewBtn.Enabled = false;
                this.SaveBtn.Enabled = false;
                this.SaveAsBtn.Enabled = false;
                this.BoldBtn.Enabled = false;
                this.ItalicBtn.Enabled = false;
                this.UnderlineBtn.Enabled = false;
                this.tb_FontSize.Enabled = false;
                this.CutBtn.Enabled = false;
                this.CopyBtn.Enabled = false;
                this.PasteBtn.Enabled = false;
                this.richTextBox1.Enabled = false;
                MessageBox.Show("You only have view access");
            }

            FontSize();
            //InstalledFonts();

        }

        private void ItalicBtn_Click(object sender, EventArgs e)
        {
            var originalFont = richTextBox1.SelectionFont;
            Font newFont;
            if (originalFont.Italic)
                newFont = new Font(originalFont, originalFont.Style & ~FontStyle.Italic);
            else
                newFont = new Font(originalFont, originalFont.Style | FontStyle.Italic);
            richTextBox1.SelectionFont = newFont;
        }

        private void BoldBtn_Click(object sender, EventArgs e)
        {
            var BoldFont = richTextBox1.SelectionFont;
            Font newFont;
            if (BoldFont.Bold)
                newFont = new Font(BoldFont, BoldFont.Style & ~FontStyle.Bold);
            else
                newFont = new Font(BoldFont, BoldFont.Style | FontStyle.Bold);
            richTextBox1.SelectionFont = newFont;
        }

        private void UnderlineBtn_Click(object sender, EventArgs e)
        {
            var oldFont = richTextBox1.SelectionFont;
            Font newFont;
            if (oldFont.Underline)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);
            richTextBox1.SelectionFont = newFont;
        }

        public void OpenFile()
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Title = "Open a Rich Text File";
                openFile.Filter = "Rich Text File (*.rtf)|";
                DialogResult dr = openFile.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string filename = openFile.FileName;
                    MessageBox.Show("File name open is:" + filename);
                    var sr = new StreamReader(openFile.FileName);
                    richTextBox1.LoadFile(filename);
                    sr.Close();
                    this.fileName = filename;
                }
            }
            catch
            {
                MessageBox.Show("Error when opening file!\nOnly .rtf files can be opened.\nPlease select another file");
                OpenFile();
            }
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            TextEditor textEditor = new TextEditor();
            this.Hide();
            textEditor.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextEditor textEditor = new TextEditor();
            this.Hide();
            textEditor.Show();
        }

        public void SaveFile()
        {
            if (fileName == "")
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Title = "Save a Rich Text File";
                saveFile.Filter = "Rich Text File (*.rtf)|";
                DialogResult dr1 = saveFile.ShowDialog();
                if (dr1 == DialogResult.OK)
                {
                    string filename = saveFile.FileName;
                    //StreamWriter sw = new StreamWriter(path);
                    //sw.WriteLine(richTextBox1.Text);
                    //sw.Close();
                    richTextBox1.SaveFile(filename);
                    this.fileName = filename;
                }
            }
            else
            {
                richTextBox1.SaveFile(this.fileName);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        public void SaveAsFile()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save a Rich Text File";
            saveFile.Filter = "Rich Text File (*.rtf)|";
            DialogResult dr1 = saveFile.ShowDialog();
            if (dr1 == DialogResult.OK)
            {
                string filename = saveFile.FileName;
                richTextBox1.SaveFile(filename);
            }
        }

        private void SaveAsBtn_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }

        public void Cut()
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.Cut();
            }
            else
            {
                MessageBox.Show("You cannot cut nothing!", "Error");
            }

        }
        public void Copy()
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.Copy();
            }
            else
            {
                MessageBox.Show("You cannot copy nothing!", "Error");
            }

        }
        public void Paste()
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                if (richTextBox1.SelectionLength > 0)
                {
                    if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                        richTextBox1.SelectionStart = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
                }
                richTextBox1.Paste();
                if (richTextBox1.SelectedText != "")
                {
                    richTextBox1.Paste();
                }
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void CutBtn_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void PasteBtn_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        void FontSize()
        {
            for (int fntSize = 8; fntSize <= 20; fntSize++)
            {
                tb_FontSize.Items.Add(fntSize.ToString());
            }
        }

        private void tb_FontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(tb_FontSize.SelectedItem.ToString(), int.Parse(tb_FontSize.SelectedItem.ToString()), richTextBox1.SelectionFont.Style);
        }

    }
}
