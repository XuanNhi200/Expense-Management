using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Expense_Management.Controllers
{
    public class User
    {
        /// <summary>
        /// Kiểm tra tên đăng nhập và mật khẩu xem có hợp lệ hay không
        /// <returns>Trả về user nếu hợp lệ, ngược lại trả về null</returns>
        public static User CheckLogin(string Fullname, string Password)
        {
            Expense_ManagementContext db = new Expense_ManagementContext();
            foreach (User user in db.users)
            {
                if (user.Fullname == Fullname && user.Password == Password)
                    return user ;
            }

            return null;
        }
        public static bool CheckExist(string Fullname)
        {
            Expense_ManagementContext db = new Expense_ManagementContext();
            try
            {
                User user = db.users.Single(r => r.Fullname == Fullname);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public static User CreateUser(string Fullname, string Password, string Email)
        {
            if (CheckExist(Fullname))
                return null;

            Expense_ManagementContext db = new Expense_ManagementContext();
            User user = new User();
            user.Fullname = Fullname;
            user.Password = Password;
            user.Email = Email;
            db.users.InsertOnSubmit(user);

            db.SubmitChanges();

            return user;
        }
    }
}