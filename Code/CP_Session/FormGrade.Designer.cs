namespace CP_Session
{
    partial class FormGrade
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrade));
            this.buttonOKGrade = new System.Windows.Forms.Button();
            this.buttonCancelGrade = new System.Windows.Forms.Button();
            this.textBoxNameDiscipline = new System.Windows.Forms.TextBox();
            this.labelNameDiscipline = new System.Windows.Forms.Label();
            this.labelSemester = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.numericUpDownSemester = new System.Windows.Forms.NumericUpDown();
            this.comboBoxScore = new System.Windows.Forms.ComboBox();
            this.errorProviderGrade = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSemester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOKGrade
            // 
            this.buttonOKGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOKGrade.Location = new System.Drawing.Point(57, 151);
            this.buttonOKGrade.Name = "buttonOKGrade";
            this.buttonOKGrade.Size = new System.Drawing.Size(100, 25);
            this.buttonOKGrade.TabIndex = 0;
            this.buttonOKGrade.Text = "ОК";
            this.buttonOKGrade.UseVisualStyleBackColor = true;
            this.buttonOKGrade.Click += new System.EventHandler(this.btOKGrade_Click);
            // 
            // buttonCancelGrade
            // 
            this.buttonCancelGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancelGrade.Location = new System.Drawing.Point(337, 151);
            this.buttonCancelGrade.Name = "buttonCancelGrade";
            this.buttonCancelGrade.Size = new System.Drawing.Size(100, 25);
            this.buttonCancelGrade.TabIndex = 0;
            this.buttonCancelGrade.Text = "Отмена";
            this.buttonCancelGrade.UseVisualStyleBackColor = true;
            this.buttonCancelGrade.Click += new System.EventHandler(this.buttonCancelGrade_Click);
            // 
            // textBoxNameDiscipline
            // 
            this.textBoxNameDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameDiscipline.Location = new System.Drawing.Point(137, 52);
            this.textBoxNameDiscipline.Multiline = true;
            this.textBoxNameDiscipline.Name = "textBoxNameDiscipline";
            this.textBoxNameDiscipline.Size = new System.Drawing.Size(338, 25);
            this.textBoxNameDiscipline.TabIndex = 1;
            this.textBoxNameDiscipline.TextChanged += new System.EventHandler(this.textBoxNameDiscipline_TextChanged);
            this.textBoxNameDiscipline.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNameDiscipline_Validating);
            // 
            // labelNameDiscipline
            // 
            this.labelNameDiscipline.AutoSize = true;
            this.labelNameDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameDiscipline.Location = new System.Drawing.Point(21, 55);
            this.labelNameDiscipline.Name = "labelNameDiscipline";
            this.labelNameDiscipline.Size = new System.Drawing.Size(93, 18);
            this.labelNameDiscipline.TabIndex = 2;
            this.labelNameDiscipline.Text = "Дисциплина";
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSemester.Location = new System.Drawing.Point(45, 18);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(69, 18);
            this.labelSemester.TabIndex = 2;
            this.labelSemester.Text = "Семестр";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.Location = new System.Drawing.Point(54, 96);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(60, 18);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "Оценка";
            // 
            // numericUpDownSemester
            // 
            this.numericUpDownSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownSemester.Location = new System.Drawing.Point(137, 16);
            this.numericUpDownSemester.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSemester.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSemester.Name = "numericUpDownSemester";
            this.numericUpDownSemester.Size = new System.Drawing.Size(57, 24);
            this.numericUpDownSemester.TabIndex = 3;
            this.numericUpDownSemester.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxScore
            // 
            this.comboBoxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxScore.FormattingEnabled = true;
            this.comboBoxScore.Items.AddRange(new object[] {
            "отлично",
            "хорошо",
            "удовлетворительно",
            "неудовлетворительно",
            "неявка"});
            this.comboBoxScore.Location = new System.Drawing.Point(137, 93);
            this.comboBoxScore.Name = "comboBoxScore";
            this.comboBoxScore.Size = new System.Drawing.Size(274, 26);
            this.comboBoxScore.TabIndex = 4;
            this.comboBoxScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxScore_KeyPress);
            this.comboBoxScore.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxScore_Validating);
            // 
            // errorProviderGrade
            // 
            this.errorProviderGrade.ContainerControl = this;
            // 
            // FormGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 202);
            this.Controls.Add(this.comboBoxScore);
            this.Controls.Add(this.numericUpDownSemester);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.labelNameDiscipline);
            this.Controls.Add(this.textBoxNameDiscipline);
            this.Controls.Add(this.buttonCancelGrade);
            this.Controls.Add(this.buttonOKGrade);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGrade";
            this.Text = "Редактирование оценки";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSemester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOKGrade;
        private System.Windows.Forms.Button buttonCancelGrade;
        private System.Windows.Forms.TextBox textBoxNameDiscipline;
        private System.Windows.Forms.Label labelNameDiscipline;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.NumericUpDown numericUpDownSemester;
        private System.Windows.Forms.ComboBox comboBoxScore;
        private System.Windows.Forms.ErrorProvider errorProviderGrade;
    }
}