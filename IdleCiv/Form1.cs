using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boblovespi.IdleCiv
{
    public partial class IdleCivMainForm : Form
    {
        private OutputManager theOutput;

        private Civilization player;

        public IdleCivMainForm()
        {
            InitializeComponent();


            theOutput = new OutputManager(outputRichTB);
            player = new Civilization("Player civ", Color.Aquamarine, theOutput);

            theOutput.WriteLine("Is it working???");

            theOutput.FancyWriteLine("This should be italicized", Color.Black, FontStyle.Italic);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();


        }

        private void outputRichTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
