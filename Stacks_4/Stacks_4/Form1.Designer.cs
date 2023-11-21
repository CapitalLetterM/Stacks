namespace Stacks_4
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
            this.buttonPush = new System.Windows.Forms.Button();
            this.buttonPop = new System.Windows.Forms.Button();
            this.textBoxPush = new System.Windows.Forms.TextBox();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.buttonPeek = new System.Windows.Forms.Button();
            this.buttonIsEmpty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPush
            // 
            this.buttonPush.Location = new System.Drawing.Point(13, 13);
            this.buttonPush.Name = "buttonPush";
            this.buttonPush.Size = new System.Drawing.Size(44, 23);
            this.buttonPush.TabIndex = 0;
            this.buttonPush.Text = "Push";
            this.buttonPush.UseVisualStyleBackColor = true;
            this.buttonPush.Click += new System.EventHandler(this.buttonPush_Click);
            // 
            // buttonPop
            // 
            this.buttonPop.Location = new System.Drawing.Point(13, 42);
            this.buttonPop.Name = "buttonPop";
            this.buttonPop.Size = new System.Drawing.Size(44, 23);
            this.buttonPop.TabIndex = 1;
            this.buttonPop.Text = "Pop";
            this.buttonPop.UseVisualStyleBackColor = true;
            this.buttonPop.Click += new System.EventHandler(this.buttonPop_Click);
            // 
            // textBoxPush
            // 
            this.textBoxPush.Location = new System.Drawing.Point(63, 15);
            this.textBoxPush.Name = "textBoxPush";
            this.textBoxPush.Size = new System.Drawing.Size(114, 20);
            this.textBoxPush.TabIndex = 2;
            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(13, 71);
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ReadOnly = true;
            this.textBoxOut.Size = new System.Drawing.Size(164, 20);
            this.textBoxOut.TabIndex = 3;
            // 
            // buttonPeek
            // 
            this.buttonPeek.Location = new System.Drawing.Point(63, 42);
            this.buttonPeek.Name = "buttonPeek";
            this.buttonPeek.Size = new System.Drawing.Size(44, 23);
            this.buttonPeek.TabIndex = 4;
            this.buttonPeek.Text = "Peek";
            this.buttonPeek.UseVisualStyleBackColor = true;
            this.buttonPeek.Click += new System.EventHandler(this.buttonPeek_Click);
            // 
            // buttonIsEmpty
            // 
            this.buttonIsEmpty.Location = new System.Drawing.Point(113, 42);
            this.buttonIsEmpty.Name = "buttonIsEmpty";
            this.buttonIsEmpty.Size = new System.Drawing.Size(64, 23);
            this.buttonIsEmpty.TabIndex = 5;
            this.buttonIsEmpty.Text = "IsEmpty";
            this.buttonIsEmpty.UseVisualStyleBackColor = true;
            this.buttonIsEmpty.Click += new System.EventHandler(this.buttonIsEmpty_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 99);
            this.Controls.Add(this.buttonIsEmpty);
            this.Controls.Add(this.buttonPeek);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.textBoxPush);
            this.Controls.Add(this.buttonPop);
            this.Controls.Add(this.buttonPush);
            this.Name = "Form1";
            this.Text = "Stacks_4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPush;
        private System.Windows.Forms.Button buttonPop;
        private System.Windows.Forms.TextBox textBoxPush;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Button buttonPeek;
        private System.Windows.Forms.Button buttonIsEmpty;
    }
}

