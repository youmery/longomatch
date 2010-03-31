// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LongoMatch.Gui {
    
    
    public partial class MainWindow {
        
        private Gtk.UIManager UIManager;
        
        private Gtk.Action FileAction;
        
        private Gtk.Action NewPojectAction;
        
        private Gtk.Action OpenProjectAction;
        
        private Gtk.Action QuitAction;
        
        private Gtk.Action CloseProjectAction;
        
        private Gtk.Action ToolsAction;
        
        private Gtk.Action ProjectsManagerAction;
        
        private Gtk.Action CategoriesTemplatesManagerAction;
        
        private Gtk.Action ViewAction;
        
        private Gtk.ToggleAction FullScreenAction;
        
        private Gtk.ToggleAction PlaylistAction;
        
        private Gtk.RadioAction CaptureModeAction;
        
        private Gtk.RadioAction AnalyzeModeAction;
        
        private Gtk.Action SaveProjectAction;
        
        private Gtk.Action HelpAction;
        
        private Gtk.Action AboutAction;
        
        private Gtk.Action ExportProjectToCSVFileAction;
        
        private Gtk.Action TeamsTemplatesManagerAction;
        
        private Gtk.ToggleAction HideAllWidgetsAction;
        
        private Gtk.Action HelpAction1;
        
        private Gtk.ToggleAction DrawingToolAction;
        
        private Gtk.Action ImportProjectAction;
        
        private Gtk.RadioAction FreeCaptureModeAction;
        
        private Gtk.VBox vbox1;
        
        private Gtk.VBox menubox;
        
        private Gtk.MenuBar menubar1;
        
        private Gtk.HPaned hpaned;
        
        private Gtk.VBox leftbox;
        
        private Gtk.Notebook notebook1;
        
        private LongoMatch.Gui.Component.PlaysListTreeWidget treewidget1;
        
        private Gtk.Label label2;
        
        private LongoMatch.Gui.Component.PlayersListTreeWidget localplayerslisttreewidget;
        
        private Gtk.Label label6;
        
        private LongoMatch.Gui.Component.PlayersListTreeWidget visitorplayerslisttreewidget;
        
        private Gtk.Label label4;
        
        private LongoMatch.Gui.Component.TagsTreeWidget tagstreewidget1;
        
        private Gtk.Label label7;
        
        private Gtk.HPaned hpaned1;
        
        private Gtk.VBox vbox5;
        
        private Gtk.HBox hbox2;
        
        private LongoMatch.Gui.Component.DrawingToolBox drawingtoolbox1;
        
        private LongoMatch.Gui.PlayerBin playerbin1;
        
        private LongoMatch.Gui.Component.TimeLineWidget timelinewidget1;
        
        private LongoMatch.Gui.Component.ButtonsWidget buttonswidget1;
        
        private Gtk.VBox rightvbox;
        
        private LongoMatch.Gui.Component.NotesWidget noteswidget1;
        
        private LongoMatch.Gui.Component.PlayListWidget playlistwidget2;
        
        private Gtk.Statusbar statusbar1;
        
        private Gtk.ProgressBar videoprogressbar;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget LongoMatch.Gui.MainWindow
            this.UIManager = new Gtk.UIManager();
            Gtk.ActionGroup w1 = new Gtk.ActionGroup("Default");
            this.FileAction = new Gtk.Action("FileAction", Mono.Unix.Catalog.GetString("_File"), null, null);
            this.FileAction.ShortLabel = Mono.Unix.Catalog.GetString("_File");
            w1.Add(this.FileAction, null);
            this.NewPojectAction = new Gtk.Action("NewPojectAction", Mono.Unix.Catalog.GetString("_New Project"), null, "gtk-new");
            this.NewPojectAction.ShortLabel = Mono.Unix.Catalog.GetString("_New Project");
            w1.Add(this.NewPojectAction, null);
            this.OpenProjectAction = new Gtk.Action("OpenProjectAction", Mono.Unix.Catalog.GetString("_Open Project"), null, "gtk-open");
            this.OpenProjectAction.ShortLabel = Mono.Unix.Catalog.GetString("_Open Project");
            w1.Add(this.OpenProjectAction, null);
            this.QuitAction = new Gtk.Action("QuitAction", Mono.Unix.Catalog.GetString("_Quit"), null, "gtk-quit");
            this.QuitAction.ShortLabel = Mono.Unix.Catalog.GetString("_Quit");
            w1.Add(this.QuitAction, null);
            this.CloseProjectAction = new Gtk.Action("CloseProjectAction", Mono.Unix.Catalog.GetString("_Close Project"), null, "gtk-close");
            this.CloseProjectAction.Sensitive = false;
            this.CloseProjectAction.ShortLabel = Mono.Unix.Catalog.GetString("_Close Project");
            w1.Add(this.CloseProjectAction, null);
            this.ToolsAction = new Gtk.Action("ToolsAction", Mono.Unix.Catalog.GetString("_Tools"), null, null);
            this.ToolsAction.ShortLabel = Mono.Unix.Catalog.GetString("_Tools");
            w1.Add(this.ToolsAction, null);
            this.ProjectsManagerAction = new Gtk.Action("ProjectsManagerAction", Mono.Unix.Catalog.GetString("Projects Manager"), null, null);
            this.ProjectsManagerAction.ShortLabel = Mono.Unix.Catalog.GetString("Database Manager");
            w1.Add(this.ProjectsManagerAction, null);
            this.CategoriesTemplatesManagerAction = new Gtk.Action("CategoriesTemplatesManagerAction", Mono.Unix.Catalog.GetString("Categories Templates Manager"), null, null);
            this.CategoriesTemplatesManagerAction.ShortLabel = Mono.Unix.Catalog.GetString("Templates Manager");
            w1.Add(this.CategoriesTemplatesManagerAction, null);
            this.ViewAction = new Gtk.Action("ViewAction", Mono.Unix.Catalog.GetString("_View"), null, null);
            this.ViewAction.ShortLabel = Mono.Unix.Catalog.GetString("_View");
            w1.Add(this.ViewAction, "<Control>t");
            this.FullScreenAction = new Gtk.ToggleAction("FullScreenAction", Mono.Unix.Catalog.GetString("Full Screen"), null, "gtk-fullscreen");
            this.FullScreenAction.ShortLabel = Mono.Unix.Catalog.GetString("Full Screen");
            w1.Add(this.FullScreenAction, null);
            this.PlaylistAction = new Gtk.ToggleAction("PlaylistAction", Mono.Unix.Catalog.GetString("Playlist"), null, null);
            this.PlaylistAction.ShortLabel = Mono.Unix.Catalog.GetString("Playlist");
            w1.Add(this.PlaylistAction, null);
            this.CaptureModeAction = new Gtk.RadioAction("CaptureModeAction", Mono.Unix.Catalog.GetString("Capture Mode"), null, null, 0);
            this.CaptureModeAction.Group = new GLib.SList(System.IntPtr.Zero);
            this.CaptureModeAction.Sensitive = false;
            this.CaptureModeAction.ShortLabel = Mono.Unix.Catalog.GetString("Capture Mode");
            w1.Add(this.CaptureModeAction, null);
            this.AnalyzeModeAction = new Gtk.RadioAction("AnalyzeModeAction", Mono.Unix.Catalog.GetString("Analyze Mode"), null, null, 0);
            this.AnalyzeModeAction.Group = this.CaptureModeAction.Group;
            this.AnalyzeModeAction.Sensitive = false;
            this.AnalyzeModeAction.ShortLabel = Mono.Unix.Catalog.GetString("Analyze Mode");
            w1.Add(this.AnalyzeModeAction, null);
            this.SaveProjectAction = new Gtk.Action("SaveProjectAction", Mono.Unix.Catalog.GetString("_Save Project"), null, "gtk-save");
            this.SaveProjectAction.Sensitive = false;
            this.SaveProjectAction.ShortLabel = Mono.Unix.Catalog.GetString("_Save Project");
            w1.Add(this.SaveProjectAction, null);
            this.HelpAction = new Gtk.Action("HelpAction", Mono.Unix.Catalog.GetString("_Help"), null, null);
            this.HelpAction.ShortLabel = Mono.Unix.Catalog.GetString("_Help");
            w1.Add(this.HelpAction, null);
            this.AboutAction = new Gtk.Action("AboutAction", Mono.Unix.Catalog.GetString("_About"), null, "gtk-about");
            this.AboutAction.ShortLabel = Mono.Unix.Catalog.GetString("_About");
            w1.Add(this.AboutAction, null);
            this.ExportProjectToCSVFileAction = new Gtk.Action("ExportProjectToCSVFileAction", Mono.Unix.Catalog.GetString("Export Project To CSV File"), null, null);
            this.ExportProjectToCSVFileAction.Sensitive = false;
            this.ExportProjectToCSVFileAction.ShortLabel = Mono.Unix.Catalog.GetString("Export Project To CSV File");
            w1.Add(this.ExportProjectToCSVFileAction, null);
            this.TeamsTemplatesManagerAction = new Gtk.Action("TeamsTemplatesManagerAction", Mono.Unix.Catalog.GetString("Teams Templates Manager"), null, null);
            this.TeamsTemplatesManagerAction.ShortLabel = Mono.Unix.Catalog.GetString("Teams Templates Manager");
            w1.Add(this.TeamsTemplatesManagerAction, null);
            this.HideAllWidgetsAction = new Gtk.ToggleAction("HideAllWidgetsAction", Mono.Unix.Catalog.GetString("Hide All Widgets"), null, null);
            this.HideAllWidgetsAction.Sensitive = false;
            this.HideAllWidgetsAction.ShortLabel = Mono.Unix.Catalog.GetString("Hide All Widgets");
            w1.Add(this.HideAllWidgetsAction, null);
            this.HelpAction1 = new Gtk.Action("HelpAction1", Mono.Unix.Catalog.GetString("_Help"), null, "gtk-help");
            this.HelpAction1.ShortLabel = Mono.Unix.Catalog.GetString("_Help");
            w1.Add(this.HelpAction1, null);
            this.DrawingToolAction = new Gtk.ToggleAction("DrawingToolAction", Mono.Unix.Catalog.GetString("_Drawing Tool"), null, null);
            this.DrawingToolAction.ShortLabel = Mono.Unix.Catalog.GetString("Drawing Tool");
            w1.Add(this.DrawingToolAction, "<Control>d");
            this.ImportProjectAction = new Gtk.Action("ImportProjectAction", Mono.Unix.Catalog.GetString("_Import Project"), null, "stock-import");
            this.ImportProjectAction.ShortLabel = Mono.Unix.Catalog.GetString("_Import Project");
            w1.Add(this.ImportProjectAction, "<Control>i");
            this.FreeCaptureModeAction = new Gtk.RadioAction("FreeCaptureModeAction", Mono.Unix.Catalog.GetString("Free Capture Mode"), null, null, 0);
            this.FreeCaptureModeAction.Group = this.CaptureModeAction.Group;
            this.FreeCaptureModeAction.Sensitive = false;
            this.FreeCaptureModeAction.ShortLabel = Mono.Unix.Catalog.GetString("Free Capture Mode");
            w1.Add(this.FreeCaptureModeAction, null);
            this.UIManager.InsertActionGroup(w1, 0);
            this.AddAccelGroup(this.UIManager.AccelGroup);
            this.Name = "LongoMatch.Gui.MainWindow";
            this.Title = Mono.Unix.Catalog.GetString("LongoMatch");
            this.Icon = Stetic.IconLoader.LoadIcon(this, "longomatch", Gtk.IconSize.Dialog, 48);
            this.WindowPosition = ((Gtk.WindowPosition)(1));
            this.Gravity = ((Gdk.Gravity)(5));
            // Container child LongoMatch.Gui.MainWindow.Gtk.Container+ContainerChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;
            // Container child vbox1.Gtk.Box+BoxChild
            this.menubox = new Gtk.VBox();
            this.menubox.Name = "menubox";
            this.menubox.Spacing = 6;
            // Container child menubox.Gtk.Box+BoxChild
            this.UIManager.AddUiFromString("<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='NewPojectAction' action='NewPojectAction'/><menuitem name='OpenProjectAction' action='OpenProjectAction'/><menuitem name='SaveProjectAction' action='SaveProjectAction'/><menuitem name='CloseProjectAction' action='CloseProjectAction'/><separator/><menuitem name='ImportProjectAction' action='ImportProjectAction'/><separator/><menuitem name='QuitAction' action='QuitAction'/></menu><menu name='ToolsAction' action='ToolsAction'><menuitem name='ProjectsManagerAction' action='ProjectsManagerAction'/><menuitem name='CategoriesTemplatesManagerAction' action='CategoriesTemplatesManagerAction'/><menuitem name='TeamsTemplatesManagerAction' action='TeamsTemplatesManagerAction'/><menuitem name='ExportProjectToCSVFileAction' action='ExportProjectToCSVFileAction'/></menu><menu name='ViewAction' action='ViewAction'><menuitem name='FullScreenAction' action='FullScreenAction'/><menuitem name='HideAllWidgetsAction' action='HideAllWidgetsAction'/><separator/><menuitem name='PlaylistAction' action='PlaylistAction'/><menuitem name='DrawingToolAction' action='DrawingToolAction'/><separator/><menuitem name='CaptureModeAction' action='CaptureModeAction'/><menuitem name='FreeCaptureModeAction' action='FreeCaptureModeAction'/><menuitem name='AnalyzeModeAction' action='AnalyzeModeAction'/></menu><menu name='HelpAction' action='HelpAction'><menuitem name='AboutAction' action='AboutAction'/><menuitem name='HelpAction1' action='HelpAction1'/></menu></menubar></ui>");
            this.menubar1 = ((Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
            this.menubar1.Name = "menubar1";
            this.menubox.Add(this.menubar1);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.menubox[this.menubar1]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            this.vbox1.Add(this.menubox);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox1[this.menubox]));
            w3.Position = 0;
            w3.Expand = false;
            w3.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.hpaned = new Gtk.HPaned();
            this.hpaned.CanFocus = true;
            this.hpaned.Name = "hpaned";
            this.hpaned.Position = 335;
            // Container child hpaned.Gtk.Paned+PanedChild
            this.leftbox = new Gtk.VBox();
            this.leftbox.Name = "leftbox";
            this.leftbox.Spacing = 6;
            // Container child leftbox.Gtk.Box+BoxChild
            this.notebook1 = new Gtk.Notebook();
            this.notebook1.CanFocus = true;
            this.notebook1.Name = "notebook1";
            this.notebook1.CurrentPage = 3;
            this.notebook1.TabPos = ((Gtk.PositionType)(3));
            // Container child notebook1.Gtk.Notebook+NotebookChild
            this.treewidget1 = new LongoMatch.Gui.Component.PlaysListTreeWidget();
            this.treewidget1.Events = ((Gdk.EventMask)(256));
            this.treewidget1.Name = "treewidget1";
            this.notebook1.Add(this.treewidget1);
            // Notebook tab
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.LabelProp = Mono.Unix.Catalog.GetString("Plays");
            this.notebook1.SetTabLabel(this.treewidget1, this.label2);
            this.label2.ShowAll();
            // Container child notebook1.Gtk.Notebook+NotebookChild
            this.localplayerslisttreewidget = new LongoMatch.Gui.Component.PlayersListTreeWidget();
            this.localplayerslisttreewidget.Events = ((Gdk.EventMask)(256));
            this.localplayerslisttreewidget.Name = "localplayerslisttreewidget";
            this.notebook1.Add(this.localplayerslisttreewidget);
            Gtk.Notebook.NotebookChild w5 = ((Gtk.Notebook.NotebookChild)(this.notebook1[this.localplayerslisttreewidget]));
            w5.Position = 1;
            // Notebook tab
            this.label6 = new Gtk.Label();
            this.label6.Name = "label6";
            this.label6.LabelProp = Mono.Unix.Catalog.GetString("Local Team");
            this.notebook1.SetTabLabel(this.localplayerslisttreewidget, this.label6);
            this.label6.ShowAll();
            // Container child notebook1.Gtk.Notebook+NotebookChild
            this.visitorplayerslisttreewidget = new LongoMatch.Gui.Component.PlayersListTreeWidget();
            this.visitorplayerslisttreewidget.Events = ((Gdk.EventMask)(256));
            this.visitorplayerslisttreewidget.Name = "visitorplayerslisttreewidget";
            this.notebook1.Add(this.visitorplayerslisttreewidget);
            Gtk.Notebook.NotebookChild w6 = ((Gtk.Notebook.NotebookChild)(this.notebook1[this.visitorplayerslisttreewidget]));
            w6.Position = 2;
            // Notebook tab
            this.label4 = new Gtk.Label();
            this.label4.Name = "label4";
            this.label4.LabelProp = Mono.Unix.Catalog.GetString("Visitor Team");
            this.notebook1.SetTabLabel(this.visitorplayerslisttreewidget, this.label4);
            this.label4.ShowAll();
            // Container child notebook1.Gtk.Notebook+NotebookChild
            this.tagstreewidget1 = new LongoMatch.Gui.Component.TagsTreeWidget();
            this.tagstreewidget1.Events = ((Gdk.EventMask)(256));
            this.tagstreewidget1.Name = "tagstreewidget1";
            this.notebook1.Add(this.tagstreewidget1);
            Gtk.Notebook.NotebookChild w7 = ((Gtk.Notebook.NotebookChild)(this.notebook1[this.tagstreewidget1]));
            w7.Position = 3;
            // Notebook tab
            this.label7 = new Gtk.Label();
            this.label7.Name = "label7";
            this.label7.LabelProp = Mono.Unix.Catalog.GetString("Tags");
            this.notebook1.SetTabLabel(this.tagstreewidget1, this.label7);
            this.label7.ShowAll();
            this.leftbox.Add(this.notebook1);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.leftbox[this.notebook1]));
            w8.Position = 0;
            this.hpaned.Add(this.leftbox);
            Gtk.Paned.PanedChild w9 = ((Gtk.Paned.PanedChild)(this.hpaned[this.leftbox]));
            w9.Resize = false;
            // Container child hpaned.Gtk.Paned+PanedChild
            this.hpaned1 = new Gtk.HPaned();
            this.hpaned1.CanFocus = true;
            this.hpaned1.Name = "hpaned1";
            this.hpaned1.Position = 770;
            // Container child hpaned1.Gtk.Paned+PanedChild
            this.vbox5 = new Gtk.VBox();
            this.vbox5.Name = "vbox5";
            this.vbox5.Spacing = 6;
            // Container child vbox5.Gtk.Box+BoxChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.drawingtoolbox1 = new LongoMatch.Gui.Component.DrawingToolBox();
            this.drawingtoolbox1.Events = ((Gdk.EventMask)(256));
            this.drawingtoolbox1.Name = "drawingtoolbox1";
            this.hbox2.Add(this.drawingtoolbox1);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.hbox2[this.drawingtoolbox1]));
            w10.Position = 0;
            w10.Expand = false;
            w10.Fill = false;
            // Container child hbox2.Gtk.Box+BoxChild
            this.playerbin1 = new LongoMatch.Gui.PlayerBin();
            this.playerbin1.Events = ((Gdk.EventMask)(256));
            this.playerbin1.Name = "playerbin1";
            this.playerbin1.Rate = 1F;
            this.playerbin1.ExpandLogo = true;
            this.hbox2.Add(this.playerbin1);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.hbox2[this.playerbin1]));
            w11.Position = 1;
            this.vbox5.Add(this.hbox2);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.vbox5[this.hbox2]));
            w12.Position = 0;
            // Container child vbox5.Gtk.Box+BoxChild
            this.timelinewidget1 = new LongoMatch.Gui.Component.TimeLineWidget();
            this.timelinewidget1.HeightRequest = 200;
            this.timelinewidget1.Events = ((Gdk.EventMask)(256));
            this.timelinewidget1.Name = "timelinewidget1";
            this.timelinewidget1.CurrentFrame = ((uint)(0));
            this.vbox5.Add(this.timelinewidget1);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.vbox5[this.timelinewidget1]));
            w13.Position = 1;
            w13.Expand = false;
            // Container child vbox5.Gtk.Box+BoxChild
            this.buttonswidget1 = new LongoMatch.Gui.Component.ButtonsWidget();
            this.buttonswidget1.Events = ((Gdk.EventMask)(256));
            this.buttonswidget1.Name = "buttonswidget1";
            this.vbox5.Add(this.buttonswidget1);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.vbox5[this.buttonswidget1]));
            w14.Position = 2;
            w14.Expand = false;
            this.hpaned1.Add(this.vbox5);
            Gtk.Paned.PanedChild w15 = ((Gtk.Paned.PanedChild)(this.hpaned1[this.vbox5]));
            w15.Resize = false;
            w15.Shrink = false;
            // Container child hpaned1.Gtk.Paned+PanedChild
            this.rightvbox = new Gtk.VBox();
            this.rightvbox.WidthRequest = 100;
            this.rightvbox.Name = "rightvbox";
            this.rightvbox.Spacing = 6;
            // Container child rightvbox.Gtk.Box+BoxChild
            this.noteswidget1 = new LongoMatch.Gui.Component.NotesWidget();
            this.noteswidget1.Events = ((Gdk.EventMask)(256));
            this.noteswidget1.Name = "noteswidget1";
            this.rightvbox.Add(this.noteswidget1);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.rightvbox[this.noteswidget1]));
            w16.Position = 1;
            // Container child rightvbox.Gtk.Box+BoxChild
            this.playlistwidget2 = new LongoMatch.Gui.Component.PlayListWidget();
            this.playlistwidget2.WidthRequest = 100;
            this.playlistwidget2.Events = ((Gdk.EventMask)(256));
            this.playlistwidget2.Name = "playlistwidget2";
            this.rightvbox.Add(this.playlistwidget2);
            Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(this.rightvbox[this.playlistwidget2]));
            w17.Position = 2;
            this.hpaned1.Add(this.rightvbox);
            Gtk.Paned.PanedChild w18 = ((Gtk.Paned.PanedChild)(this.hpaned1[this.rightvbox]));
            w18.Resize = false;
            w18.Shrink = false;
            this.hpaned.Add(this.hpaned1);
            Gtk.Paned.PanedChild w19 = ((Gtk.Paned.PanedChild)(this.hpaned[this.hpaned1]));
            w19.Resize = false;
            w19.Shrink = false;
            this.vbox1.Add(this.hpaned);
            Gtk.Box.BoxChild w20 = ((Gtk.Box.BoxChild)(this.vbox1[this.hpaned]));
            w20.Position = 1;
            // Container child vbox1.Gtk.Box+BoxChild
            this.statusbar1 = new Gtk.Statusbar();
            this.statusbar1.Name = "statusbar1";
            this.statusbar1.Spacing = 6;
            // Container child statusbar1.Gtk.Box+BoxChild
            this.videoprogressbar = new Gtk.ProgressBar();
            this.videoprogressbar.Name = "videoprogressbar";
            this.videoprogressbar.Text = Mono.Unix.Catalog.GetString("Creating video...");
            this.statusbar1.Add(this.videoprogressbar);
            Gtk.Box.BoxChild w21 = ((Gtk.Box.BoxChild)(this.statusbar1[this.videoprogressbar]));
            w21.Position = 3;
            w21.Expand = false;
            w21.Fill = false;
            this.vbox1.Add(this.statusbar1);
            Gtk.Box.BoxChild w22 = ((Gtk.Box.BoxChild)(this.vbox1[this.statusbar1]));
            w22.Position = 2;
            w22.Expand = false;
            w22.Fill = false;
            this.Add(this.vbox1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 1259;
            this.DefaultHeight = 817;
            this.leftbox.Hide();
            this.drawingtoolbox1.Hide();
            this.timelinewidget1.Hide();
            this.buttonswidget1.Hide();
            this.noteswidget1.Hide();
            this.playlistwidget2.Hide();
            this.rightvbox.Hide();
            this.videoprogressbar.Hide();
            this.Show();
            this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
            this.NewPojectAction.Activated += new System.EventHandler(this.OnNewActivated);
            this.OpenProjectAction.Activated += new System.EventHandler(this.OnOpenActivated);
            this.QuitAction.Activated += new System.EventHandler(this.OnQuitActivated);
            this.CloseProjectAction.Activated += new System.EventHandler(this.OnCloseActivated);
            this.ProjectsManagerAction.Activated += new System.EventHandler(this.OnDatabaseManagerActivated);
            this.CategoriesTemplatesManagerAction.Activated += new System.EventHandler(this.OnSectionsTemplatesManagerActivated);
            this.FullScreenAction.Toggled += new System.EventHandler(this.OnFullScreenActionToggled);
            this.PlaylistAction.Toggled += new System.EventHandler(this.OnPlaylistActionToggled);
            this.CaptureModeAction.Toggled += new System.EventHandler(this.OnViewToggled);
            this.SaveProjectAction.Activated += new System.EventHandler(this.OnSaveProjectActionActivated);
            this.AboutAction.Activated += new System.EventHandler(this.OnAboutActionActivated);
            this.ExportProjectToCSVFileAction.Activated += new System.EventHandler(this.OnExportProjectToCSVFileActionActivated);
            this.TeamsTemplatesManagerAction.Activated += new System.EventHandler(this.OnTeamsTemplatesManagerActionActivated);
            this.HideAllWidgetsAction.Toggled += new System.EventHandler(this.OnHideAllWidgetsActionToggled);
            this.HelpAction1.Activated += new System.EventHandler(this.OnHelpAction1Activated);
            this.DrawingToolAction.Toggled += new System.EventHandler(this.OnDrawingToolActionToggled);
            this.ImportProjectAction.Activated += new System.EventHandler(this.OnImportProjectActionActivated);
            this.FreeCaptureModeAction.Toggled += new System.EventHandler(this.OnViewToggled);
            this.treewidget1.TimeNodeSelected += new LongoMatch.Handlers.TimeNodeSelectedHandler(this.OnTimeNodeSelected);
            this.playerbin1.Error += new LongoMatch.Video.Handlers.ErrorHandler(this.OnPlayerbin1Error);
            this.playerbin1.SegmentClosedEvent += new LongoMatch.Video.Handlers.SegmentClosedHandler(this.OnSegmentClosedEvent);
            this.timelinewidget1.TimeNodeSelected += new LongoMatch.Handlers.TimeNodeSelectedHandler(this.OnTimeNodeSelected);
        }
    }
}
