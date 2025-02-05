using BlazorApp.Models;
using CommunityToolkit.Mvvm.Input;

namespace BlazorApp.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}