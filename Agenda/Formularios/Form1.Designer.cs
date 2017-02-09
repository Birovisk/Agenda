namespace Agenda
{ 
    partial class frmProdutos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tstSalvar = new System.Windows.Forms.ToolStripButton();
            this.tstExcluir = new System.Windows.Forms.ToolStripButton();
            this.tstPesquisar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tstSair = new System.Windows.Forms.ToolStripButton();
            this.grpClientes = new System.Windows.Forms.GroupBox();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.errErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            this.grpClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstSalvar,
            this.tstExcluir,
            this.tstPesquisar,
            this.toolStripSeparator1,
            this.tstSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(600, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tstSalvar
            // 
            this.tstSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tstSalvar.Image")));
            this.tstSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstSalvar.Name = "tstSalvar";
            this.tstSalvar.Size = new System.Drawing.Size(42, 22);
            this.tstSalvar.Text = "&Salvar";
            this.tstSalvar.ToolTipText = "Clique para Salvar";
            this.tstSalvar.Click += new System.EventHandler(this.tstSalvar_Click);
            // 
            // tstExcluir
            // 
            this.tstExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tstExcluir.Image")));
            this.tstExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstExcluir.Name = "tstExcluir";
            this.tstExcluir.Size = new System.Drawing.Size(45, 22);
            this.tstExcluir.Text = "&Excluir";
            this.tstExcluir.ToolTipText = "Excluir";
            // 
            // tstPesquisar
            // 
            this.tstPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("tstPesquisar.Image")));
            this.tstPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstPesquisar.Name = "tstPesquisar";
            this.tstPesquisar.Size = new System.Drawing.Size(61, 22);
            this.tstPesquisar.Text = "&Pesquisar";
            this.tstPesquisar.ToolTipText = "Clique para Salvar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tstSair
            // 
            this.tstSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstSair.Image = ((System.Drawing.Image)(resources.GetObject("tstSair.Image")));
            this.tstSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstSair.Name = "tstSair";
            this.tstSair.Size = new System.Drawing.Size(30, 22);
            this.tstSair.Text = "S&air";
            this.tstSair.ToolTipText = "Clique para Salvar";
            this.tstSair.Click += new System.EventHandler(this.tstSair_Click);
            // 
            // grpClientes
            // 
            this.grpClientes.Controls.Add(this.mskData);
            this.grpClientes.Controls.Add(this.lblData);
            this.grpClientes.Controls.Add(this.lblPreco);
            this.grpClientes.Controls.Add(this.lblMarca);
            this.grpClientes.Controls.Add(this.lblDescricao);
            this.grpClientes.Controls.Add(this.txtPreco);
            this.grpClientes.Controls.Add(this.txtMarca);
            this.grpClientes.Controls.Add(this.txtDescricao);
            this.grpClientes.Controls.Add(this.lblCodigo);
            this.grpClientes.Controls.Add(this.txtCodigo);
            this.grpClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpClientes.Location = new System.Drawing.Point(12, 28);
            this.grpClientes.Name = "grpClientes";
            this.grpClientes.Size = new System.Drawing.Size(583, 143);
            this.grpClientes.TabIndex = 5;
            this.grpClientes.TabStop = false;
            this.grpClientes.Text = "Dados do Produto";
            // 
            // mskData
            // 
            this.mskData.Location = new System.Drawing.Point(267, 96);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(79, 20);
            this.mskData.TabIndex = 13;
            this.mskData.ValidatingType = typeof(System.DateTime);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(263, 80);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(104, 13);
            this.lblData.TabIndex = 12;
            this.lblData.Text = "Data de Inclusão";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(186, 80);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(40, 13);
            this.lblPreco.TabIndex = 11;
            this.lblPreco.Text = "Preço";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(16, 80);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(42, 13);
            this.lblMarca.TabIndex = 10;
            this.lblMarca.Text = "Marca";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(96, 29);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(64, 13);
            this.lblDescricao.TabIndex = 9;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtPreco
            // 
            this.txtPreco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPreco.Location = new System.Drawing.Point(189, 96);
            this.txtPreco.MaxLength = 10;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(71, 20);
            this.txtPreco.TabIndex = 5;
            this.txtPreco.Text = "0.00";
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMarca
            // 
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.Location = new System.Drawing.Point(19, 96);
            this.txtMarca.MaxLength = 50;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(164, 20);
            this.txtMarca.TabIndex = 4;
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(96, 45);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(481, 20);
            this.txtDescricao.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(16, 29);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(19, 45);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(71, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // errErro
            // 
            this.errErro.ContainerControl = this;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 177);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grpClientes);
            this.Name = "frmProdutos";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpClientes.ResumeLayout(false);
            this.grpClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tstSalvar;
        private System.Windows.Forms.ToolStripButton tstExcluir;
        private System.Windows.Forms.ToolStripButton tstPesquisar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tstSair;
        private System.Windows.Forms.GroupBox grpClientes;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ErrorProvider errErro;
    }
}