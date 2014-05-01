namespace WFOBD
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.aGauge2 = new AGaugeControl.AGauge();
            this.aGauge1 = new AGaugeControl.AGauge();
            this.aGauge3 = new AGaugeControl.AGauge();
            this.SuspendLayout();
            // 
            // aGauge2  --------------------------------------------------------------------------------------------
            // 
            this.aGauge2.BaseArcColor = System.Drawing.Color.Black;
            this.aGauge2.BaseArcRadius = 80;
            this.aGauge2.BaseArcStart = 135;
            this.aGauge2.BaseArcSweep = 270;
            this.aGauge2.BaseArcWidth = 1;
            this.aGauge2.Cap_Idx = ((byte)(0));
            this.aGauge2.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge2.CapPosition = new System.Drawing.Point(57, 165);
            this.aGauge2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(57, 165),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge2.CapsText = new string[] {
        "Fuel Pressure kPa",
        "",
        "",
        "",
        ""};
            this.aGauge2.CapText = "Fuel Pressure kPa";
            this.aGauge2.Center = new System.Drawing.Point(105, 105);
            this.aGauge2.Location = new System.Drawing.Point(265, 12);
            this.aGauge2.MaxValue = 765F;
            this.aGauge2.MinValue = 0F;
            this.aGauge2.Name = "aGauge2";
            this.aGauge2.NeedleColor1 = AGaugeControl.AGauge.NeedleColorEnum.Gray;
            this.aGauge2.NeedleColor2 = System.Drawing.Color.Black;
            this.aGauge2.NeedleRadius = 65;
            this.aGauge2.NeedleType = 0;
            this.aGauge2.NeedleWidth = 5;
            this.aGauge2.Range_Idx = ((byte)(2));
            this.aGauge2.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.aGauge2.RangeEnabled = true;
            this.aGauge2.RangeEndValue = 600F;
            this.aGauge2.RangeInnerRadius = 1;
            this.aGauge2.RangeOuterRadius = 80;
            this.aGauge2.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge2.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.aGauge2.RangesEndValue = new float[] {
        635F,
        765F,
        600F,
        0F,
        0F};
            this.aGauge2.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.aGauge2.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.aGauge2.RangesStartValue = new float[] {
        0F,
        600F,
        435F,
        0F,
        0F};
            this.aGauge2.RangeStartValue = 435F;
            this.aGauge2.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesInterInnerRadius = 70;
            this.aGauge2.ScaleLinesInterOuterRadius = 80;
            this.aGauge2.ScaleLinesInterWidth = 1;
            this.aGauge2.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesMajorInnerRadius = 70;
            this.aGauge2.ScaleLinesMajorOuterRadius = 80;
            this.aGauge2.ScaleLinesMajorStepValue = 45F;
            this.aGauge2.ScaleLinesMajorWidth = 2;
            this.aGauge2.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge2.ScaleLinesMinorInnerRadius = 75;
            this.aGauge2.ScaleLinesMinorNumOf = 9;
            this.aGauge2.ScaleLinesMinorOuterRadius = 80;
            this.aGauge2.ScaleLinesMinorWidth = 1;
            this.aGauge2.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleNumbersFormat = null;
            this.aGauge2.ScaleNumbersRadius = 93;
            this.aGauge2.ScaleNumbersRotation = 0;
            this.aGauge2.ScaleNumbersStartScaleLine = 0;
            this.aGauge2.ScaleNumbersStepScaleLines = 1;
            this.aGauge2.Size = new System.Drawing.Size(211, 184);
            this.aGauge2.TabIndex = 2;
            this.aGauge2.Text = "aGauge2";
            this.aGauge2.Value = 0F;
            // 
            // aGauge1  --------------------------------------------------------------------------------------------
            // 
            this.aGauge1.BaseArcColor = System.Drawing.Color.Black;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 270;
            this.aGauge1.BaseArcWidth = 1;
            this.aGauge1.Cap_Idx = ((byte)(0));
            this.aGauge1.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge1.CapPosition = new System.Drawing.Point(75, 165);
            this.aGauge1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(75, 165),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge1.CapsText = new string[] {
        "Speed Km/h",
        "",
        "",
        "",
        ""};
            this.aGauge1.CapText = "Speed Km/h";
            this.aGauge1.Center = new System.Drawing.Point(105, 105);
            this.aGauge1.Location = new System.Drawing.Point(12, 12);
            this.aGauge1.MaxValue = 140F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = AGaugeControl.AGauge.NeedleColorEnum.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.Black;
            this.aGauge1.NeedleRadius = 65;
            this.aGauge1.NeedleType = 0;
            this.aGauge1.NeedleWidth = 5;
            this.aGauge1.Range_Idx = ((byte)(2));
            this.aGauge1.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.aGauge1.RangeEnabled = true;
            this.aGauge1.RangeEndValue = 120F;
            this.aGauge1.RangeInnerRadius = 70;
            this.aGauge1.RangeOuterRadius = 80;
            this.aGauge1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge1.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.aGauge1.RangesEndValue = new float[] {
        140F,
        140F,
        120F,
        0F,
        0F};
            this.aGauge1.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.aGauge1.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.aGauge1.RangesStartValue = new float[] {
        0F,
        120F,
        100F,
        0F,
        0F};
            this.aGauge1.RangeStartValue = 100F;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 70;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 50F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge1.ScaleLinesMinorInnerRadius = 75;
            this.aGauge1.ScaleLinesMinorNumOf = 9;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 93;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(213, 184);
            this.aGauge1.TabIndex = 1;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            // 
            // aGauge3  --------------------------------------------------------------------------------------------
            // 
            this.aGauge3.BaseArcColor = System.Drawing.Color.Black;
            this.aGauge3.BaseArcRadius = 80;
            this.aGauge3.BaseArcStart = 135;
            this.aGauge3.BaseArcSweep = 270;
            this.aGauge3.BaseArcWidth = 1;
            this.aGauge3.Cap_Idx = ((byte)(0));
            this.aGauge3.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge3.CapPosition = new System.Drawing.Point(90, 165);
            this.aGauge3.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(90, 165),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge3.CapsText = new string[] {
        "Rpm",
        "",
        "",
        "",
        ""};
            this.aGauge3.CapText = "Rpm";
            this.aGauge3.Center = new System.Drawing.Point(115, 105);
            this.aGauge3.Location = new System.Drawing.Point(510, 12);
            this.aGauge3.MaxValue = 7000F;
            this.aGauge3.MinValue = 0F;
            this.aGauge3.Name = "aGauge3";
            this.aGauge3.NeedleColor1 = AGaugeControl.AGauge.NeedleColorEnum.Gray;
            this.aGauge3.NeedleColor2 = System.Drawing.Color.Black;
            this.aGauge3.NeedleRadius = 65;
            this.aGauge3.NeedleType = 0;
            this.aGauge3.NeedleWidth = 5;
            this.aGauge3.Range_Idx = ((byte)(0));
            this.aGauge3.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge3.RangeEnabled = true;
            this.aGauge3.RangeEndValue = 6000F;
            this.aGauge3.RangeInnerRadius = 70;
            this.aGauge3.RangeOuterRadius = 80;
            this.aGauge3.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge3.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.aGauge3.RangesEndValue = new float[] {
        6000F,
        7000F,
        250F,
        0F,
        0F};
            this.aGauge3.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.aGauge3.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.aGauge3.RangesStartValue = new float[] {
        0F,
        6000F,
        100F,
        0F,
        0F};
            this.aGauge3.RangeStartValue = 0F;
            this.aGauge3.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleLinesInterInnerRadius = 70;
            this.aGauge3.ScaleLinesInterOuterRadius = 80;
            this.aGauge3.ScaleLinesInterWidth = 1;
            this.aGauge3.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleLinesMajorInnerRadius = 70;
            this.aGauge3.ScaleLinesMajorOuterRadius = 80;
            this.aGauge3.ScaleLinesMajorStepValue = 1000F;
            this.aGauge3.ScaleLinesMajorWidth = 2;
            this.aGauge3.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge3.ScaleLinesMinorInnerRadius = 75;
            this.aGauge3.ScaleLinesMinorNumOf = 9;
            this.aGauge3.ScaleLinesMinorOuterRadius = 80;
            this.aGauge3.ScaleLinesMinorWidth = 1;
            this.aGauge3.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleNumbersFormat = null;
            this.aGauge3.ScaleNumbersRadius = 100;
            this.aGauge3.ScaleNumbersRotation = 0;
            this.aGauge3.ScaleNumbersStartScaleLine = 0;
            this.aGauge3.ScaleNumbersStepScaleLines = 1;
            this.aGauge3.Size = new System.Drawing.Size(235, 184);
            this.aGauge3.TabIndex = 3;
            this.aGauge3.Text = "aGauge3";
            this.aGauge3.Value = 0F;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 242);
            this.Controls.Add(this.aGauge3);
            this.Controls.Add(this.aGauge2);
            this.Controls.Add(this.aGauge1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private AGaugeControl.AGauge aGauge1;
        private AGaugeControl.AGauge aGauge2;
        private AGaugeControl.AGauge aGauge3;
    }
}

