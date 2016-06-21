using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColorEditor20160621
{
    public partial class ColorEditorForm : Form
    {
        private Color selectedColor;
        private Hsv _hsv = new Hsv();

        EventHandler numericUpDown1ValueChanged;
        EventHandler numericUpDown2ValueChanged;
        EventHandler numericUpDown3ValueChanged;
        EventHandler trackBar1ValueChanged;
        EventHandler trackBar2ValueChanged;
        EventHandler trackBar3ValueChanged;

        EventHandler numericUpDown4ValueChanged;
        EventHandler numericUpDown5ValueChanged;
        EventHandler numericUpDown6ValueChanged;
        EventHandler trackBar4ValueChanged;
        EventHandler trackBar5ValueChanged;
        EventHandler trackBar6ValueChanged;

        public ColorEditorForm()
        {
            InitializeComponent();

            Type t = typeof(System.Windows.Forms.Control);
            System.Reflection.MethodInfo mi = t.GetMethod("SetStyle",
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Public);
            mi.Invoke(this.trackBar1, new object[] { ControlStyles.Opaque, true });
            mi.Invoke(this.trackBar2, new object[] { ControlStyles.Opaque, true });
            mi.Invoke(this.trackBar3, new object[] { ControlStyles.Opaque, true });
            mi.Invoke(this.trackBar4, new object[] { ControlStyles.Opaque, true });
            mi.Invoke(this.trackBar5, new object[] { ControlStyles.Opaque, true });
            mi.Invoke(this.trackBar6, new object[] { ControlStyles.Opaque, true });

            this.panel1.BackColor = Color.Transparent;
            this.panel2.BackColor = Color.Transparent;
            this.panel3.BackColor = Color.Transparent;
            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;
            this.label3.BackColor = Color.Transparent;
            this.label4.BackColor = Color.Transparent;
            this.label5.BackColor = Color.Transparent;
            this.label6.BackColor = Color.Transparent;

            this.numericUpDown1ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown2ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            this.numericUpDown3ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            this.numericUpDown4ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            this.numericUpDown5ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            this.numericUpDown6ValueChanged += new System.EventHandler(this.numericUpDown6_ValueChanged);

            this.numericUpDown1.ValueChanged += this.numericUpDown1ValueChanged;
            this.numericUpDown2.ValueChanged += this.numericUpDown2ValueChanged;
            this.numericUpDown3.ValueChanged += this.numericUpDown3ValueChanged;
            this.numericUpDown4.ValueChanged += this.numericUpDown4ValueChanged;
            this.numericUpDown5.ValueChanged += this.numericUpDown5ValueChanged;
            this.numericUpDown6.ValueChanged += this.numericUpDown6ValueChanged;

            this.trackBar1ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            this.trackBar2ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            this.trackBar3ValueChanged += new System.EventHandler(this.trackBar3_ValueChanged);
            this.trackBar4ValueChanged += new System.EventHandler(this.trackBar4_ValueChanged);
            this.trackBar5ValueChanged += new System.EventHandler(this.trackBar5_ValueChanged);
            this.trackBar6ValueChanged += new System.EventHandler(this.trackBar6_ValueChanged);

            this.trackBar1.ValueChanged += this.trackBar1ValueChanged;
            this.trackBar2.ValueChanged += this.trackBar2ValueChanged;
            this.trackBar3.ValueChanged += this.trackBar3ValueChanged;
            this.trackBar4.ValueChanged += this.trackBar4ValueChanged;
            this.trackBar5.ValueChanged += this.trackBar5ValueChanged;
            this.trackBar6.ValueChanged += this.trackBar6ValueChanged;

            this.SetUIColor();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.trackBar1.ValueChanged -= this.trackBar1ValueChanged;
            this.numericUpDown4.ValueChanged -= this.numericUpDown4ValueChanged;
            this.numericUpDown5.ValueChanged -= this.numericUpDown5ValueChanged;
            this.numericUpDown6.ValueChanged -= this.numericUpDown6ValueChanged;
            this.trackBar4.ValueChanged -= this.trackBar4_ValueChanged;
            this.trackBar5.ValueChanged -= this.trackBar5_ValueChanged;
            this.trackBar6.ValueChanged -= this.trackBar6_ValueChanged;

            this._hsv.H = (float)this.numericUpDown1.Value;
            this.trackBar1.Value = (int)this.numericUpDown1.Value;

            Color c = this._hsv.ToColor();
            this.numericUpDown4.Value = c.R;
            this.numericUpDown5.Value = c.G;
            this.numericUpDown6.Value = c.B;
            this.trackBar4.Value = c.R;
            this.trackBar5.Value = c.G;
            this.trackBar6.Value = c.B;

            this.trackBar1.ValueChanged += this.trackBar1ValueChanged;
            this.numericUpDown4.ValueChanged += this.numericUpDown4ValueChanged;
            this.numericUpDown5.ValueChanged += this.numericUpDown5ValueChanged;
            this.numericUpDown6.ValueChanged += this.numericUpDown6ValueChanged;
            this.trackBar4.ValueChanged += this.trackBar4_ValueChanged;
            this.trackBar5.ValueChanged += this.trackBar5_ValueChanged;
            this.trackBar6.ValueChanged += this.trackBar6_ValueChanged;

            this.SetUIColor();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.trackBar2.ValueChanged -= this.trackBar2ValueChanged;
            this.numericUpDown4.ValueChanged -= this.numericUpDown4ValueChanged;
            this.numericUpDown5.ValueChanged -= this.numericUpDown5ValueChanged;
            this.numericUpDown6.ValueChanged -= this.numericUpDown6ValueChanged;
            this.trackBar4.ValueChanged -= this.trackBar4_ValueChanged;
            this.trackBar5.ValueChanged -= this.trackBar5_ValueChanged;
            this.trackBar6.ValueChanged -= this.trackBar6_ValueChanged;

            this._hsv.S = (float)this.numericUpDown2.Value / 100.0f;
            this.trackBar2.Value = (int)this.numericUpDown2.Value;

            Color c = this._hsv.ToColor();
            this.numericUpDown4.Value = c.R;
            this.numericUpDown5.Value = c.G;
            this.numericUpDown6.Value = c.B;
            this.trackBar4.Value = c.R;
            this.trackBar5.Value = c.G;
            this.trackBar6.Value = c.B;

            this.trackBar2.ValueChanged += this.trackBar2ValueChanged;
            this.numericUpDown4.ValueChanged += this.numericUpDown4ValueChanged;
            this.numericUpDown5.ValueChanged += this.numericUpDown5ValueChanged;
            this.numericUpDown6.ValueChanged += this.numericUpDown6ValueChanged;
            this.trackBar4.ValueChanged += this.trackBar4_ValueChanged;
            this.trackBar5.ValueChanged += this.trackBar5_ValueChanged;
            this.trackBar6.ValueChanged += this.trackBar6_ValueChanged;

            this.SetUIColor();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            this.trackBar3.ValueChanged -= this.trackBar3ValueChanged;
            this.numericUpDown4.ValueChanged -= this.numericUpDown4ValueChanged;
            this.numericUpDown5.ValueChanged -= this.numericUpDown5ValueChanged;
            this.numericUpDown6.ValueChanged -= this.numericUpDown6ValueChanged;
            this.trackBar4.ValueChanged -= this.trackBar4_ValueChanged;
            this.trackBar5.ValueChanged -= this.trackBar5_ValueChanged;
            this.trackBar6.ValueChanged -= this.trackBar6_ValueChanged;

            this._hsv.V = (float)this.numericUpDown3.Value / 100.0f;
            this.trackBar3.Value = (int)this.numericUpDown3.Value;

            Color c = this._hsv.ToColor();
            this.numericUpDown4.Value = c.R;
            this.numericUpDown5.Value = c.G;
            this.numericUpDown6.Value = c.B;
            this.trackBar4.Value = c.R;
            this.trackBar5.Value = c.G;
            this.trackBar6.Value = c.B;

            this.trackBar3.ValueChanged += this.trackBar3ValueChanged;
            this.numericUpDown4.ValueChanged += this.numericUpDown4ValueChanged;
            this.numericUpDown5.ValueChanged += this.numericUpDown5ValueChanged;
            this.numericUpDown6.ValueChanged += this.numericUpDown6ValueChanged;
            this.trackBar4.ValueChanged += this.trackBar4_ValueChanged;
            this.trackBar5.ValueChanged += this.trackBar5_ValueChanged;
            this.trackBar6.ValueChanged += this.trackBar6_ValueChanged;

            this.SetUIColor();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            this.trackBar4.ValueChanged -= this.trackBar4ValueChanged;
            this.numericUpDown1.ValueChanged -= this.numericUpDown1ValueChanged;
            this.numericUpDown2.ValueChanged -= this.numericUpDown2ValueChanged;
            this.numericUpDown3.ValueChanged -= this.numericUpDown3ValueChanged;
            this.trackBar1.ValueChanged -= this.trackBar1ValueChanged;
            this.trackBar2.ValueChanged -= this.trackBar2ValueChanged;
            this.trackBar3.ValueChanged -= this.trackBar3ValueChanged;

            this._hsv.FromRgb(
                (int)this.numericUpDown4.Value,
                (int)this.numericUpDown5.Value,
                (int)this.numericUpDown6.Value);
            this.numericUpDown1.Value = (decimal)this._hsv.H;
            this.numericUpDown2.Value = (decimal)(this._hsv.S * 100.0f);
            this.numericUpDown3.Value = (decimal)(this._hsv.V * 100.0f);
            this.trackBar1.Value = (int)this._hsv.H;
            this.trackBar2.Value = (int)(this._hsv.S * 100.0f);
            this.trackBar3.Value = (int)(this._hsv.V * 100.0f);

            this.trackBar4.Value = (int)this.numericUpDown4.Value;
            this.trackBar5.Value = (int)this.numericUpDown5.Value;
            this.trackBar6.Value = (int)this.numericUpDown6.Value;

            this.trackBar4.ValueChanged += this.trackBar4ValueChanged;
            this.numericUpDown1.ValueChanged += this.numericUpDown1ValueChanged;
            this.numericUpDown2.ValueChanged += this.numericUpDown2ValueChanged;
            this.numericUpDown3.ValueChanged += this.numericUpDown3ValueChanged;
            this.trackBar1.ValueChanged += this.trackBar1ValueChanged;
            this.trackBar2.ValueChanged += this.trackBar2ValueChanged;
            this.trackBar3.ValueChanged += this.trackBar3ValueChanged;

            this.SetUIColor();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            this.trackBar5.ValueChanged -= this.trackBar5ValueChanged;
            this.numericUpDown1.ValueChanged -= this.numericUpDown1ValueChanged;
            this.numericUpDown2.ValueChanged -= this.numericUpDown2ValueChanged;
            this.numericUpDown3.ValueChanged -= this.numericUpDown3ValueChanged;
            this.trackBar1.ValueChanged -= this.trackBar1ValueChanged;
            this.trackBar2.ValueChanged -= this.trackBar2ValueChanged;
            this.trackBar3.ValueChanged -= this.trackBar3ValueChanged;

            this._hsv.FromRgb(
                (int)this.numericUpDown4.Value,
                (int)this.numericUpDown5.Value,
                (int)this.numericUpDown6.Value);
            this.numericUpDown1.Value = (decimal)this._hsv.H;
            this.numericUpDown2.Value = (decimal)(this._hsv.S * 100.0f);
            this.numericUpDown3.Value = (decimal)(this._hsv.V * 100.0f);
            this.trackBar1.Value = (int)this._hsv.H;
            this.trackBar2.Value = (int)(this._hsv.S * 100.0f);
            this.trackBar3.Value = (int)(this._hsv.V * 100.0f);
            this.trackBar4.Value = (int)this.numericUpDown4.Value;
            this.trackBar5.Value = (int)this.numericUpDown5.Value;
            this.trackBar6.Value = (int)this.numericUpDown6.Value;

            this.trackBar5.ValueChanged += this.trackBar5ValueChanged;
            this.numericUpDown1.ValueChanged += this.numericUpDown1ValueChanged;
            this.numericUpDown2.ValueChanged += this.numericUpDown2ValueChanged;
            this.numericUpDown3.ValueChanged += this.numericUpDown3ValueChanged;
            this.trackBar1.ValueChanged += this.trackBar1ValueChanged;
            this.trackBar2.ValueChanged += this.trackBar2ValueChanged;
            this.trackBar3.ValueChanged += this.trackBar3ValueChanged;

            this.SetUIColor();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            this.trackBar6.ValueChanged -= this.trackBar6ValueChanged;
            this.numericUpDown1.ValueChanged -= this.numericUpDown1ValueChanged;
            this.numericUpDown2.ValueChanged -= this.numericUpDown2ValueChanged;
            this.numericUpDown3.ValueChanged -= this.numericUpDown3ValueChanged;
            this.trackBar1.ValueChanged -= this.trackBar1ValueChanged;
            this.trackBar2.ValueChanged -= this.trackBar2ValueChanged;
            this.trackBar3.ValueChanged -= this.trackBar3ValueChanged;

            this._hsv.FromRgb(
                (int)this.numericUpDown4.Value,
                (int)this.numericUpDown5.Value,
                (int)this.numericUpDown6.Value);
            this.numericUpDown1.Value = (decimal)this._hsv.H;
            this.numericUpDown2.Value = (decimal)(this._hsv.S * 100.0f);
            this.numericUpDown3.Value = (decimal)(this._hsv.V * 100.0f);
            this.trackBar1.Value = (int)this._hsv.H;
            this.trackBar2.Value = (int)(this._hsv.S * 100.0f);
            this.trackBar3.Value = (int)(this._hsv.V * 100.0f);
            this.trackBar4.Value = (int)this.numericUpDown4.Value;
            this.trackBar5.Value = (int)this.numericUpDown5.Value;
            this.trackBar6.Value = (int)this.numericUpDown6.Value;

            this.trackBar6.ValueChanged += this.trackBar6ValueChanged;
            this.numericUpDown1.ValueChanged += this.numericUpDown1ValueChanged;
            this.numericUpDown2.ValueChanged += this.numericUpDown2ValueChanged;
            this.numericUpDown3.ValueChanged += this.numericUpDown3ValueChanged;
            this.trackBar4.ValueChanged += this.trackBar4ValueChanged;
            this.trackBar5.ValueChanged += this.trackBar5ValueChanged;
            this.trackBar6.ValueChanged += this.trackBar6ValueChanged;

            this.SetUIColor();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.numericUpDown1.ValueChanged -= this.numericUpDown1ValueChanged;
            this.numericUpDown4.ValueChanged -= this.numericUpDown4ValueChanged;
            this.numericUpDown5.ValueChanged -= this.numericUpDown5ValueChanged;
            this.numericUpDown6.ValueChanged -= this.numericUpDown6ValueChanged;
            this.trackBar4.ValueChanged -= this.trackBar4_ValueChanged;
            this.trackBar5.ValueChanged -= this.trackBar5_ValueChanged;
            this.trackBar6.ValueChanged -= this.trackBar6_ValueChanged;

            this._hsv.H = (float)this.trackBar1.Value;
            this.numericUpDown1.Value = this.trackBar1.Value;

            Color c = this._hsv.ToColor();
            this.numericUpDown4.Value = c.R;
            this.numericUpDown5.Value = c.G;
            this.numericUpDown6.Value = c.B;
            this.trackBar4.Value = c.R;
            this.trackBar5.Value = c.G;
            this.trackBar6.Value = c.B;

            this.numericUpDown1.ValueChanged += this.numericUpDown1ValueChanged;
            this.numericUpDown4.ValueChanged += this.numericUpDown4ValueChanged;
            this.numericUpDown5.ValueChanged += this.numericUpDown5ValueChanged;
            this.numericUpDown6.ValueChanged += this.numericUpDown6ValueChanged;
            this.trackBar4.ValueChanged += this.trackBar4_ValueChanged;
            this.trackBar5.ValueChanged += this.trackBar5_ValueChanged;
            this.trackBar6.ValueChanged += this.trackBar6_ValueChanged;

            this.SetUIColor();
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            this.numericUpDown2.ValueChanged -= this.numericUpDown2ValueChanged;
            this.numericUpDown4.ValueChanged -= this.numericUpDown4ValueChanged;
            this.numericUpDown5.ValueChanged -= this.numericUpDown5ValueChanged;
            this.numericUpDown6.ValueChanged -= this.numericUpDown6ValueChanged;
            this.trackBar4.ValueChanged -= this.trackBar4_ValueChanged;
            this.trackBar5.ValueChanged -= this.trackBar5_ValueChanged;
            this.trackBar6.ValueChanged -= this.trackBar6_ValueChanged;

            this._hsv.S = (float)this.trackBar2.Value / 100.0f;
            this.numericUpDown2.Value = this.trackBar2.Value;

            Color c = this._hsv.ToColor();
            this.numericUpDown4.Value = c.R;
            this.numericUpDown5.Value = c.G;
            this.numericUpDown6.Value = c.B;
            this.trackBar4.Value = c.R;
            this.trackBar5.Value = c.G;
            this.trackBar6.Value = c.B;

            this.numericUpDown2.ValueChanged += this.numericUpDown2ValueChanged;
            this.numericUpDown4.ValueChanged += this.numericUpDown4ValueChanged;
            this.numericUpDown5.ValueChanged += this.numericUpDown5ValueChanged;
            this.numericUpDown6.ValueChanged += this.numericUpDown6ValueChanged;
            this.trackBar4.ValueChanged += this.trackBar4_ValueChanged;
            this.trackBar5.ValueChanged += this.trackBar5_ValueChanged;
            this.trackBar6.ValueChanged += this.trackBar6_ValueChanged;

            this.SetUIColor();
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            this.numericUpDown3.ValueChanged -= this.numericUpDown3ValueChanged;
            this.numericUpDown4.ValueChanged -= this.numericUpDown4ValueChanged;
            this.numericUpDown5.ValueChanged -= this.numericUpDown5ValueChanged;
            this.numericUpDown6.ValueChanged -= this.numericUpDown6ValueChanged;
            this.trackBar4.ValueChanged -= this.trackBar4_ValueChanged;
            this.trackBar5.ValueChanged -= this.trackBar5_ValueChanged;
            this.trackBar6.ValueChanged -= this.trackBar6_ValueChanged;

            this._hsv.V = (float)this.trackBar3.Value / 100.0f;
            this.numericUpDown3.Value = this.trackBar3.Value;

            Color c = this._hsv.ToColor();
            this.numericUpDown4.Value = c.R;
            this.numericUpDown5.Value = c.G;
            this.numericUpDown6.Value = c.B;
            this.trackBar4.Value = c.R;
            this.trackBar5.Value = c.G;
            this.trackBar6.Value = c.B;

            this.numericUpDown3.ValueChanged += this.numericUpDown3ValueChanged;
            this.numericUpDown4.ValueChanged += this.numericUpDown4ValueChanged;
            this.numericUpDown5.ValueChanged += this.numericUpDown5ValueChanged;
            this.numericUpDown6.ValueChanged += this.numericUpDown6ValueChanged;
            this.trackBar4.ValueChanged += this.trackBar4_ValueChanged;
            this.trackBar5.ValueChanged += this.trackBar5_ValueChanged;
            this.trackBar6.ValueChanged += this.trackBar6_ValueChanged;

            this.SetUIColor();
        }

        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            this.numericUpDown4.ValueChanged -= this.numericUpDown4ValueChanged;
            this.numericUpDown1.ValueChanged -= this.numericUpDown1ValueChanged;
            this.numericUpDown2.ValueChanged -= this.numericUpDown2ValueChanged;
            this.numericUpDown3.ValueChanged -= this.numericUpDown3ValueChanged;
            this.trackBar1.ValueChanged -= this.trackBar1_ValueChanged;
            this.trackBar2.ValueChanged -= this.trackBar2_ValueChanged;
            this.trackBar3.ValueChanged -= this.trackBar3_ValueChanged;

            this.numericUpDown4.Value = this.trackBar4.Value;
            this._hsv.FromRgb(
                (int)this.trackBar4.Value,
                (int)this.trackBar5.Value,
                (int)this.trackBar6.Value);
            this.numericUpDown1.Value = (decimal)this._hsv.H;
            this.numericUpDown2.Value = (decimal)(this._hsv.S * 100);
            this.numericUpDown3.Value = (decimal)(this._hsv.V * 100);
            this.trackBar1.Value = (int)this._hsv.H;
            this.trackBar2.Value = (int)(this._hsv.S * 100);
            this.trackBar3.Value = (int)(this._hsv.V * 100);

            this.numericUpDown4.ValueChanged += this.numericUpDown4ValueChanged;
            this.numericUpDown1.ValueChanged += this.numericUpDown1ValueChanged;
            this.numericUpDown2.ValueChanged += this.numericUpDown2ValueChanged;
            this.numericUpDown3.ValueChanged += this.numericUpDown3ValueChanged;
            this.trackBar1.ValueChanged += this.trackBar1_ValueChanged;
            this.trackBar2.ValueChanged += this.trackBar2_ValueChanged;
            this.trackBar3.ValueChanged += this.trackBar3_ValueChanged;

            this.SetUIColor();
        }

        private void trackBar5_ValueChanged(object sender, EventArgs e)
        {
            this.numericUpDown5.ValueChanged -= this.numericUpDown5ValueChanged;
            this.numericUpDown1.ValueChanged -= this.numericUpDown1ValueChanged;
            this.numericUpDown2.ValueChanged -= this.numericUpDown2ValueChanged;
            this.numericUpDown3.ValueChanged -= this.numericUpDown3ValueChanged;
            this.trackBar1.ValueChanged -= this.trackBar1_ValueChanged;
            this.trackBar2.ValueChanged -= this.trackBar2_ValueChanged;
            this.trackBar3.ValueChanged -= this.trackBar3_ValueChanged;

            this.numericUpDown5.Value = this.trackBar5.Value;
            this._hsv.FromRgb(
                (int)this.trackBar4.Value,
                (int)this.trackBar5.Value,
                (int)this.trackBar6.Value);
            this.numericUpDown1.Value = (decimal)this._hsv.H;
            this.numericUpDown2.Value = (decimal)(this._hsv.S * 100);
            this.numericUpDown3.Value = (decimal)(this._hsv.V * 100);
            this.trackBar1.Value = (int)this._hsv.H;
            this.trackBar2.Value = (int)(this._hsv.S * 100);
            this.trackBar3.Value = (int)(this._hsv.V * 100);

            this.numericUpDown5.ValueChanged += this.numericUpDown5ValueChanged;
            this.numericUpDown1.ValueChanged += this.numericUpDown1ValueChanged;
            this.numericUpDown2.ValueChanged += this.numericUpDown2ValueChanged;
            this.numericUpDown3.ValueChanged += this.numericUpDown3ValueChanged;
            this.trackBar1.ValueChanged += this.trackBar1_ValueChanged;
            this.trackBar2.ValueChanged += this.trackBar2_ValueChanged;
            this.trackBar3.ValueChanged += this.trackBar3_ValueChanged;

            this.SetUIColor();
        }

        private void trackBar6_ValueChanged(object sender, EventArgs e)
        {
            this.numericUpDown6.ValueChanged -= this.numericUpDown6ValueChanged;
            this.numericUpDown1.ValueChanged -= this.numericUpDown1ValueChanged;
            this.numericUpDown2.ValueChanged -= this.numericUpDown2ValueChanged;
            this.numericUpDown3.ValueChanged -= this.numericUpDown3ValueChanged;
            this.trackBar1.ValueChanged -= this.trackBar1_ValueChanged;
            this.trackBar2.ValueChanged -= this.trackBar2_ValueChanged;
            this.trackBar3.ValueChanged -= this.trackBar3_ValueChanged;

            this.numericUpDown6.Value = this.trackBar6.Value;
            this._hsv.FromRgb(
                (int)this.trackBar4.Value,
                (int)this.trackBar5.Value,
                (int)this.trackBar6.Value);
            this.numericUpDown1.Value = (decimal)this._hsv.H;
            this.numericUpDown2.Value = (decimal)(this._hsv.S * 100);
            this.numericUpDown3.Value = (decimal)(this._hsv.V * 100);
            this.trackBar1.Value = (int)this._hsv.H;
            this.trackBar2.Value = (int)(this._hsv.S * 100);
            this.trackBar3.Value = (int)(this._hsv.V * 100);

            this.numericUpDown6.ValueChanged += this.numericUpDown6ValueChanged;
            this.numericUpDown1.ValueChanged += this.numericUpDown1ValueChanged;
            this.numericUpDown2.ValueChanged += this.numericUpDown2ValueChanged;
            this.numericUpDown3.ValueChanged += this.numericUpDown3ValueChanged;
            this.trackBar1.ValueChanged += this.trackBar1_ValueChanged;
            this.trackBar2.ValueChanged += this.trackBar2_ValueChanged;
            this.trackBar3.ValueChanged += this.trackBar3_ValueChanged;

            this.SetUIColor();
        }

        private void SetUIColor()
        {
            this.selectedColor = Color.FromArgb(
                (int)this.numericUpDown4.Value,
                (int)this.numericUpDown5.Value,
                (int)this.numericUpDown6.Value);

            this.BackColor = this.selectedColor;
            this.Update();

            this.panel1.BackColor = this.selectedColor;
            this.panel1.Update();
            this.panel2.BackColor = this.selectedColor;
            this.panel2.Update();
            this.panel3.BackColor = this.selectedColor;
            this.panel3.Update();

            this.numericUpDown1.BackColor = this.selectedColor;
            this.numericUpDown2.BackColor = this.selectedColor;
            this.numericUpDown3.BackColor = this.selectedColor;
            this.numericUpDown4.BackColor = this.selectedColor;
            this.numericUpDown5.BackColor = this.selectedColor;
            this.numericUpDown6.BackColor = this.selectedColor;

            // 文字色は背景色と反対の色にする
            Color foreColor = Color.FromArgb(
                this.selectedColor.R ^ 0xff,
                this.selectedColor.G ^ 0xff,
                this.selectedColor.B ^ 0xff);
            if ((80 < this.selectedColor.R && this.selectedColor.R < 180) &&
                (80 < this.selectedColor.G && this.selectedColor.G < 180))
            {
                foreColor = Color.Black;
            }
            this.label1.ForeColor = foreColor;
            this.label2.ForeColor = foreColor;
            this.label3.ForeColor = foreColor;
            this.label4.ForeColor = foreColor;
            this.label5.ForeColor = foreColor;
            this.label6.ForeColor = foreColor;
            this.numericUpDown1.ForeColor = foreColor;
            this.numericUpDown2.ForeColor = foreColor;
            this.numericUpDown3.ForeColor = foreColor;
            this.numericUpDown4.ForeColor = foreColor;
            this.numericUpDown5.ForeColor = foreColor;
            this.numericUpDown6.ForeColor = foreColor;

            // 1pixcel分の下線をクリアする（Windows NumericUpDown のバグ？）
            this.numericUpDown1.Refresh();
            this.numericUpDown2.Refresh();
            this.numericUpDown3.Refresh();
            this.numericUpDown4.Refresh();
            this.numericUpDown5.Refresh();
            this.numericUpDown6.Refresh();
        }

    }
}
