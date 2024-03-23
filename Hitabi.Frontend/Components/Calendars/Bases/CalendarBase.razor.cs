using Microsoft.AspNetCore.Components;

namespace Hitabi.Frontend.Components.Calendars.Bases
{
    public abstract class CalendarBase : ComponentBase
    {
        /// <summary>
        /// 日付を指定
        /// </summary>
        [Parameter]
        public string Day { get; set; } = "1";
    }
}