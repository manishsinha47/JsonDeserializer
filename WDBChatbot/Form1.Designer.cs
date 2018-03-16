namespace WDBChatbot
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
            this.jsonInput = new System.Windows.Forms.TextBox();
            this.jsonDeserialize = new System.Windows.Forms.Button();
            this.jsonOutput = new System.Windows.Forms.TextBox();
            this.jsonClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jsonInput
            // 
            this.jsonInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jsonInput.Location = new System.Drawing.Point(12, 25);
            this.jsonInput.Multiline = true;
            this.jsonInput.Name = "jsonInput";
            this.jsonInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.jsonInput.Size = new System.Drawing.Size(776, 146);
            this.jsonInput.TabIndex = 0;
            // 
            // jsonDeserialize
            // 
            this.jsonDeserialize.Location = new System.Drawing.Point(12, 193);
            this.jsonDeserialize.Name = "jsonDeserialize";
            this.jsonDeserialize.Size = new System.Drawing.Size(124, 57);
            this.jsonDeserialize.TabIndex = 1;
            this.jsonDeserialize.Text = "Deserialize";
            this.jsonDeserialize.UseVisualStyleBackColor = true;
            this.jsonDeserialize.Click += new System.EventHandler(this.jsonDeserialize_Click);
            // 
            // jsonOutput
            // 
            this.jsonOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jsonOutput.Location = new System.Drawing.Point(12, 275);
            this.jsonOutput.Multiline = true;
            this.jsonOutput.Name = "jsonOutput";
            this.jsonOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.jsonOutput.Size = new System.Drawing.Size(776, 159);
            this.jsonOutput.TabIndex = 2;
            // 
            // jsonClear
            // 
            this.jsonClear.Location = new System.Drawing.Point(195, 193);
            this.jsonClear.Name = "jsonClear";
            this.jsonClear.Size = new System.Drawing.Size(106, 57);
            this.jsonClear.TabIndex = 3;
            this.jsonClear.Text = "Clear";
            this.jsonClear.UseVisualStyleBackColor = true;
            this.jsonClear.Click += new System.EventHandler(this.jsonClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "JSON INPUT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "JSON OUTPUT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jsonClear);
            this.Controls.Add(this.jsonOutput);
            this.Controls.Add(this.jsonDeserialize);
            this.Controls.Add(this.jsonInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox jsonInput;
        private System.Windows.Forms.Button jsonDeserialize;
        private System.Windows.Forms.TextBox jsonOutput;
        private System.Windows.Forms.Button jsonClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

