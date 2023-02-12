#### [CloudyWing.FormModule.Infrastructure](index.md 'index')
### [CloudyWing.FormModule.Infrastructure.Util](CloudyWing.FormModule.Infrastructure.Util.md 'CloudyWing.FormModule.Infrastructure.Util')

## DateTimeOffsetUtils Class

Provides utility methods for working with [System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset') in the Taipei time zone.

```csharp
public static class DateTimeOffsetUtils
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DateTimeOffsetUtils
### Properties

<a name='CloudyWing.FormModule.Infrastructure.Util.DateTimeOffsetUtils.TaipeiTimeZone'></a>

## DateTimeOffsetUtils.TaipeiTimeZone Property

Gets the [System.TimeZoneInfo](https://docs.microsoft.com/en-us/dotnet/api/System.TimeZoneInfo 'System.TimeZoneInfo') for Taipei.

```csharp
public static System.TimeZoneInfo TaipeiTimeZone { get; }
```

#### Property Value
[System.TimeZoneInfo](https://docs.microsoft.com/en-us/dotnet/api/System.TimeZoneInfo 'System.TimeZoneInfo')
### Methods

<a name='CloudyWing.FormModule.Infrastructure.Util.DateTimeOffsetUtils.GetTaipeiNow()'></a>

## DateTimeOffsetUtils.GetTaipeiNow() Method

Gets the current date and time in Taipei time zone.

```csharp
public static System.DateTimeOffset GetTaipeiNow();
```

#### Returns
[System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset')  
The current [System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset') in Taipei time zone.

<a name='CloudyWing.FormModule.Infrastructure.Util.DateTimeOffsetUtils.GetTaipeiNowWithoutSeconds()'></a>

## DateTimeOffsetUtils.GetTaipeiNowWithoutSeconds() Method

Gets the current date and time in Taipei time zone without seconds.

```csharp
public static System.DateTimeOffset GetTaipeiNowWithoutSeconds();
```

#### Returns
[System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset')  
The current [System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset') in Taipei time zone without seconds.

<a name='CloudyWing.FormModule.Infrastructure.Util.DateTimeOffsetUtils.GetTaipeiToday()'></a>

## DateTimeOffsetUtils.GetTaipeiToday() Method

Gets the current date in Taipei time zone with time set to 00:00:00.

```csharp
public static System.DateTimeOffset GetTaipeiToday();
```

#### Returns
[System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset')  
The current [System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset') in Taipei time zone with time set to 00:00:00.