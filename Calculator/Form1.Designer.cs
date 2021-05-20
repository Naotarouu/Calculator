
namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(261, 255);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(41, 39);
            this.plusButton.TabIndex = 0;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(261, 210);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(41, 39);
            this.minusButton.TabIndex = 1;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            // 
            // equalButton
            // 
            this.equalButton.Location = new System.Drawing.Point(261, 300);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(41, 39);
            this.equalButton.TabIndex = 2;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(261, 165);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(41, 39);
            this.multiplyButton.TabIndex = 3;
            this.multiplyButton.Text = "×";
            this.multiplyButton.UseVisualStyleBackColor = true;
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(261, 120);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(41, 39);
            this.divideButton.TabIndex = 4;
            this.divideButton.Text = "÷";
            this.divideButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "⌫";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(214, 75);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(41, 39);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 351);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clearButton;
    }
}

