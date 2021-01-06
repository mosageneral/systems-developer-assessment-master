using Model;
using System.Collections.Generic;

namespace NetC.JuniorDeveloperExam.Web.Services
{
    public interface IJsonService
    {
          List<Post> ReturnJsonAll();
          Post GetById(int id);

        Post Post(Post post);
        Comment AddComment(Comment Comment);
        Replay AddReplay(Replay Replay);

    }
}