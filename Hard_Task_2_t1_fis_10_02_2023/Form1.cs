using System;
using System.Deployment.Application;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hard_Task_2_t1_fis_10_02_2023
{

    public partial class Form1 : Form
    {
        int city_count = 0;
        bool riga = false;
        bool palermo = false;
        bool varsaw = false;
        bool berlin = false;
        double budjTet = 0;
        string money;
        double travelcost = 0;
        bool From_ES=false;
        public Form1()
        {
            InitializeComponent();

        }


        
        public void button1_Click(object sender, EventArgs e)
        {

            if (city_count <= 5)
            {
                if (comboBox1.Text == "Берлин" && Cities.Berlin.was_there == false)
                {
                    if (city_count == 0)
                    {
                        travelcost += 0;
                        label1.Text += (" Берлин > ");
                        berlin = true;
                        city_count += 1;

                    }
                    else if (city_count < 3 && city_count != 0)
                    {
                        travelcost += Cities.Berlin.transit;
                        travelcost += (Cities.Berlin.transit / 100 * 13);
                        label1.Text += (" Берлин > ");
                        city_count += 1;
                        berlin = true;
                    }
                    else if (city_count == 3)
                    {
                        travelcost += Cities.Berlin.travel_cost;
                        travelcost += (Cities.Berlin.travel_cost / 100 * 13);
                        label1.Text += (" Берлин ");
                        city_count += 1;


                    }
                    if (From_ES == false && city_count < 3 && city_count >= 1)
                    {
                        travelcost += (Cities.Berlin.transit / 100 * 4);
                    }
                    else if (From_ES == false && city_count == 3)
                    {
                        travelcost += (Cities.Berlin.travel_cost / 100 * 4);
                    }
                    Cities.Berlin.was_there = true;
                }
                else if (comboBox1.Text == "Ватикан" && Cities.Vatican.was_there == false)
                {
                    if (city_count == 0)
                    {
                        travelcost += 0;
                        label1.Text += (" Ватикан > ");
                        Cities.Vatican.was_there = true;
                        city_count += 1;

                    }
                    else if (city_count < 3 && city_count != 0)
                    {
                        travelcost += Cities.Vatican.transit;
                        label1.Text += (" Ватикан > ");
                        city_count += 1;
                    }
                    else if (city_count == 3)
                    {
                        travelcost += Cities.Vatican.travel_cost;
                        label1.Text += (" Ватикан ");
                        city_count += 1;

                    }

                    Cities.Vatican.was_there = true;
                }
                else if (comboBox1.Text == "Мадрид" && Cities.Madrid.was_there == false)
                {
                    if (city_count == 0)
                    {
                        travelcost += Cities.Parije.transit;
                        label1.Text += (" Мадрид > Париж > ");
                        city_count =+ 2;
                        Cities.Parije.was_there = true;
                    }
                    else if (city_count < 3 && city_count != 0)
                    {
                        travelcost += Cities.Madrid.transit;
                        label1.Text += (" Мадрид > ");
                        city_count += 1;

                    }
                    else if (city_count == 3)
                    {
                        travelcost += Cities.Madrid.travel_cost;
                        label1.Text += (" Мадрид ");
                        city_count += 1;

                    }

                    if (From_ES == false && city_count < 3 && city_count >= 1)
                    {
                        travelcost += (Cities.Madrid.transit / 100 * 4);
                    }
                    else if (From_ES == false && city_count == 3)
                    {
                        travelcost += (Cities.Madrid.travel_cost / 100 * 4);
                    }
                    Cities.Madrid.was_there = true;

                }
                else if (comboBox1.Text == "Лондон" && Cities.London.was_there == false)
                {
                    if (city_count == 0)
                    {
                        travelcost += Cities.Parije.transit;
                        label1.Text += (" Лондон > Париж > ");
                        city_count =+ 2;
                        Cities.Parije.was_there = true;

                    }
                    else if (city_count < 3 && city_count != 0)
                    {
                        travelcost += Cities.London.transit;
                        label1.Text += (" Лондон > ");
                        city_count += 1;

                    }
                    else if (city_count == 3)
                    {
                        travelcost += Cities.London.travel_cost;
                        label1.Text += (" Лондон ");
                        city_count += 1;

                    }
                    Cities.London.was_there = true;

                }
                else if (comboBox1.Text == "Кишинёв" && Cities.Kishinev.was_there == false)
                {
                    if (city_count == 0)
                    {
                        travelcost += Cities.Budapesht.transit;
                        label1.Text += (" Кишинёв > Будапешт > ");
                        city_count =+ 2;
                        Cities.Kishinev.was_there = true;
                        Cities.Budapesht.was_there = true;
                    }
                    else if (city_count < 3 && city_count != 0)
                    {
                        travelcost += Cities.Kishinev.transit;
                        label1.Text += (" Кишинёв > ");
                        city_count += 1;

                    }
                    else if (city_count == 3)
                    {
                        travelcost += Cities.Kishinev.travel_cost;
                        label1.Text += (" Кишинёв");
                        city_count += 1;

                    }

                    if (From_ES == false && city_count < 3 && city_count >= 1)
                    {
                        travelcost += (Cities.Kishinev.transit / 100 * 4);
                    }
                    else if (From_ES == false && city_count == 3)
                    {
                        travelcost += (Cities.Kishinev.travel_cost / 100 * 4);
                    }
                    Cities.Kishinev.was_there = true;

                }
                else if (comboBox1.Text == "Париж" && Cities.Parije.was_there == false)
                {
                    if (city_count == 0)
                    {
                        travelcost += 0;
                        label1.Text += (" Париж > ");
                        city_count += 1;

                    }
                    else if (city_count < 3 && city_count != 0)
                    {
                        travelcost += Cities.Parije.transit;
                        label1.Text += (" Париж > ");
                        city_count += 1;

                    }
                    else if (city_count == 3)
                    {
                        travelcost += Cities.Parije.travel_cost;
                        label1.Text += (" Париж ");
                        city_count += 1;

                    }

                    if (From_ES == false && city_count < 3 && city_count >= 1)
                    {
                        travelcost += (Cities.Parije.transit / 100 * 4);
                    }
                    else if (From_ES == false && city_count == 3)
                    {
                        travelcost += (Cities.Parije.travel_cost / 100 * 4);
                    }
                    Cities.Parije.was_there = true;

                }
                else if (comboBox1.Text == "Рига" && Cities.Riga.was_there == false)
                {
                    if (city_count == 0)
                    {
                        travelcost += Cities.Warsaw.transit;
                        label1.Text += (" Рига > Варшава > ");
                        city_count =+ 2;
                        Cities.Riga.was_there = true;
                        Cities.Warsaw.was_there = true;
                        riga = true;

                    }
                    else if (city_count < 3 && city_count != 0)
                    {
                        travelcost += Cities.Riga.transit;
                        Cities.Riga.was_there = true;
                        label1.Text += (" Рига > ");
                        city_count += 1;

                    }
                    else if (city_count == 3)
                    {
                        travelcost += Cities.Riga.travel_cost;
                        label1.Text += (" Рига");
                        Cities.Riga.was_there = true;
                        riga = true;
                        city_count += 1;

                    }

                    if (From_ES == false && city_count < 3 && city_count >= 1)
                    {
                        travelcost += (Cities.Riga.transit / 100 * 4);
                    }
                    else if (From_ES == false && city_count == 3)
                    {
                        travelcost += (Cities.Riga.travel_cost / 100 * 4);
                    }

                    if (Cities.Parije.was_there = true && city_count < 3)
                    {
                        travelcost += (Cities.Riga.transit / 100 * 11);
                    }
                    else if (Cities.Parije.was_there = true && city_count == 3)
                    {
                        travelcost += (Cities.Riga.travel_cost / 100 * 11);
                    }

                }
                else if (comboBox1.Text == "Палермо" && Cities.Parlemo.was_there == false)
                {
                    if (city_count == 0)
                    {
                        travelcost += 0;
                        Cities.Parlemo.was_there = true;
                        label1.Text += (" Палермо >");
                        palermo = true;
                        city_count += 1;

                    }
                    else if (city_count < 3 && city_count != 0)
                    {
                        travelcost += Cities.Parlemo.transit;
                        Cities.Parlemo.was_there = true;
                        label1.Text += (" Палермо > ");
                        city_count += 1;

                    }
                    else if (city_count == 3)
                    {
                        travelcost += Cities.Parlemo.travel_cost;
                        label1.Text += (" Палермо ");
                        palermo = true;
                        city_count += 1;

                    }

                    if (From_ES == false && city_count < 3 && city_count >= 1)
                    {
                        travelcost += (Cities.Parlemo.transit / 100 * 4);
                    }
                    else if (From_ES == false && city_count == 3)
                    {
                        travelcost += (Cities.Parlemo.travel_cost / 100 * 4);
                    }

                    if (Cities.London.was_there = true && city_count < 3)
                    {
                        travelcost += (Cities.Parlemo.transit / 100 * 7);
                    }
                    else if (Cities.London.was_there = true && city_count == 3)
                    {
                        travelcost += (Cities.Parlemo.travel_cost / 100 * 7);
                    }

                    if (Cities.Kishinev.was_there = true && city_count < 3)
                    {
                        travelcost += (Cities.Parlemo.transit / 100 * 11);
                    }
                    else if (Cities.Kishinev.was_there = true && city_count == 3)
                    {
                        travelcost += (Cities.Parlemo.travel_cost / 100 * 11);
                    }

                }
                else if (comboBox1.Text == "Прага" && Cities.Prague.was_there == false)
                {
                    if (city_count == 0)
                    {
                        travelcost += 0;
                        Cities.Prague.was_there = true;
                        label1.Text += (" Прага >");
                        Cities.Prague.was_there = true;
                        city_count += 1;


                    }
                    else if (city_count < 3 && city_count != 0)
                    {
                        travelcost += Cities.Prague.transit;
                        Cities.Prague.was_there = true;
                        label1.Text += (" Прага >");
                        city_count += 1;
                    }
                    else if (city_count == 3)
                    {
                        travelcost += Cities.Prague.travel_cost;
                        label1.Text += (" Прага ");
                        Cities.Prague.was_there = true;
                        city_count += 1;
                    }

                    if (From_ES == false && city_count < 3 && city_count >= 1)
                    {
                        travelcost += (Cities.Prague.transit / 100 * 4);
                    }
                    else if (From_ES == false && city_count == 3)
                    {
                        travelcost += (Cities.Prague.travel_cost / 100 * 4);
                    }

                }
                else if (comboBox1.Text == "Будапешт" && Cities.Budapesht.was_there == false)
                {
                    if (city_count == 0)
                    {
                        travelcost += 0;
                        label1.Text += (" Будапешт > ");
                        Cities.Budapesht.was_there = true;
                        city_count += 1;
                    }
                    else if (city_count < 3 && city_count != 0)
                    {
                        travelcost += Cities.Budapesht.transit;
                        Cities.Budapesht.was_there = true;
                        label1.Text += (" Будапешт > ");
                        city_count += 1;
                    }
                    else if (city_count == 3)
                    {
                        travelcost += Cities.Budapesht.travel_cost;
                        label1.Text += (" Будапешт ");
                        Cities.Budapesht.was_there = true;
                        city_count += 1;

                    }

                    if (From_ES == false && city_count < 3 && city_count >= 1)
                    {
                        travelcost += (Cities.Budapesht.transit / 100 * 4);
                    }
                    else if (From_ES == false && city_count == 3)
                    {
                        travelcost += (Cities.Budapesht.travel_cost / 100 * 4);
                    }
                }
                else if (comboBox1.Text == "Варшава" && Cities.Warsaw.was_there == false)
                {
                    if (city_count == 0)
                    {
                        travelcost += 0;
                        label1.Text += (" Варшава > ");
                        Cities.Warsaw.was_there = true;
                        city_count += 1;

                    }
                    else if (city_count < 3 && city_count != 0)
                    {
                        travelcost += Cities.Warsaw.transit;
                        Cities.Warsaw.was_there = true;
                        label1.Text += (" Варшава > ");
                        city_count += 1;
                        varsaw = true;
                    }
                    else if (city_count == 3)
                    {
                        travelcost += Cities.Warsaw.travel_cost;
                        label1.Text += (" Варшава ");
                        Cities.Warsaw.was_there = true;
                        city_count += 1;

                    }

                    if (From_ES == false && city_count < 3 && city_count >= 1)
                    {
                        travelcost += (Cities.Warsaw.transit / 100 * 4);
                    }
                    else if (From_ES == false && city_count == 3)
                    {
                        travelcost += (Cities.Warsaw.travel_cost / 100 * 4);
                    }


                    

                }


            }
            
            if (city_count == 4)
            {
                if (Cities.Vatican.was_there == true)
                {
                    travelcost += (travelcost / 100 * 50);
                }
                button1.Enabled = false;
            }
      
            label3.Text = city_count.ToString();
            label2.Text = travelcost.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            money = money_text.Text;
            budjTet = Double.Parse(money);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            money = money_text.Text;
            budjTet = Double.Parse(money);
            if (budjTet>=travelcost)
            {
            label5.Visible = true;
            label5.Text = "Бюджета достаточно";
            }
            else if(budjTet< travelcost)
            {
                label5.Visible = true;
                label5.Text = "Бюджета не достаточно";
            }
            if (palermo == true && berlin == false && varsaw == false && riga == true)
            {
                button1.Enabled = false;
                label4.Visible = true;
            }
            else if(palermo == true && berlin == true && varsaw == false && riga == true)
            {
                button1.Enabled = false;
                label4.Visible = true;
            }
            else if (riga == true && berlin == true && varsaw == false && palermo == true)
            {
                button1.Enabled = false;
                label4.Visible = true;
            }
            else if (riga == true && berlin == false && varsaw == false && palermo == true)
            {
                button1.Enabled = false;
                label4.Visible = true;
            }
            else if (riga == true && berlin == false && varsaw == true && palermo == true)
            {
                button1.Enabled = false;
                label4.Visible = true;
            }
            label2.Visible = true;
            label5.Visible = true;

            label2.Text = ("стоимость: " + travelcost);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            city_count = 0;
            travelcost = 0;
            budjTet = 0;
            Cities.Riga.was_there = false;
            Cities.Berlin.was_there = false;
            Cities.Budapesht.was_there = false;
            Cities.London.was_there = false;
            Cities.Kishinev.was_there = false;
            Cities.Madrid.was_there = false;
            Cities.Parlemo.was_there = false;
            Cities.Vatican.was_there = false;
            Cities.Warsaw.was_there = false;
            Cities.Parije.was_there = false;
            Cities.Prague.was_there = false;
            label1.Text = "";
            button1.Enabled=true;
            varsaw = false;
            berlin = false;
            palermo = false;
            riga = false;
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label5.Text = "";



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                From_ES = true;
            }
            else if (checkBox1.Checked == false)
            {
                From_ES = false;
            }
        }


        //извините я не много ленив чтобы придумать способ полудше... //
    }
}
