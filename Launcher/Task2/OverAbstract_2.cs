// Избыточное создание абстракций
namespace DesignPatternsLab.Launcher.Task2
{
public interface IShape
{
    double CalculateArea();
}

public class Circle : IShape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }
    public double CalculateArea()
    {
        return Math.PI * _radius * _radius;
    }
}

public class Square : IShape
{
    private double _side;

    public Square(double side)
    {
        _side = side;

    }
    public double CalculateArea()
    {
        return _side * _side;
    }
} // Не знаю, я бы оставил как есть ибо потом расширять легко. А так, если что убрать нтерфейс и сделать обычные методы
}