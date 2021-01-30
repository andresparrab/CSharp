<img src="./joppes_hundarUI.png">

RUN
just download the folder DarkUI and run Form1.exe

If you change anything in the backend/JoppesLib.cs then you haveto recompile it like so: 
mcs -t:library JoppesLib.cs
You will get a JoppesLib.dll
move this file to the DarkUI folder

If you change anything in the DarkUI folder then 
Naviate to the DarkUI folder <br />
Compile the DarkUI app with the reference JoppesLib.dll <br />
The target is windows executable file no console in the background
<br /><br />
mcs *.cs -pkg:dotnet -r:JoppesLib.dll -t:winexe<br />
mono Form1.exe <br />

<br />
create a class lib and compile as a library<br />
dotnet new classlib -o backend <br />
mcs -t:library JoppesLib.cs
