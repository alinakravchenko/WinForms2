namespace WinForms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_chislo_Click(object sender, EventArgs e)
        {
            int min = 1, max = 2000;
            int tmp;
            for (int i = 1; ; i++)
            {
                tmp = (min + max) / 2;
                DialogResult res = MessageBox.Show($"Загаданное вами число {tmp}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    MessageBox.Show($"Потребовалось {i} запросов");
                    break;
                }
                else
                {
                    res = MessageBox.Show($"Загаданное вами число больше {tmp}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        min = tmp + 1;
                    }
                    else
                    {
                        max = tmp - 1;
                    }
                }
            }
        }
    }
}