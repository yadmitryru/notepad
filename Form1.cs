using System.Text;
using System.IO;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Меню Файл начало
        private void новыйToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Clear();

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

        // Меню Файл конец

        // Меню Правка начало
        private void отменаToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Undo();

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Cut();

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Copy();

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Paste();

        private void выделитьВсёToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.SelectAll();

        // Меню Правка конец

        // Меню Справка начало
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e) => MessageBox.Show("Блокнот для Даши Ширяевой", "О программе", MessageBoxButtons.OK);

        // Меню Справка конец

    }
}