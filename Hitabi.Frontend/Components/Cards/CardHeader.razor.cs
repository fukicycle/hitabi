using Microsoft.AspNetCore.Components;

namespace Hitabi.Frontend.Components.Cards
{
    public partial class CardHeader : ComponentBase
    {
        /// <summary>
        /// 都道府県を指定
        /// </summary>
        [Parameter]
        public string Prefecture { get; set; } = "Prefecture";
        /// <summary>
        /// 月を指定
        /// </summary>
        [Parameter]
        public string Month { get; set; } = "Month";
        /// <summary>
        /// 宿泊数を指定
        /// </summary>
        [Parameter]
        public string NumberOfStay { get; set; } = "NumberOfStay";
    }
}