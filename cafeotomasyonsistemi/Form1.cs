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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			this.Hide();
			form2.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form3 form3 = new Form3();
			this.Hide();
			form3.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form4 form4 = new Form4();
			this.Hide();
			form4.Show();
		}
		public void combobox1load()
		{
			baglantı.baglantıkontrol();
			SqlCommand command = new SqlCommand("SELECT * FROM Kahvetable WHERE KahveTur='sıcak' and aktif=1", baglantı.baglantıı);
			SqlDataReader reader = command.ExecuteReader();

			// ComboBox öğelerini eklerken KeyValuePair kullanacağız
			while (reader.Read())
			{
				string KahveName = reader["KahveName"].ToString();
				int KahveID = Convert.ToInt32(reader["KahveID"]);

				// KeyValuePair ile ComboBox'a öğe ekleyin
				comboBox1.Items.Add(new KeyValuePair<int, string>(KahveID, KahveName));
			}

			// DisplayMember olarak 'Value' (Kahve Adı), ValueMember olarak 'Key' (Kahve ID) ayarlayın
			comboBox1.DisplayMember = "Value";  // Görünen metin: KahveName
			comboBox1.ValueMember = "Key";     // Arka planda saklanan değer: KahveID

			reader.Close();
		}
		public void combobox2load()
		{
			baglantı.baglantıkontrol();
			SqlCommand command = new SqlCommand("SELECT * FROM Kahvetable WHERE KahveTur='soğuk' and aktif=1", baglantı.baglantıı);
			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				string KahveName = reader["KahveName"].ToString();
				int KahveID = Convert.ToInt32(reader["KahveID"]);

				// ComboBox'a öğeleri KeyValuePair olarak ekliyoruz
				comboBox2.Items.Add(new KeyValuePair<int, string>(KahveID, KahveName));
			}

			comboBox2.DisplayMember = "Value";  // Görünen metin: KahveName
			comboBox2.ValueMember = "Key";     // Arka planda saklanan değer: KahveID

			reader.Close();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			combobox1load();
			combobox2load();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			// Eğer sadece sıcak kahve (comboBox1) seçildiyse
			if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex == -1)
			{
				// Seçilen öğeyi al
				var selectedKahve1 = (KeyValuePair<int, string>)comboBox1.SelectedItem;
				int selectedKahveID1 = selectedKahve1.Key;  // KahveID
				string selectedKahveName1 = selectedKahve1.Value;  // KahveName

				// SQL sorgusu: Seçilen kahveye ait bilgileri al
				SqlCommand command = new SqlCommand("SELECT * FROM Kahvetable WHERE KahveID = @pkahvee", baglantı.baglantıı);
				command.Parameters.AddWithValue("@pkahvee", selectedKahveID1);

				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					kavheisim.Text = reader["KahveName"].ToString();
					kahvefiyat.Text = reader["KahvePrice"].ToString();
					Kahvetür.Text = reader["KahveTur"].ToString();
				}
				reader.Close();
			}

			// Eğer sadece soğuk kahve (comboBox2) seçildiyse
			else if (comboBox1.SelectedIndex == -1 && comboBox2.SelectedIndex != -1)
			{
				// Seçilen öğeyi al
				var selectedKahve2 = (KeyValuePair<int, string>)comboBox2.SelectedItem;
				int selectedKahveID2 = selectedKahve2.Key;  // KahveID
				string selectedKahveName2 = selectedKahve2.Value;  // KahveName

				// SQL sorgusu: Seçilen kahveye ait bilgileri al
				SqlCommand command = new SqlCommand("SELECT * FROM Kahvetable WHERE KahveID = @pkahvee", baglantı.baglantıı);
				command.Parameters.AddWithValue("@pkahvee", selectedKahveID2);

				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					Kahveisim2.Text = reader["KahveName"].ToString();
					Kahvefiyat2.Text = reader["KahvePrice"].ToString();
					Kahvetur2.Text = reader["KahveTur"].ToString();
				}
				reader.Close();
			}

			// Eğer her iki ComboBox'tan da bir kahve seçildiyse
			else if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1)
			{
				// Seçilen öğeleri al
				var selectedKahve1 = (KeyValuePair<int, string>)comboBox1.SelectedItem;
				int selectedKahveID1 = selectedKahve1.Key;  // KahveID
				string selectedKahveName1 = selectedKahve1.Value;  // KahveName

				var selectedKahve2 = (KeyValuePair<int, string>)comboBox2.SelectedItem;
				int selectedKahveID2 = selectedKahve2.Key;  // KahveID
				string selectedKahveName2 = selectedKahve2.Value;  // KahveName

				// SQL sorgusu: Her iki kahveye ait bilgileri al
				SqlCommand command = new SqlCommand("SELECT * FROM Kahvetable WHERE KahveID = @pkahvee1 OR KahveID = @pkahvee2", baglantı.baglantıı);
				command.Parameters.AddWithValue("@pkahvee1", selectedKahveID1);
				command.Parameters.AddWithValue("@pkahvee2", selectedKahveID2);

				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					// İlk kahve bilgileri
					if (Convert.ToInt32(reader["KahveID"]) == selectedKahveID1)
					{
						kavheisim.Text = reader["KahveName"].ToString();
						kahvefiyat.Text = reader["KahvePrice"].ToString();
						Kahvetür.Text = reader["KahveTur"].ToString();
					}

					// İkinci kahve bilgileri
					else if (Convert.ToInt32(reader["KahveID"]) == selectedKahveID2)
					{
						Kahveisim2.Text = reader["KahveName"].ToString();
						Kahvefiyat2.Text = reader["KahvePrice"].ToString();
						Kahvetur2.Text = reader["KahveTur"].ToString();
					}
				}
				reader.Close();
			}
			else
			{
				MessageBox.Show("Lütfen en az bir kahve seçin.");
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			baglantı.baglantıkontrol();
			SqlCommand command = new SqlCommand("SELECT * FROM İndirimTable WHERE İndirimNameSurname=@pad and aktif=1", baglantı.baglantıı);
			command.Parameters.AddWithValue("@pad", textBox1.Text.ToLower());
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				label12.Text = reader[1].ToString();
			}
			if (reader.HasRows)
			{
				int tutar = Convert.ToInt32(hesaptutar.Text);
				int indirim = tutar / 5 % 100;
				int toplam = tutar - indirim;
				hesaptutar.Text = toplam.ToString();
			}
			reader.Close();

		}

		private void button5_Click(object sender, EventArgs e)
		{

			if (!string.IsNullOrEmpty(kavheisim.Text))
			{

				listBox1.Items.Add(kavheisim.Text);
				listBox2.Items.Add(kahvefiyat.Text);


				kavheisim.Text = "";
				kahvefiyat.Text = "";
				Kahvetür.Text = "";
			}


			else if (!string.IsNullOrEmpty(Kahveisim2.Text))
			{

				listBox1.Items.Add(Kahveisim2.Text);
				listBox2.Items.Add(Kahvefiyat2.Text);


				Kahveisim2.Text = "";
				Kahvefiyat2.Text = "";
				Kahvetur2.Text = "";
			}


			else if (!string.IsNullOrEmpty(kavheisim.Text) && !string.IsNullOrEmpty(Kahveisim2.Text))
			{

				listBox1.Items.Add(kavheisim.Text);
				listBox2.Items.Add(kahvefiyat.Text);


				listBox1.Items.Add(Kahveisim2.Text);
				listBox2.Items.Add(Kahvefiyat2.Text);


				kavheisim.Text = "";
				kahvefiyat.Text = "";
				Kahvetür.Text = "";
				Kahveisim2.Text = "";
				Kahvefiyat2.Text = "";
				Kahvetur2.Text = "";
			}

			comboBox1.SelectedIndex = -1;
			comboBox2.SelectedIndex = -1;

		}
		public int total = 0;
		private void button8_Click(object sender, EventArgs e)
		{

			total = 0;


			foreach (var item in listBox2.Items)
			{
				if (item is string strValue && int.TryParse(strValue, out int parsedValue))
				{
					total += parsedValue;
				}
			}


			hesaptutar.Text = total.ToString();
		}
		private void button6_Click(object sender, EventArgs e)
		{

			baglantı.baglantıkontrol();


			SqlCommand command1 = new SqlCommand("INSERT INTO Caritable (KahveName, Kahvefiyat, Caritotal, CariDate) VALUES (@pkahveısım, @pfiyat, @ptoplam, @ptarih)", baglantı.baglantıı);

			StringBuilder kahveNames = new StringBuilder();
			StringBuilder fiyatlar = new StringBuilder();


			for (int i = 0; i < listBox1.Items.Count; i++)
			{
				var kahveAd = listBox1.Items[i].ToString();

				if (i < listBox2.Items.Count)
				{
					int fiyat = 0;
					if (int.TryParse(listBox2.Items[i].ToString(), out fiyat))
					{

						if (i != 0)
						{
							kahveNames.Append(", ");
							fiyatlar.Append(", ");
						}

						kahveNames.Append(kahveAd);
						fiyatlar.Append(fiyat);
					}
					else
					{

						MessageBox.Show("Geçersiz fiyat formatı: " + listBox2.Items[i].ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
			}
			command1.Parameters.Clear();
			command1.Parameters.AddWithValue("@pkahveısım", kahveNames.ToString());
			command1.Parameters.AddWithValue("@pfiyat", fiyatlar.ToString());
			command1.Parameters.AddWithValue("@ptoplam", total);
			command1.Parameters.AddWithValue("@ptarih", DateTime.Now);
			command1.ExecuteNonQuery();
			hesaptutar.Text = total.ToString();


		}
	}
}

