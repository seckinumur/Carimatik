; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Carimatik"
#define MyAppVersion "0.6"
#define MyAppPublisher "Se�kin Umur"
#define MyAppExeName "MainUIForm.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{C805436B-75B9-4D99-B043-97FFF5855979}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName=C:\{#MyAppName}
DisableDirPage=yes
DisableProgramGroupPage=yes
LicenseFile=C:\Users\Grafik Bask�\source\repos\Carimatik\MainUIForm\Lisans.txt
InfoAfterFile=C:\Users\Grafik Bask�\source\repos\Carimatik\MainUIForm\Kullan�m.txt
OutputDir=C:\Users\Grafik Bask�\Desktop\Carimatik
OutputBaseFilename=Carimatik Beta V06
SetupIconFile=C:\Users\Grafik Bask�\source\repos\Carimatik\MainUIForm\Img\SM.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "turkish"; MessagesFile: "compiler:Languages\Turkish.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "C:\Users\Grafik Bask�\source\repos\Carimatik\MainUIForm\bin\Debug\MainUIForm.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grafik Bask�\source\repos\Carimatik\MainUIForm\bin\Debug\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

