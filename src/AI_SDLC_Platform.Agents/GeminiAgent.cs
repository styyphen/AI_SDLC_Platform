using AI_SDLC_Platform.Core.Agents;
using AI_SDLC_Platform.Core.Enums;
using AI_SDLC_Platform.Core.Models;

namespace AI_SDLC_Platform.Agents
{
    public class GeminiAgent : IAgent
    {
        public string Name => "Gemini";
        public AgentRole Role => AgentRole.Testing;
        
        public async Task<TaskItem> ExecuteTaskAsync(TaskItem task)
        {
            var result = new TaskItem
            {
                Title = $"Generate tests : {task.Title}",
                Description = $"[Gemini] Generate tests for: {task.Description}",
                AgentTaskStatus = AgentTaskStatus.Complete
            };
            return await Task.FromResult(result);
        }
    }
}
