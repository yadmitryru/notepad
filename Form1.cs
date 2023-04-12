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

        // ���� ���� ������
        private void �����ToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Clear();

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }

        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

        // ���� ���� �����

        // ���� ������ ������
        private void ������ToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Undo();

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Cut();

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Copy();

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Paste();

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.SelectAll();

        // ���� ������ �����

        // ���� ������� ������
        private void �������ToolStripMenuItem_Click(object sender, EventArgs e) => MessageBox.Show("������� ��� ���� ��������", "� ���������", MessageBoxButtons.OK);

        // ���� ������� �����

    }
}