namespace FADVForm
{
    partial class ProjectCreateForm
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
            this.createButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.projectPathTextBox = new System.Windows.Forms.TextBox();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.ReferenceFolderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(322, 283);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(106, 39);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "作成";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "プロジェクト保存場所";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "プロジェクト名";
            // 
            // projectPathTextBox
            // 
            this.projectPathTextBox.Location = new System.Drawing.Point(167, 72);
            this.projectPathTextBox.Name = "projectPathTextBox";
            this.projectPathTextBox.Size = new System.Drawing.Size(497, 19);
            this.projectPathTextBox.TabIndex = 3;
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Location = new System.Drawing.Point(167, 183);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(317, 19);
            this.projectNameTextBox.TabIndex = 4;
            // 
            // ReferenceFolderButton
            // 
            this.ReferenceFolderButton.Location = new System.Drawing.Point(679, 71);
            this.ReferenceFolderButton.Name = "ReferenceFolderButton";
            this.ReferenceFolderButton.Size = new System.Drawing.Size(59, 20);
            this.ReferenceFolderButton.TabIndex = 5;
            this.ReferenceFolderButton.Text = "参照";
            this.ReferenceFolderButton.UseVisualStyleBackColor = true;
            this.ReferenceFolderButton.Click += new System.EventHandler(this.ReferenceFolderButton_Click);
            // 
            // ProjectCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 347);
            this.Controls.Add(this.ReferenceFolderButton);
            this.Controls.Add(this.projectNameTextBox);
            this.Controls.Add(this.projectPathTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createButton);
            this.Name = "ProjectCreateForm";
            this.Text = "プロジェクト作成";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox projectPathTextBox;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.Button ReferenceFolderButton;
    }
}