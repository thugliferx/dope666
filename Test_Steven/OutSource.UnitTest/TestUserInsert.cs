using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutSource.EF;

namespace OutSource.UnitTest
{
    [TestClass]
    public class TestUserInsert
    {
        [TestMethod]
        public void Test_User_Data_Insert()
        {
            Users user = new Users();
            user.Address = "台北市中山區";
            user.Name = "黃小名";
            user.Email = "cc@bino.com";
            user.CellPhone = "0912123123";
            user.CreateTime = DateTime.Now;
            user.UpdateTime = DateTime.Now;

            using (var db = new OUT_SOURCE_DBEntities())
            {
                db.Users.Add(user);
                db.SaveChanges();

            }

            using (var db = new OUT_SOURCE_DBEntities())
            {
                user.Name = "黃大名";
                db.Users.Add(user);
                db.SaveChanges();
            }


        }

        [TestMethod]
        public void Select_User()
        {
            using (var db = new OUT_SOURCE_DBEntities())
            {
                var users = db.Users;
                foreach (var u in users)
                {
                    Console.WriteLine(u.Name);
                }
            }
        }

        [TestMethod]
        public void Select_User_Where()
        {
            using (var db = new OUT_SOURCE_DBEntities())
            {
                var users = db.Users.Where(u => u.Id == 1).Single();

                Console.WriteLine(users.Id);
                Console.WriteLine(users.Name);
                Console.WriteLine(users.UpdateTime);
            }
        }
    }

    internal class Customer : IDisposable
    {

        private string name = "";

        public void Dispose()
        {
            name = null;
        }
    }
}
