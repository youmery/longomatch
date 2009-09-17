// TreeWidgetPopup.cs
//
//  Copyright (C) 2007-2009 Andoni Morales Alastruey
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
//
//

using System;
using Gdk;
using Gtk;
using Mono.Unix;
using LongoMatch.Handlers;
using LongoMatch.TimeNodes;

namespace LongoMatch.Gui.Component
{
	
	
	[System.ComponentModel.Category("LongoMatch")]
	[System.ComponentModel.ToolboxItem(true)]
	public class PlaysTreeView : Gtk.TreeView
	{
		
		public event TimeNodeChangedHandler TimeNodeChanged;
		public event TimeNodeSelectedHandler TimeNodeSelected;
		public event TimeNodeDeletedHandler TimeNodeDeleted;
		public event PlayListNodeAddedHandler PlayListNodeAdded;
		public event SnapshotSeriesHandler SnapshotSeriesEvent;
		public event PlayersTaggedHandler PlayersTagged;
		
		private TreeIter selectedIter;
		private Menu menu;
		private MenuItem local;
	    private	MenuItem visitor;
		private MenuItem noTeam;
		private MenuItem addPLN;
		private Gtk.CellRendererText nameCell;
		private TreePath path;
		private Gtk.TreeViewColumn nameColumn;
		//Using TimeNode as in the tree there are Media and Sections timenodes
		private TimeNode selectedTimeNode;
		private Color[] colors;
	
		

		
		public PlaysTreeView(){
			
			this.RowActivated += new RowActivatedHandler(OnTreeviewRowActivated);
						
			SetMenu();	
			
			colors = new Color[20];
			
			nameColumn = new Gtk.TreeViewColumn ();
			nameColumn.Title = "Name";
			nameCell = new Gtk.CellRendererText ();
			//nameCell.Editable = true;
			nameCell.Edited += OnNameCellEdited;
			Gtk.CellRendererPixbuf miniatureCell = new Gtk.CellRendererPixbuf ();
			nameColumn.PackStart (miniatureCell, true);
			nameColumn.PackEnd (nameCell, true);
			
			Gtk.TreeViewColumn teamColumn = new Gtk.TreeViewColumn ();
			teamColumn.Title = "Team";
			Gtk.CellRendererText teamCell = new Gtk.CellRendererText ();
			teamColumn.PackStart (teamCell, true);
 
			Gtk.TreeViewColumn startTimeColumn = new Gtk.TreeViewColumn ();
			startTimeColumn.Title = "Start";
			Gtk.CellRendererText startTimeCell = new Gtk.CellRendererText ();
			startTimeColumn.PackStart (startTimeCell, true);
			
			Gtk.TreeViewColumn stopTimeColumn = new Gtk.TreeViewColumn ();
			stopTimeColumn.Title = "Stop";
			Gtk.CellRendererText stopTimeCell = new Gtk.CellRendererText ();
			stopTimeColumn.PackStart (stopTimeCell, true);

			nameColumn.SetCellDataFunc (miniatureCell, new Gtk.TreeCellDataFunc(RenderMiniature));
			nameColumn.SetCellDataFunc (nameCell, new Gtk.TreeCellDataFunc (RenderName));
			teamColumn.SetCellDataFunc(teamCell, new Gtk.TreeCellDataFunc(RenderTeam));
			startTimeColumn.SetCellDataFunc (startTimeCell, new Gtk.TreeCellDataFunc (RenderStartTime));
			stopTimeColumn.SetCellDataFunc (stopTimeCell, new Gtk.TreeCellDataFunc (RenderStopTime));
			
			
			this.AppendColumn (nameColumn);
			this.AppendColumn(teamColumn);
			this.AppendColumn (startTimeColumn);
			this.AppendColumn (stopTimeColumn);
		
		}
		
		public Color[]  Colors{
			set {this.colors = value;}
		}
		
		public bool PlayListLoaded{
			set{addPLN.Sensitive=value;}
		}
		
		private void SetMenu(){
			
			
			Menu teamMenu = new Menu();
			local = new MenuItem(Catalog.GetString("Local Team"));
			visitor = new MenuItem(Catalog.GetString("Visitor Team"));
			noTeam = new MenuItem(Catalog.GetString("No Team"));
			teamMenu .Append(local);
			teamMenu .Append(visitor);
			teamMenu .Append(noTeam);
			
			Menu playersMenu = new Menu();
			MenuItem localPlayers = new MenuItem(Catalog.GetString("Local team"));
			MenuItem visitorPlayers = new MenuItem(Catalog.GetString("Visitor team"));
			playersMenu.Append(localPlayers);
			playersMenu.Append(visitorPlayers);
			
			menu = new Menu();
			
			MenuItem name = new MenuItem(Catalog.GetString("Edit"));
			MenuItem team = new MenuItem(Catalog.GetString("Team Selection"));
			team.Submenu = teamMenu;
			MenuItem players = new MenuItem(Catalog.GetString("Tag player"));
			players.Submenu = playersMenu;
			MenuItem quit = new MenuItem(Catalog.GetString("Delete"));
			addPLN = new MenuItem(Catalog.GetString("Add to playlist"));
			addPLN.Sensitive=false;
			MenuItem snapshot = new MenuItem(Catalog.GetString("Export to PGN images"));
			
			menu.Append(name);
			menu.Append(team);	
			menu.Append(players);
			menu.Append(addPLN);
			menu.Append(quit);
			menu.Append(snapshot);
			 
			name.Activated += new EventHandler(OnEdit);
			local.Activated += new EventHandler(OnTeamSelection);
			visitor.Activated += new EventHandler(OnTeamSelection);
			noTeam.Activated += new EventHandler(OnTeamSelection);
			localPlayers.Activated += new EventHandler(OnLocalPlayers);
			visitorPlayers.Activated += new EventHandler (OnVisitorPlayers);
			addPLN.Activated += new EventHandler(OnAdded);
			quit.Activated += new EventHandler(OnDeleted);
			snapshot.Activated += new EventHandler(OnSnapshot);
			menu.ShowAll();		
		}
		
		private int GetSectionFromIter (TreeIter iter){
			TreePath path = this.Model.GetPath(iter);
			return int.Parse(path.ToString().Split(':')[0]);			
		}
		
	
		private void RenderMiniature (Gtk.TreeViewColumn column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter)
		{
			TimeNode tNode = (TimeNode) model.GetValue (iter, 0);
			if (tNode is MediaTimeNode){
				(cell as Gtk.CellRendererPixbuf).Pixbuf = ((MediaTimeNode)tNode).Miniature;
				(cell as Gtk.CellRendererPixbuf).CellBackgroundGdk = colors[GetSectionFromIter(iter)];
			}
			else {
				(cell as Gtk.CellRendererPixbuf).Pixbuf = null;
				(cell as Gtk.CellRendererPixbuf).CellBackground = "white";
			}
		}
		
		private void RenderTeam (Gtk.TreeViewColumn column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter)
		{
			TimeNode tNode = (TimeNode) model.GetValue (iter, 0);
	 
			(cell as Gtk.CellRendererText).Text = tNode.Name;
			
			if (tNode is MediaTimeNode){
				(cell as Gtk.CellRendererText).Text =((MediaTimeNode)tNode).Team.ToString().ToLowerInvariant();
				(cell as Gtk.CellRendererText).BackgroundGdk = colors[GetSectionFromIter(iter)];
				(cell as Gtk.CellRendererText).CellBackgroundGdk = colors[GetSectionFromIter(iter)];				
			}
			else {
				(cell as Gtk.CellRendererText).Text = "";
				(cell as Gtk.CellRendererText).Background = "white";
				(cell as Gtk.CellRendererText).CellBackground = "white";
			}			
		}
		
		private void RenderName (Gtk.TreeViewColumn column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter)
		{
			TimeNode tNode = (TimeNode) model.GetValue (iter, 0);
	 
			(cell as Gtk.CellRendererText).Text = tNode.Name;
			
			if (tNode is MediaTimeNode){
				(cell as Gtk.CellRendererText).BackgroundGdk = colors[GetSectionFromIter(iter)];
				(cell as Gtk.CellRendererText).CellBackgroundGdk = colors[GetSectionFromIter(iter)];
			}
			else{
				(cell as Gtk.CellRendererText).Background = "white";
				(cell as Gtk.CellRendererText).CellBackground = "white";
			}			
		}
 
		
		private void RenderStartTime (Gtk.TreeViewColumn column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter)
		{
			TimeNode tNode = (TimeNode) model.GetValue (iter, 0);			

			if (tNode is MediaTimeNode){
				(cell as Gtk.CellRendererText).Text =tNode.Start.ToMSecondsString();
				(cell as Gtk.CellRendererText).BackgroundGdk = colors[GetSectionFromIter(iter)];
				(cell as Gtk.CellRendererText).CellBackgroundGdk = colors[GetSectionFromIter(iter)];
				
			}
			else {
				(cell as Gtk.CellRendererText).Text = "";
				(cell as Gtk.CellRendererText).Background = "white";
				(cell as Gtk.CellRendererText).CellBackground = "white";
			}		
		}
		
		private void RenderStopTime (Gtk.TreeViewColumn column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter)
		{
			TimeNode tNode = (TimeNode) model.GetValue (iter, 0);
			if (tNode is MediaTimeNode){
				(cell as Gtk.CellRendererText).Text = tNode.Stop.ToMSecondsString();
				(cell as Gtk.CellRendererText).BackgroundGdk = colors[GetSectionFromIter(iter)];
				(cell as Gtk.CellRendererText).CellBackgroundGdk = colors[GetSectionFromIter(iter)];
			}
			else {
				(cell as Gtk.CellRendererText).Text = "";
				(cell as Gtk.CellRendererText).Background = "white";
				(cell as Gtk.CellRendererText).CellBackground = "white";
			}
		}
		
		private void OnNameCellEdited (object o, Gtk.EditedArgs args)
		{
			Gtk.TreeIter iter;
			this.Model.GetIter (out iter, new Gtk.TreePath (args.Path)); 
			TimeNode tNode = (TimeNode)this.Model.GetValue (iter,0);
			tNode.Name = args.NewText;
			nameCell.Editable=false;
			if (TimeNodeChanged != null)
				TimeNodeChanged(tNode,args.NewText);
		}
		
		protected virtual void OnTreeviewRowActivated(object o, Gtk.RowActivatedArgs args)
		{
			Gtk.TreeIter iter;
			this.Model.GetIter (out iter, args.Path);
			TimeNode tNode = (TimeNode)this.Model.GetValue (iter, 0);
			
			if (tNode is MediaTimeNode && TimeNodeSelected != null)
				this.TimeNodeSelected((MediaTimeNode)tNode);				
		}
		
		protected override bool OnButtonPressEvent (EventButton evnt)
		{
			//Call base class, to allow normal handling,
			//such as allowing the row to be selected by the right-click:
			bool returnValue = base.OnButtonPressEvent(evnt);
			
			//Then do our custom stuff:
			if( (evnt.Type == EventType.ButtonPress) && (evnt.Button == 3) )
			{
				
				this.GetPathAtPos((int)evnt.X,(int)evnt.Y,out path);
				if (path!=null){
					this.Model.GetIter (out selectedIter,path); 
					selectedTimeNode = (TimeNode)this.Model.GetValue (selectedIter, 0);
					if (selectedTimeNode is MediaTimeNode )
					    menu.Popup();
					else{
						nameCell.Editable = true;
						this.SetCursor(path,  nameColumn, true);
					}
				}
			}
			return returnValue;								
		}
		
		protected void OnDeleted(object obj, EventArgs args){
			if (TimeNodeDeleted != null)
				TimeNodeDeleted((MediaTimeNode)selectedTimeNode,int.Parse(path.ToString().Split(':')[0]));
		}
		
		protected virtual void OnEdit(object obj, EventArgs args){
			nameCell.Editable = true;
			this.SetCursor(path,  nameColumn, true);
		}
		
		protected void OnTeamSelection(object obj, EventArgs args){
			MenuItem sender = (MenuItem)obj;
			Team team = Team.NONE;
			if (sender == local)
				team = Team.LOCAL;
			else if (sender == visitor)
				team = Team.VISITOR;
			else if (sender == noTeam)
				team = Team.NONE;
			((MediaTimeNode)selectedTimeNode).Team= team;
			                
		}
		
		protected void OnAdded(object obj, EventArgs args){
			if (PlayListNodeAdded != null)	
				PlayListNodeAdded((MediaTimeNode)selectedTimeNode);
		}
		
		protected void OnSnapshot(object obj, EventArgs args){
			if (SnapshotSeriesEvent != null)
				SnapshotSeriesEvent((MediaTimeNode)selectedTimeNode);			
		}
		
		protected virtual void OnLocalPlayers(object o, EventArgs args){
			if (PlayersTagged != null)
				PlayersTagged ((MediaTimeNode)selectedTimeNode, Team.LOCAL);
		}
		
		protected virtual void OnVisitorPlayers(object o, EventArgs args){
			if (PlayersTagged != null)
				PlayersTagged ((MediaTimeNode)selectedTimeNode, Team.VISITOR);
		}
	}
}