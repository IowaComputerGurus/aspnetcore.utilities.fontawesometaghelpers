using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICG.AspNetCore.Utilities.FontAwesomeTagHelpers.Tests;

public abstract class TagHelperTestBase
{
    public TagHelperContext MakeTagHelperContext(TagHelperAttributeList attributes = null)
    {
        attributes = attributes ?? new TagHelperAttributeList();

        return new TagHelperContext(
            tagName: "span",
            allAttributes: attributes,
            items: new Dictionary<object, object>(),
            uniqueId: Guid.NewGuid().ToString("N"));
    }

    public TagHelperOutput MakeTagHelperOutput(
        string tagName,
        TagHelperAttributeList attributes = null,
        string childContent = null)
    {
        attributes = attributes ?? new TagHelperAttributeList();

        return new TagHelperOutput(
            tagName,
            attributes,
            getChildContentAsync: (useCachedResult, encoder) =>
            {
                var tagHelperContent = new DefaultTagHelperContent();
                tagHelperContent.SetContent(childContent);
                return Task.FromResult<TagHelperContent>(tagHelperContent);
            });
    }
}
