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
## Summary
This app is a virtual AI software development team, where role-based agents collaborate to handle the entire SDLC (docs → design → code → tests → delivery) in an automated, Git-driven workflow.

🛠 Full Workflow for AI-Driven SDLC Platform
1. Task Assignment (You → Platform)

You (the human lead) create a task in the platform dashboard:
Example: “Build authentication API with JWT and refresh tokens.”

The task is stored in the platform database (Tasks table) and linked to a Git repo + branch.

The API (/api/tasks/assign) routes the task to the right AI agent based on its role.

2. Task Routing to AI Agents

Each agent has a role profile stored in the system:

Claude → Documentation, use cases, PoCs

DeepSeek → UML, architecture, design docs

Copilot + Grok → Implementation (code generation, refactoring)

(Future: TestAgent → automated tests, DevOpsAgent → CI/CD pipelines)

The Task Orchestrator assigns the task:

Docs tasks → Claude

Design tasks → DeepSeek

Code tasks → Copilot + Grok

3. Agent Execution

Each agent works like a microservice (or external LLM API call):

Claude Agent

Expands requirements into detailed use cases & user stories.

Generates proof-of-concept notes & documentation.

Commits docs into /docs/ folder of repo.

DeepSeek Agent

Creates UML diagrams (class, sequence, deployment).

Generates architecture diagrams (JSON, PlantUML, or Mermaid).

Commits designs into /design/.

Copilot + Grok Agents

Work on code tasks (implementation + refactoring).

Commit feature branches into repo (feature/auth-jwt).

Open pull requests (PRs).

4. Collaboration via Git Repository

All agents are added as team members in GitHub/Gitea/GitLab with their own credentials.

Workflow:

Agent commits code/docs/design.

Agent opens a PR.

Another agent (or you) reviews PR.

PR merged into main branch.

5. Testing & Validation

Optional test agent auto-generates unit tests + integration tests.

GitHub Actions (or Azure DevOps pipelines) run CI/CD:

Build + test automation.

Linting + code quality checks.

Deployment to staging/prod.

6. Feedback Loop

If a task fails (e.g., tests don’t pass), the platform re-assigns a fix task to the correct agent.

Agents continuously refine until the build passes.

7. Dashboard (Blazor Client)

Displays tasks in progress, assigned agent, Git branch, PR status, and test results.

Allows you to:

Assign tasks.

Monitor AI agent activity.

Approve/reject merges.

Manage repo access.

🔄 End-to-End Example

You assign task:

“Implement login API with JWT + refresh tokens.”

Claude → Writes detailed use cases + PoC doc → commits to /docs/.

DeepSeek → Creates UML sequence diagram for login flow → commits to /design/.

Copilot + Grok → Generate actual AuthController.cs, AuthService.cs → push to feature/auth-jwt.

PR opened → reviewed → merged into main.

CI/CD runs tests → deploys to staging.

Dashboard shows Task Completed ✅.

📌 Key Benefits

You act as Project Owner.

AI agents act as specialized dev team.

Git + API + dashboard tie everything together.

Full SDLC (docs → design → code → tests → deploy) happens automatically.
