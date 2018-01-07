namespace KEPIT_Proiznye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.active = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.save_but = new System.Windows.Forms.Button();
            this.groups_but = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.testing = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.print = new System.Windows.Forms.Button();
            this.bug = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.startMonthIndex = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.deleteAllData = new System.Windows.Forms.Button();
            this.returnSavePathButton = new System.Windows.Forms.Button();
            this.changeSavePathButton = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.loadBackup = new System.Windows.Forms.Button();
            this.changeBackupLoadPathButton = new System.Windows.Forms.Button();
            this.loadBackupPath = new System.Windows.Forms.TextBox();
            this.changeBackupMakePathButton = new System.Windows.Forms.Button();
            this.testingPassword = new System.Windows.Forms.TextBox();
            this.makeBackupPath = new System.Windows.Forms.TextBox();
            this.makeBackup = new System.Windows.Forms.Button();
            this.makeBackupDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.savePathDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.whatsNew = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.offset = new System.Windows.Forms.Button();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.table1 = new KEPIT_Proiznye.Table();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список груп";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 48);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(364, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Безліміт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(577, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "62 поїздки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(794, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "46 поїздок";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(9, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Активна група:";
            // 
            // active
            // 
            this.active.AutoSize = true;
            this.active.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.active.Location = new System.Drawing.Point(123, 90);
            this.active.Name = "active";
            this.active.Size = new System.Drawing.Size(20, 20);
            this.active.TabIndex = 7;
            this.active.Text = "—";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(242, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Підрахувати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // save_but
            // 
            this.save_but.BackColor = System.Drawing.Color.LightSteelBlue;
            this.save_but.FlatAppearance.BorderSize = 0;
            this.save_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_but.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.save_but.Location = new System.Drawing.Point(821, 550);
            this.save_but.Name = "save_but";
            this.save_but.Size = new System.Drawing.Size(151, 23);
            this.save_but.TabIndex = 9;
            this.save_but.Text = "Зберегти";
            this.save_but.UseVisualStyleBackColor = false;
            this.save_but.Click += new System.EventHandler(this.Button2_Click);
            // 
            // groups_but
            // 
            this.groups_but.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groups_but.FlatAppearance.BorderSize = 0;
            this.groups_but.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.groups_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groups_but.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groups_but.Location = new System.Drawing.Point(814, 28);
            this.groups_but.Name = "groups_but";
            this.groups_but.Size = new System.Drawing.Size(52, 48);
            this.groups_but.TabIndex = 10;
            this.groups_but.Text = "Групи";
            this.groups_but.UseVisualStyleBackColor = false;
            this.groups_but.Click += new System.EventHandler(this.Button3_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.message.Location = new System.Drawing.Point(12, 555);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(28, 16);
            this.message.TabIndex = 11;
            this.message.Text = "null";
            // 
            // testing
            // 
            this.testing.BackColor = System.Drawing.Color.LightSteelBlue;
            this.testing.Enabled = false;
            this.testing.FlatAppearance.BorderSize = 0;
            this.testing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.testing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testing.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.testing.Location = new System.Drawing.Point(6, 508);
            this.testing.Name = "testing";
            this.testing.Size = new System.Drawing.Size(214, 23);
            this.testing.TabIndex = 12;
            this.testing.Text = "Тестування";
            this.testing.UseVisualStyleBackColor = false;
            this.testing.Visible = false;
            this.testing.Click += new System.EventHandler(this.Testing_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.print);
            this.groupBox2.Controls.Add(this.bug);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.startMonthIndex);
            this.groupBox2.Controls.Add(this.restartButton);
            this.groupBox2.Controls.Add(this.deleteAllData);
            this.groupBox2.Controls.Add(this.returnSavePathButton);
            this.groupBox2.Controls.Add(this.changeSavePathButton);
            this.groupBox2.Controls.Add(this.checkBox);
            this.groupBox2.Controls.Add(this.loadBackup);
            this.groupBox2.Controls.Add(this.changeBackupLoadPathButton);
            this.groupBox2.Controls.Add(this.loadBackupPath);
            this.groupBox2.Controls.Add(this.changeBackupMakePathButton);
            this.groupBox2.Controls.Add(this.testingPassword);
            this.groupBox2.Controls.Add(this.makeBackupPath);
            this.groupBox2.Controls.Add(this.makeBackup);
            this.groupBox2.Controls.Add(this.testing);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(999, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 537);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додатково";
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.Color.LightSteelBlue;
            this.print.FlatAppearance.BorderSize = 0;
            this.print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.print.Location = new System.Drawing.Point(6, 158);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(214, 23);
            this.print.TabIndex = 30;
            this.print.Text = "Надрукувати";
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.Print_Click);
            // 
            // bug
            // 
            this.bug.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bug.FlatAppearance.BorderSize = 0;
            this.bug.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.bug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bug.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.bug.Location = new System.Drawing.Point(6, 207);
            this.bug.Name = "bug";
            this.bug.Size = new System.Drawing.Size(214, 40);
            this.bug.TabIndex = 29;
            this.bug.Text = "Натисніть, якщо знайшли помилку в інтерфейсі програмі";
            this.bug.UseVisualStyleBackColor = false;
            this.bug.Click += new System.EventHandler(this.Bug_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.Lavender;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 79);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(214, 24);
            this.comboBox2.TabIndex = 17;
            // 
            // startMonthIndex
            // 
            this.startMonthIndex.BackColor = System.Drawing.Color.LightSteelBlue;
            this.startMonthIndex.FlatAppearance.BorderSize = 0;
            this.startMonthIndex.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.startMonthIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startMonthIndex.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.startMonthIndex.Location = new System.Drawing.Point(6, 109);
            this.startMonthIndex.Name = "startMonthIndex";
            this.startMonthIndex.Size = new System.Drawing.Size(214, 23);
            this.startMonthIndex.TabIndex = 26;
            this.startMonthIndex.Text = "Змінити місяць при старті";
            this.startMonthIndex.UseVisualStyleBackColor = false;
            this.startMonthIndex.Click += new System.EventHandler(this.StartMonthIndex_Click);
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.restartButton.FlatAppearance.BorderSize = 0;
            this.restartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartButton.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.restartButton.Location = new System.Drawing.Point(6, 27);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(214, 23);
            this.restartButton.TabIndex = 25;
            this.restartButton.Text = "Перезапустити програму";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // deleteAllData
            // 
            this.deleteAllData.BackColor = System.Drawing.Color.LightSteelBlue;
            this.deleteAllData.FlatAppearance.BorderSize = 0;
            this.deleteAllData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.deleteAllData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAllData.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.deleteAllData.Location = new System.Drawing.Point(6, 451);
            this.deleteAllData.Name = "deleteAllData";
            this.deleteAllData.Size = new System.Drawing.Size(214, 23);
            this.deleteAllData.TabIndex = 24;
            this.deleteAllData.Text = "Видалити всі файли та дані";
            this.deleteAllData.UseVisualStyleBackColor = false;
            this.deleteAllData.Visible = false;
            this.deleteAllData.Click += new System.EventHandler(this.DeleteAllData_Click);
            // 
            // returnSavePathButton
            // 
            this.returnSavePathButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.returnSavePathButton.FlatAppearance.BorderSize = 0;
            this.returnSavePathButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.returnSavePathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnSavePathButton.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.returnSavePathButton.Location = new System.Drawing.Point(6, 308);
            this.returnSavePathButton.Name = "returnSavePathButton";
            this.returnSavePathButton.Size = new System.Drawing.Size(214, 23);
            this.returnSavePathButton.TabIndex = 23;
            this.returnSavePathButton.Text = "Повернути початковий шлях";
            this.returnSavePathButton.UseVisualStyleBackColor = false;
            this.returnSavePathButton.Visible = false;
            this.returnSavePathButton.Click += new System.EventHandler(this.ReturnSavePathButton_Click);
            // 
            // changeSavePathButton
            // 
            this.changeSavePathButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.changeSavePathButton.FlatAppearance.BorderSize = 0;
            this.changeSavePathButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.changeSavePathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeSavePathButton.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.changeSavePathButton.Location = new System.Drawing.Point(6, 279);
            this.changeSavePathButton.Name = "changeSavePathButton";
            this.changeSavePathButton.Size = new System.Drawing.Size(214, 23);
            this.changeSavePathButton.TabIndex = 22;
            this.changeSavePathButton.Text = "Змінити шлях збереження даних";
            this.changeSavePathButton.UseVisualStyleBackColor = false;
            this.changeSavePathButton.Visible = false;
            this.changeSavePathButton.Click += new System.EventHandler(this.ChangeSavePathButton_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.BackColor = System.Drawing.Color.MintCream;
            this.checkBox.FlatAppearance.BorderSize = 0;
            this.checkBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue;
            this.checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.checkBox.Location = new System.Drawing.Point(6, 253);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(210, 20);
            this.checkBox.TabIndex = 21;
            this.checkBox.Text = "Відкрити додаткові налаштування\r\n";
            this.checkBox.UseVisualStyleBackColor = false;
            this.checkBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // loadBackup
            // 
            this.loadBackup.BackColor = System.Drawing.Color.LightSteelBlue;
            this.loadBackup.FlatAppearance.BorderSize = 0;
            this.loadBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.loadBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadBackup.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.loadBackup.Location = new System.Drawing.Point(6, 422);
            this.loadBackup.Name = "loadBackup";
            this.loadBackup.Size = new System.Drawing.Size(214, 23);
            this.loadBackup.TabIndex = 20;
            this.loadBackup.Text = "Завантажити резервне копіювання";
            this.loadBackup.UseVisualStyleBackColor = false;
            this.loadBackup.Visible = false;
            this.loadBackup.Click += new System.EventHandler(this.LoadBackup_Click);
            // 
            // changeBackupLoadPathButton
            // 
            this.changeBackupLoadPathButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.changeBackupLoadPathButton.FlatAppearance.BorderSize = 0;
            this.changeBackupLoadPathButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.changeBackupLoadPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeBackupLoadPathButton.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.changeBackupLoadPathButton.Location = new System.Drawing.Point(203, 397);
            this.changeBackupLoadPathButton.Name = "changeBackupLoadPathButton";
            this.changeBackupLoadPathButton.Size = new System.Drawing.Size(17, 23);
            this.changeBackupLoadPathButton.TabIndex = 19;
            this.changeBackupLoadPathButton.Text = ".";
            this.changeBackupLoadPathButton.UseVisualStyleBackColor = false;
            this.changeBackupLoadPathButton.Visible = false;
            this.changeBackupLoadPathButton.Click += new System.EventHandler(this.ChangeBackupLoadPathButton_Click);
            // 
            // loadBackupPath
            // 
            this.loadBackupPath.BackColor = System.Drawing.Color.Lavender;
            this.loadBackupPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loadBackupPath.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.loadBackupPath.Location = new System.Drawing.Point(6, 400);
            this.loadBackupPath.Name = "loadBackupPath";
            this.loadBackupPath.Size = new System.Drawing.Size(191, 13);
            this.loadBackupPath.TabIndex = 18;
            this.loadBackupPath.Visible = false;
            // 
            // changeBackupMakePathButton
            // 
            this.changeBackupMakePathButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.changeBackupMakePathButton.FlatAppearance.BorderSize = 0;
            this.changeBackupMakePathButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.changeBackupMakePathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeBackupMakePathButton.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.changeBackupMakePathButton.Location = new System.Drawing.Point(203, 343);
            this.changeBackupMakePathButton.Name = "changeBackupMakePathButton";
            this.changeBackupMakePathButton.Size = new System.Drawing.Size(17, 23);
            this.changeBackupMakePathButton.TabIndex = 17;
            this.changeBackupMakePathButton.Text = ".";
            this.changeBackupMakePathButton.UseVisualStyleBackColor = false;
            this.changeBackupMakePathButton.Visible = false;
            this.changeBackupMakePathButton.Click += new System.EventHandler(this.ChangeBackupMakePathButton_Click);
            // 
            // testingPassword
            // 
            this.testingPassword.BackColor = System.Drawing.Color.Lavender;
            this.testingPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.testingPassword.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.testingPassword.Location = new System.Drawing.Point(6, 489);
            this.testingPassword.Name = "testingPassword";
            this.testingPassword.Size = new System.Drawing.Size(214, 13);
            this.testingPassword.TabIndex = 16;
            this.testingPassword.UseSystemPasswordChar = true;
            this.testingPassword.Visible = false;
            this.testingPassword.TextChanged += new System.EventHandler(this.TestingPassword_TextChanged);
            // 
            // makeBackupPath
            // 
            this.makeBackupPath.BackColor = System.Drawing.Color.Lavender;
            this.makeBackupPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.makeBackupPath.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.makeBackupPath.Location = new System.Drawing.Point(6, 346);
            this.makeBackupPath.Name = "makeBackupPath";
            this.makeBackupPath.Size = new System.Drawing.Size(191, 13);
            this.makeBackupPath.TabIndex = 15;
            this.makeBackupPath.Visible = false;
            // 
            // makeBackup
            // 
            this.makeBackup.BackColor = System.Drawing.Color.LightSteelBlue;
            this.makeBackup.FlatAppearance.BorderSize = 0;
            this.makeBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.makeBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeBackup.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.makeBackup.Location = new System.Drawing.Point(6, 368);
            this.makeBackup.Name = "makeBackup";
            this.makeBackup.Size = new System.Drawing.Size(214, 23);
            this.makeBackup.TabIndex = 14;
            this.makeBackup.Text = "Зробити резервне копіювання";
            this.makeBackup.UseVisualStyleBackColor = false;
            this.makeBackup.Visible = false;
            this.makeBackup.Click += new System.EventHandler(this.MakeBackup_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(872, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Місяць:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Lavender;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(872, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // whatsNew
            // 
            this.whatsNew.BackColor = System.Drawing.Color.Red;
            this.whatsNew.FlatAppearance.BorderSize = 0;
            this.whatsNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.whatsNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.whatsNew.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.whatsNew.Location = new System.Drawing.Point(814, 5);
            this.whatsNew.Name = "whatsNew";
            this.whatsNew.Size = new System.Drawing.Size(179, 23);
            this.whatsNew.TabIndex = 16;
            this.whatsNew.Tag = "not";
            this.whatsNew.Text = "ПРОЧИТАЙТЕ у вільний час";
            this.whatsNew.UseVisualStyleBackColor = false;
            this.whatsNew.Visible = false;
            this.whatsNew.Click += new System.EventHandler(this.WhatsNew_Click);
            // 
            // up
            // 
            this.up.BackColor = System.Drawing.Color.LightSteelBlue;
            this.up.FlatAppearance.BorderSize = 0;
            this.up.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.up.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.up.Location = new System.Drawing.Point(978, 114);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(15, 60);
            this.up.TabIndex = 29;
            this.up.UseVisualStyleBackColor = false;
            this.up.Click += new System.EventHandler(this.Up_Click);
            // 
            // down
            // 
            this.down.BackColor = System.Drawing.Color.LightSteelBlue;
            this.down.FlatAppearance.BorderSize = 0;
            this.down.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.down.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.down.Location = new System.Drawing.Point(978, 489);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(15, 60);
            this.down.TabIndex = 30;
            this.down.UseVisualStyleBackColor = false;
            this.down.Click += new System.EventHandler(this.Down_Click);
            // 
            // offset
            // 
            this.offset.BackColor = System.Drawing.Color.LightSteelBlue;
            this.offset.FlatAppearance.BorderSize = 0;
            this.offset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.offset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.offset.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.offset.Location = new System.Drawing.Point(978, 301);
            this.offset.Name = "offset";
            this.offset.Size = new System.Drawing.Size(15, 60);
            this.offset.TabIndex = 31;
            this.offset.UseVisualStyleBackColor = false;
            this.offset.Click += new System.EventHandler(this.Offset_Click);
            // 
            // elementHost2
            // 
            this.elementHost2.BackColor = System.Drawing.Color.Honeydew;
            this.elementHost2.Location = new System.Drawing.Point(12, 114);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(960, 435);
            this.elementHost2.TabIndex = 2;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.Child = this.table1;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1237, 577);
            this.Controls.Add(this.offset);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.whatsNew);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.message);
            this.Controls.Add(this.groups_but);
            this.Controls.Add(this.save_but);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.active);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.elementHost2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1253, 615);
            this.MinimumSize = new System.Drawing.Size(1253, 615);
            this.Name = "Form1";
            this.Text = "Проїзні квитки - КЕПІТ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private Table table1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label active;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button save_but;
        private System.Windows.Forms.Button groups_but;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button testing;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox testingPassword;
        private System.Windows.Forms.TextBox makeBackupPath;
        private System.Windows.Forms.Button makeBackup;
        private System.Windows.Forms.Button changeBackupLoadPathButton;
        private System.Windows.Forms.TextBox loadBackupPath;
        private System.Windows.Forms.Button changeBackupMakePathButton;
        private System.Windows.Forms.FolderBrowserDialog makeBackupDialog;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Button loadBackup;
        private System.Windows.Forms.Button returnSavePathButton;
        private System.Windows.Forms.Button changeSavePathButton;
        private System.Windows.Forms.Button deleteAllData;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog savePathDialog;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button whatsNew;
        private System.Windows.Forms.Button startMonthIndex;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button offset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bug;
        private System.Windows.Forms.Button print;
    }
}

