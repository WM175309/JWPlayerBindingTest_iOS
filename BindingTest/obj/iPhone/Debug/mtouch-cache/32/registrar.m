#include "registrar.h"
static void native_to_managed_trampoline_1 (id self, SEL _cmd, MonoMethod **managed_method_ptr, const char *r0, const char *r1)
{
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [0];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		managed_method = xamarin_get_reflection_method_method (xamarin_get_method_direct(r0, r1, 0, NULL, &exception_gchandle));
		if (exception_gchandle != 0) goto exception_handling;
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static BOOL native_to_managed_trampoline_2 (id self, SEL _cmd, MonoMethod **managed_method_ptr, void * p0, const char *r0, const char *r1, const char *r2)
{
	void * a0 = p0;
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	BOOL res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		const char *paramptr[1] = { r0 };
		managed_method = xamarin_get_reflection_method_method (xamarin_get_method_direct(r1, r2, 1, paramptr, &exception_gchandle));
		if (exception_gchandle != 0) goto exception_handling;
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	arg_ptrs [0] = &a0;

	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	res = *(BOOL *) mono_object_unbox ((MonoObject *) retval);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static UIWindow * native_to_managed_trampoline_3 (id self, SEL _cmd, MonoMethod **managed_method_ptr, const char *r0, const char *r1)
{
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	UIWindow * res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [0];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		managed_method = xamarin_get_reflection_method_method (xamarin_get_method_direct(r0, r1, 0, NULL, &exception_gchandle));
		if (exception_gchandle != 0) goto exception_handling;
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	if (!retval) {
		res = NULL;
	} else {
		id retobj;
		retobj = xamarin_get_nsobject_handle (retval);
		xamarin_framework_peer_lock ();
		[retobj retain];
		xamarin_framework_peer_unlock ();
		[retobj autorelease];
		mt_dummy_use (retval);
		res = retobj;
	}

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static void native_to_managed_trampoline_4 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIWindow * p0, const char *r0, const char *r1, const char *r2)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		const char *paramptr[1] = { r0 };
		managed_method = xamarin_get_reflection_method_method (xamarin_get_method_direct(r1, r2, 1, paramptr, &exception_gchandle));
		if (exception_gchandle != 0) goto exception_handling;
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static BOOL native_to_managed_trampoline_5 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIApplication * p0, NSDictionary * p1, const char *r0, const char *r1, const char *r2, const char *r3)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	NSObject *nsobj1 = NULL;
	MonoObject *mobj1 = NULL;
	int32_t created1 = false;
	MonoType *paramtype1 = NULL;
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	BOOL res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [2];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		const char *paramptr[2] = { r0, r1 };
		managed_method = xamarin_get_reflection_method_method (xamarin_get_method_direct(r2, r3, 2, paramptr, &exception_gchandle));
		if (exception_gchandle != 0) goto exception_handling;
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj1, _cmd, self, nsobj1, 1, mono_class_from_mono_type (paramtype1), managed_method);
	}
	arg_ptrs [1] = mobj1;

	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	res = *(BOOL *) mono_object_unbox ((MonoObject *) retval);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static void native_to_managed_trampoline_6 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIApplication * p0, const char *r0, const char *r1, const char *r2)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		const char *paramptr[1] = { r0 };
		managed_method = xamarin_get_reflection_method_method (xamarin_get_method_direct(r1, r2, 1, paramptr, &exception_gchandle));
		if (exception_gchandle != 0) goto exception_handling;
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static id native_to_managed_trampoline_7 (id self, SEL _cmd, MonoMethod **managed_method_ptr, const char *r0, const char *r1, bool* call_super)
{
	uint8_t flags = NSObjectFlagsNativeRef;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [0];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	bool has_nsobject = xamarin_has_nsobject (self, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	if (has_nsobject) {
		*call_super = true;
		goto exception_handling;
	}
	if (!managed_method) {
		managed_method = xamarin_get_reflection_method_method (xamarin_get_method_direct(r0, r1, 0, NULL, &exception_gchandle));
		if (exception_gchandle != 0) goto exception_handling;
		*managed_method_ptr = managed_method;
	}
	mthis = mono_object_new (mono_domain_get (), mono_method_get_class (managed_method));
	xamarin_set_nsobject_handle (mthis, self);
	xamarin_set_nsobject_flags (mthis, flags);
	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);
	xamarin_create_managed_ref (self, mthis, true);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return self;
}


static void native_to_managed_trampoline_8 (id self, SEL _cmd, MonoMethod **managed_method_ptr, NSObject * p0, const char *r0, const char *r1, const char *r2)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	if (!managed_method) {
		const char *paramptr[1] = { r0 };
		managed_method = xamarin_get_reflection_method_method (xamarin_get_method_direct(r1, r2, 1, paramptr, &exception_gchandle));
		if (exception_gchandle != 0) goto exception_handling;
		*managed_method_ptr = managed_method;
	}
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, NULL, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}



@protocol CALayerDelegate
@end

@interface __MonoMac_NSActionDispatcher : NSObject {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) xamarinApplySelector;
	-(BOOL) conformsToProtocol:(void *)p0;
@end
@implementation __MonoMac_NSActionDispatcher { } 
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) xamarinApplySelector
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_1 (self, _cmd, &managed_method, "Foundation.NSActionDispatcher, Xamarin.iOS", "Apply");
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, "System.IntPtr, mscorlib", "Foundation.NSObject, Xamarin.iOS", "InvokeConformsToProtocol");
	}
@end

@interface __MonoMac_NSAsyncActionDispatcher : NSObject {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) xamarinApplySelector;
	-(BOOL) conformsToProtocol:(void *)p0;
@end
@implementation __MonoMac_NSAsyncActionDispatcher { } 
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) xamarinApplySelector
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_1 (self, _cmd, &managed_method, "Foundation.NSAsyncActionDispatcher, Xamarin.iOS", "Apply");
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, "System.IntPtr, mscorlib", "Foundation.NSObject, Xamarin.iOS", "InvokeConformsToProtocol");
	}
@end

@interface AppDelegate : NSObject<UIApplicationDelegate> {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIWindow *) window;
	-(void) setWindow:(UIWindow *)p0;
	-(BOOL) application:(UIApplication *)p0 didFinishLaunchingWithOptions:(NSDictionary *)p1;
	-(void) applicationWillResignActive:(UIApplication *)p0;
	-(void) applicationDidEnterBackground:(UIApplication *)p0;
	-(void) applicationWillEnterForeground:(UIApplication *)p0;
	-(void) applicationDidBecomeActive:(UIApplication *)p0;
	-(void) applicationWillTerminate:(UIApplication *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end
@implementation AppDelegate { } 
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIWindow *) window
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_3 (self, _cmd, &managed_method, "BindingTest.AppDelegate, BindingTest", "get_Window");
	}

	-(void) setWindow:(UIWindow *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_4 (self, _cmd, &managed_method, p0, "UIKit.UIWindow, Xamarin.iOS", "BindingTest.AppDelegate, BindingTest", "set_Window");
	}

	-(BOOL) application:(UIApplication *)p0 didFinishLaunchingWithOptions:(NSDictionary *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_5 (self, _cmd, &managed_method, p0, p1, "UIKit.UIApplication, Xamarin.iOS", "Foundation.NSDictionary, Xamarin.iOS", "BindingTest.AppDelegate, BindingTest", "FinishedLaunching");
	}

	-(void) applicationWillResignActive:(UIApplication *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_6 (self, _cmd, &managed_method, p0, "UIKit.UIApplication, Xamarin.iOS", "BindingTest.AppDelegate, BindingTest", "OnResignActivation");
	}

	-(void) applicationDidEnterBackground:(UIApplication *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_6 (self, _cmd, &managed_method, p0, "UIKit.UIApplication, Xamarin.iOS", "BindingTest.AppDelegate, BindingTest", "DidEnterBackground");
	}

	-(void) applicationWillEnterForeground:(UIApplication *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_6 (self, _cmd, &managed_method, p0, "UIKit.UIApplication, Xamarin.iOS", "BindingTest.AppDelegate, BindingTest", "WillEnterForeground");
	}

	-(void) applicationDidBecomeActive:(UIApplication *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_6 (self, _cmd, &managed_method, p0, "UIKit.UIApplication, Xamarin.iOS", "BindingTest.AppDelegate, BindingTest", "OnActivated");
	}

	-(void) applicationWillTerminate:(UIApplication *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_6 (self, _cmd, &managed_method, p0, "UIKit.UIApplication, Xamarin.iOS", "BindingTest.AppDelegate, BindingTest", "WillTerminate");
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, "System.IntPtr, mscorlib", "Foundation.NSObject, Xamarin.iOS", "InvokeConformsToProtocol");
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_7 (self, _cmd, &managed_method, "BindingTest.AppDelegate, BindingTest", ".ctor", &call_super);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end

@interface ViewController : UIViewController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(void) didReceiveMemoryWarning;
	-(BOOL) conformsToProtocol:(void *)p0;
@end
@implementation ViewController { } 
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_1 (self, _cmd, &managed_method, "BindingTest.ViewController, BindingTest", "ViewDidLoad");
	}

	-(void) didReceiveMemoryWarning
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_1 (self, _cmd, &managed_method, "BindingTest.ViewController, BindingTest", "DidReceiveMemoryWarning");
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, "System.IntPtr, mscorlib", "Foundation.NSObject, Xamarin.iOS", "InvokeConformsToProtocol");
	}
@end

@interface __NSObject_Disposer : NSObject {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	+(void) drain:(NSObject *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end
@implementation __NSObject_Disposer { } 
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	+(void) drain:(NSObject *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_8 (self, _cmd, &managed_method, p0, "Foundation.NSObject, Xamarin.iOS", "Foundation.NSObject+NSObject_Disposer, Xamarin.iOS", "Drain");
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, "System.IntPtr, mscorlib", "Foundation.NSObject, Xamarin.iOS", "InvokeConformsToProtocol");
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_7 (self, _cmd, &managed_method, "Foundation.NSObject+NSObject_Disposer, Xamarin.iOS", ".ctor", &call_super);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end

@interface JWAdBreak : NSObject {
}
	-(BOOL) nonLinear;
	-(void) setNonLinear:(BOOL)p0;
	-(NSString *) offset;
	-(void) setOffset:(NSString *)p0;
	-(NSString *) tag;
	-(void) setTag:(NSString *)p0;
	-(NSArray *) tags;
	-(void) setTags:(NSArray *)p0;
	-(id) init;
	-(id) initWithTags:(NSArray *)p0 offset:(NSString *)p1;
@end

@interface JWAdConfig : NSObject {
}
	-(unsigned int) adClient;
	-(void) setAdClient:(unsigned int)p0;
	-(NSString *) adMessage;
	-(void) setAdMessage:(NSString *)p0;
	-(NSString *) skipMessage;
	-(void) setSkipMessage:(NSString *)p0;
	-(NSInteger) skipOffset;
	-(void) setSkipOffset:(NSInteger)p0;
	-(NSString *) skipText;
	-(void) setSkipText:(NSString *)p0;
	-(id) init;
@end

@interface JWCaptionStyling : NSObject {
}
	-(UIColor *) backgroundColor;
	-(void) setBackgroundColor:(UIColor *)p0;
	-(unsigned int) edgeStyle;
	-(void) setEdgeStyle:(unsigned int)p0;
	-(UIFont *) font;
	-(void) setFont:(UIFont *)p0;
	-(UIColor *) fontColor;
	-(void) setFontColor:(UIColor *)p0;
	-(UIColor *) windowColor;
	-(void) setWindowColor:(UIColor *)p0;
	-(id) init;
@end

@interface JWCastController : NSObject {
}
	-(void) cast;
	-(void) connectToDevice:(id)p0;
	-(void) disconnect;
	-(void) scanForDevices;
	-(void) stopCasting;
	-(NSArray *) availableDevices;
	-(NSString *) chromeCastReceiverAppID;
	-(void) setChromeCastReceiverAppID:(NSString *)p0;
	-(id) connectedDevice;
	-(id) player;
	-(void) setPlayer:(id)p0;
	-(NSObject *) delegate;
	-(void) setDelegate:(NSObject *)p0;
	-(id) initWithPlayer:(id)p0;
@end

@protocol JWCastingDelegate
	@required -(void) onCastingDevicesAvailable:(NSArray *)p0;
	@optional -(void) onConnectedToCastingDevice:(id)p0;
	@optional -(void) onDisconnectedFromCastingDevice:(NSError *)p0;
	@optional -(void) onConnectionTemporarilySuspended;
	@optional -(void) onConnectionRecovered;
	@optional -(void) onConnectionFailed:(NSError *)p0;
	@optional -(void) onCasting;
	@optional -(void) onCastingFailed:(NSError *)p0;
	@optional -(void) onCastingEnded:(NSError *)p0;
@end

@interface JWCastingDevice : NSObject {
}
	-(unsigned int) castingService;
	-(NSString *) identifier;
	-(NSString *) name;
@end

@interface JWConfig : NSObject {
}
	-(id) adConfig;
	-(void) setAdConfig:(id)p0;
	-(NSArray *) adSchedule;
	-(void) setAdSchedule:(NSArray *)p0;
	-(NSString *) adVmap;
	-(void) setAdVmap:(NSString *)p0;
	-(NSDictionary *) assetOptions;
	-(void) setAssetOptions:(NSDictionary *)p0;
	-(BOOL) autostart;
	-(void) setAutostart:(BOOL)p0;
	-(id) captionStyling;
	-(void) setCaptionStyling:(id)p0;
	-(BOOL) controls;
	-(void) setControls:(BOOL)p0;
	-(NSString *) cssSkin;
	-(void) setCssSkin:(NSString *)p0;
	-(NSString *) file;
	-(void) setFile:(NSString *)p0;
	-(NSString *) image;
	-(void) setImage:(NSString *)p0;
	-(NSString *) offlineMessage;
	-(void) setOfflineMessage:(NSString *)p0;
	-(UIImage *) offlinePoster;
	-(void) setOfflinePoster:(UIImage *)p0;
	-(NSArray *) playlist;
	-(void) setPlaylist:(NSArray *)p0;
	-(unsigned int) premiumSkin;
	-(void) setPremiumSkin:(unsigned int)p0;
	-(id) relatedConfig;
	-(void) setRelatedConfig:(id)p0;
	-(BOOL) repeat;
	-(void) setRepeat:(BOOL)p0;
	-(CGSize) size;
	-(void) setSize:(CGSize)p0;
	-(NSArray *) sources;
	-(void) setSources:(NSArray *)p0;
	-(unsigned int) stretch;
	-(void) setStretch:(unsigned int)p0;
	-(NSString *) title;
	-(void) setTitle:(NSString *)p0;
	-(NSArray *) tracks;
	-(void) setTracks:(NSArray *)p0;
	-(id) init;
	-(id) initWithContentUrl:(NSString *)p0;
@end

@protocol JWDrmDataSource
	@required -(void) fetchContentIdentifierForRequest:(NSURL *)p0 forEncryption:(unsigned int)p1 withCompletion:(id)p2;
	@required -(void) fetchAppIdentifierForRequest:(NSURL *)p0 forEncryption:(unsigned int)p1 withCompletion:(id)p2;
	@required -(void) fetchContentKeyWithRequest:(NSData *)p0 forEncryption:(unsigned int)p1 withCompletion:(id)p2;
@end

@interface JWPlayerController : NSObject {
}
	-(void) closeRelatedOverlay;
	-(void) enterFullScreen;
	-(void) exitFullScreen;
	-(void) load:(NSString *)p0;
	-(void) loadConfig:(id)p0;
	-(void) loadPlaylist:(NSArray *)p0;
	-(void) openRelatedOverlay;
	-(void) pause;
	-(void) play;
	-(void) playAd:(NSString *)p0;
	-(void) playAd:(NSString *)p0 onClient:(unsigned int)p1;
	-(void) seek:(NSUInteger)p0;
	-(void) stop;
	-(void) togglePictureInPicture;
	-(NSArray *) audioTracks;
	-(NSInteger) buffer;
	-(NSArray *) captionsList;
	-(id) config;
	-(BOOL) controls;
	-(void) setControls:(BOOL)p0;
	-(NSInteger) currentAudioTrack;
	-(void) setCurrentAudioTrack:(NSInteger)p0;
	-(NSInteger) currentCaptions;
	-(void) setCurrentCaptions:(NSInteger)p0;
	-(NSInteger) currentQualityLevel;
	-(void) setCurrentQualityLevel:(NSInteger)p0;
	-(BOOL) displayLockScreenControls;
	-(void) setDisplayLockScreenControls:(BOOL)p0;
	-(id) drmDataSource;
	-(void) setDrmDataSource:(id)p0;
	-(double) duration;
	-(BOOL) forceFullScreenOnLandscape;
	-(void) setForceFullScreenOnLandscape:(BOOL)p0;
	-(BOOL) forceLandscapeOnFullScreen;
	-(void) setForceLandscapeOnFullScreen:(BOOL)p0;
	-(NSString *) googleChromeCastVersion;
	-(NSString *) googleIMAVersion;
	-(BOOL) isInFullscreen;
	-(NSArray *) levels;
	-(NSDictionary *) metadata;
	-(CGSize) naturalSize;
	-(BOOL) openSafariOnAdClick;
	-(void) setOpenSafariOnAdClick:(BOOL)p0;
	-(BOOL) pictureInPictureDisabled;
	-(void) setPictureInPictureDisabled:(BOOL)p0;
	-(NSNumber *) playbackPosition;
	-(NSString *) playerEdition;
	-(NSString *) playerState;
	-(NSString *) playerVersion;
	-(NSInteger) playlistIndex;
	-(void) setPlaylistIndex:(NSInteger)p0;
	-(CGRect) safeRegion;
	-(UIView *) view;
	-(CGFloat) volume;
	-(void) setVolume:(CGFloat)p0;
	-(NSObject *) delegate;
	-(void) setDelegate:(NSObject *)p0;
	-(id) init;
	-(id) initWithConfig:(id)p0;
	-(id) initWithConfig:(id)p0 delegate:(id)p1;
	-(id) initWithConfig:(id)p0 delegate:(id)p1 drmDataSource:(id)p2;
@end

@protocol JWPlayerDelegate
	@optional -(void) onAll;
	@optional -(void) onPlayAttempt;
	@optional -(void) onBeforePlay;
	@optional -(void) onFirstFrame:(NSInteger)p0;
	@optional -(void) onPlay;
	@optional -(void) onPlay:(NSString *)p0;
	@optional -(void) onPause;
	@optional -(void) onPause:(NSString *)p0;
	@optional -(void) onIdle;
	@optional -(void) onIdle:(NSString *)p0;
	@optional -(void) onReady;
	@optional -(void) onReady:(NSInteger)p0;
	@optional -(void) onBeforeComplete;
	@optional -(void) onComplete;
	@optional -(void) onBuffer;
	@optional -(void) onBuffer:(NSString *)p0 reason:(NSString *)p1;
	@optional -(void) onBufferChange:(double)p0;
	@optional -(void) onTime:(double)p0 ofDuration:(double)p1;
	@optional -(void) onSeek:(double)p0 fromPosition:(double)p1;
	@optional -(void) onSeeked;
	@optional -(void) onMeta:(NSDictionary *)p0;
	@optional -(void) onCaptionsList:(NSArray *)p0 with:(NSInteger)p1;
	@optional -(void) onCaptionsChanged:(NSInteger)p0;
	@optional -(void) onCaptionsChange:(NSInteger)p0;
	@optional -(void) onLevels:(NSArray *)p0;
	@optional -(void) onQualityLevels:(NSArray *)p0;
	@optional -(void) onLevelsChanged:(NSInteger)p0;
	@optional -(void) onQualityChange:(NSInteger)p0;
	@optional -(void) onVisualQuality:(NSString *)p0 reason:(NSString *)p1 label:(NSString *)p2;
	@optional -(void) onAudioTracks:(NSArray *)p0;
	@optional -(void) onAudioTrackChanged:(NSInteger)p0;
	@optional -(void) onPlaylist:(NSArray *)p0;
	@optional -(void) onPlaylistItem:(NSInteger)p0;
	@optional -(void) onPlaylistComplete;
	@optional -(void) onFullscreen:(BOOL)p0;
	@optional -(void) onPictureInPicture:(BOOL)p0;
	@optional -(void) onControls:(BOOL)p0;
	@optional -(void) onDisplayClick;
	@optional -(void) onAdRequest:(NSString *)p0 forPosition:(NSString *)p1;
	@optional -(void) onAdRequest:(NSString *)p0 forPosition:(NSString *)p1 client:(unsigned int)p2 creativeType:(NSString *)p3;
	@optional -(void) onAdSkipped:(NSString *)p0;
	@optional -(void) onAdSkipped:(NSString *)p0 client:(unsigned int)p1 creativeType:(NSString *)p2;
	@optional -(void) onAdComplete:(NSString *)p0;
	@optional -(void) onAdComplete:(NSString *)p0 client:(unsigned int)p1 creativeType:(NSString *)p2;
	@optional -(void) onAdClick:(NSString *)p0;
	@optional -(void) onAdClick:(NSString *)p0 client:(unsigned int)p1 creativeType:(NSString *)p2;
	@optional -(void) onAdImpression:(NSString *)p0;
	@optional -(void) onAdImpression:(NSString *)p0 adPosition:(NSString *)p1 adSystem:(NSString *)p2 adTitle:(NSString *)p3 client:(unsigned int)p4 creativeType:(NSString *)p5 vastVersion:(double)p6 wrapper:(NSArray *)p7;
	@optional -(void) onAdPlay:(NSString *)p0;
	@optional -(void) onAdPlay:(NSString *)p0 creativeType:(NSString *)p1 newState:(NSString *)p2 oldState:(NSString *)p3;
	@optional -(void) onAdPause:(NSString *)p0;
	@optional -(void) onAdPause:(NSString *)p0 creativeType:(NSString *)p1 newState:(NSString *)p2 oldState:(NSString *)p3;
	@optional -(void) onAdTime:(double)p0 ofDuration:(double)p1 tag:(NSString *)p2 index:(NSInteger)p3;
	@optional -(void) onAdTime:(double)p0 ofDuration:(double)p1 tag:(NSString *)p2 index:(NSInteger)p3 client:(unsigned int)p4 creativeType:(NSString *)p5;
	@optional -(void) onAdError:(NSError *)p0;
	@optional -(void) onAdStarted:(NSString *)p0 creativeType:(NSString *)p1;
	@optional -(void) onOpenRelatedOverlay:(unsigned int)p0 relatedFile:(NSString *)p1 items:(NSArray *)p2;
	@optional -(void) onCloseRelatedOverlay:(NSString *)p0;
	@optional -(void) onRelatedPlay:(id)p0 auto:(BOOL)p1 position:(NSInteger)p2;
	@optional -(void) onError:(NSError *)p0;
	@optional -(void) onSetupError:(NSError *)p0;
@end

@interface JWPlaylistItem : NSObject {
}
	-(NSArray *) adSchedule;
	-(void) setAdSchedule:(NSArray *)p0;
	-(NSDictionary *) assetOptions;
	-(void) setAssetOptions:(NSDictionary *)p0;
	-(NSString *) desc;
	-(void) setDesc:(NSString *)p0;
	-(NSString *) file;
	-(void) setFile:(NSString *)p0;
	-(NSString *) image;
	-(void) setImage:(NSString *)p0;
	-(NSString *) mediaId;
	-(void) setMediaId:(NSString *)p0;
	-(NSArray *) sources;
	-(void) setSources:(NSArray *)p0;
	-(NSString *) title;
	-(void) setTitle:(NSString *)p0;
	-(NSArray *) tracks;
	-(void) setTracks:(NSArray *)p0;
	-(id) init;
@end

@interface JWRelatedConfig : NSObject {
}
	-(NSString *) autoplayMessage;
	-(void) setAutoplayMessage:(NSString *)p0;
	-(NSInteger) autoplayTimer;
	-(void) setAutoplayTimer:(NSInteger)p0;
	-(NSString *) file;
	-(void) setFile:(NSString *)p0;
	-(NSString *) heading;
	-(void) setHeading:(NSString *)p0;
	-(unsigned int) onComplete;
	-(void) setOnComplete:(unsigned int)p0;
	-(id) init;
@end

@interface JWSource : NSObject {
}
	-(NSDictionary *) assetOptions;
	-(void) setAssetOptions:(NSDictionary *)p0;
	-(BOOL) defaultQuality;
	-(void) setDefaultQuality:(BOOL)p0;
	-(NSString *) file;
	-(void) setFile:(NSString *)p0;
	-(NSString *) label;
	-(void) setLabel:(NSString *)p0;
	-(id) init;
	-(id) initWithFile:(NSString *)p0 label:(NSString *)p1 isDefault:(BOOL)p2;
@end

@interface JWTrack : NSObject {
}
	-(BOOL) defaultValue;
	-(void) setDefaultValue:(BOOL)p0;
	-(NSString *) file;
	-(void) setFile:(NSString *)p0;
	-(NSString *) kind;
	-(void) setKind:(NSString *)p0;
	-(NSString *) label;
	-(void) setLabel:(NSString *)p0;
	-(id) init;
	-(id) initWithFile:(NSString *)p0 label:(NSString *)p1;
	-(id) initWithFile:(NSString *)p0 label:(NSString *)p1 isDefault:(BOOL)p2;
@end

	static MTClassMap __xamarin_class_map [] = {
		{"NSObject", "Foundation.NSObject, Xamarin.iOS", NULL },
		{"UIResponder", "UIKit.UIResponder, Xamarin.iOS", NULL },
		{"UIViewController", "UIKit.UIViewController, Xamarin.iOS", NULL },
		{"UIFocusAnimationCoordinator", "UIKit.UIFocusAnimationCoordinator, Xamarin.iOS", NULL },
		{"UIFocusUpdateContext", "UIKit.UIFocusUpdateContext, Xamarin.iOS", NULL },
		{"UIFont", "UIKit.UIFont, Xamarin.iOS", NULL },
		{"UITraitCollection", "UIKit.UITraitCollection, Xamarin.iOS", NULL },
		{"UIView", "UIKit.UIView, Xamarin.iOS", NULL },
		{"UIImage", "UIKit.UIImage, Xamarin.iOS", NULL },
		{"NSUserActivity", "Foundation.NSUserActivity, Xamarin.iOS", NULL },
		{"NSArray", "Foundation.NSArray, Xamarin.iOS", NULL },
		{"NSCoder", "Foundation.NSCoder, Xamarin.iOS", NULL },
		{"NSDate", "Foundation.NSDate, Xamarin.iOS", NULL },
		{"UILocalNotification", "UIKit.UILocalNotification, Xamarin.iOS", NULL },
		{"NSValue", "Foundation.NSValue, Xamarin.iOS", NULL },
		{"NSNumber", "Foundation.NSNumber, Xamarin.iOS", NULL },
		{"NSRunLoop", "Foundation.NSRunLoop, Xamarin.iOS", NULL },
		{"NSString", "Foundation.NSString, Xamarin.iOS", NULL },
		{"__MonoMac_NSActionDispatcher", "Foundation.NSActionDispatcher, Xamarin.iOS", NULL },
		{"__MonoMac_NSAsyncActionDispatcher", "Foundation.NSAsyncActionDispatcher, Xamarin.iOS", NULL },
		{"NSURL", "Foundation.NSUrl, Xamarin.iOS", NULL },
		{"NSAutoreleasePool", "Foundation.NSAutoreleasePool, Xamarin.iOS", NULL },
		{"NSError", "Foundation.NSError, Xamarin.iOS", NULL },
		{"CALayer", "CoreAnimation.CALayer, Xamarin.iOS", NULL },
		{"CKShareMetadata", "CloudKit.CKShareMetadata, Xamarin.iOS", NULL },
		{"UIDevice", "UIKit.UIDevice, Xamarin.iOS", NULL },
		{"UIApplication", "UIKit.UIApplication, Xamarin.iOS", NULL },
		{"UIBezierPath", "UIKit.UIBezierPath, Xamarin.iOS", NULL },
		{"UIColor", "UIKit.UIColor, Xamarin.iOS", NULL },
		{"NSException", "Foundation.NSException, Xamarin.iOS", NULL },
		{"NSNull", "Foundation.NSNull, Xamarin.iOS", NULL },
		{"UIUserNotificationSettings", "UIKit.UIUserNotificationSettings, Xamarin.iOS", NULL },
		{"UIApplicationShortcutItem", "UIKit.UIApplicationShortcutItem, Xamarin.iOS", NULL },
		{"UIWindow", "UIKit.UIWindow, Xamarin.iOS", NULL },
		{"NSData", "Foundation.NSData, Xamarin.iOS", NULL },
		{"NSDictionary", "Foundation.NSDictionary, Xamarin.iOS", NULL },
		{"AppDelegate", "BindingTest.AppDelegate, BindingTest", NULL },
		{"ViewController", "BindingTest.ViewController, BindingTest", NULL },
		{"__NSObject_Disposer", "Foundation.NSObject+NSObject_Disposer, Xamarin.iOS", NULL },
		{"JWAdBreak", "JWPlayer.JWAdBreak, JWPlayer", NULL },
		{"JWAdConfig", "JWPlayer.JWAdConfig, JWPlayer", NULL },
		{"JWCaptionStyling", "JWPlayer.JWCaptionStyling, JWPlayer", NULL },
		{"JWCastController", "JWPlayer.JWCastController, JWPlayer", NULL },
		{"JWCastingDevice", "JWPlayer.JWCastingDevice, JWPlayer", NULL },
		{"JWConfig", "JWPlayer.JWConfig, JWPlayer", NULL },
		{"JWPlayerController", "JWPlayer.JWPlayerController, JWPlayer", NULL },
		{"JWPlaylistItem", "JWPlayer.JWPlaylistItem, JWPlayer", NULL },
		{"JWRelatedConfig", "JWPlayer.JWRelatedConfig, JWPlayer", NULL },
		{"JWSource", "JWPlayer.JWSource, JWPlayer", NULL },
		{"JWTrack", "JWPlayer.JWTrack, JWPlayer", NULL },
		{ NULL, NULL, NULL },
	};

	static const char *__xamarin_registration_assemblies []= {
		"BindingTest", 
		"Xamarin.iOS", 
		"mscorlib", 
		"System", 
		"JWPlayer"
	};

	static struct MTRegistrationMap __xamarin_registration_map = {
		NULL,
		__xamarin_registration_assemblies,
		__xamarin_class_map,
		5,
		50,
		14
	};

void xamarin_create_classes () {
	__xamarin_class_map [0].handle = objc_getClass ("NSObject");
	__xamarin_class_map [1].handle = objc_getClass ("UIResponder");
	__xamarin_class_map [2].handle = objc_getClass ("UIViewController");
	__xamarin_class_map [3].handle = objc_getClass ("UIFocusAnimationCoordinator");
	__xamarin_class_map [4].handle = objc_getClass ("UIFocusUpdateContext");
	__xamarin_class_map [5].handle = objc_getClass ("UIFont");
	__xamarin_class_map [6].handle = objc_getClass ("UITraitCollection");
	__xamarin_class_map [7].handle = objc_getClass ("UIView");
	__xamarin_class_map [8].handle = objc_getClass ("UIImage");
	__xamarin_class_map [9].handle = objc_getClass ("NSUserActivity");
	__xamarin_class_map [10].handle = objc_getClass ("NSArray");
	__xamarin_class_map [11].handle = objc_getClass ("NSCoder");
	__xamarin_class_map [12].handle = objc_getClass ("NSDate");
	__xamarin_class_map [13].handle = objc_getClass ("UILocalNotification");
	__xamarin_class_map [14].handle = objc_getClass ("NSValue");
	__xamarin_class_map [15].handle = objc_getClass ("NSNumber");
	__xamarin_class_map [16].handle = objc_getClass ("NSRunLoop");
	__xamarin_class_map [17].handle = objc_getClass ("NSString");
	__xamarin_class_map [18].handle = objc_getClass ("__MonoMac_NSActionDispatcher");
	__xamarin_class_map [19].handle = objc_getClass ("__MonoMac_NSAsyncActionDispatcher");
	__xamarin_class_map [20].handle = objc_getClass ("NSURL");
	__xamarin_class_map [21].handle = objc_getClass ("NSAutoreleasePool");
	__xamarin_class_map [22].handle = objc_getClass ("NSError");
	__xamarin_class_map [23].handle = objc_getClass ("CALayer");
	__xamarin_class_map [24].handle = objc_getClass ("CKShareMetadata");
	__xamarin_class_map [25].handle = objc_getClass ("UIDevice");
	__xamarin_class_map [26].handle = objc_getClass ("UIApplication");
	__xamarin_class_map [27].handle = objc_getClass ("UIBezierPath");
	__xamarin_class_map [28].handle = objc_getClass ("UIColor");
	__xamarin_class_map [29].handle = objc_getClass ("NSException");
	__xamarin_class_map [30].handle = objc_getClass ("NSNull");
	__xamarin_class_map [31].handle = objc_getClass ("UIUserNotificationSettings");
	__xamarin_class_map [32].handle = objc_getClass ("UIApplicationShortcutItem");
	__xamarin_class_map [33].handle = objc_getClass ("UIWindow");
	__xamarin_class_map [34].handle = objc_getClass ("NSData");
	__xamarin_class_map [35].handle = objc_getClass ("NSDictionary");
	__xamarin_class_map [36].handle = [AppDelegate class];
	__xamarin_class_map [37].handle = [ViewController class];
	__xamarin_class_map [38].handle = objc_getClass ("__NSObject_Disposer");
	__xamarin_class_map [39].handle = [JWAdBreak class];
	__xamarin_class_map [40].handle = [JWAdConfig class];
	__xamarin_class_map [41].handle = [JWCaptionStyling class];
	__xamarin_class_map [42].handle = [JWCastController class];
	__xamarin_class_map [43].handle = [JWCastingDevice class];
	__xamarin_class_map [44].handle = [JWConfig class];
	__xamarin_class_map [45].handle = [JWPlayerController class];
	__xamarin_class_map [46].handle = [JWPlaylistItem class];
	__xamarin_class_map [47].handle = [JWRelatedConfig class];
	__xamarin_class_map [48].handle = [JWSource class];
	__xamarin_class_map [49].handle = [JWTrack class];
	xamarin_add_registration_map (&__xamarin_registration_map);
}


