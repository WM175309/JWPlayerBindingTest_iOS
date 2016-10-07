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
	[Register("JWSource", true)]
	public unsafe partial class JWSource : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("JWSource");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public JWSource () : base (NSObjectFlag.Empty)
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
		protected JWSource (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal JWSource (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFile:label:isDefault:")]
		[CompilerGenerated]
		public JWSource (string file, string label, bool defaultQuality)
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
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("initWithFile:label:isDefault:"), nsfile, nslabel, defaultQuality), "initWithFile:label:isDefault:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("initWithFile:label:isDefault:"), nsfile, nslabel, defaultQuality), "initWithFile:label:isDefault:");
			}
			NSString.ReleaseNative (nsfile);
			NSString.ReleaseNative (nslabel);
			
		}
		
		[Export ("sourceWithFile:label:")]
		[CompilerGenerated]
		public static JWSource SourceWithFile (string file, string label)
		{
			if (file == null)
				throw new ArgumentNullException ("file");
			if (label == null)
				throw new ArgumentNullException ("label");
			var nsfile = NSString.CreateNative (file);
			var nslabel = NSString.CreateNative (label);
			
			JWSource ret;
			ret =  Runtime.GetNSObject<JWSource> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("sourceWithFile:label:"), nsfile, nslabel));
			NSString.ReleaseNative (nsfile);
			NSString.ReleaseNative (nslabel);
			
			return ret;
		}
		
		[Export ("sourceWithFile:label:isDefault:")]
		[CompilerGenerated]
		public static JWSource SourceWithFile (string file, string label, bool defaultQuality)
		{
			if (file == null)
				throw new ArgumentNullException ("file");
			if (label == null)
				throw new ArgumentNullException ("label");
			var nsfile = NSString.CreateNative (file);
			var nslabel = NSString.CreateNative (label);
			
			JWSource ret;
			ret =  Runtime.GetNSObject<JWSource> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool (class_ptr, Selector.GetHandle ("sourceWithFile:label:isDefault:"), nsfile, nslabel, defaultQuality));
			NSString.ReleaseNative (nsfile);
			NSString.ReleaseNative (nslabel);
			
			return ret;
		}
		
		[CompilerGenerated]
		object __mt_AssetOptions_var;
		[CompilerGenerated]
		public virtual NSDictionary AssetOptions {
			[Export ("assetOptions", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("assetOptions")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("assetOptions")));
				}
				MarkDirty ();
				__mt_AssetOptions_var = ret;
				return ret;
			}
			
			[Export ("setAssetOptions:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAssetOptions:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAssetOptions:"), value.Handle);
				}
				MarkDirty ();
				__mt_AssetOptions_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool DefaultQuality {
			[Export ("defaultQuality")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("defaultQuality"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("defaultQuality"));
				}
			}
			
			[Export ("setDefaultQuality:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDefaultQuality:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDefaultQuality:"), value);
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
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AssetOptions_var = null;
			}
		}
	} /* class JWSource */
}
