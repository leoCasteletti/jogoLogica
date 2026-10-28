namespace ProvaTLPII_2B_107081
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelnome = new System.Windows.Forms.Label();
            this.labelnumero = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.numericPalpite = new System.Windows.Forms.NumericUpDown();
            this.buttonVerificar = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.resultadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeInformadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroGeradoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericPalpite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jogo de Lógica";
            // 
            // labelnome
            // 
            this.labelnome.AutoSize = true;
            this.labelnome.Location = new System.Drawing.Point(18, 243);
            this.labelnome.Name = "labelnome";
            this.labelnome.Size = new System.Drawing.Size(75, 13);
            this.labelnome.TabIndex = 1;
            this.labelnome.Text = "Digite o nome:";
            // 
            // labelnumero
            // 
            this.labelnumero.AutoSize = true;
            this.labelnumero.Location = new System.Drawing.Point(185, 243);
            this.labelnumero.Name = "labelnumero";
            this.labelnumero.Size = new System.Drawing.Size(92, 13);
            this.labelnumero.TabIndex = 2;
            this.labelnumero.Text = "Número correto é:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 259);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            // 
            // numericPalpite
            // 
            this.numericPalpite.Location = new System.Drawing.Point(188, 260);
            this.numericPalpite.Name = "numericPalpite";
            this.numericPalpite.Size = new System.Drawing.Size(120, 20);
            this.numericPalpite.TabIndex = 4;
            // 
            // buttonVerificar
            // 
            this.buttonVerificar.Location = new System.Drawing.Point(406, 256);
            this.buttonVerificar.Name = "buttonVerificar";
            this.buttonVerificar.Size = new System.Drawing.Size(75, 23);
            this.buttonVerificar.TabIndex = 5;
            this.buttonVerificar.Text = "Verificar";
            this.buttonVerificar.UseVisualStyleBackColor = true;
            this.buttonVerificar.Click += new System.EventHandler(this.buttonVerificar_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.AutoGenerateColumns = false;
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dataHoraDataGridViewTextBoxColumn,
            this.nomeInformadoDataGridViewTextBoxColumn,
            this.numeroGeradoDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn});
            this.dgvResultados.DataSource = this.resultadoBindingSource;
            this.dgvResultados.Location = new System.Drawing.Point(21, 29);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.Size = new System.Drawing.Size(590, 151);
            this.dgvResultados.TabIndex = 6;
            // 
            // resultadoBindingSource
            // 
            this.resultadoBindingSource.DataSource = typeof(ProvaTLPII_2B_107081.Resultado);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataHoraDataGridViewTextBoxColumn
            // 
            this.dataHoraDataGridViewTextBoxColumn.DataPropertyName = "DataHora";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataHoraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataHoraDataGridViewTextBoxColumn.HeaderText = "Data e Hora";
            this.dataHoraDataGridViewTextBoxColumn.Name = "dataHoraDataGridViewTextBoxColumn";
            this.dataHoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeInformadoDataGridViewTextBoxColumn
            // 
            this.nomeInformadoDataGridViewTextBoxColumn.DataPropertyName = "NomeInformado";
            this.nomeInformadoDataGridViewTextBoxColumn.HeaderText = "Jogador";
            this.nomeInformadoDataGridViewTextBoxColumn.Name = "nomeInformadoDataGridViewTextBoxColumn";
            this.nomeInformadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroGeradoDataGridViewTextBoxColumn
            // 
            this.numeroGeradoDataGridViewTextBoxColumn.DataPropertyName = "NumeroGerado";
            this.numeroGeradoDataGridViewTextBoxColumn.HeaderText = "N° Escolhido";
            this.numeroGeradoDataGridViewTextBoxColumn.Name = "numeroGeradoDataGridViewTextBoxColumn";
            this.numeroGeradoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "Resultado";
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            this.resultDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 294);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.buttonVerificar);
            this.Controls.Add(this.numericPalpite);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labelnumero);
            this.Controls.Add(this.labelnome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "PROVA TLPII 2B 107081";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericPalpite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelnome;
        private System.Windows.Forms.Label labelnumero;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.NumericUpDown numericPalpite;
        private System.Windows.Forms.Button buttonVerificar;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.BindingSource resultadoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeInformadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroGeradoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
    }
}

