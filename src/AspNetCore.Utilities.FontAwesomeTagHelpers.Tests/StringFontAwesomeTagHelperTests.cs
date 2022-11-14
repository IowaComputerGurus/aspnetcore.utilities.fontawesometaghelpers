using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ICG.AspNetCore.Utilities.FontAwesomeTagHelpers.Tests;

public class StringFontAwesomeTagHelperTests : TagHelperTestBase
{
    [Fact]
    public void ShouldRenderProperIconClass_WhenNull_WithDefaultConfiguration()
    {
        //Arrange
        var context = MakeTagHelperContext();
        var output = MakeTagHelperOutput(" ");
        var expectedClass = "fas fa-minus";

        //Act
        var helper = new StringFontAwesomeIconTagHelper { Value = null };
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
        var helper = new StringFontAwesomeIconTagHelper { Value = null, NullValueIconClass = expectedClass };
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
        var helper = new StringFontAwesomeIconTagHelper { Value = null, Tag = tagName };
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
        var value = "My Value";

        //Act
        var helper = new StringFontAwesomeIconTagHelper { Value = value};
        helper.Process(context, output);

        //Assert
        Assert.Equal(value, output.PostContent.GetContent());
    }
}
