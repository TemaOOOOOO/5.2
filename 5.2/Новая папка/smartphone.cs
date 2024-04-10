// Підклас Смартфон
class Smartphone : Gadjet
{
	public Smartphone(double price) : base(price) { }

	public override void Reboot()
	{
		Console.WriteLine("Smartphone is rebooting...");
	}
}