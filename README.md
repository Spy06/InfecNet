# InfecNet
A minigame i made with winforms
This is just the source code, you can edit everything you want

All the assets i used is listed below:

- Image used: https://www.pngfind.com/mpng/TJibRb_black-punisher-skull-hd-png-download/
- BGM used: Max Brhon - Cyberpunk
- Font used: plasdrip (From https://1001fonts.com)

## Usage
- Convert the BGM from .mp3 to .wav file
- Create a winform project
- Type ```dotnet new winforms``` in your terminal, this will automatically create a windows form application
- Import the code
- Now go to Program.cs
- Instead of using 
```csharp
Application.Run (new Form1 ());
```
Use this
```csharp
InfectEngine engine = InfectEngine.CreateEngine ();
Application.Run(engine);
```

And thats it, you're done setting up the app!

## Setting The Desktop Wallpaper Through Code
Call this method everywhere you want
```csharp
Extension.SetDesktopWallpaper (filePath);
```
