namespace QAToolkit
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnLogs = new Button();
            btnCasosTeste = new Button();
            btnAtualizar = new Button();
            btnBat = new Button();
            btnProcessos = new Button();
            lblTitulo = new Label();
            panelConteudo = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(64, 64, 64);
            panelMenu.Controls.Add(btnLogs);
            panelMenu.Controls.Add(btnCasosTeste);
            panelMenu.Controls.Add(btnAtualizar);
            panelMenu.Controls.Add(btnBat);
            panelMenu.Controls.Add(btnProcessos);
            panelMenu.Controls.Add(lblTitulo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 603);
            panelMenu.TabIndex = 0;
            // 
            // btnLogs
            // 
            btnLogs.Cursor = Cursors.Hand;
            btnLogs.FlatAppearance.BorderSize = 0;
            btnLogs.FlatStyle = FlatStyle.Flat;
            btnLogs.Font = new Font("Segoe UI", 10F);
            btnLogs.ForeColor = Color.White;
            btnLogs.Location = new Point(10, 280);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(180, 45);
            btnLogs.TabIndex = 4;
            btnLogs.Text = "📊 Logs";
            btnLogs.TextAlign = ContentAlignment.MiddleLeft;
            btnLogs.UseVisualStyleBackColor = true;
            btnLogs.Click += btnLogs_Click;
            // 
            // btnCasosTeste
            // 
            btnCasosTeste.Cursor = Cursors.Hand;
            btnCasosTeste.FlatAppearance.BorderSize = 0;
            btnCasosTeste.FlatStyle = FlatStyle.Flat;
            btnCasosTeste.Font = new Font("Segoe UI", 10F);
            btnCasosTeste.ForeColor = Color.White;
            btnCasosTeste.Location = new Point(10, 230);
            btnCasosTeste.Name = "btnCasosTeste";
            btnCasosTeste.Size = new Size(180, 45);
            btnCasosTeste.TabIndex = 3;
            btnCasosTeste.Text = "📋 Casos de Teste";
            btnCasosTeste.TextAlign = ContentAlignment.MiddleLeft;
            btnCasosTeste.UseVisualStyleBackColor = true;
            btnCasosTeste.Click += btnCasosTeste_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Cursor = Cursors.Hand;
            btnAtualizar.FlatAppearance.BorderSize = 0;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Segoe UI", 10F);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(10, 180);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(180, 45);
            btnAtualizar.TabIndex = 2;
            btnAtualizar.Text = "🔄 Atualizar";
            btnAtualizar.TextAlign = ContentAlignment.MiddleLeft;
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnBat
            // 
            btnBat.Cursor = Cursors.Hand;
            btnBat.FlatAppearance.BorderSize = 0;
            btnBat.FlatStyle = FlatStyle.Flat;
            btnBat.Font = new Font("Segoe UI", 10F);
            btnBat.ForeColor = Color.White;
            btnBat.Location = new Point(10, 130);
            btnBat.Name = "btnBat";
            btnBat.Size = new Size(180, 45);
            btnBat.TabIndex = 1;
            btnBat.Text = "▶ BAT Files";
            btnBat.TextAlign = ContentAlignment.MiddleLeft;
            btnBat.UseVisualStyleBackColor = true;
            btnBat.Click += btnBat_Click;
            // 
            // btnProcessos
            // 
            btnProcessos.Cursor = Cursors.Hand;
            btnProcessos.FlatAppearance.BorderSize = 0;
            btnProcessos.FlatStyle = FlatStyle.Flat;
            btnProcessos.Font = new Font("Segoe UI", 10F);
            btnProcessos.ForeColor = Color.White;
            btnProcessos.Location = new Point(10, 80);
            btnProcessos.Name = "btnProcessos";
            btnProcessos.Size = new Size(180, 45);
            btnProcessos.TabIndex = 0;
            btnProcessos.Text = "⚙ Processos";
            btnProcessos.TextAlign = ContentAlignment.MiddleLeft;
            btnProcessos.UseVisualStyleBackColor = true;
            btnProcessos.Click += btnProcessos_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(121, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "QA Toolkit";
            // 
            // panelConteudo
            // 
            panelConteudo.BackColor = Color.White;
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(200, 0);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(882, 603);
            panelConteudo.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 603);
            Controls.Add(panelConteudo);
            Controls.Add(panelMenu);
            MinimumSize = new Size(1100, 650);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QA Toolkit";
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelConteudo;
        private Button btnProcessos;
        private Label lblTitulo;
        private Button btnBat;
        private Button btnAtualizar;
        private Button btnLogs;
        private Button btnCasosTeste;
    }
}
