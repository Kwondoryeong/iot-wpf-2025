using CommunityToolkit.Mvvm.ComponentModel;
using MahApps.Metro.Controls.Dialogs;
using MovieFinder2025.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFinder2025.ViewModels
{
    public partial class MoviesViewModel : ObservableObject
    {
        private readonly IDialogCoordinator dialogCoordinator;
        public MoviesViewModel(IDialogCoordinator coordinator)
        {
            this.dialogCoordinator = coordinator;
            Common.LOGGER.Info("MovieFinder2025 Start.");
        }
    }
}
