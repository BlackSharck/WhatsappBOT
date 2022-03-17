
namespace SpanZapForms.View
{
    partial class Contatos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contatos));
            this.NomeCampanha = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnISalvar = new System.Windows.Forms.Button();
            this.TxtIFone = new System.Windows.Forms.TextBox();
            this.TxtINome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Planilha = new System.Windows.Forms.Button();
            this.BtnIMassa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Lista = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnExcluirVarios = new System.Windows.Forms.Button();
            this.TxtEId = new System.Windows.Forms.TextBox();
            this.BtnEAltera = new System.Windows.Forms.Button();
            this.BtnEDell = new System.Windows.Forms.Button();
            this.TxtEFone = new System.Windows.Forms.TextBox();
            this.TxtENome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DGVContatos = new System.Windows.Forms.DataGridView();
            this.Btnvoltar = new System.Windows.Forms.Button();
            this.PBLoad = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PGBcarregar = new System.Windows.Forms.ProgressBar();
            this.BtnAtualizarDGV = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.contatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contatosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVContatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // NomeCampanha
            // 
            this.NomeCampanha.AutoSize = true;
            this.NomeCampanha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeCampanha.Location = new System.Drawing.Point(12, 9);
            this.NomeCampanha.Name = "NomeCampanha";
            this.NomeCampanha.Size = new System.Drawing.Size(27, 25);
            this.NomeCampanha.TabIndex = 0;
            this.NomeCampanha.Text = "C";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnISalvar);
            this.groupBox1.Controls.Add(this.TxtIFone);
            this.groupBox1.Controls.Add(this.TxtINome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 143);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Contatos ";
            // 
            // BtnISalvar
            // 
            this.BtnISalvar.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnISalvar.ForeColor = System.Drawing.Color.Black;
            this.BtnISalvar.Location = new System.Drawing.Point(383, 100);
            this.BtnISalvar.Name = "BtnISalvar";
            this.BtnISalvar.Size = new System.Drawing.Size(75, 37);
            this.BtnISalvar.TabIndex = 4;
            this.BtnISalvar.Text = "Inserir";
            this.BtnISalvar.UseVisualStyleBackColor = false;
            this.BtnISalvar.Click += new System.EventHandler(this.BtnISalvar_Click);
            // 
            // TxtIFone
            // 
            this.TxtIFone.Location = new System.Drawing.Point(244, 57);
            this.TxtIFone.MaxLength = 11;
            this.TxtIFone.Name = "TxtIFone";
            this.TxtIFone.Size = new System.Drawing.Size(214, 24);
            this.TxtIFone.TabIndex = 3;
            // 
            // TxtINome
            // 
            this.TxtINome.Location = new System.Drawing.Point(10, 57);
            this.TxtINome.MaxLength = 30;
            this.TxtINome.Name = "TxtINome";
            this.TxtINome.Size = new System.Drawing.Size(214, 24);
            this.TxtINome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Planilha);
            this.groupBox2.Controls.Add(this.BtnIMassa);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 132);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adicionar Contatos Em Massa";
            // 
            // Planilha
            // 
            this.Planilha.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Planilha.Location = new System.Drawing.Point(86, 85);
            this.Planilha.Name = "Planilha";
            this.Planilha.Size = new System.Drawing.Size(295, 33);
            this.Planilha.TabIndex = 6;
            this.Planilha.Text = "Baixar modelo de Planilha";
            this.Planilha.UseVisualStyleBackColor = false;
            this.Planilha.Click += new System.EventHandler(this.Planilha_Click);
            // 
            // BtnIMassa
            // 
            this.BtnIMassa.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnIMassa.ForeColor = System.Drawing.Color.Black;
            this.BtnIMassa.Location = new System.Drawing.Point(86, 42);
            this.BtnIMassa.Name = "BtnIMassa";
            this.BtnIMassa.Size = new System.Drawing.Size(295, 37);
            this.BtnIMassa.TabIndex = 5;
            this.BtnIMassa.Text = "Procura Arquivo (Excel)";
            this.BtnIMassa.UseVisualStyleBackColor = false;
            this.BtnIMassa.Click += new System.EventHandler(this.BtnIMassa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(723, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contatos";
            // 
            // Lista
            // 
            this.Lista.Filter = "Excel |*.xlsx";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnExcluirVarios);
            this.groupBox3.Controls.Add(this.TxtEId);
            this.groupBox3.Controls.Add(this.BtnEAltera);
            this.groupBox3.Controls.Add(this.BtnEDell);
            this.groupBox3.Controls.Add(this.TxtEFone);
            this.groupBox3.Controls.Add(this.TxtENome);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(17, 401);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(470, 143);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Editar Contatos ";
            // 
            // BtnExcluirVarios
            // 
            this.BtnExcluirVarios.BackColor = System.Drawing.Color.DarkRed;
            this.BtnExcluirVarios.ForeColor = System.Drawing.Color.White;
            this.BtnExcluirVarios.Location = new System.Drawing.Point(311, 87);
            this.BtnExcluirVarios.Name = "BtnExcluirVarios";
            this.BtnExcluirVarios.Size = new System.Drawing.Size(147, 37);
            this.BtnExcluirVarios.TabIndex = 7;
            this.BtnExcluirVarios.Text = "Excluir Vários";
            this.BtnExcluirVarios.UseVisualStyleBackColor = false;
            this.BtnExcluirVarios.Click += new System.EventHandler(this.BtnExcluirVarios_Click);
            // 
            // TxtEId
            // 
            this.TxtEId.Location = new System.Drawing.Point(10, 93);
            this.TxtEId.MaxLength = 30;
            this.TxtEId.Name = "TxtEId";
            this.TxtEId.Size = new System.Drawing.Size(214, 24);
            this.TxtEId.TabIndex = 6;
            this.TxtEId.Visible = false;
            // 
            // BtnEAltera
            // 
            this.BtnEAltera.BackColor = System.Drawing.Color.Orange;
            this.BtnEAltera.ForeColor = System.Drawing.Color.White;
            this.BtnEAltera.Location = new System.Drawing.Point(149, 87);
            this.BtnEAltera.Name = "BtnEAltera";
            this.BtnEAltera.Size = new System.Drawing.Size(75, 37);
            this.BtnEAltera.TabIndex = 5;
            this.BtnEAltera.Text = "Alterar";
            this.BtnEAltera.UseVisualStyleBackColor = false;
            this.BtnEAltera.Click += new System.EventHandler(this.BtnEAltera_Click);
            // 
            // BtnEDell
            // 
            this.BtnEDell.BackColor = System.Drawing.Color.Red;
            this.BtnEDell.ForeColor = System.Drawing.Color.White;
            this.BtnEDell.Location = new System.Drawing.Point(230, 87);
            this.BtnEDell.Name = "BtnEDell";
            this.BtnEDell.Size = new System.Drawing.Size(75, 37);
            this.BtnEDell.TabIndex = 4;
            this.BtnEDell.Text = "Excluir";
            this.BtnEDell.UseVisualStyleBackColor = false;
            this.BtnEDell.Click += new System.EventHandler(this.BtnEDell_Click);
            // 
            // TxtEFone
            // 
            this.TxtEFone.Location = new System.Drawing.Point(244, 57);
            this.TxtEFone.MaxLength = 11;
            this.TxtEFone.Name = "TxtEFone";
            this.TxtEFone.Size = new System.Drawing.Size(214, 24);
            this.TxtEFone.TabIndex = 3;
            // 
            // TxtENome
            // 
            this.TxtENome.Location = new System.Drawing.Point(10, 57);
            this.TxtENome.MaxLength = 30;
            this.TxtENome.Name = "TxtENome";
            this.TxtENome.Size = new System.Drawing.Size(214, 24);
            this.TxtENome.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nome";
            // 
            // DGVContatos
            // 
            this.DGVContatos.AllowUserToAddRows = false;
            this.DGVContatos.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVContatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVContatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.foneDataGridViewTextBoxColumn});
            this.DGVContatos.DataSource = this.contatosBindingSource2;
            this.DGVContatos.Location = new System.Drawing.Point(503, 55);
            this.DGVContatos.MultiSelect = false;
            this.DGVContatos.Name = "DGVContatos";
            this.DGVContatos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVContatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVContatos.RowHeadersVisible = false;
            this.DGVContatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVContatos.Size = new System.Drawing.Size(555, 489);
            this.DGVContatos.TabIndex = 6;
            this.DGVContatos.SelectionChanged += new System.EventHandler(this.DGVContatos_SelectionChanged_1);
            // 
            // Btnvoltar
            // 
            this.Btnvoltar.BackColor = System.Drawing.Color.Crimson;
            this.Btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnvoltar.ForeColor = System.Drawing.Color.White;
            this.Btnvoltar.Location = new System.Drawing.Point(945, 557);
            this.Btnvoltar.Name = "Btnvoltar";
            this.Btnvoltar.Size = new System.Drawing.Size(113, 39);
            this.Btnvoltar.TabIndex = 10;
            this.Btnvoltar.Text = "Voltar";
            this.Btnvoltar.UseVisualStyleBackColor = false;
            this.Btnvoltar.Click += new System.EventHandler(this.Btnvoltar_Click);
            // 
            // PBLoad
            // 
            this.PBLoad.BackColor = System.Drawing.Color.PaleTurquoise;
            this.PBLoad.Image = ((System.Drawing.Image)(resources.GetObject("PBLoad.Image")));
            this.PBLoad.Location = new System.Drawing.Point(323, 87);
            this.PBLoad.Name = "PBLoad";
            this.PBLoad.Size = new System.Drawing.Size(428, 347);
            this.PBLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBLoad.TabIndex = 11;
            this.PBLoad.TabStop = false;
            this.PBLoad.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PGBcarregar
            // 
            this.PGBcarregar.Location = new System.Drawing.Point(190, 502);
            this.PGBcarregar.Name = "PGBcarregar";
            this.PGBcarregar.Size = new System.Drawing.Size(714, 62);
            this.PGBcarregar.TabIndex = 12;
            this.PGBcarregar.Visible = false;
            // 
            // BtnAtualizarDGV
            // 
            this.BtnAtualizarDGV.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnAtualizarDGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizarDGV.ForeColor = System.Drawing.Color.White;
            this.BtnAtualizarDGV.Location = new System.Drawing.Point(835, 3);
            this.BtnAtualizarDGV.Name = "BtnAtualizarDGV";
            this.BtnAtualizarDGV.Size = new System.Drawing.Size(204, 40);
            this.BtnAtualizarDGV.TabIndex = 13;
            this.BtnAtualizarDGV.Text = "Recarregar Lista de Contatos";
            this.BtnAtualizarDGV.UseVisualStyleBackColor = false;
            this.BtnAtualizarDGV.Click += new System.EventHandler(this.BtnAtualizarDGV_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // foneDataGridViewTextBoxColumn
            // 
            this.foneDataGridViewTextBoxColumn.DataPropertyName = "fone";
            this.foneDataGridViewTextBoxColumn.HeaderText = "fone";
            this.foneDataGridViewTextBoxColumn.Name = "foneDataGridViewTextBoxColumn";
            this.foneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contatosBindingSource2
            // 
            this.contatosBindingSource2.DataSource = typeof(SpanZapForms.Model.Contatos);
            // 
            // contatosBindingSource
            // 
            this.contatosBindingSource.DataSource = typeof(SpanZapForms.Model.Contatos);
            // 
            // contatosBindingSource1
            // 
            this.contatosBindingSource1.DataSource = typeof(SpanZapForms.Model.Contatos);
            // 
            // Contatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 608);
            this.Controls.Add(this.BtnAtualizarDGV);
            this.Controls.Add(this.PGBcarregar);
            this.Controls.Add(this.PBLoad);
            this.Controls.Add(this.Btnvoltar);
            this.Controls.Add(this.DGVContatos);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NomeCampanha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Contatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aguiar Bot";
            this.Load += new System.EventHandler(this.Contatos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVContatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomeCampanha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnISalvar;
        private System.Windows.Forms.TextBox TxtIFone;
        private System.Windows.Forms.TextBox TxtINome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnIMassa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog Lista;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnEAltera;
        private System.Windows.Forms.Button BtnEDell;
        private System.Windows.Forms.TextBox TxtEFone;
        private System.Windows.Forms.TextBox TxtENome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource contatosBindingSource;
        private System.Windows.Forms.BindingSource contatosBindingSource1;
        private System.Windows.Forms.DataGridView DGVContatos;
        private System.Windows.Forms.BindingSource contatosBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foneDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TxtEId;
        private System.Windows.Forms.Button Btnvoltar;
        private System.Windows.Forms.PictureBox PBLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar PGBcarregar;
        private System.Windows.Forms.Button Planilha;
        private System.Windows.Forms.Button BtnExcluirVarios;
        private System.Windows.Forms.Button BtnAtualizarDGV;
    }
}