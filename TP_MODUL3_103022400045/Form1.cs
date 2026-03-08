namespace TP_MODUL3_103022400045
{
    public partial class Form1 : Form
    {
        double total = 0;
        bool tambah = false;

        public Form1()
        {
            InitializeComponent();
            label1.Text = "";

            // event handler tombol angka
            button0.Click += Angka_Click;
            button1.Click += Angka_Click;
            button2.Click += Angka_Click;
            button3.Click += Angka_Click;
            button4.Click += Angka_Click;
            button5.Click += Angka_Click;
            button6.Click += Angka_Click;
            button7.Click += Angka_Click;
            button8.Click += Angka_Click;
            button9.Click += Angka_Click;

            // event handler operasi
            buttonPlus.Click += Plus_Click;
            buttonEquals.Click += Equals_Click;
        }

        // semua tombol angka
        private void Angka_Click(object sender, EventArgs e)
        {
            Button tombol = (Button)sender;
            label1.Text += tombol.Text;
        }

        // tombol +
        private void Plus_Click(object sender, EventArgs e)
        {
            total += Convert.ToDouble(label1.Text);
            label1.Text = "";
            tambah = true;
        }

        // tombol =
        private void Equals_Click(object sender, EventArgs e)
        {
            if (tambah)
            {
                total += Convert.ToDouble(label1.Text);
                label1.Text = total.ToString();
                total = 0;
                tambah = false;
            }
        }
    }
}
