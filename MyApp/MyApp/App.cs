using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

using MyApp.CustomControls;

namespace MyApp {
	public class App : Application {
		public App() {
			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					HorizontalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							HorizontalTextAlignment = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!"
						},
						new Button {
							Text = "Button"
						},
						new Button {
							Text = "ButtonBG",
							BackgroundColor = Color.Red
						},
						new CustomButton {
							Text = "CustomButton"
						},
						new CustomButton {
							Text = "CustomButtonBG",
							BackgroundColor = Color.Red
						}
					}
				}
			};
		}

		protected override void OnStart() {
			// Handle when your app starts
		}

		protected override void OnSleep() {
			// Handle when your app sleeps
		}

		protected override void OnResume() {
			// Handle when your app resumes
		}
	}
}
