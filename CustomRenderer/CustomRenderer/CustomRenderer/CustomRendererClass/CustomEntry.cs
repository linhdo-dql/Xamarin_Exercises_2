using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CustomRenderer.CustomRendererClass
{
    /// <summary>
    /// Thêm border và bo tròn Entry
    /// </summary>
    public class CustomEntry : Entry
    {
        //Thêm thuộc tính màu viền vào Entry gốc
        public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(
            "BorderColor"
            ,typeof(Color)
            ,typeof(CustomEntry)
            ,Color.FromHex("#929292"));
        //Getter và Setter cho thuộc tính màu viền
        public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty);} 
            set { SetValue(BorderColorProperty, value);}
        }
        //Thêm thuộc tính độ dày của viền vào Entry gốc
        public static readonly BindableProperty BorderWidthProperty = BindableProperty.Create(
            "BorderWidth",
            typeof(int),
            typeof(CustomEntry),
            1
            );
        //Getter và setter cho thuộc tính độ dày viền
        public int BorderWidth
        {
            get { return (int) GetValue(BorderWidthProperty);}
            set { SetValue(BorderWidthProperty, value);}
        }
        //Thêm thuộc tính bo tròn cho Entry gốc
        public static readonly BindableProperty CornerRadiusProperty = BindableProperty.Create(
            "CornerRadius",
            typeof (int),
            typeof (CustomEntry),
            0);
        //Getter và Setter cho thuộc tính bo góc của Entry
        public int CornerRadius
        {
            get { return (int) GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value);}
        }
    }
}
