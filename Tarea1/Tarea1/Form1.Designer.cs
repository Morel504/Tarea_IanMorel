namespace Tarea1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumTextBox = new System.Windows.Forms.TextBox();
            this.PoITextBox = new System.Windows.Forms.TextBox();
            this.PoNTextBox = new System.Windows.Forms.TextBox();
            this.EjecutarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese El Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "¿Es Par o Impar?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "¿Positivo o Negativo?";
            // 
            // NumTextBox
            // 
            this.NumTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.NumTextBox.Location = new System.Drawing.Point(383, 72);
            this.NumTextBox.Name = "NumTextBox";
            this.NumTextBox.Size = new System.Drawing.Size(279, 26);
            this.NumTextBox.TabIndex = 3;
            // 
            // PoITextBox
            // 
            this.PoITextBox.Location = new System.Drawing.Point(383, 197);
            this.PoITextBox.Name = "PoITextBox";
            this.PoITextBox.Size = new System.Drawing.Size(279, 26);
            this.PoITextBox.TabIndex = 4;
            // 
            // PoNTextBox
            // 
            this.PoNTextBox.Location = new System.Drawing.Point(383, 241);
            this.PoNTextBox.Name = "PoNTextBox";
            this.PoNTextBox.Size = new System.Drawing.Size(279, 26);
            this.PoNTextBox.TabIndex = 5;
            // 
            // EjecutarButton
            // 
            this.EjecutarButton.Location = new System.Drawing.Point(429, 123);
            this.EjecutarButton.Name = "EjecutarButton";
            this.EjecutarButton.Size = new System.Drawing.Size(195, 44);
            this.EjecutarButton.TabIndex = 6;
            this.EjecutarButton.Text = "Ejecutar";
            this.EjecutarButton.UseVisualStyleBackColor = true;
            this.EjecutarButton.Click += new System.EventHandler(this.EjecutarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 380);
            this.Controls.Add(this.EjecutarButton);
            this.Controls.Add(this.PoNTextBox);
            this.Controls.Add(this.PoITextBox);
            this.Controls.Add(this.NumTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumTextBox;
        private System.Windows.Forms.TextBox PoITextBox;
        private System.Windows.Forms.TextBox PoNTextBox;
        private System.Windows.Forms.Button EjecutarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

