using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _09_Odie
{
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
        }

        private void newNote_Click(object sender, EventArgs e)
        {
            NotesForm notesForm = new NotesForm();
            notesForm.MdiParent = this;
            notesForm.Show();
        }

        private void open_Click(object sender, EventArgs e)
        {
            NotesForm newForm = new NotesForm();
            TextBox textBox = new TextBox();
            textBox.TabStop = false;

            string userSelectedFilePath = string.Empty;
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog(this) == DialogResult.OK)
            {
                userSelectedFilePath = openFile.FileName;
                newForm.TextContents = File.ReadAllText(userSelectedFilePath);
                newForm.MdiParent = this;
                newForm.Text = openFile.FileName;
                newForm.Show();
            }
            newForm.HasTextChanged = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text Files (*.txt)|*.txt";
            saveFile.DefaultExt = "txt";
            saveFile.AddExtension = true;
            string currentText = string.Empty;

            Form activeForm = ActiveMdiChild;
            if (activeForm != null)
            {
                TextBox textBox = (TextBox)activeForm.ActiveControl;
                if (textBox != null)
                {
                    currentText = textBox.Text;
                    if (saveFile.ShowDialog(this) == DialogResult.OK)
                    {
                        string savePath = saveFile.FileName;
                        using (StreamWriter streamWriter = File.CreateText(savePath))
                        {
                            streamWriter.WriteLine(currentText);
                            ActiveMdiChild.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("You must have an active notes form to save");
                return;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                NotesForm activeForm = (NotesForm)ActiveMdiChild;
                string currentText = string.Empty;

                if (activeForm.HasTextChanged == true)
                {
                    DialogResult askToSaveFile = MessageBox.Show("Would you like to save your changes?", "Save File", MessageBoxButtons.YesNo);
                    if (askToSaveFile == DialogResult.Yes)
                    {
                        save_Click(save, null);
                    }
                    else if (askToSaveFile == DialogResult.No)
                    {
                        this.Close();
                    }
                }
            }
            this.Close();
        }
    }
}
