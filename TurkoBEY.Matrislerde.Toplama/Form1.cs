using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurkoBEY.Matrisler.Toplama.Cikarma.Carpma
{
	public partial class Form1 : Form
	{
		public int M1Sonuc, M2Sonuc, M3Sonuc, M4Sonuc, M5Sonuc, M6Sonuc, M7Sonuc, M8Sonuc, M9Sonuc, M10Sonuc, M11Sonuc, M12Sonuc, M13Sonuc, M14Sonuc, M15Sonuc, M16Sonuc;
		public Form1()
		{
			InitializeComponent();
		}
		private void ButtonToplama_Click(object sender, EventArgs e)
		{
			if (checkBoxToplama2x2.Checked)
			{
				int[,] matA = {
				{ Convert.ToInt32(TBoxMA1a.Text), Convert.ToInt32(TBoxMA1b.Text) },
				{ Convert.ToInt32(TBoxMA2a.Text), Convert.ToInt32(TBoxMA2b.Text) } };

				int[,] matB = {
				{ Convert.ToInt32(TBoxMB1a.Text), Convert.ToInt32(TBoxMB1b.Text) },
				{ Convert.ToInt32(TBoxMB2a.Text), Convert.ToInt32(TBoxMB2b.Text)} };

				int[,] toplam = new int[2, 2];

				for (int i = 0; i < 2; i++)
				{
					for (int j = 0; j < 2; j++)
					{
						toplam[i, j] = matA[i, j] + matB[i, j];
					}

				}
				for (int k = 0; k < 2; k++)
				{
					Console.WriteLine();
					for (int m = 0; m < 2; m++)
					{
						richTextBox1.Text += "[" + Convert.ToString(toplam[k, m] + "]");
					}
					richTextBox1.Text += Convert.ToString("\n");
				}
			}
			else if (checkBoxToplama3x3.Checked)
			{
				int[,] matA = {
				{ Convert.ToInt32(TBoxMA1a.Text), Convert.ToInt32(TBoxMA1b.Text), Convert.ToInt32(TBoxMA1c.Text) },
				{ Convert.ToInt32(TBoxMA2a.Text), Convert.ToInt32(TBoxMA2b.Text), Convert.ToInt32(TBoxMA2c.Text) },
				{ Convert.ToInt32(TBoxMA3a.Text), Convert.ToInt32(TBoxMA3b.Text), Convert.ToInt32(TBoxMA3c.Text) } };
				int[,] matB = {
				{ Convert.ToInt32(TBoxMB1a.Text), Convert.ToInt32(TBoxMB1b.Text), Convert.ToInt32(TBoxMB1c.Text) },
				{ Convert.ToInt32(TBoxMB2a.Text), Convert.ToInt32(TBoxMB2b.Text), Convert.ToInt32(TBoxMB2c.Text) },
				{ Convert.ToInt32(TBoxMB3a.Text), Convert.ToInt32(TBoxMB3b.Text), Convert.ToInt32(TBoxMB3c.Text) } };

				int[,] toplam = new int[3, 3];

				for (int i = 0; i < 3; i++)
				{
					for (int j = 0; j < 3; j++)
					{
						toplam[i, j] = matA[i, j] + matB[i, j];
					}
				}
				for (int k = 0; k < 3; k++)
				{
					Console.WriteLine();
					for (int m = 0; m < 3; m++)
					{
						richTextBox1.Text += "[" + Convert.ToString(toplam[k, m] + "]");
					}
					richTextBox1.Text += Convert.ToString("\n");
				}
			}
			else if (checkBoxToplama4x4.Checked)
			{
				int[,] matA = {
				{ Convert.ToInt32(TBoxMA1a.Text), Convert.ToInt32(TBoxMA1b.Text), Convert.ToInt32(TBoxMA1c.Text), Convert.ToInt32(TBoxMA1d.Text) },
				{ Convert.ToInt32(TBoxMA2a.Text), Convert.ToInt32(TBoxMA2b.Text), Convert.ToInt32(TBoxMA2c.Text), Convert.ToInt32(TBoxMA2d.Text) },
				{ Convert.ToInt32(TBoxMA3a.Text), Convert.ToInt32(TBoxMA3b.Text), Convert.ToInt32(TBoxMA3c.Text), Convert.ToInt32(TBoxMA3d.Text) },
				{ Convert.ToInt32(TBoxMA4a.Text), Convert.ToInt32(TBoxMA4b.Text), Convert.ToInt32(TBoxMA4c.Text), Convert.ToInt32(TBoxMA4d.Text) } };
				int[,] matB = {
				{ Convert.ToInt32(TBoxMB1a.Text), Convert.ToInt32(TBoxMB1b.Text), Convert.ToInt32(TBoxMB1c.Text), Convert.ToInt32(TBoxMB1d.Text) },
				{ Convert.ToInt32(TBoxMB2a.Text), Convert.ToInt32(TBoxMB2b.Text), Convert.ToInt32(TBoxMB2c.Text), Convert.ToInt32(TBoxMB2d.Text) },
				{ Convert.ToInt32(TBoxMB3a.Text), Convert.ToInt32(TBoxMB3b.Text), Convert.ToInt32(TBoxMB3c.Text), Convert.ToInt32(TBoxMB3d.Text) },
				{ Convert.ToInt32(TBoxMB4a.Text), Convert.ToInt32(TBoxMB4b.Text), Convert.ToInt32(TBoxMB4c.Text), Convert.ToInt32(TBoxMB4d.Text) } };

				int[,] toplam = new int[4, 4];

				for (int i = 0; i < 4; i++)
				{
					for (int j = 0; j < 4; j++)
					{
						toplam[i, j] = matA[i, j] + matB[i, j];
					}

				}
				for (int k = 0; k < 4; k++)
				{
					Console.WriteLine();
					for (int m = 0; m < 4; m++)
					{
						richTextBox1.Text += "[" + Convert.ToString(toplam[k, m] + "]");
					}
					richTextBox1.Text += Convert.ToString("\n");
				}
			}
		}
		private void ButtonTemizle_Click(object sender, EventArgs e)
		{
			richTextBox1.Text = "";
			TBoxMA1a.Text = "";
			TBoxMA2a.Text = "";
			TBoxMA3a.Text = "";
			TBoxMA4a.Text = "";
			TBoxMA1b.Text = "";
			TBoxMA2b.Text = "";
			TBoxMA3b.Text = "";
			TBoxMA4b.Text = "";
			TBoxMA1c.Text = "";
			TBoxMA2c.Text = "";
			TBoxMA3c.Text = "";
			TBoxMA4c.Text = "";
			TBoxMA1d.Text = "";
			TBoxMA2d.Text = "";
			TBoxMA3d.Text = "";
			TBoxMA4d.Text = "";
			TBoxMB1a.Text = "";
			TBoxMB2a.Text = "";
			TBoxMB3a.Text = "";
			TBoxMB4a.Text = "";
			TBoxMB1b.Text = "";
			TBoxMB2b.Text = "";
			TBoxMB3b.Text = "";
			TBoxMB4b.Text = "";
			TBoxMB1c.Text = "";
			TBoxMB2c.Text = "";
			TBoxMB3c.Text = "";
			TBoxMB4c.Text = "";
			TBoxMB1d.Text = "";
			TBoxMB2d.Text = "";
			TBoxMB3d.Text = "";
			TBoxMB4d.Text = "";
		}
		private void checkBoxDet4x4_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxDet4x4.Checked)
			{
				TBoxMB1a.Visible = false;
				TBoxMB2a.Visible = false;
				TBoxMB3a.Visible = false;
				TBoxMB4a.Visible = false;
				TBoxMB1b.Visible = false;
				TBoxMB2b.Visible = false;
				TBoxMB3b.Visible = false;
				TBoxMB4b.Visible = false;
				TBoxMB1c.Visible = false;
				TBoxMB2c.Visible = false;
				TBoxMB3c.Visible = false;
				TBoxMB4c.Visible = false;
				TBoxMB1d.Visible = false;
				TBoxMB2d.Visible = false;
				TBoxMB3d.Visible = false;
				TBoxMB4d.Visible = false;
			}
			else
			{
				TBoxMB1a.Visible = true;
				TBoxMB2a.Visible = true;
				TBoxMB3a.Visible = true;
				TBoxMB4a.Visible = true;
				TBoxMB1b.Visible = true;
				TBoxMB2b.Visible = true;
				TBoxMB3b.Visible = true;
				TBoxMB4b.Visible = true;
				TBoxMB1c.Visible = true;
				TBoxMB2c.Visible = true;
				TBoxMB3c.Visible = true;
				TBoxMB4c.Visible = true;
				TBoxMB1d.Visible = true;
				TBoxMB2d.Visible = true;
				TBoxMB3d.Visible = true;
				TBoxMB4d.Visible = true;
			}
		}
		private void ButtonCikarma_Click(object sender, EventArgs e)
		{
			if (checkBoxCikarma2x2.Checked)
			{
				int[,] matA = {
				{ Convert.ToInt32(TBoxMA1a.Text), Convert.ToInt32(TBoxMA1b.Text) },
				{ Convert.ToInt32(TBoxMA2a.Text), Convert.ToInt32(TBoxMA2b.Text) } };

				int[,] matB = {
				{ Convert.ToInt32(TBoxMB1a.Text), Convert.ToInt32(TBoxMB1b.Text) },
				{ Convert.ToInt32(TBoxMB2a.Text), Convert.ToInt32(TBoxMB2b.Text)} };

				int[,] toplam = new int[2, 2];

				for (int i = 0; i < 2; i++)
				{
					for (int j = 0; j < 2; j++)
					{
						toplam[i, j] = matA[i, j] - matB[i, j];
					}

				}
				for (int k = 0; k < 2; k++)
				{
					Console.WriteLine();
					for (int m = 0; m < 2; m++)
					{
						richTextBox1.Text += "[" + Convert.ToString(toplam[k, m] + "]");
					}
					richTextBox1.Text += Convert.ToString("\n");
				}
			}
			else if (checkBoxCikarma3x3.Checked)
			{
				int[,] matA = {
				{ Convert.ToInt32(TBoxMA1a.Text), Convert.ToInt32(TBoxMA1b.Text), Convert.ToInt32(TBoxMA1c.Text) },
				{ Convert.ToInt32(TBoxMA2a.Text), Convert.ToInt32(TBoxMA2b.Text), Convert.ToInt32(TBoxMA2c.Text) },
				{ Convert.ToInt32(TBoxMA3a.Text), Convert.ToInt32(TBoxMA3b.Text), Convert.ToInt32(TBoxMA3c.Text) } };
				int[,] matB = {
				{ Convert.ToInt32(TBoxMB1a.Text), Convert.ToInt32(TBoxMB1b.Text), Convert.ToInt32(TBoxMB1c.Text) },
				{ Convert.ToInt32(TBoxMB2a.Text), Convert.ToInt32(TBoxMB2b.Text), Convert.ToInt32(TBoxMB2c.Text) },
				{ Convert.ToInt32(TBoxMB3a.Text), Convert.ToInt32(TBoxMB3b.Text), Convert.ToInt32(TBoxMB3c.Text) } };

				int[,] toplam = new int[3, 3];

				for (int i = 0; i < 3; i++)
				{
					for (int j = 0; j < 3; j++)
					{
						toplam[i, j] = matA[i, j] - matB[i, j];
					}
				}
				for (int k = 0; k < 3; k++)
				{
					Console.WriteLine();
					for (int m = 0; m < 3; m++)
					{
						richTextBox1.Text += "[" + Convert.ToString(toplam[k, m] + "]");
					}
					richTextBox1.Text += Convert.ToString("\n");
				}
			}
			else if (checkBoxCikarma4x4.Checked)
			{
				int[,] matA = {
				{ Convert.ToInt32(TBoxMA1a.Text), Convert.ToInt32(TBoxMA1b.Text), Convert.ToInt32(TBoxMA1c.Text), Convert.ToInt32(TBoxMA1d.Text) },
				{ Convert.ToInt32(TBoxMA2a.Text), Convert.ToInt32(TBoxMA2b.Text), Convert.ToInt32(TBoxMA2c.Text), Convert.ToInt32(TBoxMA2d.Text) },
				{ Convert.ToInt32(TBoxMA3a.Text), Convert.ToInt32(TBoxMA3b.Text), Convert.ToInt32(TBoxMA3c.Text), Convert.ToInt32(TBoxMA3d.Text) },
				{ Convert.ToInt32(TBoxMA4a.Text), Convert.ToInt32(TBoxMA4b.Text), Convert.ToInt32(TBoxMA4c.Text), Convert.ToInt32(TBoxMA4d.Text) } };
				int[,] matB = {
				{ Convert.ToInt32(TBoxMB1a.Text), Convert.ToInt32(TBoxMB1b.Text), Convert.ToInt32(TBoxMB1c.Text), Convert.ToInt32(TBoxMB1d.Text) },
				{ Convert.ToInt32(TBoxMB2a.Text), Convert.ToInt32(TBoxMB2b.Text), Convert.ToInt32(TBoxMB2c.Text), Convert.ToInt32(TBoxMB2d.Text) },
				{ Convert.ToInt32(TBoxMB3a.Text), Convert.ToInt32(TBoxMB3b.Text), Convert.ToInt32(TBoxMB3c.Text), Convert.ToInt32(TBoxMB3d.Text) },
				{ Convert.ToInt32(TBoxMB4a.Text), Convert.ToInt32(TBoxMB4b.Text), Convert.ToInt32(TBoxMB4c.Text), Convert.ToInt32(TBoxMB4d.Text) } };

				int[,] toplam = new int[4, 4];

				for (int i = 0; i < 4; i++)
				{
					for (int j = 0; j < 4; j++)
					{
						toplam[i, j] = matA[i, j] - matB[i, j];
					}

				}
				for (int k = 0; k < 4; k++)
				{
					Console.WriteLine();
					for (int m = 0; m < 4; m++)
					{
						richTextBox1.Text += "[" + Convert.ToString(toplam[k, m] + "]");
					}
					richTextBox1.Text += Convert.ToString("\n");
				}
			}
		}
		private void ButtonCarpma_Click(object sender, EventArgs e)
		{
			if (checkBox2x2.Checked && checkBox3x3.Checked == false && checkBox4x4.Checked == false)
			{

				int MA1a = Convert.ToInt32(TBoxMA1a.Text);
				int MA2a = Convert.ToInt32(TBoxMA2a.Text);

				int MA1b = Convert.ToInt32(TBoxMA1b.Text);
				int MA2b = Convert.ToInt32(TBoxMA2b.Text);

				int MB1a = Convert.ToInt32(TBoxMB1a.Text);
				int MB2a = Convert.ToInt32(TBoxMB2a.Text);

				int MB1b = Convert.ToInt32(TBoxMB1b.Text);
				int MB2b = Convert.ToInt32(TBoxMB2b.Text);

				M1Sonuc = (MA1a * MB1a) + (MA1b * MB2a);
				M3Sonuc = (MA2a * MB1a) + (MB2a * MA2b);

				M2Sonuc = (MA1a * MB1b) + (MA1b * MB2b);
				M4Sonuc = (MA2a * MB1b) + (MA2b * MB2b);
				richTextBox1.Clear();
				richTextBox1.Text += Convert.ToString(
					"[" + M1Sonuc + "] [" + M2Sonuc + "]\n" +
				"[" + M3Sonuc + "] [" + M4Sonuc + "]");
			}
			else if (checkBox3x3.Checked && checkBox2x2.Checked == false && checkBox4x4.Checked == false)
			{
				if (checkBox3x3.Checked)
				{
					int MA1a = Convert.ToInt32(TBoxMA1a.Text);
					int MA2a = Convert.ToInt32(TBoxMA2a.Text);
					int MA3a = Convert.ToInt32(TBoxMA3a.Text);

					int MA1b = Convert.ToInt32(TBoxMA1b.Text);
					int MA2b = Convert.ToInt32(TBoxMA2b.Text);
					int MA3b = Convert.ToInt32(TBoxMA3b.Text);

					int MA1c = Convert.ToInt32(TBoxMA1c.Text);
					int MA2c = Convert.ToInt32(TBoxMA2c.Text);
					int MA3c = Convert.ToInt32(TBoxMA3c.Text);

					int MB1a = Convert.ToInt32(TBoxMB1a.Text);
					int MB2a = Convert.ToInt32(TBoxMB2a.Text);
					int MB3a = Convert.ToInt32(TBoxMB3a.Text);

					int MB1b = Convert.ToInt32(TBoxMB1b.Text);
					int MB2b = Convert.ToInt32(TBoxMB2b.Text);
					int MB3b = Convert.ToInt32(TBoxMB3b.Text);

					int MB1c = Convert.ToInt32(TBoxMB1c.Text);
					int MB2c = Convert.ToInt32(TBoxMB2c.Text);
					int MB3c = Convert.ToInt32(TBoxMB3c.Text);

					M1Sonuc = (MA1a * MB1a) + (MA1b * MB2a) + (MA1c * MB3a);
					M2Sonuc = (MA1a * MB1b) + (MA1b * MB2b) + (MA1c * MB3b);
					M3Sonuc = (MA1a * MB1c) + (MA1b * MB2c) + (MA1c * MB3c);

					M4Sonuc = (MA2a * MB1a) + (MA2b * MB2a) + (MA2c * MB3a);
					M5Sonuc = (MA2a * MB1b) + (MA2b * MB2b) + (MA2c * MB3b);
					M6Sonuc = (MA2a * MB1c) + (MA2b * MB2c) + (MA2c * MB3c);

					M7Sonuc = (MA3a * MB1a) + (MA3b * MB2a) + (MA3c * MB3a);
					M8Sonuc = (MA3a * MB1b) + (MA3b * MB2b) + (MA3c * MB3b);
					M9Sonuc = (MA3a * MB1c) + (MA3b * MB2c) + (MA3c * MB3c);

					richTextBox1.Clear();
					richTextBox1.Text += Convert.ToString(
						"[" + M1Sonuc + "] [" + M2Sonuc + "] [" + M3Sonuc + "]\n" +
						"[" + M4Sonuc + "] [" + M5Sonuc + "] [" + M6Sonuc + "]\n" +
						"[" + M7Sonuc + "] [" + M8Sonuc + "] [" + M9Sonuc + "]\n");
				}
			}
			else if (checkBox4x4.Checked && checkBox3x3.Checked == false && checkBox2x2.Checked == false)
			{
				if (checkBox4x4.Checked)
				{
					int MA1a = Convert.ToInt32(TBoxMA1a.Text);
					int MA2a = Convert.ToInt32(TBoxMA2a.Text);
					int MA3a = Convert.ToInt32(TBoxMA3a.Text);
					int MA4a = Convert.ToInt32(TBoxMA4a.Text);

					int MA1b = Convert.ToInt32(TBoxMA1b.Text);
					int MA2b = Convert.ToInt32(TBoxMA2b.Text);
					int MA3b = Convert.ToInt32(TBoxMA3b.Text);
					int MA4b = Convert.ToInt32(TBoxMA4b.Text);

					int MA1c = Convert.ToInt32(TBoxMA1c.Text);
					int MA2c = Convert.ToInt32(TBoxMA2c.Text);
					int MA3c = Convert.ToInt32(TBoxMA3c.Text);
					int MA4c = Convert.ToInt32(TBoxMA4c.Text);

					int MA1d = Convert.ToInt32(TBoxMA1d.Text);
					int MA2d = Convert.ToInt32(TBoxMA2d.Text);
					int MA3d = Convert.ToInt32(TBoxMA3d.Text);
					int MA4d = Convert.ToInt32(TBoxMA4d.Text);

					int MB1a = Convert.ToInt32(TBoxMB1a.Text);
					int MB2a = Convert.ToInt32(TBoxMB2a.Text);
					int MB3a = Convert.ToInt32(TBoxMB3a.Text);
					int MB4a = Convert.ToInt32(TBoxMB4a.Text);

					int MB1b = Convert.ToInt32(TBoxMB1b.Text);
					int MB2b = Convert.ToInt32(TBoxMB2b.Text);
					int MB3b = Convert.ToInt32(TBoxMB3b.Text);
					int MB4b = Convert.ToInt32(TBoxMB4b.Text);

					int MB1c = Convert.ToInt32(TBoxMB1c.Text);
					int MB2c = Convert.ToInt32(TBoxMB2c.Text);
					int MB3c = Convert.ToInt32(TBoxMB3c.Text);
					int MB4c = Convert.ToInt32(TBoxMB4c.Text);

					int MB1d = Convert.ToInt32(TBoxMB1d.Text);
					int MB2d = Convert.ToInt32(TBoxMB2d.Text);
					int MB3d = Convert.ToInt32(TBoxMB3d.Text);
					int MB4d = Convert.ToInt32(TBoxMB4d.Text);

					M1Sonuc = (MA1a * MB1a) + (MA1b * MB2a) + (MA1c * MB3a) + (MA1d * MB4a);
					M2Sonuc = (MA1a * MB1b) + (MA1b * MB2b) + (MA1c * MB3b) + (MA1d * MB4b);
					M3Sonuc = (MA1a * MB1c) + (MA1b * MB2c) + (MA1c * MB3c) + (MA1d * MB4c);
					M4Sonuc = (MA1a * MB1d) + (MA1b * MB2d) + (MA1c * MB3d) + (MA1d * MB4d);

					M5Sonuc = (MA2a * MB1a) + (MA2b * MB2a) + (MA2c * MB3a) + (MA2d * MB4a);
					M6Sonuc = (MA2a * MB1b) + (MA2b * MB2b) + (MA2c * MB3b) + (MA2d * MB4b);
					M7Sonuc = (MA2a * MB1c) + (MA2b * MB2c) + (MA2c * MB3c) + (MA2d * MB4c);
					M8Sonuc = (MA2a * MB1d) + (MA2b * MB2d) + (MA2c * MB3d) + (MA2d * MB4d);

					M9Sonuc = (MA3a * MB1a) + (MA3b * MB2a) + (MA3c * MB3a) + (MA3d * MB4a);
					M10Sonuc = (MA3a * MB1b) + (MA3b * MB2b) + (MA3c * MB3b) + (MA3d * MB4b);
					M11Sonuc = (MA3a * MB1c) + (MA3b * MB2c) + (MA3c * MB3c) + (MA3d * MB4c);
					M12Sonuc = (MA3a * MB1d) + (MA3b * MB2d) + (MA3c * MB3d) + (MA3d * MB4d);

					M13Sonuc = (MA4a * MB1a) + (MA4b * MB2a) + (MA4c * MB3a) + (MA4d * MB4a);
					M14Sonuc = (MA4a * MB1b) + (MA4b * MB2b) + (MA4c * MB3b) + (MA4d * MB4b);
					M15Sonuc = (MA4a * MB1c) + (MA4b * MB2c) + (MA4c * MB3c) + (MA4d * MB4c);
					M16Sonuc = (MA4a * MB1d) + (MA4b * MB2d) + (MA4c * MB3d) + (MA4d * MB4d);

					richTextBox1.Clear();
					richTextBox1.Text += Convert.ToString(
						"[" + M1Sonuc + "] [" + M2Sonuc + "] [" + M3Sonuc + "] [" + M4Sonuc + "]\n" +
						"[" + M5Sonuc + "] [" + M6Sonuc + "] [" + M7Sonuc + "] [" + M8Sonuc + "]\n" +
						"[" + M9Sonuc + "] [" + M10Sonuc + "] [" + M11Sonuc + "] [" + M12Sonuc + "]\n" +
						"[" + M13Sonuc + "] [" + M14Sonuc + "] [" + M15Sonuc + "] [" + M16Sonuc + "]");
				}
			}
			else
			{
				MessageBox.Show("Tek seçim yapınız");
			}
		}
		private void checkBox2x2_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox2x2.Checked)
			{
				ButtonCarpma.Visible = true;
				TBoxMA1d.Visible = false;
				TBoxMA2d.Visible = false;
				TBoxMA3d.Visible = false;
				TBoxMA4d.Visible = false;
				TBoxMA1c.Visible = false;
				TBoxMA2c.Visible = false;
				TBoxMA3c.Visible = false;
				TBoxMA4c.Visible = false;
				TBoxMA3a.Visible = false;
				TBoxMA3b.Visible = false;
				TBoxMA4a.Visible = false;
				TBoxMA4b.Visible = false;
				TBoxMB1d.Visible = false;
				TBoxMB2d.Visible = false;
				TBoxMB3d.Visible = false;
				TBoxMB4d.Visible = false;
				TBoxMB1c.Visible = false;
				TBoxMB2c.Visible = false;
				TBoxMB3c.Visible = false;
				TBoxMB4c.Visible = false;
				TBoxMB3a.Visible = false;
				TBoxMB3b.Visible = false;
				TBoxMB4a.Visible = false;
				TBoxMB4b.Visible = false;

			}
			else
			{

				ButtonCarpma.Visible = false;
				TBoxMA1d.Visible = true;
				TBoxMA2d.Visible = true;
				TBoxMA3d.Visible = true;
				TBoxMA4d.Visible = true;
				TBoxMA1c.Visible = true;
				TBoxMA2c.Visible = true;
				TBoxMA3c.Visible = true;
				TBoxMA4c.Visible = true;
				TBoxMA3a.Visible = true;
				TBoxMA3b.Visible = true;
				TBoxMA4a.Visible = true;
				TBoxMA4b.Visible = true;
				TBoxMB1d.Visible = true;
				TBoxMB2d.Visible = true;
				TBoxMB3d.Visible = true;
				TBoxMB4d.Visible = true;
				TBoxMB1c.Visible = true;
				TBoxMB2c.Visible = true;
				TBoxMB3c.Visible = true;
				TBoxMB4c.Visible = true;
				TBoxMB3a.Visible = true;
				TBoxMB3b.Visible = true;
				TBoxMB4a.Visible = true;
				TBoxMB4b.Visible = true;
			}
		}
		private void checkBox3x3_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox3x3.Checked)
			{
				ButtonCarpma.Visible = true;
				TBoxMA1d.Visible = false;
				TBoxMA2d.Visible = false;
				TBoxMA3d.Visible = false;
				TBoxMA4d.Visible = false;
				TBoxMA4a.Visible = false;
				TBoxMA4b.Visible = false;
				TBoxMA4c.Visible = false;
				TBoxMB1d.Visible = false;
				TBoxMB2d.Visible = false;
				TBoxMB3d.Visible = false;
				TBoxMB4d.Visible = false;
				TBoxMB4a.Visible = false;
				TBoxMB4b.Visible = false;
				TBoxMB4c.Visible = false;
			}
			else
			{
				ButtonCarpma.Visible = false;
				TBoxMA1d.Visible = true;
				TBoxMA2d.Visible = true;
				TBoxMA3d.Visible = true;
				TBoxMA4d.Visible = true;
				TBoxMA4a.Visible = true;
				TBoxMA4b.Visible = true;
				TBoxMA4c.Visible = true;
				TBoxMB1d.Visible = true;
				TBoxMB2d.Visible = true;
				TBoxMB3d.Visible = true;
				TBoxMB4d.Visible = true;
				TBoxMB4a.Visible = true;
				TBoxMB4b.Visible = true;
				TBoxMB4c.Visible = true;
			}
		}
		private void checkBox4x4_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox4x4.Checked)
			{
				ButtonCarpma.Visible = true;
			}
			else
			{
				ButtonCarpma.Visible = false;
			}
		}
		private void checkBoxCikarma_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxCikarma.Checked)
			{
				ButtonCikarma.Visible = true;
				checkBoxCikarma2x2.Visible = true;
				checkBoxCikarma3x3.Visible = true;
				checkBoxCikarma4x4.Visible = true;
			}
			else
			{
				ButtonCikarma.Visible = false;
				checkBoxCikarma2x2.Visible = false;
				checkBoxCikarma3x3.Visible = false;
				checkBoxCikarma4x4.Visible = false;
			}
		}
		private void checkBoxToplama_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxToplama.Checked)
			{
				ButtonToplama.Visible = true;
				checkBoxToplama2x2.Visible = true;
				checkBoxToplama3x3.Visible = true;
				checkBoxToplama4x4.Visible = true;
			}
			else
			{
				ButtonToplama.Visible = false;
				checkBoxToplama2x2.Visible = false;
				checkBoxToplama3x3.Visible = false;
				checkBoxToplama4x4.Visible = false;
			}
		}
		private void ButtonDetHesapla_Click(object sender, EventArgs e)
		{
			if (checkBoxDet2x2.Checked && checkBoxDet3x3.Checked == false && checkBoxDet4x4.Checked == false)
			{

				int MA1a = Convert.ToInt32(TBoxMA1a.Text);
				int MA2a = Convert.ToInt32(TBoxMA2a.Text);

				int MA1b = Convert.ToInt32(TBoxMA1b.Text);
				int MA2b = Convert.ToInt32(TBoxMA2b.Text);
				int M1Sonuc;

				M1Sonuc = (MA1a * MA2b) - (MA1b * MA2a);
				richTextBox1.Clear();
				richTextBox1.Text += Convert.ToString("[ " + M1Sonuc + " ]");
			}
			else if (checkBoxDet3x3.Checked && checkBoxDet2x2.Checked == false && checkBoxDet4x4.Checked == false)
			{
				int MA1a = Convert.ToInt32(TBoxMA1a.Text);
				int MA2a = Convert.ToInt32(TBoxMA2a.Text);
				int MA3a = Convert.ToInt32(TBoxMA3a.Text);

				int MA1b = Convert.ToInt32(TBoxMA1b.Text);
				int MA2b = Convert.ToInt32(TBoxMA2b.Text);
				int MA3b = Convert.ToInt32(TBoxMA3b.Text);

				int MA1c = Convert.ToInt32(TBoxMA1c.Text);
				int MA2c = Convert.ToInt32(TBoxMA2c.Text);
				int MA3c = Convert.ToInt32(TBoxMA3c.Text);

				int M1Sonuc;
				//TBoxMA3a*TBoxMA2c*TBoxMA1b
				M1Sonuc = (MA1a * MA2b * MA3c) + (MA1b * MA2c * MA3a) + (MA1c * MA2a * MA3b) - (MA3a * MA2b * MA1c) - (MA3b * MA2c * MA1a) - (MA3c * MA2a * MA1b);
				richTextBox1.Clear();
				richTextBox1.Text += Convert.ToString("[ " + M1Sonuc + " ]");
			}
			else if (checkBoxDet4x4.Checked && checkBoxDet2x2.Checked == false && checkBoxDet2x2.Checked == false)
			{
				int MA1a = Convert.ToInt32(TBoxMA1a.Text);
				int MA2a = Convert.ToInt32(TBoxMA2a.Text);
				int MA3a = Convert.ToInt32(TBoxMA3a.Text);
				int MA4a = Convert.ToInt32(TBoxMA4a.Text);

				int MA1b = Convert.ToInt32(TBoxMA1b.Text);
				int MA2b = Convert.ToInt32(TBoxMA2b.Text);
				int MA3b = Convert.ToInt32(TBoxMA3b.Text);
				int MA4b = Convert.ToInt32(TBoxMA4b.Text);

				int MA1c = Convert.ToInt32(TBoxMA1c.Text);
				int MA2c = Convert.ToInt32(TBoxMA2c.Text);
				int MA3c = Convert.ToInt32(TBoxMA3c.Text);
				int MA4c = Convert.ToInt32(TBoxMA4c.Text);

				int MA1d = Convert.ToInt32(TBoxMA1d.Text);
				int MA2d = Convert.ToInt32(TBoxMA2d.Text);
				int MA3d = Convert.ToInt32(TBoxMA3d.Text);
				int MA4d = Convert.ToInt32(TBoxMA4d.Text);

				int M1Sonuc;
				M1Sonuc =
					(MA1a * MA2b * MA3c * MA4d) - (MA1a * MA2b * MA3d * MA4c) - (MA1a * MA2c * MA3b * MA4d) + (MA1a * MA2c * MA3d * MA4b) + (MA1a * MA2d * MA3b * MA4c) - (MA1a * MA2d * MA3c * MA4b) - (MA1b * MA2a * MA3c * MA4d) + (MA1b * MA2a * MA3d * MA4c) + (MA1b * MA2c * MA3a * MA4d) - (MA1b * MA2c * MA3d * MA4a) - (MA1b * MA2d * MA3a * MA4c) + (MA1b * MA2d * MA3c * MA4a) + (MA1c * MA2a * MA3b * MA4d) - (MA1c * MA2a * MA3d * MA4b) - (MA1c * MA2b * MA3a * MA4d) + (MA1c * MA2b * MA3d * MA4a) + (MA1c * MA2d * MA3a * MA4b) - (MA1c * MA2d * MA3b * MA4a) - (MA1d * MA2a * MA3b * MA4c) + (MA1d * MA2a * MA3c * MA4b) + (MA1d * MA2b * MA3a * MA4c) - (MA1d * MA2b * MA3c * MA4a) - (MA1d * MA2c * MA3a * MA4b) + (MA1d * MA2c * MA3b * MA4a);
				richTextBox1.Clear();
				richTextBox1.Text += Convert.ToString("[ " + M1Sonuc + " ]");
			}
		}
		private void checkBoxDet2x2_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxDet2x2.Checked)
			{
				TBoxMA1d.Visible = false;
				TBoxMA2d.Visible = false;
				TBoxMA3d.Visible = false;
				TBoxMA4d.Visible = false;
				TBoxMA1c.Visible = false;
				TBoxMA2c.Visible = false;
				TBoxMA3c.Visible = false;
				TBoxMA4c.Visible = false;
				TBoxMA3a.Visible = false;
				TBoxMA3b.Visible = false;
				TBoxMA4a.Visible = false;
				TBoxMA4b.Visible = false;
				TBoxMB1a.Visible = false;
				TBoxMB2a.Visible = false;
				TBoxMB3a.Visible = false;
				TBoxMB4a.Visible = false;
				TBoxMB1b.Visible = false;
				TBoxMB2b.Visible = false;
				TBoxMB3b.Visible = false;
				TBoxMB4b.Visible = false;
				TBoxMB1c.Visible = false;
				TBoxMB2c.Visible = false;
				TBoxMB3c.Visible = false;
				TBoxMB4c.Visible = false;
				TBoxMB1d.Visible = false;
				TBoxMB2d.Visible = false;
				TBoxMB3d.Visible = false;
				TBoxMB4d.Visible = false;
			}
			else
			{
				TBoxMA1d.Visible = true;
				TBoxMA2d.Visible = true;
				TBoxMA3d.Visible = true;
				TBoxMA4d.Visible = true;
				TBoxMA1c.Visible = true;
				TBoxMA2c.Visible = true;
				TBoxMA3c.Visible = true;
				TBoxMA4c.Visible = true;
				TBoxMA3a.Visible = true;
				TBoxMA3b.Visible = true;
				TBoxMA4a.Visible = true;
				TBoxMA4b.Visible = true;
				TBoxMB1a.Visible = true;
				TBoxMB2a.Visible = true;
				TBoxMB3a.Visible = true;
				TBoxMB4a.Visible = true;
				TBoxMB1b.Visible = true;
				TBoxMB2b.Visible = true;
				TBoxMB3b.Visible = true;
				TBoxMB4b.Visible = true;
				TBoxMB1c.Visible = true;
				TBoxMB2c.Visible = true;
				TBoxMB3c.Visible = true;
				TBoxMB4c.Visible = true;
				TBoxMB1d.Visible = true;
				TBoxMB2d.Visible = true;
				TBoxMB3d.Visible = true;
				TBoxMB4d.Visible = true;
			}
		}
		private void checkBoxDet3x3_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxDet3x3.Checked)
			{
				TBoxMA1d.Visible = false;
				TBoxMA2d.Visible = false;
				TBoxMA3d.Visible = false;
				TBoxMA4d.Visible = false;
				TBoxMA4a.Visible = false;
				TBoxMA4b.Visible = false;
				TBoxMA4c.Visible = false;
				TBoxMB1a.Visible = false;
				TBoxMB2a.Visible = false;
				TBoxMB3a.Visible = false;
				TBoxMB4a.Visible = false;
				TBoxMB1b.Visible = false;
				TBoxMB2b.Visible = false;
				TBoxMB3b.Visible = false;
				TBoxMB4b.Visible = false;
				TBoxMB1c.Visible = false;
				TBoxMB2c.Visible = false;
				TBoxMB3c.Visible = false;
				TBoxMB4c.Visible = false;
				TBoxMB1d.Visible = false;
				TBoxMB2d.Visible = false;
				TBoxMB3d.Visible = false;
				TBoxMB4d.Visible = false;
			}
			else
			{
				TBoxMA1d.Visible = true;
				TBoxMA2d.Visible = true;
				TBoxMA3d.Visible = true;
				TBoxMA4d.Visible = true;
				TBoxMA4a.Visible = true;
				TBoxMA4b.Visible = true;
				TBoxMA4c.Visible = true;
				TBoxMB1a.Visible = true;
				TBoxMB2a.Visible = true;
				TBoxMB3a.Visible = true;
				TBoxMB4a.Visible = true;
				TBoxMB1b.Visible = true;
				TBoxMB2b.Visible = true;
				TBoxMB3b.Visible = true;
				TBoxMB4b.Visible = true;
				TBoxMB1c.Visible = true;
				TBoxMB2c.Visible = true;
				TBoxMB3c.Visible = true;
				TBoxMB4c.Visible = true;
				TBoxMB1d.Visible = true;
				TBoxMB2d.Visible = true;
				TBoxMB3d.Visible = true;
				TBoxMB4d.Visible = true;
			}
		}
		private void ButtonHakkinda_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Çarpma & Toplama & Çıkarma işlemleri için öncellikle işlem türünü seçiniz.\n" +
				"Matriks alanlarında gerekli alanları doldurup sağ alttan hesaplatın.." +
				"\n\nc# Eğitim amaçlı hazırlanmıştır.. " +
				"\nHata veya eksik durumlardan bilgi verirseniz, programı düzenleyelim.");
		}
		private void checkBoxToplama2x2_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxToplama2x2.Checked)
			{
				TBoxMA1d.Visible = false;
				TBoxMA2d.Visible = false;
				TBoxMA3d.Visible = false;
				TBoxMA4d.Visible = false;
				TBoxMA1c.Visible = false;
				TBoxMA2c.Visible = false;
				TBoxMA3c.Visible = false;
				TBoxMA4c.Visible = false;
				TBoxMA3a.Visible = false;
				TBoxMA3b.Visible = false;
				TBoxMA4a.Visible = false;
				TBoxMA4b.Visible = false;
				TBoxMB1d.Visible = false;
				TBoxMB2d.Visible = false;
				TBoxMB3d.Visible = false;
				TBoxMB4d.Visible = false;
				TBoxMB1c.Visible = false;
				TBoxMB2c.Visible = false;
				TBoxMB3c.Visible = false;
				TBoxMB4c.Visible = false;
				TBoxMB3a.Visible = false;
				TBoxMB3b.Visible = false;
				TBoxMB4a.Visible = false;
				TBoxMB4b.Visible = false;

			}
			else
			{
				TBoxMA1d.Visible = true;
				TBoxMA2d.Visible = true;
				TBoxMA3d.Visible = true;
				TBoxMA4d.Visible = true;
				TBoxMA1c.Visible = true;
				TBoxMA2c.Visible = true;
				TBoxMA3c.Visible = true;
				TBoxMA4c.Visible = true;
				TBoxMA3a.Visible = true;
				TBoxMA3b.Visible = true;
				TBoxMA4a.Visible = true;
				TBoxMA4b.Visible = true;
				TBoxMB1d.Visible = true;
				TBoxMB2d.Visible = true;
				TBoxMB3d.Visible = true;
				TBoxMB4d.Visible = true;
				TBoxMB1c.Visible = true;
				TBoxMB2c.Visible = true;
				TBoxMB3c.Visible = true;
				TBoxMB4c.Visible = true;
				TBoxMB3a.Visible = true;
				TBoxMB3b.Visible = true;
				TBoxMB4a.Visible = true;
				TBoxMB4b.Visible = true;
			}
		}
		private void checkBoxToplama3x3_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxToplama3x3.Checked)
			{
				TBoxMA1d.Visible = false;
				TBoxMA2d.Visible = false;
				TBoxMA3d.Visible = false;
				TBoxMA4d.Visible = false;
				TBoxMA4a.Visible = false;
				TBoxMA4b.Visible = false;
				TBoxMA4c.Visible = false;
				TBoxMB1d.Visible = false;
				TBoxMB2d.Visible = false;
				TBoxMB3d.Visible = false;
				TBoxMB4d.Visible = false;
				TBoxMB4a.Visible = false;
				TBoxMB4b.Visible = false;
				TBoxMB4c.Visible = false;
			}
			else
			{
				TBoxMA1d.Visible = true;
				TBoxMA2d.Visible = true;
				TBoxMA3d.Visible = true;
				TBoxMA4d.Visible = true;
				TBoxMA4a.Visible = true;
				TBoxMA4b.Visible = true;
				TBoxMA4c.Visible = true;
				TBoxMB1d.Visible = true;
				TBoxMB2d.Visible = true;
				TBoxMB3d.Visible = true;
				TBoxMB4d.Visible = true;
				TBoxMB4a.Visible = true;
				TBoxMB4b.Visible = true;
				TBoxMB4c.Visible = true;
			}
		}
		private void checkBoxCikarma2x2_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxCikarma2x2.Checked)
			{
				TBoxMA1d.Visible = false;
				TBoxMA2d.Visible = false;
				TBoxMA3d.Visible = false;
				TBoxMA4d.Visible = false;
				TBoxMA1c.Visible = false;
				TBoxMA2c.Visible = false;
				TBoxMA3c.Visible = false;
				TBoxMA4c.Visible = false;
				TBoxMA3a.Visible = false;
				TBoxMA3b.Visible = false;
				TBoxMA4a.Visible = false;
				TBoxMA4b.Visible = false;
				TBoxMB1d.Visible = false;
				TBoxMB2d.Visible = false;
				TBoxMB3d.Visible = false;
				TBoxMB4d.Visible = false;
				TBoxMB1c.Visible = false;
				TBoxMB2c.Visible = false;
				TBoxMB3c.Visible = false;
				TBoxMB4c.Visible = false;
				TBoxMB3a.Visible = false;
				TBoxMB3b.Visible = false;
				TBoxMB4a.Visible = false;
				TBoxMB4b.Visible = false;

			}
			else
			{
				TBoxMA1d.Visible = true;
				TBoxMA2d.Visible = true;
				TBoxMA3d.Visible = true;
				TBoxMA4d.Visible = true;
				TBoxMA1c.Visible = true;
				TBoxMA2c.Visible = true;
				TBoxMA3c.Visible = true;
				TBoxMA4c.Visible = true;
				TBoxMA3a.Visible = true;
				TBoxMA3b.Visible = true;
				TBoxMA4a.Visible = true;
				TBoxMA4b.Visible = true;
				TBoxMB1d.Visible = true;
				TBoxMB2d.Visible = true;
				TBoxMB3d.Visible = true;
				TBoxMB4d.Visible = true;
				TBoxMB1c.Visible = true;
				TBoxMB2c.Visible = true;
				TBoxMB3c.Visible = true;
				TBoxMB4c.Visible = true;
				TBoxMB3a.Visible = true;
				TBoxMB3b.Visible = true;
				TBoxMB4a.Visible = true;
				TBoxMB4b.Visible = true;
			}
		}
		private void checkBoxCikarma3x3_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxCikarma3x3.Checked)
			{
				TBoxMA1d.Visible = false;
				TBoxMA2d.Visible = false;
				TBoxMA3d.Visible = false;
				TBoxMA4d.Visible = false;
				TBoxMA4a.Visible = false;
				TBoxMA4b.Visible = false;
				TBoxMA4c.Visible = false;
				TBoxMB1d.Visible = false;
				TBoxMB2d.Visible = false;
				TBoxMB3d.Visible = false;
				TBoxMB4d.Visible = false;
				TBoxMB4a.Visible = false;
				TBoxMB4b.Visible = false;
				TBoxMB4c.Visible = false;
			}
			else
			{
				TBoxMA1d.Visible = true;
				TBoxMA2d.Visible = true;
				TBoxMA3d.Visible = true;
				TBoxMA4d.Visible = true;
				TBoxMA4a.Visible = true;
				TBoxMA4b.Visible = true;
				TBoxMA4c.Visible = true;
				TBoxMB1d.Visible = true;
				TBoxMB2d.Visible = true;
				TBoxMB3d.Visible = true;
				TBoxMB4d.Visible = true;
				TBoxMB4a.Visible = true;
				TBoxMB4b.Visible = true;
				TBoxMB4c.Visible = true;
			}
		}
	}

}
