<img src="./joppes_hundarUI.png">

RUN
<br />
just download the folder DarkUI and run Form1.exe

If you change anything in the backend/JoppesLib.cs then you haveto recompile it like so: 
 <br />
mcs -t:library JoppesLib.cs <br />
You will get a JoppesLib.dll  <br />
move this file to the DarkUI folder

If you change anything in the DarkUI folder then 
Naviate to the DarkUI folder <br />
Compile the DarkUI app with the reference JoppesLib.dll <br />
The target is windows executable file no console in the background
<br /><br />
mcs *.cs -pkg:dotnet -r:JoppesLib.dll -t:winexe<br />
Thun run it in linux:  <br />
mono Form1.exe <br />
for windows just double click the Form1.exe

<br />
to create a class lib<br />
dotnet new classlib -o backend <br />
 compile as a library <br />
mcs -t:library JoppesLib.cs
