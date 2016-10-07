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

namespace ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<NSData>))]
		internal delegate void DActionArity1V0 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V0 {
			static internal readonly DActionArity1V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V0))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<NSData>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSData> (obj));
			}
		} /* class SDActionArity1V0 */
		
		internal class NIDActionArity1V0 {
			IntPtr blockPtr;
			DActionArity1V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<NSData> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<NSData>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSData obj)
			{
				invoker (blockPtr, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<NSData, NSDate, NSString>))]
		internal delegate void DActionArity3V0 (IntPtr block, IntPtr arg1, IntPtr arg2, IntPtr arg3);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity3V0 {
			static internal readonly DActionArity3V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity3V0))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, IntPtr arg2, IntPtr arg3) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<NSData, NSDate, NSString>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSData> (arg1),  Runtime.GetNSObject<NSDate> (arg2),  Runtime.GetNSObject<NSString> (arg3));
			}
		} /* class SDActionArity3V0 */
		
		internal class NIDActionArity3V0 {
			IntPtr blockPtr;
			DActionArity3V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity3V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity3V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity3V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<NSData, NSDate, NSString> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<NSData, NSDate, NSString>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity3V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSData arg1, NSDate arg2, NSString arg3)
			{
				invoker (blockPtr, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle, arg3 == null ? IntPtr.Zero : arg3.Handle);
			}
		} /* class NIDActionArity3V0 */
	}
}
