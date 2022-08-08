
namespace ParserStreets
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Savebutton3 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SaveFormatgroupBox = new System.Windows.Forms.GroupBox();
            this.line_by_lineRadioButton = new System.Windows.Forms.RadioButton();
            this.arrayRadioButton = new System.Windows.Forms.RadioButton();
            this.OpenFilegroupBox = new System.Windows.Forms.GroupBox();
            this.SaveFormatgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(458, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Read the file line by line, take a strings in quotation marks and Insert \",\" afte" +
    "r every string";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(2, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(439, 434);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button2.Location = new System.Drawing.Point(458, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(330, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Read the file to the end";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Savebutton3
            // 
            this.Savebutton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Savebutton3.Location = new System.Drawing.Point(52, 35);
            this.Savebutton3.Name = "Savebutton3";
            this.Savebutton3.Size = new System.Drawing.Size(75, 33);
            this.Savebutton3.TabIndex = 3;
            this.Savebutton3.Text = "Save";
            this.Savebutton3.UseVisualStyleBackColor = true;
            this.Savebutton3.Click += new System.EventHandler(this.Savebutton3_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button3.Location = new System.Drawing.Point(458, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(330, 73);
            this.button3.TabIndex = 4;
            this.button3.Text = "Read the file line by line and removes all space characters at the end of each st" +
    "ring";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button4.Location = new System.Drawing.Point(458, 197);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(330, 48);
            this.button4.TabIndex = 5;
            this.button4.Text = "Read the file line by line and delite \"/r/n\" symbols";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ExitButton.Location = new System.Drawing.Point(690, 405);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 33);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SaveFormatgroupBox
            // 
            this.SaveFormatgroupBox.Controls.Add(this.Savebutton3);
            this.SaveFormatgroupBox.Controls.Add(this.arrayRadioButton);
            this.SaveFormatgroupBox.Controls.Add(this.line_by_lineRadioButton);
            this.SaveFormatgroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveFormatgroupBox.Location = new System.Drawing.Point(447, 369);
            this.SaveFormatgroupBox.Name = "SaveFormatgroupBox";
            this.SaveFormatgroupBox.Size = new System.Drawing.Size(179, 77);
            this.SaveFormatgroupBox.TabIndex = 7;
            this.SaveFormatgroupBox.TabStop = false;
            this.SaveFormatgroupBox.Text = "Write format of saved rows";
            // 
            // line_by_lineRadioButton
            // 
            this.line_by_lineRadioButton.AutoSize = true;
            this.line_by_lineRadioButton.Checked = true;
            this.line_by_lineRadioButton.Location = new System.Drawing.Point(11, 16);
            this.line_by_lineRadioButton.Name = "line_by_lineRadioButton";
            this.line_by_lineRadioButton.Size = new System.Drawing.Size(89, 20);
            this.line_by_lineRadioButton.TabIndex = 0;
            this.line_by_lineRadioButton.TabStop = true;
            this.line_by_lineRadioButton.Text = "line by line";
            this.line_by_lineRadioButton.UseVisualStyleBackColor = true;
            this.line_by_lineRadioButton.Click += new System.EventHandler(this.line_by_lineRadioButton_Click);
            // 
            // arrayRadioButton
            // 
            this.arrayRadioButton.AutoSize = true;
            this.arrayRadioButton.Location = new System.Drawing.Point(106, 16);
            this.arrayRadioButton.Name = "arrayRadioButton";
            this.arrayRadioButton.Size = new System.Drawing.Size(57, 20);
            this.arrayRadioButton.TabIndex = 1;
            this.arrayRadioButton.Text = "array";
            this.arrayRadioButton.UseVisualStyleBackColor = true;
            this.arrayRadioButton.Click += new System.EventHandler(this.arrayRadioButton_Click);
            // 
            // OpenFilegroupBox
            // 
            this.OpenFilegroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenFilegroupBox.Location = new System.Drawing.Point(447, 12);
            this.OpenFilegroupBox.Name = "OpenFilegroupBox";
            this.OpenFilegroupBox.Size = new System.Drawing.Size(344, 296);
            this.OpenFilegroupBox.TabIndex = 8;
            this.OpenFilegroupBox.TabStop = false;
            this.OpenFilegroupBox.Text = "Open file options:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SaveFormatgroupBox);
            this.Controls.Add(this.OpenFilegroupBox);
            this.Name = "Form1";
            this.Text = "String Parser";
            this.SaveFormatgroupBox.ResumeLayout(false);
            this.SaveFormatgroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Savebutton3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox SaveFormatgroupBox;
        private System.Windows.Forms.RadioButton arrayRadioButton;
        private System.Windows.Forms.RadioButton line_by_lineRadioButton;
        private System.Windows.Forms.GroupBox OpenFilegroupBox;
    }
}

