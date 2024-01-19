namespace FalloutCha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Savebutton = new Button();
            Loadbutton = new Button();
            textBoxName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxDiscr = new TextBox();
            comboBoxArchetype = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            comboBoxRace = new ComboBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            textBoxConception = new TextBox();
            textBoxProblem = new TextBox();
            label7 = new Label();
            textBoxPurpose = new TextBox();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            StrenghtStat = new NumericUpDown();
            PerceptionStat = new NumericUpDown();
            EnduranceStat = new NumericUpDown();
            CharismaStat = new NumericUpDown();
            IntelligenceStat = new NumericUpDown();
            AgilityStat = new NumericUpDown();
            LuckStat = new NumericUpDown();
            label9 = new Label();
            label10 = new Label();
            comboBoxAthletics = new ComboBox();
            comboBoxStealth = new ComboBox();
            label11 = new Label();
            comboBoxShoot = new ComboBox();
            label12 = new Label();
            comboBoxHertz = new ComboBox();
            label13 = new Label();
            comboBoxMed = new ComboBox();
            label14 = new Label();
            comboBoxCoercion = new ComboBox();
            label15 = new Label();
            comboBoxManipulation = new ComboBox();
            label16 = new Label();
            comboBoxSurvive = new ComboBox();
            label17 = new Label();
            comboBoxKnowledge = new ComboBox();
            label18 = new Label();
            comboBoxTech = new ComboBox();
            label19 = new Label();
            label20 = new Label();
            numericUpDownHP = new NumericUpDown();
            numericUpDownHPmax = new NumericUpDown();
            label21 = new Label();
            numericUpDownFtUpdate = new NumericUpDown();
            label22 = new Label();
            numericUpDownFT = new NumericUpDown();
            label23 = new Label();
            numericUpDownArmor = new NumericUpDown();
            label24 = new Label();
            label32 = new Label();
            checkBoxSupplies0 = new CheckBox();
            checkBoxSupplies1 = new CheckBox();
            checkBoxSupplies2 = new CheckBox();
            numericUpDownCaps = new NumericUpDown();
            label33 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StrenghtStat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PerceptionStat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EnduranceStat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CharismaStat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IntelligenceStat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AgilityStat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LuckStat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHPmax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFtUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownArmor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCaps).BeginInit();
            SuspendLayout();
            // 
            // Savebutton
            // 
            Savebutton.Location = new Point(1044, 726);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(75, 23);
            Savebutton.TabIndex = 0;
            Savebutton.Text = "Зберігти";
            Savebutton.UseVisualStyleBackColor = true;
            Savebutton.Click += button1_Click;
            // 
            // Loadbutton
            // 
            Loadbutton.Location = new Point(963, 726);
            Loadbutton.Name = "Loadbutton";
            Loadbutton.Size = new Size(75, 23);
            Loadbutton.TabIndex = 1;
            Loadbutton.Text = "Завантажити";
            Loadbutton.UseVisualStyleBackColor = true;
            Loadbutton.Click += Loadbutton_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(113, 26);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(157, 22);
            textBoxName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 9);
            label1.Name = "label1";
            label1.Size = new Size(29, 14);
            label1.TabIndex = 3;
            label1.Text = "Ім'я";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 428);
            label2.Name = "label2";
            label2.Size = new Size(36, 14);
            label2.TabIndex = 4;
            label2.Text = "Опис";
            label2.Click += label2_Click;
            // 
            // textBoxDiscr
            // 
            textBoxDiscr.Location = new Point(12, 445);
            textBoxDiscr.Multiline = true;
            textBoxDiscr.Name = "textBoxDiscr";
            textBoxDiscr.Size = new Size(362, 55);
            textBoxDiscr.TabIndex = 5;
            // 
            // comboBoxArchetype
            // 
            comboBoxArchetype.FormattingEnabled = true;
            comboBoxArchetype.Items.AddRange(new object[] { "Здоровило", "Стрілець", "Торгаш", "Спокусник", "Злодюга", "Технік", "(Боже)вільний вчений", "Псионік", "Рейнджер" });
            comboBoxArchetype.Location = new Point(73, 506);
            comboBoxArchetype.Name = "comboBoxArchetype";
            comboBoxArchetype.Size = new Size(121, 22);
            comboBoxArchetype.TabIndex = 6;
            comboBoxArchetype.Text = "Оберіть...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 509);
            label3.Name = "label3";
            label3.Size = new Size(55, 14);
            label3.TabIndex = 7;
            label3.Text = "Архетип";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 509);
            label4.Name = "label4";
            label4.Size = new Size(28, 14);
            label4.TabIndex = 9;
            label4.Text = "Вид";
            label4.Click += label4_Click;
            // 
            // comboBoxRace
            // 
            comboBoxRace.FormattingEnabled = true;
            comboBoxRace.Items.AddRange(new object[] { "Людина", "Гуль", "Супермутант", "Робот", "Розумний Пазур Смерті\r (бан)" });
            comboBoxRace.Location = new Point(234, 506);
            comboBoxRace.Name = "comboBoxRace";
            comboBoxRace.Size = new Size(140, 22);
            comboBoxRace.TabIndex = 8;
            comboBoxRace.Text = "Оберіть...";
            comboBoxRace.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 371);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(172, 547);
            label5.Name = "label5";
            label5.Size = new Size(54, 14);
            label5.TabIndex = 11;
            label5.Text = "Аспекти";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(73, 571);
            label6.Name = "label6";
            label6.Size = new Size(65, 14);
            label6.TabIndex = 12;
            label6.Text = "Концепція";
            // 
            // textBoxConception
            // 
            textBoxConception.Location = new Point(12, 588);
            textBoxConception.Multiline = true;
            textBoxConception.Name = "textBoxConception";
            textBoxConception.Size = new Size(182, 79);
            textBoxConception.TabIndex = 13;
            // 
            // textBoxProblem
            // 
            textBoxProblem.Location = new Point(200, 588);
            textBoxProblem.Multiline = true;
            textBoxProblem.Name = "textBoxProblem";
            textBoxProblem.Size = new Size(182, 79);
            textBoxProblem.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(263, 571);
            label7.Name = "label7";
            label7.Size = new Size(64, 14);
            label7.TabIndex = 14;
            label7.Text = "Проблема";
            // 
            // textBoxPurpose
            // 
            textBoxPurpose.Location = new Point(12, 687);
            textBoxPurpose.Multiline = true;
            textBoxPurpose.Name = "textBoxPurpose";
            textBoxPurpose.Size = new Size(370, 69);
            textBoxPurpose.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(179, 670);
            label8.Name = "label8";
            label8.Size = new Size(30, 14);
            label8.TabIndex = 16;
            label8.Text = "Ціль";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(405, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(397, 182);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // StrenghtStat
            // 
            StrenghtStat.Location = new Point(423, 200);
            StrenghtStat.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            StrenghtStat.Minimum = new decimal(new int[] { 4, 0, 0, int.MinValue });
            StrenghtStat.Name = "StrenghtStat";
            StrenghtStat.Size = new Size(39, 22);
            StrenghtStat.TabIndex = 19;
            // 
            // PerceptionStat
            // 
            PerceptionStat.Location = new Point(477, 200);
            PerceptionStat.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            PerceptionStat.Minimum = new decimal(new int[] { 4, 0, 0, int.MinValue });
            PerceptionStat.Name = "PerceptionStat";
            PerceptionStat.Size = new Size(39, 22);
            PerceptionStat.TabIndex = 20;
            // 
            // EnduranceStat
            // 
            EnduranceStat.Location = new Point(533, 200);
            EnduranceStat.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            EnduranceStat.Minimum = new decimal(new int[] { 4, 0, 0, int.MinValue });
            EnduranceStat.Name = "EnduranceStat";
            EnduranceStat.Size = new Size(39, 22);
            EnduranceStat.TabIndex = 21;
            // 
            // CharismaStat
            // 
            CharismaStat.Location = new Point(594, 200);
            CharismaStat.Name = "CharismaStat";
            CharismaStat.Size = new Size(39, 22);
            CharismaStat.TabIndex = 22;
            // 
            // IntelligenceStat
            // 
            IntelligenceStat.Location = new Point(645, 200);
            IntelligenceStat.Name = "IntelligenceStat";
            IntelligenceStat.Size = new Size(39, 22);
            IntelligenceStat.TabIndex = 23;
            // 
            // AgilityStat
            // 
            AgilityStat.Location = new Point(700, 200);
            AgilityStat.Name = "AgilityStat";
            AgilityStat.Size = new Size(39, 22);
            AgilityStat.TabIndex = 24;
            // 
            // LuckStat
            // 
            LuckStat.Location = new Point(756, 200);
            LuckStat.Name = "LuckStat";
            LuckStat.Size = new Size(39, 22);
            LuckStat.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(520, 235);
            label9.Name = "label9";
            label9.Size = new Size(54, 14);
            label9.TabIndex = 26;
            label9.Text = "Навички";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(422, 255);
            label10.Name = "label10";
            label10.Size = new Size(60, 14);
            label10.TabIndex = 27;
            label10.Text = "Атлетика";
            // 
            // comboBoxAthletics
            // 
            comboBoxAthletics.FormattingEnabled = true;
            comboBoxAthletics.Items.AddRange(new object[] { "Учень (к6)", "Підмайстр (к8)", "Майстра (к10)" });
            comboBoxAthletics.Location = new Point(493, 252);
            comboBoxAthletics.Name = "comboBoxAthletics";
            comboBoxAthletics.Size = new Size(121, 22);
            comboBoxAthletics.TabIndex = 28;
            // 
            // comboBoxStealth
            // 
            comboBoxStealth.FormattingEnabled = true;
            comboBoxStealth.Items.AddRange(new object[] { "Учень (к6)", "Підмайстр (к8)", "Майстра (к10)" });
            comboBoxStealth.Location = new Point(493, 280);
            comboBoxStealth.Name = "comboBoxStealth";
            comboBoxStealth.Size = new Size(121, 22);
            comboBoxStealth.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(422, 283);
            label11.Name = "label11";
            label11.Size = new Size(46, 14);
            label11.TabIndex = 29;
            label11.Text = "Крадіж";
            // 
            // comboBoxShoot
            // 
            comboBoxShoot.FormattingEnabled = true;
            comboBoxShoot.Items.AddRange(new object[] { "Учень (к6)", "Підмайстр (к8)", "Майстра (к10)" });
            comboBoxShoot.Location = new Point(493, 308);
            comboBoxShoot.Name = "comboBoxShoot";
            comboBoxShoot.Size = new Size(121, 22);
            comboBoxShoot.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(422, 311);
            label12.Name = "label12";
            label12.Size = new Size(55, 14);
            label12.TabIndex = 31;
            label12.Text = "Стрільба";
            // 
            // comboBoxHertz
            // 
            comboBoxHertz.FormattingEnabled = true;
            comboBoxHertz.Items.AddRange(new object[] { "Учень (к6)", "Підмайстр (к8)", "Майстра (к10)" });
            comboBoxHertz.Location = new Point(493, 336);
            comboBoxHertz.Name = "comboBoxHertz";
            comboBoxHertz.Size = new Size(121, 22);
            comboBoxHertz.TabIndex = 34;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(422, 339);
            label13.Name = "label13";
            label13.Size = new Size(40, 14);
            label13.TabIndex = 33;
            label13.Text = "Герць";
            // 
            // comboBoxMed
            // 
            comboBoxMed.FormattingEnabled = true;
            comboBoxMed.Items.AddRange(new object[] { "Учень (к6)", "Підмайстр (к8)", "Майстра (к10)" });
            comboBoxMed.Location = new Point(493, 364);
            comboBoxMed.Name = "comboBoxMed";
            comboBoxMed.Size = new Size(121, 22);
            comboBoxMed.TabIndex = 36;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(422, 367);
            label14.Name = "label14";
            label14.Size = new Size(64, 14);
            label14.TabIndex = 35;
            label14.Text = "Медицина";
            // 
            // comboBoxCoercion
            // 
            comboBoxCoercion.FormattingEnabled = true;
            comboBoxCoercion.Items.AddRange(new object[] { "Учень (к6)", "Підмайстр (к8)", "Майстра (к10)" });
            comboBoxCoercion.Location = new Point(493, 507);
            comboBoxCoercion.Name = "comboBoxCoercion";
            comboBoxCoercion.Size = new Size(121, 22);
            comboBoxCoercion.TabIndex = 46;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(422, 510);
            label15.Name = "label15";
            label15.Size = new Size(49, 14);
            label15.TabIndex = 45;
            label15.Text = "Примус";
            // 
            // comboBoxManipulation
            // 
            comboBoxManipulation.FormattingEnabled = true;
            comboBoxManipulation.Items.AddRange(new object[] { "Учень (к6)", "Підмайстр (к8)", "Майстра (к10)" });
            comboBoxManipulation.Location = new Point(493, 476);
            comboBoxManipulation.Name = "comboBoxManipulation";
            comboBoxManipulation.Size = new Size(121, 22);
            comboBoxManipulation.TabIndex = 44;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(422, 479);
            label16.Name = "label16";
            label16.Size = new Size(74, 14);
            label16.TabIndex = 43;
            label16.Text = "Маніпуляція";
            // 
            // comboBoxSurvive
            // 
            comboBoxSurvive.FormattingEnabled = true;
            comboBoxSurvive.Items.AddRange(new object[] { "Учень (к6)", "Підмайстр (к8)", "Майстра (к10)" });
            comboBoxSurvive.Location = new Point(493, 448);
            comboBoxSurvive.Name = "comboBoxSurvive";
            comboBoxSurvive.Size = new Size(121, 22);
            comboBoxSurvive.TabIndex = 42;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(422, 451);
            label17.Name = "label17";
            label17.Size = new Size(71, 14);
            label17.TabIndex = 41;
            label17.Text = "Виживання";
            // 
            // comboBoxKnowledge
            // 
            comboBoxKnowledge.FormattingEnabled = true;
            comboBoxKnowledge.Items.AddRange(new object[] { "Учень (к6)", "Підмайстр (к8)", "Майстра (к10)" });
            comboBoxKnowledge.Location = new Point(493, 420);
            comboBoxKnowledge.Name = "comboBoxKnowledge";
            comboBoxKnowledge.Size = new Size(121, 22);
            comboBoxKnowledge.TabIndex = 40;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(422, 423);
            label18.Name = "label18";
            label18.Size = new Size(47, 14);
            label18.TabIndex = 39;
            label18.Text = "Знання";
            // 
            // comboBoxTech
            // 
            comboBoxTech.FormattingEnabled = true;
            comboBoxTech.Items.AddRange(new object[] { "Учень (к6)", "Підмайстр (к8)", "Майстра (к10)" });
            comboBoxTech.Location = new Point(493, 392);
            comboBoxTech.Name = "comboBoxTech";
            comboBoxTech.Size = new Size(121, 22);
            comboBoxTech.TabIndex = 38;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(422, 395);
            label19.Name = "label19";
            label19.Size = new Size(49, 14);
            label19.TabIndex = 37;
            label19.Text = "Техніка";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(822, 56);
            label20.Name = "label20";
            label20.Size = new Size(74, 14);
            label20.TabIndex = 47;
            label20.Text = "Поточні ОЗ ";
            label20.Click += label20_Click;
            // 
            // numericUpDownHP
            // 
            numericUpDownHP.Location = new Point(910, 54);
            numericUpDownHP.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownHP.Name = "numericUpDownHP";
            numericUpDownHP.Size = new Size(61, 22);
            numericUpDownHP.TabIndex = 48;
            // 
            // numericUpDownHPmax
            // 
            numericUpDownHPmax.Location = new Point(910, 26);
            numericUpDownHPmax.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownHPmax.Name = "numericUpDownHPmax";
            numericUpDownHPmax.Size = new Size(61, 22);
            numericUpDownHPmax.TabIndex = 50;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(822, 28);
            label21.Name = "label21";
            label21.Size = new Size(82, 14);
            label21.TabIndex = 49;
            label21.Text = "Максимум ОЗ";
            // 
            // numericUpDownFtUpdate
            // 
            numericUpDownFtUpdate.Location = new Point(978, 123);
            numericUpDownFtUpdate.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownFtUpdate.Name = "numericUpDownFtUpdate";
            numericUpDownFtUpdate.Size = new Size(61, 22);
            numericUpDownFtUpdate.TabIndex = 54;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(822, 125);
            label22.Name = "label22";
            label22.Size = new Size(150, 14);
            label22.TabIndex = 53;
            label22.Text = "Віднвлення Жетонів Долі";
            // 
            // numericUpDownFT
            // 
            numericUpDownFT.Location = new Point(1013, 160);
            numericUpDownFT.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownFT.Name = "numericUpDownFT";
            numericUpDownFT.Size = new Size(61, 22);
            numericUpDownFT.TabIndex = 52;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(822, 162);
            label23.Name = "label23";
            label23.Size = new Size(185, 14);
            label23.TabIndex = 51;
            label23.Text = "Поточна кількість Жетонів Долі";
            // 
            // numericUpDownArmor
            // 
            numericUpDownArmor.Location = new Point(910, 82);
            numericUpDownArmor.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownArmor.Name = "numericUpDownArmor";
            numericUpDownArmor.Size = new Size(61, 22);
            numericUpDownArmor.TabIndex = 56;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(822, 84);
            label24.Name = "label24";
            label24.Size = new Size(42, 14);
            label24.TabIndex = 55;
            label24.Text = "Броня";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(984, 29);
            label32.Name = "label32";
            label32.Size = new Size(55, 14);
            label32.TabIndex = 73;
            label32.Text = "Припаси";
            // 
            // checkBoxSupplies0
            // 
            checkBoxSupplies0.AutoSize = true;
            checkBoxSupplies0.Location = new Point(1050, 30);
            checkBoxSupplies0.Name = "checkBoxSupplies0";
            checkBoxSupplies0.Size = new Size(15, 14);
            checkBoxSupplies0.TabIndex = 74;
            checkBoxSupplies0.UseVisualStyleBackColor = true;
            checkBoxSupplies0.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBoxSupplies1
            // 
            checkBoxSupplies1.AutoSize = true;
            checkBoxSupplies1.Location = new Point(1071, 30);
            checkBoxSupplies1.Name = "checkBoxSupplies1";
            checkBoxSupplies1.Size = new Size(15, 14);
            checkBoxSupplies1.TabIndex = 75;
            checkBoxSupplies1.UseVisualStyleBackColor = true;
            // 
            // checkBoxSupplies2
            // 
            checkBoxSupplies2.AutoSize = true;
            checkBoxSupplies2.Location = new Point(1092, 30);
            checkBoxSupplies2.Name = "checkBoxSupplies2";
            checkBoxSupplies2.Size = new Size(15, 14);
            checkBoxSupplies2.TabIndex = 76;
            checkBoxSupplies2.UseVisualStyleBackColor = true;
            // 
            // numericUpDownCaps
            // 
            numericUpDownCaps.Location = new Point(1050, 54);
            numericUpDownCaps.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownCaps.Name = "numericUpDownCaps";
            numericUpDownCaps.Size = new Size(61, 22);
            numericUpDownCaps.TabIndex = 78;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(984, 54);
            label33.Name = "label33";
            label33.Size = new Size(49, 14);
            label33.TabIndex = 77;
            label33.Text = "Кришки";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1131, 761);
            Controls.Add(numericUpDownCaps);
            Controls.Add(label33);
            Controls.Add(checkBoxSupplies2);
            Controls.Add(checkBoxSupplies1);
            Controls.Add(checkBoxSupplies0);
            Controls.Add(label32);
            Controls.Add(numericUpDownArmor);
            Controls.Add(label24);
            Controls.Add(numericUpDownFtUpdate);
            Controls.Add(label22);
            Controls.Add(numericUpDownFT);
            Controls.Add(label23);
            Controls.Add(numericUpDownHPmax);
            Controls.Add(label21);
            Controls.Add(numericUpDownHP);
            Controls.Add(label20);
            Controls.Add(comboBoxCoercion);
            Controls.Add(label15);
            Controls.Add(comboBoxManipulation);
            Controls.Add(label16);
            Controls.Add(comboBoxSurvive);
            Controls.Add(label17);
            Controls.Add(comboBoxKnowledge);
            Controls.Add(label18);
            Controls.Add(comboBoxTech);
            Controls.Add(label19);
            Controls.Add(comboBoxMed);
            Controls.Add(label14);
            Controls.Add(comboBoxHertz);
            Controls.Add(label13);
            Controls.Add(comboBoxShoot);
            Controls.Add(label12);
            Controls.Add(comboBoxStealth);
            Controls.Add(label11);
            Controls.Add(comboBoxAthletics);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(LuckStat);
            Controls.Add(AgilityStat);
            Controls.Add(IntelligenceStat);
            Controls.Add(CharismaStat);
            Controls.Add(EnduranceStat);
            Controls.Add(PerceptionStat);
            Controls.Add(StrenghtStat);
            Controls.Add(pictureBox2);
            Controls.Add(textBoxPurpose);
            Controls.Add(label8);
            Controls.Add(textBoxProblem);
            Controls.Add(label7);
            Controls.Add(textBoxConception);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(comboBoxRace);
            Controls.Add(label3);
            Controls.Add(comboBoxArchetype);
            Controls.Add(textBoxDiscr);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(Loadbutton);
            Controls.Add(Savebutton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Пустельник a0.1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)StrenghtStat).EndInit();
            ((System.ComponentModel.ISupportInitialize)PerceptionStat).EndInit();
            ((System.ComponentModel.ISupportInitialize)EnduranceStat).EndInit();
            ((System.ComponentModel.ISupportInitialize)CharismaStat).EndInit();
            ((System.ComponentModel.ISupportInitialize)IntelligenceStat).EndInit();
            ((System.ComponentModel.ISupportInitialize)AgilityStat).EndInit();
            ((System.ComponentModel.ISupportInitialize)LuckStat).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHPmax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFtUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFT).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownArmor).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCaps).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Savebutton;
        private Button Loadbutton;
        private TextBox textBoxName;
        private Label label1;
        private Label label2;
        private TextBox textBoxDiscr;
        private ComboBox comboBoxArchetype;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxRace;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private TextBox textBoxConception;
        private TextBox textBoxProblem;
        private Label label7;
        private TextBox textBoxPurpose;
        private Label label8;
        private PictureBox pictureBox2;
        private NumericUpDown StrenghtStat;
        private NumericUpDown PerceptionStat;
        private NumericUpDown EnduranceStat;
        private NumericUpDown CharismaStat;
        private NumericUpDown IntelligenceStat;
        private NumericUpDown AgilityStat;
        private NumericUpDown LuckStat;
        private Label label9;
        private Label label10;
        private ComboBox comboBoxAthletics;
        private ComboBox comboBoxStealth;
        private Label label11;
        private ComboBox comboBoxShoot;
        private Label label12;
        private ComboBox comboBoxHertz;
        private Label label13;
        private ComboBox comboBoxMed;
        private Label label14;
        private ComboBox comboBoxCoercion;
        private Label label15;
        private ComboBox comboBoxManipulation;
        private Label label16;
        private ComboBox comboBoxSurvive;
        private Label label17;
        private ComboBox comboBoxKnowledge;
        private Label label18;
        private ComboBox comboBoxTech;
        private Label label19;
        private Label label20;
        private NumericUpDown numericUpDownHP;
        private NumericUpDown numericUpDownHPmax;
        private Label label21;
        private NumericUpDown numericUpDownFtUpdate;
        private Label label22;
        private NumericUpDown numericUpDownFT;
        private Label label23;
        private NumericUpDown numericUpDownArmor;
        private Label label24;
        private Label label32;
        private CheckBox checkBoxSupplies0;
        private CheckBox checkBoxSupplies1;
        private CheckBox checkBoxSupplies2;
        private NumericUpDown numericUpDownCaps;
        private Label label33;
    }
}