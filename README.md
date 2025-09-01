# AI_SDLC_Platform
This app is meant to be an AI-driven Software Development Lifecycle (SDLC) automation platform, where specialized AI agents (Claude, DeepSeek, Copilot, Grok, etc.) collaborate as a virtual dev team.

Instead of you doing all the heavy lifting yourself, the platform will:

📋 Refine requirements & documentation
Claude agent turns high-level ideas into well-structured use cases, proof-of-concept docs, and technical specifications.

🛠 System design
DeepSeek agent generates UML diagrams, sequence diagrams, architecture designs, and design validations.

💻 Implementation
Copilot + Grok agents generate clean, standards-compliant code directly into the repository.

✅ Testing & validation
Agents can also generate automated unit/integration tests following TDD rules.

🔄 Collaboration workflow
Each agent acts like a team member with a GitHub account, committing code, opening PRs, and reviewing tasks.

📊 Management dashboard
You (the human lead) use a dashboard to assign tasks to agents, monitor progress, and orchestrate delivery.

This is a scaffold for an autonomous AI SDLC team using .NET 9.

## Setup
- Run `dotnet restore`
- Run the API and Client separately or use docker-compose up
# AI_SDLC_Platform
