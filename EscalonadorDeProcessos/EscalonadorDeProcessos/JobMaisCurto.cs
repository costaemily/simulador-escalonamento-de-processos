using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EscalonadorDeProcessos
{
    public partial class JobMaisCurto : Form
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

        public void JobMaisCurtoEsc(processo[] pro)
        {
            int tempo = 0, zeros = 0;

            processo menorProcesso = pro[0];
            int indice = 0;
            while (zeros != pro.Length)
            {
                for (int i = 0; i < pro.Length; i++)
                {
                    for (int j = 0; j < pro.Length; j++)
                    {
                        if (pro[j].tempo != 0)
                        {
                            menorProcesso.tempo = pro[j].tempo;
                            indice = j;
                            break;
                        }
                    }

                    for (int j = 0; j < pro.Length; j++)
                    {
                        if ((pro[j].tempo < menorProcesso.tempo) && (pro[j].tempo != 0))
                        {
                            menorProcesso.tempo = pro[j].tempo;
                            indice = j;
                        }
                    }

                    for (int j = 0; j < menorProcesso.tempo; j++)
                    {
                        tempo++;
                        pro[indice].s++;
                        txbSimulacao.Text += "EXECUTANDO O " + pro[indice].chegada.ToString() + "º PROCESSO... " + pro[indice].s.ToString() + " s" + Environment.NewLine;
                        pro[indice].tempo--;
                        if (pro[indice].tempo == 0)
                        {
                            txbSimulacao.Text += Environment.NewLine + "FINALIZANDO O " + pro[indice].chegada.ToString() + "º PROCESSO..." + Environment.NewLine;
                            txbSimulacao.Text += "O PROCESSO DUROU " + tempo.ToString() + " s" + Environment.NewLine;
                            txbSimulacao.Text += "-------------------------------------------" + Environment.NewLine;
                            zeros++;
                        }
                    }
                }
            }
        }
        public JobMaisCurto()
        {
            InitializeComponent();
        }

        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            processos.Clear();
            numProcs = 0;
            lsvListaProcessos.Items.Clear();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digite o tempo do processo e adicione-o a lista com o botão 'Adicionar'. \n" +
                "OBS: Pode digitar quantos quiser.\n\nDepois clique no botão Simular para ver a simulação.");

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
                JobMaisCurtoEsc(proce);
            }
        }

        private void JobMaisCurto_Load(object sender, EventArgs e)
        {
            nudQuantum.Enabled = false;
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
