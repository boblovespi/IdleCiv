using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boblovespi.IdleCiv
{
    class OutputManager
    {



        private RichTextBox output;

        public OutputManager(RichTextBox rtb)
        {
            output = rtb;
        }


        public void Write(string s)
        {
            output.AppendText(s);
        }

        public void WriteLine(string s)
        {
            Write(s + "\n");
        }

        public void FancyWrite(string s, Color color, FontStyle fontStyle)
        {
            output.SelectionFont = new Font(output.Font, fontStyle);
            output.SelectionColor = color;

            output.AppendText(s);

            output.SelectionFont = output.Font;
            output.SelectionColor = output.ForeColor;
        }

        public void FancyWrite(string s, Color color)
        {
            //output.SelectionFont = new Font(output.Font, fontStyle);
            output.SelectionColor = color;

            output.AppendText(s);

            //output.SelectionFont = output.Font;
            output.SelectionColor = output.ForeColor;
        }

        public void FancyWriteLine(string s, Color color, FontStyle fontStyle)
        {
            FancyWrite(s + "\n", color, fontStyle);
        }

        public void FancyWriteLine(string s, Color color)
        {
            FancyWrite(s + "\n", color);
        }
    }
}
