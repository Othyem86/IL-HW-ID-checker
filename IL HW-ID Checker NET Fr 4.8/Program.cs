using IntelliLock.Licensing;
using System;

namespace IL_HW_ID_Checker_NET_Fr_4._8;

internal class Program
{
    private static void Main(string[] _)
    {
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

        var biosHwId = HardwareID.GetHardwareID(
            CPU:       false,
            HDD:       false,
            MAC:       false,
            Mainboard: false,
            BIOS:      true,
            OS:        false);

        var osHwId = HardwareID.GetHardwareID(
            CPU:       false,
            HDD:       false,
            MAC:       false,
            Mainboard: false,
            BIOS:      false,
            OS:        true);

        var fullHwId = HardwareID.GetHardwareID(
            CPU:       true,
            HDD:       true,
            MAC:       true,
            Mainboard: true,
            BIOS:      true,
            OS:        true);

        Console.WriteLine("=== HARDWARE IDs ===");
        Console.WriteLine();
        Console.WriteLine($"CPU:        {cpuHwId}");
        Console.WriteLine($"HDD:        {hddHwId}");
        Console.WriteLine($"MAC:        {macHwId}");
        Console.WriteLine($"Mainboard:  {maiboardHwId}");
        Console.WriteLine($"BIOS:       {biosHwId}");
        Console.WriteLine($"OS:         {osHwId}");
        Console.WriteLine($"FULL:       {fullHwId}");

        Console.WriteLine("Taste drücken um Programm zu beenden");
        Console.ReadLine();
    }
}