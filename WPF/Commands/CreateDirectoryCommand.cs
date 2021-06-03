﻿using System.Threading.Tasks;
using WPF.ViewModels;

namespace WPF.Commands
{
    internal class CreateDirectoryCommand : AsyncCommand
    {
        private readonly HomeViewModel _homeViewModel;

        public CreateDirectoryCommand(HomeViewModel homeViewModel)
        {
            _homeViewModel = homeViewModel;
        }

        public override Task ExecuteAsync(object parameter)
        {
            _homeViewModel.DataInputViewModel.Show(DataInputType.DirectoryName);
            _homeViewModel.CreateCommand.Execute(parameter);
            return Task.CompletedTask;
        }
    }
}