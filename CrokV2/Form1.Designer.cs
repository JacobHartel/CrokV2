namespace CrokV2
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
            

            crok = new Button();
            clipPreviewBox = new TextBox();
            outputText = new TextBox();
            SuspendLayout();
            // 
            // crok button
            // 
            crok.BackColor = Color.DarkGray;
            crok.Location = new Point(350, 150);
            crok.Name = "crok";
            crok.Size = new Size(100, 50);
            crok.TabIndex = 0;
            crok.Text = "Crok It";
            crok.UseVisualStyleBackColor = false;
            crok.Click += (sender, e) => CrokButton_Click(placeholder); //will add this later should have planned this out better 
            // 
            // clipPreviewBox
            // 
            clipPreviewBox.BackColor = Color.LightGray;
            clipPreviewBox.BorderStyle = BorderStyle.None;
            clipPreviewBox.ForeColor = Color.Black;
            clipPreviewBox.Location = new Point(250, 47);
            clipPreviewBox.Multiline = true;
            clipPreviewBox.Name = "clipPreviewBox";
            clipPreviewBox.ReadOnly = true;
            clipPreviewBox.Size = new Size(300, 75);
            clipPreviewBox.TabIndex = 1;
            clipPreviewBox.Text = "Copy Paste History Here";
            clipPreviewBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outputText
            // 
            outputText.BackColor = Color.LightGray;
            outputText.BorderStyle = BorderStyle.None;
            outputText.ForeColor = Color.Black;
            outputText.Location = new Point(200, 300);
            outputText.Name = "outputText";
            outputText.Size = new Size(400, 27);
            outputText.TabIndex = 2;
            outputText.Text = "Prompt Response Here";
            outputText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(crok);
            Controls.Add(clipPreviewBox);
            Controls.Add(outputText);
            Name = "Form1";
            Text = "Crokv2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button crok;
        private TextBox clipPreviewBox;
        private TextBox outputText;
        private string placeholder; //this is for the click event above in button styling


        private void CrokButton_Click(string _clipBoardText)//will probably arrange all of this tomorrow 12/23/24
        {
            
        }

    }
}

