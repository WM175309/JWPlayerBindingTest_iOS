using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;


namespace JWPlayer
{
	//// @interface JWAdBreak : NSObject
	//[BaseType(typeof(NSObject))]
	//interface JWAdBreak
	//{
	//	[Export("offset", ArgumentSemantic.Retain)]
	//	string Offset { get; set; }

	//	[Export("tag", ArgumentSemantic.Retain)]
	//	string Tag { get; set; }

	//	[Export("tags", ArgumentSemantic.Retain)]
	//	NSObject[] Tags { get; set; }

	//	[Export("nonLinear")]
	//	bool NonLinear { get; set; }

	//	[Static]
	//	[Export("adBreakWithTag:offset:nonLinear:")]
	//	JWAdBreak AdBreakWithTag(string tag, string offset, bool nonLinear);

	//	[Static]
	//	[Export("adBreakWithTags:offset:nonLinear:")]
	//	JWAdBreak AdBreakWithTags(NSObject[] tags, string offset, bool nonLinear);

	//	[Static]
	//	[Export("adBreakWithTag:offset:")]
	//	JWAdBreak AdBreakWithTag(string tag, string offset);

	//	[Static]
	//	[Export("adBreakWithTags:offset:")]
	//	JWAdBreak AdBreakWithTags(NSObject[] tags, string offset);

	//	[Export("initWithTags:offset:")]
	//	IntPtr Constructor(NSObject[] tags, string offset);
	//}

	//[BaseType(typeof(NSObject))]
	//interface JWAdConfig
	//{
	//	[Export("adMessage", ArgumentSemantic.Retain)]
	//	string AdMessage { get; set; }

	//	[Export("skipMessage", ArgumentSemantic.Retain)]
	//	string SkipMessage { get; set; }

	//	[Export("skipText", ArgumentSemantic.Retain)]
	//	string SkipText { get; set; }

	//	[Export("skipOffset")]
	//	nint SkipOffset { get; set; }

	//	[Export("adClient", ArgumentSemantic.Assign)]
	//	JWAdClient AdClient { get; set; }
	//}

	//[BaseType(typeof(NSObject))]
	//interface JWCaptionStyling
	//{
	//	[Export("fontColor", ArgumentSemantic.Retain)]
	//	UIColor FontColor { get; set; }

	//	[Export("windowColor", ArgumentSemantic.Retain)]
	//	UIColor WindowColor { get; set; }

	//	[Export("backgroundColor", ArgumentSemantic.Retain)]
	//	UIColor BackgroundColor { get; set; }

	//	[Export("font", ArgumentSemantic.Retain)]
	//	UIFont Font { get; set; }

	//	[Export("edgeStyle", ArgumentSemantic.Assign)]
	//	JWEdgeStyle EdgeStyle { get; set; }
	//}

	//[Protocol, Model]
	//[BaseType(typeof(NSObject))]
	//interface JWCastingDelegate
	//{
	//	[Abstract]
	//	[Export("onCastingDevicesAvailable:")]
	//	void OnCastingDevicesAvailable(JWCastingDevice[] devices);

	//	[Export("onConnectedToCastingDevice:")]
	//	void OnConnectedToCastingDevice(JWCastingDevice device);

	//	[Export("onDisconnectedFromCastingDevice:")]
	//	void OnDisconnectedFromCastingDevice(NSError error);

	//	[Export("onConnectionTemporarilySuspended")]
	//	void OnConnectionTemporarilySuspended();

	//	[Export("onConnectionRecovered")]
	//	void OnConnectionRecovered();

	//	[Export("onConnectionFailed:")]
	//	void OnConnectionFailed(NSError error);

	//	[Export("onCasting")]
	//	void OnCasting();

	//	[Export("onCastingFailed:")]
	//	void OnCastingFailed(NSError error);

	//	[Export("onCastingEnded:")]
	//	void OnCastingEnded(NSError error);
	//}

	//// @interface JWCastingDevice : NSObject
	//[BaseType(typeof(NSObject))]
	//[DisableDefaultCtor]
	//interface JWCastingDevice
	//{
	//	// @property (readonly, nonatomic) JWCastingService castingService;
	//	[Export("castingService")]
	//	JWCastingService CastingService { get; }

	//	// @property (readonly, nonatomic) NSString * name;
	//	[Export("name")]
	//	string Name { get; }

	//	// @property (readonly, nonatomic) NSString * identifier;
	//	[Export("identifier")]
	//	string Identifier { get; }
	//}

	//// @interface JWCastController : NSObject
	//[BaseType(typeof(NSObject))]
	//[DisableDefaultCtor]
	//interface JWCastController
	//{
	//	// @property (nonatomic, weak) JWPlayerController * player;
	//	[Export("player", ArgumentSemantic.Weak)]
	//	JWPlayerController Player { get; set; }

	//	// @property (nonatomic) NSString * chromeCastReceiverAppID;
	//	[Export("chromeCastReceiverAppID")]
	//	string ChromeCastReceiverAppID { get; set; }

	//	[Wrap("WeakDelegate")]
	//	JWCastingDelegate Delegate { get; set; }

	//	// @property (nonatomic, weak) id<JWCastingDelegate> delegate;
	//	[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
	//	NSObject WeakDelegate { get; set; }

	//	// @property (readonly, nonatomic) JWCastingDevice * connectedDevice;
	//	[Export("connectedDevice")]
	//	JWCastingDevice ConnectedDevice { get; }

	//	// @property (readonly, nonatomic) NSArray * availableDevices;
	//	[Export("availableDevices")]
	//	NSObject[] AvailableDevices { get; }

	//	// -(instancetype)initWithPlayer:(JWPlayerController *)player;
	//	[Export("initWithPlayer:")]
	//	IntPtr Constructor(JWPlayerController player);

	//	// -(void)scanForDevices;
	//	[Export("scanForDevices")]
	//	void ScanForDevices();

	//	// -(void)connectToDevice:(JWCastingDevice *)device;
	//	[Export("connectToDevice:")]
	//	void ConnectToDevice(JWCastingDevice device);

	//	// -(void)disconnect;
	//	[Export("disconnect")]
	//	void Disconnect();

	//	// -(void)cast;
	//	[Export("cast")]
	//	void Cast();

	//	// -(void)stopCasting;
	//	[Export("stopCasting")]
	//	void StopCasting();
	//}

	//// @interface JWTrack : NSObject
	//[BaseType(typeof(NSObject))]
	//interface JWTrack
	//{
	//	// @property (retain, nonatomic) NSString * file;
	//	[Export("file", ArgumentSemantic.Retain)]
	//	string File { get; set; }

	//	// @property (retain, nonatomic) NSString * label;
	//	[Export("label", ArgumentSemantic.Retain)]
	//	string Label { get; set; }

	//	// @property (retain, nonatomic) NSString * kind;
	//	[Export("kind", ArgumentSemantic.Retain)]
	//	string Kind { get; set; }

	//	// @property (nonatomic) BOOL defaultValue;
	//	[Export("defaultValue")]
	//	bool DefaultValue { get; set; }

	//	// +(instancetype)trackWithFile:(NSString *)file label:(NSString *)label;
	//	[Static]
	//	[Export("trackWithFile:label:")]
	//	JWTrack TrackWithFile(string file, string label);

	//	// +(instancetype)trackWithFile:(NSString *)file label:(NSString *)label isDefault:(BOOL)def;
	//	[Static]
	//	[Export("trackWithFile:label:isDefault:")]
	//	JWTrack TrackWithFile(string file, string label, bool def);

	//	// -(instancetype)initWithFile:(NSString *)file label:(NSString *)label;
	//	[Export("initWithFile:label:")]
	//	IntPtr Constructor(string file, string label);

	//	// -(instancetype)initWithFile:(NSString *)file label:(NSString *)label isDefault:(BOOL)def;
	//	[Export("initWithFile:label:isDefault:")]
	//	IntPtr Constructor(string file, string label, bool def);
	//}

	// @interface JWSource : NSObject
	[BaseType(typeof(NSObject))]
	interface JWSource
	{
		// @property (retain, nonatomic) NSString * file;
		[Export("file", ArgumentSemantic.Retain)]
		string File { get; set; }

		// @property (retain, nonatomic) NSString * label;
		[Export("label", ArgumentSemantic.Retain)]
		string Label { get; set; }

		// @property (nonatomic) BOOL defaultQuality;
		[Export("defaultQuality")]
		bool DefaultQuality { get; set; }

		// @property (nonatomic) NSDictionary * assetOptions;
		[Export("assetOptions", ArgumentSemantic.Assign)]
		NSDictionary AssetOptions { get; set; }

		// +(instancetype)sourceWithFile:(NSString *)file label:(NSString *)label;
		[Static]
		[Export("sourceWithFile:label:")]
		JWSource SourceWithFile(string file, string label);

		// +(instancetype)sourceWithFile:(NSString *)file label:(NSString *)label isDefault:(BOOL)defaultQuality;
		[Static]
		[Export("sourceWithFile:label:isDefault:")]
		JWSource SourceWithFile(string file, string label, bool defaultQuality);

		// -(instancetype)initWithFile:(NSString *)file label:(NSString *)label isDefault:(BOOL)defaultQuality;
		[Export("initWithFile:label:isDefault:")]
		IntPtr Constructor(string file, string label, bool defaultQuality);
	}

	//// @interface JWPlaylistItem : NSObject
	//[BaseType(typeof(NSObject))]
	//interface JWPlaylistItem
	//{
	//	// @property (retain, nonatomic) NSArray * sources;
	//	[Export("sources", ArgumentSemantic.Retain)]
	//	NSObject[] Sources { get; set; }

	//	// @property (retain, nonatomic) NSString * file;
	//	[Export("file", ArgumentSemantic.Retain)]
	//	string File { get; set; }

	//	// @property (retain, nonatomic) NSString * image;
	//	[Export("image", ArgumentSemantic.Retain)]
	//	string Image { get; set; }

	//	// @property (retain, nonatomic) NSString * title;
	//	[Export("title", ArgumentSemantic.Retain)]
	//	string Title { get; set; }

	//	// @property (nonatomic) NSDictionary * assetOptions;
	//	[Export("assetOptions", ArgumentSemantic.Assign)]
	//	NSDictionary AssetOptions { get; set; }

	//	// @property (retain, nonatomic) NSArray * adSchedule;
	//	[Export("adSchedule", ArgumentSemantic.Retain)]
	//	NSObject[] AdSchedule { get; set; }

	//	// @property (retain, nonatomic) NSArray * tracks;
	//	[Export("tracks", ArgumentSemantic.Retain)]
	//	NSObject[] Tracks { get; set; }

	//	// @property (retain, nonatomic) NSString * desc;
	//	[Export("desc", ArgumentSemantic.Retain)]
	//	string Desc { get; set; }

	//	// @property (nonatomic) NSString * mediaId;
	//	[Export("mediaId")]
	//	string MediaId { get; set; }

	//	// +(instancetype)playlistItemWithConfig:(JWConfig *)config;
	//	[Static]
	//	[Export("playlistItemWithConfig:")]
	//	JWPlaylistItem PlaylistItemWithConfig(JWConfig config);
	//}

	//// @interface JWRelatedConfig : NSObject
	//[BaseType(typeof(NSObject))]
	//interface JWRelatedConfig
	//{
	//	// @property (nonatomic) NSString * file;
	//	[Export("file")]
	//	string File { get; set; }

	//	// @property (nonatomic) JWRelatedCompleteAction onComplete;
	//	[Export("onComplete", ArgumentSemantic.Assign)]
	//	JWRelatedCompleteAction OnComplete { get; set; }

	//	// @property (nonatomic) NSString * heading;
	//	[Export("heading")]
	//	string Heading { get; set; }

	//	// @property (nonatomic) NSInteger autoplayTimer;
	//	[Export("autoplayTimer")]
	//	nint AutoplayTimer { get; set; }

	//	// @property (nonatomic) NSString * autoplayMessage;
	//	[Export("autoplayMessage")]
	//	string AutoplayMessage { get; set; }
	//}

	// @interface JWConfig : NSObject
	[BaseType(typeof(NSObject))]
	interface JWConfig
	{
		// @property (retain, nonatomic) JWCaptionStyling * captionStyling;
		[Export("captionStyling", ArgumentSemantic.Retain)]
		JWCaptionStyling CaptionStyling { get; set; }

		// @property (retain, nonatomic) NSString * file;
		[Export("file", ArgumentSemantic.Retain)]
		string File { get; set; }

		// @property (retain, nonatomic) NSArray * sources;
		[Export("sources", ArgumentSemantic.Retain)]
		NSObject[] Sources { get; set; }

		// @property (retain, nonatomic) NSArray * playlist;
		[Export("playlist", ArgumentSemantic.Retain)]
		NSObject[] Playlist { get; set; }

		// @property (retain, nonatomic) NSString * title;
		[Export("title", ArgumentSemantic.Retain)]
		string Title { get; set; }

		// @property (retain, nonatomic) NSString * image;
		[Export("image", ArgumentSemantic.Retain)]
		string Image { get; set; }

		// @property (nonatomic) NSDictionary * assetOptions;
		[Export("assetOptions", ArgumentSemantic.Assign)]
		NSDictionary AssetOptions { get; set; }

		// @property (retain, nonatomic) UIImage * offlinePoster;
		[Export("offlinePoster", ArgumentSemantic.Retain)]
		UIImage OfflinePoster { get; set; }

		// @property (retain, nonatomic) NSString * offlineMessage;
		[Export("offlineMessage", ArgumentSemantic.Retain)]
		string OfflineMessage { get; set; }

		// @property (nonatomic) CGSize size;
		[Export("size", ArgumentSemantic.Assign)]
		CGSize Size { get; set; }

		// @property (retain, nonatomic) JWAdConfig * adConfig;
		[Export("adConfig", ArgumentSemantic.Retain)]
		JWAdConfig AdConfig { get; set; }

		// @property (nonatomic) JWRelatedConfig * relatedConfig;
		[Export("relatedConfig", ArgumentSemantic.Assign)]
		JWRelatedConfig RelatedConfig { get; set; }

		// @property (nonatomic) BOOL controls;
		[Export("controls")]
		bool Controls { get; set; }

		// @property (nonatomic) BOOL repeat;
		[Export("repeat")]
		bool Repeat { get; set; }

		// @property (nonatomic) BOOL autostart;
		[Export("autostart")]
		bool Autostart { get; set; }

		// @property (retain, nonatomic) NSArray * adSchedule;
		[Export("adSchedule", ArgumentSemantic.Retain)]
		NSObject[] AdSchedule { get; set; }

		// @property (retain, nonatomic) NSString * adVmap;
		[Export("adVmap", ArgumentSemantic.Retain)]
		string AdVmap { get; set; }

		// @property (nonatomic) JWPremiumSkin premiumSkin;
		[Export("premiumSkin", ArgumentSemantic.Assign)]
		JWPremiumSkin PremiumSkin { get; set; }

		// @property (retain, nonatomic) NSString * cssSkin;
		[Export("cssSkin", ArgumentSemantic.Retain)]
		string CssSkin { get; set; }

		// @property (retain, nonatomic) NSArray * tracks;
		[Export("tracks", ArgumentSemantic.Retain)]
		NSObject[] Tracks { get; set; }

		// @property (nonatomic) JWStretching stretch;
		[Export("stretch", ArgumentSemantic.Assign)]
		JWStretching Stretch { get; set; }

		// +(instancetype)configWithContentURL:(NSString *)contentUrl;
		[Static]
		[Export("configWithContentURL:")]
		JWConfig ConfigWithContentURL(string contentUrl);

		// -(instancetype)initWithContentUrl:(NSString *)contentUrl;
		[Export("initWithContentUrl:")]
		IntPtr Constructor(string contentUrl);
	}

	// @protocol JWDrmDataSource <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface JWDrmDataSource
	{
		// @required -(void)fetchContentIdentifierForRequest:(NSURL *)loadingRequestURL forEncryption:(JWEncryption)encryption withCompletion:(void (^)(NSData *))completion;
		[Abstract]
		[Export("fetchContentIdentifierForRequest:forEncryption:withCompletion:")]
		void FetchContentIdentifierForRequest(NSUrl loadingRequestURL, JWEncryption encryption, Action<NSData> completion);

		// @required -(void)fetchAppIdentifierForRequest:(NSURL *)loadingRequestURL forEncryption:(JWEncryption)encryption withCompletion:(void (^)(NSData *))completion;
		[Abstract]
		[Export("fetchAppIdentifierForRequest:forEncryption:withCompletion:")]
		void FetchAppIdentifierForRequest(NSUrl loadingRequestURL, JWEncryption encryption, Action<NSData> completion);

		// @required -(void)fetchContentKeyWithRequest:(NSData *)requestBytes forEncryption:(JWEncryption)encryption withCompletion:(void (^)(NSData *, NSDate *, NSString *))completion;
		[Abstract]
		[Export("fetchContentKeyWithRequest:forEncryption:withCompletion:")]
		void FetchContentKeyWithRequest(NSData requestBytes, JWEncryption encryption, Action<NSData, NSDate, NSString> completion);
	}

	// @protocol JWPlayerDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface JWPlayerDelegate
	{
		// @optional -(void)onAll;
		[Export("onAll")]
		void OnAll();

		// @optional -(void)onPlayAttempt;
		[Export("onPlayAttempt")]
		void OnPlayAttempt();

		// @optional -(void)onBeforePlay;
		[Export("onBeforePlay")]
		void OnBeforePlay();

		// @optional -(void)onFirstFrame:(NSInteger)loadTime;
		[Export("onFirstFrame:")]
		void OnFirstFrame(nint loadTime);

		// @optional -(void)onPlay __attribute__((deprecated("Use onPlay: instead")));
		[Export("onPlay")]
		void OnPlay();

		// @optional -(void)onPlay:(NSString *)oldState;
		[Export("onPlay:")]
		void OnPlay(string oldState);

		// @optional -(void)onPause __attribute__((deprecated("Use onPause: instead")));
		[Export("onPause")]
		void OnPause();

		// @optional -(void)onPause:(NSString *)oldState;
		[Export("onPause:")]
		void OnPause(string oldState);

		// @optional -(void)onIdle __attribute__((deprecated("Use onIdle: instead")));
		[Export("onIdle")]
		void OnIdle();

		// @optional -(void)onIdle:(NSString *)oldState;
		[Export("onIdle:")]
		void OnIdle(string oldState);

		// @optional -(void)onReady __attribute__((deprecated("Use onReady: instead")));
		[Export("onReady")]
		void OnReady();

		// @optional -(void)onReady:(NSInteger)setupTime;
		[Export("onReady:")]
		void OnReady(nint setupTime);

		// @optional -(void)onBeforeComplete;
		[Export("onBeforeComplete")]
		void OnBeforeComplete();

		// @optional -(void)onComplete;
		[Export("onComplete")]
		void OnComplete();

		// @optional -(void)onBuffer __attribute__((deprecated("Use onBuffer: newState: reason: instead")));
		[Export("onBuffer")]
		void OnBuffer();

		// @optional -(void)onBuffer:(NSString *)oldState reason:(NSString *)reason;
		[Export("onBuffer:reason:")]
		void OnBuffer(string oldState, string reason);

		// @optional -(void)onBufferChange:(double)buffer;
		[Export("onBufferChange:")]
		void OnBufferChange(double buffer);

		// @optional -(void)onTime:(double)position ofDuration:(double)duration;
		[Export("onTime:ofDuration:")]
		void OnTime(double position, double duration);

		// @optional -(void)onSeek:(double)offset fromPosition:(double)position;
		[Export("onSeek:fromPosition:")]
		void OnSeek(double offset, double position);

		// @optional -(void)onSeeked;
		[Export("onSeeked")]
		void OnSeeked();

		// @optional -(void)onMeta:(NSDictionary *)metaData;
		[Export("onMeta:")]
		void OnMeta(NSDictionary metaData);

		// @optional -(void)onCaptionsList:(NSArray *)tracks with:(NSInteger)selectedTrack;
		[Export("onCaptionsList:with:")]
		void OnCaptionsList(NSObject[] tracks, nint selectedTrack);

		// @optional -(void)onCaptionsChanged:(NSInteger)selectedTrack;
		[Export("onCaptionsChanged:")]
		void OnCaptionsChanged(nint selectedTrack);

		// @optional -(void)onCaptionsChange:(NSInteger)selectedTrack __attribute__((deprecated("Use onCaptionsChanged: instead")));
		[Export("onCaptionsChange:")]
		void OnCaptionsChange(nint selectedTrack);

		// @optional -(void)onLevels:(NSArray *)levels;
		[Export("onLevels:")]
		void OnLevels(NSObject[] levels);

		// @optional -(void)onQualityLevels:(NSArray *)levels __attribute__((deprecated("Use onLevels: instead")));
		[Export("onQualityLevels:")]
		void OnQualityLevels(NSObject[] levels);

		// @optional -(void)onLevelsChanged:(NSInteger)currentLevel;
		[Export("onLevelsChanged:")]
		void OnLevelsChanged(nint currentLevel);

		// @optional -(void)onQualityChange:(NSInteger)currentQuality __attribute__((deprecated("Use onLevelsChanged: instead")));
		[Export("onQualityChange:")]
		void OnQualityChange(nint currentQuality);

		// @optional -(void)onVisualQuality:(NSString *)mode reason:(NSString *)reason label:(NSString *)label;
		[Export("onVisualQuality:reason:label:")]
		void OnVisualQuality(string mode, string reason, string label);

		// @optional -(void)onAudioTracks:(NSArray *)audioTracks;
		[Export("onAudioTracks:")]
		void OnAudioTracks(NSObject[] audioTracks);

		// @optional -(void)onAudioTrackChanged:(NSInteger)currentAudioTrack;
		[Export("onAudioTrackChanged:")]
		void OnAudioTrackChanged(nint currentAudioTrack);

		// @optional -(void)onPlaylist:(NSArray *)playlist;
		[Export("onPlaylist:")]
		void OnPlaylist(NSObject[] playlist);

		// @optional -(void)onPlaylistItem:(NSInteger)index;
		[Export("onPlaylistItem:")]
		void OnPlaylistItem(nint index);

		// @optional -(void)onPlaylistComplete;
		[Export("onPlaylistComplete")]
		void OnPlaylistComplete();

		// @optional -(void)onFullscreen:(BOOL)status;
		[Export("onFullscreen:")]
		void OnFullscreen(bool status);

		// @optional -(void)onPictureInPicture:(BOOL)status;
		[Export("onPictureInPicture:")]
		void OnPictureInPicture(bool status);

		// @optional -(void)onControls:(BOOL)status;
		[Export("onControls:")]
		void OnControls(bool status);

		// @optional -(void)onDisplayClick;
		[Export("onDisplayClick")]
		void OnDisplayClick();

		// @optional -(void)onAdRequest:(NSString *)tag forPosition:(NSString *)adPosition __attribute__((deprecated("Use onAdRequest: forPosition: client: creativeType: instead")));
		[Export("onAdRequest:forPosition:")]
		void OnAdRequest(string tag, string adPosition);

		// @optional -(void)onAdRequest:(NSString *)tag forPosition:(NSString *)adPosition client:(JWAdClient)client creativeType:(NSString *)creativeType;
		[Export("onAdRequest:forPosition:client:creativeType:")]
		void OnAdRequest(string tag, string adPosition, JWAdClient client, string creativeType);

		// @optional -(void)onAdSkipped:(NSString *)tag __attribute__((deprecated("Use onAdSkipped: client: creativeType: instead")));
		[Export("onAdSkipped:")]
		void OnAdSkipped(string tag);

		// @optional -(void)onAdSkipped:(NSString *)tag client:(JWAdClient)client creativeType:(NSString *)creativeType;
		[Export("onAdSkipped:client:creativeType:")]
		void OnAdSkipped(string tag, JWAdClient client, string creativeType);

		// @optional -(void)onAdComplete:(NSString *)tag __attribute__((deprecated("Use onAdComplete: client: creativeType: instead")));
		[Export("onAdComplete:")]
		void OnAdComplete(string tag);

		// @optional -(void)onAdComplete:(NSString *)tag client:(JWAdClient)client creativeType:(NSString *)creativeType;
		[Export("onAdComplete:client:creativeType:")]
		void OnAdComplete(string tag, JWAdClient client, string creativeType);

		// @optional -(void)onAdClick:(NSString *)tag __attribute__((deprecated("Use onAdClick: client: creativeType: instead")));
		[Export("onAdClick:")]
		void OnAdClick(string tag);

		// @optional -(void)onAdClick:(NSString *)tag client:(JWAdClient)client creativeType:(NSString *)creativeType;
		[Export("onAdClick:client:creativeType:")]
		void OnAdClick(string tag, JWAdClient client, string creativeType);

		// @optional -(void)onAdImpression:(NSString *)tag __attribute__((deprecated("Use onAdImpression: adPosition: adSystem: adTitle: client: creativeType: vastVersion: wrapper: instead")));
		[Export("onAdImpression:")]
		void OnAdImpression(string tag);

		// @optional -(void)onAdImpression:(NSString *)tag adPosition:(NSString *)position adSystem:(NSString *)adSystem adTitle:(NSString *)adTitle client:(JWAdClient)client creativeType:(NSString *)creativeType vastVersion:(double)vastVersion wrapper:(NSArray *)wrapper;
		[Export("onAdImpression:adPosition:adSystem:adTitle:client:creativeType:vastVersion:wrapper:")]
		void OnAdImpression(string tag, string position, string adSystem, string adTitle, JWAdClient client, string creativeType, double vastVersion, NSObject[] wrapper);

		// @optional -(void)onAdPlay:(NSString *)tag __attribute__((deprecated("Use onAdPlay: creativeType: newstate: oldState: instead")));
		[Export("onAdPlay:")]
		void OnAdPlay(string tag);

		// @optional -(void)onAdPlay:(NSString *)tag creativeType:(NSString *)creativeType newState:(NSString *)newState oldState:(NSString *)oldState;
		[Export("onAdPlay:creativeType:newState:oldState:")]
		void OnAdPlay(string tag, string creativeType, string newState, string oldState);

		// @optional -(void)onAdPause:(NSString *)tag __attribute__((deprecated("Use onAdPause: creativeType: newState: oldState: instead")));
		[Export("onAdPause:")]
		void OnAdPause(string tag);

		// @optional -(void)onAdPause:(NSString *)tag creativeType:(NSString *)creativeType newState:(NSString *)newState oldState:(NSString *)oldState;
		[Export("onAdPause:creativeType:newState:oldState:")]
		void OnAdPause(string tag, string creativeType, string newState, string oldState);

		// @optional -(void)onAdTime:(double)position ofDuration:(double)duration tag:(NSString *)tag index:(NSInteger)sequence __attribute__((deprecated("Use onAdTime: ofDuration: tag: index: client: creativeType: instead")));
		[Export("onAdTime:ofDuration:tag:index:")]
		void OnAdTime(double position, double duration, string tag, nint sequence);

		// @optional -(void)onAdTime:(double)position ofDuration:(double)duration tag:(NSString *)tag index:(NSInteger)sequence client:(JWAdClient)client creativeType:(NSString *)creativeType;
		[Export("onAdTime:ofDuration:tag:index:client:creativeType:")]
		void OnAdTime(double position, double duration, string tag, nint sequence, JWAdClient client, string creativeType);

		// @optional -(void)onAdError:(NSError *)error;
		[Export("onAdError:")]
		void OnAdError(NSError error);

		// @optional -(void)onAdStarted:(NSString *)tag creativeType:(NSString *)creativeType;
		[Export("onAdStarted:creativeType:")]
		void OnAdStarted(string tag, string creativeType);

		// @optional -(void)onOpenRelatedOverlay:(JWRelatedOpenMethod)method relatedFile:(NSString *)relatedFile items:(NSArray<JWPlaylistItem *> *)items;
		[Export("onOpenRelatedOverlay:relatedFile:items:")]
		void OnOpenRelatedOverlay(JWRelatedOpenMethod method, string relatedFile, JWPlaylistItem[] items);

		// @optional -(void)onCloseRelatedOverlay:(NSString *)method;
		[Export("onCloseRelatedOverlay:")]
		void OnCloseRelatedOverlay(string method);

		// @optional -(void)onRelatedPlay:(JWPlaylistItem *)item auto:(BOOL)autoplay position:(NSInteger)position;
		[Export("onRelatedPlay:auto:position:")]
		void OnRelatedPlay(JWPlaylistItem item, bool autoplay, nint position);

		// @optional -(void)onError:(NSError *)error;
		[Export("onError:")]
		void OnError(NSError error);

		// @optional -(void)onSetupError:(NSError *)error;
		[Export("onSetupError:")]
		void OnSetupError(NSError error);
	}

	// @interface JWPlayerController : NSObject
	[BaseType(typeof(NSObject))]
	interface JWPlayerController
	{
		// @property (readonly, retain, nonatomic) UIView * view;
		[Export("view", ArgumentSemantic.Retain)]
		UIView View { get; }

		[Wrap("WeakDelegate")]
		JWPlayerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<JWPlayerDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) id<JWDrmDataSource> drmDataSource;
		[Export("drmDataSource", ArgumentSemantic.Weak)]
		JWDrmDataSource DrmDataSource { get; set; }

		// @property (readonly, retain, nonatomic) NSString * googleIMAVersion;
		[Export("googleIMAVersion", ArgumentSemantic.Retain)]
		string GoogleIMAVersion { get; }

		// @property (readonly, retain, nonatomic) NSString * googleChromeCastVersion;
		[Export("googleChromeCastVersion", ArgumentSemantic.Retain)]
		string GoogleChromeCastVersion { get; }

		// @property (readonly, retain, nonatomic) NSString * playerState;
		[Export("playerState", ArgumentSemantic.Retain)]
		string PlayerState { get; }

		// @property (readonly, retain, nonatomic) NSDictionary * metadata;
		[Export("metadata", ArgumentSemantic.Retain)]
		NSDictionary Metadata { get; }

		// @property (readonly, nonatomic) CGSize naturalSize;
		[Export("naturalSize")]
		CGSize NaturalSize { get; }

		// @property (readonly, retain, nonatomic) JWConfig * config;
		[Export("config", ArgumentSemantic.Retain)]
		JWConfig Config { get; }

		// @property (readonly, nonatomic) NSInteger buffer;
		[Export("buffer")]
		nint Buffer { get; }

		// @property (nonatomic) BOOL controls;
		[Export("controls")]
		bool Controls { get; set; }

		// @property (nonatomic) BOOL displayLockScreenControls;
		[Export("displayLockScreenControls")]
		bool DisplayLockScreenControls { get; set; }

		// @property (readonly, nonatomic) CGRect safeRegion;
		[Export("safeRegion")]
		CGRect SafeRegion { get; }

		// @property (nonatomic) NSInteger currentQualityLevel;
		[Export("currentQualityLevel")]
		nint CurrentQualityLevel { get; set; }

		// @property (readonly, retain, nonatomic) NSArray * levels;
		[Export("levels", ArgumentSemantic.Retain)]
		NSObject[] Levels { get; }

		// @property (nonatomic) NSInteger currentCaptions;
		[Export("currentCaptions")]
		nint CurrentCaptions { get; set; }

		// @property (readonly, retain, nonatomic) NSArray * captionsList;
		[Export("captionsList", ArgumentSemantic.Retain)]
		NSObject[] CaptionsList { get; }

		// @property (nonatomic) NSInteger currentAudioTrack;
		[Export("currentAudioTrack")]
		nint CurrentAudioTrack { get; set; }

		// @property (readonly, retain, nonatomic) NSArray * audioTracks;
		[Export("audioTracks", ArgumentSemantic.Retain)]
		NSObject[] AudioTracks { get; }

		// @property (nonatomic) NSInteger playlistIndex;
		[Export("playlistIndex")]
		nint PlaylistIndex { get; set; }

		// -(instancetype)initWithConfig:(JWConfig *)config;
		[Export("initWithConfig:")]
		IntPtr Constructor(JWConfig config);

		// -(instancetype)initWithConfig:(JWConfig *)config delegate:(id<JWPlayerDelegate>)delegate;
		[Export("initWithConfig:delegate:")]
		IntPtr Constructor(JWConfig config, JWPlayerDelegate @delegate);

		// -(instancetype)initWithConfig:(JWConfig *)config delegate:(id<JWPlayerDelegate>)delegate drmDataSource:(id<JWDrmDataSource>)drmDataSource;
		[Export("initWithConfig:delegate:drmDataSource:")]
		IntPtr Constructor(JWConfig config, JWPlayerDelegate @delegate, JWDrmDataSource drmDataSource);

		// -(void)play;
		[Export("play")]
		void Play();

		// -(void)pause;
		[Export("pause")]
		void Pause();

		// -(void)stop;
		[Export("stop")]
		void Stop();

		// -(void)seek:(NSUInteger)position;
		[Export("seek:")]
		void Seek(nuint position);

		// @property (readonly, retain, nonatomic) NSNumber * playbackPosition;
		[Export("playbackPosition", ArgumentSemantic.Retain)]
		NSNumber PlaybackPosition { get; }

		// @property (readonly, nonatomic) double duration;
		[Export("duration")]
		double Duration { get; }

		// @property (nonatomic) CGFloat volume;
		[Export("volume")]
		nfloat Volume { get; set; }

		// @property (readonly, nonatomic) BOOL isInFullscreen;
		[Export("isInFullscreen")]
		bool IsInFullscreen { get; }

		// @property (nonatomic) BOOL forceFullScreenOnLandscape;
		[Export("forceFullScreenOnLandscape")]
		bool ForceFullScreenOnLandscape { get; set; }

		// @property (nonatomic) BOOL forceLandscapeOnFullScreen;
		[Export("forceLandscapeOnFullScreen")]
		bool ForceLandscapeOnFullScreen { get; set; }

		// @property (nonatomic) BOOL pictureInPictureDisabled;
		[Export("pictureInPictureDisabled")]
		bool PictureInPictureDisabled { get; set; }

		// -(void)enterFullScreen;
		[Export("enterFullScreen")]
		void EnterFullScreen();

		// -(void)exitFullScreen;
		[Export("exitFullScreen")]
		void ExitFullScreen();

		// -(void)togglePictureInPicture;
		[Export("togglePictureInPicture")]
		void TogglePictureInPicture();

		// -(void)load:(NSString *)file;
		[Export("load:")]
		void Load(string file);

		// -(void)loadConfig:(JWConfig *)config;
		[Export("loadConfig:")]
		void LoadConfig(JWConfig config);

		// -(void)loadPlaylist:(NSArray *)playlist;
		[Export("loadPlaylist:")]
		void LoadPlaylist(NSObject[] playlist);

		// -(void)playAd:(NSString *)tag;
		[Export("playAd:")]
		void PlayAd(string tag);

		// -(void)playAd:(NSString *)tag onClient:(JWAdClient)adClient;
		[Export("playAd:onClient:")]
		void PlayAd(string tag, JWAdClient adClient);

		// @property (nonatomic) BOOL openSafariOnAdClick;
		[Export("openSafariOnAdClick")]
		bool OpenSafariOnAdClick { get; set; }

		// -(void)openRelatedOverlay;
		[Export("openRelatedOverlay")]
		void OpenRelatedOverlay();

		// -(void)closeRelatedOverlay;
		[Export("closeRelatedOverlay")]
		void CloseRelatedOverlay();

		// @property (readonly, retain, nonatomic) NSString * playerVersion;
		[Export("playerVersion", ArgumentSemantic.Retain)]
		string PlayerVersion { get; }

		// @property (readonly, retain, nonatomic) NSString * playerEdition;
		[Export("playerEdition", ArgumentSemantic.Retain)]
		string PlayerEdition { get; }

		// +(NSString *)SDKVersion;
		[Static]
		[Export("SDKVersion")]
		string SDKVersion { get; }

		// +(NSString *)SDKVersionToMinor;
		[Static]
		[Export("SDKVersionToMinor")]
		string SDKVersionToMinor { get; }
	}
}
