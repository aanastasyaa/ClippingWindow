namespace LineClippingWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.windowParameters_groupBox = new System.Windows.Forms.GroupBox();
            this.errorMsgs_richTextBox = new System.Windows.Forms.RichTextBox();
            this.changeWindowParameters_btn = new System.Windows.Forms.Button();
            this.windowTopLeftY_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.windowTopLeftX_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.windowTopLeftY_lbl = new System.Windows.Forms.Label();
            this.windowTopLeftX_lbl = new System.Windows.Forms.Label();
            this.windowLength_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.windowWidth_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.windowTopLeftPoint_lbl = new System.Windows.Forms.Label();
            this.windowLength_lbl = new System.Windows.Forms.Label();
            this.windowWidth_lbl = new System.Windows.Forms.Label();
            this.cleanPictureBox_btn = new System.Windows.Forms.Button();
            this.findSegmentInArea_btn = new System.Windows.Forms.Button();
            this.instruction_richTextBox = new System.Windows.Forms.RichTextBox();
            this.mouseLocation_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.windowParameters_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowTopLeftY_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowTopLeftX_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowLength_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowWidth_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(1, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(548, 447);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseClick);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            // 
            // windowParameters_groupBox
            // 
            this.windowParameters_groupBox.Controls.Add(this.errorMsgs_richTextBox);
            this.windowParameters_groupBox.Controls.Add(this.changeWindowParameters_btn);
            this.windowParameters_groupBox.Controls.Add(this.windowTopLeftY_numericUpDown);
            this.windowParameters_groupBox.Controls.Add(this.windowTopLeftX_numericUpDown);
            this.windowParameters_groupBox.Controls.Add(this.windowTopLeftY_lbl);
            this.windowParameters_groupBox.Controls.Add(this.windowTopLeftX_lbl);
            this.windowParameters_groupBox.Controls.Add(this.windowLength_numericUpDown);
            this.windowParameters_groupBox.Controls.Add(this.windowWidth_numericUpDown);
            this.windowParameters_groupBox.Controls.Add(this.windowTopLeftPoint_lbl);
            this.windowParameters_groupBox.Controls.Add(this.windowLength_lbl);
            this.windowParameters_groupBox.Controls.Add(this.windowWidth_lbl);
            this.windowParameters_groupBox.Location = new System.Drawing.Point(558, 4);
            this.windowParameters_groupBox.Name = "windowParameters_groupBox";
            this.windowParameters_groupBox.Size = new System.Drawing.Size(233, 282);
            this.windowParameters_groupBox.TabIndex = 1;
            this.windowParameters_groupBox.TabStop = false;
            this.windowParameters_groupBox.Text = "Параметры прямоугольного окна";
            // 
            // errorMsgs_richTextBox
            // 
            this.errorMsgs_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorMsgs_richTextBox.Location = new System.Drawing.Point(6, 192);
            this.errorMsgs_richTextBox.Name = "errorMsgs_richTextBox";
            this.errorMsgs_richTextBox.ReadOnly = true;
            this.errorMsgs_richTextBox.Size = new System.Drawing.Size(221, 45);
            this.errorMsgs_richTextBox.TabIndex = 10;
            this.errorMsgs_richTextBox.Text = "";
            // 
            // changeWindowParameters_btn
            // 
            this.changeWindowParameters_btn.Location = new System.Drawing.Point(78, 247);
            this.changeWindowParameters_btn.Name = "changeWindowParameters_btn";
            this.changeWindowParameters_btn.Size = new System.Drawing.Size(75, 29);
            this.changeWindowParameters_btn.TabIndex = 9;
            this.changeWindowParameters_btn.Text = "Изменить";
            this.changeWindowParameters_btn.UseVisualStyleBackColor = true;
            this.changeWindowParameters_btn.Click += new System.EventHandler(this.ChangeWindowParameters_btn_Click);
            // 
            // windowTopLeftY_numericUpDown
            // 
            this.windowTopLeftY_numericUpDown.Location = new System.Drawing.Point(87, 166);
            this.windowTopLeftY_numericUpDown.Name = "windowTopLeftY_numericUpDown";
            this.windowTopLeftY_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.windowTopLeftY_numericUpDown.TabIndex = 8;
            this.windowTopLeftY_numericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // windowTopLeftX_numericUpDown
            // 
            this.windowTopLeftX_numericUpDown.Location = new System.Drawing.Point(87, 131);
            this.windowTopLeftX_numericUpDown.Name = "windowTopLeftX_numericUpDown";
            this.windowTopLeftX_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.windowTopLeftX_numericUpDown.TabIndex = 7;
            this.windowTopLeftX_numericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // windowTopLeftY_lbl
            // 
            this.windowTopLeftY_lbl.AutoSize = true;
            this.windowTopLeftY_lbl.Location = new System.Drawing.Point(20, 167);
            this.windowTopLeftY_lbl.Name = "windowTopLeftY_lbl";
            this.windowTopLeftY_lbl.Size = new System.Drawing.Size(14, 13);
            this.windowTopLeftY_lbl.TabIndex = 6;
            this.windowTopLeftY_lbl.Text = "Y";
            // 
            // windowTopLeftX_lbl
            // 
            this.windowTopLeftX_lbl.AutoSize = true;
            this.windowTopLeftX_lbl.Location = new System.Drawing.Point(19, 133);
            this.windowTopLeftX_lbl.Name = "windowTopLeftX_lbl";
            this.windowTopLeftX_lbl.Size = new System.Drawing.Size(14, 13);
            this.windowTopLeftX_lbl.TabIndex = 5;
            this.windowTopLeftX_lbl.Text = "X";
            // 
            // windowLength_numericUpDown
            // 
            this.windowLength_numericUpDown.Location = new System.Drawing.Point(87, 64);
            this.windowLength_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.windowLength_numericUpDown.Name = "windowLength_numericUpDown";
            this.windowLength_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.windowLength_numericUpDown.TabIndex = 4;
            this.windowLength_numericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // windowWidth_numericUpDown
            // 
            this.windowWidth_numericUpDown.Location = new System.Drawing.Point(87, 30);
            this.windowWidth_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.windowWidth_numericUpDown.Name = "windowWidth_numericUpDown";
            this.windowWidth_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.windowWidth_numericUpDown.TabIndex = 3;
            this.windowWidth_numericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // windowTopLeftPoint_lbl
            // 
            this.windowTopLeftPoint_lbl.AutoSize = true;
            this.windowTopLeftPoint_lbl.Location = new System.Drawing.Point(18, 100);
            this.windowTopLeftPoint_lbl.Name = "windowTopLeftPoint_lbl";
            this.windowTopLeftPoint_lbl.Size = new System.Drawing.Size(181, 13);
            this.windowTopLeftPoint_lbl.TabIndex = 2;
            this.windowTopLeftPoint_lbl.Text = "Координаты верхнего левого угла";
            // 
            // windowLength_lbl
            // 
            this.windowLength_lbl.AutoSize = true;
            this.windowLength_lbl.Location = new System.Drawing.Point(17, 64);
            this.windowLength_lbl.Name = "windowLength_lbl";
            this.windowLength_lbl.Size = new System.Drawing.Size(40, 13);
            this.windowLength_lbl.TabIndex = 1;
            this.windowLength_lbl.Text = "Длина";
            // 
            // windowWidth_lbl
            // 
            this.windowWidth_lbl.AutoSize = true;
            this.windowWidth_lbl.Location = new System.Drawing.Point(16, 30);
            this.windowWidth_lbl.Name = "windowWidth_lbl";
            this.windowWidth_lbl.Size = new System.Drawing.Size(46, 13);
            this.windowWidth_lbl.TabIndex = 0;
            this.windowWidth_lbl.Text = "Ширина";
            // 
            // cleanPictureBox_btn
            // 
            this.cleanPictureBox_btn.Location = new System.Drawing.Point(558, 292);
            this.cleanPictureBox_btn.Name = "cleanPictureBox_btn";
            this.cleanPictureBox_btn.Size = new System.Drawing.Size(233, 31);
            this.cleanPictureBox_btn.TabIndex = 2;
            this.cleanPictureBox_btn.Text = "Очистить";
            this.cleanPictureBox_btn.UseVisualStyleBackColor = true;
            this.cleanPictureBox_btn.Click += new System.EventHandler(this.CleanPictureBox_btn_Click);
            // 
            // findSegmentInArea_btn
            // 
            this.findSegmentInArea_btn.Location = new System.Drawing.Point(558, 329);
            this.findSegmentInArea_btn.Name = "findSegmentInArea_btn";
            this.findSegmentInArea_btn.Size = new System.Drawing.Size(233, 31);
            this.findSegmentInArea_btn.TabIndex = 3;
            this.findSegmentInArea_btn.Text = "Найти отрезки";
            this.findSegmentInArea_btn.UseVisualStyleBackColor = true;
            this.findSegmentInArea_btn.Click += new System.EventHandler(this.FindSegmentInArea_btn_Click);
            // 
            // instruction_richTextBox
            // 
            this.instruction_richTextBox.Location = new System.Drawing.Point(558, 366);
            this.instruction_richTextBox.Name = "instruction_richTextBox";
            this.instruction_richTextBox.Size = new System.Drawing.Size(230, 98);
            this.instruction_richTextBox.TabIndex = 5;
            this.instruction_richTextBox.Text = resources.GetString("instruction_richTextBox.Text");
            // 
            // mouseLocation_lbl
            // 
            this.mouseLocation_lbl.AutoSize = true;
            this.mouseLocation_lbl.Location = new System.Drawing.Point(238, 451);
            this.mouseLocation_lbl.Name = "mouseLocation_lbl";
            this.mouseLocation_lbl.Size = new System.Drawing.Size(0, 13);
            this.mouseLocation_lbl.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.mouseLocation_lbl);
            this.Controls.Add(this.instruction_richTextBox);
            this.Controls.Add(this.findSegmentInArea_btn);
            this.Controls.Add(this.cleanPictureBox_btn);
            this.Controls.Add(this.windowParameters_groupBox);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Нахождение видимых или частично видимых отрезков в прямоугольном окне";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.windowParameters_groupBox.ResumeLayout(false);
            this.windowParameters_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowTopLeftY_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowTopLeftX_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowLength_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowWidth_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox windowParameters_groupBox;
        private System.Windows.Forms.Button cleanPictureBox_btn;
        private System.Windows.Forms.Button findSegmentInArea_btn;
        private System.Windows.Forms.Button changeWindowParameters_btn;
        private System.Windows.Forms.NumericUpDown windowTopLeftY_numericUpDown;
        private System.Windows.Forms.NumericUpDown windowTopLeftX_numericUpDown;
        private System.Windows.Forms.Label windowTopLeftY_lbl;
        private System.Windows.Forms.Label windowTopLeftX_lbl;
        private System.Windows.Forms.NumericUpDown windowLength_numericUpDown;
        private System.Windows.Forms.NumericUpDown windowWidth_numericUpDown;
        private System.Windows.Forms.Label windowTopLeftPoint_lbl;
        private System.Windows.Forms.Label windowLength_lbl;
        private System.Windows.Forms.Label windowWidth_lbl;
        private System.Windows.Forms.RichTextBox instruction_richTextBox;
        private System.Windows.Forms.Label mouseLocation_lbl;
        private System.Windows.Forms.RichTextBox errorMsgs_richTextBox;
    }
}

