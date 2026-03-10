namespace QAToolkit
{
    public partial class FormPrincipal : Form
    {
        // Guarda qual UserControl está sendo exibido no momento
        private UserControl _controleAtual;

        public FormPrincipal()
        {
            InitializeComponent();
            // Ao abrir o app, carrega a tela de Processos por padrão
            CarregarModulo(new Forms.UcProcessos());
        }

        // Método responsável por trocar o conteúdo do painel direito
        private void CarregarModulo(UserControl modulo)
        {
            // Remove o controle anterior, se existir
            if (_controleAtual != null)
            {
                panelConteudo.Controls.Remove(_controleAtual);
                _controleAtual.Dispose();
            }

            // Configura e adiciona o novo controle
            _controleAtual = modulo;
            _controleAtual.Dock = DockStyle.Fill;
            panelConteudo.Controls.Add(_controleAtual);
        }

        // Eventos dos botões do menu
        private void btnProcessos_Click(object sender, EventArgs e)
        {
            CarregarModulo(new Forms.UcProcessos());
        }

        private void btnBat_Click(object sender, EventArgs e)
        {
            CarregarModulo(new Forms.UcBat());
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarModulo(new Forms.UcAtualizar());
        }

        private void btnCasosTeste_Click(object sender, EventArgs e)
        {
            CarregarModulo(new Forms.UcCasosTeste());
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            CarregarModulo(new Forms.UcLogs());
        }

    }
}