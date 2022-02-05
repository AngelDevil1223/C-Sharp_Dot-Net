
namespace AliaksandrForms
{
    partial class ExpenseRecording
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inpSource = new System.Windows.Forms.TextBox();
            this.inpValue = new System.Windows.Forms.NumericUpDown();
            this.inpDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inpValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(123, 51);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(119, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ADD OUTCOME ITEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Source";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // inpSource
            // 
            this.inpSource.Location = new System.Drawing.Point(103, 82);
            this.inpSource.Name = "inpSource";
            this.inpSource.Size = new System.Drawing.Size(309, 23);
            this.inpSource.TabIndex = 4;
            // 
            // inpValue
            // 
            this.inpValue.Location = new System.Drawing.Point(103, 117);
            this.inpValue.Name = "inpValue";
            this.inpValue.Size = new System.Drawing.Size(176, 23);
            this.inpValue.TabIndex = 5;
            // 
            // inpDate
            // 
            this.inpDate.Location = new System.Drawing.Point(103, 151);
            this.inpDate.Name = "inpDate";
            this.inpDate.Size = new System.Drawing.Size(200, 23);
            this.inpDate.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(204, 207);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ExpenseRecording
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 317);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.inpDate);
            this.Controls.Add(this.inpValue);
            this.Controls.Add(this.inpSource);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Name = "ExpenseRecording";
            this.Text = "Outcomes";
            this.Load += new System.EventHandler(this.ExpenseRecording_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inpValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inpSource;
        private System.Windows.Forms.NumericUpDown inpValue;
        private System.Windows.Forms.DateTimePicker inpDate;
        private System.Windows.Forms.Button btnSave;
    }
}

