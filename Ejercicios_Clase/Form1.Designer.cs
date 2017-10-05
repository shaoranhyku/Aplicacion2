namespace Ejercicios_Clase{
    partial class Form1{
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing){
            if (disposing && (components != null)){
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblResponse = new System.Windows.Forms.Label();
            this.cbxDayOfWeek = new System.Windows.Forms.ComboBox();
            this.lblDayOfWeek = new System.Windows.Forms.Label();
            this.nbrAge = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nbrAge)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(147, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(15, 58);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 13);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Edad";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(18, 132);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(15, 178);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(58, 13);
            this.lblResponse.TabIndex = 7;
            this.lblResponse.Text = "Respuesta";
            this.lblResponse.Visible = false;
            // 
            // cbxDayOfWeek
            // 
            this.cbxDayOfWeek.BackColor = System.Drawing.SystemColors.Window;
            this.cbxDayOfWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDayOfWeek.FormattingEnabled = true;
            this.cbxDayOfWeek.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.cbxDayOfWeek.Location = new System.Drawing.Point(147, 88);
            this.cbxDayOfWeek.Name = "cbxDayOfWeek";
            this.cbxDayOfWeek.Size = new System.Drawing.Size(100, 21);
            this.cbxDayOfWeek.TabIndex = 10;
            // 
            // lblDayOfWeek
            // 
            this.lblDayOfWeek.AutoSize = true;
            this.lblDayOfWeek.Location = new System.Drawing.Point(15, 96);
            this.lblDayOfWeek.Name = "lblDayOfWeek";
            this.lblDayOfWeek.Size = new System.Drawing.Size(89, 13);
            this.lblDayOfWeek.TabIndex = 11;
            this.lblDayOfWeek.Text = "Dia de la semana";
            // 
            // nbrAge
            // 
            this.nbrAge.Location = new System.Drawing.Point(147, 51);
            this.nbrAge.Name = "nbrAge";
            this.nbrAge.Size = new System.Drawing.Size(100, 20);
            this.nbrAge.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(359, 213);
            this.Controls.Add(this.nbrAge);
            this.Controls.Add(this.lblDayOfWeek);
            this.Controls.Add(this.cbxDayOfWeek);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Programa que hace cosas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbrAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.ComboBox cbxDayOfWeek;
        private System.Windows.Forms.Label lblDayOfWeek;
        private System.Windows.Forms.NumericUpDown nbrAge;
    }
}

