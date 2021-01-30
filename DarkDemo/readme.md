<img src="./joppes_hundarUI.png">


Compile the DarkUI app with the reference JoppesLib.dll and target is windows exe file no console<br />
mcs *.cs -pkg:dotnet -r:JoppesLib.dll -t:winexe<br />
mono Form1.exe <br />
<br />
create a class lib and compile as a library<br />
dotnet new classlib -o backend <br />
mcs -t:library JoppesLib.cs
