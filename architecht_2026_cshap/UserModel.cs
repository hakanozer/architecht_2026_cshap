namespace Architecht
{
    class UserModel
    {
        // id, name, surname, email, password, age
        // get - set yapısı
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Surname { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
        public int Age { get; set; }

        // toString override
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Surname: {Surname}, Email: {Email}, Password: {Password}, Age: {Age}";
        }

    }
}