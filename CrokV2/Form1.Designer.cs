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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.BackColor = Color.LightGray;
            this.Text = "Crokv2";

            System.Windows.Forms.Button crok = new System.Windows.Forms.Button();
            crok.Location = new System.Drawing.Point(350, 150);
            crok.Size = new System.Drawing.Size(100, 50);
            crok.BackColor = System.Drawing.Color.DarkGray;
            crok.Text = "Crok It";
            this.Controls.Add(crok);

            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
            textBox.Location = new System.Drawing.Point(300, 50);
            textBox.Size = new System.Drawing.Size(200, 200);
            textBox.ReadOnly = true;
            textBox.ForeColor = System.Drawing.Color.Black;
            textBox.Text = "Copy Paste History Here";
            this.Controls.Add(textBox);

            System.Windows.Forms.TextBox outputText = new System.Windows.Forms.TextBox();
            outputText.Location = new System.Drawing.Point(200, 300);
            outputText.Size = new System.Drawing.Size(400, 200);
            outputText.ReadOnly = false;
            outputText.ForeColor = System.Drawing.Color.Black;
            outputText.Text = "Prompt Response Here";
            this.Controls.Add(outputText);

        }

        #endregion
    }
}
