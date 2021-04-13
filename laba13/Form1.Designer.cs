
namespace Laba_2
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
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.comboBoxB = new System.Windows.Forms.ComboBox();
            this.comboBoxA = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.labelN = new System.Windows.Forms.Label();
            this.labelI = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelJ = new System.Windows.Forms.Label();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.labelR = new System.Windows.Forms.Label();
            this.toolTipYR1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipYr2 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(57, 34);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 0;
            this.textBoxX.Text = "0";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(31, 32);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(20, 24);
            this.labelX.TabIndex = 4;
            this.labelX.Text = "x";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB.Location = new System.Drawing.Point(168, 34);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(21, 24);
            this.labelB.TabIndex = 6;
            this.labelB.Text = "b";
            // 
            // comboBoxB
            // 
            this.comboBoxB.FormattingEnabled = true;
            this.comboBoxB.Items.AddRange(new object[] {
            "0",
            "1",
            "4",
            "6",
            "8",
            "12",
            "435",
            "1234"});
            this.comboBoxB.Location = new System.Drawing.Point(195, 37);
            this.comboBoxB.Name = "comboBoxB";
            this.comboBoxB.Size = new System.Drawing.Size(121, 21);
            this.comboBoxB.TabIndex = 10;
            this.comboBoxB.Text = "Выберите число";
            // 
            // comboBoxA
            // 
            this.comboBoxA.FormattingEnabled = true;
            this.comboBoxA.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "7",
            "23",
            "433"});
            this.comboBoxA.Location = new System.Drawing.Point(195, 84);
            this.comboBoxA.Name = "comboBoxA";
            this.comboBoxA.Size = new System.Drawing.Size(121, 21);
            this.comboBoxA.TabIndex = 11;
            this.comboBoxA.Text = "Выберите число";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(32, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Уравнение 1";
            this.toolTipYR1.SetToolTip(this.radioButton1, "Для уравнения 1 нужно ввести значения N и X");
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(32, 67);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(90, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Уравнение 2";
            this.toolTipYr2.SetToolTip(this.radioButton2, "Для уравнения 2 нужно ввести переменные N, R, a, b.");
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(332, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 108);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите уравнение";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(57, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 81);
            this.button1.TabIndex = 15;
            this.button1.Text = "Посчитать ответ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(508, 230);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(140, 20);
            this.textBoxAnswer.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Laba_2.Properties.Resources.Снимок;
            this.pictureBox2.Location = new System.Drawing.Point(508, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(267, 119);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Laba_2.Properties.Resources.answer;
            this.pictureBox1.Image = global::Laba_2.Properties.Resources.answer1;
            this.pictureBox1.InitialImage = global::Laba_2.Properties.Resources.answer;
            this.pictureBox1.Location = new System.Drawing.Point(304, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(57, 90);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 20);
            this.textBoxN.TabIndex = 19;
            this.textBoxN.Text = "0";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.Location = new System.Drawing.Point(27, 86);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(24, 24);
            this.labelN.TabIndex = 20;
            this.labelN.Text = "N";
            // 
            // labelI
            // 
            this.labelI.AutoSize = true;
            this.labelI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelI.Location = new System.Drawing.Point(37, 124);
            this.labelI.Name = "labelI";
            this.labelI.Size = new System.Drawing.Size(30, 24);
            this.labelI.TabIndex = 5;
            this.labelI.Text = "    ";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(169, 81);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(20, 24);
            this.labelA.TabIndex = 7;
            this.labelA.Text = "a";
            // 
            // labelJ
            // 
            this.labelJ.AutoSize = true;
            this.labelJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelJ.Location = new System.Drawing.Point(37, 76);
            this.labelJ.Name = "labelJ";
            this.labelJ.Size = new System.Drawing.Size(30, 24);
            this.labelJ.TabIndex = 9;
            this.labelJ.Text = "    ";
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(57, 136);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(100, 20);
            this.textBoxR.TabIndex = 21;
            this.textBoxR.Text = "0";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelR.Location = new System.Drawing.Point(27, 132);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(23, 24);
            this.labelR.TabIndex = 22;
            this.labelR.Text = "R";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 334);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxA);
            this.Controls.Add(this.comboBoxB);
            this.Controls.Add(this.labelJ);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelI);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "    ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.ComboBox comboBoxB;
        private System.Windows.Forms.ComboBox comboBoxA;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelI;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelJ;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.ToolTip toolTipYR1;
        private System.Windows.Forms.ToolTip toolTipYr2;
    }
}

