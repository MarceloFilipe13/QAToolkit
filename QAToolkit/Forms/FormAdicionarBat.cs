using QAToolkit.Models;

namespace QAToolkit.Forms
{
    public partial class FormAdicionarBat : Form
    {
        // Propriedade pública que entrega o BAT criado para quem abriu o popup
        // O ? significa que pode ser nulo — caso o usuário cancele
        public BatItem? BatCriado { get; private set; }

        public FormAdicionarBat()
        {
            InitializeComponent();
        }

        // Botão "..." — abre o explorador de arquivos filtrado por .bat
        private void btnProcurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "BAT Files (*.bat)|*.bat";
            dialog.Title = "Selecione o arquivo .bat";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtCaminho.Text = dialog.FileName;

                // Se o campo Nome ainda estiver vazio,
                // preenche automaticamente com o nome do arquivo
                if (string.IsNullOrEmpty(txtNome.Text))
                    txtNome.Text = Path.GetFileNameWithoutExtension(dialog.FileName);
            }
        }

        // Botão Salvar — valida e cria o objeto BatItem
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCaminho.Text))
            {
                MessageBox.Show("Preencha todos os campos.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BatCriado = new BatItem
            {
                Nome = txtNome.Text.Trim(),
                CaminhoArquivo = txtCaminho.Text.Trim()
            };

            // Fecha o popup informando que o usuário confirmou
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Botão Cancelar — fecha sem salvar nada
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}