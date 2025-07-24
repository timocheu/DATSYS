using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using StudentInformationSystem.Forms;
using StudentInformationSystem.Models;
using System.ComponentModel;
using System.Configuration;
using Utility.Password;

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
        }

        private void btn_RegisterAdmin_ClickAsync(object sender, EventArgs e)
        {
            using SisContext context = new();

            try
            {
                var user = new User
                {
                    FirstName = "Anchor",
                    LastName = "Arnejo",
                    DateOfBirth = DateTime.Parse("2004-01-04"),
                    Gender = "Male",
                    Email = "anchor@gmail.com",
                    Phone = "+09066671234",
                    Role = context.Roles.First(r => r.RoleName == "Teacher"),
                };

                var StudentLogin = new UserLogin
                {
                    Username = "AnchorTeacher",
                    PasswordHash = Password.Hash("TeacherPass"),
                    User = user,
                };

                context.Users.Add(user);
                context.UserLogins.Add(StudentLogin);
                context.SaveChanges();


            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("DbUpdateException: " + ex.Message);

                if (ex.InnerException != null)
                    MessageBox.Show("InnerException: " + ex.InnerException.Message);

                if (ex.InnerException?.InnerException != null)
                    MessageBox.Show("Deeper Inner: " + ex.InnerException.InnerException.Message);
            }


            if (context.Users.Any(u => u.Email == "anchor@gmail.com"))
            {
                MessageBox.Show("Successfully registerd");
            }
            else
            {
                MessageBox.Show("User not registered");
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            using SisContext context = new();

            var user = context.UserLogins
                .Include(u => u.User)
                .FirstOrDefault(u =>
                    u.Username == tb_Username.Text &&
                    u.PasswordHash == Password.Hash(tb_Password.Text));

            if (user is not null)
            {
                var role = context.Roles.First(r => r.RoleId == user.User.RoleId);

                if (role is not null)
                {
                    switch (role.RoleName)
                    {
                        case "Student":
                            new StudentDashboard().Show();
                            break;
                        case "Teacher":
                            new TeacherDashboard().Show();
                            break;
                        case "Admin":
                            new AdminDashboard().Show();
                            break;
                        default:
                            MessageBox.Show("Unable to find the role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Unable to login!");
            }
        }
    }
}
