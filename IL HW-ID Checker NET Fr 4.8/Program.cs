using IntelliLock.Licensing;
using System;
using System.ComponentModel;

namespace IL_HW_ID_Checker_NET_Fr_4._8;

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

        Console.WriteLine("=== HARDWARE IDs .NET Framework 4.8 ===");
        Console.WriteLine();
        Console.WriteLine($"BIOS:               {biosHwId}");
        Console.WriteLine($"CPU:                {cpuHwId}");
        Console.WriteLine($"HDD:                {hddHwId}");
        Console.WriteLine($"MAC:                {macHwId}");
        Console.WriteLine($"Mainboard:          {maiboardHwId}");
        Console.WriteLine($"OS:                 {osHwId}");

        Console.WriteLine();
        Console.WriteLine($"CPU/Mainboard:      {cpuMainboardHwId}");
        Console.WriteLine($"FULL:               {fullHwId}");

        var licenseStatus = GetLicenseStatus(EvaluationMonitor.CurrentLicense.LicenseStatus);
        var licenseStatusHdd = GetLicenseStatus(EvaluationMonitor.CurrentLicense.LicenseStatus_HDD);

        Console.WriteLine();
        Console.WriteLine($"License Status:     {licenseStatus}");
        Console.WriteLine($"License Status HDD: {licenseStatusHdd}");

        Console.WriteLine("Press any key to end the program...");
        Console.ReadLine();
    }

    private static string GetLicenseStatus(LicenseStatus status)
    {
        return status switch
        {
            LicenseStatus.NotChecked => "NotChecked",
            LicenseStatus.Licensed => "Licensed",
            LicenseStatus.EvaluationMode => "EvaluationMode",
            LicenseStatus.EvaluationExpired => "EvaluationExpired",
            LicenseStatus.LicenseFileNotFound => "LicenseFileNotFound",
            LicenseStatus.HardwareNotMatched => "HardwareNotMatched",
            LicenseStatus.InvalidSignature => "InvalidSignature",
            LicenseStatus.ServerValidationFailed => "ServerValidationFailed",
            LicenseStatus.Deactivated => "Deactivated",
            LicenseStatus.Reactivated => "Reactivated",
            LicenseStatus.FloatingLicenseUserExceeded => "FloatingLicenseUserExceeded",
            LicenseStatus.FloatingLicenseServerError => "FloatingLicenseServerError",
            LicenseStatus.FullVersionExpired => "FullVersionExpired",
            LicenseStatus.FloatingLicenseServerTimeout => "FloatingLicenseServerTimeout",
            _ => "INVALID LICENSE STATUS"
        };
    }
}