namespace Eleição
{
    partial class frmeleicao
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
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblganhador = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtganhador = new System.Windows.Forms.TextBox();
            this.btnvoto1 = new System.Windows.Forms.Button();
            this.btnvoto3 = new System.Windows.Forms.Button();
            this.btnvoto2 = new System.Windows.Forms.Button();
            this.lblnome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnfinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinalizar.Location = new System.Drawing.Point(170, 315);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(129, 56);
            this.btnfinalizar.TabIndex = 1;
            this.btnfinalizar.Text = "Finalizar";
            this.btnfinalizar.UseVisualStyleBackColor = false;
            this.btnfinalizar.Click += new System.EventHandler(this.btnfinalizar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(340, 315);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(129, 56);
            this.btnlimpar.TabIndex = 2;
            this.btnlimpar.Text = "Reiniciar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(512, 315);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(129, 56);
            this.btnvoltar.TabIndex = 3;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(262, 178);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(190, 24);
            this.lbltotal.TabIndex = 5;
            this.lbltotal.Text = "O total de votos foi de";
            // 
            // lblganhador
            // 
            this.lblganhador.AutoSize = true;
            this.lblganhador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblganhador.Location = new System.Drawing.Point(69, 220);
            this.lblganhador.Name = "lblganhador";
            this.lblganhador.Size = new System.Drawing.Size(135, 24);
            this.lblganhador.TabIndex = 6;
            this.lblganhador.Text = "O ganhador foi";
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(458, 179);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(81, 22);
            this.txttotal.TabIndex = 7;
            // 
            // txtganhador
            // 
            this.txtganhador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtganhador.Location = new System.Drawing.Point(210, 222);
            this.txtganhador.Name = "txtganhador";
            this.txtganhador.ReadOnly = true;
            this.txtganhador.Size = new System.Drawing.Size(491, 22);
            this.txtganhador.TabIndex = 9;
            // 
            // btnvoto1
            // 
            this.btnvoto1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnvoto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoto1.Location = new System.Drawing.Point(40, 46);
            this.btnvoto1.Name = "btnvoto1";
            this.btnvoto1.Size = new System.Drawing.Size(213, 44);
            this.btnvoto1.TabIndex = 12;
            this.btnvoto1.Text = "Votar em José Nascimento";
            this.btnvoto1.UseVisualStyleBackColor = false;
            this.btnvoto1.Click += new System.EventHandler(this.btnvoto1_Click);
            // 
            // btnvoto3
            // 
            this.btnvoto3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnvoto3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoto3.Location = new System.Drawing.Point(541, 46);
            this.btnvoto3.Name = "btnvoto3";
            this.btnvoto3.Size = new System.Drawing.Size(213, 44);
            this.btnvoto3.TabIndex = 14;
            this.btnvoto3.Text = "Votar em João da Tapioca";
            this.btnvoto3.UseVisualStyleBackColor = false;
            this.btnvoto3.Click += new System.EventHandler(this.btnvoto3_Click);
            // 
            // btnvoto2
            // 
            this.btnvoto2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnvoto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoto2.Location = new System.Drawing.Point(290, 46);
            this.btnvoto2.Name = "btnvoto2";
            this.btnvoto2.Size = new System.Drawing.Size(213, 44);
            this.btnvoto2.TabIndex = 15;
            this.btnvoto2.Text = "Votar em Maria Juruma";
            this.btnvoto2.UseVisualStyleBackColor = false;
            this.btnvoto2.Click += new System.EventHandler(this.btnvoto2_Click_1);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.ForeColor = System.Drawing.Color.Green;
            this.lblnome.Location = new System.Drawing.Point(278, 123);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(21, 20);
            this.lblnome.TabIndex = 16;
            this.lblnome.Text = "...";
            this.lblnome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmeleicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.btnvoto2);
            this.Controls.Add(this.btnvoto3);
            this.Controls.Add(this.btnvoto1);
            this.Controls.Add(this.txtganhador);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.lblganhador);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnfinalizar);
            this.Name = "frmeleicao";
            this.Text = "Eleição";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnfinalizar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblganhador;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtganhador;
        private System.Windows.Forms.Button btnvoto1;
        private System.Windows.Forms.Button btnvoto3;
        private System.Windows.Forms.Button btnvoto2;
        private System.Windows.Forms.Label lblnome;
    }
}