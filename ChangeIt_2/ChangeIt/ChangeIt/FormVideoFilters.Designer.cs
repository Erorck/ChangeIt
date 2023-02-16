
namespace ChangeIt
{
    partial class FormVideoFilters
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series43 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series44 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series45 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series46 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series47 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series48 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbControlSliderVal = new System.Windows.Forms.Label();
            this.lbControlSliderDes = new System.Windows.Forms.Label();
            this.tbSliderControl = new System.Windows.Forms.TrackBar();
            this.panelHistogram = new System.Windows.Forms.Panel();
            this.chartHistEdited = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartHistOriginal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbSelectedFilter = new System.Windows.Forms.ComboBox();
            this.btnResetVideo = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUploadVideo = new FontAwesome.Sharp.IconButton();
            this.pbEdited = new System.Windows.Forms.PictureBox();
            this.pBOriginal = new System.Windows.Forms.PictureBox();
            this.btnPlayStop = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSliderControl)).BeginInit();
            this.panelHistogram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistEdited)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdited)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.btnPlayStop);
            this.panel1.Controls.Add(this.lbControlSliderVal);
            this.panel1.Controls.Add(this.lbControlSliderDes);
            this.panel1.Controls.Add(this.tbSliderControl);
            this.panel1.Controls.Add(this.panelHistogram);
            this.panel1.Controls.Add(this.cbSelectedFilter);
            this.panel1.Controls.Add(this.btnResetVideo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnUploadVideo);
            this.panel1.Controls.Add(this.pbEdited);
            this.panel1.Controls.Add(this.pBOriginal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 491);
            this.panel1.TabIndex = 1;
            // 
            // lbControlSliderVal
            // 
            this.lbControlSliderVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbControlSliderVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.lbControlSliderVal.Location = new System.Drawing.Point(464, 410);
            this.lbControlSliderVal.Name = "lbControlSliderVal";
            this.lbControlSliderVal.Size = new System.Drawing.Size(36, 20);
            this.lbControlSliderVal.TabIndex = 35;
            this.lbControlSliderVal.Text = "0";
            this.lbControlSliderVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbControlSliderDes
            // 
            this.lbControlSliderDes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbControlSliderDes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.lbControlSliderDes.Location = new System.Drawing.Point(506, 413);
            this.lbControlSliderDes.Name = "lbControlSliderDes";
            this.lbControlSliderDes.Size = new System.Drawing.Size(108, 15);
            this.lbControlSliderDes.TabIndex = 34;
            this.lbControlSliderDes.Text = "Descripción Control";
            this.lbControlSliderDes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSliderControl
            // 
            this.tbSliderControl.Enabled = false;
            this.tbSliderControl.Location = new System.Drawing.Point(436, 383);
            this.tbSliderControl.Maximum = 255;
            this.tbSliderControl.Name = "tbSliderControl";
            this.tbSliderControl.Size = new System.Drawing.Size(204, 45);
            this.tbSliderControl.TabIndex = 33;
            this.tbSliderControl.ValueChanged += new System.EventHandler(this.tbSliderControl_ValueChanged);
            // 
            // panelHistogram
            // 
            this.panelHistogram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHistogram.BackColor = System.Drawing.Color.Black;
            this.panelHistogram.Controls.Add(this.chartHistEdited);
            this.panelHistogram.Controls.Add(this.chartHistOriginal);
            this.panelHistogram.Location = new System.Drawing.Point(755, 0);
            this.panelHistogram.Name = "panelHistogram";
            this.panelHistogram.Size = new System.Drawing.Size(435, 491);
            this.panelHistogram.TabIndex = 32;
            // 
            // chartHistEdited
            // 
            this.chartHistEdited.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.chartHistEdited.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.chartHistEdited.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.chartHistEdited.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chartHistEdited.BorderSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.chartHistEdited.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            chartArea15.AxisX.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea15.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea15.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea15.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea15.AxisX2.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea15.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea15.AxisX2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea15.AxisX2.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea15.AxisY.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea15.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea15.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea15.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea15.AxisY2.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea15.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea15.AxisY2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea15.AxisY2.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            chartArea15.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea15.Name = "ChartArea1";
            chartArea15.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.chartHistEdited.ChartAreas.Add(chartArea15);
            this.chartHistEdited.Dock = System.Windows.Forms.DockStyle.Top;
            legend15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            legend15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            legend15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(57)))));
            legend15.InterlacedRowsColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            legend15.IsTextAutoFit = false;
            legend15.Name = "Legend1";
            legend15.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            legend15.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            legend15.TitleSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.chartHistEdited.Legends.Add(legend15);
            this.chartHistEdited.Location = new System.Drawing.Point(0, 245);
            this.chartHistEdited.Name = "chartHistEdited";
            this.chartHistEdited.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series43.ChartArea = "ChartArea1";
            series43.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series43.Color = System.Drawing.Color.Red;
            series43.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            series43.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            series43.Legend = "Legend1";
            series43.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            series43.Name = "Red";
            series43.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            series44.ChartArea = "ChartArea1";
            series44.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series44.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(20)))));
            series44.Legend = "Legend1";
            series44.Name = "Green";
            series45.ChartArea = "ChartArea1";
            series45.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series45.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            series45.Legend = "Legend1";
            series45.Name = "Blue";
            this.chartHistEdited.Series.Add(series43);
            this.chartHistEdited.Series.Add(series44);
            this.chartHistEdited.Series.Add(series45);
            this.chartHistEdited.Size = new System.Drawing.Size(435, 245);
            this.chartHistEdited.TabIndex = 24;
            this.chartHistEdited.Text = "chart1";
            // 
            // chartHistOriginal
            // 
            this.chartHistOriginal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.chartHistOriginal.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.chartHistOriginal.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.chartHistOriginal.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chartHistOriginal.BorderSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.chartHistOriginal.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            chartArea16.AxisX.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea16.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea16.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea16.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea16.AxisX2.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea16.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea16.AxisX2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea16.AxisX2.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea16.AxisY.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea16.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea16.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea16.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea16.AxisY2.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea16.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea16.AxisY2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea16.AxisY2.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            chartArea16.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            chartArea16.Name = "ChartArea1";
            chartArea16.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.chartHistOriginal.ChartAreas.Add(chartArea16);
            this.chartHistOriginal.Dock = System.Windows.Forms.DockStyle.Top;
            legend16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            legend16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            legend16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(57)))));
            legend16.InterlacedRowsColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            legend16.IsTextAutoFit = false;
            legend16.Name = "Legend1";
            legend16.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            legend16.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            legend16.TitleSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.chartHistOriginal.Legends.Add(legend16);
            this.chartHistOriginal.Location = new System.Drawing.Point(0, 0);
            this.chartHistOriginal.Name = "chartHistOriginal";
            this.chartHistOriginal.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series46.ChartArea = "ChartArea1";
            series46.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series46.Color = System.Drawing.Color.Red;
            series46.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            series46.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            series46.Legend = "Legend1";
            series46.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            series46.Name = "Red";
            series46.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            series47.ChartArea = "ChartArea1";
            series47.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series47.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(20)))));
            series47.Legend = "Legend1";
            series47.Name = "Green";
            series48.ChartArea = "ChartArea1";
            series48.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series48.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            series48.Legend = "Legend1";
            series48.Name = "Blue";
            this.chartHistOriginal.Series.Add(series46);
            this.chartHistOriginal.Series.Add(series47);
            this.chartHistOriginal.Series.Add(series48);
            this.chartHistOriginal.Size = new System.Drawing.Size(435, 245);
            this.chartHistOriginal.TabIndex = 23;
            this.chartHistOriginal.Text = "chart1";
            // 
            // cbSelectedFilter
            // 
            this.cbSelectedFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.cbSelectedFilter.Enabled = false;
            this.cbSelectedFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSelectedFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cbSelectedFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.cbSelectedFilter.FormattingEnabled = true;
            this.cbSelectedFilter.Location = new System.Drawing.Point(436, 350);
            this.cbSelectedFilter.Name = "cbSelectedFilter";
            this.cbSelectedFilter.Size = new System.Drawing.Size(204, 25);
            this.cbSelectedFilter.TabIndex = 30;
            this.cbSelectedFilter.Text = "Select a Filter";
            this.cbSelectedFilter.SelectedIndexChanged += new System.EventHandler(this.cbSelectedFilter_SelectedIndexChanged);
            // 
            // btnResetVideo
            // 
            this.btnResetVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(57)))));
            this.btnResetVideo.Enabled = false;
            this.btnResetVideo.FlatAppearance.BorderSize = 0;
            this.btnResetVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetVideo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.btnResetVideo.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            this.btnResetVideo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.btnResetVideo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResetVideo.IconSize = 30;
            this.btnResetVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetVideo.Location = new System.Drawing.Point(217, 345);
            this.btnResetVideo.Name = "btnResetVideo";
            this.btnResetVideo.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnResetVideo.Size = new System.Drawing.Size(102, 35);
            this.btnResetVideo.TabIndex = 29;
            this.btnResetVideo.Text = "Reset";
            this.btnResetVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetVideo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetVideo.UseVisualStyleBackColor = false;
            this.btnResetVideo.Click += new System.EventHandler(this.btnResetVideo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(57)))));
            this.label2.Location = new System.Drawing.Point(505, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Edited";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(149, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Original";
            // 
            // btnUploadVideo
            // 
            this.btnUploadVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.btnUploadVideo.FlatAppearance.BorderSize = 0;
            this.btnUploadVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadVideo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.btnUploadVideo.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnUploadVideo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.btnUploadVideo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUploadVideo.IconSize = 30;
            this.btnUploadVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUploadVideo.Location = new System.Drawing.Point(60, 345);
            this.btnUploadVideo.Name = "btnUploadVideo";
            this.btnUploadVideo.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnUploadVideo.Size = new System.Drawing.Size(141, 35);
            this.btnUploadVideo.TabIndex = 26;
            this.btnUploadVideo.Text = "Upload Video";
            this.btnUploadVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUploadVideo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUploadVideo.UseVisualStyleBackColor = false;
            this.btnUploadVideo.Click += new System.EventHandler(this.btnUploadVideo_Click);
            // 
            // pbEdited
            // 
            this.pbEdited.BackColor = System.Drawing.Color.Black;
            this.pbEdited.Location = new System.Drawing.Point(371, 64);
            this.pbEdited.Name = "pbEdited";
            this.pbEdited.Size = new System.Drawing.Size(334, 220);
            this.pbEdited.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEdited.TabIndex = 24;
            this.pbEdited.TabStop = false;
            // 
            // pBOriginal
            // 
            this.pBOriginal.BackColor = System.Drawing.Color.Black;
            this.pBOriginal.Location = new System.Drawing.Point(24, 64);
            this.pBOriginal.Name = "pBOriginal";
            this.pBOriginal.Size = new System.Drawing.Size(334, 220);
            this.pBOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBOriginal.TabIndex = 23;
            this.pBOriginal.TabStop = false;
            // 
            // btnPlayStop
            // 
            this.btnPlayStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.btnPlayStop.Enabled = false;
            this.btnPlayStop.FlatAppearance.BorderSize = 0;
            this.btnPlayStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.btnPlayStop.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnPlayStop.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.btnPlayStop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlayStop.IconSize = 25;
            this.btnPlayStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlayStop.Location = new System.Drawing.Point(344, 345);
            this.btnPlayStop.Name = "btnPlayStop";
            this.btnPlayStop.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnPlayStop.Size = new System.Drawing.Size(47, 36);
            this.btnPlayStop.TabIndex = 36;
            this.btnPlayStop.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnPlayStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPlayStop.UseVisualStyleBackColor = false;
            this.btnPlayStop.Click += new System.EventHandler(this.btnPlayStop_Click);
            // 
            // FormVideoFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 491);
            this.Controls.Add(this.panel1);
            this.Name = "FormVideoFilters";
            this.Text = "FormVideoFilters";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVideoFilters_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSliderControl)).EndInit();
            this.panelHistogram.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartHistEdited)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdited)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBOriginal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbControlSliderVal;
        private System.Windows.Forms.Label lbControlSliderDes;
        private System.Windows.Forms.TrackBar tbSliderControl;
        private System.Windows.Forms.Panel panelHistogram;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistEdited;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistOriginal;
        private System.Windows.Forms.ComboBox cbSelectedFilter;
        private FontAwesome.Sharp.IconButton btnResetVideo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnUploadVideo;
        private System.Windows.Forms.PictureBox pbEdited;
        private System.Windows.Forms.PictureBox pBOriginal;
        private FontAwesome.Sharp.IconButton btnPlayStop;
    }
}