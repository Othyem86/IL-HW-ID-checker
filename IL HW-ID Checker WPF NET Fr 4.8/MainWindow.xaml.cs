using IntelliLock.Licensing;
using System.Text;

namespace IL_HW_ID_Checker_WPF_NET_Fr_4._8;

public partial class MainWindow
{
    public MainWindow()
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

        InitializeComponent();

        var sb = new StringBuilder();

        sb.AppendLine("=== HARDWARE IDs .NET Framework 4.8 ===");
        sb.AppendLine();
        sb.AppendLine($"BIOS:               {biosHwId}");
        sb.AppendLine($"CPU:                {cpuHwId}");
        sb.AppendLine($"HDD:                {hddHwId}");
        sb.AppendLine($"MAC:                {macHwId}");
        sb.AppendLine($"Mainboard:          {maiboardHwId}");
        sb.AppendLine($"OS:                 {osHwId}");

        sb.AppendLine();
        sb.AppendLine($"CPU/Mainboard:      {cpuMainboardHwId}");
        sb.AppendLine($"FULL:               {fullHwId}");

        var licenseStatus = GetLicenseStatus(EvaluationMonitor.CurrentLicense.LicenseStatus);
        var licenseStatusHdd = GetLicenseStatus(EvaluationMonitor.CurrentLicense.LicenseStatus_HDD);

        sb.AppendLine();
        sb.AppendLine($"License Status:     {licenseStatus}");
        sb.AppendLine($"License Status HDD: {licenseStatusHdd}");

        HwIdsTextBox.Text = sb.ToString();
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