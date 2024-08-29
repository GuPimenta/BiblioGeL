namespace Biblio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DGridList = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Título = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            Ano = new DataGridViewTextBoxColumn();
            Gênero = new DataGridViewTextBoxColumn();
            ISBN = new DataGridViewTextBoxColumn();
            TBoxTitulo = new TextBox();
            TBoxAutor = new TextBox();
            TBoxAno = new TextBox();
            TBoxGenero = new TextBox();
            TBoxISBN = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            BAdicionar = new Button();
            BRemover = new Button();
            BEditar = new Button();
            TBoxStatus = new TextBox();
            TBoxID = new TextBox();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGridList).BeginInit();
            SuspendLayout();
            // 
            // DGridList
            // 
            DGridList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGridList.Columns.AddRange(new DataGridViewColumn[] { ID, Título, Autor, Ano, Gênero, ISBN });
            DGridList.Location = new Point(381, 16);
            DGridList.Margin = new Padding(3, 4, 3, 4);
            DGridList.Name = "DGridList";
            DGridList.RowHeadersWidth = 51;
            DGridList.Size = new Size(804, 568);
            DGridList.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 125;
            // 
            // Título
            // 
            Título.HeaderText = "Título";
            Título.MinimumWidth = 6;
            Título.Name = "Título";
            Título.ReadOnly = true;
            Título.Width = 125;
            // 
            // Autor
            // 
            Autor.HeaderText = "Autor";
            Autor.MinimumWidth = 6;
            Autor.Name = "Autor";
            Autor.ReadOnly = true;
            Autor.Width = 125;
            // 
            // Ano
            // 
            Ano.HeaderText = "Ano";
            Ano.MinimumWidth = 6;
            Ano.Name = "Ano";
            Ano.ReadOnly = true;
            Ano.Width = 125;
            // 
            // Gênero
            // 
            Gênero.HeaderText = "Gênero";
            Gênero.MinimumWidth = 6;
            Gênero.Name = "Gênero";
            Gênero.ReadOnly = true;
            Gênero.Width = 125;
            // 
            // ISBN
            // 
            ISBN.HeaderText = "ISBN";
            ISBN.MinimumWidth = 6;
            ISBN.Name = "ISBN";
            ISBN.ReadOnly = true;
            ISBN.Width = 125;
            // 
            // TBoxTitulo
            // 
            TBoxTitulo.Location = new Point(66, 77);
            TBoxTitulo.Margin = new Padding(3, 4, 3, 4);
            TBoxTitulo.Name = "TBoxTitulo";
            TBoxTitulo.Size = new Size(307, 27);
            TBoxTitulo.TabIndex = 1;
            // 
            // TBoxAutor
            // 
            TBoxAutor.Location = new Point(66, 112);
            TBoxAutor.Margin = new Padding(3, 4, 3, 4);
            TBoxAutor.Name = "TBoxAutor";
            TBoxAutor.Size = new Size(307, 27);
            TBoxAutor.TabIndex = 2;
            // 
            // TBoxAno
            // 
            TBoxAno.Location = new Point(66, 147);
            TBoxAno.Margin = new Padding(3, 4, 3, 4);
            TBoxAno.Name = "TBoxAno";
            TBoxAno.Size = new Size(307, 27);
            TBoxAno.TabIndex = 3;
            // 
            // TBoxGenero
            // 
            TBoxGenero.Location = new Point(66, 182);
            TBoxGenero.Margin = new Padding(3, 4, 3, 4);
            TBoxGenero.Name = "TBoxGenero";
            TBoxGenero.Size = new Size(307, 27);
            TBoxGenero.TabIndex = 4;
            // 
            // TBoxISBN
            // 
            TBoxISBN.Location = new Point(66, 217);
            TBoxISBN.Margin = new Padding(3, 4, 3, 4);
            TBoxISBN.Name = "TBoxISBN";
            TBoxISBN.Size = new Size(307, 27);
            TBoxISBN.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 80);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 6;
            label1.Text = "Título";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 115);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 7;
            label2.Text = "Autor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 185);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 8;
            label3.Text = "Gênero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 150);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 9;
            label4.Text = "Ano";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 220);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 10;
            label5.Text = "ISBN";
            // 
            // BAdicionar
            // 
            BAdicionar.Location = new Point(8, 329);
            BAdicionar.Margin = new Padding(3, 4, 3, 4);
            BAdicionar.Name = "BAdicionar";
            BAdicionar.Size = new Size(118, 56);
            BAdicionar.TabIndex = 11;
            BAdicionar.Text = "Adicionar";
            BAdicionar.UseVisualStyleBackColor = true;
            BAdicionar.Click += BAdicionar_Click;
            // 
            // BRemover
            // 
            BRemover.Location = new Point(255, 329);
            BRemover.Margin = new Padding(3, 4, 3, 4);
            BRemover.Name = "BRemover";
            BRemover.Size = new Size(118, 56);
            BRemover.TabIndex = 12;
            BRemover.Text = "Remover";
            BRemover.UseVisualStyleBackColor = true;
            BRemover.Click += BRemover_Click;
            // 
            // BEditar
            // 
            BEditar.Location = new Point(132, 329);
            BEditar.Margin = new Padding(3, 4, 3, 4);
            BEditar.Name = "BEditar";
            BEditar.Size = new Size(118, 56);
            BEditar.TabIndex = 13;
            BEditar.Text = "Editar";
            BEditar.UseVisualStyleBackColor = true;
            BEditar.Click += BEditar_Click;
            // 
            // TBoxStatus
            // 
            TBoxStatus.Location = new Point(66, 252);
            TBoxStatus.Margin = new Padding(3, 4, 3, 4);
            TBoxStatus.Name = "TBoxStatus";
            TBoxStatus.ReadOnly = true;
            TBoxStatus.Size = new Size(307, 27);
            TBoxStatus.TabIndex = 14;
            // 
            // TBoxID
            // 
            TBoxID.Location = new Point(66, 42);
            TBoxID.Margin = new Padding(3, 4, 3, 4);
            TBoxID.Name = "TBoxID";
            TBoxID.Size = new Size(307, 27);
            TBoxID.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 45);
            label6.Name = "label6";
            label6.Size = new Size(24, 20);
            label6.TabIndex = 16;
            label6.Text = "ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(100, 9);
            label7.Name = "label7";
            label7.Size = new Size(204, 20);
            label7.TabIndex = 17;
            label7.Text = "Sistema Biblioteca Fácil - GeL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 600);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(TBoxID);
            Controls.Add(TBoxStatus);
            Controls.Add(BEditar);
            Controls.Add(BRemover);
            Controls.Add(BAdicionar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TBoxISBN);
            Controls.Add(TBoxGenero);
            Controls.Add(TBoxAno);
            Controls.Add(TBoxAutor);
            Controls.Add(TBoxTitulo);
            Controls.Add(DGridList);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DGridList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGridList;
        private TextBox TBoxTitulo;
        private TextBox TBoxAutor;
        private TextBox TBoxAno;
        private TextBox TBoxGenero;
        private TextBox TBoxISBN;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button BAdicionar;
        private Button BRemover;
        private Button BEditar;
        private TextBox TBoxStatus;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Título;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Ano;
        private DataGridViewTextBoxColumn Gênero;
        private DataGridViewTextBoxColumn ISBN;
        private TextBox TBoxID;
        private Label label6;
        private Label label7;
    }
}
