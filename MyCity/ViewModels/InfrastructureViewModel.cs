﻿using System;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using System.IO;
using GalaSoft.MvvmLight;
using MyCity.Models;
using MyCity.Services;
using GalaSoft.MvvmLight.CommandWpf;

namespace MyCity.ViewModels
{
    class InfrastructureViewModel : ViewModelBase
    {
        private Infrastructure infrastructure = new Infrastructure();
        public Infrastructure Infrastructure { get => infrastructure; set => Set(ref infrastructure, value); }

        private BitmapImage image;
        public BitmapImage Image { get => image; set => Set(ref image, value); }

        private readonly INavigationService navigationService;
        private readonly IMessageService messageService;
        private readonly AppDbContext db;

        public InfrastructureViewModel(
            INavigationService navigationService,
            IMessageService messageService,
            AppDbContext db)
        {
            this.navigationService = navigationService;
            this.messageService = messageService;
            this.db = db;
        }

        private RelayCommand browseCommand;
        public RelayCommand BrowseCommand
        {
            get => browseCommand ?? (browseCommand = new RelayCommand(
              () =>
              {
                  OpenFileDialog ofdPicture = new OpenFileDialog();
                  ofdPicture.Filter =
                      "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
                  ofdPicture.FilterIndex = 1;

                  if (ofdPicture.ShowDialog() == true)
                      Image =
                          new BitmapImage(new Uri(ofdPicture.FileName));
              }
              ));
        }

        private RelayCommand sendCommand;
        public RelayCommand SendCommand
        {
            get => sendCommand ?? (sendCommand = new RelayCommand(
              () =>
              {
                  byte[] data;
                  JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                  encoder.Frames.Add(BitmapFrame.Create(Image));
                  using (MemoryStream ms = new MemoryStream())
                  {
                      encoder.Save(ms);
                      data = ms.ToArray();
                  }
                  Infrastructure.Image = data;
                  db.Infrastructures.Add(Infrastructure);
                  db.SaveChanges();

                  navigationService.Navigate<ProblemsViewModel>();
              }
              ));
        }

        private RelayCommand backCommand;
        public RelayCommand BackCommand
        {
            get => backCommand ?? (backCommand = new RelayCommand(
              () =>
              {
                  navigationService.Navigate<ProblemsViewModel>();
              }
              ));
        }

        private RelayCommand watchProblemCommand;
        public RelayCommand WatchProblemCommand
        {
            get => watchProblemCommand ?? (watchProblemCommand = new RelayCommand(
              () =>
              {
                  navigationService.Navigate<InfrastructurePVModel>();
              }
              ));
        }
    }
}
