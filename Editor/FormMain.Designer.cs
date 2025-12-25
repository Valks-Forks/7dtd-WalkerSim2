using System.Windows.Forms;
using System.ComponentModel;

namespace WalkerSim.Editor
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormMain));
            updateTimer = new Timer(components);
            backgroundWorker1 = new BackgroundWorker();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadConfigurationToolStripMenuItem = new ToolStripMenuItem();
            exportConfigurationToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            loadStateSaveToolStripMenuItem = new ToolStripMenuItem();
            saveStateToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            zoomSubMenu = new ToolStripMenuItem();
            xToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            inToolStripMenuItem = new ToolStripMenuItem();
            outToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            viewBiomes = new ToolStripMenuItem();
            viewRoads = new ToolStripMenuItem();
            viewAgents = new ToolStripMenuItem();
            viewActiveAgents = new ToolStripMenuItem();
            viewEvents = new ToolStripMenuItem();
            viewPrefabs = new ToolStripMenuItem();
            simulationToolStripMenuItem = new ToolStripMenuItem();
            startToolStripMenuItem = new ToolStripMenuItem();
            stopToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            pauseToolStripMenuItem = new ToolStripMenuItem();
            resumeToolStripMenuItem = new ToolStripMenuItem();
            speedToolStripMenuItem = new ToolStripMenuItem();
            advanceOneTickToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            emitSoundToolStripMenuItem = new ToolStripMenuItem();
            killToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            addPlayerToolStripMenuItem = new ToolStripMenuItem();
            setPlayerPositionToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            documentationToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            simCanvas = new PictureBox();
            tabSimulation = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblPauseDuringBloodmoon = new WalkerSim.Editor.LabelWithHelp();
            lblStartAgentsGrouped = new WalkerSim.Editor.LabelWithHelp();
            inputSpawnProtectionTime = new NumericUpDown();
            panel1 = new Panel();
            inputRandomSeed = new NumericUpDown();
            btRand = new Button();
            inputRespawnPosition = new ComboBox();
            lblSpawnProtectionTime = new WalkerSim.Editor.LabelWithHelp();
            lblRespawnPosition = new WalkerSim.Editor.LabelWithHelp();
            inputWorld = new ComboBox();
            inputStartPosition = new ComboBox();
            label10 = new Label();
            lblStartPosition = new WalkerSim.Editor.LabelWithHelp();
            lblRandomSeed = new Label();
            lblGroupSize = new WalkerSim.Editor.LabelWithHelp();
            inputGroupSize = new NumericUpDown();
            lblPopulationDensity = new WalkerSim.Editor.LabelWithHelp();
            inputStartGrouped = new CheckBox();
            inputPauseDuringBloodmoon = new CheckBox();
            lblFastForward = new WalkerSim.Editor.LabelWithHelp();
            inputFastForward = new CheckBox();
            inputMaxAgents = new NumericUpDown();
            lblActivationRadius = new WalkerSim.Editor.LabelWithHelp();
            inputActivationRadius = new NumericUpDown();
            lblEnhancedSoundAwareness = new WalkerSim.Editor.LabelWithHelp();
            inputSoundAware = new CheckBox();
            labelWithHelp1 = new WalkerSim.Editor.LabelWithHelp();
            inputSoundDistanceScale = new NumericUpDown();
            tabPage2 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            listProcessorGroups = new ListBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            button1 = new Button();
            buttonRemoveGroup = new Button();
            buttonDuplicateGroup = new Button();
            groupProcessors = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            button4 = new Button();
            buttonRemoveProcessor = new Button();
            listProcessors = new ListBox();
            groupParameter = new GroupBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            inputProcessorPower = new NumericUpDown();
            label9 = new Label();
            label8 = new Label();
            inputProcessorDistance = new NumericUpDown();
            groupProps = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel2 = new Panel();
            boxGroupColor = new PictureBox();
            buttonGroupColor = new Button();
            inputPostSpawnBehavior = new ComboBox();
            inputAffectedGroup = new ComboBox();
            lblPostSpawnWanderSpeed = new WalkerSim.Editor.LabelWithHelp();
            lblMovementSpeed = new WalkerSim.Editor.LabelWithHelp();
            inputMovementSpeed = new NumericUpDown();
            lblAffected = new Label();
            lblGroupColor = new WalkerSim.Editor.LabelWithHelp();
            lblPostSpawnBehavior = new WalkerSim.Editor.LabelWithHelp();
            inputWanderSpeed = new ComboBox();
            lblAffectedGroup = new WalkerSim.Editor.LabelWithHelp();
            tabPage4 = new TabPage();
            lblStatGroups = new Label();
            label24 = new Label();
            lblStatUpdateTime = new Label();
            label22 = new Label();
            lblStatWindTarget = new Label();
            label20 = new Label();
            lblStatSimTime = new Label();
            label27 = new Label();
            lblStatWindChange = new Label();
            label25 = new Label();
            lblStatWindDir = new Label();
            label23 = new Label();
            lblStatTicks = new Label();
            label21 = new Label();
            lblStatActive = new Label();
            label19 = new Label();
            lblStatInactive = new Label();
            label17 = new Label();
            lblStatTotalAgents = new Label();
            label16 = new Label();
            tabPage3 = new TabPage();
            rtbLog = new RichTextBox();
            contextLog = new ContextMenuStrip(components);
            clearToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            colorPickerDlg = new ColorDialog();
            toolTipGroupSize = new ToolTip(components);
            btZoomIn = new Label();
            btZoomOut = new Label();
            label29 = new Label();
            menuStrip1.SuspendLayout();
            ((ISupportInitialize)(splitContainer1)).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((ISupportInitialize)(simCanvas)).BeginInit();
            tabSimulation.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((ISupportInitialize)(inputSpawnProtectionTime)).BeginInit();
            panel1.SuspendLayout();
            ((ISupportInitialize)(inputRandomSeed)).BeginInit();
            ((ISupportInitialize)(inputGroupSize)).BeginInit();
            ((ISupportInitialize)(inputMaxAgents)).BeginInit();
            ((ISupportInitialize)(inputActivationRadius)).BeginInit();
            ((ISupportInitialize)(inputSoundDistanceScale)).BeginInit();
            tabPage2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupProcessors.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            groupParameter.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            ((ISupportInitialize)(inputProcessorPower)).BeginInit();
            ((ISupportInitialize)(inputProcessorDistance)).BeginInit();
            groupProps.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel2.SuspendLayout();
            ((ISupportInitialize)(boxGroupColor)).BeginInit();
            ((ISupportInitialize)(inputMovementSpeed)).BeginInit();
            tabPage4.SuspendLayout();
            tabPage3.SuspendLayout();
            contextLog.SuspendLayout();
            SuspendLayout();
            // 
            // updateTimer
            // 
            updateTimer.Interval = 16;
            updateTimer.Tick += new System.EventHandler(OnTick);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] {
            fileToolStripMenuItem,
            viewToolStripMenuItem,
            simulationToolStripMenuItem,
            toolsToolStripMenuItem,
            helpToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(840, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            loadConfigurationToolStripMenuItem,
            exportConfigurationToolStripMenuItem,
            toolStripMenuItem1,
            loadStateSaveToolStripMenuItem,
            saveStateToolStripMenuItem,
            toolStripSeparator4,
            exitToolStripMenuItem});
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadConfigurationToolStripMenuItem
            // 
            loadConfigurationToolStripMenuItem.Name = "loadConfigurationToolStripMenuItem";
            loadConfigurationToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            loadConfigurationToolStripMenuItem.Text = "Import Configuration";
            loadConfigurationToolStripMenuItem.Click += new System.EventHandler(loadConfigurationToolStripMenuItem_Click);
            // 
            // exportConfigurationToolStripMenuItem
            // 
            exportConfigurationToolStripMenuItem.Name = "exportConfigurationToolStripMenuItem";
            exportConfigurationToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            exportConfigurationToolStripMenuItem.Text = "Export Configuration";
            exportConfigurationToolStripMenuItem.Click += new System.EventHandler(OnExportConfigurationClick);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(184, 6);
            // 
            // loadStateSaveToolStripMenuItem
            // 
            loadStateSaveToolStripMenuItem.Name = "loadStateSaveToolStripMenuItem";
            loadStateSaveToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            loadStateSaveToolStripMenuItem.Text = "Load State";
            loadStateSaveToolStripMenuItem.Click += new System.EventHandler(OnLoadStateClick);
            // 
            // saveStateToolStripMenuItem
            // 
            saveStateToolStripMenuItem.Name = "saveStateToolStripMenuItem";
            saveStateToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            saveStateToolStripMenuItem.Text = "Save State";
            saveStateToolStripMenuItem.Click += new System.EventHandler(OnSaveStateClick);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(184, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += new System.EventHandler(OnClickExit);
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            zoomSubMenu,
            toolStripSeparator3,
            viewBiomes,
            viewRoads,
            viewAgents,
            viewActiveAgents,
            viewEvents,
            viewPrefabs});
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // zoomSubMenu
            // 
            zoomSubMenu.DropDownItems.AddRange(new ToolStripItem[] {
            xToolStripMenuItem1,
            toolStripSeparator2,
            inToolStripMenuItem,
            outToolStripMenuItem});
            zoomSubMenu.Name = "zoomSubMenu";
            zoomSubMenu.Size = new System.Drawing.Size(155, 22);
            zoomSubMenu.Text = "Zoom";
            // 
            // xToolStripMenuItem1
            // 
            xToolStripMenuItem1.Name = "xToolStripMenuItem1";
            xToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            xToolStripMenuItem1.Text = "Reset";
            xToolStripMenuItem1.Click += new System.EventHandler(OnZoomResetClick);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(156, 6);
            // 
            // inToolStripMenuItem
            // 
            inToolStripMenuItem.Name = "inToolStripMenuItem";
            inToolStripMenuItem.ShortcutKeyDisplayString = "";
            inToolStripMenuItem.ShortcutKeys = ((Keys)((Keys.Control | Keys.Up)));
            inToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            inToolStripMenuItem.Text = "In";
            inToolStripMenuItem.Click += new System.EventHandler(OnZoomInClick);
            // 
            // outToolStripMenuItem
            // 
            outToolStripMenuItem.Name = "outToolStripMenuItem";
            outToolStripMenuItem.ShortcutKeyDisplayString = "";
            outToolStripMenuItem.ShortcutKeys = ((Keys)((Keys.Control | Keys.Down)));
            outToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            outToolStripMenuItem.Text = "Out";
            outToolStripMenuItem.Click += new System.EventHandler(OnZoomOutClick);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(152, 6);
            // 
            // viewBiomes
            // 
            viewBiomes.CheckOnClick = true;
            viewBiomes.Name = "viewBiomes";
            viewBiomes.Size = new System.Drawing.Size(155, 22);
            viewBiomes.Text = "Biomes";
            // 
            // viewRoads
            // 
            viewRoads.Checked = true;
            viewRoads.CheckOnClick = true;
            viewRoads.CheckState = CheckState.Checked;
            viewRoads.Name = "viewRoads";
            viewRoads.Size = new System.Drawing.Size(155, 22);
            viewRoads.Text = "Roads";
            // 
            // viewAgents
            // 
            viewAgents.Checked = true;
            viewAgents.CheckOnClick = true;
            viewAgents.CheckState = CheckState.Checked;
            viewAgents.Name = "viewAgents";
            viewAgents.Size = new System.Drawing.Size(155, 22);
            viewAgents.Text = "Inactive Agents";
            // 
            // viewActiveAgents
            // 
            viewActiveAgents.Checked = true;
            viewActiveAgents.CheckOnClick = true;
            viewActiveAgents.CheckState = CheckState.Checked;
            viewActiveAgents.Name = "viewActiveAgents";
            viewActiveAgents.Size = new System.Drawing.Size(155, 22);
            viewActiveAgents.Text = "Active Agents";
            // 
            // viewEvents
            // 
            viewEvents.Checked = true;
            viewEvents.CheckOnClick = true;
            viewEvents.CheckState = CheckState.Checked;
            viewEvents.Name = "viewEvents";
            viewEvents.Size = new System.Drawing.Size(155, 22);
            viewEvents.Text = "Events";
            // 
            // viewPrefabs
            // 
            viewPrefabs.CheckOnClick = true;
            viewPrefabs.Name = "viewPrefabs";
            viewPrefabs.Size = new System.Drawing.Size(155, 22);
            viewPrefabs.Text = "Prefabs";
            // 
            // simulationToolStripMenuItem
            // 
            simulationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            startToolStripMenuItem,
            stopToolStripMenuItem,
            resetToolStripMenuItem,
            toolStripMenuItem3,
            pauseToolStripMenuItem,
            resumeToolStripMenuItem,
            speedToolStripMenuItem,
            advanceOneTickToolStripMenuItem});
            simulationToolStripMenuItem.Name = "simulationToolStripMenuItem";
            simulationToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            simulationToolStripMenuItem.Text = "Simulation";
            // 
            // startToolStripMenuItem
            // 
            startToolStripMenuItem.Name = "startToolStripMenuItem";
            startToolStripMenuItem.ShortcutKeys = Keys.F5;
            startToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            startToolStripMenuItem.Text = "Start";
            startToolStripMenuItem.Click += new System.EventHandler(OnRestartClick);
            // 
            // stopToolStripMenuItem
            // 
            stopToolStripMenuItem.Enabled = false;
            stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            stopToolStripMenuItem.ShortcutKeys = ((Keys)((Keys.Shift | Keys.F5)));
            stopToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            stopToolStripMenuItem.Text = "Stop";
            stopToolStripMenuItem.Click += new System.EventHandler(OnStopClick);
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            resetToolStripMenuItem.Text = "Reset";
            resetToolStripMenuItem.Click += new System.EventHandler(OnResetClick);
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new System.Drawing.Size(190, 6);
            // 
            // pauseToolStripMenuItem
            // 
            pauseToolStripMenuItem.Enabled = false;
            pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            pauseToolStripMenuItem.ShortcutKeys = ((Keys)(((Keys.Control | Keys.Alt) 
            | Keys.Pause)));
            pauseToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            pauseToolStripMenuItem.Text = "Pause";
            pauseToolStripMenuItem.Click += new System.EventHandler(OnPauseClick);
            // 
            // resumeToolStripMenuItem
            // 
            resumeToolStripMenuItem.Enabled = false;
            resumeToolStripMenuItem.Name = "resumeToolStripMenuItem";
            resumeToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            resumeToolStripMenuItem.Text = "Resume";
            resumeToolStripMenuItem.Click += new System.EventHandler(OnResumeClick);
            // 
            // speedToolStripMenuItem
            // 
            speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            speedToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            speedToolStripMenuItem.Text = "Speed";
            // 
            // advanceOneTickToolStripMenuItem
            // 
            advanceOneTickToolStripMenuItem.Enabled = false;
            advanceOneTickToolStripMenuItem.Name = "advanceOneTickToolStripMenuItem";
            advanceOneTickToolStripMenuItem.ShortcutKeys = Keys.F10;
            advanceOneTickToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            advanceOneTickToolStripMenuItem.Text = "Advance one Tick";
            advanceOneTickToolStripMenuItem.Click += new System.EventHandler(OnAdvanceTick);
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            emitSoundToolStripMenuItem,
            killToolStripMenuItem,
            toolStripSeparator1,
            addPlayerToolStripMenuItem,
            setPlayerPositionToolStripMenuItem});
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // emitSoundToolStripMenuItem
            // 
            emitSoundToolStripMenuItem.Name = "emitSoundToolStripMenuItem";
            emitSoundToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            emitSoundToolStripMenuItem.Text = "Emit Sound";
            emitSoundToolStripMenuItem.Click += new System.EventHandler(OnClickSoundEmit);
            // 
            // killToolStripMenuItem
            // 
            killToolStripMenuItem.Name = "killToolStripMenuItem";
            killToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            killToolStripMenuItem.Text = "Kill";
            killToolStripMenuItem.Click += new System.EventHandler(OnClickKill);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // addPlayerToolStripMenuItem
            // 
            addPlayerToolStripMenuItem.Name = "addPlayerToolStripMenuItem";
            addPlayerToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            addPlayerToolStripMenuItem.Text = "Add Player";
            addPlayerToolStripMenuItem.Click += new System.EventHandler(OnAddPlayerClick);
            // 
            // setPlayerPositionToolStripMenuItem
            // 
            setPlayerPositionToolStripMenuItem.Name = "setPlayerPositionToolStripMenuItem";
            setPlayerPositionToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            setPlayerPositionToolStripMenuItem.Text = "Set Player Position";
            setPlayerPositionToolStripMenuItem.Click += new System.EventHandler(OnSetPlayerPosClick);
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            documentationToolStripMenuItem});
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // documentationToolStripMenuItem
            // 
            documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            documentationToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            documentationToolStripMenuItem.Text = "Online Documentaion";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.Location = new System.Drawing.Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AutoScroll = true;
            splitContainer1.Panel1.BackColor = System.Drawing.Color.Black;
            splitContainer1.Panel1.Controls.Add(simCanvas);
            splitContainer1.Panel1.SizeChanged += new System.EventHandler(OnResizeCanvas);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabSimulation);
            splitContainer1.Size = new System.Drawing.Size(840, 692);
            splitContainer1.SplitterDistance = 461;
            splitContainer1.TabIndex = 5;
            splitContainer1.SplitterMoved += new SplitterEventHandler(OnSplitContainerMove);
            // 
            // simCanvas
            // 
            simCanvas.BackColor = System.Drawing.Color.Black;
            simCanvas.Location = new System.Drawing.Point(147, 3);
            simCanvas.Name = "simCanvas";
            simCanvas.Size = new System.Drawing.Size(562, 448);
            simCanvas.SizeMode = PictureBoxSizeMode.AutoSize;
            simCanvas.TabIndex = 6;
            simCanvas.TabStop = false;
            simCanvas.MouseClick += new MouseEventHandler(OnSimCanvasClick);
            // 
            // tabSimulation
            // 
            tabSimulation.Controls.Add(tabPage1);
            tabSimulation.Controls.Add(tabPage2);
            tabSimulation.Controls.Add(tabPage4);
            tabSimulation.Controls.Add(tabPage3);
            tabSimulation.Dock = DockStyle.Fill;
            tabSimulation.Location = new System.Drawing.Point(0, 0);
            tabSimulation.Name = "tabSimulation";
            tabSimulation.SelectedIndex = 0;
            tabSimulation.Size = new System.Drawing.Size(840, 227);
            tabSimulation.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new System.Drawing.Point(4, 22);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new System.Drawing.Size(832, 201);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Base Parameters";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.61259F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.55932F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.46489F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.98063F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.84988F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.41162F));
            tableLayoutPanel1.Controls.Add(lblPauseDuringBloodmoon, 4, 2);
            tableLayoutPanel1.Controls.Add(lblStartAgentsGrouped, 4, 1);
            tableLayoutPanel1.Controls.Add(inputSpawnProtectionTime, 1, 5);
            tableLayoutPanel1.Controls.Add(panel1, 1, 2);
            tableLayoutPanel1.Controls.Add(inputRespawnPosition, 3, 2);
            tableLayoutPanel1.Controls.Add(lblSpawnProtectionTime, 0, 5);
            tableLayoutPanel1.Controls.Add(lblRespawnPosition, 2, 2);
            tableLayoutPanel1.Controls.Add(inputWorld, 1, 1);
            tableLayoutPanel1.Controls.Add(inputStartPosition, 3, 1);
            tableLayoutPanel1.Controls.Add(label10, 0, 1);
            tableLayoutPanel1.Controls.Add(lblStartPosition, 2, 1);
            tableLayoutPanel1.Controls.Add(lblRandomSeed, 0, 2);
            tableLayoutPanel1.Controls.Add(lblGroupSize, 0, 3);
            tableLayoutPanel1.Controls.Add(inputGroupSize, 1, 3);
            tableLayoutPanel1.Controls.Add(lblPopulationDensity, 0, 4);
            tableLayoutPanel1.Controls.Add(inputStartGrouped, 5, 1);
            tableLayoutPanel1.Controls.Add(inputPauseDuringBloodmoon, 5, 2);
            tableLayoutPanel1.Controls.Add(lblFastForward, 4, 3);
            tableLayoutPanel1.Controls.Add(inputFastForward, 5, 3);
            tableLayoutPanel1.Controls.Add(inputMaxAgents, 1, 4);
            tableLayoutPanel1.Controls.Add(lblActivationRadius, 2, 3);
            tableLayoutPanel1.Controls.Add(inputActivationRadius, 3, 3);
            tableLayoutPanel1.Controls.Add(lblEnhancedSoundAwareness, 4, 4);
            tableLayoutPanel1.Controls.Add(inputSoundAware, 5, 4);
            tableLayoutPanel1.Controls.Add(labelWithHelp1, 2, 4);
            tableLayoutPanel1.Controls.Add(inputSoundDistanceScale, 3, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(826, 195);
            tableLayoutPanel1.TabIndex = 47;
            // 
            // lblPauseDuringBloodmoon
            // 
            lblPauseDuringBloodmoon.AutoSize = true;
            lblPauseDuringBloodmoon.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            lblPauseDuringBloodmoon.Dock = DockStyle.Fill;
            lblPauseDuringBloodmoon.HelpUrl = null;
            lblPauseDuringBloodmoon.LabelText = "Pause during Bloodmoon";
            lblPauseDuringBloodmoon.Location = new System.Drawing.Point(546, 35);
            lblPauseDuringBloodmoon.Margin = new Padding(4, 0, 0, 2);
            lblPauseDuringBloodmoon.Name = "lblPauseDuringBloodmoon";
            lblPauseDuringBloodmoon.Padding = new Padding(0, 2, 0, 0);
            lblPauseDuringBloodmoon.Size = new System.Drawing.Size(193, 28);
            lblPauseDuringBloodmoon.TabIndex = 50;
            // 
            // lblStartAgentsGrouped
            // 
            lblStartAgentsGrouped.AutoSize = true;
            lblStartAgentsGrouped.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            lblStartAgentsGrouped.Dock = DockStyle.Fill;
            lblStartAgentsGrouped.HelpUrl = null;
            lblStartAgentsGrouped.LabelText = "Start Agents Grouped";
            lblStartAgentsGrouped.Location = new System.Drawing.Point(546, 5);
            lblStartAgentsGrouped.Margin = new Padding(4, 0, 0, 2);
            lblStartAgentsGrouped.Name = "lblStartAgentsGrouped";
            lblStartAgentsGrouped.Padding = new Padding(0, 2, 0, 0);
            lblStartAgentsGrouped.Size = new System.Drawing.Size(193, 28);
            lblStartAgentsGrouped.TabIndex = 49;
            // 
            // inputSpawnProtectionTime
            // 
            inputSpawnProtectionTime.Location = new System.Drawing.Point(162, 125);
            inputSpawnProtectionTime.Margin = new Padding(0);
            inputSpawnProtectionTime.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            inputSpawnProtectionTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            inputSpawnProtectionTime.Name = "inputSpawnProtectionTime";
            inputSpawnProtectionTime.Size = new System.Drawing.Size(112, 20);
            inputSpawnProtectionTime.TabIndex = 45;
            inputSpawnProtectionTime.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // panel1
            // 
            panel1.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            panel1.AutoSize = true;
            panel1.Controls.Add(inputRandomSeed);
            panel1.Controls.Add(btRand);
            panel1.Location = new System.Drawing.Point(162, 35);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(112, 20);
            panel1.TabIndex = 48;
            // 
            // inputRandomSeed
            // 
            inputRandomSeed.AutoSize = true;
            inputRandomSeed.Dock = DockStyle.Fill;
            inputRandomSeed.Location = new System.Drawing.Point(0, 0);
            inputRandomSeed.Margin = new Padding(0);
            inputRandomSeed.Maximum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            0});
            inputRandomSeed.Name = "inputRandomSeed";
            inputRandomSeed.Size = new System.Drawing.Size(87, 20);
            inputRandomSeed.TabIndex = 28;
            // 
            // btRand
            // 
            btRand.AutoSize = true;
            btRand.Dock = DockStyle.Right;
            btRand.Location = new System.Drawing.Point(87, 0);
            btRand.Margin = new Padding(0);
            btRand.Name = "btRand";
            btRand.Size = new System.Drawing.Size(25, 20);
            btRand.TabIndex = 43;
            btRand.Text = "R";
            btRand.UseVisualStyleBackColor = true;
            btRand.Click += new System.EventHandler(OnRandSeedClick);
            // 
            // inputRespawnPosition
            // 
            inputRespawnPosition.Dock = DockStyle.Fill;
            inputRespawnPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            inputRespawnPosition.FormattingEnabled = true;
            inputRespawnPosition.Location = new System.Drawing.Point(410, 35);
            inputRespawnPosition.Margin = new Padding(0);
            inputRespawnPosition.Name = "inputRespawnPosition";
            inputRespawnPosition.Size = new System.Drawing.Size(132, 21);
            inputRespawnPosition.TabIndex = 37;
            // 
            // lblSpawnProtectionTime
            // 
            lblSpawnProtectionTime.AutoSize = true;
            lblSpawnProtectionTime.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            lblSpawnProtectionTime.Dock = DockStyle.Fill;
            lblSpawnProtectionTime.HelpUrl = null;
            lblSpawnProtectionTime.LabelText = "Spawn Protection Time";
            lblSpawnProtectionTime.Location = new System.Drawing.Point(0, 125);
            lblSpawnProtectionTime.Margin = new Padding(0);
            lblSpawnProtectionTime.Name = "lblSpawnProtectionTime";
            lblSpawnProtectionTime.Padding = new Padding(0, 2, 0, 0);
            lblSpawnProtectionTime.Size = new System.Drawing.Size(162, 30);
            lblSpawnProtectionTime.TabIndex = 46;
            // 
            // lblRespawnPosition
            // 
            lblRespawnPosition.AutoSize = true;
            lblRespawnPosition.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            lblRespawnPosition.Dock = DockStyle.Fill;
            lblRespawnPosition.HelpUrl = null;
            lblRespawnPosition.LabelText = "Respawn Position";
            lblRespawnPosition.Location = new System.Drawing.Point(278, 35);
            lblRespawnPosition.Margin = new Padding(4, 0, 0, 2);
            lblRespawnPosition.Name = "lblRespawnPosition";
            lblRespawnPosition.Padding = new Padding(0, 2, 0, 0);
            lblRespawnPosition.Size = new System.Drawing.Size(132, 28);
            lblRespawnPosition.TabIndex = 36;
            // 
            // inputWorld
            // 
            inputWorld.Dock = DockStyle.Fill;
            inputWorld.DropDownStyle = ComboBoxStyle.DropDownList;
            inputWorld.FormattingEnabled = true;
            inputWorld.Location = new System.Drawing.Point(162, 5);
            inputWorld.Margin = new Padding(0);
            inputWorld.Name = "inputWorld";
            inputWorld.Size = new System.Drawing.Size(112, 21);
            inputWorld.TabIndex = 41;
            inputWorld.SelectedIndexChanged += new System.EventHandler(OnWorldSelectionChanged);
            // 
            // inputStartPosition
            // 
            inputStartPosition.Dock = DockStyle.Fill;
            inputStartPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            inputStartPosition.FormattingEnabled = true;
            inputStartPosition.Location = new System.Drawing.Point(410, 5);
            inputStartPosition.Margin = new Padding(0);
            inputStartPosition.Name = "inputStartPosition";
            inputStartPosition.Size = new System.Drawing.Size(132, 21);
            inputStartPosition.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new System.Drawing.Point(0, 5);
            label10.Margin = new Padding(0);
            label10.Name = "label10";
            label10.Padding = new Padding(0, 2, 0, 0);
            label10.Size = new System.Drawing.Size(162, 30);
            label10.TabIndex = 40;
            label10.Text = "World";

            // 
            // lblStartPosition
            // 
            lblStartPosition.AutoSize = true;
            lblStartPosition.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            lblStartPosition.Dock = DockStyle.Fill;
            lblStartPosition.HelpUrl = null;
            lblStartPosition.LabelText = "Start Position";
            lblStartPosition.Location = new System.Drawing.Point(278, 5);
            lblStartPosition.Margin = new Padding(4, 0, 0, 2);
            lblStartPosition.Name = "lblStartPosition";
            lblStartPosition.Padding = new Padding(0, 2, 0, 0);
            lblStartPosition.Size = new System.Drawing.Size(132, 28);
            lblStartPosition.TabIndex = 34;
            // 
            // lblRandomSeed
            // 
            lblRandomSeed.AutoSize = true;
            lblRandomSeed.Dock = DockStyle.Fill;
            lblRandomSeed.Location = new System.Drawing.Point(0, 35);
            lblRandomSeed.Margin = new Padding(0);
            lblRandomSeed.Name = "lblRandomSeed";
            lblRandomSeed.Padding = new Padding(0, 2, 0, 0);
            lblRandomSeed.Size = new System.Drawing.Size(162, 30);
            lblRandomSeed.TabIndex = 29;
            lblRandomSeed.Text = "Random Seed";
            // 
            // lblGroupSize
            // 
            lblGroupSize.AutoSize = true;
            lblGroupSize.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            lblGroupSize.Dock = DockStyle.Fill;
            lblGroupSize.HelpUrl = null;
            lblGroupSize.LabelText = "Group Size";
            lblGroupSize.Location = new System.Drawing.Point(0, 65);
            lblGroupSize.Margin = new Padding(0);
            lblGroupSize.Name = "lblGroupSize";
            lblGroupSize.Padding = new Padding(0, 2, 0, 0);
            lblGroupSize.Size = new System.Drawing.Size(162, 30);
            lblGroupSize.TabIndex = 33;
            // 
            // inputGroupSize
            // 
            inputGroupSize.Dock = DockStyle.Fill;
            inputGroupSize.Location = new System.Drawing.Point(162, 65);
            inputGroupSize.Margin = new Padding(0);
            inputGroupSize.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            inputGroupSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            inputGroupSize.Name = "inputGroupSize";
            inputGroupSize.Size = new System.Drawing.Size(112, 20);
            inputGroupSize.TabIndex = 32;
            inputGroupSize.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // lblPopulationDensity
            // 
            lblPopulationDensity.AutoSize = true;
            lblPopulationDensity.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            lblPopulationDensity.Dock = DockStyle.Fill;
            lblPopulationDensity.HelpUrl = null;
            lblPopulationDensity.LabelText = "Population Density";
            lblPopulationDensity.Location = new System.Drawing.Point(0, 95);
            lblPopulationDensity.Margin = new Padding(0);
            lblPopulationDensity.Name = "lblPopulationDensity";
            lblPopulationDensity.Padding = new Padding(0, 2, 0, 0);
            lblPopulationDensity.Size = new System.Drawing.Size(162, 30);
            lblPopulationDensity.TabIndex = 31;
            // 
            // inputStartGrouped
            // 
            inputStartGrouped.AutoSize = true;
            inputStartGrouped.Location = new System.Drawing.Point(742, 8);
            inputStartGrouped.Name = "inputStartGrouped";
            inputStartGrouped.Size = new System.Drawing.Size(15, 14);
            inputStartGrouped.TabIndex = 27;
            inputStartGrouped.UseVisualStyleBackColor = true;
            // 
            // inputPauseDuringBloodmoon
            // 
            inputPauseDuringBloodmoon.AutoSize = true;
            inputPauseDuringBloodmoon.Location = new System.Drawing.Point(742, 38);
            inputPauseDuringBloodmoon.Name = "inputPauseDuringBloodmoon";
            inputPauseDuringBloodmoon.Size = new System.Drawing.Size(15, 14);
            inputPauseDuringBloodmoon.TabIndex = 39;
            inputPauseDuringBloodmoon.UseVisualStyleBackColor = true;
            // 
            // lblFastForward
            // 
            lblFastForward.AutoSize = true;
            lblFastForward.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            lblFastForward.Dock = DockStyle.Fill;
            lblFastForward.HelpUrl = null;
            lblFastForward.LabelText = "Fast forward at start";
            lblFastForward.Location = new System.Drawing.Point(546, 65);
            lblFastForward.Margin = new Padding(4, 0, 0, 2);
            lblFastForward.Name = "lblFastForward";
            lblFastForward.Padding = new Padding(0, 2, 0, 0);
            lblFastForward.Size = new System.Drawing.Size(193, 28);
            lblFastForward.TabIndex = 51;
            // 
            // inputFastForward
            // 
            inputFastForward.AutoSize = true;
            inputFastForward.Location = new System.Drawing.Point(742, 68);
            inputFastForward.Name = "inputFastForward";
            inputFastForward.Size = new System.Drawing.Size(15, 14);
            inputFastForward.TabIndex = 44;
            inputFastForward.UseVisualStyleBackColor = true;
            // 
            // inputMaxAgents
            // 
            inputMaxAgents.AutoSize = true;
            inputMaxAgents.Dock = DockStyle.Fill;
            inputMaxAgents.Location = new System.Drawing.Point(162, 95);
            inputMaxAgents.Margin = new Padding(0);
            inputMaxAgents.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            inputMaxAgents.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            inputMaxAgents.Name = "inputMaxAgents";
            inputMaxAgents.Size = new System.Drawing.Size(112, 20);
            inputMaxAgents.TabIndex = 52;
            inputMaxAgents.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // lblActivationRadius
            // 
            lblActivationRadius.AutoSize = true;
            lblActivationRadius.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            lblActivationRadius.Dock = DockStyle.Fill;
            lblActivationRadius.HelpUrl = null;
            lblActivationRadius.LabelText = "Activation Radius";
            lblActivationRadius.Location = new System.Drawing.Point(278, 65);
            lblActivationRadius.Margin = new Padding(4, 0, 0, 2);
            lblActivationRadius.Name = "lblActivationRadius";
            lblActivationRadius.Padding = new Padding(0, 2, 0, 0);
            lblActivationRadius.Size = new System.Drawing.Size(132, 28);
            lblActivationRadius.TabIndex = 53;
            // 
            // inputActivationRadius
            // 
            inputActivationRadius.Dock = DockStyle.Fill;
            inputActivationRadius.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            inputActivationRadius.Location = new System.Drawing.Point(410, 65);
            inputActivationRadius.Margin = new Padding(0);
            inputActivationRadius.Maximum = new decimal(new int[] {
            196,
            0,
            0,
            0});
            inputActivationRadius.Minimum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            inputActivationRadius.Name = "inputActivationRadius";
            inputActivationRadius.Size = new System.Drawing.Size(132, 20);
            inputActivationRadius.TabIndex = 54;
            inputActivationRadius.Value = new decimal(new int[] {
            96,
            0,
            0,
            0});
            // 
            // lblEnhancedSoundAwareness
            // 
            lblEnhancedSoundAwareness.AutoSize = true;
            lblEnhancedSoundAwareness.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            lblEnhancedSoundAwareness.Dock = DockStyle.Fill;
            lblEnhancedSoundAwareness.HelpUrl = null;
            lblEnhancedSoundAwareness.LabelText = "Enhanced sound awareness";
            lblEnhancedSoundAwareness.Location = new System.Drawing.Point(546, 95);
            lblEnhancedSoundAwareness.Margin = new Padding(4, 0, 0, 2);
            lblEnhancedSoundAwareness.Name = "lblEnhancedSoundAwareness";
            lblEnhancedSoundAwareness.Padding = new Padding(0, 2, 0, 0);
            lblEnhancedSoundAwareness.Size = new System.Drawing.Size(193, 28);
            lblEnhancedSoundAwareness.TabIndex = 55;
            // 
            // inputSoundAware
            // 
            inputSoundAware.AutoSize = true;
            inputSoundAware.Location = new System.Drawing.Point(742, 98);
            inputSoundAware.Name = "inputSoundAware";
            inputSoundAware.Size = new System.Drawing.Size(15, 14);
            inputSoundAware.TabIndex = 56;
            inputSoundAware.UseVisualStyleBackColor = true;
            // 
            // labelWithHelp1
            // 
            labelWithHelp1.AutoSize = true;
            labelWithHelp1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            labelWithHelp1.Dock = DockStyle.Fill;
            labelWithHelp1.HelpUrl = "";
            labelWithHelp1.LabelText = "Sound Distance Scale";
            labelWithHelp1.Location = new System.Drawing.Point(278, 95);
            labelWithHelp1.Margin = new Padding(4, 0, 0, 2);
            labelWithHelp1.Name = "labelWithHelp1";
            labelWithHelp1.Padding = new Padding(0, 2, 0, 0);
            labelWithHelp1.Size = new System.Drawing.Size(132, 28);
            labelWithHelp1.TabIndex = 57;
            // 
            // inputSoundDistanceScale
            // 
            inputSoundDistanceScale.DecimalPlaces = 1;
            inputSoundDistanceScale.Dock = DockStyle.Fill;
            inputSoundDistanceScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            inputSoundDistanceScale.Location = new System.Drawing.Point(410, 95);
            inputSoundDistanceScale.Margin = new Padding(0);
            inputSoundDistanceScale.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            inputSoundDistanceScale.Name = "inputSoundDistanceScale";
            inputSoundDistanceScale.Size = new System.Drawing.Size(132, 20);
            inputSoundDistanceScale.TabIndex = 58;
            inputSoundDistanceScale.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel2);
            tabPage2.Location = new System.Drawing.Point(4, 22);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new System.Drawing.Size(832, 201);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Movement Systems";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.18447F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.98058F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.83495F));
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(groupProcessors, 2, 0);
            tableLayoutPanel2.Controls.Add(groupProps, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new System.Drawing.Size(826, 195);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new System.Drawing.Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(218, 189);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Systems";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(listProcessorGroups, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new System.Drawing.Size(212, 170);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // listProcessorGroups
            // 
            listProcessorGroups.Dock = DockStyle.Fill;
            listProcessorGroups.FormattingEnabled = true;
            listProcessorGroups.Location = new System.Drawing.Point(3, 8);
            listProcessorGroups.Margin = new Padding(3, 8, 3, 3);
            listProcessorGroups.Name = "listProcessorGroups";
            listProcessorGroups.Size = new System.Drawing.Size(206, 127);
            listProcessorGroups.TabIndex = 8;
            listProcessorGroups.SelectedIndexChanged += new System.EventHandler(OnGroupSelection);
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel4.Controls.Add(button1, 0, 0);
            tableLayoutPanel4.Controls.Add(buttonRemoveGroup, 2, 0);
            tableLayoutPanel4.Controls.Add(buttonDuplicateGroup, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new System.Drawing.Point(0, 138);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new System.Drawing.Size(212, 32);
            tableLayoutPanel4.TabIndex = 9;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new System.Drawing.Point(3, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(64, 26);
            button1.TabIndex = 9;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(OnAddGroupClick);
            // 
            // buttonRemoveGroup
            // 
            buttonRemoveGroup.Dock = DockStyle.Fill;
            buttonRemoveGroup.Enabled = false;
            buttonRemoveGroup.Location = new System.Drawing.Point(143, 3);
            buttonRemoveGroup.Name = "buttonRemoveGroup";
            buttonRemoveGroup.Size = new System.Drawing.Size(66, 26);
            buttonRemoveGroup.TabIndex = 10;
            buttonRemoveGroup.Text = "Remove";
            buttonRemoveGroup.UseVisualStyleBackColor = true;
            buttonRemoveGroup.Click += new System.EventHandler(OnRemoveGroupClick);
            // 
            // buttonDuplicateGroup
            // 
            buttonDuplicateGroup.Dock = DockStyle.Fill;
            buttonDuplicateGroup.Enabled = false;
            buttonDuplicateGroup.Location = new System.Drawing.Point(73, 3);
            buttonDuplicateGroup.Name = "buttonDuplicateGroup";
            buttonDuplicateGroup.Size = new System.Drawing.Size(64, 26);
            buttonDuplicateGroup.TabIndex = 11;
            buttonDuplicateGroup.Text = "Duplicate";
            buttonDuplicateGroup.UseVisualStyleBackColor = true;
            buttonDuplicateGroup.Click += new System.EventHandler(OnDuplicateGroupClick);
            // 
            // groupProcessors
            // 
            groupProcessors.Controls.Add(tableLayoutPanel6);
            groupProcessors.Dock = DockStyle.Fill;
            groupProcessors.Location = new System.Drawing.Point(507, 3);
            groupProcessors.Name = "groupProcessors";
            groupProcessors.Size = new System.Drawing.Size(316, 189);
            groupProcessors.TabIndex = 6;
            groupProcessors.TabStop = false;
            groupProcessors.Text = "Processors";
            groupProcessors.Visible = false;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.45889F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.54111F));
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel6.Controls.Add(groupParameter, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            tableLayoutPanel6.Margin = new Padding(3, 0, 3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new System.Drawing.Size(310, 170);
            tableLayoutPanel6.TabIndex = 11;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 0, 1);
            tableLayoutPanel7.Controls.Add(listProcessors, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.Size = new System.Drawing.Size(153, 164);
            tableLayoutPanel7.TabIndex = 12;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(button4, 0, 0);
            tableLayoutPanel8.Controls.Add(buttonRemoveProcessor, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new System.Drawing.Point(0, 132);
            tableLayoutPanel8.Margin = new Padding(0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle());
            tableLayoutPanel8.Size = new System.Drawing.Size(153, 32);
            tableLayoutPanel8.TabIndex = 13;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Location = new System.Drawing.Point(3, 3);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(70, 26);
            button4.TabIndex = 8;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            button4.Click += new System.EventHandler(OnAddProcessorClick);
            // 
            // buttonRemoveProcessor
            // 
            buttonRemoveProcessor.Dock = DockStyle.Fill;
            buttonRemoveProcessor.Enabled = false;
            buttonRemoveProcessor.Location = new System.Drawing.Point(79, 3);
            buttonRemoveProcessor.Name = "buttonRemoveProcessor";
            buttonRemoveProcessor.Size = new System.Drawing.Size(71, 26);
            buttonRemoveProcessor.TabIndex = 9;
            buttonRemoveProcessor.Text = "Remove";
            buttonRemoveProcessor.UseVisualStyleBackColor = true;
            buttonRemoveProcessor.Click += new System.EventHandler(OnRemoveProcessorClick);
            // 
            // listProcessors
            // 
            listProcessors.Dock = DockStyle.Fill;
            listProcessors.FormattingEnabled = true;
            listProcessors.Location = new System.Drawing.Point(3, 3);
            listProcessors.Margin = new Padding(3, 3, 3, 2);
            listProcessors.Name = "listProcessors";
            listProcessors.Size = new System.Drawing.Size(147, 127);
            listProcessors.TabIndex = 7;
            listProcessors.SelectedIndexChanged += new System.EventHandler(OnProcessorSelectionChanged);
            // 
            // groupParameter
            // 
            groupParameter.Controls.Add(tableLayoutPanel9);
            groupParameter.Dock = DockStyle.Fill;
            groupParameter.Location = new System.Drawing.Point(162, 0);
            groupParameter.Margin = new Padding(3, 0, 3, 3);
            groupParameter.Name = "groupParameter";
            groupParameter.Size = new System.Drawing.Size(145, 167);
            groupParameter.TabIndex = 10;
            groupParameter.TabStop = false;
            groupParameter.Text = "Parameters";
            groupParameter.Visible = false;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(inputProcessorPower, 1, 1);
            tableLayoutPanel9.Controls.Add(label9, 0, 0);
            tableLayoutPanel9.Controls.Add(label8, 0, 1);
            tableLayoutPanel9.Controls.Add(inputProcessorDistance, 1, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new System.Drawing.Point(3, 16);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle());
            tableLayoutPanel9.RowStyles.Add(new RowStyle());
            tableLayoutPanel9.Size = new System.Drawing.Size(139, 148);
            tableLayoutPanel9.TabIndex = 12;
            // 
            // inputProcessorPower
            // 
            inputProcessorPower.DecimalPlaces = 5;
            inputProcessorPower.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            inputProcessorPower.Location = new System.Drawing.Point(72, 29);
            inputProcessorPower.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            inputProcessorPower.Name = "inputProcessorPower";
            inputProcessorPower.Size = new System.Drawing.Size(64, 20);
            inputProcessorPower.TabIndex = 12;
            inputProcessorPower.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            inputProcessorPower.ValueChanged += new System.EventHandler(OnPowerValueChanged);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(3, 8);
            label9.Margin = new Padding(3, 8, 3, 3);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(49, 13);
            label9.TabIndex = 9;
            label9.Text = "Distance";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(3, 34);
            label8.Margin = new Padding(3, 8, 3, 3);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(37, 13);
            label8.TabIndex = 10;
            label8.Text = "Power";
            // 
            // inputProcessorDistance
            // 
            inputProcessorDistance.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            inputProcessorDistance.Location = new System.Drawing.Point(72, 3);
            inputProcessorDistance.Maximum = new decimal(new int[] {
            750,
            0,
            0,
            0});
            inputProcessorDistance.Name = "inputProcessorDistance";
            inputProcessorDistance.Size = new System.Drawing.Size(64, 20);
            inputProcessorDistance.TabIndex = 11;
            inputProcessorDistance.ValueChanged += new System.EventHandler(OnDistanceValueChanged);
            // 
            // groupProps
            // 
            groupProps.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupProps.Controls.Add(tableLayoutPanel5);
            groupProps.Dock = DockStyle.Fill;
            groupProps.Location = new System.Drawing.Point(227, 3);
            groupProps.Name = "groupProps";
            groupProps.Size = new System.Drawing.Size(274, 189);
            groupProps.TabIndex = 3;
            groupProps.TabStop = false;
            groupProps.Text = "Properties";
            groupProps.Visible = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.8209F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.1791F));
            tableLayoutPanel5.Controls.Add(panel2, 1, 2);
            tableLayoutPanel5.Controls.Add(inputPostSpawnBehavior, 1, 3);
            tableLayoutPanel5.Controls.Add(inputAffectedGroup, 1, 0);
            tableLayoutPanel5.Controls.Add(lblPostSpawnWanderSpeed, 0, 4);
            tableLayoutPanel5.Controls.Add(lblMovementSpeed, 0, 1);
            tableLayoutPanel5.Controls.Add(inputMovementSpeed, 1, 1);
            tableLayoutPanel5.Controls.Add(lblAffected, 0, 5);
            tableLayoutPanel5.Controls.Add(lblGroupColor, 0, 2);
            tableLayoutPanel5.Controls.Add(lblPostSpawnBehavior, 0, 3);
            tableLayoutPanel5.Controls.Add(inputWanderSpeed, 1, 4);
            tableLayoutPanel5.Controls.Add(lblAffectedGroup, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 6;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.Size = new System.Drawing.Size(268, 170);
            tableLayoutPanel5.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.Controls.Add(boxGroupColor);
            panel2.Controls.Add(buttonGroupColor);
            panel2.Location = new System.Drawing.Point(163, 53);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(105, 28);
            panel2.TabIndex = 15;
            // 
            // boxGroupColor
            // 
            boxGroupColor.BackColor = System.Drawing.Color.Transparent;
            boxGroupColor.BorderStyle = BorderStyle.FixedSingle;
            boxGroupColor.Location = new System.Drawing.Point(3, 3);
            boxGroupColor.Name = "boxGroupColor";
            boxGroupColor.Size = new System.Drawing.Size(77, 21);
            boxGroupColor.TabIndex = 8;
            boxGroupColor.TabStop = false;
            // 
            // buttonGroupColor
            // 
            buttonGroupColor.Location = new System.Drawing.Point(80, 2);
            buttonGroupColor.Name = "buttonGroupColor";
            buttonGroupColor.Size = new System.Drawing.Size(23, 23);
            buttonGroupColor.TabIndex = 7;
            buttonGroupColor.Text = "...";
            buttonGroupColor.UseVisualStyleBackColor = true;
            buttonGroupColor.Click += new System.EventHandler(OnGroupColorPickClick);
            // 
            // inputPostSpawnBehavior
            // 
            inputPostSpawnBehavior.DropDownStyle = ComboBoxStyle.DropDownList;
            inputPostSpawnBehavior.FormattingEnabled = true;
            inputPostSpawnBehavior.Location = new System.Drawing.Point(166, 84);
            inputPostSpawnBehavior.Name = "inputPostSpawnBehavior";
            inputPostSpawnBehavior.Size = new System.Drawing.Size(99, 21);
            inputPostSpawnBehavior.TabIndex = 11;
            inputPostSpawnBehavior.SelectedIndexChanged += new System.EventHandler(OnPostSpawnBehaviorSelectionChanged);
            // 
            // inputAffectedGroup
            // 
            inputAffectedGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            inputAffectedGroup.FormattingEnabled = true;
            inputAffectedGroup.Location = new System.Drawing.Point(166, 3);
            inputAffectedGroup.Name = "inputAffectedGroup";
            inputAffectedGroup.Size = new System.Drawing.Size(99, 21);
            inputAffectedGroup.TabIndex = 12;
            inputAffectedGroup.SelectionChangeCommitted += new System.EventHandler(OnGroupIdChanged);
            // 
            // lblPostSpawnWanderSpeed
            // 
            lblPostSpawnWanderSpeed.AutoSize = true;
            lblPostSpawnWanderSpeed.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            lblPostSpawnWanderSpeed.HelpUrl = null;
            lblPostSpawnWanderSpeed.LabelText = "Post Spawn Wander Speed";
            lblPostSpawnWanderSpeed.Location = new System.Drawing.Point(3, 116);
            lblPostSpawnWanderSpeed.Margin = new Padding(3, 8, 3, 3);
            lblPostSpawnWanderSpeed.Name = "lblPostSpawnWanderSpeed";
            lblPostSpawnWanderSpeed.Padding = new Padding(4, 0, 0, 2);
            lblPostSpawnWanderSpeed.Size = new System.Drawing.Size(143, 15);
            lblPostSpawnWanderSpeed.TabIndex = 13;
            // 
            // lblMovementSpeed
            // 
            lblMovementSpeed.AutoSize = true;
            lblMovementSpeed.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            lblMovementSpeed.HelpUrl = null;
            lblMovementSpeed.LabelText = "Movement Speed";
            lblMovementSpeed.Location = new System.Drawing.Point(3, 35);
            lblMovementSpeed.Margin = new Padding(3, 8, 3, 3);
            lblMovementSpeed.Name = "lblMovementSpeed";
            lblMovementSpeed.Padding = new Padding(4, 0, 0, 2);
            lblMovementSpeed.Size = new System.Drawing.Size(95, 15);
            lblMovementSpeed.TabIndex = 2;
            // 
            // inputMovementSpeed
            // 
            inputMovementSpeed.DecimalPlaces = 5;
            inputMovementSpeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            inputMovementSpeed.Location = new System.Drawing.Point(166, 30);
            inputMovementSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            inputMovementSpeed.Name = "inputMovementSpeed";
            inputMovementSpeed.Size = new System.Drawing.Size(99, 20);
            inputMovementSpeed.TabIndex = 5;
            inputMovementSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            inputMovementSpeed.ValueChanged += new System.EventHandler(OnMovementSpeedChanged);
            // 
            // lblAffected
            // 
            lblAffected.AutoSize = true;
            lblAffected.Location = new System.Drawing.Point(7, 143);
            lblAffected.Margin = new Padding(7, 8, 3, 0);
            lblAffected.Name = "lblAffected";
            lblAffected.Size = new System.Drawing.Size(95, 13);
            lblAffected.TabIndex = 9;
            lblAffected.Text = "Affected Agents: 0";
            // 
            // lblGroupColor
            // 
            lblGroupColor.AutoSize = true;
            lblGroupColor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            lblGroupColor.HelpUrl = null;
            lblGroupColor.LabelText = "Group Color";
            lblGroupColor.Location = new System.Drawing.Point(3, 61);
            lblGroupColor.Margin = new Padding(3, 8, 3, 3);
            lblGroupColor.Name = "lblGroupColor";
            lblGroupColor.Padding = new Padding(4, 0, 0, 2);
            lblGroupColor.Size = new System.Drawing.Size(67, 15);
            lblGroupColor.TabIndex = 6;
            // 
            // lblPostSpawnBehavior
            // 
            lblPostSpawnBehavior.AutoSize = true;
            lblPostSpawnBehavior.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            lblPostSpawnBehavior.HelpUrl = null;
            lblPostSpawnBehavior.LabelText = "Post Spawn Behavior";
            lblPostSpawnBehavior.Location = new System.Drawing.Point(3, 89);
            lblPostSpawnBehavior.Margin = new Padding(3, 8, 3, 3);
            lblPostSpawnBehavior.Name = "lblPostSpawnBehavior";
            lblPostSpawnBehavior.Padding = new Padding(4, 0, 0, 2);
            lblPostSpawnBehavior.Size = new System.Drawing.Size(113, 15);
            lblPostSpawnBehavior.TabIndex = 10;
            // 
            // inputWanderSpeed
            // 
            inputWanderSpeed.DropDownStyle = ComboBoxStyle.DropDownList;
            inputWanderSpeed.FormattingEnabled = true;
            inputWanderSpeed.Items.AddRange(new object[] {
            "No Override",
            "Walk",
            "Jog",
            "Run",
            "Sprint",
            "Nightmare"});
            inputWanderSpeed.Location = new System.Drawing.Point(166, 111);
            inputWanderSpeed.Name = "inputWanderSpeed";
            inputWanderSpeed.Size = new System.Drawing.Size(99, 21);
            inputWanderSpeed.TabIndex = 16;
            inputWanderSpeed.SelectedIndexChanged += new System.EventHandler(OnPostSpawnWanderSpeedSelectionChanged);
            // 
            // lblAffectedGroup
            // 
            lblAffectedGroup.AutoSize = true;
            lblAffectedGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            lblAffectedGroup.HelpUrl = null;
            lblAffectedGroup.LabelText = "Affected Group";
            lblAffectedGroup.Location = new System.Drawing.Point(3, 8);
            lblAffectedGroup.Margin = new Padding(3, 8, 3, 3);
            lblAffectedGroup.Name = "lblAffectedGroup";
            lblAffectedGroup.Padding = new Padding(4, 0, 0, 2);
            lblAffectedGroup.Size = new System.Drawing.Size(83, 15);
            lblAffectedGroup.TabIndex = 17;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(lblStatGroups);
            tabPage4.Controls.Add(label24);
            tabPage4.Controls.Add(lblStatUpdateTime);
            tabPage4.Controls.Add(label22);
            tabPage4.Controls.Add(lblStatWindTarget);
            tabPage4.Controls.Add(label20);
            tabPage4.Controls.Add(lblStatSimTime);
            tabPage4.Controls.Add(label27);
            tabPage4.Controls.Add(lblStatWindChange);
            tabPage4.Controls.Add(label25);
            tabPage4.Controls.Add(lblStatWindDir);
            tabPage4.Controls.Add(label23);
            tabPage4.Controls.Add(lblStatTicks);
            tabPage4.Controls.Add(label21);
            tabPage4.Controls.Add(lblStatActive);
            tabPage4.Controls.Add(label19);
            tabPage4.Controls.Add(lblStatInactive);
            tabPage4.Controls.Add(label17);
            tabPage4.Controls.Add(lblStatTotalAgents);
            tabPage4.Controls.Add(label16);
            tabPage4.Location = new System.Drawing.Point(4, 22);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new System.Drawing.Size(832, 201);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Statistics";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblStatGroups
            // 
            lblStatGroups.AutoSize = true;
            lblStatGroups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            lblStatGroups.Location = new System.Drawing.Point(126, 60);
            lblStatGroups.Margin = new Padding(5, 0, 5, 0);
            lblStatGroups.Name = "lblStatGroups";
            lblStatGroups.Padding = new Padding(2);
            lblStatGroups.Size = new System.Drawing.Size(17, 17);
            lblStatGroups.TabIndex = 19;
            lblStatGroups.Text = "0";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new System.Drawing.Point(10, 60);
            label24.Margin = new Padding(5, 0, 5, 0);
            label24.Name = "label24";
            label24.Padding = new Padding(2);
            label24.Size = new System.Drawing.Size(48, 17);
            label24.TabIndex = 18;
            label24.Text = "Groups:";
            // 
            // lblStatUpdateTime
            // 
            lblStatUpdateTime.AutoSize = true;
            lblStatUpdateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            lblStatUpdateTime.Location = new System.Drawing.Point(622, 43);
            lblStatUpdateTime.Margin = new Padding(5, 0, 5, 0);
            lblStatUpdateTime.Name = "lblStatUpdateTime";
            lblStatUpdateTime.Padding = new Padding(2);
            lblStatUpdateTime.Size = new System.Drawing.Size(33, 17);
            lblStatUpdateTime.TabIndex = 17;
            lblStatUpdateTime.Text = "0 ms";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(522, 43);
            label22.Margin = new Padding(5, 0, 5, 0);
            label22.Name = "label22";
            label22.Padding = new Padding(2);
            label22.Size = new System.Drawing.Size(75, 17);
            label22.TabIndex = 16;
            label22.Text = "Update Time:";
            // 
            // lblStatWindTarget
            // 
            lblStatWindTarget.AutoSize = true;
            lblStatWindTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            lblStatWindTarget.Location = new System.Drawing.Point(352, 9);
            lblStatWindTarget.Margin = new Padding(5, 0, 5, 0);
            lblStatWindTarget.Name = "lblStatWindTarget";
            lblStatWindTarget.Padding = new Padding(2);
            lblStatWindTarget.Size = new System.Drawing.Size(26, 17);
            lblStatWindTarget.TabIndex = 15;
            lblStatWindTarget.Text = "0 0";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(218, 9);
            label20.Margin = new Padding(5, 0, 5, 0);
            label20.Name = "label20";
            label20.Padding = new Padding(2);
            label20.Size = new System.Drawing.Size(118, 17);
            label20.TabIndex = 14;
            label20.Text = "Wind Direction Target:";
            // 
            // lblStatSimTime
            // 
            lblStatSimTime.AutoSize = true;
            lblStatSimTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            lblStatSimTime.Location = new System.Drawing.Point(622, 26);
            lblStatSimTime.Margin = new Padding(5, 0, 5, 0);
            lblStatSimTime.Name = "lblStatSimTime";
            lblStatSimTime.Padding = new Padding(2);
            lblStatSimTime.Size = new System.Drawing.Size(33, 17);
            lblStatSimTime.TabIndex = 13;
            lblStatSimTime.Text = "0 ms";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new System.Drawing.Point(522, 26);
            label27.Margin = new Padding(5, 0, 5, 0);
            label27.Name = "label27";
            label27.Padding = new Padding(2);
            label27.Size = new System.Drawing.Size(88, 17);
            label27.TabIndex = 12;
            label27.Text = "Simulation Time:";
            // 
            // lblStatWindChange
            // 
            lblStatWindChange.AutoSize = true;
            lblStatWindChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            lblStatWindChange.Location = new System.Drawing.Point(352, 43);
            lblStatWindChange.Margin = new Padding(5, 0, 5, 0);
            lblStatWindChange.Name = "lblStatWindChange";
            lblStatWindChange.Padding = new Padding(2);
            lblStatWindChange.Size = new System.Drawing.Size(17, 17);
            lblStatWindChange.TabIndex = 11;
            lblStatWindChange.Text = "0";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new System.Drawing.Point(218, 43);
            label25.Margin = new Padding(5, 0, 5, 0);
            label25.Name = "label25";
            label25.Padding = new Padding(2);
            label25.Size = new System.Drawing.Size(101, 17);
            label25.TabIndex = 10;
            label25.Text = "Next Wind Change";
            // 
            // lblStatWindDir
            // 
            lblStatWindDir.AutoSize = true;
            lblStatWindDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            lblStatWindDir.Location = new System.Drawing.Point(352, 26);
            lblStatWindDir.Margin = new Padding(5, 0, 5, 0);
            lblStatWindDir.Name = "lblStatWindDir";
            lblStatWindDir.Padding = new Padding(2);
            lblStatWindDir.Size = new System.Drawing.Size(26, 17);
            lblStatWindDir.TabIndex = 9;
            lblStatWindDir.Text = "0 0";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new System.Drawing.Point(218, 26);
            label23.Margin = new Padding(5, 0, 5, 0);
            label23.Name = "label23";
            label23.Padding = new Padding(2);
            label23.Size = new System.Drawing.Size(84, 17);
            label23.TabIndex = 8;
            label23.Text = "Wind Direction:";
            // 
            // lblStatTicks
            // 
            lblStatTicks.AutoSize = true;
            lblStatTicks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            lblStatTicks.Location = new System.Drawing.Point(622, 9);
            lblStatTicks.Margin = new Padding(5, 0, 5, 0);
            lblStatTicks.Name = "lblStatTicks";
            lblStatTicks.Padding = new Padding(2);
            lblStatTicks.Size = new System.Drawing.Size(17, 17);
            lblStatTicks.TabIndex = 7;
            lblStatTicks.Text = "0";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new System.Drawing.Point(522, 9);
            label21.Margin = new Padding(5, 0, 5, 0);
            label21.Name = "label21";
            label21.Padding = new Padding(2);
            label21.Size = new System.Drawing.Size(40, 17);
            label21.TabIndex = 6;
            label21.Text = "Ticks:";
            // 
            // lblStatActive
            // 
            lblStatActive.AutoSize = true;
            lblStatActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            lblStatActive.Location = new System.Drawing.Point(126, 43);
            lblStatActive.Margin = new Padding(5, 0, 5, 0);
            lblStatActive.Name = "lblStatActive";
            lblStatActive.Padding = new Padding(2);
            lblStatActive.Size = new System.Drawing.Size(17, 17);
            lblStatActive.TabIndex = 5;
            lblStatActive.Text = "0";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(10, 43);
            label19.Margin = new Padding(5, 0, 5, 0);
            label19.Name = "label19";
            label19.Padding = new Padding(2);
            label19.Size = new System.Drawing.Size(80, 17);
            label19.TabIndex = 4;
            label19.Text = "Active Agents:";
            // 
            // lblStatInactive
            // 
            lblStatInactive.AutoSize = true;
            lblStatInactive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            lblStatInactive.Location = new System.Drawing.Point(126, 26);
            lblStatInactive.Margin = new Padding(5, 0, 5, 0);
            lblStatInactive.Name = "lblStatInactive";
            lblStatInactive.Padding = new Padding(2);
            lblStatInactive.Size = new System.Drawing.Size(17, 17);
            lblStatInactive.TabIndex = 3;
            lblStatInactive.Text = "0";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(10, 26);
            label17.Margin = new Padding(5, 0, 5, 0);
            label17.Name = "label17";
            label17.Padding = new Padding(2);
            label17.Size = new System.Drawing.Size(88, 17);
            label17.TabIndex = 2;
            label17.Text = "Inactive Agents:";
            // 
            // lblStatTotalAgents
            // 
            lblStatTotalAgents.AutoSize = true;
            lblStatTotalAgents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            lblStatTotalAgents.Location = new System.Drawing.Point(126, 9);
            lblStatTotalAgents.Margin = new Padding(5, 0, 5, 0);
            lblStatTotalAgents.Name = "lblStatTotalAgents";
            lblStatTotalAgents.Padding = new Padding(2);
            lblStatTotalAgents.Size = new System.Drawing.Size(17, 17);
            lblStatTotalAgents.TabIndex = 1;
            lblStatTotalAgents.Text = "0";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(9, 9);
            label16.Margin = new Padding(5, 0, 5, 0);
            label16.Name = "label16";
            label16.Padding = new Padding(2);
            label16.Size = new System.Drawing.Size(74, 17);
            label16.TabIndex = 0;
            label16.Text = "Total Agents:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(rtbLog);
            tabPage3.Location = new System.Drawing.Point(4, 22);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new System.Drawing.Size(832, 201);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Log";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtbLog
            // 
            rtbLog.BorderStyle = BorderStyle.None;
            rtbLog.ContextMenuStrip = contextLog;
            rtbLog.Dock = DockStyle.Fill;
            rtbLog.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rtbLog.Location = new System.Drawing.Point(0, 0);
            rtbLog.Name = "rtbLog";
            rtbLog.ReadOnly = true;
            rtbLog.Size = new System.Drawing.Size(832, 201);
            rtbLog.TabIndex = 0;
            rtbLog.Text = "";
            // 
            // contextLog
            // 
            contextLog.Items.AddRange(new ToolStripItem[] {
            clearToolStripMenuItem,
            copyToolStripMenuItem});
            contextLog.Name = "contextLog";
            contextLog.Size = new System.Drawing.Size(103, 48);
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += new System.EventHandler(OnLogClearClick);
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // colorPickerDlg
            // 
            colorPickerDlg.AnyColor = true;
            // 
            // btZoomIn
            // 
            btZoomIn.BackColor = System.Drawing.Color.Black;
            btZoomIn.BorderStyle = BorderStyle.FixedSingle;
            btZoomIn.FlatStyle = FlatStyle.Flat;
            btZoomIn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btZoomIn.ForeColor = System.Drawing.Color.White;
            btZoomIn.Location = new System.Drawing.Point(35, 35);
            btZoomIn.Margin = new Padding(0);
            btZoomIn.Name = "btZoomIn";
            btZoomIn.Size = new System.Drawing.Size(22, 22);
            btZoomIn.TabIndex = 7;
            btZoomIn.Text = "+";
            btZoomIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btZoomIn.Click += new System.EventHandler(OnZoomInClick);
            // 
            // btZoomOut
            // 
            btZoomOut.BackColor = System.Drawing.Color.Black;
            btZoomOut.BorderStyle = BorderStyle.FixedSingle;
            btZoomOut.FlatStyle = FlatStyle.Flat;
            btZoomOut.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btZoomOut.ForeColor = System.Drawing.Color.White;
            btZoomOut.Location = new System.Drawing.Point(10, 35);
            btZoomOut.Margin = new Padding(0);
            btZoomOut.Name = "btZoomOut";
            btZoomOut.Size = new System.Drawing.Size(22, 22);
            btZoomOut.TabIndex = 8;
            btZoomOut.Text = "-";
            btZoomOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btZoomOut.Click += new System.EventHandler(OnZoomOutClick);
            // 
            // label29
            // 
            label29.BackColor = System.Drawing.Color.Black;
            label29.BorderStyle = BorderStyle.FixedSingle;
            label29.FlatStyle = FlatStyle.Flat;
            label29.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label29.ForeColor = System.Drawing.Color.White;
            label29.Location = new System.Drawing.Point(60, 35);
            label29.Margin = new Padding(0);
            label29.Name = "label29";
            label29.Size = new System.Drawing.Size(22, 22);
            label29.TabIndex = 9;
            label29.Text = "R";
            label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label29.Click += new System.EventHandler(OnZoomResetClick);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(840, 716);
            Controls.Add(label29);
            Controls.Add(btZoomOut);
            Controls.Add(btZoomIn);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "WalkerSim";
            KeyDown += new KeyEventHandler(OnKeyDown);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((ISupportInitialize)(splitContainer1)).EndInit();
            splitContainer1.ResumeLayout(false);
            ((ISupportInitialize)(simCanvas)).EndInit();
            tabSimulation.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((ISupportInitialize)(inputSpawnProtectionTime)).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)(inputRandomSeed)).EndInit();
            ((ISupportInitialize)(inputGroupSize)).EndInit();
            ((ISupportInitialize)(inputMaxAgents)).EndInit();
            ((ISupportInitialize)(inputActivationRadius)).EndInit();
            ((ISupportInitialize)(inputSoundDistanceScale)).EndInit();
            tabPage2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            groupProcessors.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            groupParameter.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            ((ISupportInitialize)(inputProcessorPower)).EndInit();
            ((ISupportInitialize)(inputProcessorDistance)).EndInit();
            groupProps.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel2.ResumeLayout(false);
            ((ISupportInitialize)(boxGroupColor)).EndInit();
            ((ISupportInitialize)(inputMovementSpeed)).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage3.ResumeLayout(false);
            contextLog.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Timer updateTimer;
        private BackgroundWorker backgroundWorker1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem simulationToolStripMenuItem;
        private ToolStripMenuItem startToolStripMenuItem;
        private ToolStripMenuItem pauseToolStripMenuItem;
        private ToolStripMenuItem resumeToolStripMenuItem;
        private ToolStripMenuItem advanceOneTickToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem emitSoundToolStripMenuItem;
        private ToolStripMenuItem viewRoads;
        private ToolStripMenuItem viewAgents;
        private ToolStripMenuItem viewEvents;
        private SplitContainer splitContainer1;
        private TabControl tabSimulation;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private CheckBox inputPauseDuringBloodmoon;
        private ComboBox inputRespawnPosition;
        private LabelWithHelp lblRespawnPosition;
        private ComboBox inputStartPosition;
        private LabelWithHelp lblGroupSize;
        private NumericUpDown inputGroupSize;
        private LabelWithHelp lblPopulationDensity;
        private Label lblRandomSeed;
        private NumericUpDown inputRandomSeed;
        private CheckBox inputStartGrouped;
        private GroupBox groupProps;
        private NumericUpDown inputMovementSpeed;
        private LabelWithHelp lblMovementSpeed;
        private ComboBox inputWorld;
        private Label label10;
        private ToolStripMenuItem speedToolStripMenuItem;
        private ToolStripMenuItem killToolStripMenuItem;
        private ToolStripMenuItem loadConfigurationToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem stopToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private TabPage tabPage3;
        private RichTextBox rtbLog;
        private ContextMenuStrip contextLog;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private LabelWithHelp lblGroupColor;
        private PictureBox boxGroupColor;
        private Button buttonGroupColor;
        private ColorDialog colorPickerDlg;
        private ToolStripMenuItem exportConfigurationToolStripMenuItem;
        private Button btRand;
        private ToolTip toolTipGroupSize;
        private Label lblAffected;
        private ToolStripMenuItem viewPrefabs;
        private CheckBox inputFastForward;
        private LabelWithHelp lblSpawnProtectionTime;
        private NumericUpDown inputSpawnProtectionTime;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private LabelWithHelp lblStartPosition;
        private LabelWithHelp lblPauseDuringBloodmoon;
        private LabelWithHelp lblStartAgentsGrouped;
        private LabelWithHelp lblFastForward;
        private NumericUpDown inputMaxAgents;
        private LabelWithHelp lblPostSpawnBehavior;
        private ComboBox inputPostSpawnBehavior;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem addPlayerToolStripMenuItem;
        private ToolStripMenuItem setPlayerPositionToolStripMenuItem;
        private ToolStripMenuItem viewActiveAgents;
        private PictureBox simCanvas;
        private ToolStripMenuItem zoomSubMenu;
        private ToolStripMenuItem xToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem inToolStripMenuItem;
        private ToolStripMenuItem outToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private TabPage tabPage4;
        private Label lblStatTotalAgents;
        private Label label16;
        private Label lblStatActive;
        private Label label19;
        private Label lblStatInactive;
        private Label label17;
        private Label lblStatSimTime;
        private Label label27;
        private Label lblStatWindChange;
        private Label label25;
        private Label lblStatWindDir;
        private Label label23;
        private Label lblStatTicks;
        private Label label21;
        private Label lblStatWindTarget;
        private Label label20;
        private Label lblStatUpdateTime;
        private Label label22;
        private Label lblStatGroups;
        private Label label24;
        private LabelWithHelp lblActivationRadius;
        private NumericUpDown inputActivationRadius;
        private ToolStripMenuItem loadStateSaveToolStripMenuItem;
        private ToolStripMenuItem saveStateToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem resetToolStripMenuItem;
        private LabelWithHelp lblEnhancedSoundAwareness;
        private CheckBox inputSoundAware;
        private ToolStripMenuItem viewBiomes;
        private ComboBox inputAffectedGroup;
        private LabelWithHelp lblPostSpawnWanderSpeed;
        private ListBox listProcessorGroups;
        private Button buttonDuplicateGroup;
        private GroupBox groupBox1;
        private Button buttonRemoveGroup;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel2;
        private ComboBox inputWanderSpeed;
        private GroupBox groupProcessors;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private Button button4;
        private Button buttonRemoveProcessor;
        private ListBox listProcessors;
        private GroupBox groupParameter;
        private TableLayoutPanel tableLayoutPanel9;
        private NumericUpDown inputProcessorPower;
        private Label label9;
        private Label label8;
        private NumericUpDown inputProcessorDistance;
        private Label btZoomIn;
        private Label btZoomOut;
        private Label label29;
        private LabelWithHelp lblAffectedGroup;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem documentationToolStripMenuItem;
        private LabelWithHelp labelWithHelp1;
        private NumericUpDown inputSoundDistanceScale;
    }
}

