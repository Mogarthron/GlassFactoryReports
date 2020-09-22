using System;
using System.Collections.Generic;
using System.Text;

namespace BachPlantDesktop
{
    public class PopUpControll
    {
		//PopUpWindow popUp = new PopUpWindow();
		//popUp.Title = "Utworz Komentarz";
		//popUp.Width = 800;
		//popUp.Height = 400;
		//popUp.DataContext = new MennageCommentView();
		//popUp.Show();


		PopUpWindow window;		

		public void PopUpShow()
		{
			window.Show();
		}

		public PopUpControll(string title, int width, int height, Object obj)
		{
			window = new PopUpWindow();

			window.Title = title;
			window.Width = width;
			window.Height = height;
			window.DataContext = obj;
		}
	}
}
