﻿#pragma checksum "F:\учеба\3 курс\2ой семестр\Шлемензон_всё\ргр\NewsForum\ShlemenzonRGR\NewsForum\View\MyUserControls\PanelEditDecriptionPublicationUserControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F7F59B71F05FA5091735410F7B100F07"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewsForum.View.MyUserControls
{
    partial class PanelEditDecriptionPublicationUserControl : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.PanelEditDecriptionGridView = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    #line 15 "..\..\..\..\View\MyUserControls\PanelEditDecriptionPublicationUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridView)this.PanelEditDecriptionGridView).ItemClick += this.PanelEditDecriptionGridView_ItemClick;
                    #line default
                }
                break;
            case 2:
                {
                    this.VisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 3:
                {
                    this.SmallDesktop = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4:
                {
                    this.MiddleDesktop = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5:
                {
                    this.FontSizeComboBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 44 "..\..\..\..\View\MyUserControls\PanelEditDecriptionPublicationUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.FontSizeComboBox).SelectionChanged += this.FontSizeComboBox_SelectionChanged;
                    #line default
                }
                break;
            case 6:
                {
                    this.AddLinkToTextButton = (global::Windows.UI.Xaml.Controls.GridViewItem)(target);
                    #line 83 "..\..\..\..\View\MyUserControls\PanelEditDecriptionPublicationUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridViewItem)this.AddLinkToTextButton).Tapped += this.AddLinkToTextButton_Tapped;
                    #line default
                }
                break;
            case 7:
                {
                    this.RightAlignTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.CenterAlignTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.LeftAlignTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.AddLinkTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.LinkPanelFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                }
                break;
            case 12:
                {
                    this.LinkTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 13:
                {
                    this.UnderlineTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.BoldTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15:
                {
                    this.ItalickTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

