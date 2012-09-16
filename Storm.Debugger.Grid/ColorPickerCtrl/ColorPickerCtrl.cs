using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CommonTools.ColorPickerCtrl
{
	public partial class ColorPickerCtrl : UserControl
	{
		public event EventHandler SelectionChanged;
		Color m_selectedColor = Color.AntiqueWhite;
		public Color SelectedColor
		{
			get { return Color.FromArgb((int)Math.Floor(255f*m_opacity), m_selectedColor);; }
			set
			{
				m_opacity = (float)value.A / 255f;
				value = Color.FromArgb(255, value);
				m_colorWheel.SelectedColor = value;
				if (m_colorTable.ColorExist(value) == false)
					m_colorTable.SetCustomColor(value);
				m_colorTable.SelectedItem = value;
				m_opacitySlider.Percent = m_opacity;
			}
		}
		public ColorPickerCtrl()
		{
			InitializeComponent();

			List<Color> colors = new List<Color>();
			float step = 100/8;
			for (float x = 0; x <= 100; x += step)
			{
				float v = 255 * x/100;
				colors.Add(Color.FromArgb(255, (int)v, (int)v, (int)v));
			}
			colors.Add(Color.White);

			colors.Add(Color.FromArgb(255, 255, 000, 000));
			colors.Add(Color.FromArgb(255, 255, 255, 000));
			colors.Add(Color.FromArgb(255, 000, 255, 000));
			colors.Add(Color.FromArgb(255, 000, 255, 255));
			colors.Add(Color.FromArgb(255, 000, 000, 255));
			colors.Add(Color.FromArgb(255, 255, 000, 255));

			int cols = 16;
			int rows = 3;
			float cnt = (rows * cols);
			float huestep = 360 / cnt;
			float hue = 0;
			while (hue < 360)
			{
				colors.Add(new HSLColor(hue, 1, 0.5).Color);
				hue += huestep;
			}
			hue = 0;
			while (hue < 360)
			{
				colors.Add(new HSLColor(hue, 0.5, 0.5).Color);
				hue += huestep;
			}
			m_colorTable.Colors = colors.ToArray();
			m_colorTable.Cols = cols;
			m_colorTable.SelectedIndexChanged += new EventHandler(OnColorTableSelectionChanged);

			m_colorWheel.SelectedColorChanged += new EventHandler(OnColorWheelSelectionChanged);
			m_opacitySlider.SelectedValueChanged += new EventHandler(OnOpacityValueChanged);
			m_eyedropColorPicker.SelectedColorChanged += new EventHandler(OnEyeDropperSelectionChanged);
			m_colorSample.Paint += new PaintEventHandler(OnColorSamplePaint);
		}
		void OnEyeDropperSelectionChanged(object sender, EventArgs e)
		{
			m_colorWheel.SelectedColor = m_eyedropColorPicker.SelectedColor;
		}
		float m_opacity = 1;
		void OnOpacityValueChanged(object sender, EventArgs e)
		{
			m_opacity = Math.Max(0, m_opacitySlider.Percent);
			m_opacity = Math.Min(1, m_opacitySlider.Percent);
			m_colorSample.Refresh();
			UpdateInfo();
		}
		void OnColorWheelSelectionChanged(object sender, EventArgs e)
		{
			Color selcol = m_colorWheel.SelectedColor;
			if (selcol != null && selcol != m_selectedColor)
			{
				m_selectedColor = selcol;
				m_colorSample.Refresh();
				if (lockColorTable == false && selcol != m_colorTable.SelectedItem)
					m_colorTable.SetCustomColor(selcol);
			}
			UpdateInfo();
			if (SelectionChanged != null)
				SelectionChanged(this, null);
		}
		void UpdateInfo()
		{
			Color c = Color.FromArgb((int)Math.Floor(255f*m_opacity), m_selectedColor);
			string info = string.Format("{0} aRGB({1}, {2}, {3}, {4})", m_colorWheel.SelectedHSLColor.ToString(), c.A, c.R, c.G, c.B);
			m_infoLabel.Text = info;
		}
		void OnColorSamplePaint(object sender, PaintEventArgs e)
		{
			Rectangle r = m_colorSample.ClientRectangle;
			r.Inflate(-4,-4);

			int width = r.Width;
			r.Width /= 2;
			
			Color c = Color.FromArgb((int)Math.Floor(255f*m_opacity), m_selectedColor);
			SolidBrush b = new SolidBrush(c);
			e.Graphics.FillRectangle(b, r);

			r.X += r.Width;

			e.Graphics.FillRectangle(Brushes.White, r);
			c = Color.FromArgb(255, m_selectedColor);
			b = new SolidBrush(c);
			e.Graphics.FillRectangle(b, r);
		}

		bool lockColorTable = false;
		void OnColorTableSelectionChanged(object sender, EventArgs e)
		{
			Color selcol = (Color)m_colorTable.SelectedItem;
			if (selcol != null && selcol != m_selectedColor)
			{
				lockColorTable = true;
				m_colorWheel.SelectedColor = selcol;
				lockColorTable = false;
				m_colorSample.Invalidate();
			}
		}
	}
}
