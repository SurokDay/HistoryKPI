using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace History
{
    public partial class Main : Form
    {
        Info first;
        Info second;
        Info third;
        

        

        public Main()
        {
          

            InitializeComponent();
            string text1 = File.ReadAllText("1 info.txt");
            string text2 = File.ReadAllText("2 info.txt");
            string text3 = File.ReadAllText("3 info.txt");

            this.first = new Info("Франция от начала революции до падение Напалеона", text1);
            this.second = new Info("История Древней Греции", text2);
            this.third = new Info("Иконоборчество в Византии", text3);
        }

        private void First_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Name)
            {
                case "First":
                    Topic topic1 = new Topic(first);
                    topic1.Show();
                    break;

                case "Second":
                    Topic topic2 = new Topic(second);
                    topic2.Show();
                    break;

                case "Third":
                    Topic topic3 = new Topic(third);
                    topic3.Show();
                    break;
                default:
                    break;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}