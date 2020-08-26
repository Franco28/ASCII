namespace asciiApp
{
    partial class Main_Form
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.buttonObtenerASCII = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxDecodificador = new System.Windows.Forms.TextBox();
            this.labelDecimal = new System.Windows.Forms.Label();
            this.labelHexadecimal = new System.Windows.Forms.Label();
            this.labelResultadoASCII = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.limpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decodificarCaracterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonObtenerChar = new System.Windows.Forms.Button();
            this.labelEj = new System.Windows.Forms.Label();
            this.labelBinTitle = new System.Windows.Forms.Label();
            this.labelResuDecimal = new System.Windows.Forms.TextBox();
            this.labelResuHexadecimal = new System.Windows.Forms.TextBox();
            this.labelResuBinario = new System.Windows.Forms.TextBox();
            this.console = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonObtenerASCII
            // 
            this.buttonObtenerASCII.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonObtenerASCII.Location = new System.Drawing.Point(617, 121);
            this.buttonObtenerASCII.Name = "buttonObtenerASCII";
            this.buttonObtenerASCII.Size = new System.Drawing.Size(75, 23);
            this.buttonObtenerASCII.TabIndex = 0;
            this.buttonObtenerASCII.Text = "Obtener";
            this.buttonObtenerASCII.UseVisualStyleBackColor = true;
            this.buttonObtenerASCII.Click += new System.EventHandler(this.buttonObtenerASCII_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(12, 35);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(319, 25);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Ingrese el carácter a decodificar";
            // 
            // textBoxDecodificador
            // 
            this.textBoxDecodificador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDecodificador.Location = new System.Drawing.Point(12, 93);
            this.textBoxDecodificador.MaxLength = 4;
            this.textBoxDecodificador.Name = "textBoxDecodificador";
            this.textBoxDecodificador.Size = new System.Drawing.Size(680, 22);
            this.textBoxDecodificador.TabIndex = 2;
            this.textBoxDecodificador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelDecimal
            // 
            this.labelDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDecimal.Location = new System.Drawing.Point(8, 166);
            this.labelDecimal.Name = "labelDecimal";
            this.labelDecimal.Size = new System.Drawing.Size(270, 20);
            this.labelDecimal.TabIndex = 3;
            this.labelDecimal.Text = "Decimal";
            this.labelDecimal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHexadecimal
            // 
            this.labelHexadecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHexadecimal.Location = new System.Drawing.Point(8, 238);
            this.labelHexadecimal.Name = "labelHexadecimal";
            this.labelHexadecimal.Size = new System.Drawing.Size(270, 20);
            this.labelHexadecimal.TabIndex = 5;
            this.labelHexadecimal.Text = "Hexadecimal";
            this.labelHexadecimal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResultadoASCII
            // 
            this.labelResultadoASCII.AutoSize = true;
            this.labelResultadoASCII.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultadoASCII.Location = new System.Drawing.Point(12, 131);
            this.labelResultadoASCII.Name = "labelResultadoASCII";
            this.labelResultadoASCII.Size = new System.Drawing.Size(94, 20);
            this.labelResultadoASCII.TabIndex = 7;
            this.labelResultadoASCII.Text = "Resultados:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limpiarToolStripMenuItem,
            this.invertirToolStripMenuItem,
            this.decodificarCaracterToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // limpiarToolStripMenuItem
            // 
            this.limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            this.limpiarToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.limpiarToolStripMenuItem.Text = "Limpiar";
            this.limpiarToolStripMenuItem.Click += new System.EventHandler(this.limpiarToolStripMenuItem_Click);
            // 
            // invertirToolStripMenuItem
            // 
            this.invertirToolStripMenuItem.Name = "invertirToolStripMenuItem";
            this.invertirToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.invertirToolStripMenuItem.Text = "Decodificar Hex o Dec";
            this.invertirToolStripMenuItem.Click += new System.EventHandler(this.invertirToolStripMenuItem_Click);
            // 
            // decodificarCaracterToolStripMenuItem
            // 
            this.decodificarCaracterToolStripMenuItem.Name = "decodificarCaracterToolStripMenuItem";
            this.decodificarCaracterToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.decodificarCaracterToolStripMenuItem.Text = "Decodificar Carácter";
            this.decodificarCaracterToolStripMenuItem.Click += new System.EventHandler(this.decodificarCaracterToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // buttonObtenerChar
            // 
            this.buttonObtenerChar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonObtenerChar.Location = new System.Drawing.Point(536, 121);
            this.buttonObtenerChar.Name = "buttonObtenerChar";
            this.buttonObtenerChar.Size = new System.Drawing.Size(75, 23);
            this.buttonObtenerChar.TabIndex = 9;
            this.buttonObtenerChar.Text = "Obtener";
            this.buttonObtenerChar.UseVisualStyleBackColor = true;
            this.buttonObtenerChar.Click += new System.EventHandler(this.buttonObtenerChar_Click);
            // 
            // labelEj
            // 
            this.labelEj.AutoSize = true;
            this.labelEj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEj.Location = new System.Drawing.Point(12, 74);
            this.labelEj.Name = "labelEj";
            this.labelEj.Size = new System.Drawing.Size(40, 16);
            this.labelEj.TabIndex = 10;
            this.labelEj.Text = "Ej: @";
            // 
            // labelBinTitle
            // 
            this.labelBinTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBinTitle.Location = new System.Drawing.Point(8, 307);
            this.labelBinTitle.Name = "labelBinTitle";
            this.labelBinTitle.Size = new System.Drawing.Size(270, 20);
            this.labelBinTitle.TabIndex = 11;
            this.labelBinTitle.Text = "Binario";
            this.labelBinTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResuDecimal
            // 
            this.labelResuDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResuDecimal.Location = new System.Drawing.Point(8, 190);
            this.labelResuDecimal.Name = "labelResuDecimal";
            this.labelResuDecimal.ReadOnly = true;
            this.labelResuDecimal.Size = new System.Drawing.Size(270, 26);
            this.labelResuDecimal.TabIndex = 15;
            this.labelResuDecimal.Text = "...";
            this.labelResuDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelResuHexadecimal
            // 
            this.labelResuHexadecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResuHexadecimal.Location = new System.Drawing.Point(8, 261);
            this.labelResuHexadecimal.Name = "labelResuHexadecimal";
            this.labelResuHexadecimal.ReadOnly = true;
            this.labelResuHexadecimal.Size = new System.Drawing.Size(270, 26);
            this.labelResuHexadecimal.TabIndex = 16;
            this.labelResuHexadecimal.Text = "...";
            this.labelResuHexadecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelResuBinario
            // 
            this.labelResuBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResuBinario.Location = new System.Drawing.Point(8, 330);
            this.labelResuBinario.Name = "labelResuBinario";
            this.labelResuBinario.ReadOnly = true;
            this.labelResuBinario.Size = new System.Drawing.Size(270, 26);
            this.labelResuBinario.TabIndex = 17;
            this.labelResuBinario.Text = "...";
            this.labelResuBinario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // console
            // 
            this.console.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console.Location = new System.Drawing.Point(284, 150);
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.Size = new System.Drawing.Size(408, 206);
            this.console.TabIndex = 18;
            this.console.Text = "";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(704, 363);
            this.Controls.Add(this.console);
            this.Controls.Add(this.labelResuBinario);
            this.Controls.Add(this.labelResuHexadecimal);
            this.Controls.Add(this.labelResuDecimal);
            this.Controls.Add(this.labelBinTitle);
            this.Controls.Add(this.labelEj);
            this.Controls.Add(this.buttonObtenerChar);
            this.Controls.Add(this.labelResultadoASCII);
            this.Controls.Add(this.labelHexadecimal);
            this.Controls.Add(this.labelDecimal);
            this.Controls.Add(this.textBoxDecodificador);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.buttonObtenerASCII);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TABLA ASCII";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxDecodificador;
        private System.Windows.Forms.Label labelDecimal;
        private System.Windows.Forms.Label labelHexadecimal;
        private System.Windows.Forms.Label labelResultadoASCII;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem invertirToolStripMenuItem;
        private System.Windows.Forms.Button buttonObtenerChar;
        private System.Windows.Forms.ToolStripMenuItem decodificarCaracterToolStripMenuItem;
        private System.Windows.Forms.Label labelEj;
        private System.Windows.Forms.Button buttonObtenerASCII;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Label labelBinTitle;
        private System.Windows.Forms.ToolStripMenuItem limpiarToolStripMenuItem;
        private System.Windows.Forms.TextBox labelResuDecimal;
        private System.Windows.Forms.TextBox labelResuHexadecimal;
        private System.Windows.Forms.TextBox labelResuBinario;
        private System.Windows.Forms.RichTextBox console;
    }
}

