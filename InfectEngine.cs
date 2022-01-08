using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;

namespace InfecNet
{
    public partial class InfectEngine : Form
    {
        SoundPlayer soundPlayer;
        private Keys[] letterKeys = new Keys[] {
            Keys.A,
            Keys.B,
            Keys.C,
            Keys.D,
            Keys.E,
            Keys.F,
            Keys.G,
            Keys.H,
            Keys.I,
            Keys.J,
            Keys.K,
            Keys.L,
            Keys.M,
            Keys.N,
            Keys.O,
            Keys.P,
            Keys.Q,
            Keys.R,
            Keys.S,
            Keys.T,
            Keys.U,
            Keys.V,
            Keys.W,
            Keys.X,
            Keys.Y,
            Keys.Z
        };

        Keys key;
        Random random;

        public static InfectEngine CreateEngine (){
            return new InfectEngine ();
        }

        private InfectEngine()
        {
            InitializeComponent();
            Init ();
            this.ShowInTaskbar = false;
            this.KeyDown += OnKeyDown;
        }

        private void OnKeyDown (object sender, KeyEventArgs args){
            if (args.KeyCode == key){
                Application.Exit ();
            }
        }

        private void Init (){
            this.ControlBox = false;
            this.Load += FormOnLoad;
            soundPlayer = new SoundPlayer ($"BGM/Max Brhon - Cyberpunk [NCS Release].wav");
            AddIMG ();
            AddText ();
            random = new Random ();
            key = letterKeys [random.Next (0, letterKeys.Length)];
        }

        private void AddText (){
            Label label = new Label ();
            label.Text = "Welcome to InfecNet! You cant close this until you press 1 button on your keyboard!";
            label.ForeColor = Color.Red;
            label.Anchor = AnchorStyles.Top;

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile($"Font/plasdrip.ttf");
            label.Font = new Font (pfc.Families[0], 18, FontStyle.Bold); 

            label.TextAlign = ContentAlignment.TopCenter;
            this.Controls.Add (label);

            label.Size = new Size (label.Parent.ClientSize.Width, 100);
            
            label.Location = new Point ((label.Parent.ClientSize.Width / 2) - (label.Width / 2), 0);
        }

        private void AddIMG (){
            PictureBox pic = new PictureBox ();
            pic.Anchor = AnchorStyles.None;
            pic.Image = Image.FromFile ($"UI/pngfind.com-red-skull-png-616733.png");
            pic.Size = new Size (400, 600);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add (pic);

            pic.Location = new Point ((pic.Parent.ClientSize.Width / 2) - (pic.Width / 2),
            (pic.Parent.ClientSize.Height / 2) - (pic.Height / 2) + 20);
            pic.Refresh ();
        }

        private void FormOnLoad (object sender, EventArgs e){
            this.BackColor = Color.Black;
            soundPlayer.PlayLooping ();
        }
    }
}
