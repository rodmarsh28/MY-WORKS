; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "POS"
#define MyAppVersion "1.0.0.2"
#define MyAppPublisher "bl@d3G@geR"
#define MyAppExeName "POSInventory.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{31A1EAF5-FBA4-4D86-A30A-EDF5CC007B58}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={pf}\psi-S0ft\POS
DefaultGroupName=psi-S0ft\POS
OutputDir=C:\Users\MISGWAPOHON\Documents\GitHub\POS-Inventory\POSInventory\New Updte\deployment
OutputBaseFilename=POS1002
SetupIconFile=C:\Users\MISGWAPOHON\Documents\GitHub\POS-Inventory\POSInventory\New Updte\deployment\if_system-software-installer_28708.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\MISGWAPOHON\Documents\GitHub\POS-Inventory\POSInventory\New Updte\POSInventory\bin\Debug\POSInventory.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\MISGWAPOHON\Documents\GitHub\POS-Inventory\POSInventory\New Updte\POSInventory\bin\Debug\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Registry]
Root: HKCU; Subkey: "Software\psi-S0ft"; Flags: uninsdeletekeyifempty
Root: HKCU; Subkey: "Software\psi-S0ft\POS"; Flags: uninsdeletekey
Root: HKLM; Subkey: "Software\psi-S0ft"; Flags: uninsdeletekeyifempty
Root: HKLM; Subkey: "Software\psi-S0ft\POS"; Flags: uninsdeletekey
Root: HKLM; Subkey: "Software\psi-S0ft\POS"; ValueType: string; ValueName: "InstallPath"; ValueData: "{app}"

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

