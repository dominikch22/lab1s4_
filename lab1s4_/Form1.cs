using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1s4_
{
    public partial class Form1 : Form
    {
        public delegate double MathOperation(double x);
        public MathOperation mathOperation;
        public delegate void TextOperation();
        public TextOperation textOperations;

        public List<double> Numbers;
        public delegate List<double> GrouptMathOperation(List<double> numbers);
        public GrouptMathOperation grouptMathOperations;


        public delegate int CompareTo<T>(T e1, T e2);
        public delegate void SortArray<T>(List<T> elements, CompareTo<T> comperator);
        public SortArray<double> sortNumbers;
        public SortArray<string> sortStrings;
        public static void BubbleSort<T>(List<T> list, CompareTo<T> comperator) where T : IComparable<T>
        {
            for (int i = 0; i < list.Count - 1; i++) {
                for (int j = 0; j < list.Count - 1; j++) {
                    if (comperator(list[j], list[j + 1]) > 0) {
                        T temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }

        public int CompareToAscending<T>(T e1, T e2) where T : IComparable<T>
        {
            return e1.CompareTo(e2);
        }

        public int CompareToDescending<T>(T e1, T e2) where T : IComparable<T> {
            return e2.CompareTo(e1);
        }

        public List<double> SortedNumbers;
        public List<string> SortedStrings;

        public Form1()
        {
            InitializeComponent();
            Numbers = new List<double>();
            SortedNumbers = new List<double>();
            SortedStrings = new List<string>();
        }

        public double Power(double x)
        {
            return x * x;
        }

        public double Root(double x) {
            return Math.Sqrt(x);
        }

        public double Inverse(double x) {
            return 1 / x;
        }

        public void ChangeBackgroundColor() {
            switch (background.Text)
            {
                case "Red":
                    text.BackColor = Color.Red;
                    break;
                case "Blue":
                    text.BackColor = Color.Blue;
                    break;
                case "Green":
                    text.BackColor = Color.Green;
                    break;
                default:
                    text.BackColor = Color.White;
                    break;
            }
        }

        public void changeFontColor() {
            switch (color.Text)
            {
                case "Red":
                    text.ForeColor = Color.Red;
                    break;
                case "Blue":
                    text.ForeColor = Color.Blue;
                    break;
                case "Green":
                    text.ForeColor = Color.Green;
                    break;
                default:
                    text.ForeColor = Color.Black;
                    break;
            }
        }

        public void changeFontSize() {
            try {
                text.Font = new Font(text.Font.FontFamily, int.Parse(size.Text), text.Font.Style);
            }
            catch { }

        }

        private void powerCh_CheckedChanged(object sender, EventArgs e)
        {
            if (powerCh.Checked) {
                mathOperation = Power;
                MathOperationDisableCheckBoxes((CheckBox)sender);
            }else
                mathOperation -= Power;

        }

        private void rootCh_CheckedChanged(object sender, EventArgs e)
        {
            if (rootCh.Checked)
            {
                mathOperation = Root;
                MathOperationDisableCheckBoxes((CheckBox)sender);
            }
            else
                mathOperation -= Root;
        }

        private void inverseCh_CheckedChanged(object sender, EventArgs e)
        {
            if (inverseCh.Checked)
            {
                mathOperation = Inverse;
                MathOperationDisableCheckBoxes((CheckBox)sender);
            }
            else
                mathOperation -= Inverse;
        }


        private void execute_Click(object sender, EventArgs e)
        {
            try {
                if(mathOperation != null)
                    result.Text = mathOperation(double.Parse(number.Text)).ToString();
            }
            catch(Exception ex) { }
        }

        private void backgroundCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(backgroundCheckBox.Checked)
                textOperations += ChangeBackgroundColor;
            else
                textOperations -= ChangeBackgroundColor;

        }

        private void fontColorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(fontColorCheckBox.Checked)
                textOperations += changeFontColor;
            else
                textOperations -= changeFontColor;

        }

        private void fontSizeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(fontColorCheckBox.Checked)
                textOperations += changeFontSize;
            else
                textOperations -= changeFontSize;

        }

        private void changeLabel_Click(object sender, EventArgs e)
        {
            try
            {
                if(textOperations != null)
                    textOperations();

            }
            catch (Exception ex){ }
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                Numbers.Add(double.Parse(inputN.Text));
                listBox.Items.Clear();
                foreach (double n in Numbers) {
                    listBox.Items.Add(n);
                }
            }
            catch { }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Numbers = new List<double>();
            listBox.Items.Clear();
        }

        public List<double> PowerGroup(List<double> numbers) {
            for (int i = 0; i < numbers.Count; i++) {
                numbers[i] = numbers[i] * numbers[i];
            }
            return numbers;
        }

        public List<double> RootGroup(List<double> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = Math.Sqrt(numbers[i]);
            }
            return numbers;
        }

        public List<double> InverseGroup(List<double> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = 1 / numbers[i];
            }
            return numbers;
        }




        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                grouptMathOperations = PowerGroup;
                MathGroupOperationDisableCheckBoxes((CheckBox)sender);
            }
            else
                grouptMathOperations -= PowerGroup;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) { 
                grouptMathOperations = RootGroup;
                MathGroupOperationDisableCheckBoxes((CheckBox)sender);

            }
            else
                grouptMathOperations -= RootGroup;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                grouptMathOperations = InverseGroup;
                MathGroupOperationDisableCheckBoxes((CheckBox)sender);

            }
            else
                grouptMathOperations -= InverseGroup;
        }

        private void executeNumbersList_Click(object sender, EventArgs e)
        {
            try
            {
                if (grouptMathOperations != null) {
                    Numbers = grouptMathOperations(Numbers);
                    listBox.Items.Clear();
                    foreach (double n in Numbers)
                    {
                        listBox.Items.Add(n);
                    }
                }
                
            }
            catch { }
        }

        private void addSorted_Click(object sender, EventArgs e)
        {
            try {
                SortedNumbers.Add(double.Parse(elementInput.Text));
                ShowSortedNumbers();
            }
            catch {
                SortedStrings.Add(elementInput.Text);
                ShowSortedStrings();
            }
        }

        public void ShowSortedNumbers() {
            sortedBox.Items.Clear();
            foreach (double n in SortedNumbers) {
                sortedBox.Items.Add(n);
            }
        }

        public void ShowSortedStrings() {
            sortedBox.Items.Clear();
            foreach (string s in SortedStrings)
            {
                sortedBox.Items.Add(s);
            }
        }

        private void clearSorted_Click(object sender, EventArgs e)
        {
            SortedNumbers = new List<double>();
            SortedStrings = new List<string>();

            sortedBox.Items.Clear();
        }

       

        private void sortAscending_Click(object sender, EventArgs e)
        {
            CompareTo<double> comperator = CompareToAscending<double>;
            //sortNumbers = BubbleSort<double>;

            CompareTo<string> stringComperator = CompareToAscending<string>;
            //sortStrings = BubbleSort<string>;

            BubbleSort(SortedStrings, stringComperator);
            BubbleSort(SortedNumbers, comperator);

            //sortNumbers(SortedNumbers, comperator);
            //sortStrings(SortedStrings, stringComperator);

            ShowSortedNumbers();
        }

        private void sortDescending_Click(object sender, EventArgs e)
        {
            CompareTo<double> comperator = CompareToDescending<double>;
            //sortNumbers = BubbleSort<double>;

            CompareTo<string> stringComperator = CompareToDescending<string>;
            //sortStrings = BubbleSort<string>;

            BubbleSort(SortedStrings, stringComperator);
            BubbleSort(SortedNumbers, comperator);

            //sortNumbers(SortedNumbers, comperator);
            //sortStrings(SortedStrings, stringComperator);

            ShowSortedNumbers();

        }

        public void MathOperationDisableCheckBoxes(CheckBox sender) {
            if(!sender.Equals(powerCh))
                powerCh.Checked = false;
            if (!sender.Equals(rootCh))
                rootCh.Checked = false;
            if (!sender.Equals(inverseCh))
                inverseCh.Checked = false;


        }

        public void MathGroupOperationDisableCheckBoxes(CheckBox sender) {
            if (!sender.Equals(checkBox1))
                checkBox1.Checked = false;
            if (!sender.Equals(checkBox2))
                checkBox2.Checked = false;
            if (!sender.Equals(checkBox3))
                checkBox3.Checked = false;
        }

        private void sort_Click(object sender, EventArgs e)
        {

        }

        private void showNumbersButton_Click(object sender, EventArgs e)
        {
            ShowSortedNumbers();
        }

        private void showStringsButton_Click(object sender, EventArgs e)
        {
            ShowSortedStrings();
        }
    }
}
