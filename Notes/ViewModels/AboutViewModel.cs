using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace Notes.ViewModels;

internal class AboutViewModel
{
    public string Title => AppInfo.Name;
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://github.com/lygwys/Notes";
    public string Message => "";

    public string Blog => "https://lygwys.github.io/";

    public string Reward => "http://m.qpic.cn/psc?/V510qy3o2Pw3Iu3ZXbES352K6J3MkfG7/LiySpxowE0yeWXwBdXN*SYHOk*GVlVvqAVMV4dfQJ2pz0rnQfcnuOxqmXL2nkLqKcxAisbZXnMpmix6mpnHa8r82khXDDwR*ItWMfv0aLxg!/mnull&bo=bQOpBG0DqQQBByA!&rf=photolist&t=5";

    public ICommand ShowMoreInfoCommand { get; }
    public ICommand ShowBlogCommand { get; }
    public ICommand ShowRewardCommand { get; }

    public AboutViewModel()
    {
        ShowMoreInfoCommand = new AsyncRelayCommand(ShowMoreInfo);
        ShowBlogCommand = new AsyncRelayCommand(ShowBlog);
        ShowRewardCommand = new AsyncRelayCommand(ShowReward);
    }

    async Task ShowMoreInfo() =>
        await Launcher.Default.OpenAsync(MoreInfoUrl);

    async Task ShowBlog() =>
        await Launcher.Default.OpenAsync(Blog);
    async Task ShowReward() =>
        await Launcher.Default.OpenAsync(Reward);
}
