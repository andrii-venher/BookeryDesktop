﻿using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Domain.Models;
using WPF.Common;

namespace WPF.Controls
{
    /// <summary>
    ///     Interaction logic for ItemControl.xaml
    /// </summary>
    public partial class ItemControl : UserControl
    {
        private readonly ICommand _loadItemsCommand;
        private readonly ICommand _updateCurrentItemCommand;

        public ItemControl(Item item, ICommand loadItemsCommand, ICommand updateCurrentItemCommand)
        {
            Item = item;
            Image = ItemImageHelper.GetImage(item);
            _loadItemsCommand = loadItemsCommand;
            _updateCurrentItemCommand = updateCurrentItemCommand;
            InitializeComponent();
        }

        public Item Item { get; set; }
        public BitmapImage Image { get; set; }

        private void ItemControl_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _loadItemsCommand.Execute(Item.Path);
            _updateCurrentItemCommand.Execute(Item);
        }
    }
}