using System;

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
        return config;
    }
}

public class SceneDelegate : UISceneDelegate
{
    private UIWindow? window;

    public override void WillConnect(
        UIScene scene,
        UISceneSession session,
        UISceneConnectionOptions connectionOptions)
    {
        try
        {
            if (scene is UIWindowScene windowScene)
            {
                windowScene.Title = "Hello World";
                this.window = new UIWindow(windowScene);
                this.window.RootViewController = new ViewController();
                this.window.MakeKeyAndVisible();
            }
        }
        catch(Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
    }
}

public class ViewController : UIViewController
{
    public override void LoadView()
    {
        UIView view = new();
        view.TranslatesAutoresizingMaskIntoConstraints = false;
        view.ContentMode = UIViewContentMode.ScaleAspectFit;
        view.BackgroundColor = UIColor.Red;


        UIView view2 = new();
        view2.TranslatesAutoresizingMaskIntoConstraints = false;
        view2.ContentMode = UIViewContentMode.ScaleAspectFit;
        view2.BackgroundColor = UIColor.Green;
        view2.Frame = new(0, 0, 200, 200);
        view.AddSubview(view2);

        this.View = view;
    }

    public override void ViewDidAppear(bool animated)
    {
        Console.WriteLine(this.View);
        base.ViewDidAppear(animated);
    }
}