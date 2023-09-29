namespace Solution_1
{
    internal class Person
    {
        private string name;//переменная для хранения имени
        private int age;//переменная для хранения возраста
        private string address;//переменная для хранения адреса
        public void SetName(string name = "")//метод для изменения имени
        {
            this.name = name;
        }
        public void SetAge(int age = 0)//метод для изменения возраста
        {
            this.age = age;
        }
        public void SetAddress(string address = "-")//метод для изменения адреса
        {
            this.address = address;
        }
        public string GetName()//метод для вывода имени
        {
            return this.name;
        }
        public int GetAge()//метод для вывода возраста
        {
            return this.age;
        }
        public string GetAddress()//метод для вывода адреса
        {
            return this.address;
        }
    }
}
