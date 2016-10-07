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
	[Register("JWAdBreak", true)]
	public unsafe partial class JWAdBreak : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("JWAdBreak");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public JWAdBreak () : base (NSObjectFlag.Empty)
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
		protected JWAdBreak (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal JWAdBreak (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithTags:offset:")]
		[CompilerGenerated]
		public JWAdBreak (NSObject[] tags, string offset)
			: base (NSObjectFlag.Empty)
		{
			if (tags == null)
				throw new ArgumentNullException ("tags");
			if (offset == null)
				throw new ArgumentNullException ("offset");
			var nsa_tags = NSArray.FromNSObjects (tags);
			var nsoffset = NSString.CreateNative (offset);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithTags:offset:"), nsa_tags.Handle, nsoffset), "initWithTags:offset:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithTags:offset:"), nsa_tags.Handle, nsoffset), "initWithTags:offset:");
			}
			nsa_tags.Dispose ();
			NSString.ReleaseNative (nsoffset);
			
		}
		
		[Export ("adBreakWithTag:offset:nonLinear:")]
		[CompilerGenerated]
		public static JWAdBreak AdBreakWithTag (string tag, string offset, bool nonLinear)
		{
			if (tag == null)
				throw new ArgumentNullException ("tag");
			if (offset == null)
				throw new ArgumentNullException ("offset");
			var nstag = NSString.CreateNative (tag);
			var nsoffset = NSString.CreateNative (offset);
			
			JWAdBreak ret;
			ret =  Runtime.GetNSObject<JWAdBreak> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool (class_ptr, Selector.GetHandle ("adBreakWithTag:offset:nonLinear:"), nstag, nsoffset, nonLinear));
			NSString.ReleaseNative (nstag);
			NSString.ReleaseNative (nsoffset);
			
			return ret;
		}
		
		[Export ("adBreakWithTag:offset:")]
		[CompilerGenerated]
		public static JWAdBreak AdBreakWithTag (string tag, string offset)
		{
			if (tag == null)
				throw new ArgumentNullException ("tag");
			if (offset == null)
				throw new ArgumentNullException ("offset");
			var nstag = NSString.CreateNative (tag);
			var nsoffset = NSString.CreateNative (offset);
			
			JWAdBreak ret;
			ret =  Runtime.GetNSObject<JWAdBreak> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("adBreakWithTag:offset:"), nstag, nsoffset));
			NSString.ReleaseNative (nstag);
			NSString.ReleaseNative (nsoffset);
			
			return ret;
		}
		
		[Export ("adBreakWithTags:offset:nonLinear:")]
		[CompilerGenerated]
		public static JWAdBreak AdBreakWithTags (NSObject[] tags, string offset, bool nonLinear)
		{
			if (tags == null)
				throw new ArgumentNullException ("tags");
			if (offset == null)
				throw new ArgumentNullException ("offset");
			var nsa_tags = NSArray.FromNSObjects (tags);
			var nsoffset = NSString.CreateNative (offset);
			
			JWAdBreak ret;
			ret =  Runtime.GetNSObject<JWAdBreak> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool (class_ptr, Selector.GetHandle ("adBreakWithTags:offset:nonLinear:"), nsa_tags.Handle, nsoffset, nonLinear));
			nsa_tags.Dispose ();
			NSString.ReleaseNative (nsoffset);
			
			return ret;
		}
		
		[Export ("adBreakWithTags:offset:")]
		[CompilerGenerated]
		public static JWAdBreak AdBreakWithTags (NSObject[] tags, string offset)
		{
			if (tags == null)
				throw new ArgumentNullException ("tags");
			if (offset == null)
				throw new ArgumentNullException ("offset");
			var nsa_tags = NSArray.FromNSObjects (tags);
			var nsoffset = NSString.CreateNative (offset);
			
			JWAdBreak ret;
			ret =  Runtime.GetNSObject<JWAdBreak> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("adBreakWithTags:offset:"), nsa_tags.Handle, nsoffset));
			nsa_tags.Dispose ();
			NSString.ReleaseNative (nsoffset);
			
			return ret;
		}
		
		[CompilerGenerated]
		public virtual bool NonLinear {
			[Export ("nonLinear")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("nonLinear"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("nonLinear"));
				}
			}
			
			[Export ("setNonLinear:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setNonLinear:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setNonLinear:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string Offset {
			[Export ("offset", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("offset")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("offset")));
				}
			}
			
			[Export ("setOffset:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setOffset:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setOffset:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string Tag {
			[Export ("tag", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("tag")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("tag")));
				}
			}
			
			[Export ("setTag:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTag:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTag:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual NSObject[] Tags {
			[Export ("tags", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("tags")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("tags")));
				}
				return ret;
			}
			
			[Export ("setTags:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTags:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTags:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
			}
		}
		
	} /* class JWAdBreak */
}
