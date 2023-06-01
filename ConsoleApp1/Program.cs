// Toshiba B-EX4T2 barkod yazıcının seri bağlantı ayarları
using System.IO.Ports;

string portName = "COM1";  // Yazıcının bağlı olduğu seri port adı
int baudRate = 9600;      // Bağlantı hızı
Parity parity = Parity.None;  // Parite ayarı
int dataBits = 8;         // Veri bitleri
StopBits stopBits = StopBits.One;  // Durma bitleri

// Seri port bağlantısını oluştur
SerialPort serialPort = new SerialPort(portName, baudRate, parity, dataBits, stopBits);

try
{
    // Seri portu aç
    serialPort.Open();

    // Barkod verisi
    string barcodeData = "1234567890";  // Yazdırılacak barkod verisi

    // Barkod yazıcıya komut gönder
    string command = string.Format("~SD30\r\n~DG000.GRF,{0}\r\nPR\r\n", barcodeData.Length);
    serialPort.Write(command);

    // Barkod verisini yazdırma komutu
    string printCommand = string.Format("~DGE:000,G,{0},{0},{1}\r\n", barcodeData.Length, barcodeData);
    serialPort.Write(printCommand);
}
catch (Exception ex)
{
    Console.WriteLine("Hata oluştu: " + ex.Message);
}
finally
{
    // Seri portu kapat
    serialPort.Close();
}

Console.WriteLine("Barkod yazdırma tamamlandı.");
Console.ReadLine();