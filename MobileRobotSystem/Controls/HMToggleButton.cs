using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace MoblieRobotSystem.Controls
{
    public class HMToggleButton : CheckBox
    {
        //Fields
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;
        private bool solidStyle = true;

        //Properties
        [Category("HM Code Advance")]
        public Color OnBackColor { get => onBackColor; set { onBackColor = value; Invalidate(); } }
        [Category("HM Code Advance")]
        public Color OnToggleColor { get => onToggleColor; set { onToggleColor = value; Invalidate(); } }
        [Category("HM Code Advance")]
        public Color OffBackColor { get => offBackColor; set { offBackColor = value; Invalidate(); } }
        [Category("HM Code Advance")]
        public Color OffToggleColor { get => offToggleColor; set { offToggleColor = value; Invalidate(); } }
        [Category("HM Code Advance")]
        public override string Text { get { return base.Text; } set { } }

        [DefaultValue(true)]
        public bool SolidStyle { get { return solidStyle; } set { solidStyle = value; Invalidate(); } }

        //Constructor
        public HMToggleButton()
        {
            MinimumSize = new Size(35, 22);
        }

        //Methods
        private GraphicsPath GetFigurePath()
        {
            int arcSize = Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(Parent.BackColor);

            if (Checked) //ON
            {
                //Draw the control surface
                if (solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(OnBackColor), GetFigurePath());
                else pevent.Graphics.DrawPath(new Pen(OnBackColor, 2), GetFigurePath());
                //Draw the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor),
                    new Rectangle(Width - Height + 1, 2, toggleSize, toggleSize));

            }
            else //OFF
            {
                //Draw the control surface
                if (solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                else pevent.Graphics.DrawPath(new Pen(OffBackColor, 2), GetFigurePath());
                //Draw the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor),
                    new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }

    }
}
