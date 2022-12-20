using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_7_1_Forms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				String beginStr = textBox1.Text;
				String strReplace = textBox2.Text;
				bool check = false;

				if (strReplace.Length != 1)
				{
					throw new Exception();
				}

				for (int i = 0; i < beginStr.Length; i++)
				{
					if (strReplace[0] == beginStr[i])
					{
						check = true;
						break;
					}
				}

				if (check)
				{
					String afterStr = beginStr.Replace(strReplace, (strReplace + strReplace));
					textBox3.Text = ("Новая строка с удвоенными буквами\r\n" + afterStr);
				}
				else
				{
					throw new Exception();
				}
			}
			catch (FormatException)
			{
				textBox3.Text = ("Введите корректные данные");
			}
			catch
			{
				textBox3.Text = ("Такого символа нет в строке и/или в строке должен быть один символ");
			}
		}
	}
}
