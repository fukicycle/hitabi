using Microsoft.AspNetCore.Components;

namespace Hitabi.Frontend.Components.Labels.Bases
{
    public abstract class LabelBase : ComponentBase
    {
        /// <summary>
        /// ラベルに表示される文字を指定
        /// </summary>
        [Parameter]
        public string Content { get; set; } = "Label";
    }
}