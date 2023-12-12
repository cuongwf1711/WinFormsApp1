using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WinFormsApp1
{
    [Index(nameof(Email), IsUnique = true)]
    public class User
    {
        public int UserId { get; set; }
        [MaxLength(64), Required]
        public string Password { get; set; }
        [EmailAddress, Required]
        public string Email { get; set; }
        [MaxLength(255), Required]
        public string FullName { get; set; }
        public ICollection<MyDownloadBooster> MyDownloads { get; set; }
        public User()
        {
            MyDownloads = new List<MyDownloadBooster>();
        }
        
        public List<MyDownloadBooster> GetMyDownloads()
        {
            using (MyContext Db = new MyContext())
            {
                return Db.Users.Include(p => p.MyDownloads).FirstOrDefault(p => p.UserId == UserId).MyDownloads.ToList();
            }
        }
        public bool ForgotPassword()
        {
            try
            {
                using (MyContext Db = new MyContext())
                {
                    User user = Db.Users.FirstOrDefault(p => p.Email == Email);
                    if(user == null)
                    {
                        return false;
                    }
                    string code = StaticFunc.GenerateRandomString(8);
                    if (!StaticFunc.SendEmail(Email, "Recovery password code", code))
                    {
                        return false;
                    }
                    user.Password = StaticFunc.ComputeSha256Hash(code);
                    Db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool Add()
        {
            try
            {
                using(MyContext Db = new MyContext())
                {
                    if(Db.Users.Any(p => p.Email == Email))
                    {
                        return false;
                    }
                }

                string code = StaticFunc.GenerateRandomString(8);
                if (!StaticFunc.SendEmail(Email, "Password code", code))
                {
                    return false;
                }

                Password = StaticFunc.ComputeSha256Hash(code);
                using (MyContext Db = new MyContext())
                {
                    Db.Users.Add(this);
                    Db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool Update()
        {
            try
            {
                using (MyContext Db = new MyContext())
                {
                    Db.Users.Update(this);
                    Db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public User Login()
        {
            using (MyContext Db = new MyContext())
            {
                return Db.Users.FirstOrDefault(p => p.Email == Email && p.Password == StaticFunc.ComputeSha256Hash(Password));
            }
        }
        public bool ChangePassword(string oldPass, string newPass, string newPassAgain)
        {
            if(newPass != newPassAgain)
            {
                return false;
            }

            if (!StaticFunc.CheckPassword(newPass))
            {
                return false;
            }

            try
            {
                using (MyContext Db = new MyContext())
                {
                    User user = Db.Users.FirstOrDefault(p => p.UserId == UserId);
                    if (StaticFunc.ComputeSha256Hash(oldPass) != user.Password)
                    {
                        return false;
                    }
                    user.Password = StaticFunc.ComputeSha256Hash(newPass);
                    Db.SaveChanges();
                    return true;
                }
            }
            catch
            {

                return false;
            }
        }
    }
}
