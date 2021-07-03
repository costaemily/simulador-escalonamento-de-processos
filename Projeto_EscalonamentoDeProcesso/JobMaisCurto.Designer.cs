
namespace EscalonadorDeProcessos
{
    partial class JobMaisCurto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobMaisCurto));
            this.label1 = new System.Windows.Forms.Label();
            this.txbSimulacao = new System.Windows.Forms.TextBox();
            this.btnLimparSimulacao = new System.Windows.Forms.Button();
            this.nudTempo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudQuantum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.colunaProcesso = new System.Windows.Forms.ColumnHeader();
            this.colunaTempo = new System.Windows.Forms.ColumnHeader();
            this.lsvListaProcessos = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnSimular = new System.Windows.Forms.Button();
            this.btnLimparLista = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pcbVoltar = new System.Windows.Forms.PictureBox();
            this.pcbAjuda = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantum)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAjuda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(267, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "JOB MAIS CURTO";
            // 
            // txbSimulacao
            // 
            this.txbSimulacao.BackColor = System.Drawing.Color.White;
            this.txbSimulacao.Location = new System.Drawing.Point(6, 45);
            this.txbSimulacao.Multiline = true;
            this.txbSimulacao.Name = "txbSimulacao";
            this.txbSimulacao.ReadOnly = true;
            this.txbSimulacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbSimulacao.Size = new System.Drawing.Size(374, 373);
            this.txbSimulacao.TabIndex = 26;
            // 
            // btnLimparSimulacao
            // 
            this.btnLimparSimulacao.Location = new System.Drawing.Point(262, 432);
            this.btnLimparSimulacao.Name = "btnLimparSimulacao";
            this.btnLimparSimulacao.Size = new System.Drawing.Size(118, 23);
            this.btnLimparSimulacao.TabIndex = 28;
            this.btnLimparSimulacao.Text = "Limpar Simulação";
            this.btnLimparSimulacao.UseVisualStyleBackColor = true;
            this.btnLimparSimulacao.Click += new System.EventHandler(this.btnLimparSimulacao_Click);
            // 
            // nudTempo
            // 
            this.nudTempo.Location = new System.Drawing.Point(143, 51);
            this.nudTempo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nudTempo.Name = "nudTempo";
            this.nudTempo.Size = new System.Drawing.Size(114, 23);
            this.nudTempo.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 34);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tempo\r\ndo Processo:\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nudQuantum
            // 
            this.nudQuantum.Location = new System.Drawing.Point(151, 433);
            this.nudQuantum.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nudQuantum.Name = "nudQuantum";
            this.nudQuantum.Size = new System.Drawing.Size(114, 23);
            this.nudQuantum.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Quantum:";
            // 
            // colunaProcesso
            // 
            this.colunaProcesso.Text = "Processo";
            this.colunaProcesso.Width = 100;
            // 
            // colunaTempo
            // 
            this.colunaTempo.Text = "Tempo";
            this.colunaTempo.Width = 100;
            // 
            // lsvListaProcessos
            // 
            this.lsvListaProcessos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaProcesso,
            this.colunaTempo});
            this.lsvListaProcessos.FullRowSelect = true;
            this.lsvListaProcessos.GridLines = true;
            this.lsvListaProcessos.HideSelection = false;
            this.lsvListaProcessos.Location = new System.Drawing.Point(29, 151);
            this.lsvListaProcessos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lsvListaProcessos.MultiSelect = false;
            this.lsvListaProcessos.Name = "lsvListaProcessos";
            this.lsvListaProcessos.Size = new System.Drawing.Size(203, 216);
            this.lsvListaProcessos.TabIndex = 21;
            this.lsvListaProcessos.UseCompatibleStateImageBehavior = false;
            this.lsvListaProcessos.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(29, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Lista de Processos:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(29, 84);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(80, 25);
            this.btnAdicionar.TabIndex = 24;
            this.btnAdicionar.Text = "Adiconar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(6, 432);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 25;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // btnLimparLista
            // 
            this.btnLimparLista.Location = new System.Drawing.Point(29, 388);
            this.btnLimparLista.Name = "btnLimparLista";
            this.btnLimparLista.Size = new System.Drawing.Size(106, 23);
            this.btnLimparLista.TabIndex = 27;
            this.btnLimparLista.Text = "Limpar Lista";
            this.btnLimparLista.UseVisualStyleBackColor = true;
            this.btnLimparLista.Click += new System.EventHandler(this.btnLimparLista_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.lsvListaProcessos);
            this.groupBox1.Controls.Add(this.nudTempo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudQuantum);
            this.groupBox1.Controls.Add(this.btnLimparLista);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 473);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Processo";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(157, 388);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 28;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbSimulacao);
            this.groupBox2.Controls.Add(this.btnLimparSimulacao);
            this.groupBox2.Controls.Add(this.btnSimular);
            this.groupBox2.Location = new System.Drawing.Point(301, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 473);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Simulação";
            // 
            // pcbVoltar
            // 
            this.pcbVoltar.BackColor = System.Drawing.Color.Transparent;
            this.pcbVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pcbVoltar.Image")));
            this.pcbVoltar.Location = new System.Drawing.Point(12, 15);
            this.pcbVoltar.Name = "pcbVoltar";
            this.pcbVoltar.Size = new System.Drawing.Size(38, 35);
            this.pcbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbVoltar.TabIndex = 64;
            this.pcbVoltar.TabStop = false;
            this.pcbVoltar.Click += new System.EventHandler(this.pcbVoltar_Click);
            // 
            // pcbAjuda
            // 
            this.pcbAjuda.BackColor = System.Drawing.Color.Transparent;
            this.pcbAjuda.Cursor = System.Windows.Forms.Cursors.Help;
            this.pcbAjuda.Image = ((System.Drawing.Image)(resources.GetObject("pcbAjuda.Image")));
            this.pcbAjuda.Location = new System.Drawing.Point(643, 15);
            this.pcbAjuda.Name = "pcbAjuda";
            this.pcbAjuda.Size = new System.Drawing.Size(38, 35);
            this.pcbAjuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAjuda.TabIndex = 65;
            this.pcbAjuda.TabStop = false;
            this.pcbAjuda.Click += new System.EventHandler(this.pcbAjuda_Click);
            // 
            // JobMaisCurto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 567);
            this.Controls.Add(this.pcbAjuda);
            this.Controls.Add(this.pcbVoltar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JobMaisCurto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobMaisCurto";
            this.Load += new System.EventHandler(this.JobMaisCurto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAjuda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSimulacao;
        private System.Windows.Forms.Button btnLimparSimulacao;
        private System.Windows.Forms.NumericUpDown nudTempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudQuantum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader colunaProcesso;
        private System.Windows.Forms.ColumnHeader colunaTempo;
        private System.Windows.Forms.ListView lsvListaProcessos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Button btnLimparLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.PictureBox pcbVoltar;
        private System.Windows.Forms.PictureBox pcbAjuda;
    }
}