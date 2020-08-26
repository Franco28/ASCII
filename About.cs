
using System;
using System.Reflection;
using System.Windows.Forms;

namespace asciiApp
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            this.Text = "Acerca de " + AssemblyProduct + " v" + Application.ProductVersion;
            pictureBox1.Image = Properties.Resources.ascii;
        }

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        public string AssemblyProduct
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }
    }
}
