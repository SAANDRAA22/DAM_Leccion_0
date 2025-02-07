using CommunityToolkit.Mvvm.Input;
using ControlAdmin.Models;

namespace ControlAdmin.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}