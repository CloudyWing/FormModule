using System.Text.Json;
using CloudyWing.FormModule.Infrastructure.Util;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.TagHelpers {
    /// <summary>
    /// Custom tag helper for creating dropdown lists with AJAX support.
    /// </summary>
    [HtmlTargetElement("select", Attributes = AjaxUrlAttributeName)]
    public class DropDownListTagHelper : SelectTagHelper {
        private const string AjaxUrlAttributeName = "asp-ajax-url";
        private const string SelectGroupAttributeName = "asp-select-group";
        private const string OptionLabelAttributeName = "asp-option-label";
        private const string NonUsedLabelAttributeName = "asp-non-used-label";
        private const string ChangeCallbackAttributeName = "asp-change-callback";
        private const string ExtraParamsDictionaryName = "asp-all-extra-params";
        private const string ExtraParamsPrefix = "asp-extra-params-";
        private IDictionary<string, string>? extraParams;

        /// <summary>
        /// Creates a new <see cref="DropDownListTagHelper"/>.
        /// </summary>
        /// <param name="generator">The <see cref="IHtmlGenerator"/>.</param>
        public DropDownListTagHelper(IHtmlGenerator generator) : base(generator) { }

        /// <summary>
        /// Gets or sets the URL for AJAX requests.
        /// </summary>
        [HtmlAttributeName(AjaxUrlAttributeName)]
        public string AjaxUrl { get; set; } = default!;

        /// <summary>
        /// Gets or sets the select group.
        /// </summary>
        [HtmlAttributeName(SelectGroupAttributeName)]
        public string SelectGroup { get; set; } = "";

        /// <summary>
        /// Gets or sets the option label.
        /// </summary>
        [HtmlAttributeName(OptionLabelAttributeName)]
        public string? OptionLabel { get; set; }

        /// <summary>
        /// Gets or sets the non-used label.
        /// </summary>
        [HtmlAttributeName(NonUsedLabelAttributeName)]
        public string? NonUsedLabel { get; set; }

        /// <summary>
        /// Gets or sets the change callback.
        /// </summary>
        [HtmlAttributeName(ChangeCallbackAttributeName)]
        public string? ChangeCallback { get; set; }

        /// <summary>
        /// Gets or sets the extra parameters dictionary.
        /// </summary>
        [HtmlAttributeName(ExtraParamsDictionaryName, DictionaryAttributePrefix = ExtraParamsPrefix)]
        public IDictionary<string, string> ExtraParams {
            get {
                extraParams ??= new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

                return extraParams;
            }
            set => extraParams = value;
        }

        /// <inheritdoc />
        public override void Process(TagHelperContext context, TagHelperOutput output) {
            ExceptionUtils.ThrowIfNull(() => context);
            ExceptionUtils.ThrowIfNull(() => output);

            output.Attributes.SetAttribute("data-default-value", For.ModelExplorer.Model?.ToString());
            output.Attributes.SetAttribute("data-select-group", SelectGroup);

            (string Key, string Value)[] pairs = new (string Key, string Value)[] {
                (AjaxUrlAttributeName, AjaxUrl),
                (OptionLabelAttributeName, OptionLabel),
                (NonUsedLabelAttributeName, NonUsedLabel),
                (ChangeCallbackAttributeName, ChangeCallback),
            };

            foreach ((string Key, string Value) in pairs) {
                string dataKey = Key.Replace("asp-", "data-");
                if (!context.AllAttributes.ContainsName(dataKey) && !string.IsNullOrEmpty(Value)) {
                    output.Attributes.Add(dataKey, Value);
                }
            }

            if (extraParams.Any()) {
                string dataKey = ExtraParamsPrefix.Replace("asp-", "data-").TrimEnd('-');
                output.Attributes.Add(dataKey, JsonSerializer.Serialize(ExtraParams));
            }
        }
    }
}
