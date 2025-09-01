using LibGit2Sharp;

namespace AI_SDLC_Platform.Infrastructure
{
    public class GitService
    {
        public async Task CommitAndPushAsync(string repoPath, string branch, string message, string username, string email)
        {
            using var repo = new Repository(repoPath);
            Commands.Checkout(repo, branch);
            Commands.Stage(repo, "*");
            var author = new Signature(username, email, DateTimeOffset.Now);
            repo.Commit(message, author, author);

            // Push logic can be implemented here using credentials
            await Task.CompletedTask;
        }
    }
}
