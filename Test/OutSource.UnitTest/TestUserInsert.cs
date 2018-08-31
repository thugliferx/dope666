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

        }
    }
}
