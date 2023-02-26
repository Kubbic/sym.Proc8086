using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projekt
{

    public partial class MainWindow : Window
    {
        private Dictionary<string, TextBox> rejestryTb;

        private string ah_pop = "";
        private string bh_pop = "";
        private string ch_pop = "";
        private string dh_pop = "";
        private string al_pop = "";
        private string bl_pop = "";
        private string cl_pop = "";
        private string dl_pop = "";



        public MainWindow()
        {
            InitializeComponent();
            rejestryTb = new Dictionary<string, TextBox>
            {
                {"AH", AH_tb },
                {"BH", BH_tb },
                {"CH", CH_tb },
                {"DH", DH_tb },
                {"AL", AL_tb },
                {"BL", BL_tb },
                {"CL", CL_tb },
                {"DL", DL_tb },
            };
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tx = sender as TextBox;
            string chars = "1234567890ABCDEF";
            if (tx.Text.Length > 4)
            {
                MessageBox.Show("Podano niepoprawną liczbę!");
                tx.Text = "";
                return;
            }
            foreach (var item in tx.Text)
            {
                if (!chars.Contains(item))
                {
                    MessageBox.Show("złe dane!");
                    tx.Text = "";
                    return;
                }
            }

        }

        private void MoveButton_Click(object sender, RoutedEventArgs e)
        {
            string rejestr1 = R1_cb.SelectedItem as string;
            string rejestr2 = R2_cb.SelectedItem as string;
            if (rejestr1 == null || rejestr2 == null)
            {
                MessageBox.Show("Wybierz rejestry!");
            }
            else
            {
                rejestryTb[rejestr2].Text = rejestryTb[rejestr1].Text;
                rejestryTb[rejestr1].Text = null;

            }
        }



        private void MoveButton_Copy_Click(object sender, RoutedEventArgs e)
        {
            string rejestr1 = R1_cb.SelectedItem as string;
            string rejestr2 = R2_cb.SelectedItem as string;
            if (rejestr1 == null || rejestr2 == null)
            {
                MessageBox.Show("Proszę wybrać rejestry");
            }
            else
            {
                string tmp = rejestryTb[rejestr1].Text;
                rejestryTb[rejestr1].Text = rejestryTb[rejestr2].Text;
                rejestryTb[rejestr2].Text = tmp;
            }
        }
        private void PUSH(object sender, RoutedEventArgs e)
        {
            string rejestr1 = R3_cb.SelectedItem as String;

            if (rejestr1 == null)
            {
                MessageBox.Show("Proszę wybrać rejestry");
            }

            if (rejestr1 == "AH")
            {
                ah_pop = rejestryTb[rejestr1].Text;
                rejestryTb[rejestr1].Text = "";

            }

            if (rejestr1 == "BH")
            {
                bh_pop = rejestryTb[rejestr1].Text;
                rejestryTb[rejestr1].Text = "";
            }

            if (rejestr1 == "CH")
            {
                ch_pop = rejestryTb[rejestr1].Text;
                rejestryTb[rejestr1].Text = "";
            }

            if (rejestr1 == "DH")
            {
                dh_pop = rejestryTb[rejestr1].Text;
                rejestryTb[rejestr1].Text = "";
            }
            if (rejestr1 == "AL")
            {
                dh_pop = rejestryTb[rejestr1].Text;
                rejestryTb[rejestr1].Text = "";
            }
            if (rejestr1 == "BL")
            {
                dh_pop = rejestryTb[rejestr1].Text;
                rejestryTb[rejestr1].Text = "";
            }
            if (rejestr1 == "CL")
            {
                dh_pop = rejestryTb[rejestr1].Text;
                rejestryTb[rejestr1].Text = "";
            }
            if (rejestr1 == "DL")
            {
                dh_pop = rejestryTb[rejestr1].Text;
                rejestryTb[rejestr1].Text = "";
            }
        }

        private void POP(object sender, RoutedEventArgs e)
        {
            string rejestr1 = R3_cb.SelectedItem as String;

            if (rejestr1 == null)
            {
                MessageBox.Show("Proszę wybrać rejestry");
            }

            if (rejestr1 == "AH")
            {
                rejestryTb[rejestr1].Text = ah_pop;
            }

            if (rejestr1 == "BH")
            {
                rejestryTb[rejestr1].Text = bh_pop;
            }

            if (rejestr1 == "CH")
            {
                rejestryTb[rejestr1].Text = ch_pop;
            }

            if (rejestr1 == "DH")
            {
                rejestryTb[rejestr1].Text = dh_pop;
            }
            if (rejestr1 == "AL")
            {
                rejestryTb[rejestr1].Text = al_pop;
            }
            if (rejestr1 == "BL")
            {
                rejestryTb[rejestr1].Text = bl_pop;
            }
            if (rejestr1 == "CL")
            {
                rejestryTb[rejestr1].Text = cl_pop;
            }
            if (rejestr1 == "DL")
            {
                rejestryTb[rejestr1].Text = dl_pop;
            }
        }
    }
}
