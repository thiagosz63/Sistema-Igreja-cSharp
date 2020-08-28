namespace Sistema_Igreja.gui
{
    partial class frRegisterList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.cbPesquisa = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dgvFrRegister = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblVier2 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrRegister)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvFrRegister);
            this.panel1.Controls.Add(this.lblVier2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 450);
            this.panel1.TabIndex = 0;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(138, 19);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(149, 26);
            this.txtPesquisa.TabIndex = 6;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // cbPesquisa
            // 
            this.cbPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPesquisa.FormattingEnabled = true;
            this.cbPesquisa.Location = new System.Drawing.Point(6, 17);
            this.cbPesquisa.Name = "cbPesquisa";
            this.cbPesquisa.Size = new System.Drawing.Size(121, 28);
            this.cbPesquisa.TabIndex = 5;
            this.cbPesquisa.Click += new System.EventHandler(this.cbPesquisa_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(114, 14);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(93, 31);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dgvFrRegister
            // 
            this.dgvFrRegister.AllowUserToAddRows = false;
            this.dgvFrRegister.AllowUserToDeleteRows = false;
            this.dgvFrRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFrRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvFrRegister.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFrRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar,
            this.excluir});
            this.dgvFrRegister.Location = new System.Drawing.Point(3, 101);
            this.dgvFrRegister.Name = "dgvFrRegister";
            this.dgvFrRegister.ReadOnly = true;
            this.dgvFrRegister.Size = new System.Drawing.Size(796, 346);
            this.dgvFrRegister.TabIndex = 3;
            this.dgvFrRegister.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFrRegister_CellClick);
            // 
            // editar
            // 
            this.editar.HeaderText = "";
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Text = "Editar";
            this.editar.UseColumnTextForButtonValue = true;
            this.editar.Width = 5;
            // 
            // excluir
            // 
            this.excluir.HeaderText = "";
            this.excluir.Name = "excluir";
            this.excluir.ReadOnly = true;
            this.excluir.Text = "Excluir";
            this.excluir.UseColumnTextForButtonValue = true;
            this.excluir.Width = 5;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(15, 14);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(93, 31);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblVier2
            // 
            this.lblVier2.AutoSize = true;
            this.lblVier2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVier2.Location = new System.Drawing.Point(12, 9);
            this.lblVier2.Name = "lblVier2";
            this.lblVier2.Size = new System.Drawing.Size(180, 20);
            this.lblVier2.TabIndex = 0;
            this.lblVier2.Text = "Registro de Membros";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Column3";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 54;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPesquisa);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Location = new System.Drawing.Point(271, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 54);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNovo);
            this.groupBox2.Controls.Add(this.btnVoltar);
            this.groupBox2.Location = new System.Drawing.Point(12, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 54);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // frRegisterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frRegisterList";
            this.Text = "FrRegisterList";
            this.Load += new System.EventHandler(this.frRegisterList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrRegister)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblVier2;
        private System.Windows.Forms.DataGridViewButtonColumn editar;
        private System.Windows.Forms.DataGridViewButtonColumn excluir;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        public System.Windows.Forms.DataGridView dgvFrRegister;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.ComboBox cbPesquisa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}