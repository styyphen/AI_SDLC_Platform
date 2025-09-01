using AI_SDLC_Platform.Core.Agents;
using AI_SDLC_Platform.Core.Enums;
using AI_SDLC_Platform.Core.Models;

namespace AI_SDLC_Platform.Agents
{
    public class ClaudeAgent : IAgent
    {
        public string Name => "Claude";
        public AgentRole Role => AgentRole.Requirements;
        
        public async Task<TaskItem> ExecuteTaskAsync(TaskItem task)
        {
            var result = new TaskItem
            {
                Title = $"Requirements refined: {task.Title}",
                Description = $"[RequirementsAgent] Refined requirements for: {task.Description}",
                AgentTaskStatus = AgentTaskStatus.Complete
            };
            return await Task.FromResult(result);
        }
    }
}
