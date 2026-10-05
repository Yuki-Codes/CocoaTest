using ObjCRuntime;
using UIKit;

namespace CocoaTest;

public class Program
{
	static void Main(string[] args)
	{
		UIApplication.Main(args, null, typeof(AppDelegate));
	}
}

public class AppDelegate : UIApplicationDelegate
{
    public override void FinishedLaunching(UIApplication application)
	{
	}

    public override UISceneConfiguration GetConfiguration(
        UIApplication application,
        UISceneSession connectingSceneSession,
        UISceneConnectionOptions options)
    {
        UISceneConfiguration config = new();
        config.DelegateType = typeof(SceneDelegate);
        config.SceneType = typeof(WindowScene);
        return config;
    }
}

public class SceneDelegate : UISceneDelegate
{
    public SceneDelegate()
    {
    }
}

public class WindowScene : UIWindowScene
{
    public WindowScene(UISceneSession session, UISceneConnectionOptions connectionOptions)
        : base(session, connectionOptions)
    {
    }
}
