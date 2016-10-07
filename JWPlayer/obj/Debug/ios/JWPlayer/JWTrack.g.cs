//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace JWPlayer {
	[Register("JWTrack", true)]
	public unsafe partial class JWTrack : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("JWTrack");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public JWTrack () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected JWTrack (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal JWTrack (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFile:label:")]
		[CompilerGenerated]
		public JWTrack (string file, string label)
			: base (NSObjectFlag.Empty)
		{
			if (file == null)
				throw new ArgumentNullException ("file");
			if (label == null)
				throw new ArgumentNullException ("label");
			var nsfile = NSString.CreateNative (file);
			var nslabel = NSString.CreateNative (label);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithFile:label:"), nsfile, nslabel), "initWithFile:label:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithFile:label:"), nsfile, nslabel), "initWithFile:label:");
			}
			NSString.ReleaseNative (nsfile);
			NSString.ReleaseNative (nslabel);
			
		}
		
		[Export ("initWithFile:label:isDefault:")]
		[CompilerGenerated]
		public JWTrack (string file, string label, bool def)
			: base (NSObjectFlag.Empty)
		{
			if (file == null)
				throw new ArgumentNullException ("file");
			if (label == null)
				throw new ArgumentNullException ("label");
			var nsfile = NSString.CreateNative (file);
			var nslabel = NSString.CreateNative (label);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("initWithFile:label:isDefault:"), nsfile, nslabel, def), "initWithFile:label:isDefault:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("initWithFile:label:isDefault:"), nsfile, nslabel, def), "initWithFile:label:isDefault:");
			}
			NSString.ReleaseNative (nsfile);
			NSString.ReleaseNative (nslabel);
			
		}
		
		[Export ("trackWithFile:label:")]
		[CompilerGenerated]
		public static JWTrack TrackWithFile (string file, string label)
		{
			if (file == null)
				throw new ArgumentNullException ("file");
			if (label == null)
				throw new ArgumentNullException ("label");
			var nsfile = NSString.CreateNative (file);
			var nslabel = NSString.CreateNative (label);
			
			JWTrack ret;
			ret =  Runtime.GetNSObject<JWTrack> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("trackWithFile:label:"), nsfile, nslabel));
			NSString.ReleaseNative (nsfile);
			NSString.ReleaseNative (nslabel);
			
			return ret;
		}
		
		[Export ("trackWithFile:label:isDefault:")]
		[CompilerGenerated]
		public static JWTrack TrackWithFile (string file, string label, bool def)
		{
			if (file == null)
				throw new ArgumentNullException ("file");
			if (label == null)
				throw new ArgumentNullException ("label");
			var nsfile = NSString.CreateNative (file);
			var nslabel = NSString.CreateNative (label);
			
			JWTrack ret;
			ret =  Runtime.GetNSObject<JWTrack> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool (class_ptr, Selector.GetHandle ("trackWithFile:label:isDefault:"), nsfile, nslabel, def));
			NSString.ReleaseNative (nsfile);
			NSString.ReleaseNative (nslabel);
			
			return ret;
		}
		
		[CompilerGenerated]
		public virtual bool DefaultValue {
			[Export ("defaultValue")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("defaultValue"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("defaultValue"));
				}
			}
			
			[Export ("setDefaultValue:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDefaultValue:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDefaultValue:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string File {
			[Export ("file", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("file")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("file")));
				}
			}
			
			[Export ("setFile:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFile:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFile:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string Kind {
			[Export ("kind", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("kind")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("kind")));
				}
			}
			
			[Export ("setKind:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setKind:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setKind:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string Label {
			[Export ("label", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("label")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("label")));
				}
			}
			
			[Export ("setLabel:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLabel:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLabel:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
	} /* class JWTrack */
}
