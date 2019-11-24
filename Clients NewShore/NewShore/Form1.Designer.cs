namespace NewShore
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnLoadClients = new System.Windows.Forms.Button();
            this.BtnLetters = new System.Windows.Forms.Button();
            this.BtnResults = new System.Windows.Forms.Button();
            this.RtbClients = new System.Windows.Forms.RichTextBox();
            this.RtbLetters = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbResultados = new System.Windows.Forms.RichTextBox();
            this.txtresultados = new System.Windows.Forms.TextBox();
            this.txtresultados1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnLoadClients
            // 
            this.BtnLoadClients.Location = new System.Drawing.Point(61, 58);
            this.BtnLoadClients.Name = "BtnLoadClients";
            this.BtnLoadClients.Size = new System.Drawing.Size(90, 31);
            this.BtnLoadClients.TabIndex = 0;
            this.BtnLoadClients.Text = "Load Clients";
            this.BtnLoadClients.UseVisualStyleBackColor = true;
            this.BtnLoadClients.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BtnLetters
            // 
            this.BtnLetters.Location = new System.Drawing.Point(61, 160);
            this.BtnLetters.Name = "BtnLetters";
            this.BtnLetters.Size = new System.Drawing.Size(90, 27);
            this.BtnLetters.TabIndex = 1;
            this.BtnLetters.Text = "Load Letters";
            this.BtnLetters.UseVisualStyleBackColor = true;
            this.BtnLetters.Click += new System.EventHandler(this.BtnLetters_Click);
            // 
            // BtnResults
            // 
            this.BtnResults.Location = new System.Drawing.Point(61, 253);
            this.BtnResults.Name = "BtnResults";
            this.BtnResults.Size = new System.Drawing.Size(90, 28);
            this.BtnResults.TabIndex = 2;
            this.BtnResults.Text = "Results";
            this.BtnResults.UseVisualStyleBackColor = true;
            this.BtnResults.Click += new System.EventHandler(this.BtnResults_Click);
            // 
            // RtbClients
            // 
            this.RtbClients.Location = new System.Drawing.Point(253, 49);
            this.RtbClients.Name = "RtbClients";
            this.RtbClients.Size = new System.Drawing.Size(124, 166);
            this.RtbClients.TabIndex = 4;
            this.RtbClients.Text = "";
            // 
            // RtbLetters
            // 
            this.RtbLetters.Location = new System.Drawing.Point(450, 49);
            this.RtbLetters.Name = "RtbLetters";
            this.RtbLetters.Size = new System.Drawing.Size(124, 166);
            this.RtbLetters.TabIndex = 5;
            this.RtbLetters.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Clients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Letters";
            // 
            // rtbResultados
            // 
            this.rtbResultados.Location = new System.Drawing.Point(241, 253);
            this.rtbResultados.Name = "rtbResultados";
            this.rtbResultados.Size = new System.Drawing.Size(333, 104);
            this.rtbResultados.TabIndex = 9;
            this.rtbResultados.Text = "";
            // 
            // txtresultados
            // 
            this.txtresultados.Location = new System.Drawing.Point(226, 363);
            this.txtresultados.Name = "txtresultados";
            this.txtresultados.Size = new System.Drawing.Size(325, 20);
            this.txtresultados.TabIndex = 10;
            // 
            // txtresultados1
            // 
            this.txtresultados1.Location = new System.Drawing.Point(226, 389);
            this.txtresultados1.Name = "txtresultados1";
            this.txtresultados1.Size = new System.Drawing.Size(325, 20);
            this.txtresultados1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 435);
            this.Controls.Add(this.txtresultados1);
            this.Controls.Add(this.txtresultados);
            this.Controls.Add(this.rtbResultados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RtbLetters);
            this.Controls.Add(this.RtbClients);
            this.Controls.Add(this.BtnResults);
            this.Controls.Add(this.BtnLetters);
            this.Controls.Add(this.BtnLoadClients);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLoadClients;
        private System.Windows.Forms.Button BtnLetters;
        private System.Windows.Forms.Button BtnResults;
        private System.Windows.Forms.RichTextBox RtbClients;
        private System.Windows.Forms.RichTextBox RtbLetters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbResultados;
        private System.Windows.Forms.TextBox txtresultados;
        private System.Windows.Forms.TextBox txtresultados1;
    }
}

