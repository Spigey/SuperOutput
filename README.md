<div align="center">
<h1>SuperOutput</h1>
</div>

**My First project written in C#. Make the output brighter!**

SuperOutput is a library designed to make console output more visually appealing and functional. With SuperOutput, you can easily print colorful text and perform many other exciting features. This library aims to improve the user experience when interacting with the terminal or console applications.

<div align="center">
<h2>Features</h1>
</div>

- **Colorful Output**: Print text in various colors to highlight important information.
- **Text Centering**: Easily center text on the screen for better visibility and presentation.
- **Animated Output**: Display text with typing animation.
- **Colored Status Indicators**: Display status messages (e.g., `[ OK ]`, `[ ERROR ]`) in different colors to quickly communicate the result.
- **Colored Time Output**: Print the current time in a specific color to keep track of time-based events.
- **Real-Time Time Retrieval**: Get the current time and display it in the desired format or color.
- **Library Health Check**: Built-in checks to ensure the library is functioning properly, preventing potential errors or crashes.


<div align="center">
<h2>Installation</h1>
</div>

- Download SuperOutput.cs from <a href="https://github.com/localityyy/SuperOutput/releases/tag/superoutput" target="_black">Release</a>
- Move SuperOutput.cs to your project (near Program.cs)

<div align="center">
<h2>Example</h1>
</div>

```csharp
var SuperOutput = new SuperOutput.Init();

if (SuperOutput.IsWorking()) {
    SuperOutput.OutputTime(true, ConsoleColor.DarkGray);
    SuperOutput.StatusOutput("OK", ConsoleColor.Green, false, false);
    SuperOutput.ColorOutput(" Hello, World!", ConsoleColor.Green, true, false);
    Thread.Sleep(200);
    SuperOutput.OutputTime(true, ConsoleColor.DarkGray);
    SuperOutput.StatusOutput("OK", ConsoleColor.Green, false, false);
    SuperOutput.AnimatedOutput(" Hi from SuperOutput", ConsoleColor.Magenta, 200, true);
}
```
![image](https://github.com/user-attachments/assets/ac20a952-236c-4594-93b2-aac5762ec585)

<div align="center">
<h1>Features Showcase</h1>
</div>

<div align="center">
<h2>ColorOutput</h2>
</div>

```csharp
SuperOutput.ColorOutput("Hello World!", userColor: ConsoleColor.Green, shouldWriteAtNewLine: true, centerTextOnlyConsoleApp: false);
```
![image](https://github.com/user-attachments/assets/a3b4d45a-7715-42a6-8b7d-e8d37c276cc2)

<div align="center">
<h2>StatusOutput</h2>
</div>

```csharp
SuperOutput.StatusOutput("OK", userColor: ConsoleColor.Green, shouldWriteAtNewLine: false);
Console.WriteLine();
SuperOutput.StatusOutput("FAIL", userColor: ConsoleColor.Red, shouldWriteAtNewLine: false);
```
![image](https://github.com/user-attachments/assets/72198e8b-b252-4e60-9dcd-ea700d854889)

<div align="center">
<h2>OutputTime</h2>
</div>

```csharp
SuperOutput.OutputTime(withSeconds: true, userColor: ConsoleColor.Magenta, shouldWriteAtNewLine: false, centerTextOnlyConsoleApp: false);
```
![image](https://github.com/user-attachments/assets/da9f728f-4351-44f9-ad32-d8669d274dfc)

<div align="center">
<h2>GetTime</h2>
</div>

```csharp
Console.WriteLine(SuperOutput.GetTime(withSeconds:true));
```
![image](https://github.com/user-attachments/assets/8d994976-81a7-48a6-a7d5-5cafd654327c)


# License
SuperOutput is licensed under the GNU Affero General Public License v3.0. See the LICENSE file for more details.
