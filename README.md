# AspNetCore Font Awesome Tag Helpers ![](https://img.shields.io/github/license/iowacomputergurus/aspnetcore.utilities.fontawesometaghelpers.svg)

A collection of TagHelpers for ASP.NET Core that make utilizing the FontAwesome library easier to use for developers

![Build Status](https://github.com/IowaComputerGurus/aspnetcore.utilities.fontawesometaghelpers/actions/workflows/ci-build.yml/badge.svg)

![](https://img.shields.io/nuget/v/icg.aspnetcore.utilities.fontawesometaghelpers.svg) ![](https://img.shields.io/nuget/dt/icg.aspnetcore.utilities.fontawesometaghelpers.svg)

## SonarCloud Analysis

[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=IowaComputerGurus_aspnetcore.utilities.fontawesometaghelpers&metric=alert_status)](https://sonarcloud.io/dashboard?id=IowaComputerGurus_aspnetcore.utilities.fontawesometaghelpers)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=IowaComputerGurus_aspnetcore.utilities.fontawesometaghelpers&metric=coverage)](https://sonarcloud.io/dashboard?id=IowaComputerGurus_aspnetcore.utilities.fontawesometaghelpers)
[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=IowaComputerGurus_aspnetcore.utilities.fontawesometaghelpers&metric=security_rating)](https://sonarcloud.io/dashboard?id=IowaComputerGurus_aspnetcore.utilities.fontawesometaghelpers)
[![Technical Debt](https://sonarcloud.io/api/project_badges/measure?project=IowaComputerGurus_aspnetcore.utilities.fontawesometaghelpers&metric=sqale_index)](https://sonarcloud.io/dashboard?id=IowaComputerGurus_aspnetcore.utilities.fontawesometaghelpers)

## Usage Expecations

These tag helpers are only for markup display, your web project must properly include references to FontAwesome and must abide by all license and other requirements of FontAwesome for the functionality to be utilized here.  For more on how to include FontAwesome within your project please reference their documentation.


## Setup - Registering TagHelpers

You must modify your `_viewimports.cshtml` file by adding

``` html+razor
@addTagHelper *, ICG.AspNetCore.Utilities.FontAwesomeTagHelpers
```

## Included Tag Helpers

The following is a short example of the included tag helpers, for full information on the helpers included, please run the "Samples" app, contained within this repository

### Nullable Type Icon Helpers

These helpers are for nullable types and will either show the value of the object, or a font-awesome icon if there is no value.  Currently we support the following types.

* bool
* DateTime
* decimal
* int
* string

The idea behind these helpers is that you can reduce code such as this

```` razor
@if(Model.UpdatedDate.HasValue)
{
    @Model.UpdatedDate
}
else
{
    <span class="fas fa-minus"></span>
}
````

Down to this

```` html
<date-time-font-awesome-icon Value="@Model.UpdatedDate" />
````