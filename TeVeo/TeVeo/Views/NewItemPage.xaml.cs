using System;
using System.Collections.Generic;
using System.ComponentModel;
using TeVeo.Models;
using TeVeo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeVeo.Views
{
   public partial class NewItemPage : ContentPage
   {
      public Item Item { get; set; }

      public NewItemPage()
      {
         InitializeComponent();
         BindingContext = new NewItemViewModel();
      }
   }
}