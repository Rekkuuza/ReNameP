using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ReNameP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add(new { Key = 0, Value = "Delete Text" });
            comboBox1.Items.Add(new { Key = 1, Value = "Text Move to Last" });
            comboBox1.Items.Add(new { Key = 2, Value = "Text Move to Last Until Key Text" });
            comboBox1.DisplayMember = "Value";
            comboBox1.SelectedIndex = 0;
        }

        private void OpenFolder(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();

            var result = fbd.ShowDialog();

            if (result == DialogResult.OK)
            {

                listBox1.Items.Clear();
                listBox2.Items.Clear();

                textBox1.Text = fbd.SelectedPath;

                AddDataToListBox1();
            }
        }

        private void FindKeyWord(object sender, EventArgs e)
        {

            var t = textBox2.Text;

            var list = Directory.GetFiles(textBox1.Text);

            listBox1.Items.Clear();
            listBox2.Items.Clear();


            foreach (var (file, index) in list.Select((v, i) => (v, i)))
            {
                var newFileName = CreateNewFileName(file, t);

                if (newFileName != file)
                {
                    listBox1.Items.Add($"{index}\t{file}");
                    listBox2.Items.Add($"{index}\t{newFileName}");
                }
            }
        }


        string CreateNewFileName(string oldFileName, string targetText)
        {

            var newFileName = "";

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    newFileName = ReplaceText(oldFileName, targetText);
                    break;
                case 1:
                    newFileName = ReplaceTextToLast(oldFileName, targetText);
                    break;
                case 2:

                    newFileName = ReplaceTextUntilBrackets(oldFileName, targetText);

                    break;
            }

            return newFileName;
        }


        string ReplaceTextUntilBrackets(string oldFullFileName, string targetText)
        {
            if (string.IsNullOrEmpty(targetText))
            {
                return oldFullFileName;
            }


            if (!oldFullFileName.Contains(targetText))
            {
                return oldFullFileName;
            }

            var fileName = Path.GetFileName(oldFullFileName);

            if (fileName[0].ToString() == targetText)
            {
                return oldFullFileName;
            }

            while (fileName[0].ToString() != targetText)
            {
                fileName = fileName.Insert(fileName.LastIndexOf('.'), fileName[0].ToString());
                fileName = fileName.Remove(0, 1);
            }


            var dirct = Path.GetDirectoryName(oldFullFileName);

            if (dirct == null)
            {
                return oldFullFileName;
            }

            var newFileName = Path.Combine(dirct, fileName);
            return newFileName;
        }

        string ReplaceTextToLast(string oldFileName, string targetText)
        {
            if (string.IsNullOrEmpty(targetText))
            {
                return oldFileName;
            }

            if (!oldFileName.Contains(targetText))
            {
                return oldFileName;
            }

            var newFileName = oldFileName.Replace(targetText, "");


            var lastDot = newFileName.LastIndexOf('.');
            newFileName = newFileName.Insert(lastDot, targetText.Trim());

            return newFileName;
        }

        string ReplaceText(string oldFileName, string targetText)
        {

            if (string.IsNullOrEmpty(targetText))
            {
                return oldFileName;
            }

            if (!oldFileName.Contains(targetText))
            {
                return oldFileName;
            }



            var newFileName = oldFileName.Replace(targetText, "");

            newFileName = newFileName.Replace("\\ ", "\\");

            return newFileName;
        }


        private void ChangeFileName(object sender, EventArgs e)
        {
            var t = textBox2.Text;

            var list = Directory.GetFiles(textBox1.Text);

            foreach (var file in list)
            {

                var newFileName = CreateNewFileName(file, t);

                if (newFileName != file)
                {
                    System.IO.File.Move(file, newFileName);
                }
            }


            listBox1.Items.Clear();
            listBox2.Items.Clear();
            AddDataToListBox1();
        }

        private void Refresh(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            if (string.IsNullOrEmpty(textBox1.Text))
                return;

            AddDataToListBox1();
        }

        void AddDataToListBox1()
        {
            var files = Directory.GetFiles(textBox1.Text);
            foreach (var (fileName, index) in files.Select((v, i) => (v, i)))
            {
                listBox1.Items.Add($"{index}\t{fileName}");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 2)
            {
                textBox2.Text = "[";
            }
        }
    }
}