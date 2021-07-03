
namespace EscalonadorDeProcessos
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAlgoritmos = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pcbSair = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESCOLHA O ALGORITMO\r\nDE ESCALONAMENTO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbAlgoritmos
            // 
            this.cmbAlgoritmos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlgoritmos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbAlgoritmos.FormattingEnabled = true;
            this.cmbAlgoritmos.Items.AddRange(new object[] {
            "ROUND ROBIN",
            "PRIORIDADE",
            "MÚLTIPLAS FILAS",
            "JOB MAIS CURTO",
            "SORTEIO",
            "GARANTIDO"});
            this.cmbAlgoritmos.Location = new System.Drawing.Point(91, 154);
            this.cmbAlgoritmos.Name = "cmbAlgoritmos";
            this.cmbAlgoritmos.Size = new System.Drawing.Size(130, 23);
            this.cmbAlgoritmos.TabIndex = 2;
            this.cmbAlgoritmos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Vamos Lá!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pcbSair
            // 
            this.pcbSair.BackColor = System.Drawing.Color.Transparent;
            this.pcbSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pcbSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbSair.Image = ((System.Drawing.Image)(resources.GetObject("pcbSair.Image")));
            this.pcbSair.Location = new System.Drawing.Point(269, 12);
            this.pcbSair.Name = "pcbSair";
            this.pcbSair.Size = new System.Drawing.Size(38, 33);
            this.pcbSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSair.TabIndex = 5;
            this.pcbSair.TabStop = false;
            this.pcbSair.Click += new System.EventHandler(this.pcbSair_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 291);
            this.Controls.Add(this.pcbSair);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbAlgoritmos);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAlgoritmos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pcbSair;
    }
}

