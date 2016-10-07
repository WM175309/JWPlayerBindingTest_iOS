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
	[Protocol (Name = "JWDrmDataSource", WrapperType = typeof (JWDrmDataSourceWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FetchContentIdentifierForRequest", Selector = "fetchContentIdentifierForRequest:forEncryption:withCompletion:", ParameterType = new Type [] { typeof (NSUrl), typeof (JWPlayer.JWEncryption), typeof (global::System.Action<NSData>) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FetchAppIdentifierForRequest", Selector = "fetchAppIdentifierForRequest:forEncryption:withCompletion:", ParameterType = new Type [] { typeof (NSUrl), typeof (JWPlayer.JWEncryption), typeof (global::System.Action<NSData>) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FetchContentKeyWithRequest", Selector = "fetchContentKeyWithRequest:forEncryption:withCompletion:", ParameterType = new Type [] { typeof (NSData), typeof (JWPlayer.JWEncryption), typeof (global::System.Action<NSData, NSDate, NSString>) }, ParameterByRef = new bool [] { false, false, false })]
	public interface IJWDrmDataSource : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("fetchContentIdentifierForRequest:forEncryption:withCompletion:")]
		[Preserve (Conditional = true)]
		unsafe void FetchContentIdentifierForRequest (NSUrl loadingRequestURL, JWEncryption encryption, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSData> completion);
		
		[CompilerGenerated]
		[Export ("fetchAppIdentifierForRequest:forEncryption:withCompletion:")]
		[Preserve (Conditional = true)]
		unsafe void FetchAppIdentifierForRequest (NSUrl loadingRequestURL, JWEncryption encryption, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSData> completion);
		
		[CompilerGenerated]
		[Export ("fetchContentKeyWithRequest:forEncryption:withCompletion:")]
		[Preserve (Conditional = true)]
		unsafe void FetchContentKeyWithRequest (NSData requestBytes, JWEncryption encryption, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<NSData, NSDate, NSString> completion);
		
	}
	
	internal sealed class JWDrmDataSourceWrapper : BaseWrapper, IJWDrmDataSource {
		public JWDrmDataSourceWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public JWDrmDataSourceWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("fetchContentIdentifierForRequest:forEncryption:withCompletion:")]
		[CompilerGenerated]
		public unsafe void FetchContentIdentifierForRequest (NSUrl loadingRequestURL, JWEncryption encryption, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSData> completion)
		{
			if (loadingRequestURL == null)
				throw new ArgumentNullException ("loadingRequestURL");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlock (Trampolines.SDActionArity1V0.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32_IntPtr (this.Handle, Selector.GetHandle ("fetchContentIdentifierForRequest:forEncryption:withCompletion:"), loadingRequestURL.Handle, (UInt32)encryption, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("fetchAppIdentifierForRequest:forEncryption:withCompletion:")]
		[CompilerGenerated]
		public unsafe void FetchAppIdentifierForRequest (NSUrl loadingRequestURL, JWEncryption encryption, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSData> completion)
		{
			if (loadingRequestURL == null)
				throw new ArgumentNullException ("loadingRequestURL");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlock (Trampolines.SDActionArity1V0.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32_IntPtr (this.Handle, Selector.GetHandle ("fetchAppIdentifierForRequest:forEncryption:withCompletion:"), loadingRequestURL.Handle, (UInt32)encryption, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("fetchContentKeyWithRequest:forEncryption:withCompletion:")]
		[CompilerGenerated]
		public unsafe void FetchContentKeyWithRequest (NSData requestBytes, JWEncryption encryption, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<NSData, NSDate, NSString> completion)
		{
			if (requestBytes == null)
				throw new ArgumentNullException ("requestBytes");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlock (Trampolines.SDActionArity3V0.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32_IntPtr (this.Handle, Selector.GetHandle ("fetchContentKeyWithRequest:forEncryption:withCompletion:"), requestBytes.Handle, (UInt32)encryption, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
	}
}
namespace JWPlayer {
	[Protocol]
	[Register("JWDrmDataSource", false)]
	[Model]
	public unsafe abstract partial class JWDrmDataSource : NSObject, IJWDrmDataSource {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected JWDrmDataSource () : base (NSObjectFlag.Empty)
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
		protected JWDrmDataSource (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal JWDrmDataSource (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("fetchAppIdentifierForRequest:forEncryption:withCompletion:")]
		[CompilerGenerated]
		public unsafe abstract void FetchAppIdentifierForRequest (NSUrl loadingRequestURL, JWEncryption encryption, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSData> completion);
		[Export ("fetchContentIdentifierForRequest:forEncryption:withCompletion:")]
		[CompilerGenerated]
		public unsafe abstract void FetchContentIdentifierForRequest (NSUrl loadingRequestURL, JWEncryption encryption, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSData> completion);
		[Export ("fetchContentKeyWithRequest:forEncryption:withCompletion:")]
		[CompilerGenerated]
		public unsafe abstract void FetchContentKeyWithRequest (NSData requestBytes, JWEncryption encryption, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<NSData, NSDate, NSString> completion);
	} /* class JWDrmDataSource */
}
