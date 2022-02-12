# aspnetcore.utilities.fontawesometaghelpers ![](https://img.shields.io/github/license/iowacomputergurus/aspnetcore.utilities.fontawesometaghelpers.svg)

![Build Status](https://github.com/IowaComputerGurus/aspnetcore.utilities.fontawesometaghelpers/actions/workflows/ci-build.yml/badge.svg)

![](https://img.shields.io/nuget/v/icg.aspnetcore.utilities.fontawesometaghelpers.svg) ![](https://img.shields.io/nuget/dt/icg.aspnetcore.utilities.fontawesometaghelpers.svg)


A collection of TagHelpers for ASP.NET Core that make utilizing the FontAwesome library easier to use for developers

## Usage Expecations

These tag helpers are only for markup display, your web project must properly include references to FontAwesome and must abide by all licese and other requirements of FontAwesome for the functionality to be utilized here.  For more on how to include FontAwesome within your project please reference their documentation.


## Setup - Registering TagHelpers

You must modify your `_viewimports.cshtml` file by adding

``` html+razor
@addTagHelper *, ICG.AspNetCore.Utilities.FontAwesomeTagHelpers
```

## Included Tag Helpers

The following is a short example of the included tag helpers, for full information on the helpers included, please run the "Samples" app.

### HideCondition 
This tag helper will show a font-awesome check or x based on the boolean value provided.

``` html
<bool-font-awesome-icon value="true"/>
```