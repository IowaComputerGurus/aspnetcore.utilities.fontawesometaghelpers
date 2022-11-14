using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ICG.AspNetCore.Utilities.FontAwesomeTagHelpers;

/// <summary>
///     A tag helper for rendering a nullable int value as a FontAwesome icon
/// </summary>
public class IntFontAwesomeIconTagHelper : TagHelper
{
    /// <summary>
    ///     The value used to configure the tag helper
    /// </summary>
    public int? Value { get; set; }

    /// <summary>
    ///     The tag that should be used to render the icon
    /// </summary>
    /// <remarks>
    ///     Default value is "span" you may desire to switch to "i"
    /// </remarks>
    public string Tag { get; set; } = "span";

    /// <summary>
    ///     The full FontAwesome css class to be used for a true value
    /// </summary>
    /// <remarks>
    ///     Default value is "fas fa-minus"
    /// </remarks>
    public string NullValueIconClass { get; set; } = "fas fa-minus";

    /// <summary>
    ///     An optional format string for display
    /// </summary>
    public string Format { get; set; } = "";

    /// <summary>
    ///     Renders the tag as desired
    /// </summary>
    /// <param name="context"></param>
    /// <param name="output"></param>
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = Tag;
        if (Value.HasValue)
        {
            output.TagName = null;
            output.TagMode = TagMode.StartTagAndEndTag;
            output.PostContent.SetContent(Value.Value.ToString(Format));
        }
        else
        {
            output.TagName = Tag;
            output.Attributes.Add("class", NullValueIconClass);
        }
    }
}