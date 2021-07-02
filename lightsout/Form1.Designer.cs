namespace lightsout
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
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRestart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMoves = new System.Windows.Forms.TextBox();
            this.btnLights = new System.Windows.Forms.Button[GridSize,GridSize];
            for (int row = 0; row < GridSize; row++)
                for( int col = 0; col < GridSize; col++)
                    this.btnLights[row,col] = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(13, ((35*GridSize)+30));
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 0;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.RestartClickHandler);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, ((35 * GridSize) + 30));
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.Text = "Moves:";
            // 
            // txtMoves
            // 
            this.txtMoves.Location = new System.Drawing.Point(170, ((35 * GridSize) + 30));
            this.txtMoves.Name = "txtMoves";
            this.txtMoves.ReadOnly = true;
            this.txtMoves.Size = new System.Drawing.Size(60, 20);
            // 
            // btnLights
            // 
            for (int y = 0; y < GridSize; y++)
            {
                for(int x = 0; x < GridSize; x++ )
                {
                    this.btnLights[x,y].Location = new System.Drawing.Point(13+(35*x), 13+(35*y));
                    this.btnLights[x,y].Name = "btnLights" + x.ToString() + y.ToString();
                    this.btnLights[x,y].Size = new System.Drawing.Size(30, 30);
                    this.btnLights[x,y].TabIndex = x + (y*GridSize) + 1;
                    this.btnLights[x,y].BackColor = onColor;
                    this.btnLights[x,y].Click += new System.EventHandler(this.LightsClickHandler);
                }
            }
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 
                               ( GridSize < 7 ? 240 : ((35*GridSize)+20)), 
                               ((35*GridSize) + 65));
            for (int row = 0; row < GridSize; row++)
                for (int col = 0; col < GridSize; col++ )
                    this.Controls.Add(this.btnLights[row,col]);
            this.Controls.Add(this.txtMoves);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Lights Out";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMoves;
        private System.Windows.Forms.Button [,] btnLights;
    }
}

