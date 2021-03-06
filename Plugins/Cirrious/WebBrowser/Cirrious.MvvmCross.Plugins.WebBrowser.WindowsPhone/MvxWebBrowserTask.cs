﻿// MvxWebBrowserTask.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System;
using Cirrious.CrossCore.WindowsPhone.Tasks;
using Microsoft.Phone.Tasks;

namespace Cirrious.MvvmCross.Plugins.WebBrowser.WindowsPhone
{
    public class MvxWebBrowserTask : MvxWindowsPhoneTask, IMvxWebBrowserTask
    {
        #region IMvxWebBrowserTask Members

        public void ShowWebPage(string url)
        {
            var webBrowserTask = new WebBrowserTask {Uri = new Uri(url)};
            DoWithInvalidOperationProtection(webBrowserTask.Show);
        }

        #endregion
    }
}