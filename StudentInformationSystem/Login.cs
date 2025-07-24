using StudentInformationSystem.Forms;
using StudentInformationSystem.Models;
using System.ComponentModel;
using System.Configuration;

namespace StudentInformationSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            using SisContext context = new SisContext();

            if (context.UserLogins.Any(u =>
            u.Username == tb_Username.Text && 
            u.PasswordHash == tb_Password.Text
            ))
            {
                new AdminDashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No user found or doesnt exist");
            }
        }

        private void btn_RegisterAdmin_ClickAsync(object sender, EventArgs e)
        {
            RegisterPerson();
        }

        private async Task RegisterPerson()
        {
            using SisContext context = new();
            
            foreach (var r in context.Roles.ToArray())
            {
                MessageBox.Show(r.RoleName);
            }

            var TimAdmin = new User
            {
                FirstName = "Timotheo",
                LastName = "Padilla",
                DateOfBirth = DateTime.Parse("2004-07-22"),
                Gender = "Male",
                Email = "tim@gmail.com",
                Role = context.Roles.First(r => r.RoleName == "Admin"),
            };

            var AdminLogin = new UserLogin
            {
                Username = "TimAdmin",
                PasswordHash = "AdminPass",
                User = TimAdmin,
            };

            context.Users.Add(TimAdmin);
            context.UserLogins.Add(AdminLogin);

            await context.SaveChangesAsync();

            if (context.Users.Any(u => u.Email == "tim@gmail.com"))
            {
                MessageBox.Show("Successfully registerd");
            }
            else
            {
                MessageBox.Show("User not registered");
            }
        }

    }
}
