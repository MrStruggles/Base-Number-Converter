using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberBaseConverter
{
    public partial class frmSolver : Form
    {
        public frmSolver()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            //int ConvertInput(string input)
            //{
            //    char[] inputComponents = input.ToCharArray();
            //    for (int i = 0; i < inputComponents.Length; i++)
            //    {
            //        if (char.IsLetter(inputComponents[i]))
            //        {
            //            int index = -1;
            //            foreach (string letter in Calculator.alphabet)
            //            {
            //                index++;
            //                if (letter == inputComponents[i].ToString())
            //                {

            //                }
                            
            //            }
            //        }
            //    }
            //}


            lblNumber.Text = "Base " + nudNumBase.Value + ": " + nudNumber.Value;
            lblAnswer.Text = "Base " + nudAnswerBase.Value + ": " + Calculator.ConvertNumber(Convert.ToInt32(nudNumBase.Value), Convert.ToInt32(nudAnswerBase.Value), Convert.ToInt32(nudNumber.Value));
        }
    }
}
