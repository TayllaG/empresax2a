namespace EMPRESA_X2A
{
    partial class Menu
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Sair = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.Empresa = new Guna.UI2.WinForms.Guna2Button();
            this.Funcionário = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Inicio = new Guna.UI2.WinForms.Guna2ImageButton();
            this.painelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 36;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.Sair);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1162, 35);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(48)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(14, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 28);
            this.label1.TabIndex = 92;
            this.label1.Text = " Empresa X2A";
            // 
            // Sair
            // 
            this.Sair.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Sair.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Sair.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Sair.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Sair.FillColor = System.Drawing.Color.Transparent;
            this.Sair.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Sair.ForeColor = System.Drawing.Color.White;
            this.Sair.Image = ((System.Drawing.Image)(resources.GetObject("Sair.Image")));
            this.Sair.Location = new System.Drawing.Point(1096, 0);
            this.Sair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(48, 35);
            this.Sair.TabIndex = 90;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.Empresa);
            this.guna2Panel2.Controls.Add(this.Funcionário);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.Inicio);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 35);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1162, 43);
            this.guna2Panel2.TabIndex = 1;
            // 
            // Empresa
            // 
            this.Empresa.BorderRadius = 5;
            this.Empresa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Empresa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Empresa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Empresa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Empresa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(48)))), ((int)(((byte)(124)))));
            this.Empresa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Empresa.ForeColor = System.Drawing.Color.White;
            this.Empresa.Location = new System.Drawing.Point(660, 0);
            this.Empresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Empresa.Name = "Empresa";
            this.Empresa.Size = new System.Drawing.Size(243, 43);
            this.Empresa.TabIndex = 194;
            this.Empresa.Text = "Empresa";
            this.Empresa.Click += new System.EventHandler(this.Empresa_Click);
            // 
            // Funcionário
            // 
            this.Funcionário.BorderRadius = 5;
            this.Funcionário.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Funcionário.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Funcionário.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Funcionário.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Funcionário.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(48)))), ((int)(((byte)(124)))));
            this.Funcionário.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Funcionário.ForeColor = System.Drawing.Color.White;
            this.Funcionário.Location = new System.Drawing.Point(912, 0);
            this.Funcionário.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Funcionário.Name = "Funcionário";
            this.Funcionário.Size = new System.Drawing.Size(243, 43);
            this.Funcionário.TabIndex = 193;
            this.Funcionário.Text = "Funcionário";
            this.Funcionário.Click += new System.EventHandler(this.Funcionário_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(74, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 28);
            this.label2.TabIndex = 93;
            this.label2.Text = "Menu";
            // 
            // Inicio
            // 
            this.Inicio.BackColor = System.Drawing.Color.Transparent;
            this.Inicio.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Inicio.HoverState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Vertical;
            this.Inicio.HoverState.ImageSize = new System.Drawing.Size(14, 14);
            this.Inicio.Image = ((System.Drawing.Image)(resources.GetObject("Inicio.Image")));
            this.Inicio.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Vertical;
            this.Inicio.ImageOffset = new System.Drawing.Point(0, 0);
            this.Inicio.ImageRotate = 0F;
            this.Inicio.ImageSize = new System.Drawing.Size(24, 24);
            this.Inicio.IndicateFocus = true;
            this.Inicio.Location = new System.Drawing.Point(0, 0);
            this.Inicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Inicio.Name = "Inicio";
            this.Inicio.PressedState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Vertical;
            this.Inicio.PressedState.ImageSize = new System.Drawing.Size(14, 14);
            this.Inicio.Size = new System.Drawing.Size(64, 43);
            this.Inicio.TabIndex = 91;
            this.Inicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // painelMenu
            // 
            this.painelMenu.BackColor = System.Drawing.Color.Transparent;
            this.painelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.painelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelMenu.Location = new System.Drawing.Point(0, 78);
            this.painelMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.painelMenu.Name = "painelMenu";
            this.painelMenu.Size = new System.Drawing.Size(1162, 640);
            this.painelMenu.TabIndex = 2;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 718);
            this.Controls.Add(this.painelMenu);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Form1";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button Sair;
        private Guna.UI2.WinForms.Guna2Button Funcionário;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton Inicio;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button Empresa;
        private Guna.UI2.WinForms.Guna2Panel painelMenu;
    }
}

