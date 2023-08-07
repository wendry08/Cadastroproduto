namespace Cadastro_atividade
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_codigo = new System.Windows.Forms.Label();
            this.lb_preco = new System.Windows.Forms.Label();
            this.lb_venda = new System.Windows.Forms.Label();
            this.lb_descricao = new System.Windows.Forms.Label();
            this.lb_lucro = new System.Windows.Forms.Label();
            this.dt_cadastro = new System.Windows.Forms.DataGridView();
            this.bt_novo = new System.Windows.Forms.Button();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.tx_codigo = new System.Windows.Forms.TextBox();
            this.tx_preco = new System.Windows.Forms.TextBox();
            this.tx_descricao = new System.Windows.Forms.TextBox();
            this.tx_lucro = new System.Windows.Forms.TextBox();
            this.lb_valorvenda = new System.Windows.Forms.Label();
            this.tx_valorvenda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt_cadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produto";
            // 
            // lb_codigo
            // 
            this.lb_codigo.AutoSize = true;
            this.lb_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_codigo.Location = new System.Drawing.Point(12, 131);
            this.lb_codigo.Name = "lb_codigo";
            this.lb_codigo.Size = new System.Drawing.Size(63, 20);
            this.lb_codigo.TabIndex = 1;
            this.lb_codigo.Text = "Código:";
            // 
            // lb_preco
            // 
            this.lb_preco.AutoSize = true;
            this.lb_preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_preco.Location = new System.Drawing.Point(10, 179);
            this.lb_preco.Name = "lb_preco";
            this.lb_preco.Size = new System.Drawing.Size(149, 20);
            this.lb_preco.TabIndex = 2;
            this.lb_preco.Text = "Preço de Aquisição:";
            this.lb_preco.Click += new System.EventHandler(this.label3_Click);
            // 
            // lb_venda
            // 
            this.lb_venda.AutoSize = true;
            this.lb_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_venda.Location = new System.Drawing.Point(12, 234);
            this.lb_venda.Name = "lb_venda";
            this.lb_venda.Size = new System.Drawing.Size(123, 20);
            this.lb_venda.TabIndex = 3;
            this.lb_venda.Text = "Valor da Venda:";
            // 
            // lb_descricao
            // 
            this.lb_descricao.AutoSize = true;
            this.lb_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_descricao.Location = new System.Drawing.Point(433, 140);
            this.lb_descricao.Name = "lb_descricao";
            this.lb_descricao.Size = new System.Drawing.Size(84, 20);
            this.lb_descricao.TabIndex = 4;
            this.lb_descricao.Text = "Descrição:";
            // 
            // lb_lucro
            // 
            this.lb_lucro.AutoSize = true;
            this.lb_lucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lucro.Location = new System.Drawing.Point(433, 200);
            this.lb_lucro.Name = "lb_lucro";
            this.lb_lucro.Size = new System.Drawing.Size(71, 20);
            this.lb_lucro.TabIndex = 5;
            this.lb_lucro.Text = "Lucro %:";
            // 
            // dt_cadastro
            // 
            this.dt_cadastro.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dt_cadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_cadastro.Location = new System.Drawing.Point(2, 305);
            this.dt_cadastro.Name = "dt_cadastro";
            this.dt_cadastro.Size = new System.Drawing.Size(804, 150);
            this.dt_cadastro.TabIndex = 6;
            // 
            // bt_novo
            // 
            this.bt_novo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_novo.Location = new System.Drawing.Point(452, 276);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(75, 23);
            this.bt_novo.TabIndex = 7;
            this.bt_novo.Text = "Novo";
            this.bt_novo.UseVisualStyleBackColor = false;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastrar.Location = new System.Drawing.Point(549, 276);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.bt_cadastrar.TabIndex = 8;
            this.bt_cadastrar.Text = "Cadastrar";
            this.bt_cadastrar.UseVisualStyleBackColor = false;
            this.bt_cadastrar.Click += new System.EventHandler(this.bt_cadastrar_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_excluir.Location = new System.Drawing.Point(651, 276);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(75, 23);
            this.bt_excluir.TabIndex = 9;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = false;
            // 
            // tx_codigo
            // 
            this.tx_codigo.Location = new System.Drawing.Point(81, 133);
            this.tx_codigo.Name = "tx_codigo";
            this.tx_codigo.Size = new System.Drawing.Size(201, 20);
            this.tx_codigo.TabIndex = 10;
            // 
            // tx_preco
            // 
            this.tx_preco.Location = new System.Drawing.Point(161, 181);
            this.tx_preco.Name = "tx_preco";
            this.tx_preco.Size = new System.Drawing.Size(121, 20);
            this.tx_preco.TabIndex = 11;
            // 
            // tx_descricao
            // 
            this.tx_descricao.Location = new System.Drawing.Point(513, 142);
            this.tx_descricao.Name = "tx_descricao";
            this.tx_descricao.Size = new System.Drawing.Size(100, 20);
            this.tx_descricao.TabIndex = 13;
            // 
            // tx_lucro
            // 
            this.tx_lucro.Location = new System.Drawing.Point(513, 202);
            this.tx_lucro.Name = "tx_lucro";
            this.tx_lucro.Size = new System.Drawing.Size(100, 20);
            this.tx_lucro.TabIndex = 14;
            // 
            // lb_valorvenda
            // 
            this.lb_valorvenda.AutoSize = true;
            this.lb_valorvenda.Location = new System.Drawing.Point(78, 276);
            this.lb_valorvenda.Name = "lb_valorvenda";
            this.lb_valorvenda.Size = new System.Drawing.Size(35, 13);
            this.lb_valorvenda.TabIndex = 15;
            this.lb_valorvenda.Text = "label2";
            // 
            // tx_valorvenda
            // 
            this.tx_valorvenda.Location = new System.Drawing.Point(141, 236);
            this.tx_valorvenda.Name = "tx_valorvenda";
            this.tx_valorvenda.Size = new System.Drawing.Size(100, 20);
            this.tx_valorvenda.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tx_valorvenda);
            this.Controls.Add(this.lb_valorvenda);
            this.Controls.Add(this.tx_lucro);
            this.Controls.Add(this.tx_descricao);
            this.Controls.Add(this.tx_preco);
            this.Controls.Add(this.tx_codigo);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.bt_novo);
            this.Controls.Add(this.dt_cadastro);
            this.Controls.Add(this.lb_lucro);
            this.Controls.Add(this.lb_descricao);
            this.Controls.Add(this.lb_venda);
            this.Controls.Add(this.lb_preco);
            this.Controls.Add(this.lb_codigo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dt_cadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_codigo;
        private System.Windows.Forms.Label lb_preco;
        private System.Windows.Forms.Label lb_venda;
        private System.Windows.Forms.Label lb_descricao;
        private System.Windows.Forms.Label lb_lucro;
        private System.Windows.Forms.DataGridView dt_cadastro;
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.TextBox tx_codigo;
        private System.Windows.Forms.TextBox tx_preco;
        private System.Windows.Forms.TextBox tx_descricao;
        private System.Windows.Forms.TextBox tx_lucro;
        private System.Windows.Forms.Label lb_valorvenda;
        private System.Windows.Forms.TextBox tx_valorvenda;
    }
}

