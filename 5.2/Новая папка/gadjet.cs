// ��������� ������

abstract class Gadjet
{
    
    protected double price { get; }

    public Gadjet(double price)
    {
        this.price = price;
    }

    // ������� ���������������� �������
    public abstract void Reboot();
}
