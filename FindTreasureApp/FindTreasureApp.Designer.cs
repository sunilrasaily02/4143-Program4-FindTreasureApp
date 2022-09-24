using System;
using System.Drawing;

namespace FindTreasureApp
{
    partial class FindTreasureApp
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gameHeader = new System.Windows.Forms.GroupBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.gameFooter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.gameHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameHeader
            // 
            this.gameHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gameHeader.Controls.Add(this.scoreLabel);
            this.gameHeader.Location = new System.Drawing.Point(-226, 0);
            this.gameHeader.Margin = new System.Windows.Forms.Padding(4);
            this.gameHeader.Name = "gameHeader";
            this.gameHeader.Padding = new System.Windows.Forms.Padding(4);
            this.gameHeader.Size = new System.Drawing.Size(1067, 62);
            this.gameHeader.TabIndex = 0;
            this.gameHeader.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(429, 11);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(178, 46);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Score: 0";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameFooter
            // 
            this.gameFooter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gameFooter.Location = new System.Drawing.Point(-226, 441);
            this.gameFooter.Margin = new System.Windows.Forms.Padding(4);
            this.gameFooter.Name = "gameFooter";
            this.gameFooter.Padding = new System.Windows.Forms.Padding(4);
            this.gameFooter.Size = new System.Drawing.Size(0, 0);
            this.gameFooter.TabIndex = 1;
            this.gameFooter.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Game";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(235, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoadGame);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxX);
            this.groupBox1.Controls.Add(this.textBoxY);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 636);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(341, 172);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 22);
            this.textBoxY.TabIndex = 5;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(184, 172);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 22);
            this.textBoxX.TabIndex = 6;
            // 
            // FindTreasureApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(615, 503);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gameFooter);
            this.Controls.Add(this.gameHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FindTreasureApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Start Menu";
            this.Load += new System.EventHandler(this.FindTreasureApp_Load);
            this.Shown += new System.EventHandler(this.OnAppShown);
            this.gameHeader.ResumeLayout(false);
            this.gameHeader.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox gameHeader;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.GroupBox gameFooter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
    }
}

