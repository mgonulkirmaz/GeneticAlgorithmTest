﻿namespace GeneticAlgorithmTest
{
    partial class MainScreen
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonMainScreen = new System.Windows.Forms.Button();
            this.panelSelected = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.infiniteMonkeyPage = new GeneticAlgorithmTest.InfiniteMonkeyPage();
            this.mainPage = new GeneticAlgorithmTest.MainPage();
            this.leftPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.leftPanel.Controls.Add(this.button2);
            this.leftPanel.Controls.Add(this.buttonMainScreen);
            this.leftPanel.Controls.Add(this.panelSelected);
            this.leftPanel.Controls.Add(this.buttonExit);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.ForeColor = System.Drawing.Color.White;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 640);
            this.leftPanel.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.MistyRose;
            this.button2.Location = new System.Drawing.Point(5, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = "Infinite Monkey";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonMainScreen
            // 
            this.buttonMainScreen.FlatAppearance.BorderSize = 0;
            this.buttonMainScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMainScreen.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMainScreen.ForeColor = System.Drawing.Color.MistyRose;
            this.buttonMainScreen.Location = new System.Drawing.Point(5, 100);
            this.buttonMainScreen.Name = "buttonMainScreen";
            this.buttonMainScreen.Size = new System.Drawing.Size(195, 60);
            this.buttonMainScreen.TabIndex = 3;
            this.buttonMainScreen.Text = "Main Screen";
            this.buttonMainScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMainScreen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMainScreen.UseVisualStyleBackColor = true;
            this.buttonMainScreen.Click += new System.EventHandler(this.buttonMainScreen_Click);
            // 
            // panelSelected
            // 
            this.panelSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelSelected.Location = new System.Drawing.Point(3, 3);
            this.panelSelected.Name = "panelSelected";
            this.panelSelected.Size = new System.Drawing.Size(5, 60);
            this.panelSelected.TabIndex = 2;
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonExit.ForeColor = System.Drawing.Color.MistyRose;
            this.buttonExit.Location = new System.Drawing.Point(5, 480);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(195, 60);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.topPanel.Controls.Add(this.labelTime);
            this.topPanel.Controls.Add(this.labelDate);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.ForeColor = System.Drawing.Color.White;
            this.topPanel.Location = new System.Drawing.Point(200, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(824, 25);
            this.topPanel.TabIndex = 1;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTime.Location = new System.Drawing.Point(777, 3);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(44, 18);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "21:55";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDate.Location = new System.Drawing.Point(685, 3);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(86, 18);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "18/11/2018";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // infiniteMonkeyPage
            // 
            this.infiniteMonkeyPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.infiniteMonkeyPage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infiniteMonkeyPage.Location = new System.Drawing.Point(200, 25);
            this.infiniteMonkeyPage.Margin = new System.Windows.Forms.Padding(4);
            this.infiniteMonkeyPage.Name = "infiniteMonkeyPage";
            this.infiniteMonkeyPage.Size = new System.Drawing.Size(824, 615);
            this.infiniteMonkeyPage.TabIndex = 2;
            this.infiniteMonkeyPage.Load += new System.EventHandler(this.ınfiniteMonkeyPage1_Load);
            // 
            // mainPage
            // 
            this.mainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.mainPage.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.mainPage.Location = new System.Drawing.Point(200, 25);
            this.mainPage.Margin = new System.Windows.Forms.Padding(4);
            this.mainPage.Name = "mainPage";
            this.mainPage.Size = new System.Drawing.Size(824, 615);
            this.mainPage.TabIndex = 3;
            this.mainPage.Load += new System.EventHandler(this.mainPage_Load);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.mainPage);
            this.Controls.Add(this.infiniteMonkeyPage);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "--";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.leftPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelSelected;
        private System.Windows.Forms.Button buttonMainScreen;
        private System.Windows.Forms.Button button2;
        private InfiniteMonkeyPage infiniteMonkeyPage;
        private MainPage mainPage;
    }
}

