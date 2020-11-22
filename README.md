# TP-Link API
API in .NET core 3.1 to communicate with the TP-Link HS100/HS110 wifi controlled power outlet

## Version History

0.1 - released november 22, 2020


## System Requirements

This API is built using the Microsoft .NET core framework and is fully asynchronous

## Usage Instructions

To communicate with TP-Link HS100/HS110, add the NuGet package to your solution and add a using reference in your code:

```C#
using Ealse.TPLink.Api;
```

Then create a new TPLinkClient instance using:

```C#
using var client = new TPLinkClient();
// or 
using var client = new TPLinkClient("token");
```

You can call one of the methods on the client instance to send or retrieve data, i.e.:

```C#
// Retrieves a token for the logged in user
await client.LoginAsync("your@email.com", "yourpassword");

// if not set
client.Token = loginResponse.Result.Token;
```

To retrieve information of all the TP-Link devices:

```C# 
await client.GetDevicesAsync();
```

To retrieve realtime data and system information for the given device:

```C#
await client.GetRealTimeAndSysInfoAsync(DeviceId);
```

To set the relay state of the TP-Link HS100/HS110:

```C#
await client.SetRelayStateAsync(devices.Result?.DeviceList?.FirstOrDefault()?.DeviceId, 1);
```

## Available via NuGet

You can also pull this API in as a NuGet package by adding "Ealse.TPLink.Api" or running:

Install-Package Ealse.TPLink.Api

Package statistics: https://www.nuget.org/packages/Ealse.TPLink.Api

## Feedback

Any kind of feedback is welcome!