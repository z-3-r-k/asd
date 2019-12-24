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

namespace S1uzduotis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartUp();
        }

        public void StartUp()
        {
            string sarasas = WindowsFormsApp2.Properties.Resources.duomenys;
            string[] sarasas_array = sarasas.Split('\n');
            bool ar_egzistuoja;

            //Programai užsikrovus patikrinti ar yra failas sistemoje ir atvaizduoti atsakymą „label“ elemente. (panaudoti boolean kintamojo tipą).
            if (File.Exists("..\\..\\Resources\\duomenys.txt"))
            {
                ar_egzistuoja = true;
            }
            else ar_egzistuoja = false;

            label1.Text = "Ar yra failas: " + ar_egzistuoja;
            //Nuskaitytu pirmos eilutės skaičius ir juos išrikiuotu didėjimo tvarka.

            //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            //{
            //   richTextBox1.Text += comboBox1.SelectedItem.ToString();
            //}

            string[] skaiciai = sarasas_array[0].Split(' ');
            int[] skaiciai_int = Array.ConvertAll(skaiciai, int.Parse);
            Array.Sort(skaiciai_int);
            foreach (int skaicius in skaiciai_int)
            {
                richTextBox1.Text += skaicius + " ";
            }
            richTextBox1.Text += "\n";

            //Pagal 2-3-4 eilutes susikurti atitinkama struktūrą su private kintamaisiais ir priskirti kintamūjų reikšmes naudojantis funkcijomis.
            Zmogus naujas_zmogus1 = new Zmogus(sarasas_array[1]);
            Zmogus naujas_zmogus2 = new Zmogus(sarasas_array[2]);
            Zmogus naujas_zmogus3 = new Zmogus(sarasas_array[3]);

            richTextBox1.Text += "\r\n" + naujas_zmogus1.ToString();
            richTextBox1.Text += "\r\n" + naujas_zmogus2.ToString();
            richTextBox1.Text += "\r\n" + naujas_zmogus3.ToString();

            richTextBox1.Text += "\n";
            //Su 5 - 6 - 7 suskaičiuoti kokių ir kiek balsių yra pateiktame tekste.
            char[] balses = { 'A', 'a', 'E', 'e', 'I', 'i', 'Y', 'y', 'O', 'o', 'U', 'u' };
            int[] kiekbalsiu = new int[balses.Length];
            for (int i = 4; i <= 7; i++)
            {
                string zodziai_array = sarasas_array[i];
                foreach (char raide in zodziai_array)
                {
                    for(int j = 0; j < balses.Length; j++)
                    {
                        if(raide == balses[j])
                        {
                            kiekbalsiu[j]++;
                        }
                    }
                }
            }
            for (int j = 0; j < balses.Length; j++)
            {
                if (j % 2 == 0)
                {
                    kiekbalsiu[j] += kiekbalsiu[j + 1];
                    richTextBox1.Text += "\n" + balses[j] + " - " + kiekbalsiu[j];
                }
            }
            richTextBox1.Text += "\n\n";
            // Su 8-9-10 eilutėmis surikiuoti skaičius mažėjimo tvarka.
            string skaiciai_kartu = sarasas_array[7] + sarasas_array[8] + sarasas_array[9];
            string[] skaiciai_1 = skaiciai_kartu.Split(' ', '\r');
            int[] skaiciai1_int = Array.ConvertAll(skaiciai_1, int.Parse);
            Array.Sort(skaiciai1_int);
            Array.Reverse(skaiciai1_int);

            foreach (int skaicius in skaiciai1_int)
            {
                richTextBox1.Text += skaicius + " ";

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sarasas = WindowsFormsApp2.Properties.Resources.duomenys;
            string[] sarasas_array = sarasas.Split('\n');

            if (comboBox1.SelectedIndex == 0)// vadinasi didejimo
            {
                richTextBox1.Text = "";
                string[] skaiciai = sarasas_array[0].Split(' ');
                int[] skaiciai_int = Array.ConvertAll(skaiciai, int.Parse);
                Array.Sort(skaiciai_int);
                foreach (int skaicius in skaiciai_int)
                {
                    richTextBox1.Text += skaicius + " ";
                }
                richTextBox1.Text += "\n";

                string skaiciai_kartu = sarasas_array[7] + sarasas_array[8] + sarasas_array[9];
                string[] skaiciai_1 = skaiciai_kartu.Split(' ', '\r');
                int[] skaiciai1_int = Array.ConvertAll(skaiciai_1, int.Parse);
                Array.Sort(skaiciai1_int);

                foreach (int skaicius in skaiciai1_int)
                {
                    richTextBox1.Text += skaicius + " ";

                }


            }
            else if (comboBox1.SelectedIndex == 1) // vadinasi mazejimo
            {
                richTextBox1.Text = "";
                string[] skaiciai = sarasas_array[0].Split(' ');
                int[] skaiciai_int = Array.ConvertAll(skaiciai, int.Parse);
                Array.Sort(skaiciai_int);
                Array.Reverse(skaiciai_int);
                foreach (int skaicius in skaiciai_int)
                {
                    richTextBox1.Text += skaicius + " ";
                }
                richTextBox1.Text += "\n";

                string skaiciai_kartu = sarasas_array[7] + sarasas_array[8] + sarasas_array[9];
                string[] skaiciai_1 = skaiciai_kartu.Split(' ', '\r');
                int[] skaiciai1_int = Array.ConvertAll(skaiciai_1, int.Parse);
                Array.Sort(skaiciai1_int);
                Array.Reverse(skaiciai1_int);

                foreach (int skaicius in skaiciai1_int)
                {
                    richTextBox1.Text += skaicius + " ";

                }
            }
        }
    }
}


struct Zmogus
{
    private string v1;
    private int v2;
    private int v3;
    private int v4;
    private int v5;

    public Zmogus(string eilute)
    {
        string[] zmogus_array = eilute.Split(' ');
        this.v1 = zmogus_array[0];
        this.v2 = Convert.ToInt32(zmogus_array[1]);
        this.v3 = Convert.ToInt32(zmogus_array[2]);
        this.v4 = Convert.ToInt32(zmogus_array[3]);
        this.v5 = Convert.ToInt32(zmogus_array[4]);
    }
    public override string ToString()
    {
        return string.Format(v1 + " " + v2 + " " + v3 + " " + v4 + " " + v5);
    }
}