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
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}
		public void formload()
		{
			baglantı.baglantıkontrol();
			SqlCommand command = new SqlCommand("SELECT * FROM CariTable ",baglantı.baglantıı	);
			SqlDataAdapter da = new SqlDataAdapter(command);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;

			int toplam = 0;
			foreach (DataGridViewRow dr in dataGridView1.Rows)
			{
				if (!dr.IsNewRow)
				{
					if (dr.Cells[3].Value != null && int.TryParse(dr.Cells[3].Value.ToString(), out int fiyat))
					{
						toplam += fiyat;
					}
				}
			}
			label2.Text = toplam.ToString();
		}
		private void Form4_Load(object sender, EventArgs e)
		{
			formload();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form1 form1 = new Form1();
			this.Hide();
			form1.Show();
		}
	}
}
