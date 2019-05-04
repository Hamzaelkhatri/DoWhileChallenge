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

namespace App21
{
    [Activity(Label = "alertDialogueC")]
    public class AlertDialogueC : Dialog
    {
        public AlertDialogueC(Activity activity) : base(activity)
        {
            
        }
        public Button Next;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RequestWindowFeature((int)WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.alertdialogue);
            Next = (Button)FindViewById(Resource.Id.button1);
            Next.Click += (e, a) =>
            {
            //code
            };
        }
    }
}
