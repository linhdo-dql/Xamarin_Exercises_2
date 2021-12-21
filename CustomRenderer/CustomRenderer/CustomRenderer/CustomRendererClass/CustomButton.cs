using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CustomRenderer.CustomRendererClass
{
    public class CustomButton : Button
    {
        //Thêm thuộc tính màu khi IsEnable cho Button
        public static readonly BindableProperty IsEnableColorProperty = BindableProperty.Create("IsEnableColor", typeof(Color), typeof(CustomButton),Color.FromHex("#F2985A"));
        public Color IsEnableColor
        {
            get { return (Color)GetValue(IsEnableColorProperty); }
            set { SetValue(IsEnableColorProperty, value); }
        }
        //Thêm thuộc tính màu khi IsDisable cho Button
        public static readonly BindableProperty IsDisableColorProperty = BindableProperty.Create("IsDisableColor", typeof(Color), typeof(CustomButton), Color.FromHex("#E4E9F2"));
        public Color IsDisableColor
        {
            get { return (Color) GetValue(IsDisableColorProperty); }
            set { SetValue(IsDisableColorProperty, value); }
        }
        

    }
}
