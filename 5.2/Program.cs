using System;

class Program
{
    static void Main(string[] args)
    {
        // Приклад використання
        Computer pc = new Computer(1000);
        Laptop laptop = new Laptop(1200);
        Desktop desktop = new Desktop(800);
        NintendoSwitch switchConsole = new NintendoSwitch(300);
        Smartphone phone = new Smartphone(600);
        IPhone iPhone = new IPhone(1000);
        GooglePixel7 pixel = new GooglePixel7(800);



        pc.ConnectPeripheral();
        pc.DisconnectPeripheral();
        pc.Reboot();
        laptop.Reboot();
        desktop.Reboot();
        switchConsole.Reboot();
        phone.Reboot();
        iPhone.Reboot();
        pixel.Reboot();
    }
}

