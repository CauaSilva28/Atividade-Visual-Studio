namespace Eleição
{
    partial class frmtabuada
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
            this.lblnum = new System.Windows.Forms.Label();
            this.lbltabuada = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txttabuada = new System.Windows.Forms.TextBox();
            this.btncalcular2 = new System.Windows.Forms.Button();
            this.btncalcular3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum.Location = new System.Drawing.Point(112, 72);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(304, 24);
            this.lblnum.TabIndex = 0;
            this.lblnum.Text = "Digite o número para ver a tabuada";
            // 
            // lbltabuada
            // 
            this.lbltabuada.AutoSize = true;
            this.lbltabuada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltabuada.Location = new System.Drawing.Point(490, 72);
            this.lbltabuada.Name = "lbltabuada";
            this.lbltabuada.Size = new System.Drawing.Size(85, 24);
            this.lbltabuada.TabIndex = 1;
            this.lbltabuada.Text = "Tabuada";
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(31, 366);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(115, 54);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Calcular com while";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(494, 371);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(115, 46);
            this.btnlimpar.TabIndex = 3;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(646, 371);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(115, 46);
            this.btnvoltar.TabIndex = 4;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // txtnum
            // 
            this.txtnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum.Location = new System.Drawing.Point(193, 99);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(112, 22);
            this.txtnum.TabIndex = 5;
            // 
            // txttabuada
            // 
            this.txttabuada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttabuada.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txttabuada.Location = new System.Drawing.Point(485, 99);
            this.txttabuada.Multiline = true;
            this.txttabuada.Name = "txttabuada";
            this.txttabuada.ReadOnly = true;
            this.txttabuada.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txttabuada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txttabuada.Size = new System.Drawing.Size(101, 199);
            this.txttabuada.TabIndex = 6;
            // 
            // btncalcular2
            // 
            this.btncalcular2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular2.Location = new System.Drawing.Point(182, 366);
            this.btncalcular2.Name = "btncalcular2";
            this.btncalcular2.Size = new System.Drawing.Size(115, 54);
            this.btncalcular2.TabIndex = 7;
            this.btncalcular2.Text = "Calcular com do while";
            this.btncalcular2.UseVisualStyleBackColor = true;
            this.btncalcular2.Click += new System.EventHandler(this.btncalcular2_Click);
            // 
            // btncalcular3
            // 
            this.btncalcular3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular3.Location = new System.Drawing.Point(337, 366);
            this.btncalcular3.Name = "btncalcular3";
            this.btncalcular3.Size = new System.Drawing.Size(115, 54);
            this.btncalcular3.TabIndex = 8;
            this.btncalcular3.Text = "Calcular com for";
            this.btncalcular3.UseVisualStyleBackColor = true;
            this.btncalcular3.Click += new System.EventHandler(this.btncalcular3_Click);
            // 
            // frmtabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalcular3);
            this.Controls.Add(this.btncalcular2);
            this.Controls.Add(this.txttabuada);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lbltabuada);
            this.Controls.Add(this.lblnum);
            this.Name = "frmtabuada";
            this.Text = "Tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lbltabuada;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txttabuada;
        private System.Windows.Forms.Button btncalcular2;
        private System.Windows.Forms.Button btncalcular3;
    }
}