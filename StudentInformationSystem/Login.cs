using StudentInformationSystem.Models;
using System.ComponentModel;

namespace StudentInformationSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            using SisContext db = new();

            var admin = new Admin
            {
                FullName = "Timotheo Che Padilla",
                Email = "admin@boss.com",
                Phone = "+123456",
                DateOfBirth = new DateTime(2004, 7, 22),
                Gender = "Male",
                CreatedAt = DateTime.UtcNow,
                Usertype = "Admin",

                UserLogin = new UserLogin
                {
                    Username = "timadmin",
                    PasswordHash = "12345"
                }
            };

            db.Admins.Add(admin);
            db.SaveChanges();


            foreach (var ad in db.UserLogins.ToList())
            {
                MessageBox.Show($"User:{ad.User}, Pass:{ad.PasswordHash}");
            }
        }
    }
}
