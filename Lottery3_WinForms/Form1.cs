using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LotteryNumberGenerator;

namespace Lottery3_WinForms
{
    public partial class Form1 : Form
    {
        private bool isCalledFromInside = false;
        private Controller controller = new Controller();
        private SettingsStorager storager = new SettingsStorager(@".\Config.xml");

        public Form1()
        {
            InitializeComponent();
            InitializeSettings();
        }

        public event EventHandler OnParameterChanged;

        private void ParameterChanged(EventArgs e)
        {
            if(OnParameterChanged == null || isCalledFromInside)
            {
                return;
            }
            OnParameterChanged(this, e);
        }

        private void nUD_Loto6_ValueChanged(object sender, EventArgs e)
        {
            ParameterChanged(e);
        }

        private void nUD_Loto7_ValueChanged(object sender, EventArgs e)
        {
            ParameterChanged(e);
        }

        private void nUD_Miniloto_ValueChanged(object sender, EventArgs e)
        {
            ParameterChanged(e);
        }

        private void nUD_Numbers3_ValueChanged(object sender, EventArgs e)
        {
            ParameterChanged(e);
        }

        private void nUD_Numbers4_ValueChanged(object sender, EventArgs e)
        {
            ParameterChanged(e);
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            this.btn_Start.Enabled = false;
            SetNUDEnable(false);

            using(var f = new Form())
            {
                var message = controller.Execute();

                f.TopMost = true;
                var result = MessageBox.Show(f, message, "Calculation Results", MessageBoxButtons.OK);
                f.TopMost = false;

                if(result == DialogResult.OK)
                {
                    this.btn_Start.Enabled = true;
                    SetNUDEnable(true);
                }
            }
            try
            {
                storager.SetParameter(controller.Parameter);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred" + Environment.NewLine + ex.Message);
            }
        }

        private void Form1_ParameterChanged(object sender, EventArgs e)
        {
            controller.Parameter = GetParameter();
        }

        public void SetParameter(UIParameter param)
        {
            this.SuspendLayout();
            isCalledFromInside = true;

            nUD_Loto6.Value = param.Units[(int)LotteryType.Loto6];
            nUD_Loto7.Value = param.Units[(int)LotteryType.Loto7];
            nUD_Miniloto.Value = param.Units[(int)LotteryType.Miniloto];
            nUD_Numbers3.Value = param.Units[(int)LotteryType.Numbers3];
            nUD_Numbers4.Value = param.Units[(int)LotteryType.Numbers4];

            isCalledFromInside = false;
            this.ResumeLayout();
        }

        public UIParameter GetParameter()
        {
            var result = new UIParameter();

            result.Units[(int)LotteryType.Loto6] = (int)nUD_Loto6.Value;
            result.Units[(int)LotteryType.Loto7] = (int)nUD_Loto7.Value;
            result.Units[(int)LotteryType.Miniloto] = (int)nUD_Miniloto.Value;
            result.Units[(int)LotteryType.Numbers3] = (int)nUD_Numbers3.Value;
            result.Units[(int)LotteryType.Numbers4] = (int)nUD_Numbers4.Value;

            return result;
        }

        private void InitializeSettings()
        {
            try
            {
                if (storager.HasInfo())
                {
                    controller.Parameter = storager.GetParameter<UIParameter>();
                }
                SetParameter(controller.Parameter);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred" + Environment.NewLine + ex.Message);
            }
        }

        private void SetNUDEnable(bool isEnable)
        {
            nUD_Loto6.Enabled = isEnable;
            nUD_Loto7.Enabled = isEnable;
            nUD_Miniloto.Enabled = isEnable;
            nUD_Numbers3.Enabled = isEnable;
            nUD_Numbers4.Enabled = isEnable;
        }
    }
}
