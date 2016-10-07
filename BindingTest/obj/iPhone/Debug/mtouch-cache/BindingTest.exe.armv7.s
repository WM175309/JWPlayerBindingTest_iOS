.subsections_via_symbols
.section __DWARF, __debug_line,regular,debug
Ldebug_line_section_start:
Ldebug_line_start:
.section __DWARF, __debug_abbrev,regular,debug

	.byte 1,17,1,37,8,3,8,27,8,19,11,17,1,18,1,16,6,0,0,2,46,1,3,8,135,64,8,58,15,59,15,17
	.byte 1,18,1,64,10,0,0,3,5,0,3,8,73,19,2,10,0,0,15,5,0,3,8,73,19,2,6,0,0,4,36,0
	.byte 11,11,62,11,3,8,0,0,5,2,1,3,8,11,15,0,0,17,2,0,3,8,11,15,0,0,6,13,0,3,8,73
	.byte 19,56,10,0,0,7,22,0,3,8,73,19,0,0,8,4,1,3,8,11,15,73,19,0,0,9,40,0,3,8,28,13
	.byte 0,0,10,57,1,3,8,0,0,11,52,0,3,8,73,19,2,10,0,0,12,52,0,3,8,73,19,2,6,0,0,13
	.byte 15,0,73,19,0,0,14,16,0,73,19,0,0,16,28,0,73,19,56,10,0,0,18,46,0,3,8,17,1,18,1,0
	.byte 0,0
.section __DWARF, __debug_info,regular,debug
Ldebug_info_start:

LDIFF_SYM0=Ldebug_info_end - Ldebug_info_begin
	.long LDIFF_SYM0
Ldebug_info_begin:

	.short 2
	.long 0
	.byte 4,1
	.asciz "Mono AOT Compiler 4.6.1 (tarball Fri Sep 23 15:20:44 EDT 2016)"
	.asciz "BindingTest.exe"
	.asciz ""

	.byte 2,0,0,0,0,0,0,0,0
LDIFF_SYM1=Ldebug_line_start - Ldebug_line_section_start
	.long LDIFF_SYM1
LDIE_I1:

	.byte 4,1,5
	.asciz "sbyte"
LDIE_U1:

	.byte 4,1,7
	.asciz "byte"
LDIE_I2:

	.byte 4,2,5
	.asciz "short"
LDIE_U2:

	.byte 4,2,7
	.asciz "ushort"
LDIE_I4:

	.byte 4,4,5
	.asciz "int"
LDIE_U4:

	.byte 4,4,7
	.asciz "uint"
LDIE_I8:

	.byte 4,8,5
	.asciz "long"
LDIE_U8:

	.byte 4,8,7
	.asciz "ulong"
LDIE_I:

	.byte 4,4,5
	.asciz "intptr"
LDIE_U:

	.byte 4,4,7
	.asciz "uintptr"
LDIE_R4:

	.byte 4,4,4
	.asciz "float"
LDIE_R8:

	.byte 4,8,4
	.asciz "double"
LDIE_BOOLEAN:

	.byte 4,1,2
	.asciz "boolean"
LDIE_CHAR:

	.byte 4,2,8
	.asciz "char"
LDIE_STRING:

	.byte 4,4,1
	.asciz "string"
LDIE_OBJECT:

	.byte 4,4,1
	.asciz "object"
LDIE_SZARRAY:

	.byte 4,4,1
	.asciz "object"
.section __DWARF, __debug_loc,regular,debug
Ldebug_loc_start:
.section __DWARF, __debug_frame,regular,debug
	.align 3

LDIFF_SYM2=Lcie0_end - Lcie0_start
	.long LDIFF_SYM2
Lcie0_start:

	.long -1
	.byte 3
	.asciz ""

	.byte 1,124,14,12,13,0
	.align 2
Lcie0_end:
.text
	.align 3
jit_code_start:

	.byte 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
.text
	.align 2
	.no_dead_strip BindingTest_Application__ctor
BindingTest_Application__ctor:

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,8,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_BindingTest_got - . + 44
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,60,224,158,229,0,0,94,227
	.byte 0,224,158,21,0,0,160,225,8,0,157,229,0,224,157,229,84,224,158,229,0,0,94,227,0,224,158,21,0,0,160,225
	.byte 0,224,157,229,104,224,158,229,0,0,94,227,0,224,158,21,0,0,160,225,5,223,141,226,0,1,189,232,128,128,189,232

Lme_0:
.text
	.align 2
	.no_dead_strip BindingTest_Application_Main_string__
BindingTest_Application_Main_string__:
.file 1 "/Users/wmartin/Documents/Xamarin/Projects/BindingTest/BindingTest/Main.cs"
.loc 1 10 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,7,223,77,226,8,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_BindingTest_got - . + 48
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,60,224,158,229,0,0,94,227
	.byte 0,224,158,21,0,0,160,225,4,224,157,229,0,224,158,229,0,224,157,229,88,224,158,229,0,0,94,227,0,224,158,21
	.byte 0,0,160,225
.loc 1 13 0

	.byte 0,224,157,229,108,224,158,229,0,0,94,227,0,224,158,21,0,0,160,225,8,0,157,229,16,0,141,229,0,15,160,227
	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_BindingTest_got - . + 52
	.byte 0,0,159,231,20,0,141,229,0,224,157,229,160,224,158,229,0,0,94,227,0,224,158,21,0,0,160,225,16,0,157,229
	.byte 20,32,157,229,0,31,160,227
bl _p_1
.loc 1 15 0

	.byte 0,224,157,229,196,224,158,229,0,0,94,227,0,224,158,21,0,0,160,225,0,224,157,229,216,224,158,229,0,0,94,227
	.byte 0,224,158,21,0,0,160,225,7,223,141,226,0,1,189,232,128,128,189,232

Lme_1:
.text
	.align 2
	.no_dead_strip BindingTest_AppDelegate__ctor
BindingTest_AppDelegate__ctor:

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,8,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_BindingTest_got - . + 56
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,60,224,158,229,0,0,94,227
	.byte 0,224,158,21,0,0,160,225,8,0,157,229
bl _p_2

	.byte 0,224,157,229,88,224,158,229,0,0,94,227,0,224,158,21,0,0,160,225,0,224,157,229,108,224,158,229,0,0,94,227
	.byte 0,224,158,21,0,0,160,225,5,223,141,226,0,1,189,232,128,128,189,232

Lme_2:
.text
	.align 2
	.no_dead_strip BindingTest_AppDelegate_get_Window
BindingTest_AppDelegate_get_Window:
.file 2 "/Users/wmartin/Documents/Xamarin/Projects/BindingTest/BindingTest/AppDelegate.cs"
.loc 2 15 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,4,223,77,226,8,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_BindingTest_got - . + 60
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,111,160,227,0,224,157,229,64,224,158,229
	.byte 0,0,94,227,0,224,158,21,0,0,160,225,4,224,157,229,0,224,158,229,0,224,157,229,92,224,158,229,0,0,94,227
	.byte 0,224,158,21,0,0,160,225,8,0,157,229,20,0,144,229,0,96,160,225,0,224,157,229,124,224,158,229,0,0,94,227
	.byte 0,224,158,21,0,0,160,225,4,223,141,226,64,1,189,232,128,128,189,232

Lme_3:
.text
	.align 2
	.no_dead_strip BindingTest_AppDelegate_set_Window_UIKit_UIWindow
BindingTest_AppDelegate_set_Window_UIKit_UIWindow:
.loc 2 16 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,7,223,77,226,8,0,141,229,12,16,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_BindingTest_got - . + 64
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,64,224,158,229,0,0,94,227
	.byte 0,224,158,21,0,0,160,225,4,224,157,229,0,224,158,229,0,224,157,229,92,224,158,229,0,0,94,227,0,224,158,21
	.byte 0,0,160,225,8,0,157,229,12,16,157,229,16,16,141,229,20,16,128,229,5,15,128,226
bl _p_3

	.byte 16,0,157,229,0,224,157,229,140,224,158,229,0,0,94,227,0,224,158,21,0,0,160,225,7,223,141,226,0,1,189,232
	.byte 128,128,189,232

Lme_4:
.text
	.align 2
	.no_dead_strip BindingTest_AppDelegate_FinishedLaunching_UIKit_UIApplication_Foundation_NSDictionary
BindingTest_AppDelegate_FinishedLaunching_UIKit_UIApplication_Foundation_NSDictionary:
.loc 2 20 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,7,223,77,226,12,0,141,229,16,16,141,229,20,32,141,229,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_BindingTest_got - . + 68
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,15,160,227,8,0,205,229,0,224,157,229
	.byte 76,224,158,229,0,0,94,227,0,224,158,21,0,0,160,225,4,224,157,229,0,224,158,229,0,224,157,229,104,224,158,229
	.byte 0,0,94,227,0,224,158,21,0,0,160,225
.loc 2 24 0

	.byte 0,224,157,229,124,224,158,229,0,0,94,227,0,224,158,21,0,0,160,225,64,3,160,227,8,0,205,229
.loc 2 25 0

	.byte 0,224,157,229,152,224,158,229,0,0,94,227,0,224,158,21,0,0,160,225,8,0,221,229,0,224,157,229,176,224,158,229
	.byte 0,0,94,227,0,224,158,21,0,0,160,225,7,223,141,226,0,1,189,232,128,128,189,232

Lme_5:
.text
	.align 2
	.no_dead_strip BindingTest_AppDelegate_OnResignActivation_UIKit_UIApplication
BindingTest_AppDelegate_OnResignActivation_UIKit_UIApplication:
.loc 2 28 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,8,0,141,229,12,16,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_BindingTest_got - . + 72
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,64,224,158,229,0,0,94,227
	.byte 0,224,158,21,0,0,160,225,4,224,157,229,0,224,158,229,0,224,157,229,92,224,158,229,0,0,94,227,0,224,158,21
	.byte 0,0,160,225
.loc 2 33 0

	.byte 0,224,157,229,112,224,158,229,0,0,94,227,0,224,158,21,0,0,160,225,0,224,157,229,132,224,158,229,0,0,94,227
	.byte 0,224,158,21,0,0,160,225,5,223,141,226,0,1,189,232,128,128,189,232

Lme_6:
.text
	.align 2
	.no_dead_strip BindingTest_AppDelegate_DidEnterBackground_UIKit_UIApplication
BindingTest_AppDelegate_DidEnterBackground_UIKit_UIApplication:
.loc 2 36 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,8,0,141,229,12,16,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_BindingTest_got - . + 76
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,64,224,158,229,0,0,94,227
	.byte 0,224,158,21,0,0,160,225,4,224,157,229,0,224,158,229,0,224,157,229,92,224,158,229,0,0,94,227,0,224,158,21
	.byte 0,0,160,225
.loc 2 39 0

	.byte 0,224,157,229,112,224,158,229,0,0,94,227,0,224,158,21,0,0,160,225,0,224,157,229,132,224,158,229,0,0,94,227
	.byte 0,224,158,21,0,0,160,225,5,223,141,226,0,1,189,232,128,128,189,232

Lme_7:
.text
	.align 2
	.no_dead_strip BindingTest_AppDelegate_WillEnterForeground_UIKit_UIApplication
BindingTest_AppDelegate_WillEnterForeground_UIKit_UIApplication:
.loc 2 42 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,8,0,141,229,12,16,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_BindingTest_got - . + 80
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,64,224,158,229,0,0,94,227
	.byte 0,224,158,21,0,0,160,225,4,224,157,229,0,224,158,229,0,224,157,229,92,224,158,229,0,0,94,227,0,224,158,21
	.byte 0,0,160,225
.loc 2 45 0

	.byte 0,224,157,229,112,224,158,229,0,0,94,227,0,224,158,21,0,0,160,225,0,224,157,229,132,224,158,229,0,0,94,227
	.byte 0,224,158,21,0,0,160,225,5,223,141,226,0,1,189,232,128,128,189,232

Lme_8:
.text
	.align 2
	.no_dead_strip BindingTest_AppDelegate_OnActivated_UIKit_UIApplication
BindingTest_AppDelegate_OnActivated_UIKit_UIApplication:
.loc 2 48 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,8,0,141,229,12,16,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_BindingTest_got - . + 84
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,64,224,158,229,0,0,94,227
	.byte 0,224,158,21,0,0,160,225,4,224,157,229,0,224,158,229,0,224,157,229,92,224,158,229,0,0,94,227,0,224,158,21
	.byte 0,0,160,225
.loc 2 51 0

	.byte 0,224,157,229,112,224,158,229,0,0,94,227,0,224,158,21,0,0,160,225,0,224,157,229,132,224,158,229,0,0,94,227
	.byte 0,224,158,21,0,0,160,225,5,223,141,226,0,1,189,232,128,128,189,232

Lme_9:
.text
	.align 2
	.no_dead_strip BindingTest_AppDelegate_WillTerminate_UIKit_UIApplication
BindingTest_AppDelegate_WillTerminate_UIKit_UIApplication:
.loc 2 54 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,8,0,141,229,12,16,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_BindingTest_got - . + 88
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,64,224,158,229,0,0,94,227
	.byte 0,224,158,21,0,0,160,225,4,224,157,229,0,224,158,229,0,224,157,229,92,224,158,229,0,0,94,227,0,224,158,21
	.byte 0,0,160,225
.loc 2 56 0

	.byte 0,224,157,229,112,224,158,229,0,0,94,227,0,224,158,21,0,0,160,225,0,224,157,229,132,224,158,229,0,0,94,227
	.byte 0,224,158,21,0,0,160,225,5,223,141,226,0,1,189,232,128,128,189,232

Lme_a:
.text
	.align 2
	.no_dead_strip BindingTest_ViewController__ctor_intptr
BindingTest_ViewController__ctor_intptr:
.file 3 "/Users/wmartin/Documents/Xamarin/Projects/BindingTest/BindingTest/ViewController.cs"
.loc 3 9 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,8,0,141,229,12,16,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_BindingTest_got - . + 92
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,64,224,158,229,0,0,94,227
	.byte 0,224,158,21,0,0,160,225,4,224,157,229,0,224,158,229,0,224,157,229,92,224,158,229,0,0,94,227,0,224,158,21
	.byte 0,0,160,225,8,0,157,229,12,16,157,229
bl _p_4
.loc 3 10 0

	.byte 0,224,157,229,124,224,158,229,0,0,94,227,0,224,158,21,0,0,160,225
.loc 3 12 0

	.byte 0,224,157,229,144,224,158,229,0,0,94,227,0,224,158,21,0,0,160,225,0,224,157,229,164,224,158,229,0,0,94,227
	.byte 0,224,158,21,0,0,160,225,5,223,141,226,0,1,189,232,128,128,189,232

Lme_b:
.text
	.align 2
	.no_dead_strip BindingTest_ViewController_ViewDidLoad
BindingTest_ViewController_ViewDidLoad:
.loc 3 15 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,96,9,45,233,26,223,77,226,13,176,160,225,40,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_BindingTest_got - . + 96
	.byte 0,0,159,231,16,0,139,229,16,224,155,229,0,224,158,229,20,224,139,229,0,111,160,227,0,95,160,227,16,224,155,229
	.byte 72,224,158,229,0,0,94,227,0,224,158,21,0,0,160,225,20,224,155,229,0,224,158,229,16,224,155,229,100,224,158,229
	.byte 0,0,94,227,0,224,158,21,0,0,160,225
.loc 3 16 0

	.byte 16,224,155,229,120,224,158,229,0,0,94,227,0,224,158,21,0,0,160,225,40,0,155,229,100,0,139,229,16,224,155,229
	.byte 148,224,158,229,0,0,94,227,0,224,158,21,0,0,160,225,100,0,155,229
bl _p_5
.loc 3 18 0

	.byte 16,224,155,229,176,224,158,229,0,0,94,227,0,224,158,21,0,0,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_BindingTest_got - . + 100
	.byte 0,0,159,231
bl _p_6

	.byte 96,0,139,229
bl _p_7

	.byte 16,224,155,229,224,224,158,229,0,0,94,227,0,224,158,21,0,0,160,225,96,0,155,229,0,96,160,225
.loc 3 20 0

	.byte 16,224,155,229,252,224,158,229,0,0,94,227,0,224,158,21,0,0,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_BindingTest_got - . + 104
	.byte 0,0,159,231
bl _p_6

	.byte 92,0,139,229
bl _p_8

	.byte 16,224,155,229,44,225,158,229,0,0,94,227,0,224,158,21,0,0,160,225,92,0,155,229,0,80,160,225
.loc 3 21 0

	.byte 16,224,155,229,72,225,158,229,0,0,94,227,0,224,158,21,0,0,160,225,5,0,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_BindingTest_got - . + 108
	.byte 0,0,159,231,88,0,139,229,16,224,155,229,116,225,158,229,0,0,94,227,0,224,158,21,0,0,160,225,88,16,155,229
	.byte 5,0,160,225,0,32,149,229,15,224,160,225,48,241,146,229
.loc 3 22 0

	.byte 16,224,155,229,156,225,158,229,0,0,94,227,0,224,158,21,0,0,160,225,5,0,160,225,64,0,139,229,0,42,159,237
	.byte 0,0,0,234,0,0,200,66,20,43,139,237,0,42,159,237,0,0,0,234,0,0,200,66,18,43,139,237,16,224,155,229
	.byte 216,225,158,229,0,0,94,227,0,224,158,21,0,0,160,225,18,43,155,237,20,59,155,237,6,15,139,226,0,15,160,227
	.byte 0,15,160,227,24,0,139,229,0,15,160,227,28,0,139,229,6,15,139,226,0,58,141,237,0,16,157,229,0,42,141,237
	.byte 0,32,157,229
bl _p_9

	.byte 6,15,139,226,8,15,139,226,24,0,155,229,32,0,139,229,28,0,155,229,36,0,139,229,16,224,155,229,60,226,158,229
	.byte 0,0,94,227,0,224,158,21,0,0,160,225,64,48,155,229,3,0,160,225,8,31,139,226,32,16,155,229,36,32,155,229
	.byte 0,48,147,229,15,224,160,225,240,240,147,229
.loc 3 23 0

	.byte 16,224,155,229,112,226,158,229,0,0,94,227,0,224,158,21,0,0,160,225,40,0,155,229,60,0,139,229,16,224,155,229
	.byte 140,226,158,229,0,0,94,227,0,224,158,21,0,0,160,225,60,16,155,229,1,0,160,225,0,16,145,229,15,224,160,225
	.byte 8,241,145,229,52,0,139,229,16,224,155,229,184,226,158,229,0,0,94,227,0,224,158,21,0,0,160,225,6,0,160,225
	.byte 56,0,139,229,16,224,155,229,212,226,158,229,0,0,94,227,0,224,158,21,0,0,160,225,56,16,155,229,1,0,160,225
	.byte 0,16,145,229,15,224,160,225,224,240,145,229,48,0,139,229,16,224,155,229,0,227,158,229,0,0,94,227,0,224,158,21
	.byte 0,0,160,225,48,16,155,229,52,32,155,229,2,0,160,225,0,224,210,229
bl _p_10
.loc 3 24 0

	.byte 16,224,155,229,40,227,158,229,0,0,94,227,0,224,158,21,0,0,160,225,16,224,155,229,60,227,158,229,0,0,94,227
	.byte 0,224,158,21,0,0,160,225,26,223,139,226,96,9,189,232,128,128,189,232

Lme_c:
.text
	.align 2
	.no_dead_strip BindingTest_ViewController_DidReceiveMemoryWarning
BindingTest_ViewController_DidReceiveMemoryWarning:
.loc 3 27 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,7,223,77,226,8,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_BindingTest_got - . + 112
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,60,224,158,229,0,0,94,227
	.byte 0,224,158,21,0,0,160,225,4,224,157,229,0,224,158,229,0,224,157,229,88,224,158,229,0,0,94,227,0,224,158,21
	.byte 0,0,160,225
.loc 3 28 0

	.byte 0,224,157,229,108,224,158,229,0,0,94,227,0,224,158,21,0,0,160,225,8,0,157,229,16,0,141,229,0,224,157,229
	.byte 136,224,158,229,0,0,94,227,0,224,158,21,0,0,160,225,16,0,157,229
bl _p_11
.loc 3 30 0

	.byte 0,224,157,229,164,224,158,229,0,0,94,227,0,224,158,21,0,0,160,225,0,224,157,229,184,224,158,229,0,0,94,227
	.byte 0,224,158,21,0,0,160,225,7,223,141,226,0,1,189,232,128,128,189,232

Lme_d:
.text
	.align 2
	.no_dead_strip BindingTest_ViewController_ReleaseDesignerOutlets
BindingTest_ViewController_ReleaseDesignerOutlets:
.file 4 "/Users/wmartin/Documents/Xamarin/Projects/BindingTest/BindingTest/ViewController.designer.cs"
.loc 4 14 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,8,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_BindingTest_got - . + 116
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,60,224,158,229,0,0,94,227
	.byte 0,224,158,21,0,0,160,225,4,224,157,229,0,224,158,229,0,224,157,229,88,224,158,229,0,0,94,227,0,224,158,21
	.byte 0,0,160,225
.loc 4 15 0

	.byte 0,224,157,229,108,224,158,229,0,0,94,227,0,224,158,21,0,0,160,225,0,224,157,229,128,224,158,229,0,0,94,227
	.byte 0,224,158,21,0,0,160,225,5,223,141,226,0,1,189,232,128,128,189,232

Lme_e:
.text
	.align 3
jit_code_end:

	.byte 0,0,0,0
.text
	.align 3
method_addresses:
	.no_dead_strip method_addresses
bl BindingTest_Application__ctor
bl BindingTest_Application_Main_string__
bl BindingTest_AppDelegate__ctor
bl BindingTest_AppDelegate_get_Window
bl BindingTest_AppDelegate_set_Window_UIKit_UIWindow
bl BindingTest_AppDelegate_FinishedLaunching_UIKit_UIApplication_Foundation_NSDictionary
bl BindingTest_AppDelegate_OnResignActivation_UIKit_UIApplication
bl BindingTest_AppDelegate_DidEnterBackground_UIKit_UIApplication
bl BindingTest_AppDelegate_WillEnterForeground_UIKit_UIApplication
bl BindingTest_AppDelegate_OnActivated_UIKit_UIApplication
bl BindingTest_AppDelegate_WillTerminate_UIKit_UIApplication
bl BindingTest_ViewController__ctor_intptr
bl BindingTest_ViewController_ViewDidLoad
bl BindingTest_ViewController_DidReceiveMemoryWarning
bl BindingTest_ViewController_ReleaseDesignerOutlets
bl method_addresses
method_addresses_end:

.section __TEXT, __const
	.align 3
unbox_trampolines:
unbox_trampolines_end:

	.long 0
.text
	.align 3
unbox_trampoline_addresses:

	.long 0
.section __TEXT, __const
	.align 3
unwind_info:

	.byte 31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,100,10,68,14,12,68,8,8,14,8,68,11
	.byte 31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,40,2,212,10,68,14,12,68,8,8,14,8,68,11
	.byte 31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,104,10,68,14,12,68,8,8,14,8,68,11
	.byte 35,12,13,0,68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,32,2,120,10,68,14,16,68,8,6,8,8
	.byte 14,8,68,11,31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,40,2,136,10,68,14,12,68,8,8
	.byte 14,8,68,11,31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,40,2,172,10,68,14,12,68,8,8
	.byte 14,8,68,11,31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,128,10,68,14,12,68,8,8
	.byte 14,8,68,11,31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,160,10,68,14,12,68,8,8
	.byte 14,8,68,11,50,12,13,0,68,14,8,135,2,72,14,24,133,6,134,5,136,4,139,3,142,1,68,14,128,1,68,13
	.byte 11,3,52,3,10,68,13,13,14,24,68,8,5,8,6,8,8,8,11,14,8,68,11,31,12,13,0,68,14,8,135,2
	.byte 72,14,12,136,3,142,1,68,14,40,2,180,10,68,14,12,68,8,8,14,8,68,11,31,12,13,0,68,14,8,135,2
	.byte 72,14,12,136,3,142,1,68,14,32,2,124,10,68,14,12,68,8,8,14,8,68,11

.text
	.align 4
plt:
mono_aot_BindingTest_plt:
	.no_dead_strip plt_UIKit_UIApplication_Main_string___string_string
plt_UIKit_UIApplication_Main_string___string_string:
_p_1:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_BindingTest_got - . + 132,315
	.no_dead_strip plt_UIKit_UIApplicationDelegate__ctor
plt_UIKit_UIApplicationDelegate__ctor:
_p_2:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_BindingTest_got - . + 136,320
	.no_dead_strip plt_wrapper_write_barrier_object_wbarrier_noconc_intptr
plt_wrapper_write_barrier_object_wbarrier_noconc_intptr:
_p_3:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_BindingTest_got - . + 140,325
	.no_dead_strip plt_UIKit_UIViewController__ctor_intptr
plt_UIKit_UIViewController__ctor_intptr:
_p_4:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_BindingTest_got - . + 144,332
	.no_dead_strip plt_UIKit_UIViewController_ViewDidLoad
plt_UIKit_UIViewController_ViewDidLoad:
_p_5:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_BindingTest_got - . + 148,337
	.no_dead_strip plt__jit_icall_ves_icall_object_new_specific
plt__jit_icall_ves_icall_object_new_specific:
_p_6:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_BindingTest_got - . + 152,342
	.no_dead_strip plt_JWPlayer_JWPlayerController__ctor
plt_JWPlayer_JWPlayerController__ctor:
_p_7:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_BindingTest_got - . + 156,374
	.no_dead_strip plt_JWPlayer_JWConfig__ctor
plt_JWPlayer_JWConfig__ctor:
_p_8:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_BindingTest_got - . + 160,379
	.no_dead_strip plt_CoreGraphics_CGSize__ctor_single_single
plt_CoreGraphics_CGSize__ctor_single_single:
_p_9:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_BindingTest_got - . + 164,384
	.no_dead_strip plt_UIKit_UIView_Add_UIKit_UIView
plt_UIKit_UIView_Add_UIKit_UIView:
_p_10:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_BindingTest_got - . + 168,389
	.no_dead_strip plt_UIKit_UIViewController_DidReceiveMemoryWarning
plt_UIKit_UIViewController_DidReceiveMemoryWarning:
_p_11:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_BindingTest_got - . + 172,394
plt_end:
.section __DATA, __bss
	.align 3
.lcomm mono_aot_BindingTest_got, 180
got_end:
.section __TEXT, __const
	.align 3
Lglobals_hash:

	.short 11, 0, 0, 0, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0
.data
	.align 3
globals:
	.align 2
	.long Lglobals_hash

	.long 0,0
.section __TEXT, __const
	.align 2
runtime_version:
	.asciz ""
.section __TEXT, __const
	.align 2
assembly_guid:
	.asciz "A0147463-2F3F-4F89-9A9D-59D75E9C254D"
.section __TEXT, __const
	.align 2
assembly_name:
	.asciz "BindingTest"
.data
	.align 3
_mono_aot_file_info:

	.long 137,0
	.align 2
	.long mono_aot_BindingTest_got
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long jit_code_start
	.align 2
	.long jit_code_end
	.align 2
	.long method_addresses
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long mem_end
	.align 2
	.long assembly_guid
	.align 2
	.long runtime_version
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long globals
	.align 2
	.long assembly_name
	.align 2
	.long plt
	.align 2
	.long plt_end
	.align 2
	.long unwind_info
	.align 2
	.long unbox_trampolines
	.align 2
	.long unbox_trampolines_end
	.align 2
	.long unbox_trampoline_addresses

	.long 33,180,12,16,70,923871743,0,1842
	.long 128,4,4,10,0,14,2568,720
	.long 392,200,0,312,360,248,0,192
	.long 48,0,0,0,0,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0
	.byte 123,126,134,62,192,250,194,255,145,96,238,44,161,118,213,122
	.globl _mono_aot_module_BindingTest_info
	.align 2
_mono_aot_module_BindingTest_info:
	.align 2
	.long _mono_aot_file_info
.section __DWARF, __debug_info,regular,debug
LTDIE_1:

	.byte 17
	.asciz "System_Object"

	.byte 8,7
	.asciz "System_Object"

LDIFF_SYM3=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM3
LTDIE_1_POINTER:

	.byte 13
LDIFF_SYM4=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM4
LTDIE_1_REFERENCE:

	.byte 14
LDIFF_SYM5=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM5
LTDIE_0:

	.byte 5
	.asciz "BindingTest_Application"

	.byte 8,16
LDIFF_SYM6=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM6
	.byte 2,35,0,0,7
	.asciz "BindingTest_Application"

LDIFF_SYM7=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM7
LTDIE_0_POINTER:

	.byte 13
LDIFF_SYM8=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM8
LTDIE_0_REFERENCE:

	.byte 14
LDIFF_SYM9=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM9
	.byte 2
	.asciz "BindingTest.Application:.ctor"
	.asciz "BindingTest_Application__ctor"

	.byte 0,0
	.long BindingTest_Application__ctor
	.long Lme_0

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM10=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM10
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM11=Lfde0_end - Lfde0_start
	.long LDIFF_SYM11
Lfde0_start:

	.long 0
	.align 2
	.long BindingTest_Application__ctor

LDIFF_SYM12=Lme_0 - BindingTest_Application__ctor
	.long LDIFF_SYM12
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,100,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde0_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "BindingTest.Application:Main"
	.asciz "BindingTest_Application_Main_string__"

	.byte 1,10
	.long BindingTest_Application_Main_string__
	.long Lme_1

	.byte 2,118,16,3
	.asciz "args"

LDIFF_SYM13=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM13
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM14=Lfde1_end - Lfde1_start
	.long LDIFF_SYM14
Lfde1_start:

	.long 0
	.align 2
	.long BindingTest_Application_Main_string__

LDIFF_SYM15=Lme_1 - BindingTest_Application_Main_string__
	.long LDIFF_SYM15
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,40,2,212,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde1_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_5:

	.byte 8
	.asciz "_Flags"

	.byte 1
LDIFF_SYM16=LDIE_U1 - Ldebug_info_start
	.long LDIFF_SYM16
	.byte 9
	.asciz "Disposed"

	.byte 1,9
	.asciz "NativeRef"

	.byte 2,9
	.asciz "IsDirectBinding"

	.byte 4,9
	.asciz "RegisteredToggleRef"

	.byte 8,9
	.asciz "InFinalizerQueue"

	.byte 16,9
	.asciz "HasManagedRef"

	.byte 32,0,7
	.asciz "_Flags"

LDIFF_SYM17=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM17
LTDIE_5_POINTER:

	.byte 13
LDIFF_SYM18=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM18
LTDIE_5_REFERENCE:

	.byte 14
LDIFF_SYM19=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM19
LTDIE_4:

	.byte 5
	.asciz "Foundation_NSObject"

	.byte 20,16
LDIFF_SYM20=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM20
	.byte 2,35,0,6
	.asciz "handle"

LDIFF_SYM21=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM21
	.byte 2,35,8,6
	.asciz "class_handle"

LDIFF_SYM22=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM22
	.byte 2,35,12,6
	.asciz "flags"

LDIFF_SYM23=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM23
	.byte 2,35,16,0,7
	.asciz "Foundation_NSObject"

LDIFF_SYM24=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM24
LTDIE_4_POINTER:

	.byte 13
LDIFF_SYM25=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM25
LTDIE_4_REFERENCE:

	.byte 14
LDIFF_SYM26=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM26
LTDIE_3:

	.byte 5
	.asciz "UIKit_UIApplicationDelegate"

	.byte 20,16
LDIFF_SYM27=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM27
	.byte 2,35,0,0,7
	.asciz "UIKit_UIApplicationDelegate"

LDIFF_SYM28=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM28
LTDIE_3_POINTER:

	.byte 13
LDIFF_SYM29=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM29
LTDIE_3_REFERENCE:

	.byte 14
LDIFF_SYM30=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM30
LTDIE_8:

	.byte 5
	.asciz "UIKit_UIResponder"

	.byte 20,16
LDIFF_SYM31=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM31
	.byte 2,35,0,0,7
	.asciz "UIKit_UIResponder"

LDIFF_SYM32=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM32
LTDIE_8_POINTER:

	.byte 13
LDIFF_SYM33=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM33
LTDIE_8_REFERENCE:

	.byte 14
LDIFF_SYM34=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM34
LTDIE_7:

	.byte 5
	.asciz "UIKit_UIView"

	.byte 24,16
LDIFF_SYM35=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM35
	.byte 2,35,0,6
	.asciz "__mt_PreferredFocusedView_var"

LDIFF_SYM36=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM36
	.byte 2,35,20,0,7
	.asciz "UIKit_UIView"

LDIFF_SYM37=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM37
LTDIE_7_POINTER:

	.byte 13
LDIFF_SYM38=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM38
LTDIE_7_REFERENCE:

	.byte 14
LDIFF_SYM39=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM39
LTDIE_6:

	.byte 5
	.asciz "UIKit_UIWindow"

	.byte 24,16
LDIFF_SYM40=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM40
	.byte 2,35,0,0,7
	.asciz "UIKit_UIWindow"

LDIFF_SYM41=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM41
LTDIE_6_POINTER:

	.byte 13
LDIFF_SYM42=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM42
LTDIE_6_REFERENCE:

	.byte 14
LDIFF_SYM43=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM43
LTDIE_2:

	.byte 5
	.asciz "BindingTest_AppDelegate"

	.byte 24,16
LDIFF_SYM44=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM44
	.byte 2,35,0,6
	.asciz "<Window>k__BackingField"

LDIFF_SYM45=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM45
	.byte 2,35,20,0,7
	.asciz "BindingTest_AppDelegate"

LDIFF_SYM46=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM46
LTDIE_2_POINTER:

	.byte 13
LDIFF_SYM47=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM47
LTDIE_2_REFERENCE:

	.byte 14
LDIFF_SYM48=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM48
	.byte 2
	.asciz "BindingTest.AppDelegate:.ctor"
	.asciz "BindingTest_AppDelegate__ctor"

	.byte 0,0
	.long BindingTest_AppDelegate__ctor
	.long Lme_2

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM49=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM49
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM50=Lfde2_end - Lfde2_start
	.long LDIFF_SYM50
Lfde2_start:

	.long 0
	.align 2
	.long BindingTest_AppDelegate__ctor

LDIFF_SYM51=Lme_2 - BindingTest_AppDelegate__ctor
	.long LDIFF_SYM51
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,104,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde2_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "BindingTest.AppDelegate:get_Window"
	.asciz "BindingTest_AppDelegate_get_Window"

	.byte 2,15
	.long BindingTest_AppDelegate_get_Window
	.long Lme_3

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM52=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM52
	.byte 2,125,8,11
	.asciz "V_0"

LDIFF_SYM53=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM53
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM54=Lfde3_end - Lfde3_start
	.long LDIFF_SYM54
Lfde3_start:

	.long 0
	.align 2
	.long BindingTest_AppDelegate_get_Window

LDIFF_SYM55=Lme_3 - BindingTest_AppDelegate_get_Window
	.long LDIFF_SYM55
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,32,2,120,10,68,14,16,68,8,6,8,8,14,8,68,11
	.align 2
Lfde3_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "BindingTest.AppDelegate:set_Window"
	.asciz "BindingTest_AppDelegate_set_Window_UIKit_UIWindow"

	.byte 2,16
	.long BindingTest_AppDelegate_set_Window_UIKit_UIWindow
	.long Lme_4

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM56=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM56
	.byte 2,125,8,3
	.asciz "value"

LDIFF_SYM57=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM57
	.byte 2,125,12,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM58=Lfde4_end - Lfde4_start
	.long LDIFF_SYM58
Lfde4_start:

	.long 0
	.align 2
	.long BindingTest_AppDelegate_set_Window_UIKit_UIWindow

LDIFF_SYM59=Lme_4 - BindingTest_AppDelegate_set_Window_UIKit_UIWindow
	.long LDIFF_SYM59
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,40,2,136,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde4_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_9:

	.byte 5
	.asciz "UIKit_UIApplication"

	.byte 20,16
LDIFF_SYM60=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM60
	.byte 2,35,0,0,7
	.asciz "UIKit_UIApplication"

LDIFF_SYM61=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM61
LTDIE_9_POINTER:

	.byte 13
LDIFF_SYM62=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM62
LTDIE_9_REFERENCE:

	.byte 14
LDIFF_SYM63=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM63
LTDIE_10:

	.byte 5
	.asciz "Foundation_NSDictionary"

	.byte 20,16
LDIFF_SYM64=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM64
	.byte 2,35,0,0,7
	.asciz "Foundation_NSDictionary"

LDIFF_SYM65=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM65
LTDIE_10_POINTER:

	.byte 13
LDIFF_SYM66=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM66
LTDIE_10_REFERENCE:

	.byte 14
LDIFF_SYM67=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM67
LTDIE_12:

	.byte 5
	.asciz "System_ValueType"

	.byte 8,16
LDIFF_SYM68=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM68
	.byte 2,35,0,0,7
	.asciz "System_ValueType"

LDIFF_SYM69=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM69
LTDIE_12_POINTER:

	.byte 13
LDIFF_SYM70=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM70
LTDIE_12_REFERENCE:

	.byte 14
LDIFF_SYM71=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM71
LTDIE_11:

	.byte 5
	.asciz "System_Boolean"

	.byte 9,16
LDIFF_SYM72=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM72
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM73=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM73
	.byte 2,35,8,0,7
	.asciz "System_Boolean"

LDIFF_SYM74=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM74
LTDIE_11_POINTER:

	.byte 13
LDIFF_SYM75=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM75
LTDIE_11_REFERENCE:

	.byte 14
LDIFF_SYM76=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM76
	.byte 2
	.asciz "BindingTest.AppDelegate:FinishedLaunching"
	.asciz "BindingTest_AppDelegate_FinishedLaunching_UIKit_UIApplication_Foundation_NSDictionary"

	.byte 2,20
	.long BindingTest_AppDelegate_FinishedLaunching_UIKit_UIApplication_Foundation_NSDictionary
	.long Lme_5

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM77=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM77
	.byte 2,125,12,3
	.asciz "application"

LDIFF_SYM78=LTDIE_9_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM78
	.byte 2,125,16,3
	.asciz "launchOptions"

LDIFF_SYM79=LTDIE_10_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM79
	.byte 2,125,20,11
	.asciz "V_0"

LDIFF_SYM80=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM80
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM81=Lfde5_end - Lfde5_start
	.long LDIFF_SYM81
Lfde5_start:

	.long 0
	.align 2
	.long BindingTest_AppDelegate_FinishedLaunching_UIKit_UIApplication_Foundation_NSDictionary

LDIFF_SYM82=Lme_5 - BindingTest_AppDelegate_FinishedLaunching_UIKit_UIApplication_Foundation_NSDictionary
	.long LDIFF_SYM82
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,40,2,172,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde5_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "BindingTest.AppDelegate:OnResignActivation"
	.asciz "BindingTest_AppDelegate_OnResignActivation_UIKit_UIApplication"

	.byte 2,28
	.long BindingTest_AppDelegate_OnResignActivation_UIKit_UIApplication
	.long Lme_6

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM83=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM83
	.byte 2,125,8,3
	.asciz "application"

LDIFF_SYM84=LTDIE_9_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM84
	.byte 2,125,12,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM85=Lfde6_end - Lfde6_start
	.long LDIFF_SYM85
Lfde6_start:

	.long 0
	.align 2
	.long BindingTest_AppDelegate_OnResignActivation_UIKit_UIApplication

LDIFF_SYM86=Lme_6 - BindingTest_AppDelegate_OnResignActivation_UIKit_UIApplication
	.long LDIFF_SYM86
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,128,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde6_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "BindingTest.AppDelegate:DidEnterBackground"
	.asciz "BindingTest_AppDelegate_DidEnterBackground_UIKit_UIApplication"

	.byte 2,36
	.long BindingTest_AppDelegate_DidEnterBackground_UIKit_UIApplication
	.long Lme_7

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM87=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM87
	.byte 2,125,8,3
	.asciz "application"

LDIFF_SYM88=LTDIE_9_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM88
	.byte 2,125,12,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM89=Lfde7_end - Lfde7_start
	.long LDIFF_SYM89
Lfde7_start:

	.long 0
	.align 2
	.long BindingTest_AppDelegate_DidEnterBackground_UIKit_UIApplication

LDIFF_SYM90=Lme_7 - BindingTest_AppDelegate_DidEnterBackground_UIKit_UIApplication
	.long LDIFF_SYM90
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,128,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde7_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "BindingTest.AppDelegate:WillEnterForeground"
	.asciz "BindingTest_AppDelegate_WillEnterForeground_UIKit_UIApplication"

	.byte 2,42
	.long BindingTest_AppDelegate_WillEnterForeground_UIKit_UIApplication
	.long Lme_8

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM91=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM91
	.byte 2,125,8,3
	.asciz "application"

LDIFF_SYM92=LTDIE_9_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM92
	.byte 2,125,12,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM93=Lfde8_end - Lfde8_start
	.long LDIFF_SYM93
Lfde8_start:

	.long 0
	.align 2
	.long BindingTest_AppDelegate_WillEnterForeground_UIKit_UIApplication

LDIFF_SYM94=Lme_8 - BindingTest_AppDelegate_WillEnterForeground_UIKit_UIApplication
	.long LDIFF_SYM94
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,128,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde8_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "BindingTest.AppDelegate:OnActivated"
	.asciz "BindingTest_AppDelegate_OnActivated_UIKit_UIApplication"

	.byte 2,48
	.long BindingTest_AppDelegate_OnActivated_UIKit_UIApplication
	.long Lme_9

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM95=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM95
	.byte 2,125,8,3
	.asciz "application"

LDIFF_SYM96=LTDIE_9_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM96
	.byte 2,125,12,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM97=Lfde9_end - Lfde9_start
	.long LDIFF_SYM97
Lfde9_start:

	.long 0
	.align 2
	.long BindingTest_AppDelegate_OnActivated_UIKit_UIApplication

LDIFF_SYM98=Lme_9 - BindingTest_AppDelegate_OnActivated_UIKit_UIApplication
	.long LDIFF_SYM98
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,128,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde9_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "BindingTest.AppDelegate:WillTerminate"
	.asciz "BindingTest_AppDelegate_WillTerminate_UIKit_UIApplication"

	.byte 2,54
	.long BindingTest_AppDelegate_WillTerminate_UIKit_UIApplication
	.long Lme_a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM99=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM99
	.byte 2,125,8,3
	.asciz "application"

LDIFF_SYM100=LTDIE_9_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM100
	.byte 2,125,12,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM101=Lfde10_end - Lfde10_start
	.long LDIFF_SYM101
Lfde10_start:

	.long 0
	.align 2
	.long BindingTest_AppDelegate_WillTerminate_UIKit_UIApplication

LDIFF_SYM102=Lme_a - BindingTest_AppDelegate_WillTerminate_UIKit_UIApplication
	.long LDIFF_SYM102
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,128,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde10_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_14:

	.byte 5
	.asciz "UIKit_UIViewController"

	.byte 24,16
LDIFF_SYM103=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM103
	.byte 2,35,0,6
	.asciz "__mt_PreferredFocusedView_var"

LDIFF_SYM104=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM104
	.byte 2,35,20,0,7
	.asciz "UIKit_UIViewController"

LDIFF_SYM105=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM105
LTDIE_14_POINTER:

	.byte 13
LDIFF_SYM106=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM106
LTDIE_14_REFERENCE:

	.byte 14
LDIFF_SYM107=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM107
LTDIE_13:

	.byte 5
	.asciz "BindingTest_ViewController"

	.byte 24,16
LDIFF_SYM108=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM108
	.byte 2,35,0,0,7
	.asciz "BindingTest_ViewController"

LDIFF_SYM109=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM109
LTDIE_13_POINTER:

	.byte 13
LDIFF_SYM110=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM110
LTDIE_13_REFERENCE:

	.byte 14
LDIFF_SYM111=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM111
	.byte 2
	.asciz "BindingTest.ViewController:.ctor"
	.asciz "BindingTest_ViewController__ctor_intptr"

	.byte 3,9
	.long BindingTest_ViewController__ctor_intptr
	.long Lme_b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM112=LTDIE_13_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM112
	.byte 2,125,8,3
	.asciz "handle"

LDIFF_SYM113=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM113
	.byte 2,125,12,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM114=Lfde11_end - Lfde11_start
	.long LDIFF_SYM114
Lfde11_start:

	.long 0
	.align 2
	.long BindingTest_ViewController__ctor_intptr

LDIFF_SYM115=Lme_b - BindingTest_ViewController__ctor_intptr
	.long LDIFF_SYM115
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,160,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde11_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_15:

	.byte 5
	.asciz "JWPlayer_JWPlayerController"

	.byte 28,16
LDIFF_SYM116=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM116
	.byte 2,35,0,6
	.asciz "__mt_DrmDataSource_var"

LDIFF_SYM117=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM117
	.byte 2,35,20,6
	.asciz "__mt_WeakDelegate_var"

LDIFF_SYM118=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM118
	.byte 2,35,24,0,7
	.asciz "JWPlayer_JWPlayerController"

LDIFF_SYM119=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM119
LTDIE_15_POINTER:

	.byte 13
LDIFF_SYM120=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM120
LTDIE_15_REFERENCE:

	.byte 14
LDIFF_SYM121=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM121
LTDIE_16:

	.byte 5
	.asciz "JWPlayer_JWConfig"

	.byte 28,16
LDIFF_SYM122=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM122
	.byte 2,35,0,6
	.asciz "__mt_AssetOptions_var"

LDIFF_SYM123=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM123
	.byte 2,35,20,6
	.asciz "__mt_RelatedConfig_var"

LDIFF_SYM124=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM124
	.byte 2,35,24,0,7
	.asciz "JWPlayer_JWConfig"

LDIFF_SYM125=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM125
LTDIE_16_POINTER:

	.byte 13
LDIFF_SYM126=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM126
LTDIE_16_REFERENCE:

	.byte 14
LDIFF_SYM127=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM127
	.byte 2
	.asciz "BindingTest.ViewController:ViewDidLoad"
	.asciz "BindingTest_ViewController_ViewDidLoad"

	.byte 3,15
	.long BindingTest_ViewController_ViewDidLoad
	.long Lme_c

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM128=LTDIE_13_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM128
	.byte 2,123,40,11
	.asciz "player"

LDIFF_SYM129=LTDIE_15_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM129
	.byte 1,86,11
	.asciz "config"

LDIFF_SYM130=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM130
	.byte 1,85,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM131=Lfde12_end - Lfde12_start
	.long LDIFF_SYM131
Lfde12_start:

	.long 0
	.align 2
	.long BindingTest_ViewController_ViewDidLoad

LDIFF_SYM132=Lme_c - BindingTest_ViewController_ViewDidLoad
	.long LDIFF_SYM132
	.byte 68,14,8,135,2,72,14,24,133,6,134,5,136,4,139,3,142,1,68,14,128,1,68,13,11,3,52,3,10,68,13,13
	.byte 14,24,68,8,5,8,6,8,8,8,11,14,8,68,11
	.align 2
Lfde12_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "BindingTest.ViewController:DidReceiveMemoryWarning"
	.asciz "BindingTest_ViewController_DidReceiveMemoryWarning"

	.byte 3,27
	.long BindingTest_ViewController_DidReceiveMemoryWarning
	.long Lme_d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM133=LTDIE_13_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM133
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM134=Lfde13_end - Lfde13_start
	.long LDIFF_SYM134
Lfde13_start:

	.long 0
	.align 2
	.long BindingTest_ViewController_DidReceiveMemoryWarning

LDIFF_SYM135=Lme_d - BindingTest_ViewController_DidReceiveMemoryWarning
	.long LDIFF_SYM135
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,40,2,180,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde13_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "BindingTest.ViewController:ReleaseDesignerOutlets"
	.asciz "BindingTest_ViewController_ReleaseDesignerOutlets"

	.byte 4,14
	.long BindingTest_ViewController_ReleaseDesignerOutlets
	.long Lme_e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM136=LTDIE_13_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM136
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM137=Lfde14_end - Lfde14_start
	.long LDIFF_SYM137
Lfde14_start:

	.long 0
	.align 2
	.long BindingTest_ViewController_ReleaseDesignerOutlets

LDIFF_SYM138=Lme_e - BindingTest_ViewController_ReleaseDesignerOutlets
	.long LDIFF_SYM138
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,124,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde14_end:

.section __DWARF, __debug_info,regular,debug

	.byte 0
Ldebug_info_end:
.text
	.align 3
mem_end:
