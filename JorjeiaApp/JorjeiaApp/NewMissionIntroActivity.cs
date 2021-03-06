using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace JorjeiaApp
{
    [Activity(Label = "NewMissionIntroActivity")]
    public class NewMissionIntroActivity : Activity
    {
        private Button nextButton; 
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.NewMissionIntro);
            FindViews();

            HandleEvents();
        }
        private void FindViews()
        {
            nextButton = FindViewById<Button>(Resource.Id.nextNMIButton);
        }

        private void HandleEvents()
        {
            nextButton.Click += NextButton_Click;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(NewMissionActivity));
            StartActivity(intent);
        }
    }
}