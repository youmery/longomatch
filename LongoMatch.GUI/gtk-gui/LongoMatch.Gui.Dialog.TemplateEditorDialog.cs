
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Dialog
{
	public partial class TemplateEditorDialog
	{
		private global::Gtk.HBox templateeditorbox;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Dialog.TemplateEditorDialog
			this.Name = "LongoMatch.Gui.Dialog.TemplateEditorDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Categories Template");
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "longomatch", global::Gtk.IconSize.Dialog);
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.Gravity = ((global::Gdk.Gravity)(5));
			this.SkipPagerHint = true;
			this.SkipTaskbarHint = true;
			// Internal child LongoMatch.Gui.Dialog.TemplateEditorDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.templateeditorbox = new global::Gtk.HBox ();
			this.templateeditorbox.Name = "templateeditorbox";
			this.templateeditorbox.Spacing = 6;
			w1.Add (this.templateeditorbox);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(w1 [this.templateeditorbox]));
			w2.Position = 0;
			// Internal child LongoMatch.Gui.Dialog.TemplateEditorDialog.ActionArea
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
			this.buttonOk.Label = "gtk-apply";
			this.AddActionWidget (this.buttonOk, -10);
			global::Gtk.ButtonBox.ButtonBoxChild w4 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w3 [this.buttonOk]));
			w4.Expand = false;
			w4.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 713;
			this.DefaultHeight = 373;
			this.Show ();
		}
	}
}
