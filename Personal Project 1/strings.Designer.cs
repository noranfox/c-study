﻿namespace Personal_Project_1
{
    partial class strings
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
            this.btnKor = new System.Windows.Forms.Button();
            this.btnEng = new System.Windows.Forms.Button();
            this.btnKE = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textShow = new System.Windows.Forms.TextBox();
            this.textTyping = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKor
            // 
            this.btnKor.BackColor = System.Drawing.Color.MistyRose;
            this.btnKor.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKor.Location = new System.Drawing.Point(50, 25);
            this.btnKor.Name = "btnKor";
            this.btnKor.Size = new System.Drawing.Size(100, 50);
            this.btnKor.TabIndex = 0;
            this.btnKor.Text = "한글연습";
            this.btnKor.UseVisualStyleBackColor = false;
            this.btnKor.Click += new System.EventHandler(this.btnKor_Click);
            // 
            // btnEng
            // 
            this.btnEng.BackColor = System.Drawing.Color.MistyRose;
            this.btnEng.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEng.Location = new System.Drawing.Point(330, 25);
            this.btnEng.Name = "btnEng";
            this.btnEng.Size = new System.Drawing.Size(100, 50);
            this.btnEng.TabIndex = 1;
            this.btnEng.Text = "영문연습";
            this.btnEng.UseVisualStyleBackColor = false;
            this.btnEng.Click += new System.EventHandler(this.btnEng_Click);
            // 
            // btnKE
            // 
            this.btnKE.BackColor = System.Drawing.Color.MistyRose;
            this.btnKE.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKE.Location = new System.Drawing.Point(610, 25);
            this.btnKE.Name = "btnKE";
            this.btnKE.Size = new System.Drawing.Size(100, 50);
            this.btnKE.TabIndex = 2;
            this.btnKE.Text = "한/영연습";
            this.btnKE.UseVisualStyleBackColor = false;
            this.btnKE.Click += new System.EventHandler(this.btnKE_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(120, 350);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(220, 80);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFinish.Location = new System.Drawing.Point(420, 350);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(220, 80);
            this.btnFinish.TabIndex = 4;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "총횟수 : 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(210, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "맞춘횟수 : 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(390, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "틀린횟수 : 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(560, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "정확도 : 0";
            // 
            // textShow
            // 
            this.textShow.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textShow.Location = new System.Drawing.Point(50, 110);
            this.textShow.Name = "textShow";
            this.textShow.Size = new System.Drawing.Size(660, 43);
            this.textShow.TabIndex = 9;

            // 
            // textTyping
            // 
            this.textTyping.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textTyping.Location = new System.Drawing.Point(50, 190);
            this.textTyping.Name = "textTyping";
            this.textTyping.Size = new System.Drawing.Size(660, 43);
            this.textTyping.TabIndex = 10;
            // 
            // strings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(764, 461);
            this.Controls.Add(this.textTyping);
            this.Controls.Add(this.textShow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnKE);
            this.Controls.Add(this.btnEng);
            this.Controls.Add(this.btnKor);
            this.Name = "strings";
            this.Text = "strings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnKor;
        private Button btnEng;
        private Button btnKE;
        private Button btnStart;
        private Button btnFinish;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textShow;
        private TextBox textTyping;
    }
}