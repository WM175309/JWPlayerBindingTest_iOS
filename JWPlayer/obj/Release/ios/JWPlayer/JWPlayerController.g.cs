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
	[Register("JWPlayerController", true)]
	public unsafe partial class JWPlayerController : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("JWPlayerController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public JWPlayerController () : base (NSObjectFlag.Empty)
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
		protected JWPlayerController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal JWPlayerController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithConfig:")]
		[CompilerGenerated]
		public JWPlayerController (JWConfig config)
			: base (NSObjectFlag.Empty)
		{
			if (config == null)
				throw new ArgumentNullException ("config");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithConfig:"), config.Handle), "initWithConfig:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithConfig:"), config.Handle), "initWithConfig:");
			}
		}
		
		[Export ("initWithConfig:delegate:")]
		[CompilerGenerated]
		public JWPlayerController (JWConfig config, JWPlayerDelegate @delegate)
			: base (NSObjectFlag.Empty)
		{
			if (config == null)
				throw new ArgumentNullException ("config");
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithConfig:delegate:"), config.Handle, @delegate.Handle), "initWithConfig:delegate:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithConfig:delegate:"), config.Handle, @delegate.Handle), "initWithConfig:delegate:");
			}
		}
		
		[Export ("initWithConfig:delegate:drmDataSource:")]
		[CompilerGenerated]
		public JWPlayerController (JWConfig config, JWPlayerDelegate @delegate, JWDrmDataSource drmDataSource)
			: base (NSObjectFlag.Empty)
		{
			if (config == null)
				throw new ArgumentNullException ("config");
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			if (drmDataSource == null)
				throw new ArgumentNullException ("drmDataSource");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithConfig:delegate:drmDataSource:"), config.Handle, @delegate.Handle, drmDataSource.Handle), "initWithConfig:delegate:drmDataSource:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithConfig:delegate:drmDataSource:"), config.Handle, @delegate.Handle, drmDataSource.Handle), "initWithConfig:delegate:drmDataSource:");
			}
		}
		
		[Export ("closeRelatedOverlay")]
		[CompilerGenerated]
		public virtual void CloseRelatedOverlay ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("closeRelatedOverlay"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("closeRelatedOverlay"));
			}
		}
		
		[Export ("enterFullScreen")]
		[CompilerGenerated]
		public virtual void EnterFullScreen ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("enterFullScreen"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("enterFullScreen"));
			}
		}
		
		[Export ("exitFullScreen")]
		[CompilerGenerated]
		public virtual void ExitFullScreen ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("exitFullScreen"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("exitFullScreen"));
			}
		}
		
		[Export ("load:")]
		[CompilerGenerated]
		public virtual void Load (string file)
		{
			if (file == null)
				throw new ArgumentNullException ("file");
			var nsfile = NSString.CreateNative (file);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("load:"), nsfile);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("load:"), nsfile);
			}
			NSString.ReleaseNative (nsfile);
			
		}
		
		[Export ("loadConfig:")]
		[CompilerGenerated]
		public virtual void LoadConfig (JWConfig config)
		{
			if (config == null)
				throw new ArgumentNullException ("config");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("loadConfig:"), config.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("loadConfig:"), config.Handle);
			}
		}
		
		[Export ("loadPlaylist:")]
		[CompilerGenerated]
		public virtual void LoadPlaylist (NSObject[] playlist)
		{
			if (playlist == null)
				throw new ArgumentNullException ("playlist");
			var nsa_playlist = NSArray.FromNSObjects (playlist);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("loadPlaylist:"), nsa_playlist.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("loadPlaylist:"), nsa_playlist.Handle);
			}
			nsa_playlist.Dispose ();
			
		}
		
		[Export ("openRelatedOverlay")]
		[CompilerGenerated]
		public virtual void OpenRelatedOverlay ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("openRelatedOverlay"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("openRelatedOverlay"));
			}
		}
		
		[Export ("pause")]
		[CompilerGenerated]
		public virtual void Pause ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("pause"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pause"));
			}
		}
		
		[Export ("play")]
		[CompilerGenerated]
		public virtual void Play ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("play"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("play"));
			}
		}
		
		[Export ("playAd:")]
		[CompilerGenerated]
		public virtual void PlayAd (string tag)
		{
			if (tag == null)
				throw new ArgumentNullException ("tag");
			var nstag = NSString.CreateNative (tag);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("playAd:"), nstag);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("playAd:"), nstag);
			}
			NSString.ReleaseNative (nstag);
			
		}
		
		[Export ("playAd:onClient:")]
		[CompilerGenerated]
		public virtual void PlayAd (string tag, JWAdClient adClient)
		{
			if (tag == null)
				throw new ArgumentNullException ("tag");
			var nstag = NSString.CreateNative (tag);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32 (this.Handle, Selector.GetHandle ("playAd:onClient:"), nstag, (UInt32)adClient);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_UInt32 (this.SuperHandle, Selector.GetHandle ("playAd:onClient:"), nstag, (UInt32)adClient);
			}
			NSString.ReleaseNative (nstag);
			
		}
		
		[Export ("seek:")]
		[CompilerGenerated]
		public virtual void Seek (global::System.nuint position)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("seek:"), position);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("seek:"), position);
			}
		}
		
		[Export ("stop")]
		[CompilerGenerated]
		public virtual void Stop ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stop"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stop"));
			}
		}
		
		[Export ("togglePictureInPicture")]
		[CompilerGenerated]
		public virtual void TogglePictureInPicture ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("togglePictureInPicture"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("togglePictureInPicture"));
			}
		}
		
		[CompilerGenerated]
		public virtual NSObject[] AudioTracks {
			[Export ("audioTracks", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("audioTracks")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("audioTracks")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nint Buffer {
			[Export ("buffer")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("buffer"));
				} else {
					return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("buffer"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSObject[] CaptionsList {
			[Export ("captionsList", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("captionsList")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("captionsList")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual JWConfig Config {
			[Export ("config", ArgumentSemantic.Retain)]
			get {
				JWConfig ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<JWConfig> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("config")));
				} else {
					ret =  Runtime.GetNSObject<JWConfig> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("config")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool Controls {
			[Export ("controls")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("controls"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("controls"));
				}
			}
			
			[Export ("setControls:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setControls:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setControls:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nint CurrentAudioTrack {
			[Export ("currentAudioTrack")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("currentAudioTrack"));
				} else {
					return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("currentAudioTrack"));
				}
			}
			
			[Export ("setCurrentAudioTrack:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setCurrentAudioTrack:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setCurrentAudioTrack:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nint CurrentCaptions {
			[Export ("currentCaptions")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("currentCaptions"));
				} else {
					return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("currentCaptions"));
				}
			}
			
			[Export ("setCurrentCaptions:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setCurrentCaptions:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setCurrentCaptions:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nint CurrentQualityLevel {
			[Export ("currentQualityLevel")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("currentQualityLevel"));
				} else {
					return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("currentQualityLevel"));
				}
			}
			
			[Export ("setCurrentQualityLevel:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setCurrentQualityLevel:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setCurrentQualityLevel:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public JWPlayerDelegate Delegate {
			get {
				return WeakDelegate as JWPlayerDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool DisplayLockScreenControls {
			[Export ("displayLockScreenControls")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("displayLockScreenControls"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("displayLockScreenControls"));
				}
			}
			
			[Export ("setDisplayLockScreenControls:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDisplayLockScreenControls:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDisplayLockScreenControls:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_DrmDataSource_var;
		[CompilerGenerated]
		public virtual JWDrmDataSource DrmDataSource {
			[Export ("drmDataSource", ArgumentSemantic.Weak)]
			get {
				JWDrmDataSource ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<JWDrmDataSource> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("drmDataSource")));
				} else {
					ret =  Runtime.GetNSObject<JWDrmDataSource> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("drmDataSource")));
				}
				MarkDirty ();
				__mt_DrmDataSource_var = ret;
				return ret;
			}
			
			[Export ("setDrmDataSource:", ArgumentSemantic.Weak)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDrmDataSource:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDrmDataSource:"), value.Handle);
				}
				MarkDirty ();
				__mt_DrmDataSource_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double Duration {
			[Export ("duration")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("duration"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("duration"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ForceFullScreenOnLandscape {
			[Export ("forceFullScreenOnLandscape")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("forceFullScreenOnLandscape"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("forceFullScreenOnLandscape"));
				}
			}
			
			[Export ("setForceFullScreenOnLandscape:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setForceFullScreenOnLandscape:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setForceFullScreenOnLandscape:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ForceLandscapeOnFullScreen {
			[Export ("forceLandscapeOnFullScreen")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("forceLandscapeOnFullScreen"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("forceLandscapeOnFullScreen"));
				}
			}
			
			[Export ("setForceLandscapeOnFullScreen:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setForceLandscapeOnFullScreen:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setForceLandscapeOnFullScreen:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string GoogleChromeCastVersion {
			[Export ("googleChromeCastVersion", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("googleChromeCastVersion")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("googleChromeCastVersion")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string GoogleIMAVersion {
			[Export ("googleIMAVersion", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("googleIMAVersion")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("googleIMAVersion")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsInFullscreen {
			[Export ("isInFullscreen")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isInFullscreen"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isInFullscreen"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSObject[] Levels {
			[Export ("levels", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("levels")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("levels")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSDictionary Metadata {
			[Export ("metadata", ArgumentSemantic.Retain)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("metadata")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("metadata")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual CGSize NaturalSize {
			[Export ("naturalSize")]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("naturalSize"));
						} else {
							global::ApiDefinition.Messaging.CGSize_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("naturalSize"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("naturalSize"));
					} else {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("naturalSize"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("naturalSize"));
						} else {
							global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("naturalSize"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("naturalSize"));
					} else {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("naturalSize"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool OpenSafariOnAdClick {
			[Export ("openSafariOnAdClick")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("openSafariOnAdClick"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("openSafariOnAdClick"));
				}
			}
			
			[Export ("setOpenSafariOnAdClick:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setOpenSafariOnAdClick:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setOpenSafariOnAdClick:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool PictureInPictureDisabled {
			[Export ("pictureInPictureDisabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("pictureInPictureDisabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pictureInPictureDisabled"));
				}
			}
			
			[Export ("setPictureInPictureDisabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPictureInPictureDisabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setPictureInPictureDisabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSNumber PlaybackPosition {
			[Export ("playbackPosition", ArgumentSemantic.Retain)]
			get {
				NSNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("playbackPosition")));
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("playbackPosition")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string PlayerEdition {
			[Export ("playerEdition", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("playerEdition")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("playerEdition")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string PlayerState {
			[Export ("playerState", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("playerState")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("playerState")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string PlayerVersion {
			[Export ("playerVersion", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("playerVersion")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("playerVersion")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nint PlaylistIndex {
			[Export ("playlistIndex")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("playlistIndex"));
				} else {
					return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("playlistIndex"));
				}
			}
			
			[Export ("setPlaylistIndex:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setPlaylistIndex:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setPlaylistIndex:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual CGRect SafeRegion {
			[Export ("safeRegion")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("safeRegion"));
						} else {
							global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("safeRegion"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("safeRegion"));
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("safeRegion"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("safeRegion"));
						} else {
							global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("safeRegion"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("safeRegion"));
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("safeRegion"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static string SDKVersion {
			[Export ("SDKVersion")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("SDKVersion")));
			}
			
		}
		
		[CompilerGenerated]
		public static string SDKVersionToMinor {
			[Export ("SDKVersionToMinor")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("SDKVersionToMinor")));
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIView View {
			[Export ("view", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("view")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("view")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat Volume {
			[Export ("volume")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("volume"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("volume"));
				}
			}
			
			[Export ("setVolume:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setVolume:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setVolume:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_DrmDataSource_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class JWPlayerController */
}
