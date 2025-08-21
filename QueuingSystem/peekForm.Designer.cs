namespace QueuingSystem
{
    partial class peekForm
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
            this.nowServingLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.nextInLine = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Now Serving";
            // 
            // nowServingLabel
            // 
            this.nowServingLabel.AutoSize = true;
            this.nowServingLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nowServingLabel.ForeColor = System.Drawing.Color.Teal;
            this.nowServingLabel.Location = new System.Drawing.Point(47, 127);
            this.nowServingLabel.Name = "nowServingLabel";
            this.nowServingLabel.Size = new System.Drawing.Size(62, 40);
            this.nowServingLabel.TabIndex = 1;
            this.nowServingLabel.Text = "P -";
            this.nowServingLabel.Click += new System.EventHandler(this.nowServingLabel_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.IndianRed;
            this.closeButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closeButton.Location = new System.Drawing.Point(83, 210);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(93, 39);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // nextInLine
            // 
            this.nextInLine.BackColor = System.Drawing.Color.Ivory;
            this.nextInLine.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextInLine.ForeColor = System.Drawing.Color.Teal;
            this.nextInLine.HideSelection = false;
            this.nextInLine.Location = new System.Drawing.Point(250, 45);
            this.nextInLine.Name = "nextInLine";
            this.nextInLine.Size = new System.Drawing.Size(143, 222);
            this.nextInLine.TabIndex = 3;
            this.nextInLine.UseCompatibleStateImageBehavior = false;
            this.nextInLine.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(259, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Next In Line";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // peekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(402, 279);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nextInLine);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.nowServingLabel);
            this.Controls.Add(this.label1);
            this.Name = "peekForm";
            this.Text = "NOW SERVING !!!";
            this.Load += new System.EventHandler(this.peekForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nowServingLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ListView nextInLine;
        private System.Windows.Forms.Label label2;
    }
}