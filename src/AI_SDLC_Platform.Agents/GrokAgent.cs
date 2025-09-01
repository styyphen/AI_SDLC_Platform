using AI_SDLC_Platform.Core.Agents;
using AI_SDLC_Platform.Core.Enums;
using AI_SDLC_Platform.Core.Models;

namespace AI_SDLC_Platform.Agents
{
    public class GrokAgent : IAgent
    {
        public string Name => "Grok";
        public AgentRole Role => AgentRole.CodeReview;

        public async Task<TaskItem> ExecuteTaskAsync(TaskItem task)
        {
            Console.WriteLine($"[Grok] Reviewing and optimizing code for {task.Description}");
            await Task.Delay(500);
            task.Completed = true;
            return task;
        }
    }
}
