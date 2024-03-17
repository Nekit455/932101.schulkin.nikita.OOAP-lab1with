using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Builder
{
    public partial class Form1 : Form
    {
        private IDeveloper developer;
        private Director director;

        public Form1()
        {
            InitializeComponent();
        }

        // Кнопка выбора IPhone
        private void IPhoneBtn_Click(object sender, EventArgs e)
        {
            developer = new IPhoneDeveloper();
            director = new Director(developer);
            zLabel.Text = "Тип телефона: IPhone";
            UpdateInfo();
        }

        // Кнопка выбора Android
        private void AndroidBtn_Click(object sender, EventArgs e)
        {
            developer = new AndroidDeveloper();
            director = new Director(developer);
            zLabel.Text = "Тип телефона: Android";
            UpdateInfo();
        }

        // Кнопка "собрать только корпус и дисплей"
        private void BuildPartiallyBtn_Click(object sender, EventArgs e)
        {
            if (developer != null && director != null)
            {
                Phone phone = director.MountOnlyPhone();
                ShowPhoneInfo(phone);
            } 
            else
            {
                zLabel.Text = "Сначала выберите тип телефона.";
            }
        }

        // Кнопка "Собрать целый телефон"
        private void BuildFullBtn_Click(object sender, EventArgs e)
        {
            if (developer != null && director != null)
            {
                Phone phone = director.MountFullPhone();
                ShowPhoneInfo(phone);
            }
            else
            {
                zLabel.Text = "Сначала выберите тип телефона.";
            }
        }

        private void UpdateInfo()
        {
            Phone phone = developer.GetPhone();
            ShowPhoneInfo(phone);
        }

        private void ShowPhoneInfo(Phone phone)
        {
            lblPhoneInfo.Text = phone.AboutPhone();
        }

        private void lblClear()
        {
            lblPhoneInfo.Text = string.Empty;
        }

        public class Phone
        {
            private string data;

            public Phone()
            {
                data = "";
            }

            public string AboutPhone()
            {
                return data;
            }

            public void AppendData(string str)
            {
                data += str;
            }
        }

        public interface IDeveloper
        {
            void CreateDisplay();
            void CreateBox();
            void SystemInstall();
            Phone GetPhone();
        }

        public class AndroidDeveloper : IDeveloper
        {
            private Phone phone;

            public AndroidDeveloper()
            {
                phone = new Phone();
            }

            public void CreateDisplay()
            {
                phone.AppendData("Произведен дисплей Samsung;\n");
            }

            public void CreateBox()
            {
                phone.AppendData("Произведен корпус Samsung;\n");
            }

            public void SystemInstall()
            {
                phone.AppendData("Установлена система Android;\n");
            }

            public Phone GetPhone()
            {
                return phone;
            }
        }

        public class IPhoneDeveloper : IDeveloper
        {
            private Phone phone;

            public IPhoneDeveloper()
            {
                phone = new Phone();
            }

            public void CreateDisplay()
            {
                phone.AppendData("Произведен дисплей Apple; ");
            }

            public void CreateBox()
            {
                phone.AppendData("Произведен корпус Apple");
            }

            public void SystemInstall()
            {
                phone.AppendData("Установлена система iOS");
            }

            public Phone GetPhone()
            {
                return phone;
            }
        }

        public class Director
        {
            private IDeveloper developer;

            public Director(IDeveloper dev)
            {
                developer = dev;
            }

            // Собрать телефон частично
            public Phone MountOnlyPhone()
            {
                developer.CreateBox();
                developer.CreateDisplay();
                return developer.GetPhone();
            }


            // Собрать целый телефон
            public Phone MountFullPhone()
            {
                developer.CreateBox();
                developer.CreateDisplay();
                developer.SystemInstall();
                return developer.GetPhone();
            }
        }
    }
}
