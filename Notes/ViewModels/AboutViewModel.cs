using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;
using Microsoft.Maui.ApplicationModel;

namespace Notes.ViewModels;

internal class AboutViewModel
{
    public string Title => AppInfo.Name;
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://github.com/lygwys/Notes";
    public string Message => "此便笺（Notes by lygwys）是学习 .NET MAUI 的一个练习.";

    public string Blog => "https://lygwys.github.io/";

    public string Reward => "https://s21.ax1x.com/2025/02/16/pEKHQPO.jpg";

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
