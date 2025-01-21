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
    public partial class Form3 : Form
    {
        private Ikullanıcı kullanıcıislem;
        public Form3()
        {
            InitializeComponent();
            kullanıcıislem = new kullanıcıişlem();
        }
        public void formload()
        {
            baglantı.baglantıkontrol();
            SqlCommand command = new SqlCommand("select * from İndirimTable", baglantı.baglantıı);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            formload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text.ToLower();
            int id = selectedId;
            baglantı.baglantıkontrol();
            kullanıcıislem.updatekullanıcı(name,id);
            formload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text.ToLower();

            baglantı.baglantıkontrol();
            kullanıcıislem.addkullanıcı(ad);
            formload();
        }
        public int selectedId;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0) // Geçerli bir satır tıklanmış mı kontrol ediyoruz
            {
                // ID'yi alıyoruz. Varsayalım ki ID, 0. sütunda (index 0) bulunuyor.
                selectedId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["İndirimID"].Value);

                // Diğer hücre değerlerini alıyoruz ve TextBox'lara aktarıyoruz
                textBox2.Text = dataGridView1.Rows[rowIndex].Cells["İndirimNameSurname"].Value.ToString();
                // ID'yi kullanarak işlemler yapabilirsiniz, örneğin:
                // MessageBox.Show("Seçilen ID: " + selectedId);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = selectedId;
            baglantı.baglantıkontrol();
            kullanıcıislem.deletekullanıcı(id);
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
