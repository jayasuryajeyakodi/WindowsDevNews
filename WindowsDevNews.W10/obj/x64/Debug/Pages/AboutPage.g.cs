﻿#pragma checksum "C:\Users\kiranban\Source\Repos\WinDevNews3\WindowsDevNews.W10\Pages\AboutPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F4316531FE0085095A4A5B1C4C0EDC5D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsDevNews.Pages
{
    partial class AboutPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_HyperlinkButton_NavigateUri(global::Windows.UI.Xaml.Controls.HyperlinkButton obj, global::System.Uri value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Uri) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Uri), targetNullValue);
                }
                obj.NavigateUri = value;
            }
            public static void Set_Windows_UI_Xaml_UIElement_Visibility(global::Windows.UI.Xaml.UIElement obj, global::Windows.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(global::Windows.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
            public static void Set_Windows_UI_Xaml_Documents_Run_Text(global::Windows.UI.Xaml.Documents.Run obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
        };

        private class AboutPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IAboutPage_Bindings
        {
            private global::WindowsDevNews.Pages.AboutPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj2;
            private global::Windows.UI.Xaml.Controls.TextBlock obj3;
            private global::Windows.UI.Xaml.Controls.HyperlinkButton obj4;
            private global::Windows.UI.Xaml.Controls.HyperlinkButton obj5;
            private global::Windows.UI.Xaml.Controls.StackPanel obj6;
            private global::Windows.UI.Xaml.Controls.HyperlinkButton obj7;
            private global::Windows.UI.Xaml.Controls.HyperlinkButton obj8;
            private global::Windows.UI.Xaml.Controls.HyperlinkButton obj9;
            private global::Windows.UI.Xaml.Documents.Run obj10;
            private global::Windows.UI.Xaml.Controls.Image obj11;
            private global::Windows.UI.Xaml.Documents.Run obj12;

            private AboutPage_obj1_BindingsTracking bindingsTracking;

            public AboutPage_obj1_Bindings()
            {
                this.bindingsTracking = new AboutPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 4:
                        this.obj4 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)target;
                        break;
                    case 5:
                        this.obj5 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)target;
                        break;
                    case 6:
                        this.obj6 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                        break;
                    case 7:
                        this.obj7 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)target;
                        break;
                    case 8:
                        this.obj8 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)target;
                        break;
                    case 9:
                        this.obj9 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)target;
                        break;
                    case 10:
                        this.obj10 = (global::Windows.UI.Xaml.Documents.Run)target;
                        break;
                    case 11:
                        this.obj11 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 12:
                        this.obj12 = (global::Windows.UI.Xaml.Documents.Run)target;
                        break;
                    default:
                        break;
                }
            }

            // IAboutPage_Bindings

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
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            // AboutPage_obj1_Bindings

            public void SetDataRoot(global::WindowsDevNews.Pages.AboutPage newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }
            public void SetConverterLookupRoot(global::Windows.UI.Xaml.FrameworkElement rootElement)
            {
                this.converterLookupRoot = new global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement>(rootElement);
            }

            public global::Windows.UI.Xaml.Data.IValueConverter LookupConverter(string key)
            {
                if (this.localResources == null)
                {
                    global::Windows.UI.Xaml.FrameworkElement rootElement;
                    this.converterLookupRoot.TryGetTarget(out rootElement);
                    this.localResources = rootElement.Resources;
                    this.converterLookupRoot = null;
                }
                return (global::Windows.UI.Xaml.Data.IValueConverter) (this.localResources.ContainsKey(key) ? this.localResources[key] : global::Windows.UI.Xaml.Application.Current.Resources[key]);
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::WindowsDevNews.Pages.AboutPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_AboutThisAppModel(obj.AboutThisAppModel, phase);
                    }
                }
            }
            private void Update_AboutThisAppModel(global::WindowsDevNews.ViewModels.AboutThisAppViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_AboutThisAppModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_AboutThisAppModel_AppName(obj.AppName, phase);
                        this.Update_AboutThisAppModel_AboutText(obj.AboutText, phase);
                        this.Update_AboutThisAppModel_Privacy(obj.Privacy, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_AboutThisAppModel_IsMoreInfoVisible(obj.IsMoreInfoVisible, phase);
                        this.Update_AboutThisAppModel_ViewMoreInfoCommand(obj.ViewMoreInfoCommand, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_AboutThisAppModel_WasLibs(obj.WasLibs, phase);
                        this.Update_AboutThisAppModel_NewtonsoftWeb(obj.NewtonsoftWeb, phase);
                        this.Update_AboutThisAppModel_WindowsAppStudioWeb(obj.WindowsAppStudioWeb, phase);
                        this.Update_AboutThisAppModel_Publisher(obj.Publisher, phase);
                        this.Update_AboutThisAppModel_AppLogo(obj.AppLogo, phase);
                        this.Update_AboutThisAppModel_AppVersion(obj.AppVersion, phase);
                    }
                }
            }
            private void Update_AboutThisAppModel_AppName(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj2, obj, null);
                }
            }
            private void Update_AboutThisAppModel_AboutText(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3, obj, null);
                }
            }
            private void Update_AboutThisAppModel_Privacy(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_HyperlinkButton_NavigateUri(this.obj4, (global::System.Uri) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Uri), obj), null);
                }
            }
            private void Update_AboutThisAppModel_IsMoreInfoVisible(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj5, (global::Windows.UI.Xaml.Visibility)this.LookupConverter("BoolToVisibilityConverter").Convert(obj, typeof(global::Windows.UI.Xaml.Visibility), "true", null));
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj6, (global::Windows.UI.Xaml.Visibility)this.LookupConverter("BoolToVisibilityConverter").Convert(obj, typeof(global::Windows.UI.Xaml.Visibility), null, null));
                }
            }
            private void Update_AboutThisAppModel_ViewMoreInfoCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj5, obj, null);
                }
            }
            private void Update_AboutThisAppModel_WasLibs(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_HyperlinkButton_NavigateUri(this.obj7, (global::System.Uri) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Uri), obj), null);
                }
            }
            private void Update_AboutThisAppModel_NewtonsoftWeb(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_HyperlinkButton_NavigateUri(this.obj8, (global::System.Uri) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Uri), obj), null);
                }
            }
            private void Update_AboutThisAppModel_WindowsAppStudioWeb(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_HyperlinkButton_NavigateUri(this.obj9, (global::System.Uri) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Uri), obj), null);
                }
            }
            private void Update_AboutThisAppModel_Publisher(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Documents_Run_Text(this.obj10, obj, null);
                }
            }
            private void Update_AboutThisAppModel_AppLogo(global::Windows.UI.Xaml.Media.Imaging.BitmapImage obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj11, obj, null);
                }
            }
            private void Update_AboutThisAppModel_AppVersion(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Documents_Run_Text(this.obj12, obj, null);
                }
            }

            private class AboutPage_obj1_BindingsTracking
            {
                global::System.WeakReference<AboutPage_obj1_Bindings> WeakRefToBindingObj; 

                public AboutPage_obj1_BindingsTracking(AboutPage_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<AboutPage_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_AboutThisAppModel(null);
                }

                public void PropertyChanged_AboutThisAppModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    AboutPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::WindowsDevNews.ViewModels.AboutThisAppViewModel obj = sender as global::WindowsDevNews.ViewModels.AboutThisAppViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_AboutThisAppModel_IsMoreInfoVisible(obj.IsMoreInfoVisible, DATA_CHANGED);
                                    bindings.Update_AboutThisAppModel_ViewMoreInfoCommand(obj.ViewMoreInfoCommand, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "IsMoreInfoVisible":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AboutThisAppModel_IsMoreInfoVisible(obj.IsMoreInfoVisible, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "ViewMoreInfoCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AboutThisAppModel_ViewMoreInfoCommand(obj.ViewMoreInfoCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::WindowsDevNews.ViewModels.AboutThisAppViewModel cache_AboutThisAppModel = null;
                public void UpdateChildListeners_AboutThisAppModel(global::WindowsDevNews.ViewModels.AboutThisAppViewModel obj)
                {
                    if (obj != cache_AboutThisAppModel)
                    {
                        if (cache_AboutThisAppModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_AboutThisAppModel).PropertyChanged -= PropertyChanged_AboutThisAppModel;
                            cache_AboutThisAppModel = null;
                        }
                        if (obj != null)
                        {
                            cache_AboutThisAppModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_AboutThisAppModel;
                        }
                    }
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
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    AboutPage_obj1_Bindings bindings = new AboutPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    bindings.SetConverterLookupRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}
