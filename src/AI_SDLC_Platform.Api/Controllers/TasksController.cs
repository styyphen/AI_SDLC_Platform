using AI_SDLC_Platform.Core.Agents;
using AI_SDLC_Platform.Core.Enums;
using AI_SDLC_Platform.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace AI_SDLC_Platform.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TasksController(IEnumerable<IAgent> agents) : ControllerBase
{
    [HttpPost("assign")]
    public async Task<IActionResult> AssignTask([FromBody] TaskItem task)
    {
        foreach(var agent in agents)
        {
            // Simple routing based on task description
            if(task.Description.Contains("doc") && agent.Role == AgentRole.Documentation)
                task = await agent.ExecuteTaskAsync(task);
            else if(task.Description.Contains("design") && agent.Role == AgentRole.SystemDesign)
                task = await agent.ExecuteTaskAsync(task);
            else if(task.Description.Contains("code") && agent.Role == AgentRole.Implementation)
                task = await agent.ExecuteTaskAsync(task);
            else if(agent.Role == AgentRole.CodeReview)
                task = await agent.ExecuteTaskAsync(task);
        }

        return Ok(task);
    }
}