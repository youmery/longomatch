
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Dialog
{
	public partial class ProjectSelectionDialog
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.HBox hbox1;
		private global::Gtk.RadioButton fromfileradiobutton;
		private global::Gtk.Image image61;
		private global::Gtk.HBox hbox2;
		private global::Gtk.RadioButton liveradiobutton;
		private global::Gtk.Image image63;
		private global::Gtk.HBox hbox3;
		private global::Gtk.RadioButton fakeliveradiobutton;
		private global::Gtk.Image image62;
		private global::Gtk.HBox ipcamerabox;
		private global::Gtk.RadioButton uriliveradiobutton;
		private global::Gtk.Image image64;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Dialog.ProjectSelectionDialog
			this.Name = "LongoMatch.Gui.Dialog.ProjectSelectionDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("New Project");
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "longomatch", global::Gtk.IconSize.Menu);
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.Gravity = ((global::Gdk.Gravity)(5));
			this.SkipPagerHint = true;
			this.SkipTaskbarHint = true;
			// Internal child LongoMatch.Gui.Dialog.ProjectSelectionDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.fromfileradiobutton = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("New project using a video file"));
			this.fromfileradiobutton.CanFocus = true;
			this.fromfileradiobutton.Name = "fromfileradiobutton";
			this.fromfileradiobutton.Active = true;
			this.fromfileradiobutton.DrawIndicator = true;
			this.fromfileradiobutton.UseUnderline = true;
			this.fromfileradiobutton.FocusOnClick = false;
			this.fromfileradiobutton.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.hbox1.Add (this.fromfileradiobutton);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.fromfileradiobutton]));
			w2.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.image61 = new global::Gtk.Image ();
			this.image61.Name = "image61";
			this.image61.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("video.png");
			this.hbox1.Add (this.image61);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.image61]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.liveradiobutton = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Live project using a capture device"));
			this.liveradiobutton.CanFocus = true;
			this.liveradiobutton.Name = "liveradiobutton";
			this.liveradiobutton.DrawIndicator = true;
			this.liveradiobutton.UseUnderline = true;
			this.liveradiobutton.Group = this.fromfileradiobutton.Group;
			this.hbox2.Add (this.liveradiobutton);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.liveradiobutton]));
			w5.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.image63 = new global::Gtk.Image ();
			this.image63.Name = "image63";
			this.image63.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("camera-video.png");
			this.hbox2.Add (this.image63);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.image63]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.vbox2.Add (this.hbox2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.fakeliveradiobutton = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Live project using a fake capture device"));
			this.fakeliveradiobutton.CanFocus = true;
			this.fakeliveradiobutton.Name = "fakeliveradiobutton";
			this.fakeliveradiobutton.DrawIndicator = true;
			this.fakeliveradiobutton.UseUnderline = true;
			this.fakeliveradiobutton.Group = this.fromfileradiobutton.Group;
			this.hbox3.Add (this.fakeliveradiobutton);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.fakeliveradiobutton]));
			w8.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.image62 = new global::Gtk.Image ();
			this.image62.Name = "image62";
			this.image62.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("camera-video.png");
			this.hbox3.Add (this.image62);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.image62]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			this.vbox2.Add (this.hbox3);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox3]));
			w10.Position = 2;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.ipcamerabox = new global::Gtk.HBox ();
			this.ipcamerabox.Name = "ipcamerabox";
			this.ipcamerabox.Spacing = 6;
			// Container child ipcamerabox.Gtk.Box+BoxChild
			this.uriliveradiobutton = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Live project using an IP camera"));
			this.uriliveradiobutton.CanFocus = true;
			this.uriliveradiobutton.Name = "uriliveradiobutton";
			this.uriliveradiobutton.DrawIndicator = true;
			this.uriliveradiobutton.UseUnderline = true;
			this.uriliveradiobutton.Group = this.fromfileradiobutton.Group;
			this.ipcamerabox.Add (this.uriliveradiobutton);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.ipcamerabox [this.uriliveradiobutton]));
			w11.Position = 0;
			// Container child ipcamerabox.Gtk.Box+BoxChild
			this.image64 = new global::Gtk.Image ();
			this.image64.Name = "image64";
			this.image64.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("camera-video.png");
			this.ipcamerabox.Add (this.image64);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.ipcamerabox [this.image64]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			this.vbox2.Add (this.ipcamerabox);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.ipcamerabox]));
			w13.Position = 3;
			w13.Expand = false;
			w13.Fill = false;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Internal child LongoMatch.Gui.Dialog.ProjectSelectionDialog.ActionArea
			global::Gtk.HButtonBox w15 = this.ActionArea;
			w15.Name = "dialog1_ActionArea";
			w15.Spacing = 6;
			w15.BorderWidth = ((uint)(5));
			w15.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w16 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w15 [this.buttonCancel]));
			w16.Expand = false;
			w16.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w17 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w15 [this.buttonOk]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 348;
			this.DefaultHeight = 220;
			this.Show ();
		}
	}
}
