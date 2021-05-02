
namespace BasketBoard
{
    partial class FormBoard
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_team2_points = new System.Windows.Forms.Label();
            this.label_team1_points = new System.Windows.Forms.Label();
            this.label_team2_name = new System.Windows.Forms.Label();
            this.label_team1_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label_team2_points, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_team1_points, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_team2_name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_team1_name, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-13, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.6988F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.30121F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(828, 410);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_team2_points
            // 
            this.label_team2_points.BackColor = System.Drawing.Color.Black;
            this.label_team2_points.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_team2_points.Font = new System.Drawing.Font("Verdana", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_team2_points.ForeColor = System.Drawing.Color.Red;
            this.label_team2_points.Location = new System.Drawing.Point(417, 101);
            this.label_team2_points.Name = "label_team2_points";
            this.label_team2_points.Size = new System.Drawing.Size(408, 309);
            this.label_team2_points.TabIndex = 3;
            this.label_team2_points.Text = "0";
            this.label_team2_points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_team1_points
            // 
            this.label_team1_points.BackColor = System.Drawing.Color.Black;
            this.label_team1_points.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_team1_points.Font = new System.Drawing.Font("Verdana", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_team1_points.ForeColor = System.Drawing.Color.Red;
            this.label_team1_points.Location = new System.Drawing.Point(3, 101);
            this.label_team1_points.Name = "label_team1_points";
            this.label_team1_points.Size = new System.Drawing.Size(408, 309);
            this.label_team1_points.TabIndex = 2;
            this.label_team1_points.Text = "0";
            this.label_team1_points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_team2_name
            // 
            this.label_team2_name.BackColor = System.Drawing.Color.Black;
            this.label_team2_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_team2_name.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_team2_name.ForeColor = System.Drawing.Color.Red;
            this.label_team2_name.Location = new System.Drawing.Point(417, 0);
            this.label_team2_name.Name = "label_team2_name";
            this.label_team2_name.Size = new System.Drawing.Size(408, 101);
            this.label_team2_name.TabIndex = 1;
            this.label_team2_name.Text = "Team2";
            this.label_team2_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_team1_name
            // 
            this.label_team1_name.BackColor = System.Drawing.Color.Black;
            this.label_team1_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_team1_name.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_team1_name.ForeColor = System.Drawing.Color.Red;
            this.label_team1_name.Location = new System.Drawing.Point(3, 0);
            this.label_team1_name.Name = "label_team1_name";
            this.label_team1_name.Size = new System.Drawing.Size(408, 101);
            this.label_team1_name.TabIndex = 0;
            this.label_team1_name.Text = "Team1";
            this.label_team1_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-10, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 53);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(767, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Х";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Баскетбольное табло";
            // 
            // FormBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBoard";
            this.Text = "Баскетбольное табло";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_team2_points;
        private System.Windows.Forms.Label label_team1_points;
        private System.Windows.Forms.Label label_team2_name;
        private System.Windows.Forms.Label label_team1_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}