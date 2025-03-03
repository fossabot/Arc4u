# Arc4u

SonarCloud info </br>

> [![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=GFlisch_Arc4u&metric=vulnerabilities)](https://sonarcloud.io/summary/new_code?id=GFlisch_Arc4u) [![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Fmichaeldorner%2FArc4u.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Fmichaeldorner%2FArc4u?ref=badge_shield)
</br>
> [![Bugs](https://sonarcloud.io/api/project_badges/measure?project=GFlisch_Arc4u&metric=bugs)](https://sonarcloud.io/summary/new_code?id=GFlisch_Arc4u) </br>
>[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=GFlisch_Arc4u&metric=security_rating)](https://sonarcloud.io/summary/new_code?id=GFlisch_Arc4u)


## Arc4u is a framework to ease the development of .NET applications. 
  
Its target is not to do what the .NET framework 6, 7and 8 ar doing but more to select some technologies from the .NET framework and use them to bring value for a developer.
  
The framework has been started from a while (more than 20 years) when the framework was .Net. 
After years of use in different companies I have decided to publish it on Github. This to give visibility but also to have more adoption and increase the quality.

All the companies have the same issues and are building frameworks to ease the developers and integrate standards in enterprises. So have a look on it, may be it will be interesting for you.  

The framework is covering different aspects but its main goal is not to reinvent the wheel and more the .NET framework is improving, some part of the Arc4u framework are dropped.  

The framework is also used by a commercial product (licensed) the [Arc4u.Guidance](https://github.com/gflisch/arc4u.guidance.doc) available on the Visual Studio market. This product generates a C# .NET solution based on micro-services.  

## An example of what the framework does.

The framework is extending the ILogger\<T\> to add capabilities.

ILogger\<T> logger = ...

logger.Technical().Information("The message").Add("key, value).AddIf(true, key, value)..Log();

The logging fluent API eases the creation of categorized logs (Tecnical, business and for monitoring).
There is also the capability to add to the logging extra information.

The Guidance tool will generate the code needed to link the Microsoft logging to Serilog. The guidance is using the Arc4u.Standard.Diagnostics nuget package of the framework.

You will find more info on the [Guidance doc repo](https://github.com/gflisch/arc4u.guidance.doc).

Gilles



## License
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Fmichaeldorner%2FArc4u.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Fmichaeldorner%2FArc4u?ref=badge_large)