using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EscalonadorDeProcessos
{
    public partial class Sorteio : Form
    {
        public struct processo
        {
            public int s { get; set; }
            public int chegada { get; set; }
            public int tempo { get; set; }
            public int prioridade { get; set; }
        }
        processo pro;
        int numProcs = 0, quantum;
        List<processo> processos = new List<processo>();
        public void SorteioEsc(processo[] pro)
        {
            int tempo = 0, zeros = 0;

            while (zeros != pro.Length)
            {
                int sort;
                Random randNum = new Random();

                sort = (randNum.Next(numProcs));

                int temp = pro[sort].tempo;

                for (int i = 0; i < temp; i++)
                {
                    if (pro[sort].tempo != 0)
                    {
                        pro[sort].s++;
                        txbSimulacao.Text += "EXECUTANDO O " + pro[sort].chegada.ToString() + "º PROCESSO... " + pro[sort].s.ToString() + " s" + Environment.NewLine;
                        pro[sort].tempo--;
                        tempo++;
                        if (pro[sort].tempo == 0)
                        {
                            txbSimulacao.Text += Environment.NewLine + "FINALIZANDO O " + pro[sort].chegada.ToString() + "º PROCESSO..." + Environment.NewLine;
                            txbSimulacao.Text += "O PROCESSO DUROU " + tempo.ToString() + " s" + Environment.NewLine;
                            txbSimulacao.Text += "-------------------------------------------" + Environment.NewLine;
                            zeros++;
                        }
                    }
                }
            }
        }
        public Sorteio()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (lsvListaProcessos.Items.Count == 0)
            {
                MessageBox.Show("Informe o Tempo dos Processos Por Gentileza.");
            }
            else
            {
                processo[] proce = processos.ToArray();
                SorteioEsc(proce);
            }
        }

        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            processos.Clear();
            numProcs = 0;
            lsvListaProcessos.Items.Clear();
        }

        private void btnLimparSimulacao_Click(object sender, EventArgs e)
        {
            txbSimulacao.Text = "";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu menuVoltar = new Menu();
            menuVoltar.Show();
            this.Close();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digite o tempo do processo e adicione-o a lista com o botão 'Adicionar'. \n" +
                "OBS: Pode digitar quantos quiser.\n\nDepois clique no botão Simular para ver a simulação.");

        }

        private void Sorteio_Load(object sender, EventArgs e)
        {
            nudQuantum.Enabled = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (nudTempo.Value == 0)
            {
                MessageBox.Show("Escolha o Tempo do Processo por gentileza.");
            }
            else
            {
                numProcs++;

                pro.chegada = numProcs;
                pro.prioridade = 0;
                pro.tempo = int.Parse(nudTempo.Value.ToString());
                pro.s = 0;
                processos.Add(pro);

                ListViewItem item = new ListViewItem(numProcs.ToString());
                item.SubItems.Add(pro.tempo.ToString());

                lsvListaProcessos.Items.Add(item);

                nudTempo.Value = 0;
            }
        }
    }
}
