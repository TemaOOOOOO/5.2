// Підклас Nintendo Switch

class NintendoSwitch : Gadjet
{
	public NintendoSwitch(double price) : base(price) { }

	public override void Reboot()
	{
		Console.WriteLine("Nintendo Switch is rebooting...");
	}
}