namespace CP_Session
{
    partial class FormStudent
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Семестр 1", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Предмет 1",
            "1",
            "хорошо"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudent));
            this.groupBoxStudent = new System.Windows.Forms.GroupBox();
            this.textBoxFaculty = new System.Windows.Forms.TextBox();
            this.labelFaculty = new System.Windows.Forms.Label();
            this.textBoxSpecialty = new System.Windows.Forms.TextBox();
            this.labelSpecialty = new System.Windows.Forms.Label();
            this.textBoxYearOfStudy = new System.Windows.Forms.TextBox();
            this.labelYearOfStudy = new System.Windows.Forms.Label();
            this.labelFormOfStudy = new System.Windows.Forms.Label();
            this.textBoxFormOfStudy = new System.Windows.Forms.TextBox();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
            this.textBoxSurnameStudent = new System.Windows.Forms.TextBox();
            this.labelNameStudent = new System.Windows.Forms.Label();
            this.textBoxPatronymicStudent = new System.Windows.Forms.TextBox();
            this.labelSurnameStudent = new System.Windows.Forms.Label();
            this.textBoxNameStudent = new System.Windows.Forms.TextBox();
            this.labelPatronymicStudent = new System.Windows.Forms.Label();
            this.textBoxIdStudent = new System.Windows.Forms.TextBox();
            this.labelIdStudent = new System.Windows.Forms.Label();
            this.groupBoxDisciplines = new System.Windows.Forms.GroupBox();
            this.listViewDisciplines = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonModifyStudent = new System.Windows.Forms.Button();
            this.buttonDeleteStudent = new System.Windows.Forms.Button();
            this.buttonAddDiscipline = new System.Windows.Forms.Button();
            this.buttonModifyDiscipline = new System.Windows.Forms.Button();
            this.buttonDeleteDiscipline = new System.Windows.Forms.Button();
            this.buttonCloseInfoStudent = new System.Windows.Forms.Button();
            this.checkBoxAddDisciplines = new System.Windows.Forms.CheckBox();
            this.groupBoxStudent.SuspendLayout();
            this.groupBoxDisciplines.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStudent
            // 
            this.groupBoxStudent.Controls.Add(this.textBoxFaculty);
            this.groupBoxStudent.Controls.Add(this.labelFaculty);
            this.groupBoxStudent.Controls.Add(this.textBoxSpecialty);
            this.groupBoxStudent.Controls.Add(this.labelSpecialty);
            this.groupBoxStudent.Controls.Add(this.textBoxYearOfStudy);
            this.groupBoxStudent.Controls.Add(this.labelYearOfStudy);
            this.groupBoxStudent.Controls.Add(this.labelFormOfStudy);
            this.groupBoxStudent.Controls.Add(this.textBoxFormOfStudy);
            this.groupBoxStudent.Controls.Add(this.textBoxGroup);
            this.groupBoxStudent.Controls.Add(this.labelGroup);
            this.groupBoxStudent.Controls.Add(this.labelDateOfBirth);
            this.groupBoxStudent.Controls.Add(this.textBoxDateOfBirth);
            this.groupBoxStudent.Controls.Add(this.textBoxSurnameStudent);
            this.groupBoxStudent.Controls.Add(this.labelNameStudent);
            this.groupBoxStudent.Controls.Add(this.textBoxPatronymicStudent);
            this.groupBoxStudent.Controls.Add(this.labelSurnameStudent);
            this.groupBoxStudent.Controls.Add(this.textBoxNameStudent);
            this.groupBoxStudent.Controls.Add(this.labelPatronymicStudent);
            this.groupBoxStudent.Controls.Add(this.textBoxIdStudent);
            this.groupBoxStudent.Controls.Add(this.labelIdStudent);
            this.groupBoxStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxStudent.Location = new System.Drawing.Point(12, 12);
            this.groupBoxStudent.Name = "groupBoxStudent";
            this.groupBoxStudent.Size = new System.Drawing.Size(364, 376);
            this.groupBoxStudent.TabIndex = 1;
            this.groupBoxStudent.TabStop = false;
            this.groupBoxStudent.Text = "Студент";
            // 
            // textBoxFaculty
            // 
            this.textBoxFaculty.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxFaculty.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxFaculty.Location = new System.Drawing.Point(160, 330);
            this.textBoxFaculty.Multiline = true;
            this.textBoxFaculty.Name = "textBoxFaculty";
            this.textBoxFaculty.ReadOnly = true;
            this.textBoxFaculty.Size = new System.Drawing.Size(180, 24);
            this.textBoxFaculty.TabIndex = 1;
            this.textBoxFaculty.Text = "ФВТ";
            this.textBoxFaculty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFaculty
            // 
            this.labelFaculty.AutoSize = true;
            this.labelFaculty.Location = new System.Drawing.Point(63, 333);
            this.labelFaculty.Name = "labelFaculty";
            this.labelFaculty.Size = new System.Drawing.Size(91, 18);
            this.labelFaculty.TabIndex = 0;
            this.labelFaculty.Text = "Факультет :";
            // 
            // textBoxSpecialty
            // 
            this.textBoxSpecialty.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSpecialty.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxSpecialty.Location = new System.Drawing.Point(160, 276);
            this.textBoxSpecialty.Multiline = true;
            this.textBoxSpecialty.Name = "textBoxSpecialty";
            this.textBoxSpecialty.ReadOnly = true;
            this.textBoxSpecialty.Size = new System.Drawing.Size(180, 48);
            this.textBoxSpecialty.TabIndex = 1;
            this.textBoxSpecialty.Text = "Программная инженерия";
            this.textBoxSpecialty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSpecialty
            // 
            this.labelSpecialty.AutoSize = true;
            this.labelSpecialty.Location = new System.Drawing.Point(30, 279);
            this.labelSpecialty.Name = "labelSpecialty";
            this.labelSpecialty.Size = new System.Drawing.Size(124, 18);
            this.labelSpecialty.TabIndex = 0;
            this.labelSpecialty.Text = "Специальность :";
            // 
            // textBoxYearOfStudy
            // 
            this.textBoxYearOfStudy.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxYearOfStudy.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxYearOfStudy.Location = new System.Drawing.Point(160, 246);
            this.textBoxYearOfStudy.Name = "textBoxYearOfStudy";
            this.textBoxYearOfStudy.ReadOnly = true;
            this.textBoxYearOfStudy.Size = new System.Drawing.Size(180, 24);
            this.textBoxYearOfStudy.TabIndex = 1;
            this.textBoxYearOfStudy.Text = "2";
            this.textBoxYearOfStudy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelYearOfStudy
            // 
            this.labelYearOfStudy.AutoSize = true;
            this.labelYearOfStudy.Location = new System.Drawing.Point(42, 249);
            this.labelYearOfStudy.Name = "labelYearOfStudy";
            this.labelYearOfStudy.Size = new System.Drawing.Size(112, 18);
            this.labelYearOfStudy.TabIndex = 0;
            this.labelYearOfStudy.Text = "Год обучения :";
            // 
            // labelFormOfStudy
            // 
            this.labelFormOfStudy.AutoSize = true;
            this.labelFormOfStudy.Location = new System.Drawing.Point(20, 219);
            this.labelFormOfStudy.Name = "labelFormOfStudy";
            this.labelFormOfStudy.Size = new System.Drawing.Size(134, 18);
            this.labelFormOfStudy.TabIndex = 0;
            this.labelFormOfStudy.Text = "Форма обучения :";
            // 
            // textBoxFormOfStudy
            // 
            this.textBoxFormOfStudy.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxFormOfStudy.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxFormOfStudy.Location = new System.Drawing.Point(160, 216);
            this.textBoxFormOfStudy.Name = "textBoxFormOfStudy";
            this.textBoxFormOfStudy.ReadOnly = true;
            this.textBoxFormOfStudy.Size = new System.Drawing.Size(180, 24);
            this.textBoxFormOfStudy.TabIndex = 1;
            this.textBoxFormOfStudy.Text = "очная";
            this.textBoxFormOfStudy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxGroup.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxGroup.Location = new System.Drawing.Point(160, 186);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.ReadOnly = true;
            this.textBoxGroup.Size = new System.Drawing.Size(180, 24);
            this.textBoxGroup.TabIndex = 1;
            this.textBoxGroup.Text = "19ПИ1";
            this.textBoxGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(90, 189);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(64, 18);
            this.labelGroup.TabIndex = 0;
            this.labelGroup.Text = "Группа :";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(30, 159);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(124, 18);
            this.labelDateOfBirth.TabIndex = 0;
            this.labelDateOfBirth.Text = "Дата рождения :";
            // 
            // textBoxDateOfBirth
            // 
            this.textBoxDateOfBirth.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDateOfBirth.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxDateOfBirth.Location = new System.Drawing.Point(160, 156);
            this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            this.textBoxDateOfBirth.ReadOnly = true;
            this.textBoxDateOfBirth.Size = new System.Drawing.Size(180, 24);
            this.textBoxDateOfBirth.TabIndex = 1;
            this.textBoxDateOfBirth.Text = "13.07.2003";
            this.textBoxDateOfBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSurnameStudent
            // 
            this.textBoxSurnameStudent.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSurnameStudent.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxSurnameStudent.Location = new System.Drawing.Point(160, 126);
            this.textBoxSurnameStudent.Name = "textBoxSurnameStudent";
            this.textBoxSurnameStudent.ReadOnly = true;
            this.textBoxSurnameStudent.Size = new System.Drawing.Size(180, 24);
            this.textBoxSurnameStudent.TabIndex = 1;
            this.textBoxSurnameStudent.Text = "Аркадов";
            this.textBoxSurnameStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNameStudent
            // 
            this.labelNameStudent.AutoSize = true;
            this.labelNameStudent.Location = new System.Drawing.Point(108, 69);
            this.labelNameStudent.Name = "labelNameStudent";
            this.labelNameStudent.Size = new System.Drawing.Size(46, 18);
            this.labelNameStudent.TabIndex = 0;
            this.labelNameStudent.Text = "Имя :";
            // 
            // textBoxPatronymicStudent
            // 
            this.textBoxPatronymicStudent.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPatronymicStudent.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxPatronymicStudent.Location = new System.Drawing.Point(160, 96);
            this.textBoxPatronymicStudent.Name = "textBoxPatronymicStudent";
            this.textBoxPatronymicStudent.ReadOnly = true;
            this.textBoxPatronymicStudent.Size = new System.Drawing.Size(180, 24);
            this.textBoxPatronymicStudent.TabIndex = 1;
            this.textBoxPatronymicStudent.Text = "Аркадиевич";
            this.textBoxPatronymicStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSurnameStudent
            // 
            this.labelSurnameStudent.AutoSize = true;
            this.labelSurnameStudent.Location = new System.Drawing.Point(73, 129);
            this.labelSurnameStudent.Name = "labelSurnameStudent";
            this.labelSurnameStudent.Size = new System.Drawing.Size(81, 18);
            this.labelSurnameStudent.TabIndex = 0;
            this.labelSurnameStudent.Text = "Фамилия :";
            // 
            // textBoxNameStudent
            // 
            this.textBoxNameStudent.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNameStudent.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxNameStudent.Location = new System.Drawing.Point(160, 66);
            this.textBoxNameStudent.Name = "textBoxNameStudent";
            this.textBoxNameStudent.ReadOnly = true;
            this.textBoxNameStudent.Size = new System.Drawing.Size(180, 24);
            this.textBoxNameStudent.TabIndex = 1;
            this.textBoxNameStudent.Text = "Аркадий";
            this.textBoxNameStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPatronymicStudent
            // 
            this.labelPatronymicStudent.AutoSize = true;
            this.labelPatronymicStudent.Location = new System.Drawing.Point(63, 99);
            this.labelPatronymicStudent.Name = "labelPatronymicStudent";
            this.labelPatronymicStudent.Size = new System.Drawing.Size(91, 18);
            this.labelPatronymicStudent.TabIndex = 0;
            this.labelPatronymicStudent.Text = "Отечество :";
            // 
            // textBoxIdStudent
            // 
            this.textBoxIdStudent.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxIdStudent.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxIdStudent.Location = new System.Drawing.Point(160, 36);
            this.textBoxIdStudent.Name = "textBoxIdStudent";
            this.textBoxIdStudent.ReadOnly = true;
            this.textBoxIdStudent.Size = new System.Drawing.Size(180, 24);
            this.textBoxIdStudent.TabIndex = 1;
            this.textBoxIdStudent.Text = "2214567";
            this.textBoxIdStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelIdStudent
            // 
            this.labelIdStudent.AutoSize = true;
            this.labelIdStudent.Location = new System.Drawing.Point(23, 39);
            this.labelIdStudent.Name = "labelIdStudent";
            this.labelIdStudent.Size = new System.Drawing.Size(131, 18);
            this.labelIdStudent.TabIndex = 0;
            this.labelIdStudent.Text = "Номер карточки :";
            // 
            // groupBoxDisciplines
            // 
            this.groupBoxDisciplines.Controls.Add(this.listViewDisciplines);
            this.groupBoxDisciplines.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDisciplines.Location = new System.Drawing.Point(382, 12);
            this.groupBoxDisciplines.Name = "groupBoxDisciplines";
            this.groupBoxDisciplines.Size = new System.Drawing.Size(387, 324);
            this.groupBoxDisciplines.TabIndex = 2;
            this.groupBoxDisciplines.TabStop = false;
            this.groupBoxDisciplines.Text = "Дисциплины";
            // 
            // listViewDisciplines
            // 
            this.listViewDisciplines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderScore});
            listViewGroup1.Header = "Семестр 1";
            listViewGroup1.Name = "listViewGroup1";
            this.listViewDisciplines.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listViewDisciplines.HideSelection = false;
            this.listViewDisciplines.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewDisciplines.Location = new System.Drawing.Point(6, 23);
            this.listViewDisciplines.Name = "listViewDisciplines";
            this.listViewDisciplines.Size = new System.Drawing.Size(375, 295);
            this.listViewDisciplines.TabIndex = 0;
            this.listViewDisciplines.UseCompatibleStateImageBehavior = false;
            this.listViewDisciplines.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Название";
            this.columnHeaderName.Width = 220;
            // 
            // columnHeaderScore
            // 
            this.columnHeaderScore.Text = "Оценка";
            this.columnHeaderScore.Width = 150;
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddStudent.Location = new System.Drawing.Point(12, 404);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(110, 30);
            this.buttonAddStudent.TabIndex = 3;
            this.buttonAddStudent.Text = "Добавить";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonModifyStudent
            // 
            this.buttonModifyStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonModifyStudent.Location = new System.Drawing.Point(140, 404);
            this.buttonModifyStudent.Name = "buttonModifyStudent";
            this.buttonModifyStudent.Size = new System.Drawing.Size(110, 30);
            this.buttonModifyStudent.TabIndex = 3;
            this.buttonModifyStudent.Text = "Изменить";
            this.buttonModifyStudent.UseVisualStyleBackColor = true;
            this.buttonModifyStudent.Click += new System.EventHandler(this.buttonModifyStudent_Click);
            // 
            // buttonDeleteStudent
            // 
            this.buttonDeleteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteStudent.Location = new System.Drawing.Point(266, 404);
            this.buttonDeleteStudent.Name = "buttonDeleteStudent";
            this.buttonDeleteStudent.Size = new System.Drawing.Size(110, 30);
            this.buttonDeleteStudent.TabIndex = 3;
            this.buttonDeleteStudent.Text = "Удалить";
            this.buttonDeleteStudent.UseVisualStyleBackColor = true;
            this.buttonDeleteStudent.Click += new System.EventHandler(this.buttonDeleteStudent_Click);
            // 
            // buttonAddDiscipline
            // 
            this.buttonAddDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddDiscipline.Location = new System.Drawing.Point(440, 342);
            this.buttonAddDiscipline.Name = "buttonAddDiscipline";
            this.buttonAddDiscipline.Size = new System.Drawing.Size(85, 24);
            this.buttonAddDiscipline.TabIndex = 3;
            this.buttonAddDiscipline.Text = "Добавить";
            this.buttonAddDiscipline.UseVisualStyleBackColor = true;
            this.buttonAddDiscipline.Click += new System.EventHandler(this.buttonAddDiscipline_Click);
            // 
            // buttonModifyDiscipline
            // 
            this.buttonModifyDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonModifyDiscipline.Location = new System.Drawing.Point(540, 342);
            this.buttonModifyDiscipline.Name = "buttonModifyDiscipline";
            this.buttonModifyDiscipline.Size = new System.Drawing.Size(85, 24);
            this.buttonModifyDiscipline.TabIndex = 3;
            this.buttonModifyDiscipline.Text = "Изменить";
            this.buttonModifyDiscipline.UseVisualStyleBackColor = true;
            this.buttonModifyDiscipline.Click += new System.EventHandler(this.buttonModifyDiscipline_Click);
            // 
            // buttonDeleteDiscipline
            // 
            this.buttonDeleteDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteDiscipline.Location = new System.Drawing.Point(640, 342);
            this.buttonDeleteDiscipline.Name = "buttonDeleteDiscipline";
            this.buttonDeleteDiscipline.Size = new System.Drawing.Size(85, 24);
            this.buttonDeleteDiscipline.TabIndex = 3;
            this.buttonDeleteDiscipline.Text = "Удалить";
            this.buttonDeleteDiscipline.UseVisualStyleBackColor = true;
            this.buttonDeleteDiscipline.Click += new System.EventHandler(this.buttonDeleteDiscipline_Click);
            // 
            // buttonCloseInfoStudent
            // 
            this.buttonCloseInfoStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseInfoStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonCloseInfoStudent.Location = new System.Drawing.Point(690, 410);
            this.buttonCloseInfoStudent.Name = "buttonCloseInfoStudent";
            this.buttonCloseInfoStudent.Size = new System.Drawing.Size(100, 30);
            this.buttonCloseInfoStudent.TabIndex = 4;
            this.buttonCloseInfoStudent.Text = "Закрыть";
            this.buttonCloseInfoStudent.UseVisualStyleBackColor = true;
            this.buttonCloseInfoStudent.Click += new System.EventHandler(this.buttonCloseInfoStudent_Click);
            // 
            // checkBoxAddDisciplines
            // 
            this.checkBoxAddDisciplines.AutoSize = true;
            this.checkBoxAddDisciplines.Location = new System.Drawing.Point(406, 381);
            this.checkBoxAddDisciplines.Name = "checkBoxAddDisciplines";
            this.checkBoxAddDisciplines.Size = new System.Drawing.Size(327, 17);
            this.checkBoxAddDisciplines.TabIndex = 5;
            this.checkBoxAddDisciplines.Text = "Общий список дисциплин для добавления нового студента";
            this.checkBoxAddDisciplines.UseVisualStyleBackColor = true;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxAddDisciplines);
            this.Controls.Add(this.buttonCloseInfoStudent);
            this.Controls.Add(this.buttonDeleteDiscipline);
            this.Controls.Add(this.buttonModifyDiscipline);
            this.Controls.Add(this.buttonAddDiscipline);
            this.Controls.Add(this.buttonDeleteStudent);
            this.Controls.Add(this.buttonModifyStudent);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.groupBoxDisciplines);
            this.Controls.Add(this.groupBoxStudent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStudent";
            this.Text = "Сведения о студенте";
            this.groupBoxStudent.ResumeLayout(false);
            this.groupBoxStudent.PerformLayout();
            this.groupBoxDisciplines.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxStudent;
        private System.Windows.Forms.GroupBox groupBoxDisciplines;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonModifyStudent;
        private System.Windows.Forms.Button buttonDeleteStudent;
        private System.Windows.Forms.Button buttonAddDiscipline;
        private System.Windows.Forms.Button buttonModifyDiscipline;
        private System.Windows.Forms.Button buttonDeleteDiscipline;
        private System.Windows.Forms.ListView listViewDisciplines;
        private System.Windows.Forms.TextBox textBoxFaculty;
        private System.Windows.Forms.Label labelFaculty;
        private System.Windows.Forms.TextBox textBoxSpecialty;
        private System.Windows.Forms.Label labelSpecialty;
        private System.Windows.Forms.TextBox textBoxYearOfStudy;
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
        private System.Windows.Forms.TextBox textBoxIdStudent;
        private System.Windows.Forms.Label labelIdStudent;
        private System.Windows.Forms.TextBox textBoxFormOfStudy;
        private System.Windows.Forms.TextBox textBoxDateOfBirth;
        private System.Windows.Forms.Button buttonCloseInfoStudent;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderScore;
        private System.Windows.Forms.CheckBox checkBoxAddDisciplines;
    }
}