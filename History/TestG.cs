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
    public partial class TestG : Form
    {
        List<Panel> listPanel = new List<Panel>();

        List<RadioButton> listButtons = new List<RadioButton>();

        Info Info;

        int index;

        public TestG(Info info)
        {
            this.Info = info;
            InitializeComponent();
        }

        private void Preview_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                listPanel[--index].BringToFront();
            }
        }

        private void Topic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
            {
                listPanel[++index].BringToFront();
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            int answersGood = 0;
            foreach (var item in listButtons)
            {
                if (item.Checked)
                {
                    answersGood++;
                }
            }
            MessageBox.Show($"right answers: {answersGood}");
        }

        private void TestG_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel.Add(panel3);
            listPanel.Add(panel4);
          

            listPanel[index].BringToFront();

            listButtons.Add(TrueG1);
            listButtons.Add(TrueG2);
            listButtons.Add(TrueG3);
            listButtons.Add(TrueG4);
         
        }
    }
}
