namespace Crud_com_mysql
{
    partial class crud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crud));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.MaskedTextBox();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(94, 95);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(186, 20);
            this.txtNome.TabIndex = 2;
            this.toolTip.SetToolTip(this.txtNome, "Nome do funcionario");
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(94, 124);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 3;
            this.toolTip.SetToolTip(this.txtIdade, "idade do funcionario");
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(94, 191);
            this.txtAltura.Mask = "0.00";
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 5;
            this.toolTip.SetToolTip(this.txtAltura, "Altura do funcionario");
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.Location = new System.Drawing.Point(170, 229);
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(121, 20);
            this.txtNacionalidade.TabIndex = 6;
            this.toolTip.SetToolTip(this.txtNacionalidade, "Lugar onde o funcionario nasceu");
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(103, 265);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 7;
            this.toolTip.SetToolTip(this.txtSalario, "Quantia de salario recebido pelo funcionario");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(772, 145);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(94, 158);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(100, 20);
            this.txtSexo.TabIndex = 4;
            this.toolTip.SetToolTip(this.txtSexo, "Sexo M ou F");
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(72, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(36, 20);
            this.txtID.TabIndex = 1;
            this.toolTip.SetToolTip(this.txtID, "Não Mecha");
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpar.Location = new System.Drawing.Point(674, 191);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(114, 45);
            this.btnLimpar.TabIndex = 11;
            this.toolTip.SetToolTip(this.btnLimpar, "Limpar");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExibir.BackgroundImage")));
            this.btnExibir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExibir.Location = new System.Drawing.Point(674, 242);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(114, 45);
            this.btnExibir.TabIndex = 12;
            this.toolTip.SetToolTip(this.btnExibir, "Exibir/Atualizar");
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApagar.BackgroundImage")));
            this.btnApagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnApagar.Location = new System.Drawing.Point(674, 140);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(114, 45);
            this.btnApagar.TabIndex = 10;
            this.toolTip.SetToolTip(this.btnApagar, "Apagar");
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Location = new System.Drawing.Point(674, 89);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(114, 45);
            this.btnEditar.TabIndex = 9;
            this.toolTip.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Location = new System.Drawing.Point(674, 38);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(114, 45);
            this.btnSalvar.TabIndex = 8;
            this.toolTip.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNacionalidade);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtNome);
            this.MinimizeBox = false;
            this.Name = "crud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro - V1.5.9";
            this.Load += new System.EventHandler(this.crud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.MaskedTextBox txtAltura;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

