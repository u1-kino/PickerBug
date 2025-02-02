This program reproduces the following .NET MAUI issue:
https://github.com/dotnet/maui/issues/27519

Additionally, in [MauiProgram.cs](https://github.com/u1-kino/PickerBug/blob/main/MauiApp1/MauiProgram.cs),
if you uncomment the following lines:

```
#if MACCATALYST
    // Uncomment this handler
    // Workaround for Picker not updating SelectedItem on Mac Catalyst 
    handlers.AddHandler(typeof(Picker), typeof(FixPickerHandler));
#endif
```

[FixPickerHandler.cs](https://github.com/u1-kino/PickerBug/blob/main/MauiApp1/Platforms/MacCatalyst/FixPickerHandler.cs)  
The program will load FixPickerHandler, which provides a workaround to prevent the issue from occurring.
