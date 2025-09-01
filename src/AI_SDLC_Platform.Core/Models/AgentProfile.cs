using AI_SDLC_Platform.Core.Enums;

namespace AI_SDLC_Platform.Core.Models
{
    public class AgentProfile
    {
        public string Name { get; set; } = "";
        public AgentRole Role { get; set; }
        public string GitUsername { get; set; } = "";
        public string GitEmail { get; set; } = "";
        public Dictionary<string,string> Preferences { get; set; } = new();
    }
}
