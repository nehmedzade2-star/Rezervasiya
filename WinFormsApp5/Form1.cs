namespace WinFormsApp5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
			{
				e.Handled = true;
			}

		}
		private int sure1 = 0;
		private int sure2 = 0;
		private int sure3 = 0;
		private int sure4 = 0;
		private int sure5 = 0;
		private int sure6 = 0;
		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBox1.Text))
			{
				MessageBox.Show("Zəhmət olmasa ad və soyad daxil edin!");
				return;
			}

			if (sure1 > 0)
			{
				MessageBox.Show("Bu otaq artıq doludur!");
				return;
			}

			string deqiqe = maskedTextBox1.Text.Replace("_", "").Trim();

			if (string.IsNullOrEmpty(deqiqe))
			{
				MessageBox.Show("Zəhmət olmasa dəqiqə daxil edin!");
				return;
			}

			if (int.TryParse(deqiqe, out int min))
			{
				sure1 = min * 60;
				int m = sure1 / 60;
				int s = sure1 % 60;
				label3.Text = $"{m:D2}:{s:D2}";
				timer1.Start();
			}
			else
			{
				MessageBox.Show("Yanlış format!");
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (sure1 > 0)
			{
				sure1--;
				int m = sure1 / 60;
				int s = sure1 % 60;
				label3.Text = $"{m:D2}:{s:D2}";

				if (sure1 == 0)
				{
					label3.Text = "Bitti";
					MessageBox.Show("Otaq 1 üçün vaxt bitdi!");
				}
			}

			if (sure2 > 0)
			{
				sure2--;
				int m = sure2 / 60;
				int s = sure2 % 60;
				label4.Text = $"{m:D2}:{s:D2}";

				if (sure2 == 0)
				{
					label4.Text = "Bitti";
					MessageBox.Show("Otaq 2 üçün vaxt bitdi!");
				}
			}
			if (sure3 > 0)
			{
				sure3--;
				int m = sure3 / 60;
				int s = sure3 % 60;
				label5.Text = $"{m:D2}:{s:D2}";

				if (sure3 == 0)
				{
					label5.Text = "Bitti";
					MessageBox.Show("Otaq 3 üçün vaxt bitdi!");
				}
			}
			if (sure4 > 0)
			{
				sure4--;
				int m = sure4 / 60;
				int s = sure4 % 60;
				label6.Text = $"{m:D2}:{s:D2}";

				if (sure4 == 0)
				{
					label6.Text = "Bitti";
					MessageBox.Show("Otaq 4 üçün vaxt bitdi!");
				}
			}
			if (sure5 > 0)
			{
				sure5--;
				int m = sure5 / 60;
				int s = sure5 % 60;
				label7.Text = $"{m:D2}:{s:D2}";

				if (sure5 == 0)
				{
					label7.Text = "Bitti";
					MessageBox.Show("Otaq 5 üçün vaxt bitdi!");
				}
			}
			if (sure6 > 0)
			{
				sure6--;
				int m = sure6 / 60;
				int s = sure6 % 60;
				label8.Text = $"{m:D2}:{s:D2}";

				if (sure6 == 0)
				{
					label8.Text = "Bitti";
					MessageBox.Show("Otaq 6 üçün vaxt bitdi!");
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBox1.Text))
			{
				MessageBox.Show("Zəhmət olmasa ad və soyad daxil edin!");
				return;
			}

			if (sure2 > 0)
			{
				MessageBox.Show("Bu otaq artıq doludur!");
				return;
			}

			string deqiqe = maskedTextBox1.Text.Replace("_", "").Trim();

			if (string.IsNullOrEmpty(deqiqe))
			{
				MessageBox.Show("Zəhmət olmasa dəqiqə daxil edin!");
				return;
			}

			if (int.TryParse(deqiqe, out int min))
			{
				sure2 = min * 60;
				int m = sure2 / 60;
				int s = sure2 % 60;
				label4.Text = $"{m:D2}:{s:D2}";
				timer1.Start();
			}
			else
			{
				MessageBox.Show("Yanlış format!");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBox1.Text))
			{
				MessageBox.Show("Zəhmət olmasa ad və soyad daxil edin!");
				return;
			}

			if (sure3 > 0)
			{
				MessageBox.Show("Bu otaq artıq doludur!");
				return;
			}

			string deqiqe = maskedTextBox1.Text.Replace("_", "").Trim();

			if (string.IsNullOrEmpty(deqiqe))
			{
				MessageBox.Show("Zəhmət olmasa dəqiqə daxil edin!");
				return;
			}

			if (int.TryParse(deqiqe, out int min))
			{
				sure3 = min * 60;
				int m = sure3 / 60;
				int s = sure3 % 60;
				label5.Text = $"{m:D2}:{s:D2}";
				timer1.Start();
			}
			else
			{
				MessageBox.Show("Yanlış format!");
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBox1.Text))
			{
				MessageBox.Show("Zəhmət olmasa ad və soyad daxil edin!");
				return;
			}

			if (sure4 > 0)
			{
				MessageBox.Show("Bu otaq artıq doludur!");
				return;
			}

			string deqiqe = maskedTextBox1.Text.Replace("_", "").Trim();

			if (string.IsNullOrEmpty(deqiqe))
			{
				MessageBox.Show("Zəhmət olmasa dəqiqə daxil edin!");
				return;
			}

			if (int.TryParse(deqiqe, out int min))
			{
				sure4 = min * 60;
				int m = sure4 / 60;
				int s = sure4 % 60;
				label6.Text = $"{m:D2}:{s:D2}";
				timer1.Start();
			}
			else
			{
				MessageBox.Show("Yanlış format!");
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBox1.Text))
			{
				MessageBox.Show("Zəhmət olmasa ad və soyad daxil edin!");
				return;
			}

			if (sure5 > 0)
			{
				MessageBox.Show("Bu otaq artıq doludur!");
				return;
			}

			string deqiqe = maskedTextBox1.Text.Replace("_", "").Trim();

			if (string.IsNullOrEmpty(deqiqe))
			{
				MessageBox.Show("Zəhmət olmasa dəqiqə daxil edin!");
				return;
			}

			if (int.TryParse(deqiqe, out int min))
			{
				sure5 = min * 60;
				int m = sure5 / 60;
				int s = sure5 % 60;
				label7.Text = $"{m:D2}:{s:D2}";
				timer1.Start();
			}
			else
			{
				MessageBox.Show("Yanlış format!");
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBox1.Text))
			{
				MessageBox.Show("Zəhmət olmasa ad və soyad daxil edin!");
				return;
			}

			if (sure6 > 0)
			{
				MessageBox.Show("Bu otaq artıq doludur!");
				return;
			}

			string deqiqe = maskedTextBox1.Text.Replace("_", "").Trim();

			if (string.IsNullOrEmpty(deqiqe))
			{
				MessageBox.Show("Zəhmət olmasa dəqiqə daxil edin!");
				return;
			}

			if (int.TryParse(deqiqe, out int min))
			{
				sure6 = min * 60;
				int m = sure6 / 60;
				int s = sure6 % 60;
				label8.Text = $"{m:D2}:{s:D2}";
				timer1.Start();
			}
			else
			{
				MessageBox.Show("Yanlış format!");
			}
		}
	}
}
