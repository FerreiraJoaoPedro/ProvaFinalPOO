
namespace ControleLojasRede.Ui
{
    partial class FrmProd
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
            this.dtgProdutos = new System.Windows.Forms.DataGridView();
            this.lblTituloGrande = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblTituloPequeno = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgProdutos
            // 
            this.dtgProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dtgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProdutos.Location = new System.Drawing.Point(14, 290);
            this.dtgProdutos.Name = "dtgProdutos";
            this.dtgProdutos.Size = new System.Drawing.Size(410, 150);
            this.dtgProdutos.TabIndex = 52;
            this.dtgProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProdutos_CellClick);
            // 
            // lblTituloGrande
            // 
            this.lblTituloGrande.AutoSize = true;
            this.lblTituloGrande.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblTituloGrande.ForeColor = System.Drawing.Color.Red;
            this.lblTituloGrande.Location = new System.Drawing.Point(88, 9);
            this.lblTituloGrande.Name = "lblTituloGrande";
            this.lblTituloGrande.Size = new System.Drawing.Size(270, 31);
            this.lblTituloGrande.TabIndex = 51;
            this.lblTituloGrande.Text = "Controle de Produtos";
            this.lblTituloGrande.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(14, 165);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 50;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(138, 105);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(285, 20);
            this.txtNome.TabIndex = 49;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnListar);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Location = new System.Drawing.Point(14, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 57);
            this.panel1.TabIndex = 48;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Red;
            this.btnListar.ForeColor = System.Drawing.Color.Snow;
            this.btnListar.Location = new System.Drawing.Point(308, 13);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(91, 30);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "LISTAR";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Red;
            this.btnAlterar.ForeColor = System.Drawing.Color.Snow;
            this.btnAlterar.Location = new System.Drawing.Point(108, 13);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(91, 30);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Red;
            this.btnCadastrar.ForeColor = System.Drawing.Color.Snow;
            this.btnCadastrar.Location = new System.Drawing.Point(8, 13);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(91, 30);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "CADASTRAR ";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.ForeColor = System.Drawing.Color.Snow;
            this.btnExcluir.Location = new System.Drawing.Point(208, 13);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(91, 30);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(11, 143);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 47;
            this.lblPreco.Text = "Preço:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(135, 79);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 46;
            this.lblNome.Text = "Nome:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(14, 105);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 44;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(11, 79);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 43;
            this.lblCodigo.Text = "Código:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(135, 143);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 42;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblTituloPequeno
            // 
            this.lblTituloPequeno.AutoSize = true;
            this.lblTituloPequeno.BackColor = System.Drawing.Color.Red;
            this.lblTituloPequeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTituloPequeno.ForeColor = System.Drawing.Color.Snow;
            this.lblTituloPequeno.Location = new System.Drawing.Point(164, 40);
            this.lblTituloPequeno.Name = "lblTituloPequeno";
            this.lblTituloPequeno.Size = new System.Drawing.Size(115, 20);
            this.lblTituloPequeno.TabIndex = 53;
            this.lblTituloPequeno.Text = "LOJAS REDE";
            this.lblTituloPequeno.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(139, 165);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(285, 20);
            this.txtCategoria.TabIndex = 54;
            // 
            // FrmProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.lblTituloPequeno);
            this.Controls.Add(this.dtgProdutos);
            this.Controls.Add(this.lblTituloGrande);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblCategoria);
            this.Name = "FrmProd";
            this.Text = "FrmProd";
            this.Load += new System.EventHandler(this.FrmProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgProdutos;
        private System.Windows.Forms.Label lblTituloGrande;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblTituloPequeno;
        private System.Windows.Forms.TextBox txtCategoria;
    }
}