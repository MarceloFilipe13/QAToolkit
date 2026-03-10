using QAToolkit.Models;
using QAToolkit.Services;
using System.Linq;

namespace QAToolkit.Forms
{
    public partial class UcProcessos : UserControl
    {
        private GerenciadorProcessos _gerenciador = new GerenciadorProcessos();
        private ConfiguracaoService _configuracao = new ConfiguracaoService();
        private List<ProcessoItem> _processos = new List<ProcessoItem>();

        // Guarda o nome do processo selecionado para persistir após atualização
        private string _nomeSelecionado = string.Empty;

        public UcProcessos()
        {
            InitializeComponent();
            ConfigurarColunas();
            CarregarProcessos();
            AtualizarStatus();
        }

        private void ConfigurarColunas()
        {
            listViewProcessos.Columns.Add("Aplicação", 200);
            listViewProcessos.Columns.Add("Caminho", 280);
            listViewProcessos.Columns.Add("Status", 100);
        }

        private void CarregarProcessos()
        {
            _processos = _configuracao.CarregarProcessos();
            AtualizarListView();
        }

        private void AtualizarListView()
        {
            listViewProcessos.Items.Clear();

            foreach (ProcessoItem processo in _processos.OrderBy(p => p.Nome))
            {
                bool rodando = _gerenciador.ProcessoEstaRodando(processo.NomeProcesso);
                string status = rodando ? "● Rodando" : "○ Parado";

                ListViewItem item = new ListViewItem(processo.Nome);
                item.SubItems.Add(processo.CaminhoExe);
                item.SubItems.Add(status);
                item.ForeColor = rodando ? Color.Green : Color.Red;
                item.Tag = processo;

                listViewProcessos.Items.Add(item);

                // Restaura a seleção anterior
                if (processo.Nome == _nomeSelecionado)
                {
                    item.Selected = true;
                    item.Focused = true;
                }
            }
        }

        private void AtualizarStatus()
        {
            AtualizarListView();
        }

        private void Log(string mensagem)
        {
            string linha = $"[{DateTime.Now:HH:mm:ss}] {mensagem}";
            richTextBoxLog.AppendText(linha + Environment.NewLine);
            richTextBoxLog.ScrollToCaret();
        }

        private ProcessoItem? ObterProcessoSelecionado()
        {
            if (listViewProcessos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um processo na lista.");
                return null;
            }

            return listViewProcessos.SelectedItems[0].Tag as ProcessoItem;
        }

        // Salva o nome do processo quando o usuário seleciona na lista
        private void listViewProcessos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProcessos.SelectedItems.Count > 0)
            {
                var processo = listViewProcessos.SelectedItems[0].Tag as ProcessoItem;
                if (processo != null)
                    _nomeSelecionado = processo.Nome;
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            ProcessoItem? processo = ObterProcessoSelecionado();
            if (processo == null) return;

            Log($"Abrindo {processo.Nome}...");
            bool sucesso = _gerenciador.AbrirProcesso(processo.CaminhoExe);

            if (sucesso)
            {
                Log($"{processo.Nome} aberto com sucesso.");
                AtualizarStatus();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            ProcessoItem? processo = ObterProcessoSelecionado();
            if (processo == null) return;

            Log($"Fechando {processo.Nome}...");
            bool sucesso = _gerenciador.FecharProcesso(processo.NomeProcesso);

            if (sucesso)
            {
                Log($"{processo.Nome} fechado com sucesso.");
                AtualizarStatus();
            }
        }

        private void btnAtualizarStatus_Click(object sender, EventArgs e)
        {
            AtualizarStatus();
            Log("Status atualizado.");
        }

        private void btnAdicionarApp_Click(object sender, EventArgs e)
        {
            FormAdicionarProcesso form = new FormAdicionarProcesso();

            // Abre o popup e aguarda o resultado
            if (form.ShowDialog() == DialogResult.OK && form.ProcessoCriado != null)
            {
                _processos.Add(form.ProcessoCriado);
                _configuracao.SalvarProcessos(_processos);
                AtualizarListView();
                Log($"App '{form.ProcessoCriado.Nome}' adicionado.");
            }
        }

        private void btnRemoverApp_Click(object sender, EventArgs e)
        {
            ProcessoItem? processo = ObterProcessoSelecionado();
            if (processo == null) return;

            var confirmacao = MessageBox.Show(
                $"Remover '{processo.Nome}' da lista?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                _processos.Remove(processo);
                _configuracao.SalvarProcessos(_processos);
                _nomeSelecionado = string.Empty;
                AtualizarListView();
                Log($"App '{processo.Nome}' removido.");
            }
        }
    }
}