using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscalonadorDeProcessos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmbAlgoritmos.Text == "ROUND ROBIN")
            {
                //this.Close();
                RoundRobin formRound = new RoundRobin();
                formRound.Show();
                this.Hide();
                
            }else if(cmbAlgoritmos.Text == "PRIORIDADE")
            {
                Prioridade formPrio = new Prioridade();
                formPrio.Show();
                this.Hide();

            }else if(cmbAlgoritmos.Text == "MÚLTIPLAS FILAS")
            {
                MultiplasFilas formMul = new MultiplasFilas();
                formMul.Show();
                this.Hide();
            }
            else if(cmbAlgoritmos.Text == "JOB MAIS CURTO")
            {
                JobMaisCurto formJob = new JobMaisCurto();
                formJob.Show();
                this.Hide();

            }else if (cmbAlgoritmos.Text == "SORTEIO")
            {
                Sorteio formSor = new Sorteio();
                formSor.Show();
                this.Hide();
            }
            else if(cmbAlgoritmos.Text == "GARANTIDO")
            {
                MessageBox.Show("Em Desenvolvimento.");
            }
        }

        private void btnFecharAplicacao_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcbSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
