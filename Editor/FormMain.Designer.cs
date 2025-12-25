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
            baseParametersTab = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblPauseDuringBloodmoon = new WalkerSim.Editor.LabelWithHelp();
            lblStartAgentsGrouped = new WalkerSim.Editor.LabelWithHelp();
            inputSpawnProtectionTime = new NumericUpDown();
            panel1 = new Panel();
            inputRandomSeed = new NumericUpDown();
            randomSeedBtn = new Button();
            inputRespawnPosition = new ComboBox();
            lblSpawnProtectionTime = new WalkerSim.Editor.LabelWithHelp();
            lblRespawnPosition = new WalkerSim.Editor.LabelWithHelp();
            inputWorld = new ComboBox();
            inputStartPosition = new ComboBox();
            worldLabel = new Label();
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
            movementSystemsTab = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            systemsGroupBox1 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            listProcessorGroups = new ListBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            addGroupBtn = new Button();
            buttonRemoveGroup = new Button();
            buttonDuplicateGroup = new Button();
            groupProcessors = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            addMovementProcessorBtn = new Button();
            buttonRemoveProcessor = new Button();
            listProcessors = new ListBox();
            groupParameter = new GroupBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            inputProcessorPower = new NumericUpDown();
            label9 = new Label();
            powerLabel = new Label();
            inputProcessorDistance = new NumericUpDown();
            groupProps = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel2 = new Panel();
            boxGroupColor = new PictureBox();
            buttonGroupColor = new Button();
            inputPostSpawnBehavior = new ComboBox();
            inputAffectedGroup = new ComboBox();
            lblPostSpawnWanderSpeed = new WalkerSim.Editor.LabelWithHelp();
            movementSpeedText = new WalkerSim.Editor.LabelWithHelp();
            inputMovementSpeed = new NumericUpDown();
            affectedAgentsLabel = new Label();
            groupColorLabel = new WalkerSim.Editor.LabelWithHelp();
            postSpawnBehaviorLabel = new WalkerSim.Editor.LabelWithHelp();
            inputWanderSpeed = new ComboBox();
            affectedGroupLabel = new WalkerSim.Editor.LabelWithHelp();
            statisticsTab = new TabPage();
            groupsStat = new Label();
            groupsLabel = new Label();
            updateTimeStat = new Label();
            updateTimeText = new Label();
            windDirTargetStat = new Label();
            windDirTargetText = new Label();
            simulationTimeStat = new Label();
            simulationTimeLabel = new Label();
            nextWindChangeStat = new Label();
            nextWindChangeLabel = new Label();
            windDirStat = new Label();
            windDirText = new Label();
            ticksCount = new Label();
            ticksText = new Label();
            activeAgentsCount = new Label();
            activeAgentsLabel = new Label();
            inactiveAgentsCount = new Label();
            inactiveAgentsLabel = new Label();
            totalAgentsCount = new Label();
            totalAgentsLabel = new Label();
            tabPage3 = new TabPage();
            rtbLog = new RichTextBox();
            contextLog = new ContextMenuStrip(components);
            clearToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            colorPickerDlg = new ColorDialog();
            toolTipGroupSize = new ToolTip(components);
            zoomInBtn = new Label();
            zoomOutBtn = new Label();
            zoomResetBtn = new Label();
            menuStrip1.SuspendLayout();
            ((ISupportInitialize)(splitContainer1)).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((ISupportInitialize)(simCanvas)).BeginInit();
            tabSimulation.SuspendLayout();
            baseParametersTab.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((ISupportInitialize)(inputSpawnProtectionTime)).BeginInit();
            panel1.SuspendLayout();
            ((ISupportInitialize)(inputRandomSeed)).BeginInit();
            ((ISupportInitialize)(inputGroupSize)).BeginInit();
            ((ISupportInitialize)(inputMaxAgents)).BeginInit();
            ((ISupportInitialize)(inputActivationRadius)).BeginInit();
            ((ISupportInitialize)(inputSoundDistanceScale)).BeginInit();
            movementSystemsTab.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            systemsGroupBox1.SuspendLayout();
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
            statisticsTab.SuspendLayout();
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
            tabSimulation.Controls.Add(baseParametersTab);
            tabSimulation.Controls.Add(movementSystemsTab);
            tabSimulation.Controls.Add(statisticsTab);
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
            baseParametersTab.Controls.Add(tableLayoutPanel1);
            baseParametersTab.Location = new System.Drawing.Point(4, 22);
            baseParametersTab.Name = "tabPage1";
            baseParametersTab.Padding = new Padding(3);
            baseParametersTab.Size = new System.Drawing.Size(832, 201);
            baseParametersTab.TabIndex = 0;
            baseParametersTab.Text = "Base Parameters";
            baseParametersTab.UseVisualStyleBackColor = true;
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
            tableLayoutPanel1.Controls.Add(worldLabel, 0, 1);
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
            panel1.Controls.Add(randomSeedBtn);
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
            randomSeedBtn.AutoSize = true;
            randomSeedBtn.Dock = DockStyle.Right;
            randomSeedBtn.Location = new System.Drawing.Point(87, 0);
            randomSeedBtn.Margin = new Padding(0);
            randomSeedBtn.Name = "btRand";
            randomSeedBtn.Size = new System.Drawing.Size(25, 20);
            randomSeedBtn.TabIndex = 43;
            randomSeedBtn.Text = "R";
            randomSeedBtn.UseVisualStyleBackColor = true;
            randomSeedBtn.Click += new System.EventHandler(OnRandSeedClick);
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
            worldLabel.AutoSize = true;
            worldLabel.Dock = DockStyle.Fill;
            worldLabel.Location = new System.Drawing.Point(0, 5);
            worldLabel.Margin = new Padding(0);
            worldLabel.Name = "label10";
            worldLabel.Padding = new Padding(0, 2, 0, 0);
            worldLabel.Size = new System.Drawing.Size(162, 30);
            worldLabel.TabIndex = 40;
            worldLabel.Text = "World";

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
            movementSystemsTab.Controls.Add(tableLayoutPanel2);
            movementSystemsTab.Location = new System.Drawing.Point(4, 22);
            movementSystemsTab.Name = "tabPage2";
            movementSystemsTab.Padding = new Padding(3);
            movementSystemsTab.Size = new System.Drawing.Size(832, 201);
            movementSystemsTab.TabIndex = 1;
            movementSystemsTab.Text = "Movement Systems";
            movementSystemsTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.18447F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.98058F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.83495F));
            tableLayoutPanel2.Controls.Add(systemsGroupBox1, 0, 0);
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
            systemsGroupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            systemsGroupBox1.Controls.Add(tableLayoutPanel3);
            systemsGroupBox1.Dock = DockStyle.Fill;
            systemsGroupBox1.Location = new System.Drawing.Point(3, 3);
            systemsGroupBox1.Name = "groupBox1";
            systemsGroupBox1.Size = new System.Drawing.Size(218, 189);
            systemsGroupBox1.TabIndex = 8;
            systemsGroupBox1.TabStop = false;
            systemsGroupBox1.Text = "Systems";
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
            tableLayoutPanel4.Controls.Add(addGroupBtn, 0, 0);
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
            addGroupBtn.Dock = DockStyle.Fill;
            addGroupBtn.Location = new System.Drawing.Point(3, 3);
            addGroupBtn.Name = "button1";
            addGroupBtn.Size = new System.Drawing.Size(64, 26);
            addGroupBtn.TabIndex = 9;
            addGroupBtn.Text = "Add";
            addGroupBtn.UseVisualStyleBackColor = true;
            addGroupBtn.Click += new System.EventHandler(OnAddGroupClick);
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
            tableLayoutPanel8.Controls.Add(addMovementProcessorBtn, 0, 0);
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
            addMovementProcessorBtn.Dock = DockStyle.Fill;
            addMovementProcessorBtn.Location = new System.Drawing.Point(3, 3);
            addMovementProcessorBtn.Name = "button4";
            addMovementProcessorBtn.Size = new System.Drawing.Size(70, 26);
            addMovementProcessorBtn.TabIndex = 8;
            addMovementProcessorBtn.Text = "Add";
            addMovementProcessorBtn.UseVisualStyleBackColor = true;
            addMovementProcessorBtn.Click += new System.EventHandler(OnAddProcessorClick);
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
            tableLayoutPanel9.Controls.Add(powerLabel, 0, 1);
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
            powerLabel.AutoSize = true;
            powerLabel.Location = new System.Drawing.Point(3, 34);
            powerLabel.Margin = new Padding(3, 8, 3, 3);
            powerLabel.Name = "label8";
            powerLabel.Size = new System.Drawing.Size(37, 13);
            powerLabel.TabIndex = 10;
            powerLabel.Text = "Power";
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
            tableLayoutPanel5.Controls.Add(movementSpeedText, 0, 1);
            tableLayoutPanel5.Controls.Add(inputMovementSpeed, 1, 1);
            tableLayoutPanel5.Controls.Add(affectedAgentsLabel, 0, 5);
            tableLayoutPanel5.Controls.Add(groupColorLabel, 0, 2);
            tableLayoutPanel5.Controls.Add(postSpawnBehaviorLabel, 0, 3);
            tableLayoutPanel5.Controls.Add(inputWanderSpeed, 1, 4);
            tableLayoutPanel5.Controls.Add(affectedGroupLabel, 0, 0);
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
            movementSpeedText.AutoSize = true;
            movementSpeedText.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            movementSpeedText.HelpUrl = null;
            movementSpeedText.LabelText = "Movement Speed";
            movementSpeedText.Location = new System.Drawing.Point(3, 35);
            movementSpeedText.Margin = new Padding(3, 8, 3, 3);
            movementSpeedText.Name = "lblMovementSpeed";
            movementSpeedText.Padding = new Padding(4, 0, 0, 2);
            movementSpeedText.Size = new System.Drawing.Size(95, 15);
            movementSpeedText.TabIndex = 2;
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
            affectedAgentsLabel.AutoSize = true;
            affectedAgentsLabel.Location = new System.Drawing.Point(7, 143);
            affectedAgentsLabel.Margin = new Padding(7, 8, 3, 0);
            affectedAgentsLabel.Name = "lblAffected";
            affectedAgentsLabel.Size = new System.Drawing.Size(95, 13);
            affectedAgentsLabel.TabIndex = 9;
            affectedAgentsLabel.Text = "Affected Agents: 0";
            // 
            // lblGroupColor
            // 
            groupColorLabel.AutoSize = true;
            groupColorLabel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupColorLabel.HelpUrl = null;
            groupColorLabel.LabelText = "Group Color";
            groupColorLabel.Location = new System.Drawing.Point(3, 61);
            groupColorLabel.Margin = new Padding(3, 8, 3, 3);
            groupColorLabel.Name = "lblGroupColor";
            groupColorLabel.Padding = new Padding(4, 0, 0, 2);
            groupColorLabel.Size = new System.Drawing.Size(67, 15);
            groupColorLabel.TabIndex = 6;
            // 
            // lblPostSpawnBehavior
            // 
            postSpawnBehaviorLabel.AutoSize = true;
            postSpawnBehaviorLabel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            postSpawnBehaviorLabel.HelpUrl = null;
            postSpawnBehaviorLabel.LabelText = "Post Spawn Behavior";
            postSpawnBehaviorLabel.Location = new System.Drawing.Point(3, 89);
            postSpawnBehaviorLabel.Margin = new Padding(3, 8, 3, 3);
            postSpawnBehaviorLabel.Name = "lblPostSpawnBehavior";
            postSpawnBehaviorLabel.Padding = new Padding(4, 0, 0, 2);
            postSpawnBehaviorLabel.Size = new System.Drawing.Size(113, 15);
            postSpawnBehaviorLabel.TabIndex = 10;
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
            affectedGroupLabel.AutoSize = true;
            affectedGroupLabel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            affectedGroupLabel.HelpUrl = null;
            affectedGroupLabel.LabelText = "Affected Group";
            affectedGroupLabel.Location = new System.Drawing.Point(3, 8);
            affectedGroupLabel.Margin = new Padding(3, 8, 3, 3);
            affectedGroupLabel.Name = "lblAffectedGroup";
            affectedGroupLabel.Padding = new Padding(4, 0, 0, 2);
            affectedGroupLabel.Size = new System.Drawing.Size(83, 15);
            affectedGroupLabel.TabIndex = 17;
            // 
            // tabPage4
            // 
            statisticsTab.Controls.Add(groupsStat);
            statisticsTab.Controls.Add(groupsLabel);
            statisticsTab.Controls.Add(updateTimeStat);
            statisticsTab.Controls.Add(updateTimeText);
            statisticsTab.Controls.Add(windDirTargetStat);
            statisticsTab.Controls.Add(windDirTargetText);
            statisticsTab.Controls.Add(simulationTimeStat);
            statisticsTab.Controls.Add(simulationTimeLabel);
            statisticsTab.Controls.Add(nextWindChangeStat);
            statisticsTab.Controls.Add(nextWindChangeLabel);
            statisticsTab.Controls.Add(windDirStat);
            statisticsTab.Controls.Add(windDirText);
            statisticsTab.Controls.Add(ticksCount);
            statisticsTab.Controls.Add(ticksText);
            statisticsTab.Controls.Add(activeAgentsCount);
            statisticsTab.Controls.Add(activeAgentsLabel);
            statisticsTab.Controls.Add(inactiveAgentsCount);
            statisticsTab.Controls.Add(inactiveAgentsLabel);
            statisticsTab.Controls.Add(totalAgentsCount);
            statisticsTab.Controls.Add(totalAgentsLabel);
            statisticsTab.Location = new System.Drawing.Point(4, 22);
            statisticsTab.Name = "tabPage4";
            statisticsTab.Padding = new Padding(3);
            statisticsTab.Size = new System.Drawing.Size(832, 201);
            statisticsTab.TabIndex = 3;
            statisticsTab.Text = "Statistics";
            statisticsTab.UseVisualStyleBackColor = true;
            // 
            // lblStatGroups
            // 
            groupsStat.AutoSize = true;
            groupsStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            groupsStat.Location = new System.Drawing.Point(126, 60);
            groupsStat.Margin = new Padding(5, 0, 5, 0);
            groupsStat.Name = "lblStatGroups";
            groupsStat.Padding = new Padding(2);
            groupsStat.Size = new System.Drawing.Size(17, 17);
            groupsStat.TabIndex = 19;
            groupsStat.Text = "0";
            // 
            // label24
            // 
            groupsLabel.AutoSize = true;
            groupsLabel.Location = new System.Drawing.Point(10, 60);
            groupsLabel.Margin = new Padding(5, 0, 5, 0);
            groupsLabel.Name = "label24";
            groupsLabel.Padding = new Padding(2);
            groupsLabel.Size = new System.Drawing.Size(48, 17);
            groupsLabel.TabIndex = 18;
            groupsLabel.Text = "Groups:";
            // 
            // lblStatUpdateTime
            // 
            updateTimeStat.AutoSize = true;
            updateTimeStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            updateTimeStat.Location = new System.Drawing.Point(622, 43);
            updateTimeStat.Margin = new Padding(5, 0, 5, 0);
            updateTimeStat.Name = "lblStatUpdateTime";
            updateTimeStat.Padding = new Padding(2);
            updateTimeStat.Size = new System.Drawing.Size(33, 17);
            updateTimeStat.TabIndex = 17;
            updateTimeStat.Text = "0 ms";
            // 
            // label22
            // 
            updateTimeText.AutoSize = true;
            updateTimeText.Location = new System.Drawing.Point(522, 43);
            updateTimeText.Margin = new Padding(5, 0, 5, 0);
            updateTimeText.Name = "label22";
            updateTimeText.Padding = new Padding(2);
            updateTimeText.Size = new System.Drawing.Size(75, 17);
            updateTimeText.TabIndex = 16;
            updateTimeText.Text = "Update Time:";
            // 
            // lblStatWindTarget
            // 
            windDirTargetStat.AutoSize = true;
            windDirTargetStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            windDirTargetStat.Location = new System.Drawing.Point(352, 9);
            windDirTargetStat.Margin = new Padding(5, 0, 5, 0);
            windDirTargetStat.Name = "lblStatWindTarget";
            windDirTargetStat.Padding = new Padding(2);
            windDirTargetStat.Size = new System.Drawing.Size(26, 17);
            windDirTargetStat.TabIndex = 15;
            windDirTargetStat.Text = "0 0";
            // 
            // label20
            // 
            windDirTargetText.AutoSize = true;
            windDirTargetText.Location = new System.Drawing.Point(218, 9);
            windDirTargetText.Margin = new Padding(5, 0, 5, 0);
            windDirTargetText.Name = "label20";
            windDirTargetText.Padding = new Padding(2);
            windDirTargetText.Size = new System.Drawing.Size(118, 17);
            windDirTargetText.TabIndex = 14;
            windDirTargetText.Text = "Wind Direction Target:";
            // 
            // lblStatSimTime
            // 
            simulationTimeStat.AutoSize = true;
            simulationTimeStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            simulationTimeStat.Location = new System.Drawing.Point(622, 26);
            simulationTimeStat.Margin = new Padding(5, 0, 5, 0);
            simulationTimeStat.Name = "lblStatSimTime";
            simulationTimeStat.Padding = new Padding(2);
            simulationTimeStat.Size = new System.Drawing.Size(33, 17);
            simulationTimeStat.TabIndex = 13;
            simulationTimeStat.Text = "0 ms";
            // 
            // label27
            // 
            simulationTimeLabel.AutoSize = true;
            simulationTimeLabel.Location = new System.Drawing.Point(522, 26);
            simulationTimeLabel.Margin = new Padding(5, 0, 5, 0);
            simulationTimeLabel.Name = "label27";
            simulationTimeLabel.Padding = new Padding(2);
            simulationTimeLabel.Size = new System.Drawing.Size(88, 17);
            simulationTimeLabel.TabIndex = 12;
            simulationTimeLabel.Text = "Simulation Time:";
            // 
            // lblStatWindChange
            // 
            nextWindChangeStat.AutoSize = true;
            nextWindChangeStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            nextWindChangeStat.Location = new System.Drawing.Point(352, 43);
            nextWindChangeStat.Margin = new Padding(5, 0, 5, 0);
            nextWindChangeStat.Name = "lblStatWindChange";
            nextWindChangeStat.Padding = new Padding(2);
            nextWindChangeStat.Size = new System.Drawing.Size(17, 17);
            nextWindChangeStat.TabIndex = 11;
            nextWindChangeStat.Text = "0";
            // 
            // label25
            // 
            nextWindChangeLabel.AutoSize = true;
            nextWindChangeLabel.Location = new System.Drawing.Point(218, 43);
            nextWindChangeLabel.Margin = new Padding(5, 0, 5, 0);
            nextWindChangeLabel.Name = "label25";
            nextWindChangeLabel.Padding = new Padding(2);
            nextWindChangeLabel.Size = new System.Drawing.Size(101, 17);
            nextWindChangeLabel.TabIndex = 10;
            nextWindChangeLabel.Text = "Next Wind Change";
            // 
            // lblStatWindDir
            // 
            windDirStat.AutoSize = true;
            windDirStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            windDirStat.Location = new System.Drawing.Point(352, 26);
            windDirStat.Margin = new Padding(5, 0, 5, 0);
            windDirStat.Name = "lblStatWindDir";
            windDirStat.Padding = new Padding(2);
            windDirStat.Size = new System.Drawing.Size(26, 17);
            windDirStat.TabIndex = 9;
            windDirStat.Text = "0 0";
            // 
            // label23
            // 
            windDirText.AutoSize = true;
            windDirText.Location = new System.Drawing.Point(218, 26);
            windDirText.Margin = new Padding(5, 0, 5, 0);
            windDirText.Name = "label23";
            windDirText.Padding = new Padding(2);
            windDirText.Size = new System.Drawing.Size(84, 17);
            windDirText.TabIndex = 8;
            windDirText.Text = "Wind Direction:";
            // 
            // lblStatTicks
            // 
            ticksCount.AutoSize = true;
            ticksCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            ticksCount.Location = new System.Drawing.Point(622, 9);
            ticksCount.Margin = new Padding(5, 0, 5, 0);
            ticksCount.Name = "lblStatTicks";
            ticksCount.Padding = new Padding(2);
            ticksCount.Size = new System.Drawing.Size(17, 17);
            ticksCount.TabIndex = 7;
            ticksCount.Text = "0";
            // 
            // label21
            // 
            ticksText.AutoSize = true;
            ticksText.Location = new System.Drawing.Point(522, 9);
            ticksText.Margin = new Padding(5, 0, 5, 0);
            ticksText.Name = "label21";
            ticksText.Padding = new Padding(2);
            ticksText.Size = new System.Drawing.Size(40, 17);
            ticksText.TabIndex = 6;
            ticksText.Text = "Ticks:";
            // 
            // lblStatActive
            // 
            activeAgentsCount.AutoSize = true;
            activeAgentsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            activeAgentsCount.Location = new System.Drawing.Point(126, 43);
            activeAgentsCount.Margin = new Padding(5, 0, 5, 0);
            activeAgentsCount.Name = "lblStatActive";
            activeAgentsCount.Padding = new Padding(2);
            activeAgentsCount.Size = new System.Drawing.Size(17, 17);
            activeAgentsCount.TabIndex = 5;
            activeAgentsCount.Text = "0";
            // 
            // label19
            // 
            activeAgentsLabel.AutoSize = true;
            activeAgentsLabel.Location = new System.Drawing.Point(10, 43);
            activeAgentsLabel.Margin = new Padding(5, 0, 5, 0);
            activeAgentsLabel.Name = "label19";
            activeAgentsLabel.Padding = new Padding(2);
            activeAgentsLabel.Size = new System.Drawing.Size(80, 17);
            activeAgentsLabel.TabIndex = 4;
            activeAgentsLabel.Text = "Active Agents:";
            // 
            // lblStatInactive
            // 
            inactiveAgentsCount.AutoSize = true;
            inactiveAgentsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            inactiveAgentsCount.Location = new System.Drawing.Point(126, 26);
            inactiveAgentsCount.Margin = new Padding(5, 0, 5, 0);
            inactiveAgentsCount.Name = "lblStatInactive";
            inactiveAgentsCount.Padding = new Padding(2);
            inactiveAgentsCount.Size = new System.Drawing.Size(17, 17);
            inactiveAgentsCount.TabIndex = 3;
            inactiveAgentsCount.Text = "0";
            // 
            // label17
            // 
            inactiveAgentsLabel.AutoSize = true;
            inactiveAgentsLabel.Location = new System.Drawing.Point(10, 26);
            inactiveAgentsLabel.Margin = new Padding(5, 0, 5, 0);
            inactiveAgentsLabel.Name = "label17";
            inactiveAgentsLabel.Padding = new Padding(2);
            inactiveAgentsLabel.Size = new System.Drawing.Size(88, 17);
            inactiveAgentsLabel.TabIndex = 2;
            inactiveAgentsLabel.Text = "Inactive Agents:";
            // 
            // lblStatTotalAgents
            // 
            totalAgentsCount.AutoSize = true;
            totalAgentsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            totalAgentsCount.Location = new System.Drawing.Point(126, 9);
            totalAgentsCount.Margin = new Padding(5, 0, 5, 0);
            totalAgentsCount.Name = "lblStatTotalAgents";
            totalAgentsCount.Padding = new Padding(2);
            totalAgentsCount.Size = new System.Drawing.Size(17, 17);
            totalAgentsCount.TabIndex = 1;
            totalAgentsCount.Text = "0";
            // 
            // label16
            // 
            totalAgentsLabel.AutoSize = true;
            totalAgentsLabel.Location = new System.Drawing.Point(9, 9);
            totalAgentsLabel.Margin = new Padding(5, 0, 5, 0);
            totalAgentsLabel.Name = "label16";
            totalAgentsLabel.Padding = new Padding(2);
            totalAgentsLabel.Size = new System.Drawing.Size(74, 17);
            totalAgentsLabel.TabIndex = 0;
            totalAgentsLabel.Text = "Total Agents:";
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
            zoomInBtn.BackColor = System.Drawing.Color.Black;
            zoomInBtn.BorderStyle = BorderStyle.FixedSingle;
            zoomInBtn.FlatStyle = FlatStyle.Flat;
            zoomInBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            zoomInBtn.ForeColor = System.Drawing.Color.White;
            zoomInBtn.Location = new System.Drawing.Point(35, 35);
            zoomInBtn.Margin = new Padding(0);
            zoomInBtn.Name = "btZoomIn";
            zoomInBtn.Size = new System.Drawing.Size(22, 22);
            zoomInBtn.TabIndex = 7;
            zoomInBtn.Text = "+";
            zoomInBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            zoomInBtn.Click += new System.EventHandler(OnZoomInClick);
            // 
            // btZoomOut
            // 
            zoomOutBtn.BackColor = System.Drawing.Color.Black;
            zoomOutBtn.BorderStyle = BorderStyle.FixedSingle;
            zoomOutBtn.FlatStyle = FlatStyle.Flat;
            zoomOutBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            zoomOutBtn.ForeColor = System.Drawing.Color.White;
            zoomOutBtn.Location = new System.Drawing.Point(10, 35);
            zoomOutBtn.Margin = new Padding(0);
            zoomOutBtn.Name = "btZoomOut";
            zoomOutBtn.Size = new System.Drawing.Size(22, 22);
            zoomOutBtn.TabIndex = 8;
            zoomOutBtn.Text = "-";
            zoomOutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            zoomOutBtn.Click += new System.EventHandler(OnZoomOutClick);
            // 
            // label29
            // 
            zoomResetBtn.BackColor = System.Drawing.Color.Black;
            zoomResetBtn.BorderStyle = BorderStyle.FixedSingle;
            zoomResetBtn.FlatStyle = FlatStyle.Flat;
            zoomResetBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            zoomResetBtn.ForeColor = System.Drawing.Color.White;
            zoomResetBtn.Location = new System.Drawing.Point(60, 35);
            zoomResetBtn.Margin = new Padding(0);
            zoomResetBtn.Name = "label29";
            zoomResetBtn.Size = new System.Drawing.Size(22, 22);
            zoomResetBtn.TabIndex = 9;
            zoomResetBtn.Text = "R";
            zoomResetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            zoomResetBtn.Click += new System.EventHandler(OnZoomResetClick);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(840, 716);
            Controls.Add(zoomResetBtn);
            Controls.Add(zoomOutBtn);
            Controls.Add(zoomInBtn);
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
            baseParametersTab.ResumeLayout(false);
            baseParametersTab.PerformLayout();
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
            movementSystemsTab.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            systemsGroupBox1.ResumeLayout(false);
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
            statisticsTab.ResumeLayout(false);
            statisticsTab.PerformLayout();
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
        private TabPage baseParametersTab;
        private TabPage movementSystemsTab;
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
        private LabelWithHelp movementSpeedText;
        private ComboBox inputWorld;
        private Label worldLabel;
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
        private LabelWithHelp groupColorLabel;
        private PictureBox boxGroupColor;
        private Button buttonGroupColor;
        private ColorDialog colorPickerDlg;
        private ToolStripMenuItem exportConfigurationToolStripMenuItem;
        private Button randomSeedBtn;
        private ToolTip toolTipGroupSize;
        private Label affectedAgentsLabel;
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
        private LabelWithHelp postSpawnBehaviorLabel;
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
        private TabPage statisticsTab;
        private Label totalAgentsCount;
        private Label totalAgentsLabel;
        private Label activeAgentsCount;
        private Label activeAgentsLabel;
        private Label inactiveAgentsCount;
        private Label inactiveAgentsLabel;
        private Label simulationTimeStat;
        private Label simulationTimeLabel;
        private Label nextWindChangeStat;
        private Label nextWindChangeLabel;
        private Label windDirStat;
        private Label windDirText;
        private Label ticksCount;
        private Label ticksText;
        private Label windDirTargetStat;
        private Label windDirTargetText;
        private Label updateTimeStat;
        private Label updateTimeText;
        private Label groupsStat;
        private Label groupsLabel;
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
        private GroupBox systemsGroupBox1;
        private Button buttonRemoveGroup;
        private Button addGroupBtn;
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
        private Button addMovementProcessorBtn;
        private Button buttonRemoveProcessor;
        private ListBox listProcessors;
        private GroupBox groupParameter;
        private TableLayoutPanel tableLayoutPanel9;
        private NumericUpDown inputProcessorPower;
        private Label label9;
        private Label powerLabel;
        private NumericUpDown inputProcessorDistance;
        private Label zoomInBtn;
        private Label zoomOutBtn;
        private Label zoomResetBtn;
        private LabelWithHelp affectedGroupLabel;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem documentationToolStripMenuItem;
        private LabelWithHelp labelWithHelp1;
        private NumericUpDown inputSoundDistanceScale;
    }
}

