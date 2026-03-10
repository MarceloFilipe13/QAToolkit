namespace QAToolkit.Forms
{
    partial class UcProcessos
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            listViewProcessos = new ListView();
            btnAbrir = new Button();
            btnFechar = new Button();
            btnAtualizarStatus = new Button();
            richTextBoxLog = new RichTextBox();
            btnAdicionarApp = new Button();
            btnRemoverApp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(20, 10);
            label1.Name = "label1";
            label1.Size = new Size(346, 37);
            label1.TabIndex = 0;
            label1.Text = "Gerenciador de Processos";
            // 
            // listViewProcessos
            // 
            listViewProcessos.FullRowSelect = true;
            listViewProcessos.GridLines = true;
            listViewProcessos.Location = new Point(20, 100);
            listViewProcessos.Name = "listViewProcessos";
            listViewProcessos.Size = new Size(600, 200);
            listViewProcessos.TabIndex = 1;
            listViewProcessos.UseCompatibleStateImageBehavior = false;
            listViewProcessos.View = View.Details;
            listViewProcessos.SelectedIndexChanged += listViewProcessos_SelectedIndexChanged;
            // 
            // btnAbrir
            // 
            btnAbrir.BackColor = Color.FromArgb(0, 122, 204);
            btnAbrir.FlatAppearance.BorderSize = 0;
            btnAbrir.FlatStyle = FlatStyle.Flat;
            btnAbrir.ForeColor = Color.White;
            btnAbrir.Location = new Point(20, 315);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(160, 35);
            btnAbrir.TabIndex = 2;
            btnAbrir.Text = "▶ Abrir como Admin";
            btnAbrir.UseVisualStyleBackColor = false;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.FromArgb(204, 0, 0);
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(190, 315);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(120, 35);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "■ Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnAtualizarStatus
            // 
            btnAtualizarStatus.Location = new Point(320, 315);
            btnAtualizarStatus.Name = "btnAtualizarStatus";
            btnAtualizarStatus.Size = new Size(150, 35);
            btnAtualizarStatus.TabIndex = 4;
            btnAtualizarStatus.Text = "↻ Atualizar Status";
            btnAtualizarStatus.UseVisualStyleBackColor = true;
            btnAtualizarStatus.Click += btnAtualizarStatus_Click;
            // 
            // richTextBoxLog
            // 
            richTextBoxLog.BackColor = Color.FromArgb(30, 30, 30);
            richTextBoxLog.ForeColor = Color.Lime;
            richTextBoxLog.Location = new Point(20, 365);
            richTextBoxLog.Name = "richTextBoxLog";
            richTextBoxLog.ReadOnly = true;
            richTextBoxLog.Size = new Size(600, 120);
            richTextBoxLog.TabIndex = 5;
            richTextBoxLog.Text = "";
            // 
            // btnAdicionarApp
            // 
            btnAdicionarApp.BackColor = Color.FromArgb(0, 153, 0);
            btnAdicionarApp.FlatAppearance.BorderSize = 0;
            btnAdicionarApp.FlatStyle = FlatStyle.Flat;
            btnAdicionarApp.ForeColor = Color.White;
            btnAdicionarApp.Location = new Point(20, 60);
            btnAdicionarApp.Name = "btnAdicionarApp";
            btnAdicionarApp.Size = new Size(130, 30);
            btnAdicionarApp.TabIndex = 6;
            btnAdicionarApp.Text = "+ Adicionar App";
            btnAdicionarApp.UseVisualStyleBackColor = false;
            btnAdicionarApp.Click += btnAdicionarApp_Click;
            // 
            // btnRemoverApp
            // 
            btnRemoverApp.BackColor = Color.FromArgb(204, 0, 0);
            btnRemoverApp.FlatAppearance.BorderSize = 0;
            btnRemoverApp.FlatStyle = FlatStyle.Flat;
            btnRemoverApp.ForeColor = Color.White;
            btnRemoverApp.Location = new Point(160, 60);
            btnRemoverApp.Name = "btnRemoverApp";
            btnRemoverApp.Size = new Size(130, 30);
            btnRemoverApp.TabIndex = 7;
            btnRemoverApp.Text = "- Remover App";
            btnRemoverApp.UseVisualStyleBackColor = false;
            btnRemoverApp.Click += btnRemoverApp_Click;
            // 
            // UcProcessos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRemoverApp);
            Controls.Add(btnAdicionarApp);
            Controls.Add(richTextBoxLog);
            Controls.Add(btnAtualizarStatus);
            Controls.Add(btnFechar);
            Controls.Add(btnAbrir);
            Controls.Add(listViewProcessos);
            Controls.Add(label1);
            Name = "UcProcessos";
            Size = new Size(700, 500);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listViewProcessos;
        private Button btnAbrir;
        private Button btnFechar;
        private Button btnAtualizarStatus;
        private RichTextBox richTextBoxLog;
        private Button btnAdicionarApp;
        private Button btnRemoverApp;
    }
}
