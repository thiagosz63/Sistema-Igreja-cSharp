namespace Sistema_Igreja
{
    partial class frMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.membroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.igrejaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnAncoraForm = new System.Windows.Forms.Panel();
            this.pnButton = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIgrejas = new System.Windows.Forms.Button();
            this.btnCadastroPessoas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.cadastrarToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.membroToolStripMenuItem,
            this.igrejaToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.cadastrarToolStripMenuItem.Text = "Visualizar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(117, 6);
            // 
            // membroToolStripMenuItem
            // 
            this.membroToolStripMenuItem.Name = "membroToolStripMenuItem";
            this.membroToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.membroToolStripMenuItem.Text = "Membro";
            // 
            // igrejaToolStripMenuItem
            // 
            this.igrejaToolStripMenuItem.Name = "igrejaToolStripMenuItem";
            this.igrejaToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.igrejaToolStripMenuItem.Text = "Igreja";
            this.igrejaToolStripMenuItem.Click += new System.EventHandler(this.igrejaToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // pnAncoraForm
            // 
            this.pnAncoraForm.BackColor = System.Drawing.Color.Transparent;
            this.pnAncoraForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAncoraForm.Location = new System.Drawing.Point(0, 24);
            this.pnAncoraForm.Name = "pnAncoraForm";
            this.pnAncoraForm.Size = new System.Drawing.Size(800, 426);
            this.pnAncoraForm.TabIndex = 2;
            // 
            // pnButton
            // 
            this.pnButton.BackColor = System.Drawing.Color.Goldenrod;
            this.pnButton.Controls.Add(this.button2);
            this.pnButton.Controls.Add(this.button1);
            this.pnButton.Controls.Add(this.btnIgrejas);
            this.pnButton.Controls.Add(this.btnCadastroPessoas);
            this.pnButton.Location = new System.Drawing.Point(0, 81);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(122, 378);
            this.pnButton.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Sistema_Igreja.Properties.Resources.kisspng_door_computer_icons_lock_key_exit_5aca61f9300381_1306238215232127931967;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(29, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 52);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.BackgroundImage = global::Sistema_Igreja.Properties.Resources.kisspng_black_white_m_clip_art_product_design_line_help_svg_png_icon_free_download_169_24_online_5cf4f294daca45_3860031115595567568962;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(29, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 52);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnIgrejas
            // 
            this.btnIgrejas.BackColor = System.Drawing.Color.Goldenrod;
            this.btnIgrejas.BackgroundImage = global::Sistema_Igreja.Properties.Resources._89013;
            this.btnIgrejas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIgrejas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIgrejas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIgrejas.FlatAppearance.BorderSize = 0;
            this.btnIgrejas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnIgrejas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgrejas.Location = new System.Drawing.Point(29, 104);
            this.btnIgrejas.Name = "btnIgrejas";
            this.btnIgrejas.Size = new System.Drawing.Size(64, 52);
            this.btnIgrejas.TabIndex = 2;
            this.btnIgrejas.UseVisualStyleBackColor = false;
            this.btnIgrejas.Click += new System.EventHandler(this.btnIgrejas_Click);
            // 
            // btnCadastroPessoas
            // 
            this.btnCadastroPessoas.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCadastroPessoas.BackgroundImage = global::Sistema_Igreja.Properties.Resources.kisspng_computer_icons_teamwork_icon_design_teamwork_icon_5b4bca1c6e8328_6292423315316935964527;
            this.btnCadastroPessoas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastroPessoas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroPessoas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastroPessoas.FlatAppearance.BorderSize = 0;
            this.btnCadastroPessoas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastroPessoas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroPessoas.Font = new System.Drawing.Font("Castellar", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroPessoas.ForeColor = System.Drawing.Color.White;
            this.btnCadastroPessoas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroPessoas.Location = new System.Drawing.Point(29, 30);
            this.btnCadastroPessoas.Name = "btnCadastroPessoas";
            this.btnCadastroPessoas.Size = new System.Drawing.Size(64, 52);
            this.btnCadastroPessoas.TabIndex = 0;
            this.btnCadastroPessoas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastroPessoas.UseVisualStyleBackColor = false;
            this.btnCadastroPessoas.Click += new System.EventHandler(this.btnCadastroPessoas_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 58);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assembleia de Deus Shekinah";
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnAncoraForm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Igreja";
            this.Load += new System.EventHandler(this.frMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem membroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem igrejaToolStripMenuItem;
        private System.Windows.Forms.Panel pnAncoraForm;
        private System.Windows.Forms.Button btnCadastroPessoas;
        private System.Windows.Forms.Button btnIgrejas;
        private System.Windows.Forms.Panel pnButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

