namespace CopyTemplate.App
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
            groupBox1 = new GroupBox();
            btnOutputFolder = new Button();
            txtOutputFolder = new TextBox();
            label2 = new Label();
            btnInputFolder = new Button();
            txtInputFolder = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            txtOutput = new TextBox();
            txtInput = new TextBox();
            btnCopy = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnOutputFolder);
            groupBox1.Controls.Add(txtOutputFolder);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnInputFolder);
            groupBox1.Controls.Add(txtInputFolder);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(38, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1171, 281);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Folders";
            // 
            // btnOutputFolder
            // 
            btnOutputFolder.Location = new Point(940, 191);
            btnOutputFolder.Name = "btnOutputFolder";
            btnOutputFolder.Size = new Size(188, 58);
            btnOutputFolder.TabIndex = 5;
            btnOutputFolder.Text = "Select";
            btnOutputFolder.UseVisualStyleBackColor = true;
            btnOutputFolder.Click += btnOutputFolder_Click;
            // 
            // txtOutputFolder
            // 
            txtOutputFolder.Location = new Point(23, 197);
            txtOutputFolder.Name = "txtOutputFolder";
            txtOutputFolder.ReadOnly = true;
            txtOutputFolder.Size = new Size(874, 47);
            txtOutputFolder.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 153);
            label2.Name = "label2";
            label2.Size = new Size(205, 41);
            label2.TabIndex = 3;
            label2.Text = "Output Folder";
            // 
            // btnInputFolder
            // 
            btnInputFolder.Location = new Point(940, 90);
            btnInputFolder.Name = "btnInputFolder";
            btnInputFolder.Size = new Size(188, 58);
            btnInputFolder.TabIndex = 2;
            btnInputFolder.Text = "Select";
            btnInputFolder.UseVisualStyleBackColor = true;
            btnInputFolder.Click += btnInputFolder_Click;
            // 
            // txtInputFolder
            // 
            txtInputFolder.Location = new Point(23, 96);
            txtInputFolder.Name = "txtInputFolder";
            txtInputFolder.ReadOnly = true;
            txtInputFolder.Size = new Size(874, 47);
            txtInputFolder.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 52);
            label1.Name = "label1";
            label1.Size = new Size(180, 41);
            label1.TabIndex = 0;
            label1.Text = "Input Folder";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtOutput);
            groupBox2.Controls.Add(txtInput);
            groupBox2.Location = new Point(38, 328);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(897, 191);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Text Mixing";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 122);
            label4.Name = "label4";
            label4.Size = new Size(174, 41);
            label4.TabIndex = 3;
            label4.Text = "Output Text";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 55);
            label3.Name = "label3";
            label3.Size = new Size(149, 41);
            label3.TabIndex = 2;
            label3.Text = "Input Text";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(200, 125);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(659, 47);
            txtOutput.TabIndex = 1;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(200, 55);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(659, 47);
            txtInput.TabIndex = 0;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(978, 412);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(188, 58);
            btnCopy.TabIndex = 2;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 681);
            Controls.Add(btnCopy);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Template Copy";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnOutputFolder;
        private TextBox txtOutputFolder;
        private Label label2;
        private Button btnInputFolder;
        private TextBox txtInputFolder;
        private Label label1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private TextBox txtOutput;
        private TextBox txtInput;
        private Button btnCopy;
    }
}
