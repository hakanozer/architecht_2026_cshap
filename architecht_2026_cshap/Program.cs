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

        }
    }
}