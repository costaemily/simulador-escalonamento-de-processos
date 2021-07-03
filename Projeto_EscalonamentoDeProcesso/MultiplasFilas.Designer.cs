
namespace EscalonadorDeProcessos
{
    partial class MultiplasFilas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiplasFilas));
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPrioridade = new System.Windows.Forms.ComboBox();
            this.btnLimparSimulacao = new System.Windows.Forms.Button();
            this.btnLimparLista = new System.Windows.Forms.Button();
            this.txbSimulacao = new System.Windows.Forms.TextBox();
            this.btnSimular = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lsvListaProcessos = new System.Windows.Forms.ListView();
            this.colunaProcesso = new System.Windows.Forms.ColumnHeader();
            this.colunaTempo = new System.Windows.Forms.ColumnHeader();
            this.colunaListaPrioridade = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.nudQuantum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudTempo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvFilas = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbAlgoritmo = new System.Windows.Forms.ComboBox();
            this.btnAdicionarFila = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbFila = new System.Windows.Forms.ComboBox();
            this.btnLimparFilas = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gpbProcesso = new System.Windows.Forms.GroupBox();
            this.gpbFilaPrioridade = new System.Windows.Forms.GroupBox();
            this.gpbSimulacao = new System.Windows.Forms.GroupBox();
            this.pcbVoltar = new System.Windows.Forms.PictureBox();
            this.pcbAjuda = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempo)).BeginInit();
            this.gpbProcesso.SuspendLayout();
            this.gpbFilaPrioridade.SuspendLayout();
            this.gpbSimulacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAjuda)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(8, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 34);
            this.label6.TabIndex = 49;
            this.label6.Text = "Fila de \r\nPrioridade:\r\n";
            // 
            // cmbPrioridade
            // 
            this.cmbPrioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPrioridade.FormattingEnabled = true;
            this.cmbPrioridade.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbPrioridade.Location = new System.Drawing.Point(112, 77);
            this.cmbPrioridade.Name = "cmbPrioridade";
            this.cmbPrioridade.Size = new System.Drawing.Size(124, 23);
            this.cmbPrioridade.TabIndex = 48;
            // 
            // btnLimparSimulacao
            // 
            this.btnLimparSimulacao.Location = new System.Drawing.Point(249, 415);
            this.btnLimparSimulacao.Name = "btnLimparSimulacao";
            this.btnLimparSimulacao.Size = new System.Drawing.Size(118, 29);
            this.btnLimparSimulacao.TabIndex = 45;
            this.btnLimparSimulacao.Text = "Limpar Simulação";
            this.btnLimparSimulacao.UseVisualStyleBackColor = true;
            this.btnLimparSimulacao.Click += new System.EventHandler(this.btnLimparSimulacao_Click);
            // 
            // btnLimparLista
            // 
            this.btnLimparLista.Location = new System.Drawing.Point(8, 415);
            this.btnLimparLista.Name = "btnLimparLista";
            this.btnLimparLista.Size = new System.Drawing.Size(106, 29);
            this.btnLimparLista.TabIndex = 44;
            this.btnLimparLista.Text = "Limpar Lista";
            this.btnLimparLista.UseVisualStyleBackColor = true;
            this.btnLimparLista.Click += new System.EventHandler(this.btnLimparLista_Click);
            // 
            // txbSimulacao
            // 
            this.txbSimulacao.BackColor = System.Drawing.Color.White;
            this.txbSimulacao.Location = new System.Drawing.Point(8, 28);
            this.txbSimulacao.Multiline = true;
            this.txbSimulacao.Name = "txbSimulacao";
            this.txbSimulacao.ReadOnly = true;
            this.txbSimulacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbSimulacao.Size = new System.Drawing.Size(359, 363);
            this.txbSimulacao.TabIndex = 43;
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(8, 415);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 29);
            this.btnSimular.TabIndex = 42;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(8, 111);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(80, 29);
            this.btnAdicionar.TabIndex = 41;
            this.btnAdicionar.Text = "Adiconar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(594, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 40;
            this.label5.Text = "Simulação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(8, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Lista de Processos:";
            // 
            // lsvListaProcessos
            // 
            this.lsvListaProcessos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaProcesso,
            this.colunaTempo,
            this.colunaListaPrioridade});
            this.lsvListaProcessos.FullRowSelect = true;
            this.lsvListaProcessos.GridLines = true;
            this.lsvListaProcessos.HideSelection = false;
            this.lsvListaProcessos.Location = new System.Drawing.Point(8, 177);
            this.lsvListaProcessos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lsvListaProcessos.MultiSelect = false;
            this.lsvListaProcessos.Name = "lsvListaProcessos";
            this.lsvListaProcessos.Size = new System.Drawing.Size(253, 214);
            this.lsvListaProcessos.TabIndex = 38;
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
            // colunaListaPrioridade
            // 
            this.colunaListaPrioridade.Text = "Lista (Prioridade)";
            this.colunaListaPrioridade.Width = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Quantum:";
            // 
            // nudQuantum
            // 
            this.nudQuantum.Location = new System.Drawing.Point(144, 58);
            this.nudQuantum.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nudQuantum.Name = "nudQuantum";
            this.nudQuantum.Size = new System.Drawing.Size(124, 23);
            this.nudQuantum.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 34);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tempo\r\ndo Processo:\r\n";
            // 
            // nudTempo
            // 
            this.nudTempo.Location = new System.Drawing.Point(112, 37);
            this.nudTempo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nudTempo.Name = "nudTempo";
            this.nudTempo.Size = new System.Drawing.Size(124, 23);
            this.nudTempo.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(394, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "MÚLTIPLAS FILAS";
            // 
            // lsvFilas
            // 
            this.lsvFilas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvFilas.FullRowSelect = true;
            this.lsvFilas.GridLines = true;
            this.lsvFilas.HideSelection = false;
            this.lsvFilas.Location = new System.Drawing.Point(19, 177);
            this.lsvFilas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lsvFilas.MultiSelect = false;
            this.lsvFilas.Name = "lsvFilas";
            this.lsvFilas.Size = new System.Drawing.Size(253, 214);
            this.lsvFilas.TabIndex = 50;
            this.lsvFilas.UseCompatibleStateImageBehavior = false;
            this.lsvFilas.View = System.Windows.Forms.View.Details;
            this.lsvFilas.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fila";
            this.columnHeader4.Width = 75;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantum";
            this.columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Algoritmo";
            this.columnHeader6.Width = 110;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(19, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "Lista deFilas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(19, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 53;
            this.label8.Text = "Algoritmo:";
            // 
            // cmbAlgoritmo
            // 
            this.cmbAlgoritmo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlgoritmo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbAlgoritmo.FormattingEnabled = true;
            this.cmbAlgoritmo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbAlgoritmo.Items.AddRange(new object[] {
            "ROUND ROBIN",
            "JOB MAIS CURTO",
            "SORTEIO"});
            this.cmbAlgoritmo.Location = new System.Drawing.Point(144, 27);
            this.cmbAlgoritmo.Name = "cmbAlgoritmo";
            this.cmbAlgoritmo.Size = new System.Drawing.Size(124, 23);
            this.cmbAlgoritmo.TabIndex = 52;
            this.cmbAlgoritmo.SelectedIndexChanged += new System.EventHandler(this.cmbAlgoritmo_SelectedIndexChanged);
            // 
            // btnAdicionarFila
            // 
            this.btnAdicionarFila.Location = new System.Drawing.Point(19, 114);
            this.btnAdicionarFila.Name = "btnAdicionarFila";
            this.btnAdicionarFila.Size = new System.Drawing.Size(78, 28);
            this.btnAdicionarFila.TabIndex = 55;
            this.btnAdicionarFila.Text = "Escolher";
            this.btnAdicionarFila.UseVisualStyleBackColor = true;
            this.btnAdicionarFila.Click += new System.EventHandler(this.btnAdicionarFila_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(18, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 56;
            this.label10.Text = "Fila:";
            // 
            // cmbFila
            // 
            this.cmbFila.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFila.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFila.FormattingEnabled = true;
            this.cmbFila.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbFila.Location = new System.Drawing.Point(144, 89);
            this.cmbFila.Name = "cmbFila";
            this.cmbFila.Size = new System.Drawing.Size(124, 23);
            this.cmbFila.TabIndex = 57;
            // 
            // btnLimparFilas
            // 
            this.btnLimparFilas.Location = new System.Drawing.Point(18, 415);
            this.btnLimparFilas.Name = "btnLimparFilas";
            this.btnLimparFilas.Size = new System.Drawing.Size(106, 29);
            this.btnLimparFilas.TabIndex = 58;
            this.btnLimparFilas.Text = "Limpar Filas";
            this.btnLimparFilas.UseVisualStyleBackColor = true;
            this.btnLimparFilas.Click += new System.EventHandler(this.btnLimparFilas_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(181, 415);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(80, 29);
            this.btnExcluir.TabIndex = 59;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 415);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 29);
            this.button1.TabIndex = 60;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gpbProcesso
            // 
            this.gpbProcesso.BackColor = System.Drawing.Color.Transparent;
            this.gpbProcesso.Controls.Add(this.lsvListaProcessos);
            this.gpbProcesso.Controls.Add(this.nudTempo);
            this.gpbProcesso.Controls.Add(this.btnExcluir);
            this.gpbProcesso.Controls.Add(this.label2);
            this.gpbProcesso.Controls.Add(this.label4);
            this.gpbProcesso.Controls.Add(this.btnAdicionar);
            this.gpbProcesso.Controls.Add(this.btnLimparLista);
            this.gpbProcesso.Controls.Add(this.cmbPrioridade);
            this.gpbProcesso.Controls.Add(this.label6);
            this.gpbProcesso.Location = new System.Drawing.Point(21, 53);
            this.gpbProcesso.Name = "gpbProcesso";
            this.gpbProcesso.Size = new System.Drawing.Size(278, 451);
            this.gpbProcesso.TabIndex = 61;
            this.gpbProcesso.TabStop = false;
            this.gpbProcesso.Text = "Processo";
            // 
            // gpbFilaPrioridade
            // 
            this.gpbFilaPrioridade.BackColor = System.Drawing.Color.Transparent;
            this.gpbFilaPrioridade.Controls.Add(this.lsvFilas);
            this.gpbFilaPrioridade.Controls.Add(this.nudQuantum);
            this.gpbFilaPrioridade.Controls.Add(this.button1);
            this.gpbFilaPrioridade.Controls.Add(this.label3);
            this.gpbFilaPrioridade.Controls.Add(this.btnLimparFilas);
            this.gpbFilaPrioridade.Controls.Add(this.label7);
            this.gpbFilaPrioridade.Controls.Add(this.cmbFila);
            this.gpbFilaPrioridade.Controls.Add(this.cmbAlgoritmo);
            this.gpbFilaPrioridade.Controls.Add(this.label10);
            this.gpbFilaPrioridade.Controls.Add(this.label8);
            this.gpbFilaPrioridade.Controls.Add(this.btnAdicionarFila);
            this.gpbFilaPrioridade.Location = new System.Drawing.Point(305, 53);
            this.gpbFilaPrioridade.Name = "gpbFilaPrioridade";
            this.gpbFilaPrioridade.Size = new System.Drawing.Size(283, 451);
            this.gpbFilaPrioridade.TabIndex = 62;
            this.gpbFilaPrioridade.TabStop = false;
            this.gpbFilaPrioridade.Text = "Fila Prioridade";
            // 
            // gpbSimulacao
            // 
            this.gpbSimulacao.BackColor = System.Drawing.Color.Transparent;
            this.gpbSimulacao.Controls.Add(this.txbSimulacao);
            this.gpbSimulacao.Controls.Add(this.btnSimular);
            this.gpbSimulacao.Controls.Add(this.btnLimparSimulacao);
            this.gpbSimulacao.Location = new System.Drawing.Point(594, 53);
            this.gpbSimulacao.Name = "gpbSimulacao";
            this.gpbSimulacao.Size = new System.Drawing.Size(374, 451);
            this.gpbSimulacao.TabIndex = 61;
            this.gpbSimulacao.TabStop = false;
            this.gpbSimulacao.Text = "Simulação";
            // 
            // pcbVoltar
            // 
            this.pcbVoltar.BackColor = System.Drawing.Color.Transparent;
            this.pcbVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pcbVoltar.Image")));
            this.pcbVoltar.Location = new System.Drawing.Point(21, 8);
            this.pcbVoltar.Name = "pcbVoltar";
            this.pcbVoltar.Size = new System.Drawing.Size(38, 35);
            this.pcbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbVoltar.TabIndex = 63;
            this.pcbVoltar.TabStop = false;
            this.pcbVoltar.Click += new System.EventHandler(this.pcbVoltar_Click);
            // 
            // pcbAjuda
            // 
            this.pcbAjuda.BackColor = System.Drawing.Color.Transparent;
            this.pcbAjuda.Cursor = System.Windows.Forms.Cursors.Help;
            this.pcbAjuda.Image = ((System.Drawing.Image)(resources.GetObject("pcbAjuda.Image")));
            this.pcbAjuda.Location = new System.Drawing.Point(923, 8);
            this.pcbAjuda.Name = "pcbAjuda";
            this.pcbAjuda.Size = new System.Drawing.Size(38, 35);
            this.pcbAjuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAjuda.TabIndex = 64;
            this.pcbAjuda.TabStop = false;
            this.pcbAjuda.Click += new System.EventHandler(this.pcbAjuda_Click);
            // 
            // MultiplasFilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 516);
            this.Controls.Add(this.pcbAjuda);
            this.Controls.Add(this.pcbVoltar);
            this.Controls.Add(this.gpbSimulacao);
            this.Controls.Add(this.gpbFilaPrioridade);
            this.Controls.Add(this.gpbProcesso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MultiplasFilas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiplasFilas";
            this.Load += new System.EventHandler(this.MultiplasFilas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempo)).EndInit();
            this.gpbProcesso.ResumeLayout(false);
            this.gpbProcesso.PerformLayout();
            this.gpbFilaPrioridade.ResumeLayout(false);
            this.gpbFilaPrioridade.PerformLayout();
            this.gpbSimulacao.ResumeLayout(false);
            this.gpbSimulacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAjuda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPrioridade;
        private System.Windows.Forms.Button btnLimparSimulacao;
        private System.Windows.Forms.Button btnLimparLista;
        private System.Windows.Forms.TextBox txbSimulacao;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lsvListaProcessos;
        private System.Windows.Forms.ColumnHeader colunaProcesso;
        private System.Windows.Forms.ColumnHeader colunaTempo;
        private System.Windows.Forms.ColumnHeader colunaListaPrioridade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudQuantum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvFilas;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbAlgoritmo;
        private System.Windows.Forms.Button btnAdicionarFila;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbFila;
        private System.Windows.Forms.Button btnLimparFilas;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gpbProcesso;
        private System.Windows.Forms.GroupBox gpbFilaPrioridade;
        private System.Windows.Forms.GroupBox gpbSimulacao;
        private System.Windows.Forms.PictureBox pcbVoltar;
        private System.Windows.Forms.PictureBox pcbAjuda;
    }
}