﻿#pragma checksum "F:\учеба\3 курс\2ой семестр\Шлемензон_всё\ргр\NewsForum\ShlemenzonRGR\NewsForum\View\MyUserControls\AddCoverPublicationUserControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A7B18F459ED4F158DDE4D9520163B747"
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
    partial class AddCoverPublicationUserControl : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_Xaml_Interactions_Core_ChangePropertyAction_TargetObject(global::Microsoft.Xaml.Interactions.Core.ChangePropertyAction obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.TargetObject = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private class AddCoverPublicationUserControl_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IAddCoverPublicationUserControl_Bindings
        {
            private global::NewsForum.View.MyUserControls.AddCoverPublicationUserControl dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.Xaml.Interactions.Core.ChangePropertyAction obj6;
            private global::Microsoft.Xaml.Interactions.Core.ChangePropertyAction obj7;
            private global::Microsoft.Xaml.Interactions.Core.ChangePropertyAction obj8;

            public AddCoverPublicationUserControl_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 6:
                        this.obj6 = (global::Microsoft.Xaml.Interactions.Core.ChangePropertyAction)target;
                        break;
                    case 7:
                        this.obj7 = (global::Microsoft.Xaml.Interactions.Core.ChangePropertyAction)target;
                        break;
                    case 8:
                        this.obj8 = (global::Microsoft.Xaml.Interactions.Core.ChangePropertyAction)target;
                        break;
                    default:
                        break;
                }
            }

            // IAddCoverPublicationUserControl_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::NewsForum.View.MyUserControls.AddCoverPublicationUserControl)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::NewsForum.View.MyUserControls.AddCoverPublicationUserControl obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_CoverPublicationImage(obj.CoverPublicationImage, phase);
                        this.Update_DeleteImageButton(obj.DeleteImageButton, phase);
                    }
                }
            }
            private void Update_CoverPublicationImage(global::Windows.UI.Xaml.Controls.Image obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Microsoft_Xaml_Interactions_Core_ChangePropertyAction_TargetObject(this.obj6, obj, null);
                    XamlBindingSetters.Set_Microsoft_Xaml_Interactions_Core_ChangePropertyAction_TargetObject(this.obj8, obj, null);
                }
            }
            private void Update_DeleteImageButton(global::Windows.UI.Xaml.Controls.Button obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Microsoft_Xaml_Interactions_Core_ChangePropertyAction_TargetObject(this.obj7, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.Grid element2 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 20 "..\..\..\..\View\MyUserControls\AddCoverPublicationUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)element2).DragStarting += this.CoverPublicationImage_OnDragStarting;
                    #line 21 "..\..\..\..\View\MyUserControls\AddCoverPublicationUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)element2).Drop += this.CoverPublicationImage_OnDrop;
                    #line 22 "..\..\..\..\View\MyUserControls\AddCoverPublicationUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)element2).DragOver += this.CoverPublicationImage_OnDragOver;
                    #line default
                }
                break;
            case 3:
                {
                    this.OpenPickerButton = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    #line 77 "..\..\..\..\View\MyUserControls\AddCoverPublicationUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)this.OpenPickerButton).Tapped += this.OpenPickerButton_Tapped;
                    #line default
                }
                break;
            case 4:
                {
                    this.DeleteImageButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 5:
                {
                    this.CoverPublicationImage = (global::Windows.UI.Xaml.Controls.Image)(target);
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
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    AddCoverPublicationUserControl_obj1_Bindings bindings = new AddCoverPublicationUserControl_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

