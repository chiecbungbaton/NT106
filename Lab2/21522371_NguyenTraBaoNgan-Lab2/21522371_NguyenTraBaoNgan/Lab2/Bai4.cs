using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Lab2.Bai4;
using System.Reflection;

namespace Lab2
{
    public partial class Bai4 : Form
    {
        
        [Serializable]
        public class Student
        {
            public string Name { get; set; }
            public int ID { get; set; }
            public string Phone { get; set; }
            public int Score1 { get; set; }
            public int Score2 { get; set; }
            public int Score3 { get; set; }
            public double AvgScore { get; set; }
            public Student(string name, string id, string phone, string score1, string score2, string score3)
            {
                Name = name;                
                try
                {
                    if (id.ToString().Length != 8 || !int.TryParse(id.ToString(), out int idValue))
                    {
                        throw new ArgumentException("ID must be an 8-digit number.");
                    }
                    ID = int.Parse(id);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                    bool isValid = false;
                    while (!isValid)
                    {
                        id = Microsoft.VisualBasic.Interaction.InputBox("Enter ID:");
                        if (id.ToString().Length == 8 && int.TryParse(id.ToString(), out int idValue))
                        {
                            isValid = true;
                            ID = int.Parse(id);
                        }
                        else
                        {
                            MessageBox.Show("ID must be an 8-digit number.");
                        }
                    }
                }

                try
                {
                    if (phone.Length != 10 || !phone.StartsWith("0") || !long.TryParse(phone, out long phoneValue))
                    {
                        throw new ArgumentException("Phone must be a 10-digit number starting with 0.");
                    }
                    Phone = phone;
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                    bool isValid = false;
                    while (!isValid)
                    {
                        phone = Microsoft.VisualBasic.Interaction.InputBox("Enter phone:");
                        if (phone.Length == 10 && phone.StartsWith("0") && long.TryParse(phone, out long phoneValue))
                        {
                            isValid = true;
                            Phone = phone;
                        }
                        else
                        {
                            MessageBox.Show("Phone must be a 10-digit number starting with 0. Please try again.");
                        }
                    }
                }

                try
                {
                    if (!int.TryParse(score1, out int score1Value) || score1Value < 0 || score1Value > 10)
                    {
                        throw new ArgumentException("Score1 must be a number between 0 and 10.");
                    }
                    Score1 = int.Parse(score1);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                    bool isValid = false;
                    while (!isValid)
                    {
                        score1 = Microsoft.VisualBasic.Interaction.InputBox("Enter Score 1:");
                        if (int.TryParse(score1, out int score1Value) && score1Value >= 0 && score1Value <= 10)
                        {
                            isValid = true;
                            Score1 = int.Parse(score1);                            
                        }
                        else
                        {
                            MessageBox.Show("Score1 must be a number between 0 and 10.");
                        }
                    }
                }

                try
                {
                    if (!int.TryParse(score2, out int score2Value) || score2Value < 0 || score2Value > 10)
                    {
                        throw new ArgumentException("Score 2 must be a number between 0 and 10.");
                    }
                    Score2 = int.Parse(score2);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                    bool isValid = false;
                    while (!isValid)
                    {
                        score2 = Microsoft.VisualBasic.Interaction.InputBox("Enter Score 2:");
                        if (int.TryParse(score2, out int score2Value) && score2Value >= 0 && score2Value <= 10)
                        {
                            isValid = true;
                            Score2 = int.Parse(score2);
                            
                        }
                        else
                        {
                            MessageBox.Show("Score 2 must be a number between 0 and 10.");
                        }
                    }
                }

                try
                {
                    if (!int.TryParse(score3, out int score3Value) || score3Value < 0 || score3Value > 10)
                    {
                        throw new ArgumentException("Score 3 must be a number between 0 and 10.");
                    }
                    Score3 = int.Parse(score3);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                    bool isValid = false;
                    while (!isValid)
                    {
                        score3 = Microsoft.VisualBasic.Interaction.InputBox("Enter Score 3:");
                        if (int.TryParse(score3, out int score3Value) && score3Value >= 0 && score3Value <= 10)
                        {
                            isValid = true;
                            Score3 = int.Parse(score3);                            
                        }
                        else
                        {
                            MessageBox.Show("Score 3 must be a number between 0 and 10.");
                        }
                    }
                }
            }
            
        }
        public Bai4()
        {
            InitializeComponent();
            
        }

        private void Bai4_Load(object sender, EventArgs e)
        {

        }

        private int currentStudent = 0;     
        private List<Student> students = new List<Student>();

        private void read_Click(object sender, EventArgs e)
        {
            string[] datas = richTextBox.Text.Trim('\n').Split(new string[] { "\n\n" }, StringSplitOptions.None);
            if (string.IsNullOrEmpty(richTextBox.Text))
            {
                MessageBox.Show("Please enter the data!");
                return;
            }            
            else
            {               
               foreach (string data in datas)
               {
                    try
                    {
                        string[] stif = data.Trim().Split('\n');
                        string name = stif[0].Trim();
                        string id = stif[1].Trim();
                        string phone = stif[2].Trim();
                        string score1 = stif[3].Trim();
                        string score2 = stif[4].Trim();
                        string score3 = stif[5].Trim();
                        Student student = new Student(name, id, phone, score1, score2, score3);
                        students.Add(student);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Please enter enough data foreach student!");
                        return;
                    }
                    
               }                    
                BinaryFormatter formatter = new BinaryFormatter();
                MemoryStream stream = new MemoryStream();
                formatter.Serialize(stream, students);
                byte[] bytes = stream.ToArray();
                File.WriteAllBytes(@"C:\Users\BAO NGAN\Desktop\21522371_NguyenTraBaoNgan\21522371_NguyenTraBaoNgan\Lab2\inputbai4.txt", bytes);
                stream = new MemoryStream(bytes);
                object obj = formatter.Deserialize(stream);
                if (obj is List<Student>)
                {
                    students = (List<Student>)obj;
                    if (students.Count > 0)
                    {
                        currentStudent = 0;
                        ShowStudentInfo1(currentStudent);
                    }
                }
            }
            richTextBox.ReadOnly = true;
            MessageBox.Show("Richtextbox has been closed. \nIf you want to add data, please restart this form hihi :3!","A message form @chiecbungbat.on",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void ShowStudentInfo1(int index)
        {
            readname.Text = students[index].Name;            
            readid.Text = students[index].ID.ToString();
            readphone.Text = students[index].Phone.ToString();
            readsc1.Text = students[index].Score1.ToString();
            readsc2.Text = students[index].Score2.ToString();
            readsc3.Text = students[index].Score3.ToString();
            readavg.Text = null;
        }
        private void next_Click(object sender, EventArgs e)
        {
            if (currentStudent < students.Count - 1)
            {
                currentStudent++;
                ShowStudentInfo1(currentStudent);
                label1.Text = (currentStudent+1).ToString();
                
            }
        }
        
        private void back_Click(object sender, EventArgs e)
        {
            if (currentStudent > 0)
            {
                currentStudent--;
                ShowStudentInfo1(currentStudent);
                label1.Text = (currentStudent + 1).ToString();
            }
        }
       
        private void ShowStudentInfo2(int index)
        {
            writename.Text = students[index].Name;
            writeid.Text = students[index].ID.ToString();
            writephone.Text = students[index].Phone.ToString();
            writesc1.Text = students[index].Score1.ToString();
            writesc2.Text = students[index].Score2.ToString();
            writesc3.Text = students[index].Score3.ToString();
            writeavg.Text = ((float)(students[index].Score1 + students[index].Score2 + students[index].Score3)/3).ToString();
        }
        private void add_Click(object sender, EventArgs e)
        {
            ShowStudentInfo2(currentStudent);
        }
        
        private void write_Click(object sender, EventArgs e)
        {
            String path = @"C:\Users\BAO NGAN\Desktop\21522371_NguyenTraBaoNgan\21522371_NguyenTraBaoNgan\Lab2\outputbai4.txt";
            FileStream fs1 = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs1);
            if (writename.Text == "")
            {
                MessageBox.Show("Data is null, please click ADD");
                return;
            }
            sw.WriteLine("Name: " + writename.Text + "\nID: " + writeid.Text + "\nPhone: " + writephone.Text + "\nScore 1: " + writesc1.Text + "\nScore 2: " + writesc2.Text + "\nScore 3: " + writesc3.Text + "\nAverage score: " + writeavg.Text + "\n\n");
            MessageBox.Show("File đã được ghi lại!");
            sw.Close();
            fs1.Close();
        }
    }
}
