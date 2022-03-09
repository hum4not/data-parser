namespace hosts_reader
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
            this.components = new System.ComponentModel.Container();
            this.url = new System.Windows.Forms.TextBox();
            this.logs = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.isFilter = new System.Windows.Forms.CheckBox();
            this.isIp = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // url
            // 
            this.url.BackColor = System.Drawing.SystemColors.MenuText;
            this.url.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.url.ForeColor = System.Drawing.Color.Lime;
            this.url.Location = new System.Drawing.Point(414, 12);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(374, 20);
            this.url.TabIndex = 0;
            // 
            // logs
            // 
            this.logs.BackColor = System.Drawing.SystemColors.MenuText;
            this.logs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logs.ForeColor = System.Drawing.Color.Lime;
            this.logs.Location = new System.Drawing.Point(12, 12);
            this.logs.Multiline = true;
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(375, 426);
            this.logs.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(414, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Parse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // isFilter
            // 
            this.isFilter.AutoSize = true;
            this.isFilter.ForeColor = System.Drawing.Color.Lime;
            this.isFilter.Location = new System.Drawing.Point(414, 39);
            this.isFilter.Name = "isFilter";
            this.isFilter.Size = new System.Drawing.Size(48, 17);
            this.isFilter.TabIndex = 3;
            this.isFilter.Text = "Filter";
            this.isFilter.UseVisualStyleBackColor = true;
            // 
            // isIp
            // 
            this.isIp.AutoSize = true;
            this.isIp.ForeColor = System.Drawing.Color.Lime;
            this.isIp.Location = new System.Drawing.Point(468, 38);
            this.isIp.Name = "isIp";
            this.isIp.Size = new System.Drawing.Size(36, 17);
            this.isIp.TabIndex = 4;
            this.isIp.Text = "IP";
            this.isIp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(637, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Made by humanot";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(275, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isIp);
            this.Controls.Add(this.isFilter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.url);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Name = "Form1";
            this.Text = "RetardParser v1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.TextBox logs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox isFilter;
        private System.Windows.Forms.CheckBox isIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button2;
    }
}

