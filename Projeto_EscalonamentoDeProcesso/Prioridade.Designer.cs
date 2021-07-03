
namespace EscalonadorDeProcessos
{
    partial class Prioridade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prioridade));
            this.btnLimparSimulacao = new System.Windows.Forms.Button();
            this.btnLimparLista = new System.Windows.Forms.Button();
            this.txbSimulacao = new System.Windows.Forms.TextBox();
            this.btnSimular = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lsvListaProcessos = new System.Windows.Forms.ListView();
            this.colunaProcesso = new System.Windows.Forms.ColumnHeader();
            this.colunaTempo = new System.Windows.Forms.ColumnHeader();
            this.colunaPrioridade = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.nudQuantum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudTempo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPrioridade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pcbVoltar = new System.Windows.Forms.PictureBox();
            this.pcbAjuda = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAjuda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimparSimulacao
            // 
            this.btnLimparSimulacao.Location = new System.Drawing.Point(249, 448);
            this.btnLimparSimulacao.Name = "btnLimparSimulacao";
            this.btnLimparSimulacao.Size = new System.Drawing.Size(118, 23);
            this.btnLimparSimulacao.TabIndex = 28;
            this.btnLimparSimulacao.Text = "Limpar Simulação";
            this.btnLimparSimulacao.UseVisualStyleBackColor = true;
            this.btnLimparSimulacao.Click += new System.EventHandler(this.btnLimparSimulacao_Click);
            // 
            // btnLimparLista
            // 
            this.btnLimparLista.Location = new System.Drawing.Point(36, 407);
            this.btnLimparLista.Name = "btnLimparLista";
            this.btnLimparLista.Size = new System.Drawing.Size(106, 23);
            this.btnLimparLista.TabIndex = 27;
            this.btnLimparLista.Text = "Limpar Lista";
            this.btnLimparLista.UseVisualStyleBackColor = true;
            this.btnLimparLista.Click += new System.EventHandler(this.btnLimparLista_Click);
            // 
            // txbSimulacao
            // 
            this.txbSimulacao.BackColor = System.Drawing.Color.White;
            this.txbSimulacao.Location = new System.Drawing.Point(8, 35);
            this.txbSimulacao.Multiline = true;
            this.txbSimulacao.Name = "txbSimulacao";
            this.txbSimulacao.ReadOnly = true;
            this.txbSimulacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbSimulacao.Size = new System.Drawing.Size(359, 395);
            this.txbSimulacao.TabIndex = 26;
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(6, 448);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 25;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(36, 117);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(80, 24);
            this.btnAdicionar.TabIndex = 24;
            this.btnAdicionar.Text = "Adiconar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(36, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Lista de Processos:";
            // 
            // lsvListaProcessos
            // 
            this.lsvListaProcessos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaProcesso,
            this.colunaTempo,
            this.colunaPrioridade});
            this.lsvListaProcessos.FullRowSelect = true;
            this.lsvListaProcessos.GridLines = true;
            this.lsvListaProcessos.HideSelection = false;
            this.lsvListaProcessos.Location = new System.Drawing.Point(36, 184);
            this.lsvListaProcessos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lsvListaProcessos.MultiSelect = false;
            this.lsvListaProcessos.Name = "lsvListaProcessos";
            this.lsvListaProcessos.Size = new System.Drawing.Size(228, 216);
            this.lsvListaProcessos.TabIndex = 21;
            this.lsvListaProcessos.UseCompatibleStateImageBehavior = false;
            this.lsvListaProcessos.View = System.Windows.Forms.View.Details;
            // 
            // colunaProcesso
            // 
            this.colunaProcesso.Text = "Processo";
            this.colunaProcesso.Width = 75;
            // 
            // colunaTempo
            // 
            this.colunaTempo.Text = "Tempo";
            this.colunaTempo.Width = 75;
            // 
            // colunaPrioridade
            // 
            this.colunaPrioridade.Text = "Prioridade";
            this.colunaPrioridade.Width = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(35, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Quantum:";
            // 
            // nudQuantum
            // 
            this.nudQuantum.Location = new System.Drawing.Point(149, 448);
            this.nudQuantum.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nudQuantum.Name = "nudQuantum";
            this.nudQuantum.Size = new System.Drawing.Size(115, 23);
            this.nudQuantum.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 34);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tempo\r\ndo Processo:\r\n";
            // 
            // nudTempo
            // 
            this.nudTempo.Location = new System.Drawing.Point(149, 48);
            this.nudTempo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nudTempo.Name = "nudTempo";
            this.nudTempo.Size = new System.Drawing.Size(115, 23);
            this.nudTempo.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(287, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "PRIORIDADE";
            // 
            // cmbPrioridade
            // 
            this.cmbPrioridade.FormattingEnabled = true;
            this.cmbPrioridade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbPrioridade.Location = new System.Drawing.Point(149, 82);
            this.cmbPrioridade.Name = "cmbPrioridade";
            this.cmbPrioridade.Size = new System.Drawing.Size(115, 23);
            this.cmbPrioridade.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(36, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Prioridade:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.lsvListaProcessos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nudTempo);
            this.groupBox1.Controls.Add(this.cmbPrioridade);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudQuantum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnLimparLista);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 491);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Processo";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(189, 407);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 44;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbSimulacao);
            this.groupBox2.Controls.Add(this.btnLimparSimulacao);
            this.groupBox2.Controls.Add(this.btnSimular);
            this.groupBox2.Location = new System.Drawing.Point(323, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 491);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Simulação";
            // 
            // pcbVoltar
            // 
            this.pcbVoltar.BackColor = System.Drawing.Color.Transparent;
            this.pcbVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pcbVoltar.Image")));
            this.pcbVoltar.Location = new System.Drawing.Point(12, 16);
            this.pcbVoltar.Name = "pcbVoltar";
            this.pcbVoltar.Size = new System.Drawing.Size(38, 35);
            this.pcbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbVoltar.TabIndex = 35;
            this.pcbVoltar.TabStop = false;
            this.pcbVoltar.Click += new System.EventHandler(this.pcbVoltar_Click);
            // 
            // pcbAjuda
            // 
            this.pcbAjuda.BackColor = System.Drawing.Color.Transparent;
            this.pcbAjuda.Cursor = System.Windows.Forms.Cursors.Help;
            this.pcbAjuda.Image = ((System.Drawing.Image)(resources.GetObject("pcbAjuda.Image")));
            this.pcbAjuda.Location = new System.Drawing.Point(652, 16);
            this.pcbAjuda.Name = "pcbAjuda";
            this.pcbAjuda.Size = new System.Drawing.Size(38, 35);
            this.pcbAjuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAjuda.TabIndex = 50;
            this.pcbAjuda.TabStop = false;
            this.pcbAjuda.Click += new System.EventHandler(this.pcbAjuda_Click);
            // 
            // Prioridade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 590);
            this.Controls.Add(this.pcbAjuda);
            this.Controls.Add(this.pcbVoltar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prioridade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prioridade";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempo)).EndInit();
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
        private System.Windows.Forms.Button btnLimparSimulacao;
        private System.Windows.Forms.Button btnLimparLista;
        private System.Windows.Forms.TextBox txbSimulacao;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lsvListaProcessos;
        private System.Windows.Forms.ColumnHeader colunaProcesso;
        private System.Windows.Forms.ColumnHeader colunaTempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudQuantum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader colunaPrioridade;
        private System.Windows.Forms.ComboBox cmbPrioridade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pcbVoltar;
        private System.Windows.Forms.PictureBox pcbAjuda;
    }
}