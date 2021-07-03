using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EscalonadorDeProcessos
{
    public partial class RoundRobin : Form
    {
        public struct processo
        {
            public int s { get; set; }
            public int chegada { get; set; }
            public int tempo { get; set; }
            public int prioridade { get; set; }
        }
        processo pro, prExcluir;
        int numProcs = 0, quantum;
        List<processo> processos = new List<processo>();
        public RoundRobin()
        {
            InitializeComponent();
        }

        private void RoundRobin_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(nudTempo.Value == 0)
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

        public void RoundRobinEsc(int quantum, processo[] pro)
        {
            int tempo = 0;
            int j = 0, zeros = 0;
            while (zeros != pro.Length)
            {
                for (int i = 0; i < quantum; i++)
                {
                    if (pro[j].tempo != 0)                      
                    {
                        pro[j].s++;
                        txbSimulacao.Text += "EXECUTANDO O " + pro[j].chegada.ToString() + "º PROCESSO... " + pro[j].s.ToString() + " s" + Environment.NewLine;
                        pro[j].tempo--;
                        tempo++;
                        if (pro[j].tempo == 0)
                        {
                            txbSimulacao.Text += Environment.NewLine + "FINALIZANDO O " + pro[j].chegada.ToString() + "º PROCESSO..." + Environment.NewLine;
                            txbSimulacao.Text += "O PROCESSO DUROU " + tempo.ToString() + " s" + Environment.NewLine;
                            txbSimulacao.Text += "-------------------------------------------" + Environment.NewLine;
                            zeros++;
                        }

                    }

                }

                if(j == (pro.Length - 1))
                {
                    j = 0;
                }
                else
                {
                    j++;
                }
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
            
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
        }

        private void pcbVoltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void pcbAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digite o tempo do processo e adicione-o a lista com o botão 'Adicionar'. \n" +
                "OBS: Pode digitar quantos quiser.\n\nDepois escolha o tempo do Quantum e clique no botão Simular para ver a simulação.");

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            prExcluir.chegada = int.Parse(lsvListaProcessos.SelectedItems[0].SubItems[colunaProcesso.Index].Text);
            for (int i = 0; i < processos.Count; i++)
            {
                if (prExcluir.chegada == processos[i].chegada)
                {
                    int indx = i;
                    processos.RemoveAt(indx);
                    break;
                }
            }
            lsvListaProcessos.SelectedItems[0].Remove();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if(nudQuantum.Value == 0)
            {
                MessageBox.Show("Informe o Valor do Quantum Por Gentileza.");
            }
            else if(lsvListaProcessos.Items.Count == 0)
            {
                MessageBox.Show("Informe o Tempo dos Processos Por Gentileza.");
            }
            else
            {
                processo[] proce = new processo[numProcs];
                proce = processos.ToArray();

                quantum = int.Parse(nudQuantum.Value.ToString());
                RoundRobinEsc(quantum, proce);
            }
        }
    }
}
