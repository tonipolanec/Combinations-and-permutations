using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leksikografski_poredak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Leksikografski poredak";
            this.Icon = Properties.Resources._66116;
        }

        private void buttonPermutiraj_Click(object sender, EventArgs e)
        {
            listBoxIspisPermutacija.Items.Clear();

            if (radioButtonBrojevi.Checked)
            {

                String brojceki = textBoxUnosSlova.Text;
                int nBrojeva = 1;
                for (int i = 0; i < brojceki.Length; i++)
                {
                    if (brojceki[i] == ',')
                        nBrojeva++;
                }
                int[] brojevi = uzmiBrojeveIzStringa(brojceki, nBrojeva);
                brojevi = sort(brojevi);

                int nPermutacijaBr = faktorijel(nBrojeva);
                int k = nadiDjeliteljZbogPonavljanjaElemenata(brojevi);
                nPermutacijaBr = nPermutacijaBr / k;

                labelUkupnoPermutacija.Text = "Ukupno ima " + nPermutacijaBr + " permutacija.";

                listBoxIspisPermutacija.Items.Add("" + intArrToString(brojevi));

                int[] permuteraniBrojevi = permuteraj(brojevi);
                for (int i = 1; i < nPermutacijaBr; i++)
                {
                    listBoxIspisPermutacija.Items.Add("" + intArrToString(permuteraniBrojevi));
                    permuteraniBrojevi = permuteraj(permuteraniBrojevi);
                }

            }
            else if (radioButtonSlova.Checked)
            {

                String rijec = textBoxUnosSlova.Text;
                int brojSlova = rijec.Length;
                int nPermutacijaSl = faktorijel(brojSlova);

                int k = nadiDjeliteljZbogPonavljanjaElemenata(pretvorba(rijec));
                nPermutacijaSl /= k;

                labelUkupnoPermutacija.Text = "Ukupno ima " + nPermutacijaSl + " permutacija.";

                int[] intRijec = pretvorba(rijec);
                intRijec = sort(intRijec);

                listBoxIspisPermutacija.Items.Add("" + uzmiStringIzBrojeva(intRijec));

                int[] permuteranaSlova = permuteraj(intRijec);
                for (int p = 1; p < nPermutacijaSl; p++)
                {
                    listBoxIspisPermutacija.Items.Add("" + uzmiStringIzBrojeva(permuteranaSlova));

                    permuteranaSlova = permuteraj(permuteranaSlova);
                }

                if (checkBoxPronadiPermutaciju.Checked)
                {
                    string[] listaPermutacija = listBoxIspisPermutacija.Items.OfType<string>().ToArray();
                    int index = Array.IndexOf(listaPermutacija, rijec);
                    labelPermutacijaPoRedu.Text = "Upisana kombinacija je " + (index+1) + ". po redu.";
                }


            }



        }

        public static int[] permuteraj(int[] arr)
        {

            int i = arr.Length - 1;

            while (i > 0 && arr[i] <= arr[i - 1])
                i--;

            if (i <= 0)
                return arr;


            int j = arr.Length - 1;
            while (arr[j] <= arr[i - 1])
                j--;

            //swap
            int temp = arr[j];
            arr[j] = arr[i - 1];
            arr[i - 1] = temp;

            //brni ga
            j = arr.Length - 1;
            while (i < j)
            {
                temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;

                i++;
                j--;
            }
            return arr;

        }

        public static int[] pretvorba(String str)
        {
            int[] pretvoreno = new int[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                pretvoreno[i] = (int)str[i];
            }

            return pretvoreno;
        }

        public static int faktorijel(int n) {
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
            }

            return f;
        }

        public static int[] uzmiBrojeveIzStringa(String str, int n)
        {
            int[] vratiTo = new int[n];

            String trenutniBroj = "";
            int indexBrojeva = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ',')
                {
                    trenutniBroj += str[i];
                } else if (str[i] == ',')
                {
                    int broj = int.Parse(trenutniBroj);
                    vratiTo[indexBrojeva] = broj;
                    indexBrojeva++;
                    trenutniBroj = "";
                }
                if (i == str.Length - 1)
                {
                    int broj = int.Parse(trenutniBroj);
                    vratiTo[indexBrojeva] = broj;
                    indexBrojeva++;
                    trenutniBroj = "";
                }
            }
            return vratiTo;
        }

        public static String uzmiStringIzBrojeva(int[] arr)
        {
            String str = "";

            for (int i = 0; i < arr.Length; i++)
            {
                str += "" + (char)arr[i];
            }
            return str;
        }

        public static String intArrToString(int[] arr)
        {
            String str = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != arr.Length - 1)
                {
                    str += "" + arr[i] + ", ";
                }else{
                    str += "" + arr[i];
                }
            }
            return str;
        }

        public static int nadiDjeliteljZbogPonavljanjaElemenata(int[] arr)
        {
            int k = 1;

            int[] ponavljani = new int[20];
            int indeksP = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (!Array.Exists(ponavljani, element => element == arr[i]))
                {
                    int trenutni = arr[i];
                    ponavljani[indeksP] = trenutni; indeksP++;
                    int tempK = 0;

                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (trenutni == arr[j])
                        {
                            tempK++;

                        }
                    }
                    k *= faktorijel(tempK);
                }
            }
            return k;
        }

        //OVO SE JOS MOZDA PREMENI
        private void listBoxIspisPermutacija_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sel = listBoxIspisPermutacija.SelectedIndex + 1;
            MessageBox.Show("Odabrana permutacija je " + sel + ". po redu");
        }


        public static int[] sort(int[] arr)
        {
            
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }


        private void checkBoxPronadiPermutaciju_CheckedChanged(object sender, EventArgs e)
        {
            labelPermutacijaPoRedu.Text = "";
        }

        private void radioButtonBrojevi_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonBrojevi.Checked)
                checkBoxPronadiPermutaciju.Enabled = false;
            else
                checkBoxPronadiPermutaciju.Enabled = true;

        }
    }


}
