using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Events4ALL
{
    public partial class Promociones : UserControl
    {
        public Promociones()
        {
            InitializeComponent();
        }

        private void checkBox_MC_ActivarCond1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_MC_ActivarCond1.Checked == true)
            {
                textBox_MC_VC_Valor2.Enabled = true;
                comboBox_MC_VC_Comparacion2.Enabled = true;
                comboBox_MC_VC_Tcondicion2.Enabled = true;
                radioButton_MC_TE2_Cine.Enabled = true;
                radioButton_MC_TE2_Espectaculo.Enabled = true;
                radioButton_MC_TE2_Teatro.Enabled = true;
            }
            else
            {
                textBox_MC_VC_Valor2.Enabled = false;
                comboBox_MC_VC_Comparacion2.Enabled = false;
                comboBox_MC_VC_Tcondicion2.Enabled = false;
                radioButton_MC_TE2_Cine.Enabled = false;
                radioButton_MC_TE2_Espectaculo.Enabled = false;
                radioButton_MC_TE2_Teatro.Enabled = false;
            }
        }

        private void checkBox_MC_ActivarCond2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_MC_ActivarCond2.Checked == true)
            {
                textBox_MC_VC_Valor3.Enabled = true;
                comboBox_MC_VC_Comparacion3.Enabled = true;
                comboBox_MC_VC_Tcondicion3.Enabled = true;
                radioButton_MC_TE3_Cine.Enabled = true;
                radioButton_MC_TE3_Espectaculo.Enabled = true;
                radioButton_MC_TE3_Teatro.Enabled = true;
            }
            else
            {
                textBox_MC_VC_Valor3.Enabled = false;
                comboBox_MC_VC_Comparacion3.Enabled = false;
                comboBox_MC_VC_Tcondicion3.Enabled = false;
                radioButton_MC_TE3_Cine.Enabled = false;
                radioButton_MC_TE3_Espectaculo.Enabled = false;
                radioButton_MC_TE3_Teatro.Enabled = false;
            }
        }

    }
}
