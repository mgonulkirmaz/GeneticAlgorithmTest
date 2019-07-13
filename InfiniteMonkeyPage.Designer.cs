namespace GeneticAlgorithmTest
{
    partial class InfiniteMonkeyPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.btnTarget = new System.Windows.Forms.Button();
            this.txtPopSize = new System.Windows.Forms.MaskedTextBox();
            this.txtMutRate = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPopSize = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMutRate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblGeneration = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFitness = new System.Windows.Forms.Label();
            this.txtDna = new System.Windows.Forms.RichTextBox();
            this.lblBest = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtElitism = new System.Windows.Forms.MaskedTextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(208, 405);
            this.txtTarget.MaxLength = 100;
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(483, 23);
            this.txtTarget.TabIndex = 0;
            // 
            // btnTarget
            // 
            this.btnTarget.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTarget.Location = new System.Drawing.Point(208, 434);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(483, 39);
            this.btnTarget.TabIndex = 1;
            this.btnTarget.Text = "SET TARGET TEXT";
            this.btnTarget.UseVisualStyleBackColor = true;
            this.btnTarget.Click += new System.EventHandler(this.btnTarget_Click);
            // 
            // txtPopSize
            // 
            this.txtPopSize.Location = new System.Drawing.Point(336, 502);
            this.txtPopSize.Mask = "000";
            this.txtPopSize.Name = "txtPopSize";
            this.txtPopSize.Size = new System.Drawing.Size(60, 23);
            this.txtPopSize.TabIndex = 2;
            this.txtPopSize.ValidatingType = typeof(int);
            // 
            // txtMutRate
            // 
            this.txtMutRate.Location = new System.Drawing.Point(336, 531);
            this.txtMutRate.Mask = "0,00";
            this.txtMutRate.Name = "txtMutRate";
            this.txtMutRate.Size = new System.Drawing.Size(60, 23);
            this.txtMutRate.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(402, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 81);
            this.button1.TabIndex = 4;
            this.button1.Text = "SET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(204, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Population size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(208, 531);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mutation rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(106, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Target Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(42, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Current Population Size";
            // 
            // lblPopSize
            // 
            this.lblPopSize.AutoSize = true;
            this.lblPopSize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPopSize.Location = new System.Drawing.Point(240, 32);
            this.lblPopSize.Name = "lblPopSize";
            this.lblPopSize.Size = new System.Drawing.Size(36, 19);
            this.lblPopSize.TabIndex = 9;
            this.lblPopSize.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(43, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Current Mutation Rate";
            // 
            // lblMutRate
            // 
            this.lblMutRate.AutoSize = true;
            this.lblMutRate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMutRate.Location = new System.Drawing.Point(240, 63);
            this.lblMutRate.Name = "lblMutRate";
            this.lblMutRate.Size = new System.Drawing.Size(30, 19);
            this.lblMutRate.TabIndex = 11;
            this.lblMutRate.Text = "%1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(69, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Current Generation";
            // 
            // lblGeneration
            // 
            this.lblGeneration.AutoSize = true;
            this.lblGeneration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGeneration.Location = new System.Drawing.Point(240, 94);
            this.lblGeneration.Name = "lblGeneration";
            this.lblGeneration.Size = new System.Drawing.Size(18, 19);
            this.lblGeneration.TabIndex = 13;
            this.lblGeneration.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(136, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 19);
            this.label10.TabIndex = 14;
            this.label10.Text = "Best Fitness";
            // 
            // lblFitness
            // 
            this.lblFitness.AutoSize = true;
            this.lblFitness.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFitness.Location = new System.Drawing.Point(240, 125);
            this.lblFitness.Name = "lblFitness";
            this.lblFitness.Size = new System.Drawing.Size(59, 19);
            this.lblFitness.TabIndex = 15;
            this.lblFitness.Text = "0.0845";
            // 
            // txtDna
            // 
            this.txtDna.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDna.HideSelection = false;
            this.txtDna.Location = new System.Drawing.Point(359, 18);
            this.txtDna.Name = "txtDna";
            this.txtDna.ReadOnly = true;
            this.txtDna.Size = new System.Drawing.Size(433, 340);
            this.txtDna.TabIndex = 16;
            this.txtDna.Text = "";
            // 
            // lblBest
            // 
            this.lblBest.AutoSize = true;
            this.lblBest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBest.Location = new System.Drawing.Point(204, 371);
            this.lblBest.Name = "lblBest";
            this.lblBest.Size = new System.Drawing.Size(81, 19);
            this.lblBest.TabIndex = 17;
            this.lblBest.Text = "BEST DNA";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(488, 501);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(102, 82);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(270, 560);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Elitism";
            // 
            // txtElitism
            // 
            this.txtElitism.Location = new System.Drawing.Point(336, 560);
            this.txtElitism.Mask = "0";
            this.txtElitism.Name = "txtElitism";
            this.txtElitism.Size = new System.Drawing.Size(60, 23);
            this.txtElitism.TabIndex = 19;
            this.txtElitism.ValidatingType = typeof(int);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStop.Location = new System.Drawing.Point(596, 502);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(95, 82);
            this.btnStop.TabIndex = 21;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Time Passed: ";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(169, 231);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 17);
            this.lblTime.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(205, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "secs";
            // 
            // InfiniteMonkeyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtElitism);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblBest);
            this.Controls.Add(this.txtDna);
            this.Controls.Add(this.lblFitness);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblGeneration);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblMutRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPopSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMutRate);
            this.Controls.Add(this.txtPopSize);
            this.Controls.Add(this.btnTarget);
            this.Controls.Add(this.txtTarget);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InfiniteMonkeyPage";
            this.Size = new System.Drawing.Size(824, 615);
            this.Load += new System.EventHandler(this.InfiniteMonkeyPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Button btnTarget;
        private System.Windows.Forms.MaskedTextBox txtPopSize;
        private System.Windows.Forms.MaskedTextBox txtMutRate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPopSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMutRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblGeneration;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblFitness;
        private System.Windows.Forms.RichTextBox txtDna;
        private System.Windows.Forms.Label lblBest;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtElitism;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label9;
    }
}
