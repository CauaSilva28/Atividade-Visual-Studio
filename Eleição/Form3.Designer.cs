namespace Eleição
{
    partial class frmcomb
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
            this.btncalc = new System.Windows.Forms.Button();
            this.btnlimp = new System.Windows.Forms.Button();
            this.btnvolt = new System.Windows.Forms.Button();
            this.lblcomb = new System.Windows.Forms.Label();
            this.lbllitros = new System.Windows.Forms.Label();
            this.lblvalor = new System.Windows.Forms.Label();
            this.txtcomb = new System.Windows.Forms.TextBox();
            this.txtlitros = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncalc
            // 
            this.btncalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc.Location = new System.Drawing.Point(112, 311);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(121, 53);
            this.btncalc.TabIndex = 0;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnlimp
            // 
            this.btnlimp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimp.Location = new System.Drawing.Point(331, 311);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(121, 53);
            this.btnlimp.TabIndex = 1;
            this.btnlimp.Text = "Limpar";
            this.btnlimp.UseVisualStyleBackColor = true;
            this.btnlimp.Click += new System.EventHandler(this.btnlimp_Click);
            // 
            // btnvolt
            // 
            this.btnvolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolt.Location = new System.Drawing.Point(558, 311);
            this.btnvolt.Name = "btnvolt";
            this.btnvolt.Size = new System.Drawing.Size(121, 53);
            this.btnvolt.TabIndex = 2;
            this.btnvolt.Text = "Voltar";
            this.btnvolt.UseVisualStyleBackColor = true;
            this.btnvolt.Click += new System.EventHandler(this.btnvolt_Click);
            // 
            // lblcomb
            // 
            this.lblcomb.AutoSize = true;
            this.lblcomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomb.Location = new System.Drawing.Point(203, 103);
            this.lblcomb.Name = "lblcomb";
            this.lblcomb.Size = new System.Drawing.Size(335, 24);
            this.lblcomb.TabIndex = 3;
            this.lblcomb.Text = "Digite A para álcool ou G para gasolina";
            // 
            // lbllitros
            // 
            this.lbllitros.AutoSize = true;
            this.lbllitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllitros.Location = new System.Drawing.Point(204, 151);
            this.lbllitros.Name = "lbllitros";
            this.lbllitros.Size = new System.Drawing.Size(241, 24);
            this.lbllitros.TabIndex = 4;
            this.lbllitros.Text = "Digite a quantidade de litros";
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalor.Location = new System.Drawing.Point(204, 204);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(148, 24);
            this.lblvalor.TabIndex = 5;
            this.lblvalor.Text = "Valor a ser pago";
            // 
            // txtcomb
            // 
            this.txtcomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomb.Location = new System.Drawing.Point(544, 103);
            this.txtcomb.Name = "txtcomb";
            this.txtcomb.Size = new System.Drawing.Size(100, 24);
            this.txtcomb.TabIndex = 6;
            // 
            // txtlitros
            // 
            this.txtlitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlitros.Location = new System.Drawing.Point(451, 151);
            this.txtlitros.Name = "txtlitros";
            this.txtlitros.Size = new System.Drawing.Size(100, 24);
            this.txtlitros.TabIndex = 7;
            // 
            // txtvalor
            // 
            this.txtvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor.Location = new System.Drawing.Point(358, 204);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.ReadOnly = true;
            this.txtvalor.Size = new System.Drawing.Size(100, 24);
            this.txtvalor.TabIndex = 8;
            // 
            // frmcomb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtlitros);
            this.Controls.Add(this.txtcomb);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.lbllitros);
            this.Controls.Add(this.lblcomb);
            this.Controls.Add(this.btnvolt);
            this.Controls.Add(this.btnlimp);
            this.Controls.Add(this.btncalc);
            this.Name = "frmcomb";
            this.Text = "Combustível";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnlimp;
        private System.Windows.Forms.Button btnvolt;
        private System.Windows.Forms.Label lblcomb;
        private System.Windows.Forms.Label lbllitros;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.TextBox txtcomb;
        private System.Windows.Forms.TextBox txtlitros;
        private System.Windows.Forms.TextBox txtvalor;
    }
}