namespace ArbitraryIntegerApp
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
            this.btnSetInteger = new System.Windows.Forms.Button();
            this.btnGetComponent = new System.Windows.Forms.Button();
            this.btnSetComponent = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSetInteger
            // 
            this.btnSetInteger.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSetInteger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetInteger.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSetInteger.Location = new System.Drawing.Point(46, 252);
            this.btnSetInteger.Name = "btnSetInteger";
            this.btnSetInteger.Size = new System.Drawing.Size(212, 78);
            this.btnSetInteger.TabIndex = 0;
            this.btnSetInteger.Text = "SetInteger";
            this.btnSetInteger.UseVisualStyleBackColor = false;
            this.btnSetInteger.Click += new System.EventHandler(this.btnSetInteger_Click);
            // 
            // btnGetComponent
            // 
            this.btnGetComponent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGetComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetComponent.Location = new System.Drawing.Point(333, 252);
            this.btnGetComponent.Name = "btnGetComponent";
            this.btnGetComponent.Size = new System.Drawing.Size(210, 78);
            this.btnGetComponent.TabIndex = 1;
            this.btnGetComponent.Text = "GetComponent";
            this.btnGetComponent.UseVisualStyleBackColor = false;
            this.btnGetComponent.Click += new System.EventHandler(this.btnGetComponent_Click);
            // 
            // btnSetComponent
            // 
            this.btnSetComponent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSetComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetComponent.Location = new System.Drawing.Point(46, 352);
            this.btnSetComponent.Name = "btnSetComponent";
            this.btnSetComponent.Size = new System.Drawing.Size(212, 72);
            this.btnSetComponent.TabIndex = 2;
            this.btnSetComponent.Text = "SetComponent";
            this.btnSetComponent.UseVisualStyleBackColor = false;
            this.btnSetComponent.Click += new System.EventHandler(this.btnSetComponent_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDisplay.Location = new System.Drawing.Point(333, 352);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(210, 72);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtInput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtInput.Location = new System.Drawing.Point(167, 51);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(275, 34);
            this.txtInput.TabIndex = 4;
            this.txtInput.Text = "Input";
            // 
            // txtIndex
            // 
            this.txtIndex.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtIndex.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtIndex.Location = new System.Drawing.Point(167, 105);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(275, 34);
            this.txtIndex.TabIndex = 5;
            this.txtIndex.Text = "Index";
            // 
            // txtValue
            // 
            this.txtValue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtValue.Location = new System.Drawing.Point(167, 160);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(275, 34);
            this.txtValue.TabIndex = 6;
            this.txtValue.Text = "Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(594, 532);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnSetComponent);
            this.Controls.Add(this.btnGetComponent);
            this.Controls.Add(this.btnSetInteger);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "KursovaOOP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetInteger;
        private System.Windows.Forms.Button btnGetComponent;
        private System.Windows.Forms.Button btnSetComponent;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.TextBox txtValue;
    }
}

