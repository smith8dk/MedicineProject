using System.ComponentModel;
using Xamarin.Forms;
using MedicineProject.ViewModels;

namespace MedicineProject.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}