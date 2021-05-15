using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EscalonadorDeProcessos
{
    public partial class MultiplasFilas : Form
    {
        public struct processo
        {
            public int s { get; set; }
            public int chegada { get; set; }
            public int tempo { get; set; }
            public int prioridade { get; set; }
        }
        processo pro;
        int numProcs = 0, numFila = 0;
        List<processo> l1 = new List<processo>();
        List<processo> l2 = new List<processo>();
        List<processo> l3 = new List<processo>();
        String[] algoritmos = new String[3];
        int[] quantum = new int[3];

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

                if (j == (pro.Length - 1))
                {
                    j = 0;
                }
                else
                {
                    j++;
                }

            }
        }

        public void SorteioEsc(processo[] pro)
        {
            int tempo = 0, zeros = 0;

            while (zeros != pro.Length)
            {
                int sort;
                Random randNum = new Random();

                sort = (randNum.Next(numProcs));
                while (sort >= pro.Length)
                {
                    sort = (randNum.Next(numProcs));
                }
                

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
        public void MultiplasFilasEsc(processo[] p1, processo[] p2, processo[] p3, int[] quantum, String[] algoritmos)
        {
            RoundRobin round = new RoundRobin();
            if ((p3.Length) != 0)
            {
                if (algoritmos[2] == "ROUND ROBIN")
                {
                    txbSimulacao.Text += "------------- ALTA PRIORIDADE ----------" + Environment.NewLine;
                    RoundRobinEsc(quantum[2], p3);
                }
                else if (algoritmos[2] == "JOB MAIS CURTO")
                {
                    txbSimulacao.Text += "------------- ALTA PRIORIDADE ----------" + Environment.NewLine;
                    JobMaisCurtoEsc(p3);
                }
                else
                {
                    txbSimulacao.Text += "------------- ALTA PRIORIDADE ----------" + Environment.NewLine;
                    SorteioEsc(p3);
                }
            }

            if (p2.Length != 0)
            {
                if (algoritmos[1] == "ROUND ROBIN")
                {
                    txbSimulacao.Text += "------------- MÉDIA PRIORIDADE ----------" + Environment.NewLine;
                    RoundRobinEsc(quantum[1], p2);
                }
                else if (algoritmos[1] == "JOB MAIS CURTO")
                {
                    txbSimulacao.Text += "------------- MÉDIA PRIORIDADE ----------" + Environment.NewLine;
                    JobMaisCurtoEsc(p2);
                }
                else
                {
                    txbSimulacao.Text += "------------- MÉDIA PRIORIDADE ----------" + Environment.NewLine;
                    SorteioEsc(p2);
                }
            }

            if (p1.Length != 0)
            {
                if (algoritmos[0] == "ROUND ROBIN")
                {
                    txbSimulacao.Text += "------------- BAIXA PRIORIDADE ----------" + Environment.NewLine;
                    RoundRobinEsc(quantum[0], p1);
                }
                else if (algoritmos[0] == "JOB MAIS CURTO")
                {
                    txbSimulacao.Text += "------------- BAIXA PRIORIDADE ----------" + Environment.NewLine;
                    JobMaisCurtoEsc(p1);
                }
                else
                {
                    txbSimulacao.Text += "------------- BAIXA PRIORIDADE ----------" + Environment.NewLine;
                    SorteioEsc(p1);
                }
            }

        }
        public MultiplasFilas()
        {
            InitializeComponent();
        }

        private void MultiplasFilas_Load(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if(lsvListaProcessos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Adicione Processos a Lista e Escolha os Algoritmos de Cada Fila para a Simulação por gentileza.");
            }else if(lsvFilas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Escolha os Algoritmos de Cada Fila para a Simulação por gentileza.");
            }
            else
            {
                processo[] o1 = l1.ToArray();
                processo[] o2 = l2.ToArray();
                processo[] o3 = l3.ToArray();
                MultiplasFilasEsc(o1, o2, o3, quantum, algoritmos);
            }
        }

        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            l1.Clear();
            l2.Clear();
            l2.Clear();
            numProcs = 0;
            lsvListaProcessos.Items.Clear();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (cmbPrioridade.SelectedItem == null)
            {
                MessageBox.Show("Escolha a Fila de Prioridade do Processo por gentileza.");
            }else if(nudTempo.Value == 0)
            {
                MessageBox.Show("Escolha o Tempo do Processo por gentileza.");
            }
            else
            {
                numProcs++;

                pro.chegada = numProcs;
                pro.prioridade = int.Parse(cmbPrioridade.SelectedItem.ToString());
                pro.tempo = int.Parse(nudTempo.Value.ToString());
                pro.s = 0;
                if(int.Parse(cmbPrioridade.SelectedItem.ToString()) == 1)
                {
                    l1.Add(pro);
                }else if (int.Parse(cmbPrioridade.SelectedItem.ToString()) == 2)
                {
                    l2.Add(pro);
                }
                else
                {
                    l3.Add(pro);
                }
                

                ListViewItem item = new ListViewItem(numProcs.ToString());
                item.SubItems.Add(pro.tempo.ToString());
                item.SubItems.Add(pro.prioridade.ToString());
                lsvListaProcessos.Items.Add(item);

                nudTempo.Value = 0;
            }
        }

        private void btnAdicionarFila_Click(object sender, EventArgs e)
        {
            if (cmbAlgoritmo.SelectedItem == null)
            {
                MessageBox.Show("Escolha o Algoritmo da Fila por gentileza.");
            }
            else if((cmbAlgoritmo.SelectedItem.ToString() == "ROUND ROBIN") &&  (nudQuantum.Value == 0))
            {
                MessageBox.Show("Escolha a Quantidade do Quantum da Fila por gentileza.");
            }
            else if(cmbFila.SelectedItem == null)
            {
                MessageBox.Show("Escolha a Fila do Algoritmo por gentileza.");
            }
            else
            {
                numFila++;

                if(cmbAlgoritmo.SelectedItem.ToString() == "ROUND ROBIN")
                {
                    algoritmos[int.Parse(cmbFila.SelectedItem.ToString()) - 1] = "ROUND ROBIN";
                    quantum[int.Parse(cmbFila.SelectedItem.ToString()) - 1] = int.Parse(nudQuantum.Value.ToString());
                }
                else if(cmbAlgoritmo.SelectedItem.ToString() == "JOB MAIS CURTO")
                {
                    algoritmos[int.Parse(cmbFila.SelectedItem.ToString()) - 1] = "JOB MAIS CURTO";
                    quantum[int.Parse(cmbFila.SelectedItem.ToString()) - 1] = 0;
                }
                else
                {
                    algoritmos[int.Parse(cmbFila.SelectedItem.ToString()) - 1] = "SORTEIO";
                    quantum[int.Parse(cmbFila.SelectedItem.ToString()) - 1] = 0;
                }

                ListViewItem item = new ListViewItem(cmbFila.SelectedItem.ToString());
                item.SubItems.Add(quantum[int.Parse(cmbFila.SelectedItem.ToString()) - 1].ToString());
                item.SubItems.Add(algoritmos[int.Parse(cmbFila.SelectedItem.ToString()) - 1]);
                lsvFilas.Items.Add(item);

                nudTempo.Value = 0;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu voltarMenu = new Menu();
            voltarMenu.Show();
            this.Close();
        }

        private void btnLimparFilas_Click(object sender, EventArgs e)
        {
            lsvFilas.Items.Clear();
        }

        private void cmbAlgoritmo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAlgoritmo.SelectedItem.ToString() == "JOB MAIS CURTO")
            {
                nudQuantum.Enabled = false;
            }
            else if (cmbAlgoritmo.SelectedItem.ToString() == "SORTEIO")
            {
                nudQuantum.Enabled = false;
            }
            else
            {
                nudQuantum.Enabled = true;
            }
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digite o tempo do processo e lista de prioridade e adicione-o a lista com o botão 'Adicionar'. \n" +
                "OBS: Pode digitar quantos quiser.\n\nDepois escolha o algoritmo de cada fila e clique no botão 'Simular' para ver a simulação.");

        }

        private void btnLimparSimulacao_Click(object sender, EventArgs e)
        {
            txbSimulacao.Text = "";
        }
    }
}
