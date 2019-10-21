using System;

namespace Exercise02_Console_StackOverflow
{
  class Program
  {
    static void Main(string[] args)
    {
      string title;
      string description;

      Post newPost;

      Console.WriteLine("Title: ");
      title = Console.ReadLine();

      Console.WriteLine("Description: ");
      description = Console.ReadLine();

      newPost = new Post(title, description);

      for (int i = 0; i < 10; i++)
      {
        newPost.UpVotePost();
      }

      for (int i = 0; i < 4; i++)
      {
        newPost.DownVotePost();
      }

      Console.WriteLine($"Title: {newPost.Title}");
      Console.WriteLine($"Description: {newPost.Description}");
      Console.WriteLine($"Created At: {newPost.Created}");
      Console.WriteLine($"UpVote: {newPost.UpVote}");
      Console.WriteLine($"DownVote: {newPost.DownVote}");
    }
  }
}
