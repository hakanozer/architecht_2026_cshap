namespace Architecht
{
    class User
    {
        // global değişken / dizi
        string[] userNames = { "ali@mail.com", "zehra@mail.com", "ayse@mail.com", "mehmet@mail.com" };
        string[] passwords = { "12345", "54321", "11111", "22222" };
        
        // class olmadan method / fonksiyon tanımlanamaz
        // single responsibility principle - tek sorumluluk prensibi

        // fonksiyon tanımlama
        // erişim belirleyici, geri dönüş tipi, fonksiyon adı, (parametre listesi)

        // public -> erişim belirleyici, her yerden görün
        // void, return türü -> void ise birşey geriye dönmüyor, bir tür varsa o türe ait değer döner.
        public bool Login(string userName, string password)
        {
            for (int i = 0; i < userNames.Length; i++)
            {
                if (userName == userNames[i] && password == passwords[i])
                {
                    return true;
                }
            }
            return false;
        }

        public bool Register(string name, string userName, string password)
        {
            for (int i = 0; i < userNames.Length; i++)
            {
                if (userName == userNames[i])
                {
                    return false;
                }
            }
            Console.WriteLine("Kayıt Başarılı: " + name + " " + userName + " " + password);
            return true;
        }

    }
}