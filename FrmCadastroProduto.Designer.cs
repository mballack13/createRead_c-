
namespace WinFormsApp1
{
    partial class FrmCadastroProduto
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblQuantEst = new System.Windows.Forms.Label();
            this.txtQuantEst = new System.Windows.Forms.TextBox();
            this.lblValorUnit = new System.Windows.Forms.Label();
            this.txtValorUnit = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.dtGridProduto = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantDeEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(12, 234);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(94, 35);
            this.btnSalvar.TabIndex = 39;
            this.btnSalvar.Tag = "#";
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblQuantEst
            // 
            this.lblQuantEst.AutoSize = true;
            this.lblQuantEst.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantEst.Location = new System.Drawing.Point(12, 142);
            this.lblQuantEst.Name = "lblQuantEst";
            this.lblQuantEst.Size = new System.Drawing.Size(166, 25);
            this.lblQuantEst.TabIndex = 28;
            this.lblQuantEst.Text = "Quant. de Estoque";
            // 
            // txtQuantEst
            // 
            this.txtQuantEst.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantEst.Location = new System.Drawing.Point(205, 139);
            this.txtQuantEst.Name = "txtQuantEst";
            this.txtQuantEst.Size = new System.Drawing.Size(203, 33);
            this.txtQuantEst.TabIndex = 27;
            // 
            // lblValorUnit
            // 
            this.lblValorUnit.AutoSize = true;
            this.lblValorUnit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorUnit.Location = new System.Drawing.Point(12, 103);
            this.lblValorUnit.Name = "lblValorUnit";
            this.lblValorUnit.Size = new System.Drawing.Size(129, 25);
            this.lblValorUnit.TabIndex = 26;
            this.lblValorUnit.Text = "Valor Unitário";
            // 
            // txtValorUnit
            // 
            this.txtValorUnit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorUnit.Location = new System.Drawing.Point(205, 100);
            this.txtValorUnit.Name = "txtValorUnit";
            this.txtValorUnit.Size = new System.Drawing.Size(203, 33);
            this.txtValorUnit.TabIndex = 25;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescricao.Location = new System.Drawing.Point(12, 64);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(94, 25);
            this.lblDescricao.TabIndex = 24;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescricao.Location = new System.Drawing.Point(205, 61);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(203, 33);
            this.txtDescricao.TabIndex = 23;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(205, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(203, 33);
            this.txtNome.TabIndex = 22;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(12, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(63, 25);
            this.lblNome.TabIndex = 21;
            this.lblNome.Text = "Nome";
            // 
            // dtGridProduto
            // 
            this.dtGridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Descricao,
            this.ValorUnit,
            this.QuantDeEst,
            this.Fabricante});
            this.dtGridProduto.Location = new System.Drawing.Point(463, 19);
            this.dtGridProduto.Name = "dtGridProduto";
            this.dtGridProduto.RowTemplate.Height = 25;
            this.dtGridProduto.Size = new System.Drawing.Size(1243, 489);
            this.dtGridProduto.TabIndex = 40;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            // 
            // ValorUnit
            // 
            this.ValorUnit.HeaderText = "Valor Unitário";
            this.ValorUnit.Name = "ValorUnit";
            // 
            // QuantDeEst
            // 
            this.QuantDeEst.HeaderText = "Quantidade de Estoque";
            this.QuantDeEst.Name = "QuantDeEst";
            // 
            // Fabricante
            // 
            this.Fabricante.HeaderText = "Fabricante";
            this.Fabricante.Name = "Fabricante";
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFabricante.Location = new System.Drawing.Point(12, 181);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(99, 25);
            this.lblFabricante.TabIndex = 42;
            this.lblFabricante.Text = "Fabricante";
            // 
            // txtFabricante
            // 
            this.txtFabricante.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFabricante.Location = new System.Drawing.Point(205, 178);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(203, 33);
            this.txtFabricante.TabIndex = 41;
            // 
            // FrmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 450);
            this.Controls.Add(this.lblFabricante);
            this.Controls.Add(this.txtFabricante);
            this.Controls.Add(this.dtGridProduto);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblQuantEst);
            this.Controls.Add(this.txtQuantEst);
            this.Controls.Add(this.lblValorUnit);
            this.Controls.Add(this.txtValorUnit);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmCadastroProduto";
            this.Text = "Cadastro de Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblQuantEst;
        private System.Windows.Forms.TextBox txtQuantEst;
        private System.Windows.Forms.Label lblValorUnit;
        private System.Windows.Forms.TextBox txtValorUnit;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dtGridProduto;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantDeEst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fabricante;
    }
}