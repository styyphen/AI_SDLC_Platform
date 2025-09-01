using AI_SDLC_Platform.Core.Enums;

namespace AI_SDLC_Platform.Core.Models
{
    public class TaskItem
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Description { get; set; } = "";
        public string RepositoryUrl { get; set; } = "";
        public string Branch { get; set; } = "";
        
        public string Title { get; set; } = "";
        public AgentTaskStatus AgentTaskStatus { get; set; }
        public bool Completed { get; set; } = false;
    }
}
