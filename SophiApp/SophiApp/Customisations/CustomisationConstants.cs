﻿using SophiApp.Helpers;
using System;
using System.Collections.Generic;

namespace SophiApp.Customisations
{
    internal static class CustomisationConstants
    {
        internal const int _10_SECONDS_TIMEOUT = 10000;
        internal const string _100_DIAG_TRACK = "DiagTrack";
        internal const string _104_CORE = "Core";
        internal const byte _104_DISABLED_DEFAULT_VALUE = 1;
        internal const string _104_QUEUE_TASK = "QueueReporting";
        internal const string _104_QUEUE_TASK_PATH = @"Microsoft\Windows\Windows Error Reporting";
        internal const string _104_WER_PATH = @"SOFTWARE\Microsoft\Windows\Windows Error Reporting";
        internal const string _104_WER_SERVICE = "WerSvc";
        internal const string _109_DATA_UPDATER_TASK = "ProgramDataUpdater";
        internal const string _109_DATA_UPDATER_TASK_PATH = @"Microsoft\Windows\Application Experience";
        internal const string _110_PROXY_TASK = "Proxy";
        internal const string _110_PROXY_TASK_PATH = @"Microsoft\Windows\Autochk";
        internal const string _111_CONS_TASK = "Consolidator";
        internal const string _112_USB_CEIP_TASK = "UsbCeip";
        internal const string _113_DISK_DATA_TASK = "Microsoft-Windows-DiskDiagnosticDataCollector";
        internal const string _113_DISK_DATA_TASK_PATH = @"Microsoft\Windows\DiskDiagnostic";
        internal const string _114_MAPS_TOAST_TASK = "MapsToastTask";
        internal const string _115_MAPS_UPDATE = "MapsUpdateTask";
        internal const string _116_FAMILY_MONITOR_TASK = "FamilySafetyMonitor";
        internal const string _116_FAMILY_MONITOR_TASK_PATH = @"Microsoft\Windows\Shell";
        internal const string _117_XBOX_SAVE_TASK = "XblGameSaveTask";
        internal const string _117_XBOX_SAVE_TASK_PATH = @"Microsoft\XblGameSave";
        internal const string _118_OPT_OUT = "OptOut";
        internal const byte _118_OPT_OUT_DEFAULT_VALUE = 1;
        internal const string _118_USER_ARSO_PATH = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon\UserARSO";
        internal const string _119_HTTP_ACCEPT = "HttpAcceptLanguageOptOut";
        internal const byte _119_HTTP_ACCEPT_DEFAULT_VALUE = 1;
        internal const string _119_USER_PROFILE_PATH = @"Control Panel\International\User Profile";
        internal const string _120_ADVERT_INFO_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\AdvertisingInfo";
        internal const string _121_SUB_CONTENT = "SubscribedContent-310093Enabled";
        internal const string _122_SUB_CONTENT = "SubscribedContent-338389Enabled";
        internal const string _123_SUB_CONTENT_93 = "SubscribedContent-338393Enabled";
        internal const string _123_SUB_CONTENT_94 = "SubscribedContent-353694Enabled";
        internal const string _123_SUB_CONTENT_96 = "SubscribedContent-353696Enabled";
        internal const string _124_SILENT_APP_INSTALL = "SilentInstalledAppsEnabled";
        internal const string _125_PROFILE_ENGAGE_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\UserProfileEngagement";
        internal const string _125_SETTING_ENABLED = "ScoobeSystemSettingEnabled";
        internal const string _126_PRIVACY_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Privacy";
        internal const string _126_TAILORED_DATA = "TailoredExperiencesWithDiagnosticDataEnabled";
        internal const string _127_DISABLE_SEARCH_SUGGESTIONS = "DisableSearchBoxSuggestions";
        internal const string _203_AUTO_CHECK_SELECT = "AutoCheckSelect";
        internal const byte _204_DISABLED_VALUE = 2;
        internal const byte _204_ENABLED_VALUE = 1;
        internal const string _204_HIDDEN = "Hidden";
        internal const string _205_HIDE_FILE_EXT = "HideFileExt";
        internal const byte _205_HIDE_VALUE = 1;
        internal const byte _205_SHOW_VALUE = 0;
        internal const string _206_HIDE_MERGE_CONF = "HideMergeConflicts";
        internal const string _210_CORTANA_BUTTON = "ShowCortanaButton";
        internal const string _211_SHOW_SYNC_PROVIDER = "ShowSyncProviderNotifications";
        internal const string _212_SNAP_ASSIST = "SnapAssist";
        internal const byte _216_EXPANDED_VALUE = 0;
        internal const byte _216_MINIMIZED_VALUE = 1;
        internal const string _216_RIBBON_EXPLORER_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Ribbon";
        internal const string _216_TABLET_MODE_OFF = "MinimizedStateTabletModeOff";
        internal const byte _217_SHELL_DISABLED_VALUE = 55;
        internal const byte _217_SHELL_ENABLED_VALUE = 51;
        internal const string _217_SHELL_STATE = "ShellState";
        internal const string _218_3D_OBJECT_HIDE_VALUE = "Hide";
        internal const string _218_3D_OBJECT_PROPERTY_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{31C0DD25-9439-4F12-BF41-7FF4EDA38722}\PropertyBag";
        internal const string _218_PC_POLICY = "ThisPCPolicy";
        internal const string _219_SHOW_RECENT = "ShowRecent";
        internal const string _220_SHOW_FREQUENT = "ShowFrequent";
        internal const string _221_SHOW_TASK_VIEW = "ShowTaskViewButton";
        internal const string _222_PEOPLE_BAND = "PeopleBand";
        internal const string _222_PEOPLE_EXPLORER_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\People";
        internal const string _223_SHOW_SECONDS = "ShowSecondsInSystemClock";
        internal const string _228_PEN_WORKSPACE_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\PenWorkspace";
        internal const string _228_PEN_WORKSPACE_VISIBILITY = "PenWorkspaceButtonDesiredVisibility";
        internal const string _229_AUTO_TRAY = "EnableAutoTray";
        internal const byte _229_AUTO_TRAY_HIDE_VALUE = 1;
        internal const byte _229_AUTO_TRAY_SHOW_VALUE = 0;
        internal const byte _230_STUCK_RECTS3_HIDE_VALUE = 128;
        internal const string _230_STUCK_RECTS3_PATH = @"Software\Microsoft\Windows\CurrentVersion\Explorer\StuckRects3";
        internal const string _230_STUCK_RECTS3_SETTINGS = "Settings";
        internal const byte _230_STUCK_RECTS3_SHOW_VALUE = 0;
        internal const string _231_ENABLE_FEEDS = "EnableFeeds";
        internal const string _231_FEEDS_PATH = @"Software\Microsoft\Windows\CurrentVersion\Feeds";
        internal const string _231_FEEDS_POLICY_PATH = @"SOFTWARE\Policies\Microsoft\Windows\Windows Feeds";
        internal const byte _231_SHELL_FEEDS_DISABLED_VALUE = 2;
        internal const byte _231_SHELL_FEEDS_ENABLED_VALUE = 0;
        internal const string _231_SHELL_FEEDS_MODE = "ShellFeedsTaskbarViewMode";
        internal const byte _242_HIDE_ALERT_VALUE = 1;
        internal const string _242_NO_NEW_APP_ALERT = "NoNewAppAlert";
        internal const byte _242_SHOW_ALERT_VALUE = 0;
        internal const string _243_FIRST_LOGON_ANIMATION = "EnableFirstLogonAnimation";
        internal const byte _245_JPEG_MAX_QUALITY = 100;
        internal const byte _247_HIDE_VALUE = 0;
        internal const string _247_RESTART_NOTIFICATIONS = "RestartNotificationsAllowed2";
        internal const byte _247_SHOW_VALUE = 1;
        internal const string _247_WINDOWS_UPDATE_SETTINGS_PATH = @"SOFTWARE\Microsoft\WindowsUpdate\UX\Settings";
        internal const string _248_DISABLE_VALUE = "%s.lnk";
        internal const string _248_EXPLORER_NAMING_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\NamingTemplates";
        internal const string _248_LINK = "link";
        internal const string _248_SHORTCUT = "ShortcutNameTemplate";
        internal const string _249_CONTROL_PANEL_KEYBOARD_PATH = @"Control Panel\Keyboard";
        internal const string _249_PRINT_SCREEN_SNIPPING = "PrintScreenKeyForSnippingEnabled";
        internal const byte _251_DISABLED_VALUE = 1;
        internal const string _251_DISALLOW_WINDOWS_SHAKE = "DisallowShaking";
        internal const byte _251_ENABLED_VALUE = 0;
        internal const byte _302_STORAGE_POLICY_MONTH_VALUE = 30;
        internal const string _304_STORAGE_POLICY_04 = "04";
        internal const byte _305_ENABLED_VALUE = 1;
        internal const string _305_HIBERNATE = "HibernateEnabled";
        internal const string _305_HIBERNATE_OFF = "/HIBERNATE OFF";
        internal const string _305_HIBERNATE_ON = "/HIBERNATE ON";
        internal const string _305_POWER_CONTROL_PATH = @"SYSTEM\CurrentControlSet\Control\Power";
        internal const string _307_SYMBOLIC_LINK_TASK = "SophiApp Temp Folder Link Task";
        internal const string _307_SYSTEM_DRIVE_TEMP = @"%SystemDrive%\Temp";
        internal const string _307_TASK_ARGS = "-WindowStyle Hidden -Command \"Get-ChildItem -Path $env:SystemRoot\\Temp -Recurse -Force | Remove-Item -Recurse -Force; Get-ChildItem -Path $env:LOCALAPPDATA\\Temp -Recurse -Force | Remove-Item -Recurse -Force; Get-Item -Path $env:LOCALAPPDATA\\Temp -Force | Where-Object -FilterScript {$_.LinkType -ne 'SymbolicLink'} | Remove-Item -Recurse -Force; New-Item -Path $env:LOCALAPPDATA\\Temp -ItemType SymbolicLink -Value $env:SystemDrive\\Temp -Force; Unregister-ScheduledTask -TaskName 'SophiApp Temp Folder Link Task' -Confirm:$false;\"";
        internal const string _308_APPDATA_TEMP = @"%USERPROFILE%\AppData\Local\Temp";
        internal const string _308_TASK_ARGS = "-WindowStyle Hidden -Command \"Remove-Item -Path $env:SystemDrive\\Temp -Recurse -Force; Unregister-ScheduledTask -TaskName 'SophiApp Temp Folder Clear Task' -Confirm:$false;\"";
        internal const string _308_TEMPORARY_TASK = "SophiApp Temp Folder Clear Task";
        internal const string _309_CONTROL_FILE_SYSTEM_PATH = @"SYSTEM\CurrentControlSet\Control\FileSystem";
        internal const byte _309_DISABLED_VALUE = 1;
        internal const byte _309_ENABLED_VALUE = 0;
        internal const string _309_LONG_PATH = "LongPathsEnabled";
        internal const string _310_DISPLAY_PARAMS = "DisplayParameters";
        internal const string _310_SYSTEM_CRASH_CONTROL_PATH = @"SYSTEM\CurrentControlSet\Control\CrashControl";
        internal const string _314_ENABLE_LINKED = "EnableLinkedConnections";
        internal const byte _314_ENABLE_LINKED_VALUE = 1;
        internal const string _315_DELIVERY_SETTINGS_PATH = @"S-1-5-20\SOFTWARE\Microsoft\Windows\CurrentVersion\DeliveryOptimization\Settings";
        internal const string _315_DOWNLOAD_MODE = "DownloadMode";
        internal const string _316_FOREGROUND_POLICY = "SyncForegroundPolicy";
        internal const string _316_WINLOGON_PATH = @"SOFTWARE\Policies\Microsoft\Windows NT\CurrentVersion\Winlogon";
        internal const string _317_CURRENT_VERSION_WINDOWS_PATH = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Windows";
        internal const byte _317_DISABLED_VALUE = 1;
        internal const byte _317_ENABLED_VALUE = 0;
        internal const string _317_PRINTER_LEGACY_MODE = "LegacyDefaultPrinterMode";
        internal const string _334_SERVICE_MANAGER_GUID = "7971f918-a847-4430-9279-4a52d1efe18d";
        internal const string _334_UPDATE_SERVICE_MANAGER = "Microsoft.Update.ServiceManager";
        internal const string _336_HIGH_POWER_ARGS = "/SETACTIVE SCHEME_MIN";
        internal const string _336_HIGH_POWER_GUID = "{8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c}";
        internal const string _337_BALANCED_POWER_ARGS = "/SETACTIVE SCHEME_BALANCED";
        internal const string _338_NET_FRAMEWORK32_PATH = @"SOFTWARE\Wow6432Node\Microsoft\.NETFramework";
        internal const string _338_NET_FRAMEWORK64_PATH = @"SOFTWARE\Microsoft\.NETFramework";
        internal const string _338_USE_LATEST_CLR = "OnlyUseLatestCLR";
        internal const string _340_DISABLE_NET_BINDING_PS = "Disable-NetAdapterBinding –Name * –ComponentID ms_tcpip6";
        internal const string _340_ENABLE_NET_BINDING_PS = "Enable-NetAdapterBinding –Name * –ComponentID ms_tcpip6";
        internal const string _340_GET_IPV6_PS = @"((@((Get-CimInstance -ClassName Win32_NetworkAdapterConfiguration -Namespace root\cimv2 | Where-Object -FilterScript {$_.IPEnabled -eq $true}).IPAddress)) -match ':')";
        internal const string _345_DESKTOP_FOLDER = "Desktop";
        internal const byte _348_AUTOMATICALLY_VALUE = 3;
        internal const byte _349_DEFAULT_VALUE = 2;
        internal const string _350_SEPARATE_PROCESS = "SeparateProcess";
        internal const string _351_RESERVE_MANAGER_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\ReserveManager";
        internal const string _351_SHIPPED_RESERVES = "ShippedWithReserves";
        internal const string _352_TYPELIB_PATH = @"SOFTWARE\Classes\Typelib\{8cec5860-07a1-11d9-b15e-000d56bfe6ee}";
        internal const string _352_TYPELIB_WIN64_PATH = @"SOFTWARE\Classes\Typelib\{8cec5860-07a1-11d9-b15e-000d56bfe6ee}\1.0\0\win64";
        internal const string _353_DEFAULT_KEYBOARD_PATH = @".DEFAULT\Control Panel\Keyboard";
        internal const string _353_DISABLED_VALUE = "2147483648";
        internal const string _353_ENABLED_VALUE = "2147483650";
        internal const string _353_INITIAL_INDICATORS = "InitialKeyboardIndicators";
        internal const string _354_KEYBOARD_LAYOUT_PATH = @"SYSTEM\CurrentControlSet\Control\Keyboard Layout";
        internal const string _354_SCAN_CODE = "Scancode Map";
        internal const string _355_DISABLED_VALUE = "506";
        internal const string _355_ENABLED_VALUE = "510";
        internal const string _355_FLAGS = "Flags";
        internal const string _355_STICKY_KEYS_PATH = @"Control Panel\Accessibility\StickyKeys";
        internal const string _356_AUTOPLAY = "DisableAutoplay";
        internal const string _356_AUTOPLAY_HANDLERS_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\AutoplayHandlers";
        internal const byte _356_DISABLED_VALUE = 1;
        internal const byte _356_ENABLED_VALUE = 0;
        internal const string _357_AUTOPLAY = "Autorun";
        internal const byte _357_DISABLED_VALUE = 0;
        internal const byte _357_ENABLED_VALUE = 3;
        internal const string _357_THUMBNAIL_CACHE_PATH = @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Explorer\VolumeCaches\Thumbnail Cache";
        internal const string _358_RESTART_APPS = "RestartApps";
        internal const string _359_FILE_PRINTER_SHARING_GROUP = "@FirewallAPI.dll,-32752";
        internal const string _359_NET_CATEGORY_PARAM = "NetworkCategory";
        internal const string _359_NETWORK_DISCOVERY_GROUP = "@FirewallAPI.dll,-28502";
        internal const string _359_PRIVATE_VALUE = "Private";
        internal const string _359_SET_PROFILE_PS = "Set-NetConnectionProfile";
        internal const string _360_ACTIVE_HOURS = "SmartActiveHoursState";
        internal const byte _360_AUTO_STATE = 1;
        internal const byte _360_MANUAL_STATE = 0;
        internal const string _361_IS_EXPEDITED = "IsExpedited";
        internal const string _362_MSI_MASK = "*.msi";
        internal const string _362_MSIEXEC_EXE = "msiexec.exe";
        internal const string _362_PC_HEALTH_CHECK = "Windows PC Health Check";
        internal const string _362_PRODUCT_NAME = "ProductName";
        internal const string _363_DOWNLOAD_URL = "https://aka.ms/vs/17/release/vc_redist.x64.exe";
        internal const string _363_VC_REDISTR_FOR_VS_2022 = "Visual C++ Redistributable for Visual Studio 2022";
        internal const string _363_VC_REDISTRX64 = "vc_redist.x64.exe";
        internal const string _363_VC_REDISTRX64_ARGS = "/install /passive /norestart";
        internal const string _363_VC_VERSION_URL = "https://raw.githubusercontent.com/aaronparker/vcredist/main/VcRedist/VisualCRedistributables.json";
        internal const byte _400_DISABLED_VALUE = 1;
        internal const string _400_HIDE_ADDED_APPS = "HideRecentlyAddedApps";
        internal const string _401_APP_SUGGESTIONS = "SubscribedContent-338388Enabled";
        internal const string _500_ADGUARD_LINK = "https://store.rg-adguard.net/api/GetFiles";
        internal const string _500_UWP_HEVC_VIDEO = "Microsoft.HEVCVideoExtension";
        internal const string _501_CORTANA_STARTUP_PATH = @"Local Settings\Software\Microsoft\Windows\CurrentVersion\AppModel\SystemAppData\Microsoft.549981C3F5F10_8wekyb3d8bbwe\CortanaStartupId";
        internal const string _501_CORTANA_STATE = "State";
        internal const byte _501_DISABLED_VALUE = 1;
        internal const byte _501_ENABLED_VALUE = 2;
        internal const string _600_APP_CAPTURE = "AppCaptureEnabled";
        internal const string _600_GAME_CONFIG_PATH = @"System\GameConfigStore";
        internal const string _600_GAME_DVR = "GameDVR_Enabled";
        internal const string _600_GAME_DVR_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\GameDVR";
        internal const string _601_GAME_BAR_PATH = @"SOFTWARE\Microsoft\GameBar";
        internal const string _601_SHOW_PANEL = "ShowStartupPanel";
        internal const byte _602_DISABLED_VALUE = 1;
        internal const byte _602_ENABLED_VALUE = 2;
        internal const string _602_FEATURE_SET_PATH = @"SYSTEM\CurrentControlSet\Control\GraphicsDrivers\FeatureSetUsage";
        internal const string _602_GRAPHICS_DRIVERS_PATH = @"SYSTEM\CurrentControlSet\Control\GraphicsDrivers";
        internal const string _602_HWSCH_MODE = "HwSchMode";
        internal const string _602_INTERNAL_DAC_TYPE = "Internal";
        internal const string _602_WDDM_VERSION = "WddmVersion_Min";
        internal const int _602_WDDM_VERSION_MIN = 2700;
        internal const byte _700_30_DAYS_INTERVAL = 30;

        internal const string _700_CLEANUP_TASK_ARGS = @"-WindowStyle Hidden -Command Get-Process -Name cleanmgr | Stop-Process -Force
Get-Process -Name Dism | Stop-Process -Force
Get-Process -Name DismHost | Stop-Process -Force
$ProcessInfo = New-Object -TypeName System.Diagnostics.ProcessStartInfo
$ProcessInfo.FileName = """"""$env:SystemRoot\system32\cleanmgr.exe""""""
$ProcessInfo.Arguments = """"""/sagerun:1337""""""
$ProcessInfo.UseShellExecute = $true
$ProcessInfo.WindowStyle = [System.Diagnostics.ProcessWindowStyle]::Minimized
$Process = New-Object -TypeName System.Diagnostics.Process
$Process.StartInfo = $ProcessInfo
$Process.Start() | Out-Null
Start-Sleep -Seconds 3
[int]$SourceMainWindowHandle = (Get-Process -Name cleanmgr | Where-Object -FilterScript {$_.PriorityClass -eq """"""BelowNormal""""""}).MainWindowHandle
function MinimizeWindow
    {
        [CmdletBinding()]
        param
    (
        [Parameter(Mandatory = $true)]
		$Process
    )
	$ShowWindowAsync = @{
        Namespace = """"""WinAPI""""""
        Name = """"""Win32ShowWindowAsync""""""
        Language = """"""CSharp""""""
        MemberDefinition = @'
[DllImport(""""""user32.dll"""""")]
public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow)
'@
    }

    if (-not(""""""WinAPI.Win32ShowWindowAsync"""""" -as [type]))
    {
        Add-Type @ShowWindowAsync
    }
	$MainWindowHandle = (Get-Process -Name $Process | Where-Object -FilterScript {$_.PriorityClass -eq """"""BelowNormal""""""}).MainWindowHandle
    [WinAPI.Win32ShowWindowAsync]::ShowWindowAsync($MainWindowHandle, 2)
    }

while ($true)
{
    [int]$CurrentMainWindowHandle = (Get-Process -Name cleanmgr | Where-Object -FilterScript {$_.PriorityClass -eq """"""BelowNormal""""""}).MainWindowHandle
    if ($SourceMainWindowHandle -ne $CurrentMainWindowHandle)
    {
        MinimizeWindow -Process cleanmgr
        break
    }
    Start-Sleep -Milliseconds 5
}
$ProcessInfo = New-Object -TypeName System.Diagnostics.ProcessStartInfo
$ProcessInfo.FileName = """"""$env:SystemRoot\system32\dism.exe""""""
$ProcessInfo.Arguments = """"""/Online /English /Cleanup-Image /StartComponentCleanup /NoRestart""""""
$ProcessInfo.UseShellExecute = $true
$ProcessInfo.WindowStyle = [System.Diagnostics.ProcessWindowStyle]::Minimized
$Process = New-Object -TypeName System.Diagnostics.Process
$Process.StartInfo = $ProcessInfo
$Process.Start() | Out-Null";

        internal const string _700_CLEANUP_TOAST_TASK_ARGS = @"-WindowStyle Hidden -Command [Windows.UI.Notifications.ToastNotificationManager, Windows.UI.Notifications, ContentType = WindowsRuntime] | Out-Null
[Windows.Data.Xml.Dom.XmlDocument, Windows.Data.Xml.Dom.XmlDocument, ContentType = WindowsRuntime] | Out-Null
[xml]$ToastTemplate = @""""""
<toast duration=""""""Long"""""" scenario=""""""reminder"""""">
	<visual>
		<binding template = """"""ToastGeneric"""""" >
            <text>*</text>
			<group>
				<subgroup>
					<text hint-style=""""""title"""""" hint-wrap=""""""true"""""">*</text>
				</subgroup>
			</group>
			<group>
				<subgroup>
					<text hint-style=""""""body"""""" hint-wrap=""""""true"""""">*</text>
				</subgroup>
			</group>
		</binding>
	</visual>
	<audio src=""""""ms-winsoundevent:notification.default""""""/>
    <actions>
        <input id=""""""SnoozeTimer"""""" type=""""""selection"""""" title=""""""*"""""" defaultInput=""""""1"""""">
			<selection id=""""""1"""""" content=""""""*"""""" />
			<selection id=""""""30"""""" content=""""""*"""""" />
			<selection id=""""""240"""""" content=""""""*"""""" />
		</input>
		<action activationType=""""""system"""""" arguments=""""""snooze"""""" hint-inputId=""""""SnoozeTimer"""""" content="""""""""""" id=""""""test-snooze""""""/>
		<action arguments=""""""WindowsCleanup:"""""" content=""""""*"""""" activationType=""""""protocol""""""/>
		<action arguments=""""""dismiss"""""" content="""""""""""" activationType=""""""system""""""/>
	</actions>
</toast>
""""""@
$ToastXml = [Windows.Data.Xml.Dom.XmlDocument]::New()
$ToastXml.LoadXml($ToastTemplate.OuterXml)
$ToastMessage = [Windows.UI.Notifications.ToastNotification]::New($ToastXML)
[Windows.UI.Notifications.ToastNotificationManager]::CreateToastNotifier(""""""windows.immersivecontrolpanel_cw5n1h2txyewy!microsoft.windows.immersivecontrolpanel"""""").Show($ToastMessage)";

        internal const string _700_EDIT_FLAGS = "EditFlags";
        internal const uint _700_EDIT_FLAGS_VALUE = 2162688;
        internal const string _700_SOPHIA_CLEANUP_NOTIFICATION_TASK = "Windows Cleanup Notification";
        internal const string _700_SOPHIA_CLEANUP_TASK = "Windows Cleanup";
        internal const string _700_STATE_FLAGS_1337 = "StateFlags1337";
        internal const byte _700_STATE_FLAGS_1337_VALUE = 2;
        internal const string _700_URL_PROTOCOL = "URL Protocol";
        internal const string _700_VOLUME_CACHES_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\VolumeCaches";
        internal const string _700_WINDOWS_CLEANUP = "WindowsCleanup";
        internal const string _700_WINDOWS_CLEANUP_COMMAND = @"powershell.exe -Command ""& {Start-ScheduledTask -TaskPath 'SophiApp' -TaskName 'Windows Cleanup'}"" -Force";
        internal const string _700_WINDOWS_CLEANUP_OPEN_PATH = @"WindowsCleanup\shell\open\command";
        internal const string _700_WINDOWS_CLEANUP_URL = "URL:WindowsCleanup";
        internal const byte _701_90_DAYS_INTERVAL = 90;

        internal const string _701_SOFTWARE_DISTRIBUTION_TASK_ARGS = @"-WindowStyle Hidden -Command (Get-Service -Name wuauserv).WaitForStatus('Stopped', '01:00:00')
Get-ChildItem -Path $env:SystemRoot\SoftwareDistribution\Download -Recurse -Force | Remove-Item -Recurse -Force
[Windows.UI.Notifications.ToastNotificationManager, Windows.UI.Notifications, ContentType = WindowsRuntime] | Out-Null
[Windows.Data.Xml.Dom.XmlDocument, Windows.Data.Xml.Dom.XmlDocument, ContentType = WindowsRuntime] | Out-Null
[xml]$ToastTemplate = @""""""
<toast duration=""""""Long"""""">
	<visual>
		<binding template = """"""ToastGeneric"""""">
			<text>*</text>
			<group>
				<subgroup>
					<text hint-style=""""""body"""""" hint-wrap=""""""true"""""">*</text>
				</subgroup>
			</group>
		</binding>
	</visual>
	<audio src = """"""ms-winsoundevent:notification.default""""""/>
</toast>
""""""@
$ToastXml = [Windows.Data.Xml.Dom.XmlDocument]::New()
$ToastXml.LoadXml($ToastTemplate.OuterXml)
$ToastMessage = [Windows.UI.Notifications.ToastNotification]::New($ToastXML)
[Windows.UI.Notifications.ToastNotificationManager]::CreateToastNotifier(""""""windows.immersivecontrolpanel_cw5n1h2txyewy!microsoft.windows.immersivecontrolpanel"""""").Show($ToastMessage)";

        internal const string _701_SOPHIA_SOFTWARE_DISTRIBUTION_TASK = "SoftwareDistribution";
        internal const byte _702_60_DAYS_INTERVAL = 60;

        internal const string _702_CLEAR_TEMP_ARGS = @"-WindowStyle Hidden -Command Get-ChildItem -Path $env:TEMP -Recurse -Force | Where-Object {$_.CreationTime -lt (Get-Date).AddDays(-1)} | Remove-Item -Recurse -Force
[Windows.UI.Notifications.ToastNotificationManager, Windows.UI.Notifications, ContentType = WindowsRuntime] | Out-Null
[Windows.Data.Xml.Dom.XmlDocument, Windows.Data.Xml.Dom.XmlDocument, ContentType = WindowsRuntime] | Out-Null
[xml]$ToastTemplate = @""""""
<toast duration=""""""Long"""""">
	<visual>
		<binding template=""""""ToastGeneric"""""">
			<text>*</text>
			<group>
				<subgroup>
					<text hint-style=""""""body"""""" hint-wrap=""""""true"""""">*</text>
				</subgroup>
			</group>
		</binding>
	</visual>
	<audio src=""""""ms-winsoundevent:notification.default"""""" />
</toast>
""""""@
$ToastXml = [Windows.Data.Xml.Dom.XmlDocument]::New()
$ToastXml.LoadXml($ToastTemplate.OuterXml)
$ToastMessage = [Windows.UI.Notifications.ToastNotification]::New($ToastXML)
[Windows.UI.Notifications.ToastNotificationManager]::CreateToastNotifier(""""""windows.immersivecontrolpanel_cw5n1h2txyewy!microsoft.windows.immersivecontrolpanel"""""").Show($ToastMessage)";

        internal const string _702_SOPHIA_CLEAR_TEMP_TASK = "Temp";
        internal const string _800_ENABLE_NETWORK_PROTECTION = "EnableNetworkProtection";
        internal const string _800_SET_NETWORK_PROTECTION_PS = "Set-MpPreference -EnableNetworkProtection";
        internal const string _801_PUA_PROTECTION = "PUAProtection";
        internal const string _801_SET_PUA_PROTECTION_PS = "Set-MpPreference -PUAProtection";
        internal const string _802_DEFENDER_SANDBOX_PROCESS = "MsMpEngCP";
        internal const string _802_DEFENDER_USE_SANDBOX_ARGS = "/M MP_FORCE_USE_SANDBOX";
        internal const string _802_FORCE_USE_SANDBOX = "MP_FORCE_USE_SANDBOX";
        internal const string _802_SANDBOX_ENABLED_VALUE = "1";
        internal const string _802_SETX_APP = "setx";

        internal const string _803_PROGRAM_AUDIT_ENABLED_PS = @"$OutputEncoding = [System.Console]::OutputEncoding = [System.Console]::InputEncoding = [System.Text.Encoding]::UTF8
$Enabled = auditpol /get /Subcategory:'{0CCE922B-69AE-11D9-BED3-505054503030}' /r | ConvertFrom-Csv | Select-Object -ExpandProperty 'Inclusion Setting'
if ($Enabled -eq 'Success and Failure')
{
    $true
}
else
{
    $false
}";

        internal const string _804_COMMAND_AUDIT_ENABLED_PS = @"$OutputEncoding = [System.Console]::OutputEncoding = [System.Console]::InputEncoding = [System.Text.Encoding]::UTF8
$Enabled = auditpol /get /Subcategory:'{0CCE922B-69AE-11D9-BED3-505054503030}' /r | ConvertFrom-Csv | Select-Object -ExpandProperty 'Inclusion Setting'
if ($Enabled -eq 'Success and Failure')
{
    $ProcessCreationIncludeCmdLine_Enabled = Get-ItemPropertyValue -Path HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System\Audit -Name ProcessCreationIncludeCmdLine_Enabled
    if ($ProcessCreationIncludeCmdLine_Enabled -eq 1)
    {
        $true
    }
    else
    {
        $false
    }
}
else
{
    $false
}";

        internal const string _805_EVENT_VIEWER_IS_CUSTOM_VIEW_PS = @"$OutputEncoding = [System.Console]::OutputEncoding = [System.Console]::InputEncoding = [System.Text.Encoding]::UTF8
$Enabled = auditpol /get /Subcategory:'{0CCE922B-69AE-11D9-BED3-505054503030}' /r | ConvertFrom-Csv | Select-Object -ExpandProperty 'Inclusion Setting'
if ($Enabled -eq 'Success and Failure')
{
	$ProcessCreationIncludeCmdLine_Enabled = Get-ItemPropertyValue -Path HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System\Audit -Name ProcessCreationIncludeCmdLine_Enabled
	if ($ProcessCreationIncludeCmdLine_Enabled -eq 1)
	{
		if (Test-Path -Path ""$env:ProgramData\Microsoft\Event Viewer\Views\ProcessCreation.xml"")
		{
			$true
		}
        else
        {
            $false
        }
	}
    else
    {
        $false
    }
}
else
{
    $false
}";

        internal const string _805_PROCESS_CREATION_XML = "ProcessCreation.xml";

        internal const string _805_PROCESS_CREATION_XML_DATA = @"<ViewerConfig>
    <QueryConfig>
        <QueryParams>
            <UserQuery/>
        </QueryParams>
        <QueryNode>
            <Name>*</Name>
            <Description>*</Description>
            <QueryList>
                <Query Id=""0"" Path=""Security"">
                    <Select Path=""Security"">*</Select>
                </Query>
            </QueryList>
        </QueryNode>
    </QueryConfig>
</ViewerConfig>";

        internal const string _806_ALL_MODULE = "*";
        internal const string _806_ENABLE_MODULE_LOGGING = "EnableModuleLogging";
        internal const string _806_POWERSHELL_MODULE_LOGGING_PATH = @"SOFTWARE\Policies\Microsoft\Windows\PowerShell\ModuleLogging";
        internal const string _806_POWERSHELL_MODULE_NAMES_PATH = @"SOFTWARE\Policies\Microsoft\Windows\PowerShell\ModuleLogging\ModuleNames";
        internal const string _807_ENABLE_SCRIPT_BLOCK_LOGGING = "EnableScriptBlockLogging";
        internal const string _807_POWERSHELL_SCRIPT_BLOCK_LOGGING_PATH = @"SOFTWARE\Policies\Microsoft\Windows\PowerShell\ScriptBlockLogging";
        internal const string _808_SMART_SCREEN_DISABLED_VALUE = "Off";
        internal const string _808_SMART_SCREEN_ENABLED = "SmartScreenEnabled";
        internal const string _808_SMART_SCREEN_ENABLED_VALUE = "Warn";
        internal const string _809_CURRENT_POLICIES_ATTACHMENTS_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Attachments";
        internal const byte _809_DISABLED_VALUE = 1;
        internal const string _809_SAFE_ZONE_INFO = "SaveZoneInformation";
        internal const string _810_WSH_SETTINGS_PATH = @"SOFTWARE\Microsoft\Windows Script Host\Settings";
        internal const string _811_HYPERVISOR_PRESENT = "HypervisorPresent";
        internal const string _811_WINDOWS_SANDBOX_FEATURE = "Containers-DisposableClientVM";
        internal const string _812_POWERSHELL_V2_ROOT_FEATURE = "MicrosoftWindowsPowerShellV2Root";
        internal const string _900_MSI_EXTRACT_COM_PATH = @"Msi.Package\shell\Extract\Command";
        internal const string _900_MSI_EXTRACT_PATH = @"Msi.Package\shell\Extract";
        internal const string _900_MSI_EXTRACT_VALUE = "msiexec.exe /a \"%1\" /qb TARGETDIR=\"%1 extracted\"";
        internal const string _900_MSI_ICON = "Icon";
        internal const string _900_MSI_ICON_VALUE = "shell32.dll,-16817";
        internal const string _900_MSI_MUIVERB_VALUE = "@shell32.dll,-37514";
        internal const string _901_CAB_COM_PATH = @"CABFolder\Shell\RunAs\Command";
        internal const string _901_CAB_LUA_SHIELD = "HasLUAShield";
        internal const string _901_CAB_RUNAS_PATH = @"CABFolder\Shell\RunAs";
        internal const string _901_CAB_VALUE = "cmd /c DISM.exe /Online /Add-Package /PackagePath:\"%1\" /NoRestart & pause\"";
        internal const string _901_MUIVERB_VALUE = "@shell32.dll,-10210";
        internal const string _902_EXTENDED = @"Extended";
        internal const string _902_RUNAS_USER_PATH = @"exefile\shell\runasuser";
        internal const string _903_CAST_TO_DEV_GUID = @"{7AD84985-87B4-4a16-BE58-8B72A5B390F7}";
        internal const string _903_CAST_TO_DEV_VALUE = "Play to menu";
        internal const string _904_SHARE_GUID = @"{E2BF9676-5F8F-435C-97EB-11607A5BEDF7}";
        internal const string _905_MS_PAINT_3D = "Microsoft.MSPaint";
        internal const string _906_BMP_EXT = @"SystemFileAssociations\.bmp\Shell\3D Edit";
        internal const string _907_GIF_EXT = @"SystemFileAssociations\.gif\Shell\3D Edit";
        internal const string _908_JPE_EXT = @"SystemFileAssociations\.jpe\Shell\3D Edit";
        internal const string _909_JPEG_EXT = @"SystemFileAssociations\.jpeg\Shell\3D Edit";
        internal const string _910_JPG_EXT = @"SystemFileAssociations\.jpg\Shell\3D Edit";
        internal const string _911_PNG_EXT = @"SystemFileAssociations\.png\Shell\3D Edit";
        internal const string _912_TIF_EXT = @"SystemFileAssociations\.tif\Shell\3D Edit";
        internal const string _913_TIFF_EXT = @"SystemFileAssociations\.tiff\Shell\3D Edit";
        internal const string _914_PHOTOS_SHELL_EDIT_PATH = @"AppX43hnxtbyyps62jhe9sqpdzxn1790zetc\Shell\ShellEdit";
        internal const string _915_PHOTOS_SHELL_VIDEO_PATH = @"AppX43hnxtbyyps62jhe9sqpdzxn1790zetc\Shell\ShellCreateVideo";
        internal const string _916_IMG_SHELL_EDIT_PATH = @"SystemFileAssociations\image\shell\edit";
        internal const string _917_BAT_SHELL_EDIT_PATH = @"batfile\shell\print";
        internal const string _917_CMD_SHELL_EDIT_PATH = @"cmdfile\shell\print";
        internal const string _918_HIDE_VALUE = "-{3dad6c5d-2167-4cae-9914-f99e41c12cfa}";
        internal const string _918_LIB_LOCATION_PATH = @"Folder\ShellEx\ContextMenuHandlers\Library Location";
        internal const string _918_SHOW_VALUE = "{3dad6c5d-2167-4cae-9914-f99e41c12cfa}";
        internal const string _919_HIDE_VALUE = "-{7BA4C740-9E81-11CF-99D3-00AA004AE837}";
        internal const string _919_SEND_TO_PATH = @"AllFilesystemObjects\shellex\ContextMenuHandlers\SendTo";
        internal const string _919_SHOW_VALUE = "{7BA4C740-9E81-11CF-99D3-00AA004AE837}";
        internal const string _920_BITLOCKER_BDELEV_PATH = @"Drive\shell\encrypt-bde-elev";
        internal const string _921_BMP_ITEM_NAME = "ItemName";
        internal const string _921_BMP_ITEM_VALUE = @"@%systemroot%\system32\mspaint.exe,-59414";
        internal const string _921_BMP_NULL_FILE = "NullFile";
        internal const string _921_BMP_SHELL_NEW = @".bmp\ShellNew";
        internal const string _922_DATA_VALUE = "{\rtf1}";
        internal const string _922_ITEM_VALUE = @"@%ProgramFiles%\Windows NT\Accessories\WORDPAD.EXE,-213";
        internal const string _922_MS_WORD_PAD = "Microsoft.Windows.WordPad~~~~0.0.1.0";
        internal const string _922_RTF_SHELL_NEW = @".rtf\ShellNew";
        internal const string _923_ITEM_DATA = @"@%SystemRoot%\system32\zipfldr.dll,-10194";
        internal const string _923_ZIP_SHELLNEW_PATH = @".zip\CompressedFolder\ShellNew";
        internal const string _924_PROMPT_NAME = "MultipleInvokePromptMinimum";
        internal const int _924_PROMPT_VALUE = 300;
        internal const string _925_NO_USE_NAME = "NoUseStoreOpenWith";
        internal const byte _925_NO_USE_VALUE = 1;
        internal const string ACTION_CENTER_APPX_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Notifications\Settings\windows.immersivecontrolpanel_cw5n1h2txyewy!microsoft.windows.immersivecontrolpanel";
        internal const string ADMIN_PROMPT = "ConsentPromptBehaviorAdmin";
        internal const byte ADMIN_PROMPT_DEFAULT_VALUE = 5;
        internal const byte ADMIN_PROMPT_NEVER_VALUE = 0;
        internal const string ADVANCED_EXPLORER_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced";
        internal const byte ALL_ITEMS_ICON_CATEGORY_VALUE = 0;
        internal const byte ALL_ITEMS_ICON_SMALL_VALUE = 1;
        internal const string ALL_ITEMS_ICON_VIEW = "AllItemsIconView";
        internal const string ALLOW_TELEMETRY = "AllowTelemetry";
        internal const string ANTISPYWARE_ENABLED = "AntispywareEnabled";
        internal const string APPS_USES_THEME = "AppsUseLightTheme";
        internal const string AUDITPOL_APP = "auditpol";
        internal const string CAPABILITY_MS_PAINT = "Microsoft.Windows.MSPaint~~~~0.0.1.0";
        internal const string CEIP_TASK_PATH = @"Microsoft\Windows\Customer Experience Improvement Program";
        internal const string CONTENT_DELIVERY_MANAGER_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\ContentDeliveryManager";
        internal const string CONTROL_PANEL_DESKTOP_PATH = @"Control Panel\Desktop";
        internal const string CONTROL_PANEL_EXPLORER_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\ControlPanel";
        internal const string CONTROL_PANEL_USER_PROFILE_PATH = @"Control Panel\International\User Profile";
        internal const string CURRENT_VERSION_EXPLORER_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer";
        internal const byte DARK_THEME_VALUE = 0;
        internal const string DATA = "Data";
        internal const string DATA_COLLECTION_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\DataCollection";
        internal const byte DEFAULT_TELEMETRY_VALUE = 3;
        internal const string DEFENDER_COMPUTER_STATUS_CLASS = "MSFT_MpComputerStatus";
        internal const string DEFENDER_NAMESPACE = @"Root\Microsoft\Windows\Defender";
        internal const string DEFENDER_PREFERENCE_PS = "Get-MpPreference";
        internal const string DESKTOP_ICON_THIS_COMPUTER = "{20D04FE0-3AEA-1069-A2D8-08002B30309D}";
        internal const string DIAG_TRACK_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Diagnostics\DiagTrack";
        internal const byte DIALOG_COMPACT_VALUE = 0;
        internal const byte DIALOG_DETAILED_VALUE = 1;
        internal const string DISABLED = "Disabled";
        internal const byte DISABLED_VALUE = 0;
        internal const string ENABLED = "Enabled";
        internal const byte ENABLED_VALUE = 1;
        internal const string ENTHUSIAST_MODE = "EnthusiastMode";
        internal const string ENVIRONMENT = "Environment";
        internal const string ENVIRONMENT_LOCAL_APPDATA = "%LOCALAPPDATA%";
        internal const string ENVIRONMENT_SYSTEM_DRIVE = "%SystemDrive%";
        internal const string ENVIRONMENT_SYSTEM_ROOT = "%SystemRoot%";
        internal const string ENVIRONMENT_TEMP = "%TEMP%";
        internal const string GAMING_APP_UWP = "Microsoft.GamingApp";
        internal const string IMAGES_FOLDER = "{B7BEDE81-DF94-4682-A7D8-57A52620B86F}";
        internal const string INPUT_ENG_VALUE = "0409:00000409";
        internal const string INPUT_METHOD_OVERRIDE = "InputMethodOverride";
        internal const string ITEM_NAME = "ItemName";
        internal const string JPEG_QUALITY = "JPEGImportQuality";
        internal const string KB5005463_FIX_UNINSTALL_ARGS = "/uninstall /kb:5005463 /quiet /norestart";
        internal const string KB5005463_UPD = "KB5005463";
        internal const byte LAUNCH_PC_VALUE = 1;
        internal const byte LAUNCH_QA_VALUE = 2;
        internal const string LAUNCH_TO = "LaunchTo";
        internal const byte LIGHT_THEME_VALUE = 1;
        internal const string MAPS_TASK_PATH = @"Microsoft\Windows\Maps";
        internal const string MAX_TELEMETRY_ALLOWED = "MaxTelemetryAllowed";
        internal const byte MIN_ENT_TELEMETRY_VALUE = 0;
        internal const byte MIN_TELEMETRY_VALUE = 1;
        internal const string MITIGATION_USER_PREFERENCE = "UserPreference";
        internal const string MUIVERB = "MUIVerb";
        internal const string PERSONALIZE_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize";
        internal const string POLICIES_AUDIT_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System\Audit";
        internal const string POLICIES_EXPLORER_PATH = @"SOFTWARE\Policies\Microsoft\Windows\Explorer";
        internal const string POLICIES_SYSTEM_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System";
        internal const string POWERCFG_EXE = "powercfg.exe";
        internal const string POWERSHELL_EXE = "powershell.exe";
        internal const string PROCESS_AUDIT_DISABLED_ARGS = @"/set /subcategory:""{0CCE922B-69AE-11D9-BED3-505054503030}"" /success:disable /failure:disable";
        internal const string PROCESS_AUDIT_ENABLED_ARGS = @"/set /subcategory:""{0CCE922B-69AE-11D9-BED3-505054503030}"" /success:enable /failure:enable";
        internal const string PROCESS_CREATION_ENABLED = "ProcessCreationIncludeCmdLine_Enabled";
        internal const string PROGRAM_ACCESS_ONLY = "ProgrammaticAccessOnly";
        internal const string SERVICE_SPOOLER = "Spooler";
        internal const string SESSION_MANAGER_ENVIRONMENT = @"SYSTEM\CurrentControlSet\Control\Session Manager\Environment";
        internal const string SHELL_EXT_BLOCKED_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Shell Extensions\Blocked";
        internal const string SHOW_IN_ACTION_CENTER = "ShowInActionCenter";
        internal const string SHOWED_TOAST_LEVEL = "ShowedToastAtLevel";
        internal const string SIUF_PATH = @"SOFTWARE\Microsoft\Siuf\Rules";
        internal const string SIUF_PERIOD = "NumberOfSIUFInPeriod";
        internal const string SOPHIA_SCRIPT_SCHEDULED_PATH = "Sophia Script";
        internal const string START_PANEL_EXPLORER_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel";
        internal const string STARTUP_PAGE = "StartupPage";
        internal const byte STARTUP_PAGE_CATEGORY_VALUE = 0;
        internal const byte STARTUP_PAGE_ICON_VALUE = 1;
        internal const string STATUS_MANAGER_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\OperationStatusManager";
        internal const string STORAGE_POLICY_01 = "01";
        internal const string STORAGE_POLICY_2048 = "2048";
        internal const string STORAGE_POLICY_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\StorageSense\Parameters\StoragePolicy";
        internal const string SYSTEM_USES_THEME = "SystemUsesLightTheme";
        internal const byte TASKBAR_SEARCH_BOX_VALUE = 2;
        internal const byte TASKBAR_SEARCH_HIDE_VALUE = 0;
        internal const byte TASKBAR_SEARCH_ICON_VALUE = 1;
        internal const string TASKBAR_SEARCH_MODE = "SearchboxTaskbarMode";
        internal const string TASKBAR_SEARCH_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Search";
        internal const string TEMP = "TEMP";
        internal const string TEMP_FOLDER = "Temp";
        internal const string TMP = "TMP";
        internal const string UPDATE_UX_SETTINGS_PATH = @"SOFTWARE\Microsoft\WindowsUpdate\UX\Settings";
        internal const string USER_DOWNLOAD_FOLDER = "{374DE290-123F-4565-9164-39C4925E467B}";
        internal const string USER_SHELL_FOLDERS_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders";
        internal const string UWP_MS_CORTANA = "Microsoft.549981C3F5F10";
        internal const string UWP_MS_WIN_PHOTOS = "Microsoft.Windows.Photos";
        internal const string WIN_VER_EDU = "Education";
        internal const string WIN_VER_ENT = "Enterprise";
        internal const string WIN_VER_PRO = "Professional";
        internal const string WINDOWS_MITIGATION_PATH = @"SOFTWARE\Microsoft\WindowsMitigation";
        internal const string WINLOGON_PATH = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon";
        internal const string WUSA_EXE = "wusa.exe";
        internal const string X64 = "x64";
        internal const string XBOX_GAMING_OVERLAY_UWP = "Microsoft.XboxGamingOverlay";
        internal static readonly DateTime _21_PM_TASK_START = DateTime.Today.AddHours(21);
        internal static readonly string _315_DELIVERY_OPT_PATH = $@"{Environment.GetEnvironmentVariable("SystemRoot")}\SoftwareDistribution\DeliveryOptimization";
        internal static readonly string _362_INSTALLER_PATH = $@"{Environment.GetEnvironmentVariable("SystemRoot")}\Installer";
        internal static readonly string _402_POWERSHELL_LNK = $@"{Environment.GetEnvironmentVariable("APPDATA")}\Microsoft\Windows\Start Menu\Programs\Windows PowerShell\Windows PowerShell.lnk";

        internal static readonly Dictionary<string, string> _500_ADGUARD_WEB_PARAMS = new Dictionary<string, string>()        {
            { "ContentType", "application/x-www-form-urlencoded" }, { "type", "url" }, { "url", "https://www.microsoft.com/store/productId/9n4wgh0z6vhq" },
            { "ring", "RP" }, { "lang", "en-US" }
        };

        internal static readonly IEnumerable<string> _700_VOLUME_CACHES_NAMES = new string[] { "Delivery Optimization Files", "Device Driver Packages", "Previous Installations", "Setup Log Files", "Temporary Setup Files", "Update Cleanup", "Windows Defender", "Windows Upgrade Log Files" };
        internal static readonly string _805_EVENT_VIEWS_PATH = $@"{Environment.GetEnvironmentVariable("ProgramData")}\Microsoft\Event Viewer\Views";
        internal static readonly string SOPHIA_APP_SCHEDULED_PATH = AppHelper.AppName;
        internal static byte[] _354_DISABLED_VALUE = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 58, 0, 0, 0, 0, 0 };
        internal static byte[] _823_ZIP_DATA = new byte[] { 80, 75, 5, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    }
}