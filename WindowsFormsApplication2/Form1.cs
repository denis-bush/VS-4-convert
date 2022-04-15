using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Режим перевода из $ в руб.
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Kursznach.Text = "Курс обмена (руб./$):";
            ishodval.Text = "$";
            itogval.Text = "руб.";
        }

        private void Sumkonv_TextChanged(object sender, EventArgs e)
        {

        }

        // Фильтрация вводимых данных в поле "Сумма конвертации"
        private void Sumkonv_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == '-')
            {
                if (Sumkonv.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == ',')
            {
                if (Sumkonv.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    Clozz.Focus();
                return;
            } e.Handled = true;
        
        }

        // Фильтрация вводимых данных в поле "Курс обмена"
        private void Kurs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == '-')
            {
                if (Kurs.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == ',')
            {
                if (Kurs.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    Clozz.Focus();
                return;
            } e.Handled = true;
        }

        private void sumkonv2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == '-')
            {
                if (sumkonv2.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == ',')
            {
                if (sumkonv2.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    Clozz.Focus();
                return;
            } e.Handled = true;
        }

        // Закрытие программы
        private void Clozz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Выполнение конвертации по курсу
        private void doit_Click(object sender, EventArgs e)
        {
            double a=0, b=0, c;
            bool fl1=false, fl2=false;
            if (Sumkonv.Text == "") { a = 0;fl1=true; }
            if (Kurs.Text == "") { b = 0;fl2=true; }
            sumkonv2.Text = Sumkonv.Text;
            if ((radioButton1.Checked) | (radioButton2.Checked) | (radioButton3.Checked) | (radioButton4.Checked))
            {
                if (fl1 == false) { a = Convert.ToDouble(Sumkonv.Text); }
                if (fl2 == false) { b = Convert.ToDouble(Kurs.Text); }
                c = a * b;
                result.Text = Convert.ToString(c);
            }
            else
            {
                Sost.Text = "Конвертация не выбрана";
            }
       
        }

        // Режим перевода из руб. в $
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Kursznach.Text = "Курс обмена ($/руб.):";
            ishodval.Text = "Руб.";
            itogval.Text = "$";
        }

        // Режим перевода из € в руб.
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Kursznach.Text = "Курс обмена (руб./€):";
            ishodval.Text = "€";
            itogval.Text = "руб.";
        }

        // Режим перевода из руб. в €
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Kursznach.Text = "Курс обмена (€/руб.):";
            ishodval.Text = "руб.";
            itogval.Text = "€";
        }
    }
}
