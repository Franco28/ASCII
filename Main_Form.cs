
using System;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asciiApp
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            buttonObtenerChar.Hide();
            CheckForIllegalCrossThreadCalls = false;
        }

        public void cAppend(string message)
        {
            this.Invoke((Action)delegate
            {
                console.AppendText(string.Format("\n{0} : {1}", DateTime.Now, message));
                console.ScrollToCaret();
            });
        }

        private async void buttonObtenerASCII_Click(object sender, EventArgs e)
        {
            string s = textBoxDecodificador.Text;
            byte[] hexaenbytes = Encoding.Default.GetBytes(s);
            var hexString = BitConverter.ToString(hexaenbytes);
            if (s.Equals(""))
            {
                cAppend("Ingrese algún carácter");
                MessageBox.Show("Ingrese algún carácter", @"DECOFICADOR ASCII", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cAppend("Decodificando carácter ASCII... " + s);
                await Task.Run(() =>
                {
                    cAppend("-----------------------------------");
                    foreach (char c in s)
                    {
                        cAppend("Dec: " + Convert.ToInt32(c).ToString());
                        labelResuDecimal.Text = Convert.ToInt32(c).ToString();
                        hexString = hexString.Replace("-", "");
                        labelResuHexadecimal.Text = hexString.ToString() + "h";
                        cAppend("Hexa: " + hexString.ToString() + "h");
                        string binary = Convert.ToString(c, 2);
                        labelResuBinario.Text = binary;
                        cAppend("Bin: " + binary);
                    }
                });
                cAppend("-----------------------------------");
            }
        }

        private async void buttonObtenerChar_Click(object sender, EventArgs e)
        {
            string s = textBoxDecodificador.Text;
            if (s.Equals(""))
            {
                cAppend("Ingrese algún número Hex o Dec");
                MessageBox.Show("Ingrese algún número Hex o Dec", @"DECOFICADOR ASCII", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {          
                if (s.EndsWith("h"))
                {
                    cAppend("Decodificando hexa... " + s);
                    await Task.Run(() =>
                    {
                        cAppend("-----------------------------------");
                        string re = s.Replace("h", "").Trim();
                        int decValue = Convert.ToInt32(re, 16);
                        char c = (char)decValue;
                        cAppend("Dec: " + c.ToString());
                        labelResuDecimal.Text = c.ToString();
                        string binary = Convert.ToString(c, 2);
                        cAppend("Bin: " + binary);
                        labelResuBinario.Text = binary;
                    });
                    cAppend("-----------------------------------");
                    return;
                }

                string input = s;
                int value;
                cAppend("Decodificando dec... " + input); 
                await Task.Run(() =>
                {
                    if (Int32.TryParse(input, out value))
                    {
                        if (value >= 0 && value <= 255)
                        {
                            cAppend("-----------------------------------");
                            char c = (char)value;
                            cAppend("Caráter: " + c.ToString());
                            labelResuDecimal.Text = c.ToString();
                            string binary = Convert.ToString(c, 2);
                            cAppend("Bin: " + binary);
                            labelResuBinario.Text = binary;
                            cAppend("-----------------------------------");
                        }
                        else
                        {
                            cAppend("El número ingresado superó el rango del valor >= 0 y valor <= 255");
                            MessageBox.Show("El número ingresado superó el rango del valor >= 0 y valor <= 255", @"DECOFICADOR ASCII", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                });
            }
        }

        private void invertirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelResuDecimal.Text = "...";
            labelResuHexadecimal.Text = "...";
            labelResuBinario.Text = "...";
            textBoxDecodificador.Text = "";

            labelEj.Text = "Ej: 9Fh o 30";
            labelTitulo.Text = "Ingrese el número Decimal o Hexadecimal a decodificar a carácter";
            labelDecimal.Text = "Carácter";
            labelResuDecimal.Text = "...";
            labelHexadecimal.Hide();
            labelResuHexadecimal.Hide();
            buttonObtenerASCII.Hide();
            buttonObtenerChar.Show();
            buttonObtenerChar.Location = new Point(617, 121);
            labelBinTitle.Location = new Point(8, 238);
            labelResuBinario.Location = new Point(8, 261);
            textBoxDecodificador.MaxLength = 6;
        }

        private void decodificarCaracterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelResuDecimal.Text = "...";
            labelResuHexadecimal.Text = "...";
            labelResuBinario.Text = "...";
            textBoxDecodificador.Text = "";

            labelEj.Text = "Ej: @";
            labelTitulo.Text = "Ingrese el carácter a decodificar";
            labelDecimal.Text = "Decimal";
            labelResuDecimal.Text = "...";
            labelHexadecimal.Show();
            labelResuHexadecimal.Show();
            buttonObtenerASCII.Show();
            buttonObtenerChar.Hide();
            buttonObtenerASCII.Location = new Point(617, 121);
            labelBinTitle.Location = new Point(12, 306);
            labelResuBinario.Location = new Point(15, 332);
            textBoxDecodificador.MaxLength = 4;
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelResuDecimal.Text = "...";
            labelResuHexadecimal.Text = "...";
            labelResuBinario.Text = "...";
            textBoxDecodificador.Text = "";
            console.Clear();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.ShowDialog();
        }
    }
}
