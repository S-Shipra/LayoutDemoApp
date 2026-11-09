using CommunityToolkit.Mvvm.Input;
using LayoutsDemoApp.Models;

namespace LayoutsDemoApp.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}