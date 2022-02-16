namespace IPPOPr1
{
    partial class MailClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailClient));
            this.addressLbl = new System.Windows.Forms.Label();
            this.topicLbl = new System.Windows.Forms.Label();
            this.messageLbl = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.addrTo = new System.Windows.Forms.DomainUpDown();
            this.msgTopic = new System.Windows.Forms.TextBox();
            this.msgBody = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(12, 30);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(98, 13);
            this.addressLbl.TabIndex = 0;
            this.addressLbl.Text = "Адрес получателя";
            // 
            // topicLbl
            // 
            this.topicLbl.AutoSize = true;
            this.topicLbl.Location = new System.Drawing.Point(12, 64);
            this.topicLbl.Name = "topicLbl";
            this.topicLbl.Size = new System.Drawing.Size(34, 13);
            this.topicLbl.TabIndex = 1;
            this.topicLbl.Text = "Тема";
            // 
            // messageLbl
            // 
            this.messageLbl.AutoSize = true;
            this.messageLbl.Location = new System.Drawing.Point(12, 96);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(87, 13);
            this.messageLbl.TabIndex = 2;
            this.messageLbl.Text = "Текст отправки";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(15, 301);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Отправить";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // addrTo
            // 
            this.addrTo.Location = new System.Drawing.Point(143, 28);
            this.addrTo.Name = "addrTo";
            this.addrTo.Size = new System.Drawing.Size(232, 20);
            this.addrTo.TabIndex = 5;
            // 
            // msgTopic
            // 
            this.msgTopic.Location = new System.Drawing.Point(143, 61);
            this.msgTopic.Name = "msgTopic";
            this.msgTopic.Size = new System.Drawing.Size(232, 20);
            this.msgTopic.TabIndex = 6;
            // 
            // msgBody
            // 
            this.msgBody.Location = new System.Drawing.Point(143, 93);
            this.msgBody.Multiline = true;
            this.msgBody.Name = "msgBody";
            this.msgBody.Size = new System.Drawing.Size(232, 188);
            this.msgBody.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(399, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(88, 22);
            this.toolStripButton1.Text = "Пишите здесь";
            // 
            // MailClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 345);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.msgBody);
            this.Controls.Add(this.msgTopic);
            this.Controls.Add(this.addrTo);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.messageLbl);
            this.Controls.Add(this.topicLbl);
            this.Controls.Add(this.addressLbl);
            this.Name = "MailClient";
            this.Text = "Почтовый клиент";
            this.Load += new System.EventHandler(this.MailClient_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label topicLbl;
        private System.Windows.Forms.Label messageLbl;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.DomainUpDown addrTo;
        private System.Windows.Forms.TextBox msgTopic;
        private System.Windows.Forms.TextBox msgBody;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

