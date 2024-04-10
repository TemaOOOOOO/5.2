// Суперклас Гаджет

abstract class Gadjet
{
    
    protected double price { get; }

    public Gadjet(double price)
    {
        this.price = price;
    }

    // Функція перезавантаження гаджета
    public abstract void Reboot();
}
