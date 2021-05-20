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
    public partial class TestV : Form
    {
        List<Panel> listPanel = new List<Panel>();

        List<RadioButton> listButtons = new List<RadioButton>();

        Info Info;

        int index;

        public TestV(Info info)
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

        private void TestV_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel.Add(panel3);
            listPanel.Add(panel4);
            listPanel.Add(panel5);


            listPanel[index].BringToFront();

            listButtons.Add(TrueV1);
            listButtons.Add(TrueV2);
            listButtons.Add(TrueV3);
            listButtons.Add(TrueV4);
            listButtons.Add(TrueV5);
        }
    }
}
