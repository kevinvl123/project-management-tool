using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProjectManagementTool
{
    public partial class Form1 : Form
    {
        private InputDialog _dialog;
        private Backlog _backLog;

        public Form1()
        {
            InitializeComponent();
            panelBacklog.Paint += dropShadow;
            panelTodo.Paint += dropShadow;
            panelDoing.Paint += dropShadow;
            panelDone.Paint += dropShadow;
            if (File.Exists("Backlog.dat"))
            {
                var r = new StreamReader("Backlog.dat");
                String json = r.ReadLine();
                r.Close();
                _backLog = Newtonsoft.Json.JsonConvert.DeserializeObject<Backlog>(json);
                /*foreach (Story s in _backLog.Stories)
                {
                    s.Priority = 2;
                }*/
            }
            else
            {
                _backLog = new Backlog();
            }
            RefreshScreen();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            String json = Newtonsoft.Json.JsonConvert.SerializeObject(_backLog);
            var w = new StreamWriter("Backlog.dat");
            w.WriteLine(json);
            w.Close();
        }

        private void RefreshScreen()
        {
            panelBacklog.Controls.Clear();
            panelTodo.Controls.Clear();
            panelDoing.Controls.Clear();
            panelDone.Controls.Clear();
            int position = 4;
            foreach (Story s in _backLog.BacklogStories)
            {
                Label l = new Label();
                l.Dock = DockStyle.Fill;
                l.Font = new Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                l.Location = new Point(0, 0);
                l.Name = "lbl";
                l.Size = new Size(278, 34);
                l.TabIndex = 0;
                l.Text = s.Title;
                l.TextAlign = ContentAlignment.MiddleLeft;
                l.MouseDown += Drag;
                l.Tag = s;
                l.Cursor = Cursors.Hand;
                PictureBox pbup1 = new PictureBox();
                pbup1.Cursor = System.Windows.Forms.Cursors.Hand;
                pbup1.Image = Image.FromFile("up1.png");
                pbup1.Location = new System.Drawing.Point(278, -1);
                pbup1.Size = new System.Drawing.Size(14, 17);
                pbup1.Tag = s;
                pbup1.Click += new System.EventHandler(this.buttonUp_Click);
                PictureBox pbdown1 = new PictureBox();
                pbdown1.Cursor = System.Windows.Forms.Cursors.Hand;
                pbdown1.Image = Image.FromFile("down1.png");
                pbdown1.Location = new System.Drawing.Point(278, 17);
                pbdown1.Size = new System.Drawing.Size(14, 17);
                pbdown1.Tag = s;
                pbdown1.Click += new System.EventHandler(this.buttonDown_Click);
                Panel p = new Panel();
                p.BorderStyle = BorderStyle.FixedSingle;
                p.SuspendLayout();
                p.BackColor = SystemColors.GradientInactiveCaption;
                p.Controls.Add(l);
                p.Controls.Add(pbup1);
                p.Controls.Add(pbdown1);
                p.Name = "pnl";
                p.Size = new Size(292, 34);
                p.TabIndex = 0;
                p.Location = new Point(4, position);
                position += 40;
                panelBacklog.Controls.Add(p);
            }
            position = 4;
            foreach (Story s in _backLog.TodoStories)
            {
                Label l = new Label();
                l.Dock = DockStyle.Fill;
                l.Font = new Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                l.Location = new Point(0, 0);
                l.Name = "lbl";
                l.Size = new Size(278, 34);
                l.TabIndex = 0;
                l.Text = s.Title;
                l.TextAlign = ContentAlignment.MiddleLeft;
                l.MouseDown += Drag;
                l.Tag = s;
                l.Cursor = Cursors.Hand;
                PictureBox pbup1 = new PictureBox();
                pbup1.Cursor = System.Windows.Forms.Cursors.Hand;
                pbup1.Image = Image.FromFile("up1.png");
                pbup1.Location = new System.Drawing.Point(278, -1);
                pbup1.Size = new System.Drawing.Size(14, 17);
                pbup1.Tag = s;
                pbup1.Click += new System.EventHandler(this.buttonUp_Click);
                PictureBox pbdown1 = new PictureBox();
                pbdown1.Cursor = System.Windows.Forms.Cursors.Hand;
                pbdown1.Image = Image.FromFile("down1.png");
                pbdown1.Location = new System.Drawing.Point(278, 17);
                pbdown1.Size = new System.Drawing.Size(14, 17);
                pbdown1.Tag = s;
                pbdown1.Click += new System.EventHandler(this.buttonDown_Click);
                Panel p = new Panel();
                p.BorderStyle = BorderStyle.FixedSingle;
                p.SuspendLayout();
                p.BackColor = SystemColors.GradientInactiveCaption;
                p.Controls.Add(l);
                p.Controls.Add(pbup1);
                p.Controls.Add(pbdown1);
                p.Name = "pnl";
                p.Size = new Size(292, 34);
                p.TabIndex = 0;
                p.Location = new Point(4, position);
                position += 40;
                panelTodo.Controls.Add(p);
            }
            position = 4;
            foreach (Story s in _backLog.DoingStories)
            {
                Label l = new Label();
                l.Dock = DockStyle.Fill;
                l.Font = new Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                l.Location = new Point(0, 0);
                l.Name = "lbl";
                l.Size = new Size(278, 34);
                l.TabIndex = 0;
                l.Text = s.Title;
                l.TextAlign = ContentAlignment.MiddleLeft;
                l.MouseDown += Drag;
                l.Tag = s;
                l.Cursor = Cursors.Hand;
                PictureBox pbup1 = new PictureBox();
                pbup1.Cursor = System.Windows.Forms.Cursors.Hand;
                pbup1.Image = Image.FromFile("up1.png");
                pbup1.Location = new System.Drawing.Point(278, -1);
                pbup1.Size = new System.Drawing.Size(14, 17);
                pbup1.Tag = s;
                pbup1.Click += new System.EventHandler(this.buttonUp_Click);
                PictureBox pbdown1 = new PictureBox();
                pbdown1.Cursor = System.Windows.Forms.Cursors.Hand;
                pbdown1.Image = Image.FromFile("down1.png");
                pbdown1.Location = new System.Drawing.Point(278, 17);
                pbdown1.Size = new System.Drawing.Size(14, 17);
                pbdown1.Tag = s;
                pbdown1.Click += new System.EventHandler(this.buttonDown_Click);
                Panel p = new Panel();
                p.BorderStyle = BorderStyle.FixedSingle;
                p.SuspendLayout();
                p.BackColor = SystemColors.GradientInactiveCaption;
                p.Controls.Add(l);
                p.Controls.Add(pbup1);
                p.Controls.Add(pbdown1);
                p.Name = "pnl";
                p.Size = new Size(292, 34);
                p.TabIndex = 0;
                p.Location = new Point(4, position);
                position += 40;
                panelDoing.Controls.Add(p);
            }
            position = 4;
            foreach (Story s in _backLog.DoneStories)
            {
                Label l = new Label();
                l.Dock = DockStyle.Fill;
                l.Font = new Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                l.Location = new Point(0, 0);
                l.Name = "lbl";
                l.Size = new Size(278, 34);
                l.TabIndex = 0;
                l.Text = s.Title;
                l.TextAlign = ContentAlignment.MiddleLeft;
                l.MouseDown += Drag;
                l.Tag = s;
                l.Cursor = Cursors.Hand;
                PictureBox pbup1 = new PictureBox();
                pbup1.Cursor = System.Windows.Forms.Cursors.Hand;
                pbup1.Image = Image.FromFile("up1.png");
                pbup1.Location = new System.Drawing.Point(278, -1);
                pbup1.Size = new System.Drawing.Size(14, 17);
                pbup1.Tag = s;
                pbup1.Click += new System.EventHandler(this.buttonUp_Click);
                PictureBox pbdown1 = new PictureBox();
                pbdown1.Cursor = System.Windows.Forms.Cursors.Hand;
                pbdown1.Image = Image.FromFile("down1.png");
                pbdown1.Location = new System.Drawing.Point(278, 17);
                pbdown1.Size = new System.Drawing.Size(14, 17);
                pbdown1.Tag = s;
                pbdown1.Click += new System.EventHandler(this.buttonDown_Click);
                Panel p = new Panel();
                p.BorderStyle = BorderStyle.FixedSingle;
                p.SuspendLayout();
                p.BackColor = SystemColors.GradientInactiveCaption;
                p.Controls.Add(l);
                p.Controls.Add(pbup1);
                p.Controls.Add(pbdown1);
                p.Name = "pnl";
                p.Size = new Size(292, 34);
                p.TabIndex = 0;
                p.Location = new Point(4, position);
                position += 40;
                panelDone.Controls.Add(p);
            }
            panelBacklog.Refresh();
            panelTodo.Refresh();
            panelDoing.Refresh();
            panelDone.Refresh();
        }

        private void Drag(object sender, MouseEventArgs mouseEventArgs)
        {
            ((Label)sender).DoDragDrop(((Story)((Label)sender).Tag).Id, DragDropEffects.Copy);
        }

        private void dropShadow(object sender, PaintEventArgs e)
        {
            var panel = (Panel)sender;
            var shadow = new Color[3];
            shadow[0] = Color.FromArgb(181, 181, 181);
            shadow[1] = Color.FromArgb(195, 195, 195);
            shadow[2] = Color.FromArgb(211, 211, 211);
            var pen = new Pen(shadow[0]);
            using (pen)
            {
                foreach (Control p in panel.Controls)
                {
                    if (p is Panel)
                    {
                        var ptu = p.Location;
                        ptu.Y += p.Height;
                        var pts = p.Location;
                        pts.X += p.Width;
                        for (var sp = 0; sp < 3; sp++)
                        {
                            pen.Color = shadow[sp];
                            e.Graphics.DrawLine(pen, ptu.X, ptu.Y, ptu.X + p.Width + sp, ptu.Y);
                            e.Graphics.DrawLine(pen, pts.X, pts.Y, pts.X, pts.Y + p.Height + sp);
                            ptu.Y++;
                            pts.X++;
                        }
                    }
                }
            }
        }

        private void panelTodo_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void panelTodo_DragDrop(object sender, DragEventArgs e)
        {
            String storyGuid = e.Data.GetData(DataFormats.Text).ToString();
            _backLog.MoveStory(storyGuid, "TODO");
            RefreshScreen();
        }

        private void panelBacklog_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void panelBacklog_DragDrop(object sender, DragEventArgs e)
        {
            String storyGuid = e.Data.GetData(DataFormats.Text).ToString();
            _backLog.MoveStory(storyGuid, "BACKLOG");
            RefreshScreen();
        }

        private void panelDoing_DragDrop(object sender, DragEventArgs e)
        {
            String storyGuid = e.Data.GetData(DataFormats.Text).ToString();
            _backLog.MoveStory(storyGuid, "DOING");
            RefreshScreen();
        }

        private void panelDoing_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void panelDone_DragDrop(object sender, DragEventArgs e)
        {
            String storyGuid = e.Data.GetData(DataFormats.Text).ToString();
            _backLog.MoveStory(storyGuid, "DONE");
            RefreshScreen();
        }

        private void panelDone_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _dialog = new InputDialog();
            _dialog.ShowDialog(this);
            if (_dialog.Title != "")
                _backLog.AddStory(new Story(_dialog.Title, _dialog.Description));
            RefreshScreen();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            
            RefreshScreen();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            
            RefreshScreen();
        }
    }
}
