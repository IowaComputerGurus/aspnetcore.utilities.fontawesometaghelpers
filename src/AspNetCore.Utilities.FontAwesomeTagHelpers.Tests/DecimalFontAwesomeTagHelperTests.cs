using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace ICG.AspNetCore.Utilities.FontAwesomeTagHelpers.Tests;

public class DecimalFontAwesomeTagHelperTests : TagHelperTestBase
{
    [Fact]
    public void ShouldRenderProperIconClass_WhenNull_WithDefaultConfiguration()
    {
        //Arrange
        var context = MakeTagHelperContext();
        var output = MakeTagHelperOutput(" ");
        var expectedClass = "fas fa-minus";

        //Act
        var helper = new DecimalFontAwesomeIconTagHelper { Value = null };
        helper.Process(context, output);

        //Assert
        Assert.Equal("span", output.TagName);
        Assert.Equal(expectedClass, output.Attributes["class"].Value);
    }

    [Fact]
    public void ShouldRenderProperIconClass_WhenNull_WithCustomConfiguration()
    {
        //Arrange
        var context = MakeTagHelperContext();
        var output = MakeTagHelperOutput(" ");
        var expectedClass = "fas fa-times";

        //Act
        var helper = new DecimalFontAwesomeIconTagHelper { Value = null, NullValueIconClass = expectedClass };
        helper.Process(context, output);

        //Assert
        Assert.Equal("span", output.TagName);
        Assert.Equal(expectedClass, output.Attributes["class"].Value);
    }

    [Fact]
    public void ShouldRenderProperTagName_WithCustomTagName()
    {
        //Arrange
        var context = MakeTagHelperContext();
        var output = MakeTagHelperOutput(" ");
        var tagName = "i";

        //Act
        var helper = new DecimalFontAwesomeIconTagHelper { Value = null, Tag = tagName };
        helper.Process(context, output);

        //Assert
        Assert.Equal(tagName, output.TagName);
    }

    [Theory]
    [InlineData(100, "", "100")]
    [InlineData(1000, "", "1000")]
    [InlineData(1000, "N1", "1,000.0")]
    public void SHouldRenderProperValue_WhenNotNull(decimal value, string formatString, string expectedValue)
    {
        //Arrange
        var context = MakeTagHelperContext();
        var output = MakeTagHelperOutput(" ");

        //Act
        var helper = new DecimalFontAwesomeIconTagHelper { Value = value, Format = formatString };
        helper.Process(context, output);

        //Assert
        Assert.Equal(expectedValue, output.PostContent.GetContent());
    }
}

