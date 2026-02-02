namespace W2SZ_Flea_Log
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
            ID = new TextBox();
            IDL = new Label();
            Submit = new Button();
            textBox1 = new TextBox();
            NewFile = new Button();
            FileLocation = new Label();
            Import = new Button();
            SuspendLayout();
            // 
            // ID
            // 
            ID.Location = new Point(156, 80);
            ID.Name = "ID";
            ID.Size = new Size(345, 31);
            ID.TabIndex = 0;
            ID.TextChanged += RIN_TextChanged;
            ID.Leave += RIN_Leave;
            // 
            // IDL
            // 
            IDL.AutoSize = true;
            IDL.Location = new Point(22, 80);
            IDL.Name = "IDL";
            IDL.Size = new Size(126, 25);
            IDL.TabIndex = 1;
            IDL.Text = "RIN (optional):";
            IDL.Click += RIN_Click;
            // 
            // Submit
            // 
            Submit.Anchor = AnchorStyles.Right;
            Submit.Location = new Point(829, 300);
            Submit.Name = "Submit";
            Submit.Size = new Size(112, 34);
            Submit.TabIndex = 2;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(345, 31);
            textBox1.TabIndex = 3;
            // 
            // NewFile
            // 
            NewFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NewFile.Location = new Point(22, 40);
            NewFile.Name = "NewFile";
            NewFile.Size = new Size(112, 34);
            NewFile.TabIndex = 4;
            NewFile.Text = "New File";
            NewFile.UseVisualStyleBackColor = true;
            NewFile.Click += NewFile_Click;
            // 
            // FileLocation
            // 
            FileLocation.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FileLocation.AutoSize = true;
            FileLocation.Location = new Point(259, 45);
            FileLocation.Name = "FileLocation";
            FileLocation.Size = new Size(169, 25);
            FileLocation.TabIndex = 5;
            FileLocation.Text = "No log file selected!";
            FileLocation.TextAlign = ContentAlignment.MiddleRight;
            FileLocation.Click += FileLocation_Click;
            // 
            // Import
            // 
            Import.Location = new Point(146, 40);
            Import.Name = "Import";
            Import.Size = new Size(112, 34);
            Import.TabIndex = 6;
            Import.Text = "Import File";
            Import.UseVisualStyleBackColor = true;
            Import.Click += Import_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 644);
            Controls.Add(Import);
            Controls.Add(FileLocation);
            Controls.Add(NewFile);
            Controls.Add(textBox1);
            Controls.Add(Submit);
            Controls.Add(IDL);
            Controls.Add(ID);
            Name = "Form1";
            Text = "Flea Log";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ID;
        private Label IDL;
        private Button Submit;
        private TextBox textBox1;
        private Button NewFile;
        private Label FileLocation;
        private Button Import;
    }
}
