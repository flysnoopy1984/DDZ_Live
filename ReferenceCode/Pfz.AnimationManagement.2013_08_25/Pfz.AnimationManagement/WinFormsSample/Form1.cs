using System.Drawing;
using System.Windows.Forms;
using Pfz.AnimationManagement;
using Pfz.AnimationManagement.WinForms;

namespace WinFormsSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Initializer.Initialize();

            var animation = 
                AnimationBuilder.
                    BeginParallel().
                       BeginProgressiveTimeMultipliers(0.1).
                                    MultiplySpeed(1, 0.25).
                                    KeepSpeed(0.5).
                                    MultiplySpeed(0.1, 0.25).
                                    BeginSequence().
                                        Range(0, 100, 0.5, (value) => label.Left = value).
                                        Range(100, 200, 0.5, (value) => label.Left = value).
                                    EndSequence().
                                EndProgressiveTimeMultipliers().
                                BeginProgressiveTimeMultipliers(0.1).
                                    MultiplySpeed(1, 0.25).
                                    KeepSpeed(0.5).
                                    MultiplySpeed(0.1, 0.25).
                                    BeginSequence().
                                        Range(200, 100, 0.5, (value) => label.Top = value).
                                        Range(100, 0, 0.5, (value) => label.Top = value).
                                    EndSequence().
                                EndProgressiveTimeMultipliers().
                        BeginLoop().
                            BeginSequence().

                            EndSequence().
                        EndLoop().
                        BeginLoop().
                            BeginSequence().
                                Range(0, 500, 5, (value) => label.Left = value).
                                Range(500, 0, 5, (value) => label.Left = value).
                            EndSequence().
                        EndLoop().
                        BeginLoop().
                            BeginRanges((color) => label.ForeColor = color, Color.Black).
                                To(Color.Red, 1).
                                To(Color.Green, 1).
                                Wait(1).
                                To(Color.Blue, 1).
                                To(Color.Black, 1).
                            EndRanges().
                        EndLoop().
                    EndParallel();

            AnimationManager.Add(animation);
        }
    }
}
