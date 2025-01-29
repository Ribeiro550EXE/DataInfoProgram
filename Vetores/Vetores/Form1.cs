using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vetores
{
    

    public partial class Form1 : Form
    {
        public static Form1 instance;
        public TextBox TB1;
        string path = Environment.CurrentDirectory;
        string pathS = Environment.CurrentDirectory + ("\\Students\\");
        //string pathI = Environment.CurrentDirectory + ("\\IMG\\");
        //string N, L;
        int i = 1;
        int i1 = 1;
        Contact[] Contactt2 = new Contact[5];
        bool FoundedB = false;
        
        public Form1()
        {
            InitializeComponent();
            instance = this;
            TB1 = TXTPATH;
            StreamReader sr = new StreamReader(Application.StartupPath + "\\Students\\" + "DetailContacts" + ".txt");
            CDFT.Text = sr.ReadLine();

            sr.Close();
        }

    

        private void BAddContact_Click(object sender, EventArgs e)
        {
            Debug.Print(Convert.ToString("Digitos :" + NumT.TextLength));
            if (NumT.TextLength < 9)
            {
                MessageBox.Show("The number phone needs 9 characters");
                return;
            }
           

            Contacts(1);
            ContactLabel.Text = ContactLabel.Text + "\n" + AddContact.Text;
            
            AddContact.Text = "";

            string text = CDFT.Text;
            i1 = Convert.ToInt32(text) + 1;
            i++;
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Students\\" + "DetailContacts" + ".txt");
            sw.WriteLine(i1);
            Debug.WriteLine(i);
            Debug.WriteLine(i1);
            sw.WriteLine("Contacts : " + i);
            sw.Close();

            StreamReader sr = new StreamReader(Application.StartupPath + "\\Students\\" + "DetailContacts" + ".txt");
            CDFT.Text = sr.ReadLine();

            sr.Close();

            AgeT.Text = "";
            LocT.Text = "";
            NumT.Text = "";
            BirthT.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddContact_TextChanged(object sender, EventArgs e)
        {
           
        }
        public void Contacts(int op)
        {
            int[] n = new int[10];
            Contact Contactt = new Contact();
            
            if (op == 1)
            {
                Contact Contactt1 = Contact1(Contactt);
                LName.Text = Contactt1.getName();
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Students\\" + Contactt1.getName() + ".txt");
                Contactt2[i] = Contactt1;
                sw.WriteLine("");
                sw.WriteLine("-------" + Contactt1.getName() + "-------");
                sw.WriteLine("Age: " + Contactt1.getAge());
                sw.WriteLine("Birth : " + Contactt1.getBirth());
                sw.WriteLine("NTel: " + Contactt1.getNTel());
                sw.WriteLine("Loc : " + Contactt1.getLoc());
                
                sw.Close();

                StreamReader sr = new StreamReader(Application.StartupPath + "\\Students\\" + Contactt1.getName() + ".txt");
                ReadFilesRTB.Text = sr.ReadToEnd();
                sr.Close();
                //LName.Text = Convert.ToString(i);
            }
            else if(op == 2)
            {
                string path = Environment.CurrentDirectory + ("\\Students\\" + FoundText.Text + ".txt");
                
                if (File.Exists(path))
                {
                    StreamReader sr = new StreamReader(Application.StartupPath + "\\Students\\" + FoundText.Text + ".txt");
                    FRFile.Text = sr.ReadToEnd();
                    sr.Close();
                    
                }
                
                //LocTF.Text = Convert.ToString(N1);
                for (int c = 1; c < i; c++)
                {
                    if (FoundText.Text == Contactt2[c].getName())
                    {
                        Founded.Text = "Encontrado";
                        FoundedB = true;
                        NumTF.Text = Convert.ToString(Contactt2[c].getNTel());
                        AgeTF.Text = Convert.ToString(Contactt2[c].getAge());
                        LocTF.Text = Contactt2[c].getLoc();
                    }
                    else if (FoundedB == false || FoundText.Text == "")
                    {
                        
                        Founded.Text = "Não Encontrado";
                        FoundedB = false;
                        
                    }
                }
            }
 
        }

        private void FoundText_TextChanged(object sender, EventArgs e)
        {
            Contacts(2);
            //LocTF.Text = Convert.ToString(Convert.ToInt16(LocTF.Text) + 1);
        }
        public Contact Contact1(Contact cnt)
        {
            string name = AddContact.Text;
            int age = Convert.ToInt32(AgeT.Text);
            string loc = LocT.Text;
            long ntel = Convert.ToInt32(NumT.Text);
            DateTime.TryParseExact(BirthT.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birth);

            if (DateTime.TryParseExact(BirthT.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birth))
            {
                //
            }

            cnt = new Contact(name, age, loc, ntel,birth);
            return cnt;
        }
        public void IdadeDe(DateTime birth2)
        {
            var birthdate = birth2;
            var data = DateTime.Today;

            var years = data.Year - birthdate.Year;
            var months = data.Month - birthdate.Month;
            var days = data.Day - birthdate.Day;

           
            TimeSpan compare2 = data - birthdate;

            var datadays = data.Day;
            var birthdays = birthdate.Day;

            var datamonths = data.Month;
            var birthmonths = birthdate.Month;


           //Debug.Print(Convert.ToString(compare/30));
            Debug.Print(Convert.ToString(compare2.Days));
            Debug.Print(Convert.ToString(months));
            Debug.Print(Convert.ToString(days));
            Debug.Print("A" + compare2.Days/365 + "" );
            AgeT.Text = Convert.ToString(compare2.Days/365);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + ("\\Students\\" + FoundText.Text + ".txt");
            string path2 = Environment.CurrentDirectory + ("\\StudentsDeleted\\" + FoundText.Text + ".txt");
            Debug.WriteLine(File.Exists(path2));
            if (File.Exists(path))
            {
                Debug.WriteLine(File.Exists(path2));
                if (File.Exists(path2))
                {
                    File.Delete(path2);
                }
                File.Move(path, path2);
                string text = CDFT.Text;
                i1 = Convert.ToInt32(text) - 1;
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Students\\" + "DetailContacts" + ".txt");
                sw.WriteLine(i1);
                Debug.WriteLine(i);
                Debug.WriteLine(i1);
                sw.WriteLine("Contacts : " + i1);
                sw.Close();

                StreamReader sr = new StreamReader(Application.StartupPath + "\\Students\\" + "DetailContacts" + ".txt");
                CDFT.Text = sr.ReadLine();

                sr.Close();
                MessageBox.Show(FoundText.Text + " Deleted");
            }
            
        }

        private void BirthT_TextChanged(object sender, EventArgs e)
        {
            Debug.Print(Convert.ToString(DateTime.TryParse(BirthT.Text, out DateTime dt)));
            Debug.Print(Convert.ToString(DateTime.TryParseExact(BirthT.Text,"dd/MM/yyyy",CultureInfo.InvariantCulture,DateTimeStyles.None, out DateTime dt2)));
            Debug.Print(Convert.ToString(dt2.Year));
            Debug.Print(Convert.ToString(dt2.Month));
            Debug.Print(Convert.ToString(dt2.Day));

            if (DateTime.TryParseExact(BirthT.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt2))
            {
                IdadeDe(dt2);
            }

        }

        private void NumT_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void BTDeleteMultipleFiles_Click(object sender, EventArgs e)
        {
            Form DeleteMFF = new DeleteMultipleItems();
            DeleteMultipleItems.instance.LockPath(pathS);
            DeleteMFF.Show();
        }
    }
    public class Contact
    {
        public string name;
        public int age;
        public string loc;
        public long nºTel;
        public DateTime birth;

        public Contact()
        {

        }
        public Contact (string Name, int Age, string Loc, long NºTel, DateTime Birth)
        {
            this.name = Name;
            this.age = Age;
            this.loc = Loc;
            this.nºTel = NºTel;
            this.birth = Birth;
        }
        public string getName() { return name;}
        public int getAge() {return age;}
        public string getLoc() { return loc; }
        public long getNTel() { return nºTel; }
        public DateTime getBirth() { return birth;}
    }

    

}
