using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace Express.UI.ERP.Extensions
{
    public class EmailTagHelper : TagHelper
    {
        public string EmailDomain { get; set; } = "legasys.com";
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a"; //informa que a saida vai ser um link no html
            var content = await output.GetChildContentAsync();
            var target = content.GetContent() + "@" + EmailDomain; //formata o endereço de email de saída
            output.Attributes.SetAttribute("href", "mailto:" + target);
            output.Content.SetContent(target);
        }
    }
}
