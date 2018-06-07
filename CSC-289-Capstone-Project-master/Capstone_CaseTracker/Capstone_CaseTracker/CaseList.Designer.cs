namespace Capstone_CaseTracker
{
    partial class CaseList
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
            this.caseListExitButton = new System.Windows.Forms.Button();
            this.viewCaseButton = new System.Windows.Forms.Button();
            this.activeCaseListBox = new System.Windows.Forms.ListBox();
            this.newCaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // caseListExitButton
            // 
            this.caseListExitButton.Location = new System.Drawing.Point(106, 367);
            this.caseListExitButton.Name = "caseListExitButton";
            this.caseListExitButton.Size = new System.Drawing.Size(75, 45);
            this.caseListExitButton.TabIndex = 5;
            this.caseListExitButton.Text = "Exit";
            this.caseListExitButton.UseVisualStyleBackColor = true;
            this.caseListExitButton.Click += new System.EventHandler(this.caseListExitButton_Click);
            // 
            // viewCaseButton
            // 
            this.viewCaseButton.Location = new System.Drawing.Point(65, 316);
            this.viewCaseButton.Name = "viewCaseButton";
            this.viewCaseButton.Size = new System.Drawing.Size(75, 45);
            this.viewCaseButton.TabIndex = 4;
            this.viewCaseButton.Text = "View Case";
            this.viewCaseButton.UseVisualStyleBackColor = true;
            this.viewCaseButton.Click += new System.EventHandler(this.viewCaseButton_Click);
            // 
            // activeCaseListBox
            // 
            this.activeCaseListBox.FormattingEnabled = true;
            this.activeCaseListBox.ItemHeight = 16;
            this.activeCaseListBox.Location = new System.Drawing.Point(34, 22);
            this.activeCaseListBox.Name = "activeCaseListBox";
            this.activeCaseListBox.Size = new System.Drawing.Size(218, 276);
            this.activeCaseListBox.TabIndex = 3;
            // 
            // newCaseButton
            // 
            this.newCaseButton.Location = new System.Drawing.Point(146, 316);
            this.newCaseButton.Name = "newCaseButton";
            this.newCaseButton.Size = new System.Drawing.Size(75, 45);
            this.newCaseButton.TabIndex = 6;
            this.newCaseButton.Text = "New Case";
            this.newCaseButton.UseVisualStyleBackColor = true;
            this.newCaseButton.Click += new System.EventHandler(this.newCaseButton_Click);
            // 
            // CaseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 424);
            this.Controls.Add(this.newCaseButton);
            this.Controls.Add(this.caseListExitButton);
            this.Controls.Add(this.viewCaseButton);
            this.Controls.Add(this.activeCaseListBox);
            this.Name = "CaseList";
            this.Text = "CaseList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button caseListExitButton;
        private System.Windows.Forms.Button viewCaseButton;
        private System.Windows.Forms.ListBox activeCaseListBox;
        private System.Windows.Forms.Button newCaseButton;
    }
}