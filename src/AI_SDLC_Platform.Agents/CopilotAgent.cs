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
            Console.WriteLine($"[Copilot] Implementing code for {task.Description}");
            await Task.Delay(1000); // simulate coding
            task.Completed = true;
            return task;
        }
    }
}
