namespace WinFormsGallery
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
            galleryLayoutPanel = new TableLayoutPanel();
            imageButton = new Button();
            button1 = new Button();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            galleryLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // galleryLayoutPanel
            // 
            galleryLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            galleryLayoutPanel.ColumnCount = 2;
            galleryLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            galleryLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            galleryLayoutPanel.Controls.Add(imageButton, 1, 0);
            galleryLayoutPanel.Controls.Add(button1, 1, 1);
            galleryLayoutPanel.Controls.Add(label1, 0, 1);
            galleryLayoutPanel.Controls.Add(label2, 0, 0);
            galleryLayoutPanel.Location = new Point(12, 12);
            galleryLayoutPanel.Name = "galleryLayoutPanel";
            galleryLayoutPanel.RowCount = 2;
            galleryLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 51.1002426F));
            galleryLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 48.8997574F));
            galleryLayoutPanel.Size = new Size(752, 409);
            galleryLayoutPanel.TabIndex = 0;
            // 
            // imageButton
            // 
            imageButton.Dock = DockStyle.Fill;
            imageButton.Location = new Point(567, 3);
            imageButton.Name = "imageButton";
            imageButton.Size = new Size(182, 203);
            imageButton.TabIndex = 0;
            imageButton.Text = "Choose Image";
            imageButton.UseVisualStyleBackColor = true;
            imageButton.Click += imageButton_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(567, 212);
            button1.Name = "button1";
            button1.Size = new Size(182, 194);
            button1.TabIndex = 1;
            button1.Text = "Choose Color";
            button1.UseVisualStyleBackColor = true;
            button1.Click += colorButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 209);
            label1.Name = "label1";
            label1.Size = new Size(558, 200);
            label1.TabIndex = 2;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Location = new Point(595, 321);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(8, 8);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(558, 209);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 436);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(galleryLayoutPanel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            galleryLayoutPanel.ResumeLayout(false);
            galleryLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel galleryLayoutPanel;
        private TableLayoutPanel tableLayoutPanel2;
        private Button imageButton;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}