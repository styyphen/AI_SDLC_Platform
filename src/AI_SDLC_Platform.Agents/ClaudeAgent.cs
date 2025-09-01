using AI_SDLC_Platform.Core.Agents;
using AI_SDLC_Platform.Core.Enums;
using AI_SDLC_Platform.Core.Models;

namespace AI_SDLC_Platform.Agents
{
    public class ClaudeAgent : IAgent
    {
        public string Name => "Claude";
        public AgentRole Role => AgentRole.Documentation;

        public async Task<TaskItem> ExecuteTaskAsync(TaskItem task)
        {
            Console.WriteLine($"[Claude] Generating documentation for task {task.Description}");
            await Task.Delay(500); // Simulate AI processing
            task.Completed = true;
            return task;
        }
    }
}
