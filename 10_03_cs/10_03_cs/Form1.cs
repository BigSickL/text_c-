using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//jedina klavesa co nema funkci je alt protoze jsem už nevymyslel co dalsiho bych na klavesnici mohl delat
//ale funguje zpet, tab, shift, enter, capslock, restart, zmena klavesnice je tlacitko CZ/ENG, winlock, a vsechny tlacitka na numpadu
//taky funguje moznost ulozeni, otevreni souboru a zmena fontu a barvy
// alt == alternativni ulozeni
namespace _10_03_cs
{
    public partial class Form1 : Form
    {
        string retezec;
        int i = 0, j = 0, c = 0, num = 0;
        bool shift = false;//shift jsem pridal posledni a chctel jsem zkusit bool typ
        
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = filter;
            saveFileDialog1.Filter = filter;
        }
        
        private string filter = "Textový soubor (*.txt)|*.txt|dokument *.doc|*.doc";
        
        private void otevřítToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                retezec = sr.ReadToEnd();
                textBox1.Text = retezec;
                sr.Close();
            }
        }
        
        private void uložitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                retezec = textBox1.Text;
                sw.WriteLine(retezec);
                sw.Close();
            }
        }
        
        private void pismoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = false;
            fontDialog1.Font = textBox1.Font;
            fontDialog1.Color = textBox1.ForeColor;

            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
                textBox1.ForeColor = fontDialog1.Color;
            }
        }
        
        private void barvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.ShowHelp = true;
            MyDialog.Color = textBox1.ForeColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = MyDialog.Color;
            }
        }
        private void btn_res_click(object sender, EventArgs e)
        {
            retezec = "";
            textBox1.Text = retezec;
            i = 0;
            j = 0;
            c = 0;
            shift = false;
            oprava();
        }

        private void oprava()//jsem nevedel jak jinak spravit velke a male pismena kdyz zmacknu shift
        {
            if (j == 0)//ENG
            {
                if(i == 0 && shift == false)//male
                {
                    btn_1.Text = "1";
                    btn_2.Text = "2";
                    btn_3.Text = "3";
                    btn_4.Text = "4";
                    btn_5.Text = "5";
                    btn_6.Text = "6";
                    btn_7.Text = "7";
                    btn_8.Text = "8";
                    btn_9.Text = "9";
                    btn_0.Text = "0";
                    btn_minus.Text = "-";
                    btn_rovnase.Text = "=";
                    btn_q.Text = "q";
                    btn_w.Text = "w";
                    btn_e.Text = "e";
                    btn_r.Text = "r";
                    btn_t.Text = "t";
                    btn_y.Text = "z";
                    btn_u.Text = "u";
                    btn_i.Text = "i";
                    btn_o.Text = "o";
                    btn_p.Text = "p";
                    btn_zv_0.Text = "[";
                    btn_zv_1.Text = "]";
                    btn_a.Text = "a";
                    btn_s.Text = "s";
                    btn_d.Text = "d";
                    btn_f.Text = "f";
                    btn_g.Text = "g";
                    btn_h.Text = "h";
                    btn_j.Text = "j";
                    btn_k.Text = "k";
                    btn_l.Text = "l";
                    btn_zv_2.Text = ";";
                    btn_zv_3.Text = "'";
                    btn_zv_4.Text = "¨";
                    btn_z.Text = "y";
                    btn_x.Text = "x";
                    btn_c.Text = "c";
                    btn_v.Text = "v";
                    btn_b.Text = "b";
                    btn_n.Text = "n";
                    btn_m.Text = "m";
                    btn_zv_5.Text = ",";
                    btn_zv_6.Text = ".";
                    btn_zv_7.Text = "/";
                }
                else if(i == 1 || shift == true)//velke
                {
                    btn_1.Text = "!";
                    btn_2.Text = "@";
                    btn_3.Text = "#";
                    btn_4.Text = "$";
                    btn_5.Text = "%";
                    btn_6.Text = "^";
                    btn_7.Text = "&";
                    btn_8.Text = "*";
                    btn_9.Text = "(";
                    btn_0.Text = ")";
                    btn_minus.Text = "_";
                    btn_rovnase.Text = "+";
                    btn_q.Text = "Q";
                    btn_w.Text = "W";
                    btn_e.Text = "E";
                    btn_r.Text = "R";
                    btn_t.Text = "T";
                    btn_y.Text = "Z";
                    btn_u.Text = "U";
                    btn_i.Text = "I";
                    btn_o.Text = "O";
                    btn_p.Text = "P";
                    btn_zv_0.Text = "{";
                    btn_zv_1.Text = "}";
                    btn_a.Text = "A";
                    btn_s.Text = "S";
                    btn_d.Text = "D";
                    btn_f.Text = "F";
                    btn_g.Text = "G";
                    btn_h.Text = "H";
                    btn_j.Text = "J";
                    btn_k.Text = "K";
                    btn_l.Text = "L";
                    btn_zv_2.Text = ":";
                    btn_zv_3.Text = "''";
                    btn_zv_4.Text = "'";
                    btn_z.Text = "Y";
                    btn_x.Text = "X";
                    btn_c.Text = "C";
                    btn_v.Text = "V";
                    btn_b.Text = "B";
                    btn_n.Text = "N";
                    btn_m.Text = "M";
                    btn_zv_5.Text = "<";
                    btn_zv_6.Text = ">";
                    btn_zv_7.Text = "?";
                }
            }

            else if (j == 1)//CZ
            {
                if (i == 0 && shift == false)//male
                {
                    btn_1.Text = "+";
                    btn_2.Text = "ě";
                    btn_3.Text = "š";
                    btn_4.Text = "č";
                    btn_5.Text = "ř";
                    btn_6.Text = "ž";
                    btn_7.Text = "ý";
                    btn_8.Text = "á";
                    btn_9.Text = "í";
                    btn_0.Text = "é";
                    btn_minus.Text = "=";
                    btn_rovnase.Text = "´";
                    btn_q.Text = "q";
                    btn_w.Text = "w";
                    btn_e.Text = "e";
                    btn_r.Text = "r";
                    btn_t.Text = "t";
                    btn_y.Text = "z";
                    btn_u.Text = "u";
                    btn_i.Text = "i";
                    btn_o.Text = "o";
                    btn_p.Text = "p";
                    btn_zv_0.Text = "ú";
                    btn_zv_1.Text = ")";
                    btn_a.Text = "a";
                    btn_s.Text = "s";
                    btn_d.Text = "d";
                    btn_f.Text = "f";
                    btn_g.Text = "g";
                    btn_h.Text = "h";
                    btn_j.Text = "j";
                    btn_k.Text = "k";
                    btn_l.Text = "l";
                    btn_zv_2.Text = "ů";
                    btn_zv_3.Text = "§";
                    btn_zv_4.Text = "¨";
                    btn_z.Text = "z";
                    btn_x.Text = "x";
                    btn_c.Text = "c";
                    btn_v.Text = "v";
                    btn_b.Text = "b";
                    btn_n.Text = "n";
                    btn_m.Text = "m";
                    btn_zv_5.Text = ",";
                    btn_zv_6.Text = ".";
                    btn_zv_7.Text = "-";
                }
                else if (i == 1 || shift == true)//velke
                {
                    if (i == 0 && shift == true)//shift
                    {
                        btn_1.Text = "1";
                        btn_2.Text = "2";
                        btn_3.Text = "3";
                        btn_4.Text = "4";
                        btn_5.Text = "5";
                        btn_6.Text = "6";
                        btn_7.Text = "7";
                        btn_8.Text = "8";
                        btn_9.Text = "9";
                        btn_0.Text = "0";
                        btn_minus.Text = "%";
                        btn_rovnase.Text = "ˇ";
                    }
                    else if (i == 1 && shift == false)//caps
                    {
                        btn_1.Text = "+";
                        btn_2.Text = "Ě";
                        btn_3.Text = "Š";
                        btn_4.Text = "Č";
                        btn_5.Text = "Ř";
                        btn_6.Text = "Ž";
                        btn_7.Text = "Ý";
                        btn_8.Text = "Á";
                        btn_9.Text = "Í";
                        btn_0.Text = "É";
                        btn_minus.Text = "=";
                        btn_rovnase.Text = "´";
                    }
                    btn_q.Text = "Q";
                    btn_w.Text = "W";
                    btn_e.Text = "E";
                    btn_r.Text = "R";
                    btn_t.Text = "T";
                    btn_y.Text = "Y";
                    btn_u.Text = "U";
                    btn_i.Text = "I";
                    btn_o.Text = "O";
                    btn_p.Text = "P";
                    btn_zv_0.Text = "/";
                    btn_zv_1.Text = "(";
                    btn_a.Text = "A";
                    btn_s.Text = "S";
                    btn_d.Text = "D";
                    btn_f.Text = "F";
                    btn_g.Text = "G";
                    btn_h.Text = "H";
                    btn_j.Text = "J";
                    btn_k.Text = "K";
                    btn_l.Text = "L";
                    btn_zv_2.Text = "¨";
                    btn_zv_3.Text = "!";
                    btn_zv_4.Text = "'";
                    btn_z.Text = "Z";
                    btn_x.Text = "X";
                    btn_c.Text = "C";
                    btn_v.Text = "V";
                    btn_b.Text = "B";
                    btn_n.Text = "N";
                    btn_m.Text = "M";
                    btn_zv_5.Text = "?";
                    btn_zv_6.Text = ":";
                    btn_zv_7.Text = "_";
                }
            }
        }

        private void btn_enter(object sender, EventArgs e)
        {
            retezec = retezec + "\r\n";
            textBox1.Text = retezec;
        }
        private void btn_zpet_click(object sender, EventArgs e)
        {
            if (retezec.Length > 1)
            {
                retezec = retezec.Remove(retezec.Length - 1);
            }
            else
            {
                retezec = "";
            }
            textBox1.Text = retezec;
        }

        private void btn_eng_cz_click(object sender, EventArgs e)
        {
            if(j == 0)//CZ
            {
                j = 1;
                btn_eng_0.Text = "ENG";
                btn_eng_1.Text = "ENG";
                label1.Text = "Aktualni: CZ";
            }
            else//ENG
            {
                j = 0;
                btn_eng_0.Text = "CZ";
                btn_eng_1.Text = "CZ";
                label1.Text = "Aktualni: ENG";
            }
            oprava();
            shift = false;
        }

        private void btn_capslock_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                checkBox2.Checked = true;
                i = 1;
                btn_q.Text = btn_q.Text.ToUpper();
                btn_w.Text = btn_w.Text.ToUpper();
                btn_e.Text = btn_e.Text.ToUpper();
                btn_r.Text = btn_r.Text.ToUpper();
                btn_t.Text = btn_t.Text.ToUpper();
                btn_z.Text = btn_z.Text.ToUpper();
                btn_u.Text = btn_u.Text.ToUpper();
                btn_i.Text = btn_i.Text.ToUpper();
                btn_o.Text = btn_o.Text.ToUpper();
                btn_p.Text = btn_p.Text.ToUpper();
                btn_a.Text = btn_a.Text.ToUpper();
                btn_s.Text = btn_s.Text.ToUpper();
                btn_d.Text = btn_d.Text.ToUpper();
                btn_f.Text = btn_f.Text.ToUpper();
                btn_g.Text = btn_g.Text.ToUpper();
                btn_h.Text = btn_h.Text.ToUpper();
                btn_j.Text = btn_j.Text.ToUpper();
                btn_k.Text = btn_k.Text.ToUpper();
                btn_l.Text = btn_l.Text.ToUpper();
                btn_y.Text = btn_y.Text.ToUpper();
                btn_x.Text = btn_x.Text.ToUpper();
                btn_c.Text = btn_c.Text.ToUpper();
                btn_v.Text = btn_v.Text.ToUpper();
                btn_b.Text = btn_b.Text.ToUpper();
                btn_n.Text = btn_n.Text.ToUpper();
                btn_m.Text = btn_m.Text.ToUpper();
            }
            else
            {
                checkBox2.Checked = false;
                i = 0;
                btn_q.Text = btn_q.Text.ToLower();
                btn_w.Text = btn_w.Text.ToLower();
                btn_e.Text = btn_e.Text.ToLower();
                btn_r.Text = btn_r.Text.ToLower();
                btn_t.Text = btn_t.Text.ToLower();
                btn_z.Text = btn_z.Text.ToLower();
                btn_u.Text = btn_u.Text.ToLower();
                btn_i.Text = btn_i.Text.ToLower();
                btn_o.Text = btn_o.Text.ToLower();
                btn_p.Text = btn_p.Text.ToLower();
                btn_a.Text = btn_a.Text.ToLower();
                btn_s.Text = btn_s.Text.ToLower();
                btn_d.Text = btn_d.Text.ToLower();
                btn_f.Text = btn_f.Text.ToLower();
                btn_g.Text = btn_g.Text.ToLower();
                btn_h.Text = btn_h.Text.ToLower();
                btn_j.Text = btn_j.Text.ToLower();
                btn_k.Text = btn_k.Text.ToLower();
                btn_l.Text = btn_l.Text.ToLower();
                btn_y.Text = btn_y.Text.ToLower();
                btn_x.Text = btn_x.Text.ToLower();
                btn_c.Text = btn_c.Text.ToLower();
                btn_v.Text = btn_v.Text.ToLower();
                btn_b.Text = btn_b.Text.ToLower();
                btn_n.Text = btn_n.Text.ToLower();
                btn_m.Text = btn_m.Text.ToUpper();
            }
            oprava();
        }

        private void btn_tab_Click(object sender, EventArgs e)
        {
            retezec = retezec + "   ";
            textBox1.Text = retezec;
            oprava();
        }

        private void btn_shift_Click(object sender, EventArgs e)
        {
            shift = true;
            oprava();
        }

        private void btn_strednik_click(object sender, EventArgs e)
        {
            retezec += ";";
            textBox1.Text = retezec;
            shift = false;
            oprava();
        }
        private void btn_1_click(object sender, EventArgs e)
        {
            if (j == 0)//ENG
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "1";
                    textBox1.Text = retezec;
                }
                else if(i == 1 || shift == true)//velke
                {
                    retezec = retezec + "!";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            else//CZ
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "+";
                    textBox1.Text = retezec;
                }
                else if(i == 1 || shift == true)//velke
                {
                    retezec = retezec + "1";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            oprava();
        }
        private void btn_2_click(object sender, EventArgs e)
        {
            if (j == 0)//ENG
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "2";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "@";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            else//CZ
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "ě";
                    textBox1.Text = retezec;
                }
                else if (shift == true)//velke shift
                {
                    retezec = retezec + "2";
                    textBox1.Text = retezec;
                    shift = false;
                }
                else if(i == 1)//velke caps
                {
                    retezec = retezec + "Ě";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            oprava();
        }
        private void btn_3_click(object sender, EventArgs e)
        {
            if (j == 0)//ENG
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "3";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "#";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            else//CZ
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "š";
                    textBox1.Text = retezec;
                }
                else if (shift == true)//velke shift
                {
                    retezec = retezec + "3";
                    textBox1.Text = retezec;
                    shift = false;
                }
                else if (i == 1)//velke caps
                {
                    retezec = retezec + "Š";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            oprava();
        }
        private void btn_4_click(object sender, EventArgs e)
        {
            if (j == 0)//ENG
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "4";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "$";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            else//CZ
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "č";
                    textBox1.Text = retezec;
                }
                else if(shift == true)//velke shift
                {
                    retezec = retezec + "4";
                    textBox1.Text = retezec;
                    shift = false;
                }
                else if (i == 1)//velke caps
                {
                    retezec = retezec + "Č";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            oprava();
        }
        private void btn_5_click(object sender, EventArgs e)
        {
            if (j == 0)//ENG
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "5";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "%";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            else//CZ
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "ř";
                    textBox1.Text = retezec;
                }
                else if (shift == true)//velke shift
                {
                    retezec = retezec + "5";
                    textBox1.Text = retezec;
                    shift = false;
                }
                else if (i == 1)//velke caps
                {
                    retezec = retezec + "Ř";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            oprava();
        }
        private void btn_6_click(object sender, EventArgs e)
        {
            if (j == 0)//ENG
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "6";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "^";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            else//CZ
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "ž";
                    textBox1.Text = retezec;
                }
                else if (shift == true)//velke shift
                {
                    retezec = retezec + "6";
                    textBox1.Text = retezec;
                    shift = false;
                }
                else if (i == 1)//velke caps
                {
                    retezec = retezec + "Ž";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            oprava();
        }
        private void btn_7_click(object sender, EventArgs e)
        {
            if (j == 0)//ENG
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "7";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "&";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            else//CZ
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "ý";
                    textBox1.Text = retezec;
                }
                else if (shift == true)//velke shift
                {
                    retezec = retezec + "7";
                    textBox1.Text = retezec;
                    shift = false;
                }
                else if (i == 1)//velke caps
                {
                    retezec = retezec + "Ý";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            oprava();
        }
        private void btn_8_click(object sender, EventArgs e)
        {
            if (j == 0)//ENG
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "8";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "*";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            else//CZ
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "á";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke shift
                {
                    retezec = retezec + "8";
                    textBox1.Text = retezec;
                    shift = false;
                }
                else if (i == 1)//velke caps
                {
                    retezec = retezec + "Á";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            oprava();
        }
        private void btn_9_click(object sender, EventArgs e)
        {
            if (j == 0)//ENG
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "9";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "(";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            else//CZ
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "í";
                    textBox1.Text = retezec;
                }
                else if (shift == true)//velke shift
                {
                    retezec = retezec + "9";
                    textBox1.Text = retezec;
                    shift = false;
                }
                else if (i == 1)//velke caps
                {
                    retezec = retezec + "Í";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            oprava();
        }
        private void btn_0_click(object sender, EventArgs e)
        {
            if (j == 0)//ENG
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "0";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + ")";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            else//CZ
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "é";
                    textBox1.Text = retezec;
                }
                else if (shift == true)//velke shift
                {
                    retezec = retezec + "0";
                    textBox1.Text = retezec;
                    shift = false;
                }
                else if (i == 1)//velke caps
                {
                    retezec = retezec + "É";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            oprava();
        }
        private void btn_minus_click(object sender, EventArgs e)
        {
            if (j == 0)//ENG
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "-";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "_";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            else//CZ
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "=";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "%";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            oprava();
        }
        private void btn_rovnase_click(object sender, EventArgs e)
        {
            if (j == 0)//ENG
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "=";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "+";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            else//CZ
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "´";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "ˇ";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            oprava();
        }
        private void btn_q_Click(object sender, EventArgs e)
        {
            if (i == 0 && shift == false)//male
            {
                retezec = retezec + "q";
                textBox1.Text = retezec;
            }
            else if (i == 1 || shift == true)//velke
            {
                retezec = retezec + "Q";
                textBox1.Text = retezec;
                shift = false;
            }
            oprava();
        }
        private void btn_w_Click(object sender, EventArgs e)
        {
            if (i == 0 && shift == false)//male
            {
                retezec = retezec + "w";
                textBox1.Text = retezec;
            }
            else if (i == 1 || shift == true)//velke
            {
                retezec = retezec + "W";
                textBox1.Text = retezec;
                shift = false;
            }
            oprava();
        }
        private void btn_e_Click(object sender, EventArgs e)
        {
            if (i == 0 && shift == false)//male
            {
                retezec = retezec + "e";
                textBox1.Text = retezec;
            }
            else if (i == 1 || shift == true)//velke
            {
                retezec = retezec + "E";
                textBox1.Text = retezec;
                shift = false;
            }
            oprava();
        }
        private void btn_r_Click(object sender, EventArgs e)
        {
            if (i == 0 && shift == false)//male
            {
                retezec = retezec + "r";
                textBox1.Text = retezec;
            }
            else if (i == 1 || shift == true)//velke
            {
                retezec = retezec + "R";
                textBox1.Text = retezec;
                shift = false;
            }
            oprava();
        }
        private void btn_t_Click(object sender, EventArgs e)
        {
            if (i == 0 && shift == false)//male
            {
                retezec = retezec + "t";
                textBox1.Text = retezec;
            }
            else if (i == 1 || shift == true)//velke
            {
                retezec = retezec + "T";
                textBox1.Text = retezec;
                shift = false;
            }
            oprava();
        }
        private void btn_z_Click(object sender, EventArgs e)
        {
            if (j == 0)//ENG
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "y";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "Y";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            else//CZ
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "z";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "Z";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            oprava();
        }
        private void btn_u_Click(object sender, EventArgs e)
        {
            if (i == 0 && shift == false)//male
            {
                retezec = retezec + "u";
                textBox1.Text = retezec;
            }
            else if (i == 1 || shift == true)//velke
            {
                retezec = retezec + "U";
                textBox1.Text = retezec;
                shift = false;
            }
            oprava();
        }
        private void btn_i_Click(object sender, EventArgs e)
        {
            if (i == 0 && shift == false)//male
            {
                retezec = retezec + "i";
                textBox1.Text = retezec;
            }
            else if (i == 1 || shift == true)//velke
            {
                retezec = retezec + "I";
                textBox1.Text = retezec;
                shift = false;
            }
            oprava();
        }
        private void btn_o_Click(object sender, EventArgs e)
        {
            if (i == 0 && shift == false)//male
            {
                retezec = retezec + "o";
                textBox1.Text = retezec;
            }
            else if (i == 1 || shift == true)//velke
            {
                retezec = retezec + "O";
                textBox1.Text = retezec;
                shift = false;
            }
            oprava();
        }
        private void btn_p_Click(object sender, EventArgs e)
        {
            if (i == 0 && shift == false)//male
            {
                retezec = retezec + "p";
                textBox1.Text = retezec;
            }
            else if (i == 1 || shift == true)//velke
            {
                retezec = retezec + "P";
                textBox1.Text = retezec;
                shift = false;
            }
            oprava();
        }
        private void btn_zv_0_Click(object sender, EventArgs e)//zv = zvlastni
        {
            if (j == 0)//ENG
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "[";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "{";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            else//CZ
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "ú";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "/";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            oprava();
        }
        private void btn_zv_1_Click(object sender, EventArgs e)
        {
            if (j == 0)//ENG
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "]";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "}";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            else//CZ
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + ")";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "(";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            oprava();
        }
        private void btn_a_Click(object sender, EventArgs e)
        {
            if (i == 0 && shift == false)//male
            {
                retezec = retezec + "a";
                textBox1.Text = retezec;
            }
            else if (i == 1 || shift == true)//velke
            {
                retezec = retezec + "A";
                textBox1.Text = retezec;
                shift = false;
            }
            oprava();
        }
        private void btn_s_Click(object sender, EventArgs e)
        {
            if (i == 0 && shift == false)//male
            {
                retezec = retezec + "s";
                textBox1.Text = retezec;
            }
            else if (i == 1 || shift == true)//velke
            {
                retezec = retezec + "S";
                textBox1.Text = retezec;
                shift = false;
            }
            oprava();
        }
        private void btn_d_Click(object sender, EventArgs e)
        {
            if (i == 0 && shift == false)//male
            {
                retezec = retezec + "d";
                textBox1.Text = retezec;
            }
            else if (i == 1 || shift == true)//velke
            {
                retezec = retezec + "D";
                textBox1.Text = retezec;
                shift = false;
            }
            oprava();
        }
        private void btn_f_Click(object sender, EventArgs e)
        {
            if (i == 0 && shift == false)//male
            {
                retezec = retezec + "f";
                textBox1.Text = retezec;
            }
            else if (i == 1 || shift == true)//velke
            {
                retezec = retezec + "F";
                textBox1.Text = retezec;
                shift = false;
            }
            oprava();
        }
        private void btn_g_Click(object sender, EventArgs e)
        {
            if (i == 0 && shift == false)//male
            {
                retezec = retezec + "g";
                textBox1.Text = retezec;
            }
            else if (i == 1 || shift == true)//velke
            {
                retezec = retezec + "G";
                textBox1.Text = retezec;
                shift = false;
            }
            oprava();
        }
        private void btn_h_Click(object sender, EventArgs e)
        {
            if (i == 0 && shift == false)//male
            {
                retezec = retezec + "h";
                textBox1.Text = retezec;
            }
            else if (i == 1 || shift == true)//velke
            {
                retezec = retezec + "H";
                textBox1.Text = retezec;
                shift = false;
            }
            oprava();
        }
        private void btn_j_Click(object sender, EventArgs e)
        {
            if (i == 0 && shift == false)//male
            {
                retezec = retezec + "j";
                textBox1.Text = retezec;
            }
            else if (i == 1 || shift == true)//velke
            {
                retezec = retezec + "J";
                textBox1.Text = retezec;
                shift = false;
            }
            oprava();
        }
        private void btn_k_Click(object sender, EventArgs e)
        {
            if (i == 0 && shift == false)//male
            {
                retezec = retezec + "k";
                textBox1.Text = retezec;
            }
            else if (i == 1 || shift == true)//velke
            {
                retezec = retezec + "K";
                textBox1.Text = retezec;
                shift = false;
            }
            oprava();
        }
        private void btn_l_Click(object sender, EventArgs e)
        {
            if (i == 0 && shift == false)//male
            {
                retezec = retezec + "l";
                textBox1.Text = retezec;
            }
            else if (i == 1 || shift == true)//velke
            {
                retezec = retezec + "L";
                textBox1.Text = retezec;
                shift = false;
            }
            oprava();
        }
        private void btn_zv_2_Click(object sender, EventArgs e)
        {
            if (j == 0)//ENG
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + ";";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + ":";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            else//CZ
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "ů";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "''";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            oprava();
        }
        private void btn_zv_3_Click(object sender, EventArgs e)
        {
            if (j == 0)//ENG
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "§";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "!";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            else//CZ
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "ů";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "§";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            oprava();
        }
        private void btn_zv_4_Click(object sender, EventArgs e)
        {
            if (j == 0)//ENG
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "¨";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "'";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            else//CZ
            {
                if (i == 1 && shift == true)//male
                {
                    retezec = retezec + "\\";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "|";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            oprava();
        }
        private void btn_y_z_Click(object sender, EventArgs e)
        {
            if (j == 0)//ENG
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "z";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "Z";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            else//CZ
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "y";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "Y";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            oprava();
        }
        private void btn_x_Click(object sender, EventArgs e)
        {
            if (i == 0 && shift == false)//male
            {
                retezec = retezec + "x";
                textBox1.Text = retezec;
            }
            else if (i == 1 || shift == true)//velke
            {
                retezec = retezec + "X";
                textBox1.Text = retezec;
                shift = false;
            }
            oprava();
        }
        private void btn_c_Click(object sender, EventArgs e)
        {
            if (i == 0 && shift == false)//male
            {
                retezec = retezec + "c";
                textBox1.Text = retezec;
            }
            else if (i == 1 || shift == true)//velke
            {
                retezec = retezec + "C";
                textBox1.Text = retezec;
                shift = false;
            }
            oprava();
        }
        private void btn_v_Click(object sender, EventArgs e)
        {
            if (i == 0 && shift == false)//male
            {
                retezec = retezec + "v";
                textBox1.Text = retezec;
            }
            else if (i == 1 || shift == true)//velke
            {
                retezec = retezec + "V";
                textBox1.Text = retezec;
                shift = false;
            }
            oprava();
        }
        private void btn_b_Click(object sender, EventArgs e)
        {
            if (i == 0 && shift == false)//male
            {
                retezec = retezec + "b";
                textBox1.Text = retezec;
            }
            else if (i == 1 || shift == true)//velke
            {
                retezec = retezec + "B";
                textBox1.Text = retezec;
                shift = false;
            }
            oprava();
        }
        private void btn_n_Click(object sender, EventArgs e)
        {
            if (i == 0 && shift == false)//male
            {
                retezec = retezec + "n";
                textBox1.Text = retezec;
            }
            else if (i == 1 || shift == true)//velke
            {
                retezec = retezec + "N";
                textBox1.Text = retezec;
                shift = false;
            }
            oprava();
        }
        private void btn_m_Click(object sender, EventArgs e)
        {
            if (i == 0 && shift == false)//male
            {
                retezec = retezec + "m";
                textBox1.Text = retezec;
            }
            else if (i == 1 || shift == true)//velke
            {
                retezec = retezec + "M";
                textBox1.Text = retezec;
                shift = false;
            }
            oprava();
        }
        private void btn_zv_5_Click(object sender, EventArgs e)
        {
            if (j == 0)//ENG
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + ",";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "<";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            else//CZ
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + ",";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "?";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            oprava();
        }
        private void btn_zv_6_Click(object sender, EventArgs e)
        {
            if (j == 0)//ENG
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + ".";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + ">";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            else//CZ
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + ".";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + ":";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            oprava();
        }
        private void btn_zv_7_Click(object sender, EventArgs e)
        {
            if (j == 0)//ENG
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "/";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "?";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            else//CZ
            {
                if (i == 0 && shift == false)//male
                {
                    retezec = retezec + "-";
                    textBox1.Text = retezec;
                }
                else if (i == 1 || shift == true)//velke
                {
                    retezec = retezec + "_";
                    textBox1.Text = retezec;
                    shift = false;
                }
            }
            oprava();
        }
        private void btn_mezernik_Click(object sender, EventArgs e)
        {
            retezec = retezec + " ";
            textBox1.Text = retezec;
        }
        private void btn_num_Click(object sender, EventArgs e)
        {
            if (num == 0)//numlock zapnut
            {
                num = 1;
                checkBox1.Checked = true;
                btn_num_0.Enabled = true;
                btn_num_1.Enabled = true;
                btn_num_2.Enabled = true;
                btn_num_3.Enabled = true;
                btn_num_4.Enabled = true;
                btn_num_5.Enabled = true;
                btn_num_6.Enabled = true;
                btn_num_7.Enabled = true;
                btn_num_8.Enabled = true;
                btn_num_9.Enabled = true;
                btn_num_carka.Enabled = true;
            }
            else if (num == 1)//numlock vypnut
            {
                num = 0;
                checkBox1.Checked = false;
                btn_num_0.Enabled = false;
                btn_num_1.Enabled = false;
                btn_num_2.Enabled = false;
                btn_num_3.Enabled = false;
                btn_num_4.Enabled = false;
                btn_num_5.Enabled = false;
                btn_num_6.Enabled = false;
                btn_num_7.Enabled = false;
                btn_num_8.Enabled = false;
                btn_num_9.Enabled = false;
                btn_num_carka.Enabled = false;
            }
        }

        private void btn_num_0_Click(object sender, EventArgs e)
        {
            retezec = retezec + "0";
            textBox1.Text = retezec;
        }
        private void btn_num_carka_Click(object sender, EventArgs e)
        {
            retezec = retezec + ",";
            textBox1.Text = retezec;
        }
        private void btn_num_1_Click(object sender, EventArgs e)
        {
            retezec = retezec + "1";
            textBox1.Text = retezec;
        }
        private void btn_num_2_Click(object sender, EventArgs e)
        {
            retezec = retezec + "2";
            textBox1.Text = retezec;
        }
        private void btn_num_3_Click(object sender, EventArgs e)
        {
            retezec = retezec + "3";
            textBox1.Text = retezec;
        }
        private void btn_num_4_Click(object sender, EventArgs e)
        {
            retezec = retezec + "4";
            textBox1.Text = retezec;
        }
        private void btn_num_5_Click(object sender, EventArgs e)
        {
            retezec = retezec + "5";
            textBox1.Text = retezec;
        }
        private void btn_num_6_Click(object sender, EventArgs e)
        {
            retezec = retezec + "6";
            textBox1.Text = retezec;
        }
        private void btn_num_7_Click(object sender, EventArgs e)
        {
            retezec = retezec + "7";
            textBox1.Text = retezec;
        }
        private void btn_num_8_Click(object sender, EventArgs e)
        {
            retezec = retezec + "8";
            textBox1.Text = retezec;
        }
        private void btn_num_9_Click(object sender, EventArgs e)
        {
            retezec = retezec + "9";
            textBox1.Text = retezec;
        }
        private void btn_num_deleno_Click(object sender, EventArgs e)
        {
            retezec = retezec + "/";
            textBox1.Text = retezec;
        }
        private void bnt_num_krat_Click(object sender, EventArgs e)
        {
            retezec = retezec + "*";
            textBox1.Text = retezec;
        }
        private void btn_num_minus_Click(object sender, EventArgs e)
        {
            retezec = retezec + "-";
            textBox1.Text = retezec;
        }

        private void btn_alt_0_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("text.txt");
            sw.WriteLine(retezec);
            sw.Close();
        }

        private void btn_num_plus_Click(object sender, EventArgs e)
        {
            retezec = retezec + "+";
            textBox1.Text = retezec;
        }

        private void btn_win_lock_Click(object sender, EventArgs e)
        {
            if (c == 0)//winlock zapnut
            {
                c = 1;
                checkBox3.Checked = true;
                btn_reset_0.Enabled = false;
                btn_reset_1.Enabled = false;
                btn_eng_0.Enabled = false;
                btn_eng_1.Enabled = false;
                btn_alt_0.Enabled = false;
                btn_alt_1.Enabled = false;
            }
            else if (c == 1)//winlock vypnut
            {
                c = 0;
                checkBox3.Checked = false;
                btn_reset_0.Enabled = true;
                btn_reset_1.Enabled = true;
                btn_eng_0.Enabled = true;
                btn_eng_1.Enabled = true;
                btn_alt_0.Enabled = true;
                btn_alt_1.Enabled = true;
            }
        }

        private void konecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}