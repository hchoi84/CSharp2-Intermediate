using System;

namespace Exercise02_Console_StackOverflow
{
  public class Post
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Created { get; private set; }
    public int UpVote { get; private set; }
    public int DownVote { get; private set; }

    public Post (string title, string description)
    {
      Title = title;
      Description = description;
      Created = DateTime.Now;
    }

    public void UpVotePost()
    {
      UpVote++;
    }

    public void DownVotePost()
    {
      DownVote++;
    }
  }
}