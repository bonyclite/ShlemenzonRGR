﻿#pragma checksum "F:\учеба\3 курс\2ой семестр\Шлемензон_всё\ргр\NewsForum\NewsForum\Pages\EditorPublication\ThirdStepNewsEditorPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4BCF603211F0CBC0C6450617C336AEB7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewsForum.Pages.EditorPublication
{
    partial class ThirdStepNewsEditorPage : 
        global::Windows.UI.Xaml.Controls.Page, 
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
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    #line 13 "..\..\..\..\Pages\EditorPublication\ThirdStepNewsEditorPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)element1).SizeChanged += this.Page_SizeChanged;
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
                    this.VisualStateGroup1 = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 4:
                {
                    this.EditorContentStretch = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5:
                {
                    this.EditorContentCompress = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 6:
                {
                    this.Mobile = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 7:
                {
                    this.SmallDesktop = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 8:
                {
                    this.MiddleDesktop = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 9:
                {
                    this.TitlePageTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.PanelEditDecriptionPublicationUserControl = (global::NewsForum.View.MyUserControls.PanelEditDecriptionPublicationUserControl)(target);
                }
                break;
            case 11:
                {
                    this.sv = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                }
                break;
            case 12:
                {
                    this.PanelAddElementsToPublicGriView = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    #line 113 "..\..\..\..\Pages\EditorPublication\ThirdStepNewsEditorPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridView)this.PanelAddElementsToPublicGriView).ItemClick += this.PanelAddElementsToPublicGriView_ItemClick;
                    #line default
                }
                break;
            case 13:
                {
                    this.AddVideoTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.AddSeparatorTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15:
                {
                    this.AddTextTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16:
                {
                    this.AddImageTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17:
                {
                    this.EditorContentListView = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
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

