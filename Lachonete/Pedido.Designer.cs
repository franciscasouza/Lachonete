
namespace Lachonete
{
    partial class Pedido
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPnome = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPId = new System.Windows.Forms.TextBox();
            this.dataGridViewPedido = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPedido = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Cliente:";
            // 
            // txtPnome
            // 
            this.txtPnome.BackColor = System.Drawing.Color.Wheat;
            this.txtPnome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPnome.Location = new System.Drawing.Point(197, 91);
            this.txtPnome.Name = "txtPnome";
            this.txtPnome.Size = new System.Drawing.Size(307, 19);
            this.txtPnome.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lachonete.Properties.Resources.cardapio;
            this.pictureBox1.Location = new System.Drawing.Point(694, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 499);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo do Pedido";
            // 
            // txtPId
            // 
            this.txtPId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPId.Location = new System.Drawing.Point(197, 151);
            this.txtPId.Name = "txtPId";
            this.txtPId.Size = new System.Drawing.Size(104, 26);
            this.txtPId.TabIndex = 4;
            // 
            // dataGridViewPedido
            // 
            this.dataGridViewPedido.AllowUserToAddRows = false;
            this.dataGridViewPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewPedido.Location = new System.Drawing.Point(7, 222);
            this.dataGridViewPedido.Name = "dataGridViewPedido";
            this.dataGridViewPedido.Size = new System.Drawing.Size(681, 371);
            this.dataGridViewPedido.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Descrição Produto";
            this.Column1.Name = "Column1";
            this.Column1.Width = 500;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Valor Unitário";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // btnPedido
            // 
            this.btnPedido.BackColor = System.Drawing.Color.Lime;
            this.btnPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.Location = new System.Drawing.Point(551, 673);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(137, 30);
            this.btnPedido.TabIndex = 6;
            this.btnPedido.Text = "Fechar Pedido";
            this.btnPedido.UseVisualStyleBackColor = false;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Maroon;
            this.txtTotal.Location = new System.Drawing.Point(176, 631);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 19);
            this.txtTotal.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(44, 630);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total a Pagar: ";
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 727);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.dataGridViewPedido);
            this.Controls.Add(this.txtPId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPnome);
            this.Controls.Add(this.label1);
            this.Name = "Pedido";
            this.Text = "Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPnome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPId;
        private System.Windows.Forms.DataGridView dataGridViewPedido;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
    }
}