namespace BilgisayarClassExample
{
    public partial class Form1 : Form
    {
        Bilgisayar _bilgisayar=new Bilgisayar(); //alan,global de�i�ken
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
            this.Text = "Bilgisayar App v1";
            lSonuc.Text = " ";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string[] ramArray = cbRam.Text.Split(' ');
             //_bilgisayar = new Bilgisayar() //Local de�i�ken
            //{
            //    Aciklama = tbAciklama.Text,
            //    Hiz = Convert.ToDouble(tbHiz.Text),
            //    Id = Convert.ToInt32(nudId.Value),
            //    Marka = tbMarka.Text.Trim(),
            //    Ram = Convert.ToByte(ramArray[0]),
            //    SuSogutmaliMi = cbSuSogutma.Checked,
            //    UretimTarihi = dtpUretimTarihi.Value

            //};

            _bilgisayar.Aciklama = tbAciklama.Text;
            _bilgisayar.Hiz = Convert.ToDouble(tbHiz.Text);
            _bilgisayar.Id = Convert.ToInt32(nudId.Value);
            _bilgisayar.Marka = tbMarka.Text.Trim();
            _bilgisayar.Ram = Convert.ToByte(ramArray[0]);
            _bilgisayar.SuSogutmaliMi = cbSuSogutma.Checked;
            _bilgisayar.UretimTarihi = dtpUretimTarihi.Value;


            btnGoster.Enabled = true;
            lSonuc.Text = "Bilgisayar olu�turuldu.";
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            string suSogutma = "Yok";
            suSogutma=_bilgisayar.SuSogutmaliMi ? "Do�ru" :"Yanl��";
            //if (_bilgisayar.SuSogutmaliMi)
            //{
            //    suSogutma = "Do�ru";
            //}
            
                
            MessageBox.Show("Bilgisayar markas�: " +_bilgisayar.Marka+"\n"  + " Hiz: " + _bilgisayar.Hiz +"\n"+ " Ram: " + _bilgisayar.Ram+"\n"+"Tarih: "+_bilgisayar.UretimTarihi.ToShortDateString()+"\n"+" SuSo�utma: "+ suSogutma);
        }
    }
}