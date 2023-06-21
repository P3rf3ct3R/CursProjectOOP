namespace CP_Session
{
    partial class FormEditStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditStudent));
            this.buttonOKStudent = new System.Windows.Forms.Button();
            this.buttonCancelStudent = new System.Windows.Forms.Button();
            this.textBoxFaculty = new System.Windows.Forms.TextBox();
            this.labelFaculty = new System.Windows.Forms.Label();
            this.textBoxSpecialty = new System.Windows.Forms.TextBox();
            this.labelSpecialty = new System.Windows.Forms.Label();
            this.labelYearOfStudy = new System.Windows.Forms.Label();
            this.labelFormOfStudy = new System.Windows.Forms.Label();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.textBoxSurnameStudent = new System.Windows.Forms.TextBox();
            this.labelNameStudent = new System.Windows.Forms.Label();
            this.textBoxPatronymicStudent = new System.Windows.Forms.TextBox();
            this.labelSurnameStudent = new System.Windows.Forms.Label();
            this.textBoxNameStudent = new System.Windows.Forms.TextBox();
            this.labelPatronymicStudent = new System.Windows.Forms.Label();
            this.labelIdStudent = new System.Windows.Forms.Label();
            this.pickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.comboBoxFormOfStudy = new System.Windows.Forms.ComboBox();
            this.numericYearOfStudy = new System.Windows.Forms.NumericUpDown();
            this.textBoxIdStudent = new System.Windows.Forms.MaskedTextBox();
            this.errorProviderStudent = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericYearOfStudy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOKStudent
            // 
            this.buttonOKStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOKStudent.Location = new System.Drawing.Point(44, 287);
            this.buttonOKStudent.Name = "buttonOKStudent";
            this.buttonOKStudent.Size = new System.Drawing.Size(100, 25);
            this.buttonOKStudent.TabIndex = 11;
            this.buttonOKStudent.Text = "ОК";
            this.buttonOKStudent.UseVisualStyleBackColor = true;
            this.buttonOKStudent.Click += new System.EventHandler(this.buttonOKStudent_Click);
            // 
            // buttonCancelStudent
            // 
            this.buttonCancelStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancelStudent.Location = new System.Drawing.Point(324, 287);
            this.buttonCancelStudent.Name = "buttonCancelStudent";
            this.buttonCancelStudent.Size = new System.Drawing.Size(100, 25);
            this.buttonCancelStudent.TabIndex = 12;
            this.buttonCancelStudent.Text = "Отмена";
            this.buttonCancelStudent.UseVisualStyleBackColor = true;
            this.buttonCancelStudent.Click += new System.EventHandler(this.buttonCancelStudent_Click);
            // 
            // textBoxFaculty
            // 
            this.textBoxFaculty.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFaculty.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFaculty.Location = new System.Drawing.Point(244, 224);
            this.textBoxFaculty.Name = "textBoxFaculty";
            this.textBoxFaculty.Size = new System.Drawing.Size(180, 24);
            this.textBoxFaculty.TabIndex = 10;
            this.textBoxFaculty.Text = "ФВТ";
            this.textBoxFaculty.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // labelFaculty
            // 
            this.labelFaculty.AutoSize = true;
            this.labelFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFaculty.Location = new System.Drawing.Point(241, 203);
            this.labelFaculty.Name = "labelFaculty";
            this.labelFaculty.Size = new System.Drawing.Size(91, 18);
            this.labelFaculty.TabIndex = 11;
            this.labelFaculty.Text = "Факультет :";
            // 
            // textBoxSpecialty
            // 
            this.textBoxSpecialty.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSpecialty.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSpecialty.Location = new System.Drawing.Point(44, 224);
            this.textBoxSpecialty.Multiline = true;
            this.textBoxSpecialty.Name = "textBoxSpecialty";
            this.textBoxSpecialty.Size = new System.Drawing.Size(180, 48);
            this.textBoxSpecialty.TabIndex = 9;
            this.textBoxSpecialty.Text = "Программная инженерия";
            this.textBoxSpecialty.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // labelSpecialty
            // 
            this.labelSpecialty.AutoSize = true;
            this.labelSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpecialty.Location = new System.Drawing.Point(41, 203);
            this.labelSpecialty.Name = "labelSpecialty";
            this.labelSpecialty.Size = new System.Drawing.Size(124, 18);
            this.labelSpecialty.TabIndex = 10;
            this.labelSpecialty.Text = "Специальность :";
            // 
            // labelYearOfStudy
            // 
            this.labelYearOfStudy.AutoSize = true;
            this.labelYearOfStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYearOfStudy.Location = new System.Drawing.Point(241, 153);
            this.labelYearOfStudy.Name = "labelYearOfStudy";
            this.labelYearOfStudy.Size = new System.Drawing.Size(112, 18);
            this.labelYearOfStudy.TabIndex = 12;
            this.labelYearOfStudy.Text = "Год обучения :";
            // 
            // labelFormOfStudy
            // 
            this.labelFormOfStudy.AutoSize = true;
            this.labelFormOfStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormOfStudy.Location = new System.Drawing.Point(41, 153);
            this.labelFormOfStudy.Name = "labelFormOfStudy";
            this.labelFormOfStudy.Size = new System.Drawing.Size(134, 18);
            this.labelFormOfStudy.TabIndex = 8;
            this.labelFormOfStudy.Text = "Форма обучения :";
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxGroup.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGroup.Location = new System.Drawing.Point(244, 126);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(180, 24);
            this.textBoxGroup.TabIndex = 6;
            this.textBoxGroup.Text = "19ПИ1";
            this.textBoxGroup.TextChanged += new System.EventHandler(this.textBoxGroup_TextChanged);
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGroup.Location = new System.Drawing.Point(241, 105);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(64, 18);
            this.labelGroup.TabIndex = 3;
            this.labelGroup.Text = "Группа :";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateOfBirth.Location = new System.Drawing.Point(241, 57);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(124, 18);
            this.labelDateOfBirth.TabIndex = 7;
            this.labelDateOfBirth.Text = "Дата рождения :";
            // 
            // textBoxSurnameStudent
            // 
            this.textBoxSurnameStudent.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSurnameStudent.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxSurnameStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurnameStudent.Location = new System.Drawing.Point(44, 78);
            this.textBoxSurnameStudent.Name = "textBoxSurnameStudent";
            this.textBoxSurnameStudent.Size = new System.Drawing.Size(180, 24);
            this.textBoxSurnameStudent.TabIndex = 3;
            this.textBoxSurnameStudent.Text = "Аркадов";
            this.textBoxSurnameStudent.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // labelNameStudent
            // 
            this.labelNameStudent.AutoSize = true;
            this.labelNameStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameStudent.Location = new System.Drawing.Point(41, 9);
            this.labelNameStudent.Name = "labelNameStudent";
            this.labelNameStudent.Size = new System.Drawing.Size(46, 18);
            this.labelNameStudent.TabIndex = 6;
            this.labelNameStudent.Text = "Имя :";
            // 
            // textBoxPatronymicStudent
            // 
            this.textBoxPatronymicStudent.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPatronymicStudent.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxPatronymicStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPatronymicStudent.Location = new System.Drawing.Point(244, 30);
            this.textBoxPatronymicStudent.Name = "textBoxPatronymicStudent";
            this.textBoxPatronymicStudent.Size = new System.Drawing.Size(180, 24);
            this.textBoxPatronymicStudent.TabIndex = 2;
            this.textBoxPatronymicStudent.Text = "Аркадиевич";
            this.textBoxPatronymicStudent.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // labelSurnameStudent
            // 
            this.labelSurnameStudent.AutoSize = true;
            this.labelSurnameStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurnameStudent.Location = new System.Drawing.Point(41, 57);
            this.labelSurnameStudent.Name = "labelSurnameStudent";
            this.labelSurnameStudent.Size = new System.Drawing.Size(81, 18);
            this.labelSurnameStudent.TabIndex = 5;
            this.labelSurnameStudent.Text = "Фамилия :";
            // 
            // textBoxNameStudent
            // 
            this.textBoxNameStudent.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNameStudent.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxNameStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameStudent.Location = new System.Drawing.Point(44, 30);
            this.textBoxNameStudent.Name = "textBoxNameStudent";
            this.textBoxNameStudent.Size = new System.Drawing.Size(180, 24);
            this.textBoxNameStudent.TabIndex = 1;
            this.textBoxNameStudent.Text = "Аркадий";
            this.textBoxNameStudent.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // labelPatronymicStudent
            // 
            this.labelPatronymicStudent.AutoSize = true;
            this.labelPatronymicStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatronymicStudent.Location = new System.Drawing.Point(241, 9);
            this.labelPatronymicStudent.Name = "labelPatronymicStudent";
            this.labelPatronymicStudent.Size = new System.Drawing.Size(91, 18);
            this.labelPatronymicStudent.TabIndex = 4;
            this.labelPatronymicStudent.Text = "Отечество :";
            // 
            // labelIdStudent
            // 
            this.labelIdStudent.AutoSize = true;
            this.labelIdStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIdStudent.Location = new System.Drawing.Point(41, 105);
            this.labelIdStudent.Name = "labelIdStudent";
            this.labelIdStudent.Size = new System.Drawing.Size(131, 18);
            this.labelIdStudent.TabIndex = 9;
            this.labelIdStudent.Text = "Номер карточки :";
            // 
            // pickerDateOfBirth
            // 
            this.pickerDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pickerDateOfBirth.Location = new System.Drawing.Point(244, 78);
            this.pickerDateOfBirth.Name = "pickerDateOfBirth";
            this.pickerDateOfBirth.Size = new System.Drawing.Size(180, 24);
            this.pickerDateOfBirth.TabIndex = 4;
            // 
            // comboBoxFormOfStudy
            // 
            this.comboBoxFormOfStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFormOfStudy.FormattingEnabled = true;
            this.comboBoxFormOfStudy.Items.AddRange(new object[] {
            "очная",
            "заочная"});
            this.comboBoxFormOfStudy.Location = new System.Drawing.Point(44, 174);
            this.comboBoxFormOfStudy.Name = "comboBoxFormOfStudy";
            this.comboBoxFormOfStudy.Size = new System.Drawing.Size(180, 26);
            this.comboBoxFormOfStudy.TabIndex = 7;
            this.comboBoxFormOfStudy.Text = "очная";
            // 
            // numericYearOfStudy
            // 
            this.numericYearOfStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericYearOfStudy.Location = new System.Drawing.Point(244, 176);
            this.numericYearOfStudy.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericYearOfStudy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericYearOfStudy.Name = "numericYearOfStudy";
            this.numericYearOfStudy.Size = new System.Drawing.Size(180, 24);
            this.numericYearOfStudy.TabIndex = 8;
            this.numericYearOfStudy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxIdStudent
            // 
            this.textBoxIdStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIdStudent.Location = new System.Drawing.Point(44, 126);
            this.textBoxIdStudent.Mask = "00000000";
            this.textBoxIdStudent.Name = "textBoxIdStudent";
            this.textBoxIdStudent.Size = new System.Drawing.Size(180, 24);
            this.textBoxIdStudent.TabIndex = 5;
            this.textBoxIdStudent.Text = "12345678";
            // 
            // errorProviderStudent
            // 
            this.errorProviderStudent.ContainerControl = this;
            // 
            // FormEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 324);
            this.Controls.Add(this.textBoxIdStudent);
            this.Controls.Add(this.numericYearOfStudy);
            this.Controls.Add(this.comboBoxFormOfStudy);
            this.Controls.Add(this.pickerDateOfBirth);
            this.Controls.Add(this.textBoxFaculty);
            this.Controls.Add(this.labelFaculty);
            this.Controls.Add(this.textBoxSpecialty);
            this.Controls.Add(this.labelSpecialty);
            this.Controls.Add(this.labelYearOfStudy);
            this.Controls.Add(this.labelFormOfStudy);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.textBoxSurnameStudent);
            this.Controls.Add(this.labelNameStudent);
            this.Controls.Add(this.textBoxPatronymicStudent);
            this.Controls.Add(this.labelSurnameStudent);
            this.Controls.Add(this.textBoxNameStudent);
            this.Controls.Add(this.labelPatronymicStudent);
            this.Controls.Add(this.labelIdStudent);
            this.Controls.Add(this.buttonCancelStudent);
            this.Controls.Add(this.buttonOKStudent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditStudent";
            this.Text = "Редактирование студента";
            ((System.ComponentModel.ISupportInitialize)(this.numericYearOfStudy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOKStudent;
        private System.Windows.Forms.Button buttonCancelStudent;
        private System.Windows.Forms.TextBox textBoxFaculty;
        private System.Windows.Forms.Label labelFaculty;
        private System.Windows.Forms.TextBox textBoxSpecialty;
        private System.Windows.Forms.Label labelSpecialty;
        private System.Windows.Forms.Label labelYearOfStudy;
        private System.Windows.Forms.Label labelFormOfStudy;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.TextBox textBoxSurnameStudent;
        private System.Windows.Forms.Label labelNameStudent;
        private System.Windows.Forms.TextBox textBoxPatronymicStudent;
        private System.Windows.Forms.Label labelSurnameStudent;
        private System.Windows.Forms.TextBox textBoxNameStudent;
        private System.Windows.Forms.Label labelPatronymicStudent;
        private System.Windows.Forms.Label labelIdStudent;
        private System.Windows.Forms.DateTimePicker pickerDateOfBirth;
        private System.Windows.Forms.ComboBox comboBoxFormOfStudy;
        private System.Windows.Forms.NumericUpDown numericYearOfStudy;
        private System.Windows.Forms.MaskedTextBox textBoxIdStudent;
        private System.Windows.Forms.ErrorProvider errorProviderStudent;
    }
}