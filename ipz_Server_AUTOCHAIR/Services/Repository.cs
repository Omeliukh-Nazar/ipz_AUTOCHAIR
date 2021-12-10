using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ipz_Server_AUTOCHAIR.Models;

namespace ipz_Server_AUTOCHAIR
{
    public class Repository
    {
        public static ShopContext db = new ShopContext();
        public static User GetUserById(int Id)
        {
            return db.Users.Find(Id);
        }
        public static string CheckUser(User user)
        {
            if (db.Users.Where(x => x.Email == user.Email).Any())
            {
                return "Error : Email already registered";
            }
            if (db.Users.Where(x => x.Phone == user.Phone).Any())
            {
                return "Error : Phone already registered";
            }
            if (db.Users.Where(x => x.Login == user.Login).Any())
            {
                return "Error : Login already registered";
            }
            return "Correct";

        }
        public static void AddUser(User user)
        {

            db.Users.Add(user);
            db.SaveChangesAsync();

        }

        public static int CheckLogin(User user)
        {
            if (!db.Users.Where(x => x.Login == user.Login && x.Password == user.Password).Any())
            {
                return -1;
            }
            return db.Users.Where(x => x.Login == user.Login).First().Id;
        }

        public static void AddChair(Chair chair)
        {
            db.Chairs.Add(chair);
            db.SaveChangesAsync();
        }

        internal static IEnumerable<Chair> GetAllChairs()
        {
            return db.Chairs;
        }

        internal static void AddOrders(List<Order> orders)
        {
            foreach (var item in orders)
            {
                Order order = new Order
                {
                    UserId = item.UserId,
                    ChairId = db.Chairs.Where(x => x.Name == item.Chair.Name).FirstOrDefault().Id,
                    Count = item.Count,
                    Prise = item.Prise * item.Count
                };
                db.Orders.Add(order);
                db.SaveChanges();
            }
        }

        internal static List<Order> GerOdersById(int id)
        {
            return db.Orders.Where(x => x.UserId == id).ToList();
        }
    }
}
