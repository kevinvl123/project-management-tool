namespace ProjectManagementTool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTodo = new System.Windows.Forms.Panel();
            this.panelDoing = new System.Windows.Forms.Panel();
            this.panelDone = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelBacklog = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTodo
            // 
            this.panelTodo.AllowDrop = true;
            this.panelTodo.BackColor = System.Drawing.SystemColors.Control;
            this.panelTodo.Location = new System.Drawing.Point(318, 48);
            this.panelTodo.Name = "panelTodo";
            this.panelTodo.Size = new System.Drawing.Size(300, 516);
            this.panelTodo.TabIndex = 0;
            this.panelTodo.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTodo_DragDrop);
            this.panelTodo.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTodo_DragEnter);
            // 
            // panelDoing
            // 
            this.panelDoing.AllowDrop = true;
            this.panelDoing.BackColor = System.Drawing.SystemColors.Control;
            this.panelDoing.Location = new System.Drawing.Point(624, 48);
            this.panelDoing.Name = "panelDoing";
            this.panelDoing.Size = new System.Drawing.Size(300, 516);
            this.panelDoing.TabIndex = 1;
            this.panelDoing.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelDoing_DragDrop);
            this.panelDoing.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelDoing_DragEnter);
            // 
            // panelDone
            // 
            this.panelDone.AllowDrop = true;
            this.panelDone.BackColor = System.Drawing.SystemColors.Control;
            this.panelDone.Location = new System.Drawing.Point(930, 48);
            this.panelDone.Name = "panelDone";
            this.panelDone.Size = new System.Drawing.Size(300, 516);
            this.panelDone.TabIndex = 2;
            this.panelDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelDone_DragDrop);
            this.panelDone.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelDone_DragEnter);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(318, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 28);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "TODO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(624, 14);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 28);
            this.panel5.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "DOING";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(930, 14);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 28);
            this.panel6.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "DONE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(45, 14);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(267, 28);
            this.panel7.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "BACKLOG";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBacklog
            // 
            this.panelBacklog.AllowDrop = true;
            this.panelBacklog.BackColor = System.Drawing.SystemColors.Control;
            this.panelBacklog.Location = new System.Drawing.Point(12, 48);
            this.panelBacklog.Name = "panelBacklog";
            this.panelBacklog.Size = new System.Drawing.Size(300, 516);
            this.panelBacklog.TabIndex = 7;
            this.panelBacklog.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelBacklog_DragDrop);
            this.panelBacklog.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelBacklog_DragEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(28, 28);
            this.panel1.TabIndex = 8;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.Location = new System.Drawing.Point(0, 0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(28, 28);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.TabStop = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1242, 574);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBacklog);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelDone);
            this.Controls.Add(this.panelDoing);
            this.Controls.Add(this.panelTodo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTodo;
        private System.Windows.Forms.Panel panelDoing;
        private System.Windows.Forms.Panel panelDone;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelBacklog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox buttonAdd;

    }
}

