#pragma clang diagnostic ignored "-Wdeprecated-declarations"
#pragma clang diagnostic ignored "-Wtypedef-redefinition"
#pragma clang diagnostic ignored "-Wobjc-designated-initializers"
#define DEBUG 1
#include <stdarg.h>
#include <xamarin/xamarin.h>
#include <objc/objc.h>
#include <objc/runtime.h>
#include <objc/message.h>
#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#import <QuartzCore/QuartzCore.h>
#import <QuartzCore/CAEmitterBehavior.h>
#import <CloudKit/CloudKit.h>
#import <CoreGraphics/CoreGraphics.h>

@protocol CALayerDelegate;
@class __MonoMac_NSActionDispatcher;
@class __MonoMac_NSAsyncActionDispatcher;
@class AppDelegate;
@class ViewController;
@class __NSObject_Disposer;
@class JWAdBreak;
@class JWAdConfig;
@class JWCaptionStyling;
@class JWCastController;
@protocol JWCastingDelegate;
@class JWCastingDevice;
@class JWConfig;
@protocol JWDrmDataSource;
@class JWPlayerController;
@protocol JWPlayerDelegate;
@class JWPlaylistItem;
@class JWRelatedConfig;
@class JWSource;
@class JWTrack;

