namespace OriginValidMailChecker
{
    partial class Checker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checker));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MiniButton = new ns1.SiticoneControlBox();
            this.CloseButton = new ns1.SiticoneControlBox();
            this.Title = new System.Windows.Forms.Label();
            this.SetupGB = new ns1.SiticoneGroupBox();
            this.StartButton = new ns1.SiticoneButton();
            this.ThreadLabelValue = new System.Windows.Forms.Label();
            this.SOCKS5Toggle = new ns1.SiticoneRadioButton();
            this.ThreadTitle = new System.Windows.Forms.Label();
            this.LoadProxiesButton = new ns1.SiticoneButton();
            this.ThreadBar = new ns1.SiticoneTrackBar();
            this.SOCKS4Toggle = new ns1.SiticoneRadioButton();
            this.LoadEmailButton = new ns1.SiticoneButton();
            this.HTTPToggle = new ns1.SiticoneRadioButton();
            this.Drag = new ns1.SiticoneDragControl(this.components);
            this.CheckedEmailValue = new System.Windows.Forms.Label();
            this.CheckedLabel = new System.Windows.Forms.Label();
            this.ErrorValue = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.InvalidEmailValue = new System.Windows.Forms.Label();
            this.InvalidEmailLabel = new System.Windows.Forms.Label();
            this.ValidEmailValue = new System.Windows.Forms.Label();
            this.ValidEmailLabel = new System.Windows.Forms.Label();
            this.LoadedProxyValue = new System.Windows.Forms.Label();
            this.LoadedProxyLabel = new System.Windows.Forms.Label();
            this.LoadedEmailValue = new System.Windows.Forms.Label();
            this.LoadedEmailsLabel = new System.Windows.Forms.Label();
            this.ValidEmailBar = new ns1.SiticonePanel();
            this.EmailTitle = new System.Windows.Forms.Label();
            this.ResultListView = new System.Windows.Forms.ListView();
            this.ValidEmailHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProxylessToggle = new ns1.SiticoneRadioButton();
            this.TopPanel.SuspendLayout();
            this.SetupGB.SuspendLayout();
            this.ValidEmailBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.TopPanel.Controls.Add(this.MiniButton);
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Controls.Add(this.Title);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(704, 36);
            this.TopPanel.TabIndex = 0;
            // 
            // MiniButton
            // 
            this.MiniButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MiniButton.ControlBoxType = ns5.ControlBoxType.MinimizeBox;
            this.MiniButton.FillColor = System.Drawing.Color.Transparent;
            this.MiniButton.HoveredState.Parent = this.MiniButton;
            this.MiniButton.IconColor = System.Drawing.Color.White;
            this.MiniButton.Location = new System.Drawing.Point(597, 0);
            this.MiniButton.Name = "MiniButton";
            this.MiniButton.ShadowDecoration.Parent = this.MiniButton;
            this.MiniButton.Size = new System.Drawing.Size(54, 36);
            this.MiniButton.TabIndex = 2;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.FillColor = System.Drawing.Color.Transparent;
            this.CloseButton.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.CloseButton.HoveredState.Parent = this.CloseButton;
            this.CloseButton.IconColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(650, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.ShadowDecoration.Parent = this.CloseButton;
            this.CloseButton.Size = new System.Drawing.Size(54, 36);
            this.CloseButton.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(6, 8);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(218, 20);
            this.Title.TabIndex = 0;
            this.Title.Text = "Origin Valid Email Checker | Fliz";
            // 
            // SetupGB
            // 
            this.SetupGB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SetupGB.Controls.Add(this.ProxylessToggle);
            this.SetupGB.Controls.Add(this.StartButton);
            this.SetupGB.Controls.Add(this.ThreadLabelValue);
            this.SetupGB.Controls.Add(this.SOCKS5Toggle);
            this.SetupGB.Controls.Add(this.ThreadTitle);
            this.SetupGB.Controls.Add(this.LoadProxiesButton);
            this.SetupGB.Controls.Add(this.ThreadBar);
            this.SetupGB.Controls.Add(this.SOCKS4Toggle);
            this.SetupGB.Controls.Add(this.LoadEmailButton);
            this.SetupGB.Controls.Add(this.HTTPToggle);
            this.SetupGB.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SetupGB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SetupGB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetupGB.ForeColor = System.Drawing.Color.White;
            this.SetupGB.Location = new System.Drawing.Point(13, 46);
            this.SetupGB.Name = "SetupGB";
            this.SetupGB.ShadowDecoration.Parent = this.SetupGB;
            this.SetupGB.Size = new System.Drawing.Size(211, 299);
            this.SetupGB.TabIndex = 1;
            this.SetupGB.Text = "Setup";
            this.SetupGB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartButton
            // 
            this.StartButton.CheckedState.Parent = this.StartButton;
            this.StartButton.CustomImages.Parent = this.StartButton;
            this.StartButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.StartButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.StartButton.HoveredState.Parent = this.StartButton;
            this.StartButton.Location = new System.Drawing.Point(31, 257);
            this.StartButton.Name = "StartButton";
            this.StartButton.ShadowDecoration.Parent = this.StartButton;
            this.StartButton.Size = new System.Drawing.Size(149, 28);
            this.StartButton.TabIndex = 11;
            this.StartButton.Text = "Start";
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ThreadLabelValue
            // 
            this.ThreadLabelValue.BackColor = System.Drawing.Color.Transparent;
            this.ThreadLabelValue.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreadLabelValue.ForeColor = System.Drawing.Color.White;
            this.ThreadLabelValue.Location = new System.Drawing.Point(134, 201);
            this.ThreadLabelValue.Name = "ThreadLabelValue";
            this.ThreadLabelValue.Size = new System.Drawing.Size(58, 17);
            this.ThreadLabelValue.TabIndex = 10;
            this.ThreadLabelValue.Text = "0";
            this.ThreadLabelValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SOCKS5Toggle
            // 
            this.SOCKS5Toggle.AutoSize = true;
            this.SOCKS5Toggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SOCKS5Toggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.SOCKS5Toggle.CheckedState.BorderThickness = 0;
            this.SOCKS5Toggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.SOCKS5Toggle.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.SOCKS5Toggle.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SOCKS5Toggle.Location = new System.Drawing.Point(34, 172);
            this.SOCKS5Toggle.Name = "SOCKS5Toggle";
            this.SOCKS5Toggle.Size = new System.Drawing.Size(66, 21);
            this.SOCKS5Toggle.TabIndex = 7;
            this.SOCKS5Toggle.TabStop = true;
            this.SOCKS5Toggle.Text = "Socks5";
            this.SOCKS5Toggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SOCKS5Toggle.UncheckedState.BorderThickness = 2;
            this.SOCKS5Toggle.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.SOCKS5Toggle.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.SOCKS5Toggle.UseVisualStyleBackColor = false;
            // 
            // ThreadTitle
            // 
            this.ThreadTitle.AutoSize = true;
            this.ThreadTitle.BackColor = System.Drawing.Color.Transparent;
            this.ThreadTitle.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreadTitle.ForeColor = System.Drawing.Color.White;
            this.ThreadTitle.Location = new System.Drawing.Point(12, 201);
            this.ThreadTitle.Name = "ThreadTitle";
            this.ThreadTitle.Size = new System.Drawing.Size(58, 17);
            this.ThreadTitle.TabIndex = 8;
            this.ThreadTitle.Text = "Threads:";
            // 
            // LoadProxiesButton
            // 
            this.LoadProxiesButton.CheckedState.Parent = this.LoadProxiesButton;
            this.LoadProxiesButton.CustomImages.Parent = this.LoadProxiesButton;
            this.LoadProxiesButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LoadProxiesButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadProxiesButton.ForeColor = System.Drawing.Color.White;
            this.LoadProxiesButton.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.LoadProxiesButton.HoveredState.Parent = this.LoadProxiesButton;
            this.LoadProxiesButton.Location = new System.Drawing.Point(31, 82);
            this.LoadProxiesButton.Name = "LoadProxiesButton";
            this.LoadProxiesButton.ShadowDecoration.Parent = this.LoadProxiesButton;
            this.LoadProxiesButton.Size = new System.Drawing.Size(149, 28);
            this.LoadProxiesButton.TabIndex = 2;
            this.LoadProxiesButton.Text = "Load Proxies";
            this.LoadProxiesButton.Click += new System.EventHandler(this.LoadProxiesButton_Click);
            // 
            // ThreadBar
            // 
            this.ThreadBar.BackColor = System.Drawing.Color.Transparent;
            this.ThreadBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ThreadBar.HoveredState.Parent = this.ThreadBar;
            this.ThreadBar.Location = new System.Drawing.Point(15, 221);
            this.ThreadBar.Maximum = 200;
            this.ThreadBar.Minimum = 1;
            this.ThreadBar.Name = "ThreadBar";
            this.ThreadBar.Size = new System.Drawing.Size(177, 23);
            this.ThreadBar.TabIndex = 9;
            this.ThreadBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.ThreadBar.Value = 100;
            this.ThreadBar.ValueChanged += new System.EventHandler(this.ThreadBar_ValueChanged);
            // 
            // SOCKS4Toggle
            // 
            this.SOCKS4Toggle.AutoSize = true;
            this.SOCKS4Toggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SOCKS4Toggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.SOCKS4Toggle.CheckedState.BorderThickness = 0;
            this.SOCKS4Toggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.SOCKS4Toggle.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.SOCKS4Toggle.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SOCKS4Toggle.Location = new System.Drawing.Point(34, 145);
            this.SOCKS4Toggle.Name = "SOCKS4Toggle";
            this.SOCKS4Toggle.Size = new System.Drawing.Size(66, 21);
            this.SOCKS4Toggle.TabIndex = 6;
            this.SOCKS4Toggle.TabStop = true;
            this.SOCKS4Toggle.Text = "Socks4";
            this.SOCKS4Toggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SOCKS4Toggle.UncheckedState.BorderThickness = 2;
            this.SOCKS4Toggle.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.SOCKS4Toggle.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.SOCKS4Toggle.UseVisualStyleBackColor = false;
            // 
            // LoadEmailButton
            // 
            this.LoadEmailButton.CheckedState.Parent = this.LoadEmailButton;
            this.LoadEmailButton.CustomImages.Parent = this.LoadEmailButton;
            this.LoadEmailButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LoadEmailButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadEmailButton.ForeColor = System.Drawing.Color.White;
            this.LoadEmailButton.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.LoadEmailButton.HoveredState.Parent = this.LoadEmailButton;
            this.LoadEmailButton.Location = new System.Drawing.Point(31, 48);
            this.LoadEmailButton.Name = "LoadEmailButton";
            this.LoadEmailButton.ShadowDecoration.Parent = this.LoadEmailButton;
            this.LoadEmailButton.Size = new System.Drawing.Size(149, 28);
            this.LoadEmailButton.TabIndex = 1;
            this.LoadEmailButton.Text = "Load Emails";
            this.LoadEmailButton.Click += new System.EventHandler(this.LoadEmailButton_Click);
            // 
            // HTTPToggle
            // 
            this.HTTPToggle.AutoSize = true;
            this.HTTPToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.HTTPToggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.HTTPToggle.CheckedState.BorderThickness = 0;
            this.HTTPToggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.HTTPToggle.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.HTTPToggle.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HTTPToggle.Location = new System.Drawing.Point(34, 118);
            this.HTTPToggle.Name = "HTTPToggle";
            this.HTTPToggle.Size = new System.Drawing.Size(67, 21);
            this.HTTPToggle.TabIndex = 5;
            this.HTTPToggle.TabStop = true;
            this.HTTPToggle.Text = "HTTP/s";
            this.HTTPToggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.HTTPToggle.UncheckedState.BorderThickness = 2;
            this.HTTPToggle.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.HTTPToggle.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.HTTPToggle.UseVisualStyleBackColor = false;
            // 
            // Drag
            // 
            this.Drag.TargetControl = this.TopPanel;
            // 
            // CheckedEmailValue
            // 
            this.CheckedEmailValue.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckedEmailValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CheckedEmailValue.Location = new System.Drawing.Point(608, 321);
            this.CheckedEmailValue.Name = "CheckedEmailValue";
            this.CheckedEmailValue.Size = new System.Drawing.Size(76, 17);
            this.CheckedEmailValue.TabIndex = 28;
            this.CheckedEmailValue.Text = "0";
            this.CheckedEmailValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CheckedLabel
            // 
            this.CheckedLabel.AutoSize = true;
            this.CheckedLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CheckedLabel.Location = new System.Drawing.Point(554, 321);
            this.CheckedLabel.Name = "CheckedLabel";
            this.CheckedLabel.Size = new System.Drawing.Size(60, 17);
            this.CheckedLabel.TabIndex = 27;
            this.CheckedLabel.Text = "Checked:";
            // 
            // ErrorValue
            // 
            this.ErrorValue.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorValue.ForeColor = System.Drawing.Color.Yellow;
            this.ErrorValue.Location = new System.Drawing.Point(608, 294);
            this.ErrorValue.Name = "ErrorValue";
            this.ErrorValue.Size = new System.Drawing.Size(76, 17);
            this.ErrorValue.TabIndex = 26;
            this.ErrorValue.Text = "0";
            this.ErrorValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Yellow;
            this.ErrorLabel.Location = new System.Drawing.Point(554, 294);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(47, 17);
            this.ErrorLabel.TabIndex = 25;
            this.ErrorLabel.Text = "Errors:";
            // 
            // InvalidEmailValue
            // 
            this.InvalidEmailValue.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidEmailValue.ForeColor = System.Drawing.Color.Red;
            this.InvalidEmailValue.Location = new System.Drawing.Point(476, 321);
            this.InvalidEmailValue.Name = "InvalidEmailValue";
            this.InvalidEmailValue.Size = new System.Drawing.Size(74, 17);
            this.InvalidEmailValue.TabIndex = 24;
            this.InvalidEmailValue.Text = "0";
            this.InvalidEmailValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // InvalidEmailLabel
            // 
            this.InvalidEmailLabel.AutoSize = true;
            this.InvalidEmailLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidEmailLabel.ForeColor = System.Drawing.Color.Red;
            this.InvalidEmailLabel.Location = new System.Drawing.Point(387, 321);
            this.InvalidEmailLabel.Name = "InvalidEmailLabel";
            this.InvalidEmailLabel.Size = new System.Drawing.Size(89, 17);
            this.InvalidEmailLabel.TabIndex = 23;
            this.InvalidEmailLabel.Text = "Invalid Emails:";
            // 
            // ValidEmailValue
            // 
            this.ValidEmailValue.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidEmailValue.ForeColor = System.Drawing.Color.Lime;
            this.ValidEmailValue.Location = new System.Drawing.Point(473, 294);
            this.ValidEmailValue.Name = "ValidEmailValue";
            this.ValidEmailValue.Size = new System.Drawing.Size(77, 17);
            this.ValidEmailValue.TabIndex = 22;
            this.ValidEmailValue.Text = "0";
            this.ValidEmailValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ValidEmailLabel
            // 
            this.ValidEmailLabel.AutoSize = true;
            this.ValidEmailLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidEmailLabel.ForeColor = System.Drawing.Color.Lime;
            this.ValidEmailLabel.Location = new System.Drawing.Point(387, 294);
            this.ValidEmailLabel.Name = "ValidEmailLabel";
            this.ValidEmailLabel.Size = new System.Drawing.Size(80, 17);
            this.ValidEmailLabel.TabIndex = 21;
            this.ValidEmailLabel.Text = "Valid Emails:";
            // 
            // LoadedProxyValue
            // 
            this.LoadedProxyValue.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadedProxyValue.ForeColor = System.Drawing.Color.White;
            this.LoadedProxyValue.Location = new System.Drawing.Point(289, 321);
            this.LoadedProxyValue.Name = "LoadedProxyValue";
            this.LoadedProxyValue.Size = new System.Drawing.Size(76, 17);
            this.LoadedProxyValue.TabIndex = 20;
            this.LoadedProxyValue.Text = "0";
            this.LoadedProxyValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LoadedProxyLabel
            // 
            this.LoadedProxyLabel.AutoSize = true;
            this.LoadedProxyLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadedProxyLabel.ForeColor = System.Drawing.Color.White;
            this.LoadedProxyLabel.Location = new System.Drawing.Point(235, 321);
            this.LoadedProxyLabel.Name = "LoadedProxyLabel";
            this.LoadedProxyLabel.Size = new System.Drawing.Size(53, 17);
            this.LoadedProxyLabel.TabIndex = 19;
            this.LoadedProxyLabel.Text = "Proxies:";
            // 
            // LoadedEmailValue
            // 
            this.LoadedEmailValue.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadedEmailValue.ForeColor = System.Drawing.Color.White;
            this.LoadedEmailValue.Location = new System.Drawing.Point(289, 294);
            this.LoadedEmailValue.Name = "LoadedEmailValue";
            this.LoadedEmailValue.Size = new System.Drawing.Size(76, 17);
            this.LoadedEmailValue.TabIndex = 18;
            this.LoadedEmailValue.Text = "0";
            this.LoadedEmailValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LoadedEmailsLabel
            // 
            this.LoadedEmailsLabel.AutoSize = true;
            this.LoadedEmailsLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadedEmailsLabel.ForeColor = System.Drawing.Color.White;
            this.LoadedEmailsLabel.Location = new System.Drawing.Point(235, 294);
            this.LoadedEmailsLabel.Name = "LoadedEmailsLabel";
            this.LoadedEmailsLabel.Size = new System.Drawing.Size(48, 17);
            this.LoadedEmailsLabel.TabIndex = 16;
            this.LoadedEmailsLabel.Text = "Emails:";
            // 
            // ValidEmailBar
            // 
            this.ValidEmailBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ValidEmailBar.Controls.Add(this.EmailTitle);
            this.ValidEmailBar.Location = new System.Drawing.Point(232, 46);
            this.ValidEmailBar.Name = "ValidEmailBar";
            this.ValidEmailBar.ShadowDecoration.Parent = this.ValidEmailBar;
            this.ValidEmailBar.Size = new System.Drawing.Size(462, 42);
            this.ValidEmailBar.TabIndex = 17;
            // 
            // EmailTitle
            // 
            this.EmailTitle.AutoSize = true;
            this.EmailTitle.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTitle.ForeColor = System.Drawing.Color.White;
            this.EmailTitle.Location = new System.Drawing.Point(185, 11);
            this.EmailTitle.Name = "EmailTitle";
            this.EmailTitle.Size = new System.Drawing.Size(89, 20);
            this.EmailTitle.TabIndex = 3;
            this.EmailTitle.Text = "Valid Emails";
            // 
            // ResultListView
            // 
            this.ResultListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ResultListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ValidEmailHeader});
            this.ResultListView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultListView.ForeColor = System.Drawing.Color.White;
            this.ResultListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ResultListView.HideSelection = false;
            this.ResultListView.Location = new System.Drawing.Point(232, 87);
            this.ResultListView.Name = "ResultListView";
            this.ResultListView.Size = new System.Drawing.Size(462, 196);
            this.ResultListView.TabIndex = 15;
            this.ResultListView.UseCompatibleStateImageBehavior = false;
            this.ResultListView.View = System.Windows.Forms.View.Details;
            // 
            // ValidEmailHeader
            // 
            this.ValidEmailHeader.Text = "Valid Emails";
            this.ValidEmailHeader.Width = 388;
            // 
            // ProxylessToggle
            // 
            this.ProxylessToggle.AutoSize = true;
            this.ProxylessToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ProxylessToggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.ProxylessToggle.CheckedState.BorderThickness = 0;
            this.ProxylessToggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.ProxylessToggle.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.ProxylessToggle.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProxylessToggle.Location = new System.Drawing.Point(102, 118);
            this.ProxylessToggle.Name = "ProxylessToggle";
            this.ProxylessToggle.Size = new System.Drawing.Size(80, 21);
            this.ProxylessToggle.TabIndex = 12;
            this.ProxylessToggle.TabStop = true;
            this.ProxylessToggle.Text = "Proxyless";
            this.ProxylessToggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ProxylessToggle.UncheckedState.BorderThickness = 2;
            this.ProxylessToggle.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ProxylessToggle.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.ProxylessToggle.UseVisualStyleBackColor = false;
            // 
            // Checker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(704, 353);
            this.Controls.Add(this.CheckedEmailValue);
            this.Controls.Add(this.CheckedLabel);
            this.Controls.Add(this.ErrorValue);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.InvalidEmailValue);
            this.Controls.Add(this.InvalidEmailLabel);
            this.Controls.Add(this.ValidEmailValue);
            this.Controls.Add(this.ValidEmailLabel);
            this.Controls.Add(this.LoadedProxyValue);
            this.Controls.Add(this.LoadedProxyLabel);
            this.Controls.Add(this.LoadedEmailValue);
            this.Controls.Add(this.LoadedEmailsLabel);
            this.Controls.Add(this.ValidEmailBar);
            this.Controls.Add(this.ResultListView);
            this.Controls.Add(this.SetupGB);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Checker";
            this.Text = "Origin Valid Email Checker";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.SetupGB.ResumeLayout(false);
            this.SetupGB.PerformLayout();
            this.ValidEmailBar.ResumeLayout(false);
            this.ValidEmailBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private ns1.SiticoneControlBox MiniButton;
        private ns1.SiticoneControlBox CloseButton;
        private System.Windows.Forms.Label Title;
        private ns1.SiticoneGroupBox SetupGB;
        private ns1.SiticoneButton LoadEmailButton;
        private ns1.SiticoneDragControl Drag;
        private ns1.SiticoneRadioButton SOCKS5Toggle;
        private ns1.SiticoneButton LoadProxiesButton;
        private ns1.SiticoneRadioButton SOCKS4Toggle;
        private ns1.SiticoneRadioButton HTTPToggle;
        private ns1.SiticoneButton StartButton;
        private System.Windows.Forms.Label ThreadLabelValue;
        private System.Windows.Forms.Label ThreadTitle;
        private ns1.SiticoneTrackBar ThreadBar;
        private System.Windows.Forms.Label CheckedEmailValue;
        private System.Windows.Forms.Label CheckedLabel;
        private System.Windows.Forms.Label ErrorValue;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label InvalidEmailValue;
        private System.Windows.Forms.Label InvalidEmailLabel;
        private System.Windows.Forms.Label ValidEmailValue;
        private System.Windows.Forms.Label ValidEmailLabel;
        private System.Windows.Forms.Label LoadedProxyValue;
        private System.Windows.Forms.Label LoadedProxyLabel;
        private System.Windows.Forms.Label LoadedEmailValue;
        private System.Windows.Forms.Label LoadedEmailsLabel;
        private ns1.SiticonePanel ValidEmailBar;
        private System.Windows.Forms.Label EmailTitle;
        private System.Windows.Forms.ListView ResultListView;
        private System.Windows.Forms.ColumnHeader ValidEmailHeader;
        private ns1.SiticoneRadioButton ProxylessToggle;
    }
}

