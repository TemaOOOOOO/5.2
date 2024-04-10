// Підклас Комп'ютер

class Computer : Gadjet
{
	public Computer(double price) : base(price) { }

	public override void Reboot()
	{
		Console.WriteLine("Computer is rebooting...");
	}
	
	public void ConnectPeripheral()
	{
		Console.WriteLine("Peripheral is connected to the computer.");
	}

	public void DisconnectPeripheral()
	{
		Console.WriteLine("Peripheral is disconnected from the computer.");
	}
}