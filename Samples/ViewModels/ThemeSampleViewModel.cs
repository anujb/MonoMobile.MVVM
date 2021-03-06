using System;
using MonoMobile.MVVM;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MonoTouch.Foundation;

namespace Samples
{
	[Preserve(AllMembers = true)]
	public class ThemeSampleViewModel : ViewModel
	{		
		private List<Theme> _Themes = new List<Theme>()
		{
			new AutumnTheme(),
			new BrickedTheme(),
			new CorkTheme(),
			new DenimTheme(),
			new FrostedTheme()
		};
		
		public ObservableCollection<Theme> Themes { get; set; }
		
		public int Selected { get; set; }

		public ThemeSampleViewModel()
		{
			Themes =  new ObservableCollection<Theme>(_Themes);
		}
	}
}

