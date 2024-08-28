using BlogManagementSysAPI.DataAccessLayer.Models;

namespace BlogManagementSysAPI.DataAccessLayer.Interface
{
    public interface IJSONBlogMngmt
    {
        IEnumerable<BlogMngmt> GetBlogMngmtlist();
        string GetBlogMngmt();
        BlogMngmt GetBlogMngmtById(int id);
        BlogMngmt AddBlogMngmt(BlogMngmt blog);
        BlogMngmt UpdateBlogMngmt(BlogMngmt blog);
        BlogMngmt DeleteBlogMngmt(int id);
    }
}
