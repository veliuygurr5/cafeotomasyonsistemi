using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeotomasyonsistemi
{
    public partial class Form2 : Form
    {
        private Ikahveişlem kahveişlem;
        public Form2()
        {
            InitializeComponent();
            kahveişlem = new kahveişlemleri();

        }
        private void formload()
        {
            baglantı.baglantıkontrol();
            SqlCommand command = new SqlCommand("select * from KahveTable", baglantı.baglantıı);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            formload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.baglantıkontrol();
            string name = textBox1.Text;
            string kahveozellik = textBox4.Text;
            string fiyat = textBox2.Text;
            string tur = textBox3.Text;
            kahveişlem.addkavhe(name, kahveozellik, fiyat, tur);
            formload();


        }
        public int selectedId;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0) // Geçerli bir satır tıklanmış mı kontrol ediyoruz
            {
                // ID'yi alıyoruz. Varsayalım ki ID, 0. sütunda (index 0) bulunuyor.
                selectedId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["KahveID"].Value);

                // Diğe8r hücre değerlerini alıyoruz ve TextBox'lara aktarıyoruz
                textBox8.Text = dataGridView1.Rows[rowIndex].Cells["KahveName"].Value.ToString();
                textBox7.Text = dataGridView1.Rows[rowIndex].Cells["KahvePrice"].Value.ToString();
                textBox6.Text = dataGridView1.Rows[rowIndex].Cells["KahveTur"].Value.ToString();
                textBox5.Text = dataGridView1.Rows[rowIndex].Cells["KahveOzellik"].Value.ToString();

                // ID'yi kullanarak işlemler yapabilirsiniz, örneğin:
                // MessageBox.Show("Seçilen ID: " + selectedId);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglantı.baglantıkontrol();
            string kahve = textBox8.Text;
            string ozellik = textBox5.Text;
            string fiyat = textBox7.Text;
            string tur = textBox6.Text;
            kahveişlem.updatekahve(selectedId, kahve, ozellik, fiyat, tur);
            formload();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglantı.baglantıkontrol();
            kahveişlem.deletekahve(selectedId);
            formload();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
