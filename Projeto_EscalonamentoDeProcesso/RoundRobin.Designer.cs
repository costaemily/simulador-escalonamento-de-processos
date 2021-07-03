
namespace EscalonadorDeProcessos
{
    partial class RoundRobin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoundRobin));
            this.label1 = new System.Windows.Forms.Label();
            this.nudTempo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudQuantum = new System.Windows.Forms.NumericUpDown();
            this.lsvListaProcessos = new System.Windows.Forms.ListView();
            this.colunaProcesso = new System.Windows.Forms.ColumnHeader();
            this.colunaTempo = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnSimular = new System.Windows.Forms.Button();
            this.txbSimulacao = new System.Windows.Forms.TextBox();
            this.btnLimparLista = new System.Windows.Forms.Button();
            this.btnLimparSimulacao = new System.Windows.Forms.Button();
            this.gpbProcesso = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pcbVoltar = new System.Windows.Forms.PictureBox();
            this.pcbAjuda = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantum)).BeginInit();
            this.gpbProcesso.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAjuda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(288, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROUND ROBIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nudTempo
            // 
            this.nudTempo.Location = new System.Drawing.Point(146, 44);
            this.nudTempo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nudTempo.Name = "nudTempo";
            this.nudTempo.Size = new System.Drawing.Size(114, 23);
            this.nudTempo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tempo\r\ndo Processo:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantum:";
            // 
            // nudQuantum
            // 
            this.nudQuantum.Location = new System.Drawing.Point(134, 440);
            this.nudQuantum.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nudQuantum.Name = "nudQuantum";
            this.nudQuantum.Size = new System.Drawing.Size(114, 23);
            this.nudQuantum.TabIndex = 3;
            // 
            // lsvListaProcessos
            // 
            this.lsvListaProcessos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaProcesso,
            this.colunaTempo});
            this.lsvListaProcessos.FullRowSelect = true;
            this.lsvListaProcessos.GridLines = true;
            this.lsvListaProcessos.HideSelection = false;
            this.lsvListaProcessos.Location = new System.Drawing.Point(32, 143);
            this.lsvListaProcessos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lsvListaProcessos.MultiSelect = false;
            this.lsvListaProcessos.Name = "lsvListaProcessos";
            this.lsvListaProcessos.Size = new System.Drawing.Size(203, 222);
            this.lsvListaProcessos.TabIndex = 5;
            this.lsvListaProcessos.UseCompatibleStateImageBehavior = false;
            this.lsvListaProcessos.View = System.Windows.Forms.View.Details;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(32, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lista de Processos:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(32, 79);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(80, 24);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "Adiconar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(14, 440);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 10;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // txbSimulacao
            // 
            this.txbSimulacao.BackColor = System.Drawing.Color.White;
            this.txbSimulacao.Location = new System.Drawing.Point(14, 34);
            this.txbSimulacao.Multiline = true;
            this.txbSimulacao.Name = "txbSimulacao";
            this.txbSimulacao.ReadOnly = true;
            this.txbSimulacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbSimulacao.Size = new System.Drawing.Size(359, 387);
            this.txbSimulacao.TabIndex = 11;
            // 
            // btnLimparLista
            // 
            this.btnLimparLista.Location = new System.Drawing.Point(30, 389);
            this.btnLimparLista.Name = "btnLimparLista";
            this.btnLimparLista.Size = new System.Drawing.Size(106, 23);
            this.btnLimparLista.TabIndex = 12;
            this.btnLimparLista.Text = "Limpar Lista";
            this.btnLimparLista.UseVisualStyleBackColor = true;
            this.btnLimparLista.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimparSimulacao
            // 
            this.btnLimparSimulacao.Location = new System.Drawing.Point(255, 440);
            this.btnLimparSimulacao.Name = "btnLimparSimulacao";
            this.btnLimparSimulacao.Size = new System.Drawing.Size(118, 23);
            this.btnLimparSimulacao.TabIndex = 13;
            this.btnLimparSimulacao.Text = "Limpar Simulação";
            this.btnLimparSimulacao.UseVisualStyleBackColor = true;
            this.btnLimparSimulacao.Click += new System.EventHandler(this.btnLimparSimulacao_Click);
            // 
            // gpbProcesso
            // 
            this.gpbProcesso.Controls.Add(this.btnExcluir);
            this.gpbProcesso.Controls.Add(this.lsvListaProcessos);
            this.gpbProcesso.Controls.Add(this.nudTempo);
            this.gpbProcesso.Controls.Add(this.label2);
            this.gpbProcesso.Controls.Add(this.nudQuantum);
            this.gpbProcesso.Controls.Add(this.btnLimparLista);
            this.gpbProcesso.Controls.Add(this.label3);
            this.gpbProcesso.Controls.Add(this.label4);
            this.gpbProcesso.Controls.Add(this.btnAdicionar);
            this.gpbProcesso.Location = new System.Drawing.Point(12, 71);
            this.gpbProcesso.Name = "gpbProcesso";
            this.gpbProcesso.Size = new System.Drawing.Size(287, 485);
            this.gpbProcesso.TabIndex = 16;
            this.gpbProcesso.TabStop = false;
            this.gpbProcesso.Text = "Processo";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(160, 389);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbSimulacao);
            this.groupBox1.Controls.Add(this.btnLimparSimulacao);
            this.groupBox1.Controls.Add(this.btnSimular);
            this.groupBox1.Location = new System.Drawing.Point(305, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 485);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulação";
            // 
            // pcbVoltar
            // 
            this.pcbVoltar.BackColor = System.Drawing.Color.Transparent;
            this.pcbVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pcbVoltar.Image")));
            this.pcbVoltar.Location = new System.Drawing.Point(12, 12);
            this.pcbVoltar.Name = "pcbVoltar";
            this.pcbVoltar.Size = new System.Drawing.Size(38, 35);
            this.pcbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbVoltar.TabIndex = 18;
            this.pcbVoltar.TabStop = false;
            this.pcbVoltar.Click += new System.EventHandler(this.pcbVoltar_Click);
            // 
            // pcbAjuda
            // 
            this.pcbAjuda.BackColor = System.Drawing.Color.Transparent;
            this.pcbAjuda.Cursor = System.Windows.Forms.Cursors.Help;
            this.pcbAjuda.Image = ((System.Drawing.Image)(resources.GetObject("pcbAjuda.Image")));
            this.pcbAjuda.Location = new System.Drawing.Point(640, 12);
            this.pcbAjuda.Name = "pcbAjuda";
            this.pcbAjuda.Size = new System.Drawing.Size(38, 35);
            this.pcbAjuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAjuda.TabIndex = 19;
            this.pcbAjuda.TabStop = false;
            this.pcbAjuda.Click += new System.EventHandler(this.pcbAjuda_Click);
            // 
            // RoundRobin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 572);
            this.Controls.Add(this.pcbAjuda);
            this.Controls.Add(this.pcbVoltar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbProcesso);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RoundRobin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoundRobin";
            this.Load += new System.EventHandler(this.RoundRobin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantum)).EndInit();
            this.gpbProcesso.ResumeLayout(false);
            this.gpbProcesso.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAjuda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudTempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudQuantum;
        private System.Windows.Forms.ListView lsvListaProcessos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.ColumnHeader colunaProcesso;
        private System.Windows.Forms.ColumnHeader colunaTempo;
        private System.Windows.Forms.TextBox txbSimulacao;
        private System.Windows.Forms.Button btnLimparLista;
        private System.Windows.Forms.Button btnLimparSimulacao;
        private System.Windows.Forms.GroupBox gpbProcesso;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pcbVoltar;
        private System.Windows.Forms.PictureBox pcbAjuda;
    }
}