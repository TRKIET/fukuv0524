namespace fukuv0524
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "とりん";
            label1.ForeColor = SystemColors.MenuHighlight;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Top = label1.Top - 20;
            label1.Text = "上";
            label1.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left - 20;
            label1.Text = "↓";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left + 20;
            label1.Text = "左クリック";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Top = label1.Top + 20;
            label1.Text = "右側";
        }
    }
}