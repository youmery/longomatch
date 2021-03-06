// Main.cs
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
//Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301, USA.
//
//


using System;
using System.IO;
using System.Reflection;
using Gtk;
using Mono.Unix;

using LongoMatch.Addins;
using LongoMatch.Interfaces.GUI;
using LongoMatch.Interfaces.Multimedia;
using LongoMatch.Gui;
using LongoMatch.Services;
using LongoMatch.Common;
using LongoMatch.Video;
using LongoMatch.Multimedia;
using LongoMatch.Multimedia.Utils;
using LongoMatch.Gui.Helpers;

namespace LongoMatch

{

	class MainClass
	{
		
		public static void Main(string[] args)
		{
			/* Init Gtk */
			Application.Init();
			
			Core.Init();

			/* Init GStreamer */
			GStreamer.Init();
			if (!GStreamer.CheckInstallation())
				return;

			GLib.ExceptionManager.UnhandledException += new GLib.UnhandledExceptionHandler(OnException);
			Version version = Assembly.GetExecutingAssembly().GetName().Version;

			try {
				AddinsManager manager = new AddinsManager(Config.PluginsConfigDir, Config.PluginsDir);
				manager.LoadConfigModifierAddins();
			    GUIToolkit guiToolkit = new GUIToolkit(version);
			    IMultimediaToolkit multimediaToolkit = new MultimediaFactory();
			    manager.LoadExportProjectAddins(guiToolkit.MainWindow);
			    manager.LoadImportProjectAddins(guiToolkit.MainWindow);
			    try {
					Core.Start(guiToolkit, multimediaToolkit);
			    } catch (DBLockedException locked) {
					string msg = Catalog.GetString ("The database seems to be locked by another instance and " +
					                                "the application will closed.");
					Log.Exception (locked);
					return;
			    }
				Application.Run();
			} catch(Exception ex) {
				ProcessExecutionError(ex);
			}
		}

		private static void OnException(GLib.UnhandledExceptionArgs args) {
			ProcessExecutionError((Exception)args.ExceptionObject);
		}

		private static void ProcessExecutionError(Exception ex) {
			string logFile = Constants.SOFTWARE_NAME + "-" + DateTime.Now +".log";
			string message;

			logFile = logFile.Replace("/","-");
			logFile = logFile.Replace(" ","-");
			logFile = logFile.Replace(":","-");
			logFile = System.IO.Path.Combine(Config.HomeDir,logFile);

			message = SysInfo.PrintInfo(Assembly.GetExecutingAssembly().GetName().Version);
			if(ex.InnerException != null)
				message += String.Format("{0}\n{1}\n{2}\n{3}\n{4}",ex.Message,ex.InnerException.Message,ex.Source,ex.StackTrace,ex.InnerException.StackTrace);
			else
				message += String.Format("{0}\n{1}\n{2}",ex.Message,ex.Source,ex.StackTrace);

			using(StreamWriter s = new StreamWriter(logFile)) {
				s.WriteLine(message);
				s.WriteLine("\n\n\nStackTrace:");
				s.WriteLine(System.Environment.StackTrace);
			}
			Log.Exception(ex);
			//TODO Add bug reports link
			MessagesHelpers.ErrorMessage (null,
			                              Catalog.GetString("The application has finished with an unexpected error.")+"\n"+
			                              Catalog.GetString("A log has been saved at: ")+logFile+ "\n"+
			                              Catalog.GetString("Please, fill a bug report "));

			Application.Quit();
		}
	}
}
