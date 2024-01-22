using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace FalloutCha
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Створюю клас персонажа

            Character MainCh = new Character();
            // Опис персонажа 

            MainCh.Name = textBoxName.Text;
            MainCh.Discr = textBoxDiscr.Text;
            MainCh.Archetype = comboBoxArchetype.Text;
            MainCh.Race = comboBoxRace.Text;
            // Аспекти

            MainCh.aspects["Concept"] = textBoxConception.Text;
            MainCh.aspects["Problems"] = textBoxProblem.Text;
            MainCh.aspects["Purpose"] = textBoxPurpose.Text;
            // Стати SPECIAL
            MainCh.attributes["S"] = (int)StrenghtStat.Value;
            MainCh.attributes["P"] = (int)PerceptionStat.Value;
            MainCh.attributes["E"] = (int)EnduranceStat.Value;
            MainCh.attributes["C"] = (int)CharismaStat.Value;
            MainCh.attributes["I"] = (int)IntelligenceStat.Value;
            MainCh.attributes["A"] = (int)AgilityStat.Value;
            MainCh.attributes["L"] = (int)LuckStat.Value;
            //Навички

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
            // ОЗ і інші ресурси

            MainCh.Hp_max = (int)numericUpDownHPmax.Value;
            MainCh.Hp = (int)numericUpDownHP.Value;
            MainCh.Armor = (int)numericUpDownArmor.Value;
            MainCh.supplies[0] = checkBoxSupplies0.Checked;
            MainCh.supplies[1] = checkBoxSupplies1.Checked;
            MainCh.supplies[2] = checkBoxSupplies2.Checked;
            MainCh.Caps = (int)numericUpDownCaps.Value;
            MainCh.FT_have = (int)numericUpDownFT.Value;
            MainCh.FT_Update = (int)numericUpDownFtUpdate.Value;

            //Зберігаємо у json
            string pathName;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Зберігти Персонажа";
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
                //MessageBox.Show("помилка", "фаіл не створено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Створюю файл
            FileStream fs = File.Create(pathName);
            byte[] info = new UTF8Encoding(true).GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(MainCh));
            fs.Write(info, 0, info.Length);
            // Перевірка
            if (File.Exists(pathName))
            {
                MessageBox.Show("Фаіл створено", "Єпі!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Помилка", "Фаіл не створено", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Character MainCh;
            //string file;
            OpenFileDialog FileChooseDilog = new OpenFileDialog();
            FileChooseDilog.Title = "Оберіть файл";
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
                        MessageBox.Show("Некоректний файл", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Файл не знайдено", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //string json = File.ReadAllText(FileChooseDilog.FileName);
                //MessageBox.Show(json, "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //t = JsonConvert.DeserializeObject<Character>(json);

            }
            else
            {
                //MessageBox.Show("Файл не обрано!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Опис персонажа 
            textBoxName.Text = MainCh.Name;
            textBoxDiscr.Text = MainCh.Discr;
            comboBoxArchetype.Text = MainCh.Archetype;
            comboBoxRace.Text = MainCh.Race;
            // Аспекти
            textBoxConception.Text = MainCh.aspects["Concept"];
            textBoxProblem.Text = MainCh.aspects["Problems"];
            textBoxPurpose.Text = MainCh.aspects["Purpose"];
            // Стати SPECIAL
            StrenghtStat.Value = MainCh.attributes["S"];
            PerceptionStat.Value = MainCh.attributes["P"];
            EnduranceStat.Value = MainCh.attributes["E"];
            CharismaStat.Value = MainCh.attributes["C"];
            IntelligenceStat.Value = MainCh.attributes["I"];
            AgilityStat.Value = MainCh.attributes["A"];
            LuckStat.Value = MainCh.attributes["L"];
            //Навички
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
            // ОЗ і інші ресурси
            numericUpDownHPmax.Value = MainCh.Hp_max;
            numericUpDownHP.Value = MainCh.Hp;
            numericUpDownArmor.Value = MainCh.Armor;
            checkBoxSupplies0.Checked = MainCh.supplies[0];
            checkBoxSupplies1.Checked = MainCh.supplies[1];
            checkBoxSupplies2.Checked = MainCh.supplies[2];
            numericUpDownCaps.Value = MainCh.Caps;
            numericUpDownFT.Value = MainCh.FT_have;
            numericUpDownFtUpdate.Value = MainCh.FT_Update;
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

        }
    }
}