using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace PixelFix
{
    public partial class FrmMain : Form
    {
        private bool IsFullscreen = false;
        private bool IsWorking = false;
        private Thread RotatorThread = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void cmdAddColor_Click(object sender, EventArgs e)
        {
            ColorDialog ColorPickDialog = new ColorDialog()
            {
                AllowFullOpen = true,
                AnyColor = true,
                SolidColorOnly = true
            };

            if (ColorPickDialog.ShowDialog() != DialogResult.OK)
                return;

            Color SelectedColor = ColorPickDialog.Color;

            ListViewItem ColorItem = new ListViewItem(SelectedColor.Name)
            {
                Tag = SelectedColor
            };

            RotatorSettings.ColorList.Add(SelectedColor);

            lvColors.Items.Add(ColorItem);
        }

        private void cmdRemoveSelected_Click(object sender, EventArgs e)
        {
            if (lvColors.Items.Count == 0 || lvColors.SelectedItems.Count == 0)
                return;

            foreach (ListViewItem I in lvColors.SelectedItems)
            {
                Color CurrentColor = (Color) I.Tag;
                RotatorSettings.ColorList.RemoveAll(c => c == CurrentColor);
                lvColors.Items.Remove(I);
            }
        }

        private void cmdReadMe_Click(object sender, EventArgs e)
        {
            FrmReadMe ReadMeForm = new FrmReadMe();
            ReadMeForm.Show(this);
        }

        private void cmdBegin_Click(object sender, EventArgs e)
        {
            if (RotatorSettings.ColorList.Count < 3)
            {
                MessageBox.Show("You must add at least three (3) colors in the color list to begin.",
                    "Color list error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult ConfirmReadMe =
                MessageBox.Show(
                    "Make sure that you have read the README before proceeding. Serious health risk is possed if you continue without knowledge.\n\nDid you read the README?",
                    "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (ConfirmReadMe != DialogResult.Yes)
                return;


            RotatorThread?.Abort();
         
            ToggleControlVisibility();
            ToggleFullscreen();

            Cursor.Hide();            

            IsWorking = true;

            RotatorThread = new Thread(RotateScreenColor);
            RotatorThread.Start();

            timerThreadStopper.Enabled = true;
            timerThreadStopper.Start();
        }

        private void ToggleFullscreen()
        {
            if (IsFullscreen)
            {
                FormBorderStyle = FormBorderStyle.FixedSingle;
                WindowState = FormWindowState.Normal;
                Size = new Size(323, 340);
                
            }
            else
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                Bounds = Screen.PrimaryScreen.Bounds;
            }

            IsFullscreen = !IsFullscreen;
        }

        private void ToggleControlVisibility()
        {
            foreach (Control C in Controls)            
                C.Visible = !C.Visible;            
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != (int)Keys.Escape) return;

            timerThreadStopper.Enabled = false;
            timerThreadStopper.Stop();

            RotatorThread = null;
            IsWorking = false;

            Cursor.Show();

            ToggleFullscreen();
            ToggleControlVisibility();            
        }

        private void RotateScreenColor()
        {
            while (IsWorking)
            {
                lock (RotatorSettings.ColorList)
                {
                    foreach (Color C in RotatorSettings.ColorList)
                    {
                        Invoke(new MethodInvoker(delegate ()
                        {
                            BackColor = C;
                        }));
                        Thread.Sleep(RotatorSettings.RotationInterval);
                    }
                }
            }

            // For some reason, default(Color) gives the default form designer control color.
            // This will run when we attempt to abort the thread, since the loop will exit.
            BackColor = default(Color);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Add the default colors (Red, Green, Blue)

            ListViewItem RedItem = new ListViewItem("Red") {Tag = Color.Red};
            ListViewItem GreenItem = new ListViewItem("Green") { Tag = Color.Green };
            ListViewItem BlueItem = new ListViewItem("Blue") { Tag = Color.Blue };

            lvColors.Items.AddRange(new [] { RedItem, GreenItem, BlueItem });

            RotatorSettings.ColorList.AddRange(new [] { Color.Red, Color.Green, Color.Blue });
        }

        private void timerThreadStopper_Tick(object sender, EventArgs e)
        {
            RotatorThread = null;
            IsWorking = false;

            Cursor.Show();

            ToggleFullscreen();
            ToggleControlVisibility();

            timerThreadStopper.Enabled = false;
            timerThreadStopper.Stop();
        }

        private void numRotatorDuration_ValueChanged(object sender, EventArgs e)
        {
            RotatorSettings.RotationInterval = Convert.ToInt32(numRotatorDuration.Value)*60*1000*60;
            timerThreadStopper.Interval = RotatorSettings.RotationInterval;
        }
    }
}
