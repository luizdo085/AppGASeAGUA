﻿namespace AppGASeAGUA.br.com.projeto.VIEW
{
    partial class FrmEntrega
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
            panel1 = new Panel();
            label1 = new Label();
            txtobs = new TextBox();
            label5 = new Label();
            btnfinalizar = new Button();
            txttotal = new TextBox();
            label4 = new Label();
            txttroco = new TextBox();
            label3 = new Label();
            label8 = new Label();
            txtfrpagamento = new ComboBox();
            ImprimirVenda = new System.Drawing.Printing.PrintDocument();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.fundo_login_certo;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(496, 110);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(100, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(310, 56);
            label1.TabIndex = 0;
            label1.Text = "Pagamentos";
            // 
            // txtobs
            // 
            txtobs.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtobs.Location = new Point(244, 162);
            txtobs.Multiline = true;
            txtobs.Name = "txtobs";
            txtobs.Size = new Size(201, 138);
            txtobs.TabIndex = 52;
            txtobs.TextChanged += txtobs_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(251, 141);
            label5.Name = "label5";
            label5.Size = new Size(45, 18);
            label5.TabIndex = 51;
            label5.Text = "Obs.:";
            // 
            // btnfinalizar
            // 
            btnfinalizar.BackColor = Color.Navy;
            btnfinalizar.FlatStyle = FlatStyle.Flat;
            btnfinalizar.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnfinalizar.ForeColor = Color.White;
            btnfinalizar.Location = new Point(103, 319);
            btnfinalizar.Name = "btnfinalizar";
            btnfinalizar.Size = new Size(310, 47);
            btnfinalizar.TabIndex = 50;
            btnfinalizar.Text = "Finalizar Venda";
            btnfinalizar.UseVisualStyleBackColor = false;
            btnfinalizar.Click += btnfinalizar_Click;
            // 
            // txttotal
            // 
            txttotal.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttotal.Location = new Point(55, 274);
            txttotal.Name = "txttotal";
            txttotal.ReadOnly = true;
            txttotal.Size = new Size(163, 26);
            txttotal.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(59, 253);
            label4.Name = "label4";
            label4.Size = new Size(44, 18);
            label4.TabIndex = 48;
            label4.Text = "Total:";
            // 
            // txttroco
            // 
            txttroco.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttroco.Location = new Point(55, 218);
            txttroco.Name = "txttroco";
            txttroco.ReadOnly = true;
            txttroco.Size = new Size(163, 26);
            txttroco.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(55, 197);
            label3.Name = "label3";
            label3.Size = new Size(137, 18);
            label3.TabIndex = 46;
            label3.Text = "Troco pra quantos:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(55, 141);
            label8.Name = "label8";
            label8.Size = new Size(163, 18);
            label8.TabIndex = 42;
            label8.Text = "Forma de pagamento:";
            // 
            // txtfrpagamento
            // 
            txtfrpagamento.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtfrpagamento.FormattingEnabled = true;
            txtfrpagamento.Items.AddRange(new object[] { "Dinheiro", "Cartão", "Pix" });
            txtfrpagamento.Location = new Point(55, 162);
            txtfrpagamento.Name = "txtfrpagamento";
            txtfrpagamento.Size = new Size(163, 26);
            txtfrpagamento.TabIndex = 54;
            txtfrpagamento.SelectedIndexChanged += txtfrpagamento_SelectedIndexChanged;
            // 
            // ImprimirVenda
            // 
            ImprimirVenda.PrintPage += ImprimirVenda_PrintPage;
            // 
            // FrmEntrega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 432);
            Controls.Add(txtfrpagamento);
            Controls.Add(txtobs);
            Controls.Add(label5);
            Controls.Add(btnfinalizar);
            Controls.Add(txttotal);
            Controls.Add(label4);
            Controls.Add(txttroco);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(panel1);
            Name = "FrmEntrega";
            Text = "FrmEntrega";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtobs;
        private Label label5;
        private Button btnfinalizar;
        public TextBox txttotal;
        private Label label4;
        private TextBox txttroco;
        private Label label3;
        private Label label8;
        private ComboBox txtfrpagamento;
        private System.Drawing.Printing.PrintDocument ImprimirVenda;
    }
}