
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Dialog
{
	public partial class Win32CalendarDialog
	{
		private global::Gtk.Calendar calendar1;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Dialog.Win32CalendarDialog
			this.Name = "LongoMatch.Gui.Dialog.Win32CalendarDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Calendar");
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "longomatch", global::Gtk.IconSize.Menu);
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Gravity = ((global::Gdk.Gravity)(5));
			this.SkipPagerHint = true;
			this.SkipTaskbarHint = true;
			// Internal child LongoMatch.Gui.Dialog.Win32CalendarDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.calendar1 = new global::Gtk.Calendar ();
			this.calendar1.CanFocus = true;
			this.calendar1.Name = "calendar1";
			this.calendar1.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
			w1.Add (this.calendar1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(w1 [this.calendar1]));
			w2.Position = 0;
			// Internal child LongoMatch.Gui.Dialog.Win32CalendarDialog.ActionArea
			global::Gtk.HButtonBox w3 = this.ActionArea;
			w3.Name = "dialog1_ActionArea";
			w3.Spacing = 6;
			w3.BorderWidth = ((uint)(5));
			w3.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w4 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w3 [this.buttonOk]));
			w4.Expand = false;
			w4.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 259;
			this.DefaultHeight = 258;
			this.Show ();
			this.calendar1.DaySelectedDoubleClick += new global::System.EventHandler (this.OnCalendar1DaySelectedDoubleClick);
			this.calendar1.DaySelected += new global::System.EventHandler (this.OnCalendar1DaySelected);
		}
	}
}
