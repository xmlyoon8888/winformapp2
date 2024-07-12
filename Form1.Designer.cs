namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox10 = new GroupBox();
            btn_result = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_plus = new Button();
            btn_point = new Button();
            btn_0 = new Button();
            btn_clear = new Button();
            btn_sub = new Button();
            btn_3 = new Button();
            btn_2 = new Button();
            btn_1 = new Button();
            btn_mul = new Button();
            btn_6 = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            btn_div = new Button();
            btn_9 = new Button();
            btn_8 = new Button();
            btn_7 = new Button();
            display = new Label();
            groupBox10.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(btn_result);
            groupBox10.Controls.Add(tableLayoutPanel1);
            groupBox10.Controls.Add(display);
            groupBox10.Dock = DockStyle.Top;
            groupBox10.Location = new Point(0, 0);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(525, 405);
            groupBox10.TabIndex = 0;
            groupBox10.TabStop = false;
            groupBox10.Text = "계산기";
            // 
            // btn_result
            // 
            btn_result.Dock = DockStyle.Bottom;
            btn_result.Location = new Point(3, 352);
            btn_result.Name = "btn_result";
            btn_result.Size = new Size(519, 50);
            btn_result.TabIndex = 9;
            btn_result.Text = "=";
            btn_result.UseVisualStyleBackColor = true;
            btn_result.Click += btn_result_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btn_plus, 3, 3);
            tableLayoutPanel1.Controls.Add(btn_point, 2, 3);
            tableLayoutPanel1.Controls.Add(btn_0, 1, 3);
            tableLayoutPanel1.Controls.Add(btn_clear, 0, 3);
            tableLayoutPanel1.Controls.Add(btn_sub, 3, 2);
            tableLayoutPanel1.Controls.Add(btn_3, 2, 2);
            tableLayoutPanel1.Controls.Add(btn_2, 1, 2);
            tableLayoutPanel1.Controls.Add(btn_1, 0, 2);
            tableLayoutPanel1.Controls.Add(btn_mul, 3, 1);
            tableLayoutPanel1.Controls.Add(btn_6, 2, 1);
            tableLayoutPanel1.Controls.Add(btn_5, 1, 1);
            tableLayoutPanel1.Controls.Add(btn_4, 0, 1);
            tableLayoutPanel1.Controls.Add(btn_div, 3, 0);
            tableLayoutPanel1.Controls.Add(btn_9, 2, 0);
            tableLayoutPanel1.Controls.Add(btn_8, 1, 0);
            tableLayoutPanel1.Controls.Add(btn_7, 0, 0);
            tableLayoutPanel1.Location = new Point(10, 75);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(484, 275);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // btn_plus
            // 
            btn_plus.Dock = DockStyle.Top;
            btn_plus.Location = new Point(366, 207);
            btn_plus.Name = "btn_plus";
            btn_plus.Size = new Size(115, 65);
            btn_plus.TabIndex = 15;
            btn_plus.Text = "+";
            btn_plus.UseVisualStyleBackColor = true;
            btn_plus.Click += btn_plus_Click;
            // 
            // btn_point
            // 
            btn_point.Dock = DockStyle.Top;
            btn_point.Location = new Point(245, 207);
            btn_point.Name = "btn_point";
            btn_point.Size = new Size(115, 65);
            btn_point.TabIndex = 14;
            btn_point.Text = ".";
            btn_point.UseVisualStyleBackColor = true;
            btn_point.Click += btn_point_Click;
            // 
            // btn_0
            // 
            btn_0.Dock = DockStyle.Top;
            btn_0.Location = new Point(124, 207);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(115, 65);
            btn_0.TabIndex = 13;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += btn_0_Click;
            // 
            // btn_clear
            // 
            btn_clear.Dock = DockStyle.Top;
            btn_clear.Location = new Point(3, 207);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(115, 65);
            btn_clear.TabIndex = 12;
            btn_clear.Text = "AC";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_sub
            // 
            btn_sub.Dock = DockStyle.Top;
            btn_sub.Location = new Point(366, 139);
            btn_sub.Name = "btn_sub";
            btn_sub.Size = new Size(115, 62);
            btn_sub.TabIndex = 11;
            btn_sub.Text = "-";
            btn_sub.UseVisualStyleBackColor = true;
            btn_sub.Click += btn_sub_Click;
            // 
            // btn_3
            // 
            btn_3.Dock = DockStyle.Top;
            btn_3.Location = new Point(245, 139);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(115, 62);
            btn_3.TabIndex = 10;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += btn_3_Click;
            // 
            // btn_2
            // 
            btn_2.Dock = DockStyle.Top;
            btn_2.Location = new Point(124, 139);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(115, 62);
            btn_2.TabIndex = 9;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += btn_2_Click;
            // 
            // btn_1
            // 
            btn_1.Dock = DockStyle.Top;
            btn_1.Location = new Point(3, 139);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(115, 62);
            btn_1.TabIndex = 8;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_1_Click;
            // 
            // btn_mul
            // 
            btn_mul.Dock = DockStyle.Top;
            btn_mul.Location = new Point(366, 71);
            btn_mul.Name = "btn_mul";
            btn_mul.Size = new Size(115, 62);
            btn_mul.TabIndex = 7;
            btn_mul.Text = "x";
            btn_mul.UseVisualStyleBackColor = true;
            btn_mul.Click += btn_mul_Click;
            // 
            // btn_6
            // 
            btn_6.Dock = DockStyle.Top;
            btn_6.Location = new Point(245, 71);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(115, 62);
            btn_6.TabIndex = 6;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += btn_6_Click;
            // 
            // btn_5
            // 
            btn_5.Dock = DockStyle.Top;
            btn_5.Location = new Point(124, 71);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(115, 62);
            btn_5.TabIndex = 5;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += btn_5_Click;
            // 
            // btn_4
            // 
            btn_4.Dock = DockStyle.Top;
            btn_4.Location = new Point(3, 71);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(115, 62);
            btn_4.TabIndex = 4;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += btn_4_Click;
            // 
            // btn_div
            // 
            btn_div.Dock = DockStyle.Top;
            btn_div.Location = new Point(366, 3);
            btn_div.Name = "btn_div";
            btn_div.Size = new Size(115, 62);
            btn_div.TabIndex = 3;
            btn_div.Text = "/";
            btn_div.UseVisualStyleBackColor = true;
            btn_div.Click += btn_div_Click;
            // 
            // btn_9
            // 
            btn_9.Dock = DockStyle.Top;
            btn_9.Location = new Point(245, 3);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(115, 62);
            btn_9.TabIndex = 2;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += btn_9_Click;
            // 
            // btn_8
            // 
            btn_8.Dock = DockStyle.Top;
            btn_8.Location = new Point(124, 3);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(115, 62);
            btn_8.TabIndex = 1;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += btn_8_Click;
            // 
            // btn_7
            // 
            btn_7.Dock = DockStyle.Top;
            btn_7.Location = new Point(3, 3);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(115, 62);
            btn_7.TabIndex = 0;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += btn_7_Click;
            // 
            // display
            // 
            display.AutoSize = true;
            display.Dock = DockStyle.Fill;
            display.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            display.Location = new Point(3, 19);
            display.Name = "display";
            display.Size = new Size(38, 32);
            display.TabIndex = 7;
            display.Text = "   ";
            display.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 441);
            Controls.Add(groupBox10);
            Name = "Form1";
            Text = "윤남주계산기";
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox10;
        private Label display;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_plus;
        private Button btn_point;
        private Button btn_0;
        private Button btn_clear;
        private Button btn_sub;
        private Button btn_3;
        private Button btn_2;
        private Button btn_1;
        private Button btn_mul;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button btn_div;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private Button btn_result;
    }
}
