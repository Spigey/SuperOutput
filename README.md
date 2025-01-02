# SuperOutput

**My First project written in C#. Make the output brighter!**

SuperOutput is a library designed to make console output more visually appealing and functional. With SuperOutput, you can easily print colorful text and perform many other exciting features. This library aims to improve the user experience when interacting with the terminal or console applications.

## Features

- **Colorful Output**: Print text in various colors to highlight important information.
- **Text Centering**: Easily center text on the screen for better visibility and presentation.
- **Animated Output**: Display text with animations, such as scrolling, flashing, or bouncing effects.
- **Colored Status Indicators**: Display status messages (e.g., `[ OK ]`, `[ ERROR ]`) in different colors to quickly communicate the result.
- **Colored Time Output**: Print the current time in a specific color to keep track of time-based events.
- **Real-Time Time Retrieval**: Get the current time and display it in the desired format or color.
- **Library Health Check**: Built-in checks to ensure the library is functioning properly, preventing potential errors or crashes.


## Installation
- Download SuperOutput.cs from Release
- Move SuperOutput.cs to your project (near Program.cs)

# Example
```csharp
var SuperOutput = new SuperOutput.Init();

if (SuperOutput.IsReady()) {
    SuperOutput.OutputTime(true, ConsoleColor.DarkGray);
    SuperOutput.StatusOutput("OK", ConsoleColor.Green, false, false);
    SuperOutput.ColorOutput(" Hello, World!", ConsoleColor.Green, true, false);
    Thread.Sleep(200);
    SuperOutput.OutputTime(true, ConsoleColor.DarkGray);
    SuperOutput.StatusOutput("OK", ConsoleColor.Green, false, false);
    SuperOutput.AnimatedOutput(" Hi from SuperOutput", ConsoleColor.Magenta, 200, true);
}
```

**Output**:

ㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤ![image](https://github.com/user-attachments/assets/ac20a952-236c-4594-93b2-aac5762ec585)

# License
SuperOutput is licensed under the GNU Affero General Public License v3.0. See the LICENSE file for more details.
