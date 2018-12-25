﻿namespace Text_analyzer
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
            this.categoryName = new System.Windows.Forms.TextBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.tbNews = new System.Windows.Forms.TextBox();
            this.btnTf = new System.Windows.Forms.Button();
            this.lbWords = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbBig = new System.Windows.Forms.Label();
            this.btnIdf = new System.Windows.Forms.Button();
            this.btnTfIdf = new System.Windows.Forms.Button();
            this.tbNewText = new System.Windows.Forms.TextBox();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.myGrid = new System.Windows.Forms.DataGridView();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfMatches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentOfMatches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDebug = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryName
            // 
            this.categoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryName.Location = new System.Drawing.Point(148, 23);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(137, 21);
            this.categoryName.TabIndex = 0;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCategory.Location = new System.Drawing.Point(3, 26);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(133, 15);
            this.lbCategory.TabIndex = 1;
            this.lbCategory.Text = "Enter name of category";
            // 
            // tbNews
            // 
            this.tbNews.Location = new System.Drawing.Point(6, 63);
            this.tbNews.MaxLength = 100000;
            this.tbNews.Multiline = true;
            this.tbNews.Name = "tbNews";
            this.tbNews.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNews.Size = new System.Drawing.Size(503, 543);
            this.tbNews.TabIndex = 2;
            // 
            // btnTf
            // 
            this.btnTf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTf.Location = new System.Drawing.Point(291, 7);
            this.btnTf.Name = "btnTf";
            this.btnTf.Size = new System.Drawing.Size(50, 50);
            this.btnTf.TabIndex = 4;
            this.btnTf.Text = "TF";
            this.btnTf.UseVisualStyleBackColor = true;
            this.btnTf.Click += new System.EventHandler(this.btnTf_Click);
            // 
            // lbWords
            // 
            this.lbWords.AutoSize = true;
            this.lbWords.Location = new System.Drawing.Point(3, 0);
            this.lbWords.Name = "lbWords";
            this.lbWords.Size = new System.Drawing.Size(0, 13);
            this.lbWords.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.lbWords);
            this.panel2.Location = new System.Drawing.Point(515, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 599);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.lbBig);
            this.panel3.Location = new System.Drawing.Point(651, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 599);
            this.panel3.TabIndex = 8;
            // 
            // lbBig
            // 
            this.lbBig.AutoSize = true;
            this.lbBig.Location = new System.Drawing.Point(3, 0);
            this.lbBig.Name = "lbBig";
            this.lbBig.Size = new System.Drawing.Size(0, 13);
            this.lbBig.TabIndex = 0;
            // 
            // btnIdf
            // 
            this.btnIdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIdf.Location = new System.Drawing.Point(347, 6);
            this.btnIdf.Name = "btnIdf";
            this.btnIdf.Size = new System.Drawing.Size(50, 50);
            this.btnIdf.TabIndex = 9;
            this.btnIdf.Text = "IDF";
            this.btnIdf.UseVisualStyleBackColor = true;
            this.btnIdf.Click += new System.EventHandler(this.btnIdf_Click);
            // 
            // btnTfIdf
            // 
            this.btnTfIdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTfIdf.Location = new System.Drawing.Point(403, 6);
            this.btnTfIdf.Name = "btnTfIdf";
            this.btnTfIdf.Size = new System.Drawing.Size(50, 50);
            this.btnTfIdf.TabIndex = 10;
            this.btnTfIdf.Text = "TFIDF";
            this.btnTfIdf.UseVisualStyleBackColor = true;
            this.btnTfIdf.Click += new System.EventHandler(this.btnTfIdf_Click);
            // 
            // tbNewText
            // 
            this.tbNewText.Location = new System.Drawing.Point(6, 6);
            this.tbNewText.Multiline = true;
            this.tbNewText.Name = "tbNewText";
            this.tbNewText.Size = new System.Drawing.Size(462, 232);
            this.tbNewText.TabIndex = 11;
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Location = new System.Drawing.Point(6, 244);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(150, 50);
            this.btnAnalysis.TabIndex = 12;
            this.btnAnalysis.Text = "Аналіз";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 50);
            this.button2.TabIndex = 13;
            this.button2.Text = "Ключові слова";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(318, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 50);
            this.button3.TabIndex = 14;
            this.button3.Text = "Налаштування";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // myGrid
            // 
            this.myGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Topic,
            this.numberOfMatches,
            this.percentOfMatches});
            this.myGrid.Location = new System.Drawing.Point(6, 310);
            this.myGrid.Name = "myGrid";
            this.myGrid.Size = new System.Drawing.Size(462, 295);
            this.myGrid.TabIndex = 15;
            // 
            // Topic
            // 
            this.Topic.HeaderText = "Рубрика";
            this.Topic.Name = "Topic";
            // 
            // numberOfMatches
            // 
            this.numberOfMatches.HeaderText = "Кількість співпадінь";
            this.numberOfMatches.Name = "numberOfMatches";
            // 
            // percentOfMatches
            // 
            this.percentOfMatches.HeaderText = "Відсоток співпадінь";
            this.percentOfMatches.Name = "percentOfMatches";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSave.Location = new System.Drawing.Point(459, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 50);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbDebug);
            this.panel1.Location = new System.Drawing.Point(13, 672);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 150);
            this.panel1.TabIndex = 16;
            // 
            // lbDebug
            // 
            this.lbDebug.AutoSize = true;
            this.lbDebug.Location = new System.Drawing.Point(7, 0);
            this.lbDebug.Name = "lbDebug";
            this.lbDebug.Size = new System.Drawing.Size(0, 13);
            this.lbDebug.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLoad.Location = new System.Drawing.Point(474, 6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 50);
            this.btnLoad.TabIndex = 17;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(862, 653);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbNews);
            this.tabPage1.Controls.Add(this.categoryName);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.lbCategory);
            this.tabPage1.Controls.Add(this.btnTf);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.btnIdf);
            this.tabPage1.Controls.Add(this.btnTfIdf);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(854, 627);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLoad);
            this.tabPage2.Controls.Add(this.tbNewText);
            this.tabPage2.Controls.Add(this.btnAnalysis);
            this.tabPage2.Controls.Add(this.myGrid);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(854, 627);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 848);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Text analyzer";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox categoryName;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.TextBox tbNews;
        private System.Windows.Forms.Button btnTf;
        private System.Windows.Forms.Label lbWords;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbBig;
        private System.Windows.Forms.Button btnIdf;
        private System.Windows.Forms.Button btnTfIdf;
        private System.Windows.Forms.TextBox tbNewText;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView myGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfMatches;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentOfMatches;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDebug;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

