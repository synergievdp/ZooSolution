
using System;

namespace ZooFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AddElephant = new System.Windows.Forms.Button();
            this.AddMonkey = new System.Windows.Forms.Button();
            this.AddLion = new System.Windows.Forms.Button();
            this.FeedElephant = new System.Windows.Forms.Button();
            this.FeedLion = new System.Windows.Forms.Button();
            this.FeedMonkey = new System.Windows.Forms.Button();
            this.FeedAll = new System.Windows.Forms.Button();
            this.StartTimer = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.intervalBinding = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // AddElephant
            // 
            this.AddElephant.AutoSize = true;
            this.AddElephant.Location = new System.Drawing.Point(3, 95);
            this.AddElephant.Name = "AddElephant";
            this.AddElephant.Size = new System.Drawing.Size(109, 40);
            this.AddElephant.TabIndex = 0;
            this.AddElephant.Text = "Add Elephant";
            this.AddElephant.UseVisualStyleBackColor = true;
            this.AddElephant.Click += new System.EventHandler(this.AddAnimal);
            // 
            // AddMonkey
            // 
            this.AddMonkey.AutoSize = true;
            this.AddMonkey.Location = new System.Drawing.Point(3, 3);
            this.AddMonkey.Name = "AddMonkey";
            this.AddMonkey.Size = new System.Drawing.Size(103, 40);
            this.AddMonkey.TabIndex = 1;
            this.AddMonkey.Text = "Add Monkey";
            this.AddMonkey.UseVisualStyleBackColor = true;
            this.AddMonkey.Click += new System.EventHandler(this.AddAnimal);
            // 
            // AddLion
            // 
            this.AddLion.AutoSize = true;
            this.AddLion.Location = new System.Drawing.Point(3, 49);
            this.AddLion.Name = "AddLion";
            this.AddLion.Size = new System.Drawing.Size(80, 40);
            this.AddLion.TabIndex = 2;
            this.AddLion.Text = "Add Lion";
            this.AddLion.UseVisualStyleBackColor = true;
            this.AddLion.Click += new System.EventHandler(this.AddAnimal);
            // 
            // FeedElephant
            // 
            this.FeedElephant.AutoSize = true;
            this.FeedElephant.Location = new System.Drawing.Point(118, 95);
            this.FeedElephant.Name = "FeedElephant";
            this.FeedElephant.Size = new System.Drawing.Size(113, 40);
            this.FeedElephant.TabIndex = 3;
            this.FeedElephant.Text = "Feed Elephant";
            this.FeedElephant.UseVisualStyleBackColor = true;
            this.FeedElephant.Click += new System.EventHandler(this.FeedAnimal);
            // 
            // FeedLion
            // 
            this.FeedLion.AutoSize = true;
            this.FeedLion.Location = new System.Drawing.Point(118, 49);
            this.FeedLion.Name = "FeedLion";
            this.FeedLion.Size = new System.Drawing.Size(83, 40);
            this.FeedLion.TabIndex = 4;
            this.FeedLion.Text = "Feed Lion";
            this.FeedLion.UseVisualStyleBackColor = true;
            this.FeedLion.Click += new System.EventHandler(this.FeedAnimal);
            // 
            // FeedMonkey
            // 
            this.FeedMonkey.AutoSize = true;
            this.FeedMonkey.Location = new System.Drawing.Point(118, 3);
            this.FeedMonkey.Name = "FeedMonkey";
            this.FeedMonkey.Size = new System.Drawing.Size(107, 40);
            this.FeedMonkey.TabIndex = 5;
            this.FeedMonkey.Text = "Feed Monkey";
            this.FeedMonkey.UseVisualStyleBackColor = true;
            this.FeedMonkey.Click += new System.EventHandler(this.FeedAnimal);
            // 
            // FeedAll
            // 
            this.FeedAll.AutoSize = true;
            this.FeedAll.Location = new System.Drawing.Point(118, 141);
            this.FeedAll.Name = "FeedAll";
            this.FeedAll.Size = new System.Drawing.Size(80, 40);
            this.FeedAll.TabIndex = 6;
            this.FeedAll.Text = "Feed All";
            this.FeedAll.UseVisualStyleBackColor = true;
            this.FeedAll.Click += new System.EventHandler(this.FeedAnimal);
            // 
            // StartTimer
            // 
            this.StartTimer.AutoSize = true;
            this.StartTimer.Location = new System.Drawing.Point(3, 141);
            this.StartTimer.Name = "StartTimer";
            this.StartTimer.Size = new System.Drawing.Size(80, 40);
            this.StartTimer.TabIndex = 7;
            this.StartTimer.Text = "Start";
            this.StartTimer.UseVisualStyleBackColor = true;
            this.StartTimer.Click += new System.EventHandler(this.StartTimer_Click);
            // 
            // listBox1
            // 
            this.listBox1.DisplayMember = "Form1";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(328, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(116, 284);
            this.listBox1.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.AddMonkey);
            this.flowLayoutPanel1.Controls.Add(this.AddLion);
            this.flowLayoutPanel1.Controls.Add(this.AddElephant);
            this.flowLayoutPanel1.Controls.Add(this.StartTimer);
            this.flowLayoutPanel1.Controls.Add(this.FeedMonkey);
            this.flowLayoutPanel1.Controls.Add(this.FeedLion);
            this.flowLayoutPanel1.Controls.Add(this.FeedElephant);
            this.flowLayoutPanel1.Controls.Add(this.FeedAll);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(310, 192);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // listBox2
            // 
            this.listBox2.DisplayMember = "Form1";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(450, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(116, 284);
            this.listBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 27);
            this.textBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 442);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalBinding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button AddElephant;
        private System.Windows.Forms.Button AddMonkey;
        private System.Windows.Forms.Button AddLion;
        private System.Windows.Forms.Button FeedElephant;
        private System.Windows.Forms.Button FeedLion;
        private System.Windows.Forms.Button FeedMonkey;
        private System.Windows.Forms.Button FeedAll;
        private System.Windows.Forms.Button StartTimer;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource intervalBinding;
    }
}

