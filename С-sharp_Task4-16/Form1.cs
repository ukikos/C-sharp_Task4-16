using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace С_sharp_Task4_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateQButton_Click(object sender, EventArgs e)
        {
            if (CheckError1())
                return;
            Party party1lvl = new Party(partyNameTextBox.Text, double.Parse(partySizeTextBox.Text), double.Parse(partyPercentOfVotesTextBox.Text));
            partyQTextBox.Text = "";
            partyQTextBox.Text += party1lvl.calculateQ();
        }

        private void calculateQpButton_Click(object sender, EventArgs e)
        {
            if (CheckError2())
                return;
            DescendantOfTheParty party2lvl = new DescendantOfTheParty(partyNameTextBox.Text, double.Parse(partySizeTextBox.Text),
                double.Parse(partyPercentOfVotesTextBox.Text), double.Parse(partySizeLastYearTextBox.Text));
            partyQpTextBox.Text = "";
            partyQpTextBox.Text += party2lvl.calculateQ();
        }

        private void showInfo1Button_Click(object sender, EventArgs e)
        {
            if (CheckError1())
                return;
            Party party1lvl = new Party(partyNameTextBox.Text, double.Parse(partySizeTextBox.Text), double.Parse(partyPercentOfVotesTextBox.Text));
            partyInfo1TextBox.Text = "";
            partyInfo1TextBox.Text += party1lvl.ToString();
        }

        private void showInfo2Button_Click(object sender, EventArgs e)
        {
            if (CheckError2())
                return;
            DescendantOfTheParty party2lvl = new DescendantOfTheParty(partyNameTextBox.Text, double.Parse(partySizeTextBox.Text),
                double.Parse(partyPercentOfVotesTextBox.Text), double.Parse(partySizeLastYearTextBox.Text));
            partyInfo2TextBox.Text = "";
            partyInfo2TextBox.Text += party2lvl.ToString();
        }

        private bool CheckError1() //проверка правильности введения данных в поля класса 1-го уровня
        {
            if (partyNameTextBox.Text.Length == 0 || partySizeTextBox.Text.Length == 0 || partyPercentOfVotesTextBox.Text.Length == 0)
            {
                partyInfo1TextBox.Text = "";
                partyInfo1TextBox.Text = "Неверный формат введенных данных\r\nВозможные ошибки:\r\nПустое поле для ввода.";
                return true;
            }
            if (partySizeTextBox.Text.Contains('.') || partyPercentOfVotesTextBox.Text.Contains('.'))
            {
                partyInfo1TextBox.Text = "";
                partyInfo1TextBox.Text = "Неверный формат введенных данных\r\nИспользуйте запятую в качестве десятичного разделителя";
                return true;
            }
            if (double.Parse(partySizeTextBox.Text) < 0 || double.Parse(partyPercentOfVotesTextBox.Text) < 0 || double.Parse(partyPercentOfVotesTextBox.Text) > 100)
            {
                partyInfo1TextBox.Text = "";
                partyInfo1TextBox.Text = "Неверный формат введенных данных\r\nВозможные ошибки:\r\nЧисленность партии меньше 0,\r\n" +
                    "Процент голосов меньше 0 или больше 100.";
                return true;
            }
            return false;
        }

        private bool CheckError2() //проверка правильности введения данных в поля классов 1-го и 2-го уровня
        {
            if (partyNameTextBox.Text.Length == 0 || partySizeTextBox.Text.Length == 0 || partyPercentOfVotesTextBox.Text.Length == 0 ||
                partySizeLastYearTextBox.Text.Length == 0)
            {
                partyInfo2TextBox.Text = "";
                partyInfo2TextBox.Text = "Неверный формат введенных данных\r\nВозможные ошибки:\r\nПустое поле для ввода.";
                return true;
            }
            if (partySizeTextBox.Text.Contains('.') || partyPercentOfVotesTextBox.Text.Contains('.') || partySizeLastYearTextBox.Text.Contains('.'))
            {
                partyInfo2TextBox.Text = "";
                partyInfo2TextBox.Text = "Неверный формат введенных данных\r\nИспользуйте запятую в качестве десятичного разделителя";
                return true;
            }
            if (double.Parse(partySizeTextBox.Text) < 0 || double.Parse(partyPercentOfVotesTextBox.Text) < 0 || double.Parse(partyPercentOfVotesTextBox.Text) > 100)
            {
                partyInfo2TextBox.Text = "";
                partyInfo2TextBox.Text = "Неверный формат введенных данных\r\nВозможные ошибки:\r\nЧисленность партии меньше 0,\r\n" +
                    "Процент голосов меньше 0 или больше 100.";
                return true;
            }
            return false;
        }
    }
}
