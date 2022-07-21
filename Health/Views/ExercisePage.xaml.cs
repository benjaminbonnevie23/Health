using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Health.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExercisePage : ContentPage
    {
        public ExercisePage()
        {
            InitializeComponent();
        }

        public async void DisplayOverhandPU(object obj, EventArgs eventArgs)
        {
            await DisplayAlert("Over-Hand Pull Ups", "Step 1 - Grasp the bar with an overhand grip, arms and shoulders fully extended\nStep 2 - Pull your body up until your chin is above the bar\nStep 3 - Lower your body back to starting position", "Done");
        }
        public async void DisplayUnderhandPU(object obj, EventArgs eventArgs)
        {
            await DisplayAlert("Under-Hand Pull-ups", "Step 1 - Grasp the bar with an underhand grip, arms and shoulders fully extended\nStep 2 - Pull your body up until your chin is above the bar\nStep 3 - Lower your body back to starting position", "Done");
        }
        public async void DisplayPushUps(object obj, EventArgs eventArgs)
        {
            await DisplayAlert("Push-Ups", "Step 1 - Place your hands firmly on the ground, directly under shoulders\nStep 2 - Flatten your back so your entire body is straight and slowly lower your body\nStep 3 - Draw shoulder blades back and down, keeping elbows tucked close to your body\nStep 4 - Exhale as you push back to the starting position\n", "Done");
        }
        public async void DisplayDips(object obj, EventArgs eventArgs)
        {
            await DisplayAlert("Dips", "Step 1 - Hold your body with arms locked above the equipment\nStep 2 - Lower your body slowly while leaning forward, flare out your elbows\nStep 3 - Raise your body above the bars until your arms are locked.", "Done");
        }
        public async void DisplayCrunches(object obj, EventArgs eventArgs)
        {
            await DisplayAlert("Crunches", "Step 1 - Stand straight with your feet together and hands by your sides\nStep 2 - Jump up, spread your feet and bring both hands together above your head\nStep 3 - Jump again and return to the starting position. Repeat until set is complete", "Done");
        }
        public async void DisplayLegRaises(object obj, EventArgs eventArgs)
        {
            await DisplayAlert("Leg Raises", "Step 1 - Lay on your back with your arms palms down on either side\nStep 2 - Keep your legs together and as straight as possible\nStep 3 - Slowly raise your legs to a 90° angle, pause at this position, or as high as you can reach your legs, and then slowly lower your legs back down\nStep 4 - Duration of these movements should be slow so that you do not utilize momentum, enabling you to get the most out of the exercise", "Done");
        }
        public async void DisplayJumpingJacks(object obj, EventArgs eventArgs)
        {
            await DisplayAlert("Inchworms", "Step 1 - You start standing, reach your arms down toward the ground\nStep 2 - walk your hands away from your feet, entering a plank-like position, before stepping your feet forward toward your hands and finally returning to a standing position\nStep 3 - You then continue the worm-like crawl for time or repetitions.", "Done");
        }
        public async void DisplayPlanks(object obj, EventArgs eventArgs)
        {
            await DisplayAlert("Planks", "Step 1 - Lay on the floor with your elbows under your shoulders, hands flat on the floor and core engaged\nStep 2 - Keeping your forearms and knees on the floor slowly raise yourself upwards until your body is in a straight line from your knees to your head\nStep 3 - Hold the position for as long as you can. Don’t worry if you abs muscles start shaking. This is a sign that you are working your abs", "Done");
        }
        public async void DisplaySquats(object obj, EventArgs eventArgs)
        {
            await DisplayAlert("Squats", "Step 1 - Stand with your feet shoulder width apart\nStep 2 - flex your knees and hips and sit back into the squat while lowering your body\nStep 3 - Continue down to full depth\nStep 4 - Return to starting position", "Done");
        }
        public async void DisplayCalfRaises(object obj, EventArgs eventArgs)
        {
            await DisplayAlert("Calf Raises", "Step 1 - Balance on the balls of your feet on the platform or plates, leaning forward to use the wall to assist with balance\nStep 2 - Lower the heels of your feet towards the ground and pause, then push through the balls of your feet like you are standing tip toe, pausing at the apex of the motion\nStep 3 - Repeat as necessary", "Done");
        }

    }
}