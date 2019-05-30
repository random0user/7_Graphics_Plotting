namespace Lab3Gauss
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LeftBorderText = new System.Windows.Forms.TextBox();
            this.RightBorderText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AmountOfPointsText = new System.Windows.Forms.TextBox();
            this.tofile = new System.Windows.Forms.Button();
            this.plot = new System.Windows.Forms.Button();
            this.NodesAmountGroupBox = new System.Windows.Forms.GroupBox();
            this.Nodes_4 = new System.Windows.Forms.RadioButton();
            this.Nodes_3 = new System.Windows.Forms.RadioButton();
            this.Nodes_2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.IntegralValueText = new System.Windows.Forms.TextBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NodesAmountGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Граница слева";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Граница справа";
            // 
            // LeftBorderText
            // 
            this.LeftBorderText.Location = new System.Drawing.Point(99, 12);
            this.LeftBorderText.Name = "LeftBorderText";
            this.LeftBorderText.Size = new System.Drawing.Size(93, 20);
            this.LeftBorderText.TabIndex = 3;
            this.LeftBorderText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LeftBorderText_KeyPress);
            // 
            // RightBorderText
            // 
            this.RightBorderText.Location = new System.Drawing.Point(99, 35);
            this.RightBorderText.Name = "RightBorderText";
            this.RightBorderText.Size = new System.Drawing.Size(93, 20);
            this.RightBorderText.TabIndex = 4;
            this.RightBorderText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RightBorderText_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Кол-во точек";
            // 
            // AmountOfPointsText
            // 
            this.AmountOfPointsText.Location = new System.Drawing.Point(99, 60);
            this.AmountOfPointsText.Name = "AmountOfPointsText";
            this.AmountOfPointsText.Size = new System.Drawing.Size(93, 20);
            this.AmountOfPointsText.TabIndex = 6;
            this.AmountOfPointsText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountOfPointsText_KeyPress);
            // 
            // tofile
            // 
            this.tofile.Location = new System.Drawing.Point(14, 86);
            this.tofile.Name = "tofile";
            this.tofile.Size = new System.Drawing.Size(188, 45);
            this.tofile.TabIndex = 7;
            this.tofile.Text = "Запись значений функции в файл";
            this.tofile.UseVisualStyleBackColor = true;
            this.tofile.Click += new System.EventHandler(this.tofile_Click);
            // 
            // plot
            // 
            this.plot.Location = new System.Drawing.Point(12, 185);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(190, 45);
            this.plot.TabIndex = 8;
            this.plot.Text = "Построить график";
            this.plot.UseVisualStyleBackColor = true;
            this.plot.Click += new System.EventHandler(this.plot_Click);
            // 
            // NodesAmountGroupBox
            // 
            this.NodesAmountGroupBox.Controls.Add(this.Nodes_4);
            this.NodesAmountGroupBox.Controls.Add(this.Nodes_3);
            this.NodesAmountGroupBox.Controls.Add(this.Nodes_2);
            this.NodesAmountGroupBox.Location = new System.Drawing.Point(33, 137);
            this.NodesAmountGroupBox.Name = "NodesAmountGroupBox";
            this.NodesAmountGroupBox.Size = new System.Drawing.Size(150, 42);
            this.NodesAmountGroupBox.TabIndex = 9;
            this.NodesAmountGroupBox.TabStop = false;
            this.NodesAmountGroupBox.Text = "Количество узлов Гаусса";
            // 
            // Nodes_4
            // 
            this.Nodes_4.AutoSize = true;
            this.Nodes_4.Location = new System.Drawing.Point(99, 19);
            this.Nodes_4.Name = "Nodes_4";
            this.Nodes_4.Size = new System.Drawing.Size(31, 17);
            this.Nodes_4.TabIndex = 11;
            this.Nodes_4.Text = "4";
            this.Nodes_4.UseVisualStyleBackColor = true;
            // 
            // Nodes_3
            // 
            this.Nodes_3.AutoSize = true;
            this.Nodes_3.Location = new System.Drawing.Point(62, 19);
            this.Nodes_3.Name = "Nodes_3";
            this.Nodes_3.Size = new System.Drawing.Size(31, 17);
            this.Nodes_3.TabIndex = 10;
            this.Nodes_3.Text = "3";
            this.Nodes_3.UseVisualStyleBackColor = true;
            // 
            // Nodes_2
            // 
            this.Nodes_2.AutoSize = true;
            this.Nodes_2.Checked = true;
            this.Nodes_2.Location = new System.Drawing.Point(25, 19);
            this.Nodes_2.Name = "Nodes_2";
            this.Nodes_2.Size = new System.Drawing.Size(31, 17);
            this.Nodes_2.TabIndex = 0;
            this.Nodes_2.TabStop = true;
            this.Nodes_2.Text = "2";
            this.Nodes_2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Определённый интеграл";
            // 
            // IntegralValueText
            // 
            this.IntegralValueText.Enabled = false;
            this.IntegralValueText.Location = new System.Drawing.Point(30, 260);
            this.IntegralValueText.Name = "IntegralValueText";
            this.IntegralValueText.Size = new System.Drawing.Size(153, 20);
            this.IntegralValueText.TabIndex = 11;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControl1.Location = new System.Drawing.Point(208, 12);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(757, 527);
            this.zedGraphControl1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(462, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "y = exp(-x) * sin(x) * x + x ";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(43, 408);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Разбиений на отрезки при вычислении";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 551);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.IntegralValueText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NodesAmountGroupBox);
            this.Controls.Add(this.plot);
            this.Controls.Add(this.tofile);
            this.Controls.Add(this.AmountOfPointsText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RightBorderText);
            this.Controls.Add(this.LeftBorderText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Лабораторная №3";
            this.NodesAmountGroupBox.ResumeLayout(false);
            this.NodesAmountGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LeftBorderText;
        private System.Windows.Forms.TextBox RightBorderText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AmountOfPointsText;
        private System.Windows.Forms.Button tofile;
        private System.Windows.Forms.Button plot;
        private System.Windows.Forms.GroupBox NodesAmountGroupBox;
        private System.Windows.Forms.RadioButton Nodes_4;
        private System.Windows.Forms.RadioButton Nodes_3;
        private System.Windows.Forms.RadioButton Nodes_2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IntegralValueText;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}

//Из firstpoint
/*private int firstPoint(double x, PointPairList list)
{
    int count = list.Count, grad = 1, first, near;
    if (grad % 2 == 1)
    {
        near = count - 1;
        for (int i = 0; i < count; i++)
        {
            if (x < list[i].X)
            {
                near = i;
                break;
            }
        }
    }
    else
    {
        near = 0;
        double NEAR = Math.Abs(x - list[0].X);
        for (int i = 1; i < count; i++)
        {
            if (Math.Abs(x - list[i].X) < NEAR)
            {
                NEAR = Math.Abs(x - list[i].X);
                near = i;
            }
        }
    }
    first = near - (grad + 1) / 2;
    if (first > count - 1 - grad) first = count - 1 - grad;
    if (first < 0)
    { first = 0; }
    return first;
}*/