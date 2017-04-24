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
    [Activity(Label = "NewMissionActivity")]
    public class NewMissionActivity : Activity
    {

        private Spinner skinSpinner;
        private Spinner missionsSpinner;
        private TextView description;
        private TextView missionText;
        private TextView skinText;
        private TextView ageText;
        private EditText ageEditText;
        private Button nextButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.NewMission);

            FindViewById();

            FillSpinners();
            HandleEvents();
        }

        private void FindViewById()
        {
            skinSpinner = FindViewById<Spinner>(Resource.Id.spinnerSkinType);
            missionsSpinner = FindViewById<Spinner>(Resource.Id.spinnerMissionsType);
            //description = FindViewById<TextView>(Resource.Id.descriptionTextView);
            //missionText = FindViewById<TextView>(Resource.Id.missionTextView);
            //skinText = FindViewById<TextView>(Resource.Id.skinTextView);
            //ageText = FindViewById<TextView>(Resource.Id.ageTextView);
            ageEditText = FindViewById<EditText>(Resource.Id.ageEditTextView);
        }

        protected void FillSpinners()
        {
            var SkinType = new string[]
            {
                "Суха кожа","Нормална кожа"
            };
            var missions = new string[]
            {
                "Мисия 1", "Мисия 2","Мисия 3","Мисия 1 FOR MEN"
            };
            skinSpinner.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerDropDownItem, SkinType);
            missionsSpinner.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerDropDownItem, missions);
        }


        private void FindViews()
        {
            nextButton = FindViewById<Button>(Resource.Id.nextNMButton);
        }

        private void HandleEvents()
        {
            nextButton.Click += NextButton_Click;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //var intent = new Intent(this, typeof(CameraActivity));
            //StartActivity(intent);
        }
    }
}