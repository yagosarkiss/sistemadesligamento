using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace SistemaDesligamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            // Obtém o horário selecionado
            DateTime horarioDesligamento = dtAgendar.Value;

            // Obtém a hora atual
            DateTime agora = DateTime.Now;

            // Calcula o tempo restante até o horário especificado
            TimeSpan tempoRestante = horarioDesligamento - agora;

            // Converte o tempo restante para segundos
            int tempoRestanteSegundos = (int)tempoRestante.TotalSeconds;

            // Agenda o desligamento
            Process.Start(new ProcessStartInfo("Shutdown", $"/s /t {tempoRestanteSegundos}")
            {
                CreateNoWindow = true,
                UseShellExecute = false,
            });

        }
    }
}