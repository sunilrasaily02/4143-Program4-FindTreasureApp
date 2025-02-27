﻿using System;
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
            this.gameHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameHeader
            // 
            this.gameHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gameHeader.Controls.Add(this.scoreLabel);
            this.gameHeader.Location = new System.Drawing.Point(0, 0);
            this.gameHeader.Name = "gameHeader";
            this.gameHeader.Size = new System.Drawing.Size(800, 50);
            this.gameHeader.TabIndex = 0;
            this.gameHeader.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(322, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(144, 37);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Score: 0";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameFooter
            // 
            this.gameFooter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gameFooter.Location = new System.Drawing.Point(0, 400);
            this.gameFooter.Name = "gameFooter";
            this.gameFooter.Size = new System.Drawing.Size(800, 50);
            this.gameFooter.TabIndex = 1;
            this.gameFooter.TabStop = false;
            // 
            // FindTreasureApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gameFooter);
            this.Controls.Add(this.gameHeader);
            this.Name = "FindTreasureApp";
            this.Text = "Find the Treasure";
            this.Shown += new System.EventHandler(this.OnAppShown);
            this.gameHeader.ResumeLayout(false);
            this.gameHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox gameHeader;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.GroupBox gameFooter;
    }
}

