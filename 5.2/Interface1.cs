using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Інтерфейс, що описує функціонал підключення/відключення комплектуючих
interface IPeripheralConnection
{
    void ConnectPeripheral();
    void DisconnectPeripheral();
}
