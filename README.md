# InfecNet
A minigame i made with winforms
This is just the source code, you can edit everything you want
All the assets i used is listed below:

- Image used: https://www.pngfind.com/mpng/TJibRb_black-punisher-skull-hd-png-download/
- BGM used: Max Brhon - Cyberpunk
- Font used: plasdrip (From https://1001fonts.com)

## Usage
First, create a winform project first
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
