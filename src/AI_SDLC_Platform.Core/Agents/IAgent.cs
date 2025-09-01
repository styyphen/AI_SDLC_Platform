using AI_SDLC_Platform.Core.Enums;
using AI_SDLC_Platform.Core.Models;

namespace AI_SDLC_Platform.Core.Agents
{
    public interface IAgent
    {
        string Name { get; }
        AgentRole Role { get; }
        Task<TaskItem> ExecuteTaskAsync(TaskItem task);
    }
}
