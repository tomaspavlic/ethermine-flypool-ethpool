# Generic pool API client for Ethpool, Ethermine & Flypool

[![Build status](https://ci.appveyor.com/api/projects/status/dnp9i3t6sexv9tpa?svg=true)](https://github.com/tomaspavlic/ethermine-flypool-ethpool)

Supported on the .NET Standard 1.3 (https://docs.microsoft.com/en-us/dotnet/articles/standard/library) compatible .NET runtimes: .NET Core, .NET Framework 4.6, Universal Windows Platform, Xamarin.

This project makes your Microsoft .NET applications able to interact with the Application Programming Interface (API) of ethpool, ethermine a& flypool. The class library is written in C#.

Api capabilities described here (https://api.ethermine.org/docs)

#### Implementing
Below are basic examples of how to use generic api client. Other main classes for other pools are Ethermine, Ethpool & Flypool.

```cs
var ethermine = new Ethermine();
var miner = ethermine.GetMiner("0x97ca8a408e0f9315fa46c0d3d5e45956ac1ac7fe");
var payouts = await _miner.GetPayoutsAsync();
...
```

#### Dependencies
Newtonsoft.Json 10.0.9+ ([nuget link](https://www.nuget.org/packages/newtonsoft.json/#dotnet-cli))

Contributions and bugs reports are welcome.

> Please feel free to donate to me. I'm not going to force you to donate, you can use my software completely free of charge and without limitation for any purpose you want. If you really want to give something to me then you are welcome to do so. I don't expect donations, nor do I insist that you give them. Ethereum wallet for donation 97ca8a408e0f9315fa46c0d3d5e45956ac1ac7fe

