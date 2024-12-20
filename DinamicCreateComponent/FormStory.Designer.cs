namespace DinamicCreateComponent
{
    partial class FormStory
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
            this.panelHead = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panelAllProducts = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelDescription = new System.Windows.Forms.Panel();
            this.pictureBoxBig = new System.Windows.Forms.PictureBox();
            this.panelHead.SuspendLayout();
            this.panelProducts.SuspendLayout();
            this.panelDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBig)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHead.Controls.Add(this.label1);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(800, 100);
            this.panelHead.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(197, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "МАЯ МАГАЗИНА";
            // 
            // panelProducts
            // 
            this.panelProducts.AutoScroll = true;
            this.panelProducts.BackColor = System.Drawing.SystemColors.Info;
            this.panelProducts.Controls.Add(this.panelDescription);
            this.panelProducts.Controls.Add(this.splitter1);
            this.panelProducts.Controls.Add(this.panelAllProducts);
            this.panelProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProducts.Location = new System.Drawing.Point(0, 100);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(800, 350);
            this.panelProducts.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panelAllProducts
            // 
            this.panelAllProducts.AutoScroll = true;
            this.panelAllProducts.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelAllProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAllProducts.Location = new System.Drawing.Point(0, 0);
            this.panelAllProducts.Name = "panelAllProducts";
            this.panelAllProducts.Size = new System.Drawing.Size(251, 350);
            this.panelAllProducts.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(251, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 350);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panelDescription
            // 
            this.panelDescription.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelDescription.Controls.Add(this.pictureBoxBig);
            this.panelDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDescription.Location = new System.Drawing.Point(254, 0);
            this.panelDescription.Name = "panelDescription";
            this.panelDescription.Size = new System.Drawing.Size(546, 350);
            this.panelDescription.TabIndex = 2;
            // 
            // pictureBoxBig
            // 
            this.pictureBoxBig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBig.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBig.Name = "pictureBoxBig";
            this.pictureBoxBig.Size = new System.Drawing.Size(546, 350);
            this.pictureBoxBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBig.TabIndex = 0;
            this.pictureBoxBig.TabStop = false;
            // 
            // FormStory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelProducts);
            this.Controls.Add(this.panelHead);
            this.Name = "FormStory";
            this.Text = "Новогодняя распродажа";
            this.Load += new System.EventHandler(this.FormStory_Load);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.panelProducts.ResumeLayout(false);
            this.panelDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelAllProducts;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panelDescription;
        private System.Windows.Forms.PictureBox pictureBoxBig;
    }
}

