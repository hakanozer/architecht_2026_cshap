using System.Collections.Generic;

namespace Architecht
{
    public class Action
    {
        public int userAge = 30;
        public static string userName = "Ali Bilmem";
        
        public void Execute()
        {
            
            List<string> ls = new();

            // eleman ekleme - Add
            ls.Add("Ali");
            ls.Add("Zehra");
            ls.Add("Ayşe");
            ls.Add("Mehmet");
            ls.Add("Ahmet");
            ls.Add("Kemal");
            ls.Add("Selin");

            for (;;)
            {
                Console.WriteLine("Kullanıcı Giriniz, (Kapat 'e')");
                string data = Console.ReadLine() ?? "e";
                if (data.ToLower().Equals("e"))
                {
                    break;
                }
                ls.Add(data);
            }

            // insert - belirli bir indexe eleman ekleme
            ls.Insert(2, "Deniz");

            // eleman silme - Remove
            // ls.Remove("Ahmet"); // değere göre silme
            // ls.RemoveAt(4); // indexe göre silme

            // tek değeri yazdırma
            Console.WriteLine("Index 3'teki eleman: " + ls[3]);

            // loop ile tüm elemanları yazdırma
            Console.WriteLine("Listedeki elemanlar:");
            foreach (var item in ls)            {
                Console.WriteLine(item);
            }

            // listedeki eleman sayısı
            Console.WriteLine("Listedeki eleman sayısı: " + ls.Count);

            // eleman değeri güncelleme
            ls[1] = "Sultan";
            ls.Add("Zeynep");

            // değere göre index bulma
            int indexOfDeniz = ls.IndexOf("Deniz");
            Console.WriteLine("Deniz'in indexi: " + indexOfDeniz);

            // sort - sıralama
            ls.Sort();
            // sort - ters sıralama
            // ls.Reverse();

            // filter - belirli bir kritere göre elemanları alma
            List<string> filterList = ls.Where(item => item.ToLower().Contains("a")).ToList();
            Console.WriteLine("a harfi içeren elemanlar: " + string.Join(", ", filterList));

            Console.WriteLine("Listedeki elemanlar: " + string.Join(", ", ls));

            List<UserModel> userList = new();

            UserModel user1 = new() { Id = 1, Name = "Ali", Surname = "Veli", Email = "ali@example.com", Password = "12345", Age = 30 };
            UserModel user2 = new() { Id = 2, Name = "Zehra", Surname = "Yılmaz", Email = "zehra@example.com", Password = "67890", Age = 25 };
            UserModel user3 = new() { Id = 3, Name = "Mehmet", Surname = "Demir", Email = "mehmet@example.com", Password = "54321", Age = 28 };

            userList.Add(user1);
            userList.Add(user2);
            userList.Add(user3);

            List<UserModel> filteredUsers = userList.Where(user => user.Age > 26).ToList();
            Console.WriteLine("Yaşı 26'dan büyük olan kullanıcılar:");
            foreach (var user in filteredUsers)
            {
                Console.WriteLine(user);
            }
            
            Console.WriteLine("JWT Secret Key: " + Const.jwtSecretKey);

        }

    }
}
