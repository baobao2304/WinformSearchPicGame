namespace PhamVanLeBao_2001170836_AppSmart_BT2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxMatrix = new System.Windows.Forms.TextBox();
            this.btnCreatePic = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = " Nhap so hinh :";
            // 
            // txtMaxMatrix
            // 
            this.txtMaxMatrix.Location = new System.Drawing.Point(139, 24);
            this.txtMaxMatrix.Name = "txtMaxMatrix";
            this.txtMaxMatrix.Size = new System.Drawing.Size(175, 22);
            this.txtMaxMatrix.TabIndex = 1;
            this.txtMaxMatrix.TextChanged += new System.EventHandler(this.txtMaxMatrix_TextChanged);
            this.txtMaxMatrix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxMatrix_KeyPress);
            // 
            // btnCreatePic
            // 
            this.btnCreatePic.Location = new System.Drawing.Point(369, 24);
            this.btnCreatePic.Name = "btnCreatePic";
            this.btnCreatePic.Size = new System.Drawing.Size(75, 23);
            this.btnCreatePic.TabIndex = 2;
            this.btnCreatePic.Text = "Tao Hinh";
            this.btnCreatePic.UseVisualStyleBackColor = true;
            this.btnCreatePic.Click += new System.EventHandler(this.btnCreatePic_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(484, 24);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(75, 23);
            this.btnStartGame.TabIndex = 3;
            this.btnStartGame.Text = "Bat Dau";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(32, 57);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1292, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 684);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnCreatePic);
            this.Controls.Add(this.txtMaxMatrix);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxMatrix;
        private System.Windows.Forms.Button btnCreatePic;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

