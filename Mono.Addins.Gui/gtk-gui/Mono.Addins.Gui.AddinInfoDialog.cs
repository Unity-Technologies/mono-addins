
// This file has been generated by the GUI designer. Do not modify.
namespace Mono.Addins.Gui
{
	internal partial class AddinInfoDialog
	{
		private global::Gtk.HBox hbox81;

		private global::Gtk.VBox vbox94;

		private global::Gtk.Image packageImage;

		private global::Gtk.ScrolledWindow scrolledwindow22;

		private global::Gtk.Label infoLabel;

		private global::Gtk.Button closebutton3;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Mono.Addins.Gui.AddinInfoDialog
			this.Name = "Mono.Addins.Gui.AddinInfoDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Package");
			this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
			this.BorderWidth = ((uint)(6));
			this.DefaultWidth = 550;
			this.DefaultHeight = 400;
			// Internal child Mono.Addins.Gui.AddinInfoDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog-vbox12";
			w1.Spacing = 6;
			// Container child dialog-vbox12.Gtk.Box+BoxChild
			this.hbox81 = new global::Gtk.HBox ();
			this.hbox81.Name = "hbox81";
			this.hbox81.Spacing = 12;
			this.hbox81.BorderWidth = ((uint)(6));
			// Container child hbox81.Gtk.Box+BoxChild
			this.vbox94 = new global::Gtk.VBox ();
			this.vbox94.Name = "vbox94";
			// Container child vbox94.Gtk.Box+BoxChild
			this.packageImage = new global::Gtk.Image ();
			this.packageImage.Name = "packageImage";
			this.vbox94.Add (this.packageImage);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox94[this.packageImage]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			this.hbox81.Add (this.vbox94);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox81[this.vbox94]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox81.Gtk.Box+BoxChild
			this.scrolledwindow22 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow22.CanFocus = true;
			this.scrolledwindow22.Name = "scrolledwindow22";
			// Container child scrolledwindow22.Gtk.Container+ContainerChild
			global::Gtk.Viewport w4 = new global::Gtk.Viewport ();
			w4.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child viewport4.Gtk.Container+ContainerChild
			this.infoLabel = new global::Gtk.Label ();
			this.infoLabel.WidthRequest = 420;
			this.infoLabel.Name = "infoLabel";
			this.infoLabel.Xpad = 6;
			this.infoLabel.Ypad = 6;
			this.infoLabel.Xalign = 0f;
			this.infoLabel.Yalign = 0f;
			this.infoLabel.LabelProp = "aa a a a a a a a a aa a a a a aaa a a a a a a a a aa a a a a aaa a a a a a a a a aa a a a a a";
			this.infoLabel.Wrap = true;
			w4.Add (this.infoLabel);
			this.scrolledwindow22.Add (w4);
			this.hbox81.Add (this.scrolledwindow22);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox81[this.scrolledwindow22]));
			w7.Position = 1;
			w1.Add (this.hbox81);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(w1[this.hbox81]));
			w8.Position = 0;
			// Internal child Mono.Addins.Gui.AddinInfoDialog.ActionArea
			global::Gtk.HButtonBox w9 = this.ActionArea;
			w9.Name = "dialog-action_area12";
			w9.Spacing = 10;
			w9.BorderWidth = ((uint)(6));
			w9.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog-action_area12.Gtk.ButtonBox+ButtonBoxChild
			this.closebutton3 = new global::Gtk.Button ();
			this.closebutton3.CanDefault = true;
			this.closebutton3.CanFocus = true;
			this.closebutton3.Name = "closebutton3";
			this.closebutton3.UseStock = true;
			this.closebutton3.UseUnderline = true;
			this.closebutton3.Label = "gtk-close";
			this.AddActionWidget (this.closebutton3, -7);
			global::Gtk.ButtonBox.ButtonBoxChild w10 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w9[this.closebutton3]));
			w10.Expand = false;
			w10.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
		}
	}
}
