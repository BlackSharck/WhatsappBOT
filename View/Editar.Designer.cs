
namespace SpanZapForms.View
{
    partial class Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNomeCamp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtSaudaDois = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSaudaUM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVCampanhas = new System.Windows.Forms.DataGridView();
            this.txtTextoCampanha = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnDell = new System.Windows.Forms.Button();
            this.btnAddContato = new System.Windows.Forms.Button();
            this.Salvar = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btnvoltar = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campanhaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCampanhas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campanhaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da Campanha";
            // 
            // TxtNomeCamp
            // 
            this.TxtNomeCamp.Location = new System.Drawing.Point(6, 56);
            this.TxtNomeCamp.Name = "TxtNomeCamp";
            this.TxtNomeCamp.Size = new System.Drawing.Size(282, 20);
            this.TxtNomeCamp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "1º ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtSaudaDois);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtSaudaUM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 137);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saudações";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TxtSaudaDois
            // 
            this.TxtSaudaDois.Location = new System.Drawing.Point(9, 91);
            this.TxtSaudaDois.Name = "TxtSaudaDois";
            this.TxtSaudaDois.Size = new System.Drawing.Size(267, 23);
            this.TxtSaudaDois.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "2º ";
            // 
            // TxtSaudaUM
            // 
            this.TxtSaudaUM.Location = new System.Drawing.Point(9, 32);
            this.TxtSaudaUM.Name = "TxtSaudaUM";
            this.TxtSaudaUM.Size = new System.Drawing.Size(267, 23);
            this.TxtSaudaUM.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mensagem Da Campanha";
            // 
            // DGVCampanhas
            // 
            this.DGVCampanhas.AllowUserToAddRows = false;
            this.DGVCampanhas.AllowUserToDeleteRows = false;
            this.DGVCampanhas.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCampanhas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVCampanhas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCampanhas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn});
            this.DGVCampanhas.DataSource = this.campanhaBindingSource;
            this.DGVCampanhas.EnableHeadersVisualStyles = false;
            this.DGVCampanhas.Location = new System.Drawing.Point(39, 50);
            this.DGVCampanhas.MultiSelect = false;
            this.DGVCampanhas.Name = "DGVCampanhas";
            this.DGVCampanhas.ReadOnly = true;
            this.DGVCampanhas.RowHeadersVisible = false;
            this.DGVCampanhas.RowHeadersWidth = 60;
            this.DGVCampanhas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCampanhas.Size = new System.Drawing.Size(289, 268);
            this.DGVCampanhas.TabIndex = 5;
            this.DGVCampanhas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCampanhas_CellContentClick);
            this.DGVCampanhas.SelectionChanged += new System.EventHandler(this.DGVCampanhas_SelectionChanged);
            // 
            // txtTextoCampanha
            // 
            this.txtTextoCampanha.Location = new System.Drawing.Point(298, 56);
            this.txtTextoCampanha.Name = "txtTextoCampanha";
            this.txtTextoCampanha.Size = new System.Drawing.Size(322, 161);
            this.txtTextoCampanha.TabIndex = 6;
            this.txtTextoCampanha.Text = "";
            this.txtTextoCampanha.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnDell);
            this.groupBox2.Controls.Add(this.btnAddContato);
            this.groupBox2.Controls.Add(this.Salvar);
            this.groupBox2.Controls.Add(this.TxtId);
            this.groupBox2.Controls.Add(this.txtTextoCampanha);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtNomeCamp);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(355, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 297);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Da Campanha";
            // 
            // BtnDell
            // 
            this.BtnDell.BackColor = System.Drawing.Color.Red;
            this.BtnDell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDell.ForeColor = System.Drawing.Color.White;
            this.BtnDell.Location = new System.Drawing.Point(249, 234);
            this.BtnDell.Name = "BtnDell";
            this.BtnDell.Size = new System.Drawing.Size(165, 49);
            this.BtnDell.TabIndex = 11;
            this.BtnDell.Text = "Excluir";
            this.BtnDell.UseVisualStyleBackColor = false;
            this.BtnDell.Click += new System.EventHandler(this.BtnDell_Click);
            // 
            // btnAddContato
            // 
            this.btnAddContato.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddContato.ForeColor = System.Drawing.Color.White;
            this.btnAddContato.Location = new System.Drawing.Point(43, 234);
            this.btnAddContato.Name = "btnAddContato";
            this.btnAddContato.Size = new System.Drawing.Size(167, 49);
            this.btnAddContato.TabIndex = 10;
            this.btnAddContato.Text = "Editar/Adicionar Contatos";
            this.btnAddContato.UseVisualStyleBackColor = false;
            this.btnAddContato.Click += new System.EventHandler(this.btnAddContato_Click);
            // 
            // Salvar
            // 
            this.Salvar.BackColor = System.Drawing.Color.LimeGreen;
            this.Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salvar.ForeColor = System.Drawing.Color.White;
            this.Salvar.Location = new System.Drawing.Point(445, 234);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(165, 49);
            this.Salvar.TabIndex = 9;
            this.Salvar.Text = "Salvar Alterações";
            this.Salvar.UseVisualStyleBackColor = false;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(497, 22);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(113, 20);
            this.TxtId.TabIndex = 7;
            this.TxtId.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lista das Campanhas";
            // 
            // Btnvoltar
            // 
            this.Btnvoltar.BackColor = System.Drawing.Color.Crimson;
            this.Btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnvoltar.ForeColor = System.Drawing.Color.White;
            this.Btnvoltar.Location = new System.Drawing.Point(852, 330);
            this.Btnvoltar.Name = "Btnvoltar";
            this.Btnvoltar.Size = new System.Drawing.Size(113, 39);
            this.Btnvoltar.TabIndex = 9;
            this.Btnvoltar.Text = "Voltar";
            this.Btnvoltar.UseVisualStyleBackColor = false;
            this.Btnvoltar.Click += new System.EventHandler(this.Btnvoltar_Click);
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
            // campanhaBindingSource
            // 
            this.campanhaBindingSource.DataSource = typeof(SpanZapForms.Model.Campanha);
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 381);
            this.Controls.Add(this.Btnvoltar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DGVCampanhas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aguiar Bot";
            this.Load += new System.EventHandler(this.Editar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCampanhas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campanhaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNomeCamp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtSaudaDois;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSaudaUM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGVCampanhas;
        private System.Windows.Forms.RichTextBox txtTextoCampanha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddContato;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource campanhaBindingSource;
        private System.Windows.Forms.Button BtnDell;
        private System.Windows.Forms.Button Btnvoltar;
    }
}