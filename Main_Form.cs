
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
            if (s.Equals(""))
            {
                cAppend("Ingrese algún caractér");
                MessageBox.Show("Ingrese algún caractér", @"DECOFICADOR ASCII", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cAppend("Decodificando caractér ASCII... " + s);
                await Task.Run(() =>
                {
                    foreach (char c in s)
                    {
                        cAppend("-----------------------------------");
                        byte[] hexaenbytes = Encoding.Default.GetBytes(s);
                        var hexString = BitConverter.ToString(hexaenbytes);
                        int decValue = Convert.ToInt32(hexString, 16);
                        string binary = Convert.ToString(decValue, 2);
                        cAppend("Dec: " + decValue.ToString());
                        labelResuDecimal.Text = decValue.ToString();
                        cAppend("Hexa: " + hexString.ToString() + "h");
                        labelResuHexadecimal.Text = hexString.ToString() + "h";
                        cAppend("Bin: " + binary);
                        labelResuBinario.Text = binary;
                        cAppend("-----------------------------------");
                    }
                });
            }
        }

        public string Hex2Ascii(string hexString)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hexString.Length; i += 2)
            {
                string hs = hexString.Substring(i, 2);
                sb.Append(Convert.ToString(Convert.ToChar(Int32.Parse(hs, System.Globalization.NumberStyles.HexNumber))));
                cAppend("Caractér: " + sb.ToString());
                labelResuDecimal.Text = sb.ToString();
            }
            return sb.ToString();
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
                        Hex2Ascii(re);
                        string binary = Convert.ToString(c, 2);
                        cAppend("Bin: " + binary);
                        labelResuBinario.Text = binary;
                        cAppend("-----------------------------------");
                    });
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
                            char c = Convert.ToChar(value);
                            cAppend("Caractér: " + c.ToString());
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

            labelEj.Text = "Ej: ACh o 240";
            labelTitulo.Text = "Ingrese el número Decimal o Hexadecimal a decodificar a caractér";
            labelDecimal.Text = "Caractér";
            labelResuDecimal.Text = "...";
            labelHexadecimal.Hide();
            labelResuHexadecimal.Hide();
            buttonObtenerASCII.Hide();
            buttonObtenerChar.Show();
            buttonObtenerChar.Location = new Point(617, 105);
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
            labelTitulo.Text = "Ingrese el caractér a decodificar";
            labelDecimal.Text = "Decimal";
            labelResuDecimal.Text = "...";
            labelHexadecimal.Show();
            labelResuHexadecimal.Show();
            buttonObtenerASCII.Show();
            buttonObtenerChar.Hide();
            buttonObtenerASCII.Location = new Point(617, 105);
            labelBinTitle.Location = new Point(8, 307);
            labelResuBinario.Location = new Point(8, 330);
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

        private void Main_Form_Load(object sender, EventArgs e)
        {
            string userName = Environment.UserName;
            cAppend("Bienvenido " +  userName + " a Decodificador ASCII By Franco28");
        }
    }
}
