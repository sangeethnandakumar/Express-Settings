# Express-Settings
Express settings allows you to create very quick persistant settings in your .NET core app

ExpressSettingsCore is the .NET Core implementatio of Express Settings. Express settings allows you quick prototyping of applications that relies on fetching configurations from settings file. Express settings is seamless to integrate and requires mearly 1 line to read or write settings. It creates readable intented JSON based settings and can be called from anywhere your application.

### Package Manager
The library is available free on NuGet

```nuget
If you are on .Net Framework
Install-Package Twileloop.ExpressSettings -Version 1.0.0

Or, If you are on .Net Core
Install-Package Twileloop.ExpressSettingsCore -Version 1.0.0
```

> The Implementation on ExpressSettings and ExpressSettingsCore are same on any platforms

### Repository Contents
This repo maintains 3 projects. The .NET Framework library, .NET Core library and a demo project to implement it


### Create Your Settings Object
Create your settings class with the whatever properties you want to persist
> NOTE: Make sure you have a constructor on your settings class that initialises to the default settings value.
> The library will create a defaut instance of settings from the constructor if it can't find an already persisted settings.
```csharp
public class MySettings 
{
  public bool EnableApp {get; set;}
  public List < string > Blocklists {get; set;}
  public string URL {get; set;}
  public Debugging Debug {get; set;}

  //Initlaise default settings values
  public MySettings() {
    EnableApp = true;
    Blocklists = new List < string > ();
    URL = "https://default.com";
    Debug = new Debugging();
  }
}


public class Debugging 
{
  public bool EnableVerboseLogging {get; set;}
  public bool EnableTestMode {get; set;}

  //Initlaise default settings values
  public Debugging() {
    EnableTestMode = false;
    EnableVerboseLogging = true;
  }
}
```

## Read/Write Settings Anywhere
Once you have your settings model class, Simply call the ExpressSettings to read or write your settings at valid points on your application. No complexities.
```csharp
//Read settings (this will return a default instance of 'MySettings' if no persisted settings available)
var settings = Settings<MySettings>.Read();
```
```csharp
//Your settings
var settings = new MySettings 
{
  EnableApp = true,
  Blocklists = new List <string> {"List A","List B", "List C", "List D"}, 
  URL = url.Text,
  Debug = new Debugging 
  {
    EnableTestMode = false,
    EnableVerboseLogging = true
  }
};

//Write settings
Settings<MySettings>.Write(settings);
```
