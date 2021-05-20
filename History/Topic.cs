using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace History
{
    public partial class Topic : Form
    {
        Info Info;
        public Topic()
        {
            InitializeComponent();
        }
        public Topic(Info info)
        {
            InitializeComponent();

            this.Info = info;
            TBTitle.Text = info.Title;
            TBText.Text = info.LBText;
        }

        private void Test_Click(object sender, EventArgs e)
        {
            if (Info.Title== "Франция от начала революции до падение Напалеона")
            {
                TestF test = new TestF(Info);

                test.Show();
            }
            else if(Info.Title == "История Древней Греции")
            {
                TestG test = new TestG(Info);

                test.Show();
            }
             else if (Info.Title == "Иконоборчество в Византии")
             {
                TestV test = new TestV(Info);
                test.Show();
             }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}