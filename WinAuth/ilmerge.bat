set PP=%~1
set TP=%~2
set OP=%~3
"%PP%ilmerge.exe" /out:"%TP%WinAuth2.exe" /internalize "%TP%WinAuth.exe" "%TP%Authenticator.dll" "%TP%BouncyCastle.Crypto.dll" "%TP%zxing.dll" "%TP%zxing.presentation.dll" "%TP%HtmlRenderer.dll" "%TP%HtmlRenderer.WinForms.dll" "%TP%ICSharpCode.SharpZipLib.dll" "%TP%InputSimulator.dll" "%TP%MetroFramework.Design.dll" "%TP%Newtonsoft.Json.dll" "%TP%NLog.dll"
copy "%TP%winauth2.exe" "%OP%winauth.exe"
copy "%TP%winauth2.pdb" "%OP%winauth.pdb"