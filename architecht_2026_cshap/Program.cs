namespace Architecht
{
    class Program
    {
        // Main metodu, programın başlangıç noktasıdır.
        static void Main(string[] args)
        {
            
            // Tek satırlı yorum satırı
            /*
             * Çok satırlı yorum bloğu
             * Bu blok içerisinde birden fazla satırda yorum yapabilirsiniz.
            */

            // Değişken tanımlama ve atama
            // string değişkeni, metin verilerini saklamak için kullanılır.
            string name = "Ali";
            string surname = "Bilmem";
            Console.WriteLine("Ad: " + name + ", Soyad: " + surname);

            // int değişkeni, tam sayıları saklamak için kullanılır.
            int age = 30;
            Console.WriteLine("Yaş: " + age);

            // double değişkeni, ondalık sayıları saklamak için kullanılır.
            double height = 1.75;
            Console.WriteLine("Boy: " + height);

            // bool değişkeni, doğru veya yanlış değerlerini saklamak için kullanılır.
            bool isStudent = true;
            Console.WriteLine("Öğrenci mi? " + isStudent);

            // Mantıksal operatörler
            // > büyüktür, < küçüktür, == eşittir, != eşit değildir
            bool status = age > 18; // age 18'den büyük mü?
            Console.WriteLine("18'den büyük mü? " + status);
            status = age < 18; // age 18'den küçük mü?
            Console.WriteLine("18'den küçük mü? " + status);
            status = age == 30; // age 30'a eşit mi?
            Console.WriteLine("Yaş 30'a eşit mi? " + status);
            status = age != 30; // age 30'a eşit değil mi?
            Console.WriteLine("Yaş 30'a eşit değil mi? " + status);

            // yemek siparişi alma örneği
            // yemek stokta var mı kontrolü
            // kurye dahil fiyat üst limit aşıldı mı kontrolü
            // ödeme yöntemi geçerli mi kontrolü
            // kumbardan mı ödenecek diğer ödeme yöntemleri mi kontrolü
            // sipariş onaylandı mı kontrolü
            // işletme bu siparişi onayladı mı kontrolü
            // sipariş hazırlanıyor mu kontrolü
            // kurye yola çıktı mı kontrolü
            // sipariş teslim edildi mi kontrolü

            // karar kontrol yapıları
            // if-else yapısı
            if (age >= 18)
            {
                Console.WriteLine("Reşitsiniz.");
            }
            else
            {
                Console.WriteLine("Reşit değilsiniz.");
            }

            // kullanıcı adı ve şifre alarak kontrolü
            Console.WriteLine("Kullanıcı Adı: ");
            // string username = Console.ReadLine();
            string username = "admin";
            Console.WriteLine("Şifre: ");
            // string password = Console.ReadLine();
            string password = "1234";
            if ((username == "admin" || username == "user") && password == "1234")
            {
                Console.WriteLine("Giriş başarılı!");
            }
            else
            {
                Console.WriteLine("Giriş başarısız! Kullanıcı adı veya şifre yanlış.");
            }

            // || örneği
            int price = 50;
            if (price > 100 || isStudent)
            {
                Console.WriteLine("İndirim uygulanır.");
            }
            else
            {
                Console.WriteLine("İndirim uygulanmaz.");
            }

            // şehirler
            string[] cities = { "İstanbul", "Ankara", "İzmir", "Bursa", "Adana" };

            int index = 3;
            int count = cities.Length;
            if (index >= 0 && index < count)
            {
                // index ile erişim, index değerleri 0'dan başlar
                Console.WriteLine("İlk şehir: " + cities[index]);
            }

            // dizideki elemanların sayısı
            Console.WriteLine("Toplam şehir sayısı: " + count);

            // döngüler
            // for döngüsü
            for(int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine("Cities Item: " + cities[i]);
            }
            Console.WriteLine("================================");
            
            // foreach döngüsü
            foreach (string item in cities)
            {
                Console.WriteLine("foreach Item: " + item);
            }

            Console.WriteLine("================================");
            // while döngüsü
            int j = 0;
            while (j < cities.Length)
            {
                Console.WriteLine("while Item: " + cities[j]);
                j++;
            }

            Console.WriteLine("================================");
            // break ve continue
            for (int i = 0; i < 100; i++)
            {
                if (i == 3)
                {
                    continue; // bu iterasyonu atlar, sonraki iterasyona geçer
                } 
                if (i == 10)
                {
                    Console.WriteLine("10 bulundu");
                    break; // döngüyü sonlandırır
                }
                Console.WriteLine("i: " + i);
            }

            Console.WriteLine("================================");
            // 3,4,77,98 sayıları hariç 0-100 arasındaki sayıları yazdıran döngü
            int[] excludedNumbers = { 3, 4, 77, 98, 44 };
            for (int i = 0; i < 100; i++)
            {
                for(int x = 0; x < excludedNumbers.Length; x++)
                {
                    if (i == excludedNumbers[x])
                    {
                        goto Skip; // bu sayıyı atlar, sonraki iterasyona geçer
                    }
                }
                Console.WriteLine("for : " + i);
            Skip:
                continue;
            }

            Console.WriteLine("================================");
            // Nesne Üretimi
            // User -> class adı
            // objUser -> nesne
            // new() -> bellekte hazır hale getir, kullanıma uygun
            User objUser = new();
            bool loginStatus1 = objUser.Login("zehra@mail.com", "54321");
            Console.WriteLine("Zehra Login: " + loginStatus1);

            loginStatus1 = objUser.Login("mehmet@mail.com", "2222");
            Console.WriteLine("Mehmet Login: " + loginStatus1);

            bool registerStatus = objUser.Register("Erkan", "erkan@mail.com", "12345");
            Console.WriteLine("Register :" + registerStatus);

            object objCall = objUser.Call();
            // tür tespiti
            if (objCall is int)
            {
                int convertedValue = (int)objCall; // tür dönüşümü
                int sum = convertedValue + 50;
                Console.WriteLine("Call methodundan dönen değer + 50: " + sum);
            }

            // tür dönüşümü
            string ageString = "25";
            int ageConverted = int.Parse(ageString);
            Console.WriteLine("Yaş: " + ageConverted);

            string heightString = "1,80";
            double heightConverted = double.Parse(heightString);
            Console.WriteLine("Boy: " + heightConverted);

            bool isStudentConverted = bool.Parse("true");
            Console.WriteLine("Öğrenci mi? " + isStudentConverted);

            // Propery - get ve set
            UserModel zehraModel = objUser.Profile();
            Console.WriteLine("Zehra'nın Profili:");
            Console.WriteLine("ID: " + zehraModel.Id);
            Console.WriteLine("Name: " + zehraModel.Name);
            Console.WriteLine("Surname: " + zehraModel.Surname);
            Console.WriteLine("Email: " + zehraModel.Email);
            Console.WriteLine("Password: " + zehraModel.Password);
            Console.WriteLine("Age: " + zehraModel.Age);

            // userModel dizisi oluşturup içerisine 3 farklı kullanıcı ekleyelim
            // aliModel
            UserModel aliModel = new();
            aliModel.Id = 2;
            aliModel.Name = "Ali";
            aliModel.Surname = "Bilmem";
            aliModel.Email = "ali@mail.com";
            aliModel.Password = "12345";
            aliModel.Age = 30;

            // mehmetModel
            UserModel mehmetModel = new();
            mehmetModel.Id = 3;
            mehmetModel.Name = "Mehmet";
            mehmetModel.Surname = "Yılmaz";
            mehmetModel.Email = "mehmet@mail.com";
            mehmetModel.Password = "22222";
            mehmetModel.Age = 28;

            Console.WriteLine("==============================");
            UserModel[] users = { zehraModel, aliModel, mehmetModel };

            // Başlık
            Console.WriteLine(
                "{0,-5} {1,-15} {2,-15} {3,-25} {4,-15} {5,-5}",
                "ID", "Name", "Surname", "Email", "Password", "Age"
            );
            Console.WriteLine(new string('-', 90));
            // Veriler
            foreach (var item in users)
            {
                Console.WriteLine(
                    "{0,-5} {1,-15} {2,-15} {3,-25} {4,-15} {5,-5}",
                    item.Id,
                    item.Name,
                    item.Surname,
                    item.Email,
                    item.Password,
                    item.Age
                );
            }

            Console.WriteLine(new string('-', 90));
            Action action = new();
            action.Execute();

            // Hata denetimi - istisna
            // Dış dünya ile yazılımın iletişim halinde olduğu alanlarda ortaya çıkar.
            // kullanıcıdan veri alma, veri tabanı bağlantısı, dosya okuma, socket okuma gibi..
            int size = 10;
            try
            {
                // hata olma olasılığı olan kod parçaları buraya yazılır.
                Console.WriteLine("Boyunuz (cm) ?");
                double xx = double.Parse(Console.ReadLine() ?? "0");
                Console.WriteLine("Kilonuz (kg) ?");
                double yy = double.Parse(Console.ReadLine() ?? "0");

                double end = xx / yy ;
                Console.WriteLine("Sonuç :" + end);
            }
            catch (Exception ex)
            {
                // hata olduğu durumlarda çalışan gövde
                Console.WriteLine("Lütfen 0 dan büyük bir değer giriniz!, " + ex.Message);
            }finally
            {
                size = 0;
            }
            
            Console.WriteLine("Size : " + size);
            Console.WriteLine("This line call");
        }
    }
}