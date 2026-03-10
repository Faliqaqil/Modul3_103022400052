namespace Modul3_103022400052
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbSatuanAwal.SelectedItem == null || cbSatuanAkhir.SelectedItem == null) { 
                MessageBox.Show("Pilih satuan terlebih dahulu!");
            }

            double nilaiAwal;
            bool isAngkaValid = double.TryParse(textBox1.Text, out nilaiAwal);

            if (textBox1.Text == "" || isAngkaValid == false)
            {
                MessageBox.Show("Masukkan angka yang valid");
                return;
            }
            
            String satuanAwal = cbSatuanAwal.SelectedItem.ToString();
            String satuanAkhir = cbSatuanAkhir.SelectedItem.ToString();

            double suhuCelcius = 0;

            if (satuanAwal == "Celcius")
            {
                suhuCelcius = nilaiAwal;
            }
            else if (satuanAwal == "Fahrenheit")
            {
                suhuCelcius = (nilaiAwal - 32) * 5 / 9;
            }
            else if (satuanAwal == "Kelvin")
            {
                suhuCelcius = nilaiAwal - 273.15;
            }
            else if (satuanAwal == "Reamur")
            {
                suhuCelcius = nilaiAwal * 5 / 4;
            }

            double hasilAkhir = 0;

            if (satuanAkhir == "Celcius")
            {
                hasilAkhir = suhuCelcius;
            }
            else if (satuanAkhir == "Fahrenheit")
            {
                hasilAkhir = (suhuCelcius * 9 / 5) + 32;
            }
            else if (satuanAkhir == "Kelvin")
            {
                hasilAkhir = suhuCelcius + 273.15;
            }
            else if (satuanAkhir == "Reamur")
            {
                hasilAkhir = suhuCelcius * 4 / 5;
            }

            textBox2.Text = Math.Round(hasilAkhir, 2).ToString();
        }

        private void cbSatuanAkhir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
