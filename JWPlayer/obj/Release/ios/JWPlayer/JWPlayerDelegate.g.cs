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
	[Protocol (Name = "JWPlayerDelegate", WrapperType = typeof (JWPlayerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnAll", Selector = "onAll")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnPlayAttempt", Selector = "onPlayAttempt")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnBeforePlay", Selector = "onBeforePlay")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnFirstFrame", Selector = "onFirstFrame:", ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnPlay", Selector = "onPlay")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnPlay", Selector = "onPlay:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnPause", Selector = "onPause")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnPause", Selector = "onPause:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnIdle", Selector = "onIdle")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnIdle", Selector = "onIdle:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnReady", Selector = "onReady")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnReady", Selector = "onReady:", ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnBeforeComplete", Selector = "onBeforeComplete")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnComplete", Selector = "onComplete")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnBuffer", Selector = "onBuffer")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnBuffer", Selector = "onBuffer:reason:", ParameterType = new Type [] { typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnBufferChange", Selector = "onBufferChange:", ParameterType = new Type [] { typeof (double) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnTime", Selector = "onTime:ofDuration:", ParameterType = new Type [] { typeof (double), typeof (double) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnSeek", Selector = "onSeek:fromPosition:", ParameterType = new Type [] { typeof (double), typeof (double) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnSeeked", Selector = "onSeeked")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnMeta", Selector = "onMeta:", ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnCaptionsList", Selector = "onCaptionsList:with:", ParameterType = new Type [] { typeof (NSObject[]), typeof (nint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnCaptionsChanged", Selector = "onCaptionsChanged:", ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnCaptionsChange", Selector = "onCaptionsChange:", ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnLevels", Selector = "onLevels:", ParameterType = new Type [] { typeof (NSObject[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnQualityLevels", Selector = "onQualityLevels:", ParameterType = new Type [] { typeof (NSObject[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnLevelsChanged", Selector = "onLevelsChanged:", ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnQualityChange", Selector = "onQualityChange:", ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnVisualQuality", Selector = "onVisualQuality:reason:label:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnAudioTracks", Selector = "onAudioTracks:", ParameterType = new Type [] { typeof (NSObject[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnAudioTrackChanged", Selector = "onAudioTrackChanged:", ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnPlaylist", Selector = "onPlaylist:", ParameterType = new Type [] { typeof (NSObject[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnPlaylistItem", Selector = "onPlaylistItem:", ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnPlaylistComplete", Selector = "onPlaylistComplete")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnFullscreen", Selector = "onFullscreen:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnPictureInPicture", Selector = "onPictureInPicture:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnControls", Selector = "onControls:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnDisplayClick", Selector = "onDisplayClick")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnAdRequest", Selector = "onAdRequest:forPosition:", ParameterType = new Type [] { typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnAdRequest", Selector = "onAdRequest:forPosition:client:creativeType:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (JWPlayer.JWAdClient), typeof (string) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnAdSkipped", Selector = "onAdSkipped:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnAdSkipped", Selector = "onAdSkipped:client:creativeType:", ParameterType = new Type [] { typeof (string), typeof (JWPlayer.JWAdClient), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnAdComplete", Selector = "onAdComplete:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnAdComplete", Selector = "onAdComplete:client:creativeType:", ParameterType = new Type [] { typeof (string), typeof (JWPlayer.JWAdClient), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnAdClick", Selector = "onAdClick:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnAdClick", Selector = "onAdClick:client:creativeType:", ParameterType = new Type [] { typeof (string), typeof (JWPlayer.JWAdClient), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnAdImpression", Selector = "onAdImpression:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnAdImpression", Selector = "onAdImpression:adPosition:adSystem:adTitle:client:creativeType:vastVersion:wrapper:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (string), typeof (string), typeof (JWPlayer.JWAdClient), typeof (string), typeof (double), typeof (NSObject[]) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnAdPlay", Selector = "onAdPlay:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnAdPlay", Selector = "onAdPlay:creativeType:newState:oldState:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnAdPause", Selector = "onAdPause:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnAdPause", Selector = "onAdPause:creativeType:newState:oldState:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnAdTime", Selector = "onAdTime:ofDuration:tag:index:", ParameterType = new Type [] { typeof (double), typeof (double), typeof (string), typeof (nint) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnAdTime", Selector = "onAdTime:ofDuration:tag:index:client:creativeType:", ParameterType = new Type [] { typeof (double), typeof (double), typeof (string), typeof (nint), typeof (JWPlayer.JWAdClient), typeof (string) }, ParameterByRef = new bool [] { false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnAdError", Selector = "onAdError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnAdStarted", Selector = "onAdStarted:creativeType:", ParameterType = new Type [] { typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnOpenRelatedOverlay", Selector = "onOpenRelatedOverlay:relatedFile:items:", ParameterType = new Type [] { typeof (JWPlayer.JWRelatedOpenMethod), typeof (string), typeof (JWPlayer.JWPlaylistItem[]) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnCloseRelatedOverlay", Selector = "onCloseRelatedOverlay:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnRelatedPlay", Selector = "onRelatedPlay:auto:position:", ParameterType = new Type [] { typeof (JWPlayer.JWPlaylistItem), typeof (bool), typeof (nint) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnError", Selector = "onError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnSetupError", Selector = "onSetupError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	public interface IJWPlayerDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class JWPlayerDelegate_Extensions {
		[CompilerGenerated]
		public static void OnAll (this IJWPlayerDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onAll"));
		}
		
		[CompilerGenerated]
		public static void OnPlayAttempt (this IJWPlayerDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onPlayAttempt"));
		}
		
		[CompilerGenerated]
		public static void OnBeforePlay (this IJWPlayerDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onBeforePlay"));
		}
		
		[CompilerGenerated]
		public static void OnFirstFrame (this IJWPlayerDelegate This, global::System.nint loadTime)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nint (This.Handle, Selector.GetHandle ("onFirstFrame:"), loadTime);
		}
		
		[CompilerGenerated]
		public static void OnPlay (this IJWPlayerDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onPlay"));
		}
		
		[CompilerGenerated]
		public static void OnPlay (this IJWPlayerDelegate This, string oldState)
		{
			if (oldState == null)
				throw new ArgumentNullException ("oldState");
			var nsoldState = NSString.CreateNative (oldState);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onPlay:"), nsoldState);
			NSString.ReleaseNative (nsoldState);
			
		}
		
		[CompilerGenerated]
		public static void OnPause (this IJWPlayerDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onPause"));
		}
		
		[CompilerGenerated]
		public static void OnPause (this IJWPlayerDelegate This, string oldState)
		{
			if (oldState == null)
				throw new ArgumentNullException ("oldState");
			var nsoldState = NSString.CreateNative (oldState);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onPause:"), nsoldState);
			NSString.ReleaseNative (nsoldState);
			
		}
		
		[CompilerGenerated]
		public static void OnIdle (this IJWPlayerDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onIdle"));
		}
		
		[CompilerGenerated]
		public static void OnIdle (this IJWPlayerDelegate This, string oldState)
		{
			if (oldState == null)
				throw new ArgumentNullException ("oldState");
			var nsoldState = NSString.CreateNative (oldState);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onIdle:"), nsoldState);
			NSString.ReleaseNative (nsoldState);
			
		}
		
		[CompilerGenerated]
		public static void OnReady (this IJWPlayerDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onReady"));
		}
		
		[CompilerGenerated]
		public static void OnReady (this IJWPlayerDelegate This, global::System.nint setupTime)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nint (This.Handle, Selector.GetHandle ("onReady:"), setupTime);
		}
		
		[CompilerGenerated]
		public static void OnBeforeComplete (this IJWPlayerDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onBeforeComplete"));
		}
		
		[CompilerGenerated]
		public static void OnComplete (this IJWPlayerDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onComplete"));
		}
		
		[CompilerGenerated]
		public static void OnBuffer (this IJWPlayerDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onBuffer"));
		}
		
		[CompilerGenerated]
		public static void OnBuffer (this IJWPlayerDelegate This, string oldState, string reason)
		{
			if (oldState == null)
				throw new ArgumentNullException ("oldState");
			if (reason == null)
				throw new ArgumentNullException ("reason");
			var nsoldState = NSString.CreateNative (oldState);
			var nsreason = NSString.CreateNative (reason);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("onBuffer:reason:"), nsoldState, nsreason);
			NSString.ReleaseNative (nsoldState);
			NSString.ReleaseNative (nsreason);
			
		}
		
		[CompilerGenerated]
		public static void OnBufferChange (this IJWPlayerDelegate This, global::System.Double buffer)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_Double (This.Handle, Selector.GetHandle ("onBufferChange:"), buffer);
		}
		
		[CompilerGenerated]
		public static void OnTime (this IJWPlayerDelegate This, global::System.Double position, global::System.Double duration)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_Double_Double (This.Handle, Selector.GetHandle ("onTime:ofDuration:"), position, duration);
		}
		
		[CompilerGenerated]
		public static void OnSeek (this IJWPlayerDelegate This, global::System.Double offset, global::System.Double position)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_Double_Double (This.Handle, Selector.GetHandle ("onSeek:fromPosition:"), offset, position);
		}
		
		[CompilerGenerated]
		public static void OnSeeked (this IJWPlayerDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onSeeked"));
		}
		
		[CompilerGenerated]
		public static void OnMeta (this IJWPlayerDelegate This, NSDictionary metaData)
		{
			if (metaData == null)
				throw new ArgumentNullException ("metaData");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onMeta:"), metaData.Handle);
		}
		
		[CompilerGenerated]
		public static void OnCaptionsList (this IJWPlayerDelegate This, NSObject[] tracks, global::System.nint selectedTrack)
		{
			if (tracks == null)
				throw new ArgumentNullException ("tracks");
			var nsa_tracks = NSArray.FromNSObjects (tracks);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nint (This.Handle, Selector.GetHandle ("onCaptionsList:with:"), nsa_tracks.Handle, selectedTrack);
			nsa_tracks.Dispose ();
			
		}
		
		[CompilerGenerated]
		public static void OnCaptionsChanged (this IJWPlayerDelegate This, global::System.nint selectedTrack)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nint (This.Handle, Selector.GetHandle ("onCaptionsChanged:"), selectedTrack);
		}
		
		[CompilerGenerated]
		public static void OnCaptionsChange (this IJWPlayerDelegate This, global::System.nint selectedTrack)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nint (This.Handle, Selector.GetHandle ("onCaptionsChange:"), selectedTrack);
		}
		
		[CompilerGenerated]
		public static void OnLevels (this IJWPlayerDelegate This, NSObject[] levels)
		{
			if (levels == null)
				throw new ArgumentNullException ("levels");
			var nsa_levels = NSArray.FromNSObjects (levels);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onLevels:"), nsa_levels.Handle);
			nsa_levels.Dispose ();
			
		}
		
		[CompilerGenerated]
		public static void OnQualityLevels (this IJWPlayerDelegate This, NSObject[] levels)
		{
			if (levels == null)
				throw new ArgumentNullException ("levels");
			var nsa_levels = NSArray.FromNSObjects (levels);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onQualityLevels:"), nsa_levels.Handle);
			nsa_levels.Dispose ();
			
		}
		
		[CompilerGenerated]
		public static void OnLevelsChanged (this IJWPlayerDelegate This, global::System.nint currentLevel)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nint (This.Handle, Selector.GetHandle ("onLevelsChanged:"), currentLevel);
		}
		
		[CompilerGenerated]
		public static void OnQualityChange (this IJWPlayerDelegate This, global::System.nint currentQuality)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nint (This.Handle, Selector.GetHandle ("onQualityChange:"), currentQuality);
		}
		
		[CompilerGenerated]
		public static void OnVisualQuality (this IJWPlayerDelegate This, string mode, string reason, string label)
		{
			if (mode == null)
				throw new ArgumentNullException ("mode");
			if (reason == null)
				throw new ArgumentNullException ("reason");
			if (label == null)
				throw new ArgumentNullException ("label");
			var nsmode = NSString.CreateNative (mode);
			var nsreason = NSString.CreateNative (reason);
			var nslabel = NSString.CreateNative (label);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("onVisualQuality:reason:label:"), nsmode, nsreason, nslabel);
			NSString.ReleaseNative (nsmode);
			NSString.ReleaseNative (nsreason);
			NSString.ReleaseNative (nslabel);
			
		}
		
		[CompilerGenerated]
		public static void OnAudioTracks (this IJWPlayerDelegate This, NSObject[] audioTracks)
		{
			if (audioTracks == null)
				throw new ArgumentNullException ("audioTracks");
			var nsa_audioTracks = NSArray.FromNSObjects (audioTracks);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onAudioTracks:"), nsa_audioTracks.Handle);
			nsa_audioTracks.Dispose ();
			
		}
		
		[CompilerGenerated]
		public static void OnAudioTrackChanged (this IJWPlayerDelegate This, global::System.nint currentAudioTrack)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nint (This.Handle, Selector.GetHandle ("onAudioTrackChanged:"), currentAudioTrack);
		}
		
		[CompilerGenerated]
		public static void OnPlaylist (this IJWPlayerDelegate This, NSObject[] playlist)
		{
			if (playlist == null)
				throw new ArgumentNullException ("playlist");
			var nsa_playlist = NSArray.FromNSObjects (playlist);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onPlaylist:"), nsa_playlist.Handle);
			nsa_playlist.Dispose ();
			
		}
		
		[CompilerGenerated]
		public static void OnPlaylistItem (this IJWPlayerDelegate This, global::System.nint index)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nint (This.Handle, Selector.GetHandle ("onPlaylistItem:"), index);
		}
		
		[CompilerGenerated]
		public static void OnPlaylistComplete (this IJWPlayerDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onPlaylistComplete"));
		}
		
		[CompilerGenerated]
		public static void OnFullscreen (this IJWPlayerDelegate This, bool status)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("onFullscreen:"), status);
		}
		
		[CompilerGenerated]
		public static void OnPictureInPicture (this IJWPlayerDelegate This, bool status)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("onPictureInPicture:"), status);
		}
		
		[CompilerGenerated]
		public static void OnControls (this IJWPlayerDelegate This, bool status)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("onControls:"), status);
		}
		
		[CompilerGenerated]
		public static void OnDisplayClick (this IJWPlayerDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onDisplayClick"));
		}
		
		[CompilerGenerated]
		public static void OnAdRequest (this IJWPlayerDelegate This, string tag, string adPosition)
		{
			if (tag == null)
				throw new ArgumentNullException ("tag");
			if (adPosition == null)
				throw new ArgumentNullException ("adPosition");
			var nstag = NSString.CreateNative (tag);
			var nsadPosition = NSString.CreateNative (adPosition);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("onAdRequest:forPosition:"), nstag, nsadPosition);
			NSString.ReleaseNative (nstag);
			NSString.ReleaseNative (nsadPosition);
			
		}
		
		[CompilerGenerated]
		public static void OnAdRequest (this IJWPlayerDelegate This, string tag, string adPosition, JWAdClient client, string creativeType)
		{
			if (tag == null)
				throw new ArgumentNullException ("tag");
			if (adPosition == null)
				throw new ArgumentNullException ("adPosition");
			if (creativeType == null)
				throw new ArgumentNullException ("creativeType");
			var nstag = NSString.CreateNative (tag);
			var nsadPosition = NSString.CreateNative (adPosition);
			var nscreativeType = NSString.CreateNative (creativeType);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt32_IntPtr (This.Handle, Selector.GetHandle ("onAdRequest:forPosition:client:creativeType:"), nstag, nsadPosition, (UInt32)client, nscreativeType);
			NSString.ReleaseNative (nstag);
			NSString.ReleaseNative (nsadPosition);
			NSString.ReleaseNative (nscreativeType);
			
		}
		
		[CompilerGenerated]
		public static void OnAdSkipped (this IJWPlayerDelegate This, string tag)
		{
			if (tag == null)
				throw new ArgumentNullException ("tag");
			var nstag = NSString.CreateNative (tag);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onAdSkipped:"), nstag);
			NSString.ReleaseNative (nstag);
			
		}
		
		[CompilerGenerated]
		public static void OnAdSkipped (this IJWPlayerDelegate This, string tag, JWAdClient client, string creativeType)
		{
			if (tag == null)
				throw new ArgumentNullException ("tag");
			if (creativeType == null)
				throw new ArgumentNullException ("creativeType");
			var nstag = NSString.CreateNative (tag);
			var nscreativeType = NSString.CreateNative (creativeType);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32_IntPtr (This.Handle, Selector.GetHandle ("onAdSkipped:client:creativeType:"), nstag, (UInt32)client, nscreativeType);
			NSString.ReleaseNative (nstag);
			NSString.ReleaseNative (nscreativeType);
			
		}
		
		[CompilerGenerated]
		public static void OnAdComplete (this IJWPlayerDelegate This, string tag)
		{
			if (tag == null)
				throw new ArgumentNullException ("tag");
			var nstag = NSString.CreateNative (tag);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onAdComplete:"), nstag);
			NSString.ReleaseNative (nstag);
			
		}
		
		[CompilerGenerated]
		public static void OnAdComplete (this IJWPlayerDelegate This, string tag, JWAdClient client, string creativeType)
		{
			if (tag == null)
				throw new ArgumentNullException ("tag");
			if (creativeType == null)
				throw new ArgumentNullException ("creativeType");
			var nstag = NSString.CreateNative (tag);
			var nscreativeType = NSString.CreateNative (creativeType);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32_IntPtr (This.Handle, Selector.GetHandle ("onAdComplete:client:creativeType:"), nstag, (UInt32)client, nscreativeType);
			NSString.ReleaseNative (nstag);
			NSString.ReleaseNative (nscreativeType);
			
		}
		
		[CompilerGenerated]
		public static void OnAdClick (this IJWPlayerDelegate This, string tag)
		{
			if (tag == null)
				throw new ArgumentNullException ("tag");
			var nstag = NSString.CreateNative (tag);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onAdClick:"), nstag);
			NSString.ReleaseNative (nstag);
			
		}
		
		[CompilerGenerated]
		public static void OnAdClick (this IJWPlayerDelegate This, string tag, JWAdClient client, string creativeType)
		{
			if (tag == null)
				throw new ArgumentNullException ("tag");
			if (creativeType == null)
				throw new ArgumentNullException ("creativeType");
			var nstag = NSString.CreateNative (tag);
			var nscreativeType = NSString.CreateNative (creativeType);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32_IntPtr (This.Handle, Selector.GetHandle ("onAdClick:client:creativeType:"), nstag, (UInt32)client, nscreativeType);
			NSString.ReleaseNative (nstag);
			NSString.ReleaseNative (nscreativeType);
			
		}
		
		[CompilerGenerated]
		public static void OnAdImpression (this IJWPlayerDelegate This, string tag)
		{
			if (tag == null)
				throw new ArgumentNullException ("tag");
			var nstag = NSString.CreateNative (tag);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onAdImpression:"), nstag);
			NSString.ReleaseNative (nstag);
			
		}
		
		[CompilerGenerated]
		public static void OnAdImpression (this IJWPlayerDelegate This, string tag, string position, string adSystem, string adTitle, JWAdClient client, string creativeType, global::System.Double vastVersion, NSObject[] wrapper)
		{
			if (tag == null)
				throw new ArgumentNullException ("tag");
			if (position == null)
				throw new ArgumentNullException ("position");
			if (adSystem == null)
				throw new ArgumentNullException ("adSystem");
			if (adTitle == null)
				throw new ArgumentNullException ("adTitle");
			if (creativeType == null)
				throw new ArgumentNullException ("creativeType");
			if (wrapper == null)
				throw new ArgumentNullException ("wrapper");
			var nstag = NSString.CreateNative (tag);
			var nsposition = NSString.CreateNative (position);
			var nsadSystem = NSString.CreateNative (adSystem);
			var nsadTitle = NSString.CreateNative (adTitle);
			var nscreativeType = NSString.CreateNative (creativeType);
			var nsa_wrapper = NSArray.FromNSObjects (wrapper);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_UInt32_IntPtr_Double_IntPtr (This.Handle, Selector.GetHandle ("onAdImpression:adPosition:adSystem:adTitle:client:creativeType:vastVersion:wrapper:"), nstag, nsposition, nsadSystem, nsadTitle, (UInt32)client, nscreativeType, vastVersion, nsa_wrapper.Handle);
			NSString.ReleaseNative (nstag);
			NSString.ReleaseNative (nsposition);
			NSString.ReleaseNative (nsadSystem);
			NSString.ReleaseNative (nsadTitle);
			NSString.ReleaseNative (nscreativeType);
			nsa_wrapper.Dispose ();
			
		}
		
		[CompilerGenerated]
		public static void OnAdPlay (this IJWPlayerDelegate This, string tag)
		{
			if (tag == null)
				throw new ArgumentNullException ("tag");
			var nstag = NSString.CreateNative (tag);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onAdPlay:"), nstag);
			NSString.ReleaseNative (nstag);
			
		}
		
		[CompilerGenerated]
		public static void OnAdPlay (this IJWPlayerDelegate This, string tag, string creativeType, string newState, string oldState)
		{
			if (tag == null)
				throw new ArgumentNullException ("tag");
			if (creativeType == null)
				throw new ArgumentNullException ("creativeType");
			if (newState == null)
				throw new ArgumentNullException ("newState");
			if (oldState == null)
				throw new ArgumentNullException ("oldState");
			var nstag = NSString.CreateNative (tag);
			var nscreativeType = NSString.CreateNative (creativeType);
			var nsnewState = NSString.CreateNative (newState);
			var nsoldState = NSString.CreateNative (oldState);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("onAdPlay:creativeType:newState:oldState:"), nstag, nscreativeType, nsnewState, nsoldState);
			NSString.ReleaseNative (nstag);
			NSString.ReleaseNative (nscreativeType);
			NSString.ReleaseNative (nsnewState);
			NSString.ReleaseNative (nsoldState);
			
		}
		
		[CompilerGenerated]
		public static void OnAdPause (this IJWPlayerDelegate This, string tag)
		{
			if (tag == null)
				throw new ArgumentNullException ("tag");
			var nstag = NSString.CreateNative (tag);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onAdPause:"), nstag);
			NSString.ReleaseNative (nstag);
			
		}
		
		[CompilerGenerated]
		public static void OnAdPause (this IJWPlayerDelegate This, string tag, string creativeType, string newState, string oldState)
		{
			if (tag == null)
				throw new ArgumentNullException ("tag");
			if (creativeType == null)
				throw new ArgumentNullException ("creativeType");
			if (newState == null)
				throw new ArgumentNullException ("newState");
			if (oldState == null)
				throw new ArgumentNullException ("oldState");
			var nstag = NSString.CreateNative (tag);
			var nscreativeType = NSString.CreateNative (creativeType);
			var nsnewState = NSString.CreateNative (newState);
			var nsoldState = NSString.CreateNative (oldState);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("onAdPause:creativeType:newState:oldState:"), nstag, nscreativeType, nsnewState, nsoldState);
			NSString.ReleaseNative (nstag);
			NSString.ReleaseNative (nscreativeType);
			NSString.ReleaseNative (nsnewState);
			NSString.ReleaseNative (nsoldState);
			
		}
		
		[CompilerGenerated]
		public static void OnAdTime (this IJWPlayerDelegate This, global::System.Double position, global::System.Double duration, string tag, global::System.nint sequence)
		{
			if (tag == null)
				throw new ArgumentNullException ("tag");
			var nstag = NSString.CreateNative (tag);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_Double_Double_IntPtr_nint (This.Handle, Selector.GetHandle ("onAdTime:ofDuration:tag:index:"), position, duration, nstag, sequence);
			NSString.ReleaseNative (nstag);
			
		}
		
		[CompilerGenerated]
		public static void OnAdTime (this IJWPlayerDelegate This, global::System.Double position, global::System.Double duration, string tag, global::System.nint sequence, JWAdClient client, string creativeType)
		{
			if (tag == null)
				throw new ArgumentNullException ("tag");
			if (creativeType == null)
				throw new ArgumentNullException ("creativeType");
			var nstag = NSString.CreateNative (tag);
			var nscreativeType = NSString.CreateNative (creativeType);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_Double_Double_IntPtr_nint_UInt32_IntPtr (This.Handle, Selector.GetHandle ("onAdTime:ofDuration:tag:index:client:creativeType:"), position, duration, nstag, sequence, (UInt32)client, nscreativeType);
			NSString.ReleaseNative (nstag);
			NSString.ReleaseNative (nscreativeType);
			
		}
		
		[CompilerGenerated]
		public static void OnAdError (this IJWPlayerDelegate This, NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onAdError:"), error.Handle);
		}
		
		[CompilerGenerated]
		public static void OnAdStarted (this IJWPlayerDelegate This, string tag, string creativeType)
		{
			if (tag == null)
				throw new ArgumentNullException ("tag");
			if (creativeType == null)
				throw new ArgumentNullException ("creativeType");
			var nstag = NSString.CreateNative (tag);
			var nscreativeType = NSString.CreateNative (creativeType);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("onAdStarted:creativeType:"), nstag, nscreativeType);
			NSString.ReleaseNative (nstag);
			NSString.ReleaseNative (nscreativeType);
			
		}
		
		[CompilerGenerated]
		public static void OnOpenRelatedOverlay (this IJWPlayerDelegate This, JWRelatedOpenMethod method, string relatedFile, JWPlaylistItem[] items)
		{
			if (relatedFile == null)
				throw new ArgumentNullException ("relatedFile");
			if (items == null)
				throw new ArgumentNullException ("items");
			var nsrelatedFile = NSString.CreateNative (relatedFile);
			var nsa_items = NSArray.FromNSObjects (items);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_UInt32_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("onOpenRelatedOverlay:relatedFile:items:"), (UInt32)method, nsrelatedFile, nsa_items.Handle);
			NSString.ReleaseNative (nsrelatedFile);
			nsa_items.Dispose ();
			
		}
		
		[CompilerGenerated]
		public static void OnCloseRelatedOverlay (this IJWPlayerDelegate This, string method)
		{
			if (method == null)
				throw new ArgumentNullException ("method");
			var nsmethod = NSString.CreateNative (method);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onCloseRelatedOverlay:"), nsmethod);
			NSString.ReleaseNative (nsmethod);
			
		}
		
		[CompilerGenerated]
		public static void OnRelatedPlay (this IJWPlayerDelegate This, JWPlaylistItem item, bool autoplay, global::System.nint position)
		{
			if (item == null)
				throw new ArgumentNullException ("item");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool_nint (This.Handle, Selector.GetHandle ("onRelatedPlay:auto:position:"), item.Handle, autoplay, position);
		}
		
		[CompilerGenerated]
		public static void OnError (this IJWPlayerDelegate This, NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onError:"), error.Handle);
		}
		
		[CompilerGenerated]
		public static void OnSetupError (this IJWPlayerDelegate This, NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onSetupError:"), error.Handle);
		}
		
	}
	
	internal sealed class JWPlayerDelegateWrapper : BaseWrapper, IJWPlayerDelegate {
		public JWPlayerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public JWPlayerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace JWPlayer {
	[Protocol]
	[Register("JWPlayerDelegate", false)]
	[Model]
	public unsafe partial class JWPlayerDelegate : NSObject, IJWPlayerDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public JWPlayerDelegate () : base (NSObjectFlag.Empty)
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
		protected JWPlayerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal JWPlayerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("onAdClick:")]
		[CompilerGenerated]
		public virtual void OnAdClick (string tag)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onAdClick:client:creativeType:")]
		[CompilerGenerated]
		public virtual void OnAdClick (string tag, JWAdClient client, string creativeType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onAdComplete:")]
		[CompilerGenerated]
		public virtual void OnAdComplete (string tag)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onAdComplete:client:creativeType:")]
		[CompilerGenerated]
		public virtual void OnAdComplete (string tag, JWAdClient client, string creativeType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onAdError:")]
		[CompilerGenerated]
		public virtual void OnAdError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onAdImpression:")]
		[CompilerGenerated]
		public virtual void OnAdImpression (string tag)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onAdImpression:adPosition:adSystem:adTitle:client:creativeType:vastVersion:wrapper:")]
		[CompilerGenerated]
		public virtual void OnAdImpression (string tag, string position, string adSystem, string adTitle, JWAdClient client, string creativeType, global::System.Double vastVersion, NSObject[] wrapper)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onAdPause:")]
		[CompilerGenerated]
		public virtual void OnAdPause (string tag)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onAdPause:creativeType:newState:oldState:")]
		[CompilerGenerated]
		public virtual void OnAdPause (string tag, string creativeType, string newState, string oldState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onAdPlay:")]
		[CompilerGenerated]
		public virtual void OnAdPlay (string tag)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onAdPlay:creativeType:newState:oldState:")]
		[CompilerGenerated]
		public virtual void OnAdPlay (string tag, string creativeType, string newState, string oldState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onAdRequest:forPosition:")]
		[CompilerGenerated]
		public virtual void OnAdRequest (string tag, string adPosition)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onAdRequest:forPosition:client:creativeType:")]
		[CompilerGenerated]
		public virtual void OnAdRequest (string tag, string adPosition, JWAdClient client, string creativeType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onAdSkipped:")]
		[CompilerGenerated]
		public virtual void OnAdSkipped (string tag)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onAdSkipped:client:creativeType:")]
		[CompilerGenerated]
		public virtual void OnAdSkipped (string tag, JWAdClient client, string creativeType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onAdStarted:creativeType:")]
		[CompilerGenerated]
		public virtual void OnAdStarted (string tag, string creativeType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onAdTime:ofDuration:tag:index:")]
		[CompilerGenerated]
		public virtual void OnAdTime (global::System.Double position, global::System.Double duration, string tag, global::System.nint sequence)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onAdTime:ofDuration:tag:index:client:creativeType:")]
		[CompilerGenerated]
		public virtual void OnAdTime (global::System.Double position, global::System.Double duration, string tag, global::System.nint sequence, JWAdClient client, string creativeType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onAll")]
		[CompilerGenerated]
		public virtual void OnAll ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onAudioTrackChanged:")]
		[CompilerGenerated]
		public virtual void OnAudioTrackChanged (global::System.nint currentAudioTrack)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onAudioTracks:")]
		[CompilerGenerated]
		public virtual void OnAudioTracks (NSObject[] audioTracks)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onBeforeComplete")]
		[CompilerGenerated]
		public virtual void OnBeforeComplete ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onBeforePlay")]
		[CompilerGenerated]
		public virtual void OnBeforePlay ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onBuffer")]
		[CompilerGenerated]
		public virtual void OnBuffer ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onBuffer:reason:")]
		[CompilerGenerated]
		public virtual void OnBuffer (string oldState, string reason)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onBufferChange:")]
		[CompilerGenerated]
		public virtual void OnBufferChange (global::System.Double buffer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onCaptionsChange:")]
		[CompilerGenerated]
		public virtual void OnCaptionsChange (global::System.nint selectedTrack)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onCaptionsChanged:")]
		[CompilerGenerated]
		public virtual void OnCaptionsChanged (global::System.nint selectedTrack)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onCaptionsList:with:")]
		[CompilerGenerated]
		public virtual void OnCaptionsList (NSObject[] tracks, global::System.nint selectedTrack)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onCloseRelatedOverlay:")]
		[CompilerGenerated]
		public virtual void OnCloseRelatedOverlay (string method)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onComplete")]
		[CompilerGenerated]
		public virtual void OnComplete ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onControls:")]
		[CompilerGenerated]
		public virtual void OnControls (bool status)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onDisplayClick")]
		[CompilerGenerated]
		public virtual void OnDisplayClick ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onError:")]
		[CompilerGenerated]
		public virtual void OnError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onFirstFrame:")]
		[CompilerGenerated]
		public virtual void OnFirstFrame (global::System.nint loadTime)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onFullscreen:")]
		[CompilerGenerated]
		public virtual void OnFullscreen (bool status)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onIdle")]
		[CompilerGenerated]
		public virtual void OnIdle ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onIdle:")]
		[CompilerGenerated]
		public virtual void OnIdle (string oldState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onLevels:")]
		[CompilerGenerated]
		public virtual void OnLevels (NSObject[] levels)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onLevelsChanged:")]
		[CompilerGenerated]
		public virtual void OnLevelsChanged (global::System.nint currentLevel)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onMeta:")]
		[CompilerGenerated]
		public virtual void OnMeta (NSDictionary metaData)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onOpenRelatedOverlay:relatedFile:items:")]
		[CompilerGenerated]
		public virtual void OnOpenRelatedOverlay (JWRelatedOpenMethod method, string relatedFile, JWPlaylistItem[] items)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onPause")]
		[CompilerGenerated]
		public virtual void OnPause ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onPause:")]
		[CompilerGenerated]
		public virtual void OnPause (string oldState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onPictureInPicture:")]
		[CompilerGenerated]
		public virtual void OnPictureInPicture (bool status)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onPlay")]
		[CompilerGenerated]
		public virtual void OnPlay ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onPlay:")]
		[CompilerGenerated]
		public virtual void OnPlay (string oldState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onPlayAttempt")]
		[CompilerGenerated]
		public virtual void OnPlayAttempt ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onPlaylist:")]
		[CompilerGenerated]
		public virtual void OnPlaylist (NSObject[] playlist)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onPlaylistComplete")]
		[CompilerGenerated]
		public virtual void OnPlaylistComplete ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onPlaylistItem:")]
		[CompilerGenerated]
		public virtual void OnPlaylistItem (global::System.nint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onQualityChange:")]
		[CompilerGenerated]
		public virtual void OnQualityChange (global::System.nint currentQuality)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onQualityLevels:")]
		[CompilerGenerated]
		public virtual void OnQualityLevels (NSObject[] levels)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onReady")]
		[CompilerGenerated]
		public virtual void OnReady ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onReady:")]
		[CompilerGenerated]
		public virtual void OnReady (global::System.nint setupTime)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onRelatedPlay:auto:position:")]
		[CompilerGenerated]
		public virtual void OnRelatedPlay (JWPlaylistItem item, bool autoplay, global::System.nint position)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onSeek:fromPosition:")]
		[CompilerGenerated]
		public virtual void OnSeek (global::System.Double offset, global::System.Double position)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onSeeked")]
		[CompilerGenerated]
		public virtual void OnSeeked ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onSetupError:")]
		[CompilerGenerated]
		public virtual void OnSetupError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onTime:ofDuration:")]
		[CompilerGenerated]
		public virtual void OnTime (global::System.Double position, global::System.Double duration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onVisualQuality:reason:label:")]
		[CompilerGenerated]
		public virtual void OnVisualQuality (string mode, string reason, string label)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class JWPlayerDelegate */
}
