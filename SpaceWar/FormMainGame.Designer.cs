namespace SpaceWar
{
    partial class FormMainGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainGame));
            this.pictureBoxEnemy = new System.Windows.Forms.PictureBox();
            this.pictureBoxMyShip = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyShip)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxEnemy
            // 
            this.pictureBoxEnemy.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEnemy.Image")));
            this.pictureBoxEnemy.Location = new System.Drawing.Point(317, 48);
            this.pictureBoxEnemy.Name = "pictureBoxEnemy";
            this.pictureBoxEnemy.Size = new System.Drawing.Size(144, 78);
            this.pictureBoxEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEnemy.TabIndex = 1;
            this.pictureBoxEnemy.TabStop = false;
            // 
            // pictureBoxMyShip
            // 
            this.pictureBoxMyShip.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMyShip.Image")));
            this.pictureBoxMyShip.Location = new System.Drawing.Point(416, 227);
            this.pictureBoxMyShip.Name = "pictureBoxMyShip";
            this.pictureBoxMyShip.Size = new System.Drawing.Size(100, 107);
            this.pictureBoxMyShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMyShip.TabIndex = 2;
            this.pictureBoxMyShip.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxMyShip);
            this.Controls.Add(this.pictureBoxEnemy);
            this.Name = "FormMainGame";
            this.Text = "Космические войны";
            this.Load += new System.EventHandler(this.FormMainGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyShip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEnemy;
        private System.Windows.Forms.PictureBox pictureBoxMyShip;
        private System.Windows.Forms.Timer timer1;
    }
}

