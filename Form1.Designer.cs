
namespace Alarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Time = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Hour = new System.Windows.Forms.ComboBox();
            this.Minute = new System.Windows.Forms.ComboBox();
            this.Second = new System.Windows.Forms.ComboBox();
            this.Стоп = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ADDButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // Time
            // 
            this.Time.BackColor = System.Drawing.SystemColors.Info;
            this.Time.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time.Location = new System.Drawing.Point(275, 36);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(229, 66);
            this.Time.TabIndex = 0;
            this.Time.Text = "12:32:06";
            this.Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // Hour
            // 
            this.Hour.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hour.FormattingEnabled = true;
            this.Hour.Location = new System.Drawing.Point(274, 153);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(58, 39);
            this.Hour.TabIndex = 1;
            this.Hour.Text = "0";
            this.Hour.SelectedIndexChanged += new System.EventHandler(this.Hour_SelectedIndexChanged);
            // 
            // Minute
            // 
            this.Minute.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minute.FormattingEnabled = true;
            this.Minute.Location = new System.Drawing.Point(362, 153);
            this.Minute.Name = "Minute";
            this.Minute.Size = new System.Drawing.Size(58, 39);
            this.Minute.TabIndex = 2;
            this.Minute.Text = "0";
            // 
            // Second
            // 
            this.Second.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Second.FormattingEnabled = true;
            this.Second.Location = new System.Drawing.Point(446, 153);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(58, 39);
            this.Second.TabIndex = 3;
            this.Second.Text = "0";
            // 
            // Стоп
            // 
            this.Стоп.BackColor = System.Drawing.SystemColors.Info;
            this.Стоп.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Стоп.Location = new System.Drawing.Point(303, 285);
            this.Стоп.Name = "Стоп";
            this.Стоп.Size = new System.Drawing.Size(172, 53);
            this.Стоп.TabIndex = 5;
            this.Стоп.Text = "Стоп";
            this.Стоп.UseVisualStyleBackColor = false;
            this.Стоп.Click += new System.EventHandler(this.Стоп_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 363);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 201);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanel1_ControlRemoved);
            // 
            // ADDButton
            // 
            this.ADDButton.BackColor = System.Drawing.SystemColors.Info;
            this.ADDButton.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADDButton.Location = new System.Drawing.Point(303, 211);
            this.ADDButton.Name = "ADDButton";
            this.ADDButton.Size = new System.Drawing.Size(172, 50);
            this.ADDButton.TabIndex = 7;
            this.ADDButton.Text = "Добавить";
            this.ADDButton.UseVisualStyleBackColor = false;
            this.ADDButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(285, 612);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(233, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(866, 104);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(223, 135);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(825, 669);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ADDButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Стоп);
            this.Controls.Add(this.Second);
            this.Controls.Add(this.Minute);
            this.Controls.Add(this.Hour);
            this.Controls.Add(this.Time);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ComboBox Hour;
        private System.Windows.Forms.ComboBox Minute;
        private System.Windows.Forms.ComboBox Second;
        private System.Windows.Forms.Button Стоп;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ADDButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

