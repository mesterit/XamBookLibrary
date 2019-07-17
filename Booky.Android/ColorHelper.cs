﻿using System;
using Android.Graphics;
using Booky.Droid;
using Booky.Services;
using ColorThiefDotNet;
using Plugin.CurrentActivity;
using Xamarin.Forms;

[assembly: Dependency(typeof(ColorHelper))]
namespace Booky.Droid
{
    public class ColorHelper : IColorHelper
    {
        public ColorHelper() { }

        public string GetColor(string fileName)
        {
            var colorThief = new ColorThief();
            var theifColor = colorThief.GetColor(BitmapFactory.DecodeResource(
                CrossCurrentActivity.Current.Activity.Resources,
                CrossCurrentActivity.Current.Activity.Resources.GetIdentifier(fileName, "drawable",
                CrossCurrentActivity.Current.Activity.PackageName)), 1).Color;
            return theifColor.ToHexString();
        }
    }
}
