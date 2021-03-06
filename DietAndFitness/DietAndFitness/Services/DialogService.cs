﻿using DietAndFitness.Interfaces;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DietAndFitness.Services
{
    /// <summary>
    /// Class that is used to display various dialog messages from the ViewModel
    /// </summary>
    public class DialogService : IDialogService
    {
        public async Task ShowError(string message,
            string title,
            string buttonText,
            Action afterHideCallback)
        {
            await Application.Current.MainPage.DisplayAlert(
                title,
                message,
                buttonText);

            afterHideCallback?.Invoke();
        }

        public async Task ShowError(
            Exception error,
            string title,
            string buttonText,
            Action afterHideCallback)
        {
            await Application.Current.MainPage.DisplayAlert(
                title,
                error.Message,
                buttonText);

            afterHideCallback?.Invoke();
        }

        public async Task ShowMessage(
            string message,
            string title)
        {
            await Application.Current.MainPage.DisplayAlert(
                title,
                message,
                "OK");
        }

        public async Task ShowMessage(
            string message,
            string title,
            string buttonText,
            Action afterHideCallback)
        {
            await Application.Current.MainPage.DisplayAlert(
                title,
                message,
                buttonText);

            afterHideCallback?.Invoke();
        }

        public async Task<bool> ShowMessage(
            string message,
            string title,
            string buttonConfirmText,
            string buttonCancelText,
            Action<bool> afterHideCallback)
        {
            var result = await Application.Current.MainPage.DisplayAlert(
                title,
                message,
                buttonConfirmText,
                buttonCancelText);

            afterHideCallback?.Invoke(result);
            return result;
        }

        public async Task<bool> ShowMessage(string message, string title, string buttonConfirmText, string buttonCancelText, Func<bool, Task> afterHideCallback)
        {
            var result = await Application.Current.MainPage.DisplayAlert(
               title,
               message,
               buttonConfirmText,
               buttonCancelText);

            if (afterHideCallback != null)
            {
                await afterHideCallback(result);
            }
            return result;
        }

        public async Task ShowMessageBox(
            string message,
            string title)
        {
            await Application.Current.MainPage.DisplayAlert(
                title,
                message,
                "OK");
        }
    }
    #region Command Dialog Service Example 
    //public RelayCommand ConfirmCommand
    //{
    //    get
    //    {
    //        return _confirmCommand
    //               ?? (_confirmCommand = new RelayCommand(
    //                   async () =>
    //                   {
    //                       await _dialogService.ShowMessage("Does dialog callback work?",
    //                          "Callback Test",
    //                          "Yup",
    //                          "Nope",
    //                           (r) => { _dialogService.ShowMessage("Result: " + r.ToString(), "Result", "OK", null); });
    //                   }));
    //    }
    //}
    #endregion

}
