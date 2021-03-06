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
// Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301, USA.
//
//

namespace LongoMatch.Video.Converter {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using Mono.Unix;
	
	using LongoMatch.Interfaces;
	using LongoMatch.Common;
	using LongoMatch.Interfaces.Multimedia;
	using LongoMatch.Video.Common;
	

	#region Autogenerated code
	public  class GstVideoConverter: GLib.Object, IVideoConverter {
	
		public event LongoMatch.Handlers.ProgressHandler Progress;
		public event LongoMatch.Handlers.ErrorHandler Error;

		[DllImport("libcesarplayer.dll")]
		static extern unsafe IntPtr gst_video_encoder_new(IntPtr filename, out IntPtr err);
		
		[Obsolete]
		protected GstVideoConverter(GLib.GType gtype) : base(gtype) {}
		public GstVideoConverter(IntPtr raw) : base(raw) {}

		public unsafe GstVideoConverter(string filename) : base(IntPtr.Zero)
		{
			if(GetType() != typeof(GstVideoConverter)) {
				throw new InvalidOperationException("Can't override this constructor.");
			}
			IntPtr error = IntPtr.Zero;
			Raw = gst_video_encoder_new (GLib.Marshaller.StringToPtrGStrdup(filename), out error);
			if(error != IntPtr.Zero) throw new GLib.GException(error);
			
			PercentCompleted += delegate(object o, PercentCompletedArgs args) {
				if(Progress!= null)
					Progress(args.Percent);
			};
			InternalError += delegate(object o, ErrorArgs args) {
				if (Error != null)
					Error (o, args.Message);
			};
		}

#pragma warning disable 0169
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		delegate void ErrorSignalDelegate(IntPtr arg0, IntPtr arg1, IntPtr gch);

		static void ErrorSignalCallback(IntPtr arg0, IntPtr arg1, IntPtr gch)
		{
			ErrorArgs args = new ErrorArgs();
			try {
				GLib.Signal sig = ((GCHandle) gch).Target as GLib.Signal;
				if(sig == null)
					throw new Exception("Unknown signal GC handle received " + gch);

				args.Args = new object[1];
				args.Args[0] = GLib.Marshaller.Utf8PtrToString(arg1);
				ErrorHandler handler = (ErrorHandler) sig.Handler;
				handler(GLib.Object.GetObject(arg0), args);
			} catch(Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException(e, false);
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		delegate void ErrorVMDelegate(IntPtr gcc, IntPtr message);

		static ErrorVMDelegate ErrorVMCallback;

		static void error_cb(IntPtr gcc, IntPtr message)
		{
			try {
				GstVideoConverter gcc_managed = GLib.Object.GetObject(gcc, false) as GstVideoConverter;
				gcc_managed.OnError(GLib.Marshaller.Utf8PtrToString(message));
			} catch(Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException(e, false);
			}
		}

		private static void OverrideError(GLib.GType gtype)
		{
			if(ErrorVMCallback == null)
				ErrorVMCallback = new ErrorVMDelegate(error_cb);
			OverrideVirtualMethod(gtype, "error", ErrorVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(LongoMatch.Video.Converter.GstVideoConverter), ConnectionMethod="OverrideError")]
		protected virtual void OnError(string message)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray(2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value(this);
			inst_and_params.Append(vals [0]);
			vals [1] = new GLib.Value(message);
			inst_and_params.Append(vals [1]);
			g_signal_chain_from_overridden(inst_and_params.ArrayPtr, ref ret);
			foreach(GLib.Value v in vals)
				v.Dispose();
		}

		[GLib.Signal("error")]
		public event ErrorHandler InternalError {
			add {
				GLib.Signal sig = GLib.Signal.Lookup(this, "error", new ErrorSignalDelegate(ErrorSignalCallback));
				sig.AddDelegate(value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup(this, "error", new ErrorSignalDelegate(ErrorSignalCallback));
				sig.RemoveDelegate(value);
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		delegate void PercentCompletedVMDelegate(IntPtr gvc, float percent);

		static PercentCompletedVMDelegate PercentCompletedVMCallback;

		static void percentcompleted_cb(IntPtr gvc, float percent)
		{
			try {
				GstVideoConverter gvc_managed = GLib.Object.GetObject(gvc, false) as GstVideoConverter;
				gvc_managed.OnPercentCompleted(percent);
			} catch(Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException(e, false);
			}
		}

		private static void OverridePercentCompleted(GLib.GType gtype)
		{
			if(PercentCompletedVMCallback == null)
				PercentCompletedVMCallback = new PercentCompletedVMDelegate(percentcompleted_cb);
			OverrideVirtualMethod(gtype, "percent_completed", PercentCompletedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(LongoMatch.Video.Converter.GstVideoConverter), ConnectionMethod="OverridePercentCompleted")]
		protected virtual void OnPercentCompleted(float percent)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray(2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value(this);
			inst_and_params.Append(vals [0]);
			vals [1] = new GLib.Value(percent);
			inst_and_params.Append(vals [1]);
			g_signal_chain_from_overridden(inst_and_params.ArrayPtr, ref ret);
			foreach(GLib.Value v in vals)
				v.Dispose();
		}

		[GLib.Signal("percent_completed")]
		public event PercentCompletedHandler PercentCompleted {
			add {
				GLib.Signal sig = GLib.Signal.Lookup(this, "percent_completed", typeof(PercentCompletedArgs));
				sig.AddDelegate(value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup(this, "percent_completed", typeof(PercentCompletedArgs));
				sig.RemoveDelegate(value);
			}
		}
#pragma warning restore 0169

		[DllImport("libcesarplayer.dll")]
		static extern void gst_video_encoder_init_backend(out int argc, IntPtr argv);

		public static int InitBackend(string argv) {
			int argc;
			gst_video_encoder_init_backend(out argc, GLib.Marshaller.StringToPtrGStrdup(argv));
			return argc;
		}

		[DllImport("libcesarplayer.dll")]
		static extern void gst_video_encoder_cancel(IntPtr raw);

		public void Cancel() {
			gst_video_encoder_cancel(Handle);
		}

		[DllImport("libcesarplayer.dll")]
		static extern void gst_video_encoder_start(IntPtr raw);

		public void Start() {
			gst_video_encoder_start(Handle);
		}

		[DllImport("libcesarplayer.dll")]
		static extern bool gst_video_encoder_set_encoding_format(IntPtr raw,
		                                                         VideoEncoderType video_codec,
		                                                         AudioEncoderType audio_codec,
		                                                         VideoMuxerType muxer,
		                                                         uint video_quality,
		                                                         uint audio_quality,
		                                                         uint width,
		                                                         uint height,
		                                                         uint fps_n,
		                                                         uint fps_d);
		
		public EncodingSettings EncodingSettings {
			set {
				gst_video_encoder_set_encoding_format (Handle,
				                                       value.EncodingProfile.VideoEncoder,
				                                       value.EncodingProfile.AudioEncoder,
				                                       value.EncodingProfile.Muxer,
				                                       value.EncodingQuality.VideoQuality,
				                                       value.EncodingQuality.AudioQuality,
				                                       value.VideoStandard.Width,
				                                       value.VideoStandard.Height,
				                                       value.Framerate_n,
				                                       value.Framerate_d);
			}
		}
		
		[DllImport("libcesarplayer.dll")]
		static extern bool gst_video_encoder_add_file (IntPtr raw, IntPtr filename, long duration);
		
		public void AddFile (string filename, long duration) {
			if (!filename.StartsWith(Uri.UriSchemeFile)) {
				filename = "file:///" + filename;
			}
			IntPtr file = GLib.Marshaller.StringToPtrGStrdup(filename);
			gst_video_encoder_add_file (Handle, file, duration);
		}

		[DllImport("libcesarplayer.dll")]
		static extern IntPtr gst_video_encoder_get_type();

		public static new GLib.GType GType {
			get {
				IntPtr raw_ret = gst_video_encoder_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		static GstVideoConverter()
		{
			LongoMatch.GtkSharp.Encoder.ObjectManager.Initialize();
		}
		#endregion
		
	}
}
