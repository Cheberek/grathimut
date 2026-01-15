namespace Grathimut;

public static class Weather //Класс с методами для управления погодой с помощью консольной графики.
{
    public static void Rain(int Quantity = 10) //Rain - метод для отисовки дождя. Quantity - количество капель. 
    { 
        Drop[] Drops = new Drop[Quantity]; //Создаём пулл объектов. Для начала объявляем массив.
        int Lenght = Drops.Length; //Чтобы каждый раз не вызывать Drops.Lenght, тем самым загружая систему.
        for(int i = 0; i < Lenght; i++) //Заполняем массив (пулл объектов) объектами.
        {
            Drops[i] = new Drop();
        }
    }
    class Drop() //Класс для отрисовки одной капли. Каждая капля - отдельный объект.
    {
        
    }
}
