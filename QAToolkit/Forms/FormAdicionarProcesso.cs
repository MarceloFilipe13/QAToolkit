using QAToolkit.Models;

namespace QAToolkit.Forms
{
    public partial class FormAdicionarProcesso : Form
    {
        // Propriedade pública que retorna o processo criado
        public ProcessoItem? ProcessoCriado { get; private set; }

        public FormAdicionarProcesso()
        {
            InitializeComponent();
        }

        // Botão "..." — abre o explorador de arquivos
        private void btnProcurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Executáveis (*.exe)|*.exe";
            dialog.Title = "Selecione o executável";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtCaminho.Text = dialog.FileName;

                // Preenche o nome do processo automaticamente
                // (nome do arquivo sem extensão)
                if (string.IsNullOrEmpty(txtNomeProcesso.Text))
                {
                    txtNomeProcesso.Text = Path.GetFileNameWithoutExtension(dialog.FileName);
                }
            }
        }

        // Botão Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Validação básica
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCaminho.Text) ||
                string.IsNullOrWhiteSpace(txtNomeProcesso.Text))
            {
                MessageBox.Show("Preencha todos os campos.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cria o objeto com os dados preenchidos
            ProcessoCriado = new ProcessoItem
            {
                Nome = txtNome.Text.Trim(),
                CaminhoExe = txtCaminho.Text.Trim(),
                NomeProcesso = txtNomeProcesso.Text.Trim()
            };

            // Fecha o popup com resultado OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Botão Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}