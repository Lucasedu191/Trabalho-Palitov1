using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Palitov1
{
    public partial class FormPalito : Form
    {
        public FormPalito()
        {
            InitializeComponent();
        }
        private int A = 0;
        private int B = 0;

        // RichTextBoxpalito.AppendText();
        private void Btnjogar_Click(object sender, EventArgs e)
        {
			this.Btnretirar.Visible = true;
			this.Maskbxpalitos.Visible = true;
			this.Lblquantospalitos.Visible = true;




		}

        private void Btnretirar_Click(object sender, EventArgs e)
        {
            int palitos = (int)(Numqtdpalitos.Value);

            RichTextBoxpalito.AppendText( " Eu começo!! ");
            RichTextBoxpalito.AppendText(Environment.NewLine);
            RichTextBoxpalito.AppendText("Retiro " + (3) + " Palitos");
            RichTextBoxpalito.AppendText(Environment.NewLine);
			RichTextBoxpalito.AppendText("sua vez... ");
			RichTextBoxpalito.AppendText(Environment.NewLine);
			RichTextBoxpalito.AppendText("Restam " + (3) + " palitos");
            RichTextBoxpalito.AppendText(Environment.NewLine);
            RichTextBoxpalito.AppendText("Restam " + (3) + " palitos");





            {
                
            }



        }

  
    }
}
