﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Hitabi.Frontend.Components.Buttons.Bases
{
    public abstract class ButtonBase : ComponentBase
    {
        /// <summary>
        /// ボタンに表示される文字を指定
        /// </summary>
        [Parameter]
        public string Content { get; set; } = "Button";
        /// <summary>
        /// ボタンがクリックされたときのメソッドを指定
        /// </summary>
        [Parameter]
        public EventCallback<MouseEventArgs> OnClick { get; set; }
    }
}