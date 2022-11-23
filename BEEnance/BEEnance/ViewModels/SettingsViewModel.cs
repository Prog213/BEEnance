// <copyright file="SettingsViewModel.cs" company="InternetWideWorld.com">
// Copyright (c) George Leithead, InternetWideWorld.com
// </copyright>

namespace BEEnance.ViewModels
{
	using System;
	using System.Collections.Generic;
	using System.Globalization;
	using System.Linq;
	using System.Threading.Tasks;
	using Xamarin.Essentials;
	using Xamarin.Forms;

	/// <summary>Settings view model.</summary>
	public class SettingsViewModel : BaseViewModel
	{
		/// <summary>Initialises a new instance of the <see cref="SettingsViewModel"/> class.</summary>
		public SettingsViewModel()
		{
			;
		}

		/// <summary>Gets a value indicating whether dark theme is enabled.</summary>
		public bool ThemeDark => Application.Current.UserAppTheme == OSAppTheme.Dark;

		/// <summary>Gets a value indicating whether light theme is enabled.</summary>
		public bool ThemeLight => Application.Current.UserAppTheme == OSAppTheme.Light;

		/// <summary>Gets a value indicating whether system theme is enabled.</summary>
		public bool ThemeSystem => Application.Current.UserAppTheme == OSAppTheme.Unspecified;
	}
}