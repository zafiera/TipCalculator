using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;

namespace TipCalculator
{
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
	public class MainActivity : AppCompatActivity
	{
        EditText inputBill;
        Button calculateButton;
        TextView outputTip;
        TextView outputTotal;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            inputBill = FindViewById<EditText>(Resource.Id.inputBill);
            outputTip = FindViewById<TextView>(Resource.Id.outputTip);
            outputTotal = FindViewById<TextView>(Resource.Id.outputTotal);
            calculateButton = FindViewById<Button>(Resource.Id.calculateButton);

            calculateButton.Click += OnClickCalculate;
        }

        private void OnClickCalculate(object sender, EventArgs e)
        {
            string userInput = inputBill.Text;
            double bill;
            if (double.TryParse(userInput, out bill))
            {
                double tip = bill * 0.15;
                double total = tip + bill;
                outputTip.Text = tip.ToString();
                outputTotal.Text = total.ToString();
            }

        }
    }
}

