using AI_SDLC_Platform.Core.Agents;
using AI_SDLC_Platform.Core.Enums;
using AI_SDLC_Platform.Core.Models;

namespace AI_SDLC_Platform.Agents
{
    public class CopilotAgent : IAgent
    {
        public string Name => "Copilot";
        public AgentRole Role => AgentRole.Implementation;
        
        public async Task<TaskItem> ExecuteTaskAsync(TaskItem task)
        {
            var result = new TaskItem
            {
                Title = $"Requirements refined: {task.Title}",
                Description = $"[Copilot] Implementing code for : {task.Description}",
                AgentTaskStatus = AgentTaskStatus.Complete
            };
            return await Task.FromResult(result);
        }
    }
}
