using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace ICG.AspNetCore.Utilities.FontAwesomeTagHelpers.Tests;

public class DateTimeFontAwesomeTagHelperTests : TagHelperTestBase
{
    [Fact]
    public void ShouldRenderProperIconClass_WhenNull_WithDefaultConfiguration()
    {
        //Arrange
        var context = MakeTagHelperContext();
        var output = MakeTagHelperOutput(" ");
        var expectedClass = "fas fa-minus";

        //Act
        var helper = new DateTimeFontAwesomeIconTagHelper { Value = null };
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
        var helper = new DateTimeFontAwesomeIconTagHelper { Value = null, NullValueIconClass = expectedClass };
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
        var helper = new DateTimeFontAwesomeIconTagHelper { Value = null, Tag = tagName };
        helper.Process(context, output);

        //Assert
        Assert.Equal(tagName, output.TagName);
    }

    [Fact]
    public void SHouldRenderProperValue_WhenNotNull()
    {
        //Arrange
        var context = MakeTagHelperContext();
        var output = MakeTagHelperOutput(" ");
        var value = new DateTime(2022, 11, 15);

        //Act
        var helper = new DateTimeFontAwesomeIconTagHelper { Value = value };
        helper.Process(context, output);

        //Assert
        Assert.Equal(value.ToString(), output.PostContent.GetContent());
    }

    [Fact]
    public void SHouldRenderProperValue_WhenNotNull_WithFormatString()
    {
        //Arrange
        var context = MakeTagHelperContext();
        var output = MakeTagHelperOutput(" ");
        var value = new DateTime(2022, 11, 15);
        var formatString = "MMdd";
        var expectedValue = "1115";

        //Act
        var helper = new DateTimeFontAwesomeIconTagHelper { Value = value, Format = formatString };
        helper.Process(context, output);

        //Assert
        Assert.Equal(expectedValue, output.PostContent.GetContent());
    }
}
