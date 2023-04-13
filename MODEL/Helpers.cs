using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleVendas.MODEL
{
    public class Helpers
    {
        public void LimparTela(Form tela)
        {
            foreach (Control ctrPai in tela.Controls)
            {
                foreach (Control ctr1 in ctrPai.Controls)
                {
                    if (ctr1 is TabPage)
                    {
                        foreach (Control ctrl2 in ctr1.Controls)
                        {
                            if (ctrl2 is TextBox)
                            {
                                (ctrl2 as TextBox).Text = string.Empty;
                            }
                            if (ctrl2 is ComboBox)
                            {
                                (ctrl2 as ComboBox).Text = string.Empty;
                            }
                            if (ctrl2 is MaskedTextBox)
                            {
                                (ctrl2 as MaskedTextBox).Text = string.Empty;
                            }
                        }
                    }
                }
                
            }

        }


    }
}
