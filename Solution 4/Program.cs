namespace Solution_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDrawable[] IDD = new IDrawable[3];//создание массива интерфейсов IDrawable
            //заполнение массива объектами
            IDD[0] = new Circle(19);
            IDD[1] = new Rectangle(10, 20);
            IDD[2] = new Triangle(8, 32, 11);
            //Вызываем метод Draw() для каждого объекта в массиве
            for (int i = 0; i < 3; i++)
            {
                IDD[i].Draw();
            }
        }
    }
}
