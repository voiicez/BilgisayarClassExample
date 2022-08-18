namespace BilgisayarClassExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Bilgisayar App v0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string[] ramArray = cbRam.Text.Split(' ');
            Bilgisayar bilgisayar = new Bilgisayar()
            {
                Aciklama = tbAciklama.Text,
                Hiz = Convert.ToDouble(tbHiz.Text),
                Id = Convert.ToInt32(nudId.Value),
                Marka = tbMarka.Text.Trim(),
                Ram = Convert.ToByte(ramArray[0]),
                SuSogutmaliMi = cbSuSogutma.Checked,
                UretimTarihi = dtpUretimTarihi.Value

            };

            btnGoster.Enabled = true;
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            
        }
    }
}