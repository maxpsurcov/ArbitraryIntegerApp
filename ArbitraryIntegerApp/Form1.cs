using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbitraryIntegerApp
{
    public partial class Form1 : Form
    {
        private ArbitraryInteger myInteger;
        public Form1()
        {
            InitializeComponent();
            myInteger = new ArbitraryInteger();
        }

        private void btnSetInteger_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            try
            {
                myInteger.SetInteger(input);
                MessageBox.Show("Integer set successfully!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format. Please enter digits only.");
            }
        }

        private void btnGetComponent_Click(object sender, EventArgs e)
        {
            int index;
            if (int.TryParse(txtIndex.Text, out index))
            {
                try
                {
                    int component = myInteger.GetComponent(index - 1); 
                    MessageBox.Show($"Component at index {index}: {component}");
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Invalid index. Please enter a valid index.");
                }
            }
            else
            {
                MessageBox.Show("Invalid index format. Please enter a valid index.");
            }
        }

        private void btnSetComponent_Click(object sender, EventArgs e)
        {
            int index, value;
            if (int.TryParse(txtIndex.Text, out index) && int.TryParse(txtValue.Text, out value))
            {
                try
                {
                    myInteger.SetComponent(index - 1, value); 
                    MessageBox.Show("Component set successfully!");
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Invalid index. Please enter a valid index.");
                }
            }
            else
            {
                MessageBox.Show("Invalid index or value format. Please enter valid values.");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            List<int> components = myInteger.GetComponents();
            if (components.Count > 0)
            {
                string displayText = string.Join(" ", components);
                MessageBox.Show(displayText);
            }
            else
            {
                MessageBox.Show("No components to display. Please set an integer first.");
            }
        }
    }
    public class ArbitraryInteger
    {
        private List<int> components;

        public ArbitraryInteger()
        {
            components = new List<int>();
        }

        public void SetInteger(string input)
        {
            components.Clear();
            foreach (char digit in input)
            {
                if (Char.IsDigit(digit))
                {
                    int component = Convert.ToInt32(digit.ToString());
                    components.Add(component);
                }
                else
                {
                    throw new FormatException();
                }
            }
        }

        public int GetComponent(int index)
        {
            if (index >= 0 && index < components.Count)
                return components[index];
            else
                throw new IndexOutOfRangeException();
        }

        public void SetComponent(int index, int value)
        {
            if (index >= 0 && index < components.Count)
                components[index] = value;
            else
                throw new IndexOutOfRangeException();
        }

        public List<int> GetComponents()
        {
            return components;
        }
    }
}
