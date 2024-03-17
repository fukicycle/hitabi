using Microsoft.AspNetCore.Components;

namespace Hitabi.Frontend.Components.Cards.Bases
{
    public abstract class CardBase : ComponentBase
    {
        /// <summary>
        /// 説明に表示される文字を指定
        /// </summary>
        [Parameter]
        public string Content { get; set; } = "Content";
    }
}
