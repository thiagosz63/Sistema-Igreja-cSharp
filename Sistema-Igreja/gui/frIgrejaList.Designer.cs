namespace Sistema_Igreja.gui
{
    partial class frIgrejaList
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
            this.btnVoltar2 = new System.Windows.Forms.Button();
            this.dgvFrRegister = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPesquisaIgrejas = new System.Windows.Forms.ComboBox();
            this.txtPesquisaIgrejas = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrRegister)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnVoltar2);
            this.panel1.Controls.Add(this.dgvFrRegister);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnVoltar2
            // 
            this.btnVoltar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar2.Location = new System.Drawing.Point(115, 58);
            this.btnVoltar2.Name = "btnVoltar2";
            this.btnVoltar2.Size = new System.Drawing.Size(90, 35);
            this.btnVoltar2.TabIndex = 6;
            this.btnVoltar2.Text = "Voltar";
            this.btnVoltar2.UseVisualStyleBackColor = true;
            this.btnVoltar2.Click += new System.EventHandler(this.btnVoltar2_Click);
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
            this.dgvFrRegister.Location = new System.Drawing.Point(0, 99);
            this.dgvFrRegister.Name = "dgvFrRegister";
            this.dgvFrRegister.ReadOnly = true;
            this.dgvFrRegister.Size = new System.Drawing.Size(796, 351);
            this.dgvFrRegister.TabIndex = 5;
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
            this.btnNovo.Location = new System.Drawing.Point(3, 58);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(93, 35);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registros de Igrejas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPesquisaIgrejas);
            this.groupBox1.Controls.Add(this.txtPesquisaIgrejas);
            this.groupBox1.Location = new System.Drawing.Point(243, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 54);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // cbPesquisaIgrejas
            // 
            this.cbPesquisaIgrejas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesquisaIgrejas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPesquisaIgrejas.FormattingEnabled = true;
            this.cbPesquisaIgrejas.Location = new System.Drawing.Point(6, 17);
            this.cbPesquisaIgrejas.Name = "cbPesquisaIgrejas";
            this.cbPesquisaIgrejas.Size = new System.Drawing.Size(121, 28);
            this.cbPesquisaIgrejas.TabIndex = 5;
            // 
            // txtPesquisaIgrejas
            // 
            this.txtPesquisaIgrejas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaIgrejas.Location = new System.Drawing.Point(138, 19);
            this.txtPesquisaIgrejas.Name = "txtPesquisaIgrejas";
            this.txtPesquisaIgrejas.Size = new System.Drawing.Size(149, 26);
            this.txtPesquisaIgrejas.TabIndex = 6;
            // 
            // frIgrejaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frIgrejaList";
            this.Text = "frIgrejaList";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrRegister)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvFrRegister;
        private System.Windows.Forms.DataGridViewButtonColumn editar;
        private System.Windows.Forms.DataGridViewButtonColumn excluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnVoltar2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbPesquisaIgrejas;
        private System.Windows.Forms.TextBox txtPesquisaIgrejas;
    }
}