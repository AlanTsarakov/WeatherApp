namespace WeatherApp
{
    partial class FormMain
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
            this.buttonShowMessage = new System.Windows.Forms.Button();
            this.labelWeatherInfo = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonShowMessage
            // 
            this.buttonShowMessage.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowMessage.Location = new System.Drawing.Point(57, 113);
            this.buttonShowMessage.Name = "buttonShowMessage";
            this.buttonShowMessage.Size = new System.Drawing.Size(211, 135);
            this.buttonShowMessage.TabIndex = 0;
            this.buttonShowMessage.Text = "Узнать погоду";
            this.buttonShowMessage.UseVisualStyleBackColor = true;
            this.buttonShowMessage.Click += new System.EventHandler(this.buttonShowMessage_Click);
            // 
            // labelWeatherInfo
            // 
            this.labelWeatherInfo.AutoSize = true;
            this.labelWeatherInfo.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWeatherInfo.Location = new System.Drawing.Point(49, 278);
            this.labelWeatherInfo.Name = "labelWeatherInfo";
            this.labelWeatherInfo.Size = new System.Drawing.Size(0, 46);
            this.labelWeatherInfo.TabIndex = 1;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCity.Location = new System.Drawing.Point(57, 35);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(211, 45);
            this.textBoxCity.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 370);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelWeatherInfo);
            this.Controls.Add(this.buttonShowMessage);
            this.Name = "FormMain";
            this.Text = "Прогноз погоды";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowMessage;
        private System.Windows.Forms.Label labelWeatherInfo;
        private System.Windows.Forms.TextBox textBoxCity;
    }
}

