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
	[Protocol (Name = "JWCastingDelegate", WrapperType = typeof (JWCastingDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnCastingDevicesAvailable", Selector = "onCastingDevicesAvailable:", ParameterType = new Type [] { typeof (JWPlayer.JWCastingDevice[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnConnectedToCastingDevice", Selector = "onConnectedToCastingDevice:", ParameterType = new Type [] { typeof (JWPlayer.JWCastingDevice) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnDisconnectedFromCastingDevice", Selector = "onDisconnectedFromCastingDevice:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnConnectionTemporarilySuspended", Selector = "onConnectionTemporarilySuspended")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnConnectionRecovered", Selector = "onConnectionRecovered")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnConnectionFailed", Selector = "onConnectionFailed:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnCasting", Selector = "onCasting")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnCastingFailed", Selector = "onCastingFailed:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnCastingEnded", Selector = "onCastingEnded:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	public interface IJWCastingDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("onCastingDevicesAvailable:")]
		[Preserve (Conditional = true)]
		void OnCastingDevicesAvailable (JWCastingDevice[] devices);
		
	}
	
	public static partial class JWCastingDelegate_Extensions {
		[CompilerGenerated]
		public static void OnConnectedToCastingDevice (this IJWCastingDelegate This, JWCastingDevice device)
		{
			if (device == null)
				throw new ArgumentNullException ("device");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onConnectedToCastingDevice:"), device.Handle);
		}
		
		[CompilerGenerated]
		public static void OnDisconnectedFromCastingDevice (this IJWCastingDelegate This, NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onDisconnectedFromCastingDevice:"), error.Handle);
		}
		
		[CompilerGenerated]
		public static void OnConnectionTemporarilySuspended (this IJWCastingDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onConnectionTemporarilySuspended"));
		}
		
		[CompilerGenerated]
		public static void OnConnectionRecovered (this IJWCastingDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onConnectionRecovered"));
		}
		
		[CompilerGenerated]
		public static void OnConnectionFailed (this IJWCastingDelegate This, NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onConnectionFailed:"), error.Handle);
		}
		
		[CompilerGenerated]
		public static void OnCasting (this IJWCastingDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onCasting"));
		}
		
		[CompilerGenerated]
		public static void OnCastingFailed (this IJWCastingDelegate This, NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onCastingFailed:"), error.Handle);
		}
		
		[CompilerGenerated]
		public static void OnCastingEnded (this IJWCastingDelegate This, NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onCastingEnded:"), error.Handle);
		}
		
	}
	
	internal sealed class JWCastingDelegateWrapper : BaseWrapper, IJWCastingDelegate {
		public JWCastingDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public JWCastingDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("onCastingDevicesAvailable:")]
		[CompilerGenerated]
		public void OnCastingDevicesAvailable (JWCastingDevice[] devices)
		{
			if (devices == null)
				throw new ArgumentNullException ("devices");
			var nsa_devices = NSArray.FromNSObjects (devices);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("onCastingDevicesAvailable:"), nsa_devices.Handle);
			nsa_devices.Dispose ();
			
		}
		
	}
}
namespace JWPlayer {
	[Protocol]
	[Register("JWCastingDelegate", false)]
	[Model]
	public unsafe abstract partial class JWCastingDelegate : NSObject, IJWCastingDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected JWCastingDelegate () : base (NSObjectFlag.Empty)
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
		protected JWCastingDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal JWCastingDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("onCasting")]
		[CompilerGenerated]
		public virtual void OnCasting ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onCastingDevicesAvailable:")]
		[CompilerGenerated]
		public abstract void OnCastingDevicesAvailable (JWCastingDevice[] devices);
		[Export ("onCastingEnded:")]
		[CompilerGenerated]
		public virtual void OnCastingEnded (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onCastingFailed:")]
		[CompilerGenerated]
		public virtual void OnCastingFailed (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onConnectedToCastingDevice:")]
		[CompilerGenerated]
		public virtual void OnConnectedToCastingDevice (JWCastingDevice device)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onConnectionFailed:")]
		[CompilerGenerated]
		public virtual void OnConnectionFailed (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onConnectionRecovered")]
		[CompilerGenerated]
		public virtual void OnConnectionRecovered ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onConnectionTemporarilySuspended")]
		[CompilerGenerated]
		public virtual void OnConnectionTemporarilySuspended ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onDisconnectedFromCastingDevice:")]
		[CompilerGenerated]
		public virtual void OnDisconnectedFromCastingDevice (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class JWCastingDelegate */
}
