using IntelliLock.Licensing;

namespace IL_HW_ID_Checker_NET8;

internal class Program
{
    private static void Main(string[] _)
    {
        var biosHwId = HardwareID.GetHardwareID(
            CPU:       false,
            HDD:       false,
            MAC:       false,
            Mainboard: false,
            BIOS:      true,
            OS:        false);

        var cpuHwId = HardwareID.GetHardwareID(
            CPU:       true,
            HDD:       false,
            MAC:       false,
            Mainboard: false,
            BIOS:      false,
            OS:        false);

        var hddHwId = HardwareID.GetHardwareID(
            CPU:       false,
            HDD:       true,
            MAC:       false,
            Mainboard: false,
            BIOS:      false,
            OS:        false);

        var macHwId = HardwareID.GetHardwareID(
            CPU:       false,
            HDD:       false,
            MAC:       true,
            Mainboard: false,
            BIOS:      false,
            OS:        false);

        var maiboardHwId = HardwareID.GetHardwareID(
            CPU:       false,
            HDD:       false,
            MAC:       false,
            Mainboard: true,
            BIOS:      false,
            OS:        false);

        var osHwId = HardwareID.GetHardwareID(
            CPU:       false,
            HDD:       false,
            MAC:       false,
            Mainboard: false,
            BIOS:      false,
            OS:        true);

        var cpuMainboardHwId = HardwareID.GetHardwareID(
            CPU:       true,
            HDD:       false,
            MAC:       false,
            Mainboard: true,
            BIOS:      false,
            OS:        false);

        var fullHwId = HardwareID.GetHardwareID(
            CPU:       true,
            HDD:       true,
            MAC:       true,
            Mainboard: true,
            BIOS:      true,
            OS:        true);

        Console.WriteLine("=== HARDWARE IDs ===");
        Console.WriteLine();
        Console.WriteLine($"BIOS:           {biosHwId}");
        Console.WriteLine($"CPU:            {cpuHwId}");
        Console.WriteLine($"HDD:            {hddHwId}");
        Console.WriteLine($"MAC:            {macHwId}");
        Console.WriteLine($"Mainboard:      {maiboardHwId}");
        Console.WriteLine($"OS:             {osHwId}");
        
        Console.WriteLine();
        Console.WriteLine($"CPU/Mainboard:  {cpuMainboardHwId}");
        Console.WriteLine($"FULL:           {fullHwId}");

        Console.WriteLine("Press any key to end the program...");
        Console.ReadLine();
    }
}