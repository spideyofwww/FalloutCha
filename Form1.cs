using Newtonsoft.Json;
using System.Text;


namespace FalloutCha
{

    public partial class Form1 : Form
    {
        Character MainCh = new Character();
        char[] stats = { 'S', 'P', 'E', 'C', 'I', 'A', 'L' };
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ���� ��������� 

            MainCh.Name = textBoxName.Text;
            MainCh.Discr = textBoxDiscr.Text;
            MainCh.Archetype = comboBoxArchetype.Text;
            MainCh.Race = comboBoxRace.Text;
            // �������

            MainCh.aspects["Concept"] = textBoxConception.Text;
            MainCh.aspects["Problems"] = textBoxProblem.Text;
            MainCh.aspects["Purpose"] = textBoxPurpose.Text;
            // ����� SPECIAL
            MainCh.attributes["S"] = (int)StrenghtStat.Value;
            MainCh.attributes["P"] = (int)PerceptionStat.Value;
            MainCh.attributes["E"] = (int)EnduranceStat.Value;
            MainCh.attributes["C"] = (int)CharismaStat.Value;
            MainCh.attributes["I"] = (int)IntelligenceStat.Value;
            MainCh.attributes["A"] = (int)AgilityStat.Value;
            MainCh.attributes["L"] = (int)LuckStat.Value;
            //�������

            MainCh.skills["Athletics"] = comboBoxAthletics.Text;
            MainCh.skills["Stealth"] = comboBoxStealth.Text;
            MainCh.skills["Shoot"] = comboBoxShoot.Text;
            MainCh.skills["Hertz"] = comboBoxHertz.Text;
            MainCh.skills["Med"] = comboBoxMed.Text;
            MainCh.skills["Tech"] = comboBoxTech.Text;
            MainCh.skills["Knowledge"] = comboBoxKnowledge.Text;
            MainCh.skills["Survive"] = comboBoxSurvive.Text;
            MainCh.skills["Manipulation"] = comboBoxManipulation.Text;
            MainCh.skills["Coercion"] = comboBoxCoercion.Text;
            // �� � ���� �������

            MainCh.Hp_max = Convert.ToInt32(labelMaxHP.Text);
            MainCh.Hp = (int)numericUpDownHP.Value;
            MainCh.Armor = (int)numericUpDownArmor.Value;
            MainCh.supplies[0] = checkBoxSupplies0.Checked;
            MainCh.supplies[1] = checkBoxSupplies1.Checked;
            MainCh.supplies[2] = checkBoxSupplies2.Checked;
            MainCh.Caps = (int)numericUpDownCaps.Value;
            //MainCh.FT_have = (int)numericUpDownFT.Value;
            //MainCh.FT_Update = (int)numericUpDownFtUpdate.Value;

            //�������� � json
            string pathName;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "������� ���������";
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.FileName = MainCh.Name + ".json";
            saveFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathName = saveFileDialog.FileName;
            }
            else
            {
                //MessageBox.Show("�������", "��� �� ��������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //������� ����
            FileStream fs = File.Create(pathName);
            byte[] info = new UTF8Encoding(true).GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(MainCh));
            fs.Write(info, 0, info.Length);
            // ��������
            if (File.Exists(pathName))
            {
                MessageBox.Show("��� ��������", "��!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("�������", "��� �� ��������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            fs.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainCh.Race = comboBoxRace.Text;
            MainCh.MaxHPCount();
            numericUpDownHP.Maximum = MainCh.Hp_max;
            MainCh.StatMaxMin();

            label_S_Max.Text = Convert.ToString(MainCh.attributesMax["S"]) ;
            label_S_Min.Text = Convert.ToString(MainCh.attributesMin["S"]);
            StrenghtStat.Maximum = MainCh.attributesMax["S"];
            StrenghtStat.Minimum = MainCh.attributesMin["S"];
            label_P_Max.Text = Convert.ToString(MainCh.attributesMax["P"]);
            label_P_Min.Text = Convert.ToString(MainCh.attributesMin["P"]);
            PerceptionStat.Maximum = MainCh.attributesMax["P"];
            PerceptionStat.Minimum = MainCh.attributesMin["P"];
            label_E_Max.Text = Convert.ToString(MainCh.attributesMax["E"]);
            label_E_Min.Text = Convert.ToString(MainCh.attributesMin["E"]);
            EnduranceStat.Maximum = MainCh.attributesMax["E"];
            EnduranceStat.Minimum = MainCh.attributesMin["E"];
            label_C_Max.Text = Convert.ToString(MainCh.attributesMax["C"]);
            label_C_Min.Text = Convert.ToString(MainCh.attributesMin["C"]);
            CharismaStat.Maximum = MainCh.attributesMax["C"];
            CharismaStat.Minimum = MainCh.attributesMin["C"];
            label_I_Max.Text = Convert.ToString(MainCh.attributesMax["I"]);
            label_I_Min.Text = Convert.ToString(MainCh.attributesMin["I"]);
            IntelligenceStat.Maximum = MainCh.attributesMax["I"];
            IntelligenceStat.Minimum = MainCh.attributesMin["I"];
            label_A_Max.Text = Convert.ToString(MainCh.attributesMax["A"]);
            label_A_Min.Text = Convert.ToString(MainCh.attributesMin["A"]);
            AgilityStat.Maximum = MainCh.attributesMax["A"];
            AgilityStat.Minimum = MainCh.attributesMin["A"];
            label_L_Max.Text = Convert.ToString(MainCh.attributesMax["L"]);
            label_L_Min.Text = Convert.ToString(MainCh.attributesMin["L"]);
            LuckStat.Maximum = MainCh.attributesMax["L"];
            LuckStat.Minimum = MainCh.attributesMin["L"];
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxSupplies0.Checked)
            {
                checkBoxSupplies1.Checked = false;
                checkBoxSupplies2.Checked = false;
            }
        }

        private void Loadbutton_Click(object sender, EventArgs e)
        {
            //string file;
            OpenFileDialog FileChooseDilog = new OpenFileDialog();
            FileChooseDilog.Title = "������ ����";
            FileChooseDilog.DefaultExt = "json";
            FileChooseDilog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            if (FileChooseDilog.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(FileChooseDilog.FileName, "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //file = FileChooseDilog.FileName;
                //FileStream fs = File.Create(FileChooseDilog.FileName);
                if (File.Exists(FileChooseDilog.FileName))
                {
                    MainCh = JsonConvert.DeserializeObject<Character>(File.ReadAllText(FileChooseDilog.FileName));
                    if (MainCh == null)
                    {
                        MessageBox.Show("����������� ����", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("���� �� ��������", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //string json = File.ReadAllText(FileChooseDilog.FileName);
                //MessageBox.Show(json, "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //t = JsonConvert.DeserializeObject<Character>(json);

            }
            else
            {
                //MessageBox.Show("���� �� ������!", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ���� ��������� 
            textBoxName.Text = MainCh.Name;
            textBoxDiscr.Text = MainCh.Discr;
            comboBoxArchetype.Text = MainCh.Archetype;
            comboBoxRace.Text = MainCh.Race;
            // �������
            textBoxConception.Text = MainCh.aspects["Concept"];
            textBoxProblem.Text = MainCh.aspects["Problems"];
            textBoxPurpose.Text = MainCh.aspects["Purpose"];
            // ����� SPECIAL
            StrenghtStat.Value = MainCh.attributes["S"];
            PerceptionStat.Value = MainCh.attributes["P"];
            EnduranceStat.Value = MainCh.attributes["E"];
            CharismaStat.Value = MainCh.attributes["C"];
            IntelligenceStat.Value = MainCh.attributes["I"];
            AgilityStat.Value = MainCh.attributes["A"];
            LuckStat.Value = MainCh.attributes["L"];
            //�������
            //t.skills.Add("Athletics", comboBoxAthletics.Text);
            comboBoxAthletics.Text = MainCh.skills["Athletics"];
            comboBoxStealth.Text = MainCh.skills["Stealth"];
            comboBoxShoot.Text = MainCh.skills["Shoot"];
            comboBoxHertz.Text = MainCh.skills["Hertz"];
            comboBoxMed.Text = MainCh.skills["Med"];
            comboBoxTech.Text = MainCh.skills["Tech"];
            comboBoxKnowledge.Text = MainCh.skills["Knowledge"];
            comboBoxSurvive.Text = MainCh.skills["Survive"];
            comboBoxManipulation.Text = MainCh.skills["Manipulation"];
            comboBoxCoercion.Text = MainCh.skills["Coercion"];
            // �� � ���� �������
            labelMaxHP.Text = Convert.ToString(MainCh.Hp_max);
            numericUpDownHP.Value = MainCh.Hp;
            numericUpDownArmor.Value = MainCh.Armor;
            checkBoxSupplies0.Checked = MainCh.supplies[0];
            checkBoxSupplies1.Checked = MainCh.supplies[1];
            checkBoxSupplies2.Checked = MainCh.supplies[2];
            numericUpDownCaps.Value = MainCh.Caps;
            numericUpDownFT.Value = MainCh.FT["FT_have"];
            labelFtUpdat.Text = Convert.ToString(MainCh.FT["FT_Update"]);
        }

        private void checkBoxSupplies1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxSupplies1.Checked)
            {
                checkBoxSupplies1.Checked = false;
            }
            else
            {
                checkBoxSupplies0.Checked = true;
            }
        }

        private void checkBoxSupplies2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSupplies2.Checked)
            {
                checkBoxSupplies0.Checked = true;
                checkBoxSupplies1.Checked = true;
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            //������� ���� ���������
            Character MainCh = new Character();
            // ���� ��������� 

            MainCh.Name = textBoxName.Text;
            MainCh.Discr = textBoxDiscr.Text;
            MainCh.Archetype = comboBoxArchetype.Text;
            MainCh.Race = comboBoxRace.Text;
            // �������

            MainCh.aspects["Concept"] = textBoxConception.Text;
            MainCh.aspects["Problems"] = textBoxProblem.Text;
            MainCh.aspects["Purpose"] = textBoxPurpose.Text;
            // ����� SPECIAL
            MainCh.attributes["S"] = (int)StrenghtStat.Value;
            MainCh.attributes["P"] = (int)PerceptionStat.Value;
            MainCh.attributes["E"] = (int)EnduranceStat.Value;
            MainCh.attributes["C"] = (int)CharismaStat.Value;
            MainCh.attributes["I"] = (int)IntelligenceStat.Value;
            MainCh.attributes["A"] = (int)AgilityStat.Value;
            MainCh.attributes["L"] = (int)LuckStat.Value;
            //�������

            MainCh.skills["Athletics"] = comboBoxAthletics.Text;
            MainCh.skills["Stealth"] = comboBoxStealth.Text;
            MainCh.skills["Shoot"] = comboBoxShoot.Text;
            MainCh.skills["Hertz"] = comboBoxHertz.Text;
            MainCh.skills["Med"] = comboBoxMed.Text;
            MainCh.skills["Tech"] = comboBoxTech.Text;
            MainCh.skills["Knowledge"] = comboBoxKnowledge.Text;
            MainCh.skills["Survive"] = comboBoxSurvive.Text;
            MainCh.skills["Manipulation"] = comboBoxManipulation.Text;
            MainCh.skills["Coercion"] = comboBoxCoercion.Text;
            // �� � ���� �������

            MainCh.Hp_max = Convert.ToInt32(labelMaxHP.Text);
            MainCh.Hp = (int)numericUpDownHP.Value;
            MainCh.Armor = (int)numericUpDownArmor.Value;
            MainCh.supplies[0] = checkBoxSupplies0.Checked;
            MainCh.supplies[1] = checkBoxSupplies1.Checked;
            MainCh.supplies[2] = checkBoxSupplies2.Checked;
            MainCh.Caps = (int)numericUpDownCaps.Value;
            MainCh.FT["FT_Update"] = Convert.ToInt32(labelFtUpdat.Text);
            MainCh.FT["FT_have"] = (int)numericUpDownFT.Value;

            //�������� � json
            string pathName;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "������� ���������";
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.FileName = MainCh.Name + ".json";
            saveFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathName = saveFileDialog.FileName;
            }
            else
            {
                //MessageBox.Show("�������", "��� �� ��������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //������� ����
            FileStream fs = File.Create(pathName);
            byte[] info = new UTF8Encoding(true).GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(MainCh));
            fs.Write(info, 0, info.Length);
            // ��������
            if (File.Exists(pathName))
            {
                MessageBox.Show("��� ��������", "��!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("�������", "��� �� ��������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            fs.Close();
        }

        private void LuckStat_ValueChanged(object sender, EventArgs e)
        {
            MainCh.attributes["L"] = (int)LuckStat.Value;
            MainCh.FtUpadatecheck();
            labelFtUpdat.Text = Convert.ToString(MainCh.FT["FT_Update"]);
            numericUpDownFT.Maximum = MainCh.FT["FT_Update"];
        }

        private void comboBoxArchetype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EnduranceStat_ValueChanged(object sender, EventArgs e)
        {
            MainCh.attributes["E"] = (int)EnduranceStat.Value;
            MainCh.MaxHPCount();
            numericUpDownHP.Maximum = MainCh.Hp_max;
            labelMaxHP.Text = Convert.ToString(MainCh.Hp_max);
        }
    }
}