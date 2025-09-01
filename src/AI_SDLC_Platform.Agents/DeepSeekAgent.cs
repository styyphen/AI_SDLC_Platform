using AI_SDLC_Platform.Core.Agents;
using AI_SDLC_Platform.Core.Enums;
using AI_SDLC_Platform.Core.Models;

namespace AI_SDLC_Platform.Agents
{
    public class DeepSeekAgent : IAgent
    {
        public string Name => "DeepSeek";
        public AgentRole Role => AgentRole.SystemDesign;
        
        public async Task<TaskItem> ExecuteTaskAsync(TaskItem task)
        {
            var result = new TaskItem
            {
                Title = $"Requirements refined: {task.Title}",
                Description = $"[DeepSeek] Creating system design for : {task.Description}",
                AgentTaskStatus = AgentTaskStatus.Complete
            };
            return await Task.FromResult(result);
        }
    }
}
