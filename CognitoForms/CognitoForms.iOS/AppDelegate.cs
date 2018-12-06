﻿using System;
using System.Collections.Generic;
using System.Linq;
using Amazon;
using Foundation;
using Plugin.Settings;
using SaltyDog.CognitoForms.App;
using UIKit;
using SaltyDog.CognitoForms.App;
using Plugin.Settings;
using SaltyDog.CognitoForms;
using Amazon.CognitoIdentityProvider;

namespace SaltyDog.CognitoForms.iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();


            var config = new AmazonCognitoIdentityProviderConfig
            {
                HttpClientFactory = new IOSClientFactory()

            };

            config.RegionEndpoint = RegionEndpoint.USEast1; //set your Endpoint

            LoadApplication(new SaltyDog.CognitoForms.App.App(config));

			return base.FinishedLaunching(app, options);
		}
	}
}
