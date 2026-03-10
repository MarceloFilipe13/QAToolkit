namespace QAToolkit.Forms
{
    partial class FormAdicionarProcesso
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            txtNome = new TextBox();
            txtCaminho = new TextBox();
            txtNomeProcesso = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnProcurar = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome da Aplicação:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(20, 40);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(400, 27);
            txtNome.TabIndex = 1;
            // 
            // txtCaminho
            // 
            txtCaminho.Location = new Point(20, 100);
            txtCaminho.Name = "txtCaminho";
            txtCaminho.Size = new Size(320, 27);
            txtCaminho.TabIndex = 2;
            // 
            // txtNomeProcesso
            // 
            txtNomeProcesso.Location = new Point(20, 160);
            txtNomeProcesso.Name = "txtNomeProcesso";
            txtNomeProcesso.Size = new Size(400, 27);
            txtNomeProcesso.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 80);
            label2.Name = "label2";
            label2.Size = new Size(167, 20);
            label2.TabIndex = 4;
            label2.Text = "Caminho do Executável:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 140);
            label3.Name = "label3";
            label3.Size = new Size(241, 20);
            label3.TabIndex = 5;
            label3.Text = "Nome do Processo (Task Manager):";
            // 
            // btnProcurar
            // 
            btnProcurar.Location = new Point(350, 99);
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new Size(70, 27);
            btnProcurar.TabIndex = 6;
            btnProcurar.Text = "...";
            btnProcurar.UseVisualStyleBackColor = true;
            btnProcurar.Click += btnProcurar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(0, 153, 0);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(220, 205);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 35);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "✔ Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = SystemColors.ControlText;
            btnCancelar.Location = new Point(330, 205);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 35);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "X Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormAdicionarProcesso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 233);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(btnProcurar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNomeProcesso);
            Controls.Add(txtCaminho);
            Controls.Add(txtNome);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAdicionarProcesso";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Adicionar Aplicação";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtCaminho;
        private TextBox txtNomeProcesso;
        private Label label2;
        private Label label3;
        private Button btnProcurar;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}