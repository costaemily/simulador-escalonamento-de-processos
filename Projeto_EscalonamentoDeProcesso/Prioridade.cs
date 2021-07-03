using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EscalonadorDeProcessos
{
    public partial class Prioridade : Form
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

        public int encontrarMaiorPrioridade(processo[] procss)
        {
            int maior, ind = 0;
            maior = procss[0].prioridade;
            for (int i = 0; i < procss.Length; i++)
            {
                if (procss[i].prioridade > maior)
                {
                    maior = procss[i].prioridade;
                    ind = i;
                }
            }
            return ind;
        }
        public void PrioridadeEsc(int quantum, processo[] pro)
        {
            int tempo = 0, zeros = 0;

            while (zeros != pro.Length)
            {
                int indPrio = encontrarMaiorPrioridade(pro);

                for (int i = 0; i < quantum; i++)
                {
                    if (pro[indPrio].tempo != 0)
                    {
                        tempo++;
                        pro[indPrio].s++;
                        txbSimulacao.Text += "EXECUTANDO O " + pro[indPrio].chegada.ToString() + "º PROCESSO... " + pro[indPrio].s.ToString() + " s" + Environment.NewLine;
                        pro[indPrio].tempo--;
                        if (pro[indPrio].tempo == 0)
                        {
                            pro[indPrio].prioridade = 0;
                            txbSimulacao.Text += Environment.NewLine + "FINALIZANDO O " + pro[indPrio].chegada.ToString() + "º PROCESSO..." + Environment.NewLine;
                            txbSimulacao.Text += "O PROCESSO DUROU " + tempo.ToString() + " s" + Environment.NewLine;
                            txbSimulacao.Text += "-------------------------------------------" + Environment.NewLine;
                            zeros++;
                        }
                    }
                }
                pro[indPrio].prioridade--;
            }
        }
        public Prioridade()
        {
            InitializeComponent();
        }

        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            processos.Clear();
            numProcs = 0;
            lsvListaProcessos.Items.Clear();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (nudQuantum.Value == 0)
            {
                MessageBox.Show("Informe o Valor do Quantum Por Gentileza.");
            }
            else
            {
                processo[] proce = new processo[numProcs];
                proce = processos.ToArray();

                quantum = int.Parse(nudQuantum.Value.ToString());
                PrioridadeEsc(quantum, proce);
            }
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
            Menu voltar = new Menu();
            voltar.Show();
            this.Close();
        }

        private void pcbAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digite o tempo do processo e sua prioridade e adicione-o a lista com o botão 'Adicionar'. \n" +
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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            
            if(cmbPrioridade.SelectedItem == null)
            {
                MessageBox.Show("Escolha a Prioridade do Processo por gentileza.");
            }
            else
            {
                numProcs++;

                pro.chegada = numProcs;
                pro.prioridade = int.Parse(cmbPrioridade.SelectedItem.ToString());
                pro.tempo = int.Parse(nudTempo.Value.ToString());
                pro.s = 0;
                processos.Add(pro);

                ListViewItem item = new ListViewItem(numProcs.ToString());
                item.SubItems.Add(pro.tempo.ToString());
                item.SubItems.Add(pro.prioridade.ToString());
                lsvListaProcessos.Items.Add(item);

                nudTempo.Value = 0;
            }
        }
    }
}
