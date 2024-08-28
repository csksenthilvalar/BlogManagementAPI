using BlogManagementSysAPI.DataAccessLayer.Interface;
using BlogManagementSysAPI.DataAccessLayer.Models;
using Newtonsoft.Json;
using System.Reflection.Metadata;

namespace BlogManagementSysAPI.DataAccessLayer.Repositories
{
    public class JSONBlogMngmtRepository : IJSONBlogMngmt
    {
        private readonly IConfiguration _config;
        private readonly string _Path;
        private readonly string _fileName;
        public JSONBlogMngmtRepository(IConfiguration config)
        {
            _config = config;
            _Path = _config.GetValue<string>("MySettings:path");
            _fileName = _config.GetValue<string>("MySettings:filename");
        }
        public BlogMngmt AddBlogMngmt(BlogMngmt blog)
        {
            List<BlogMngmt> lstblogs = new List<BlogMngmt>();
           
            var path = Path.Combine(Directory.GetCurrentDirectory(), _Path, _fileName);
            lstblogs = JsonConvert.DeserializeObject<List<BlogMngmt>>(GetBlogMngmt());
            if (lstblogs != null && lstblogs.Count > 0)
            {
                var id = lstblogs.OrderByDescending(x => x.Id).Max(x => x.Id);
                blog.Id = Convert.ToInt16(id) + 1;
            }
            else
            {
                blog.Id = 1;
            }
            BlogMngmt _blog = lstblogs.FirstOrDefault(x => x.Id == blog.Id);

            if (_blog == null)
            {
               
                lstblogs.Add(blog);
            }
            else
            {
                int index = lstblogs.FindIndex(x => x.Id == blog.Id);
                lstblogs[index] = blog;
            }

            string jSONString = JsonConvert.SerializeObject(lstblogs);
            using (var streamWriter = File.CreateText(path))
            {
                streamWriter.Write(jSONString);
            }
            return blog;
        }

        public BlogMngmt DeleteBlogMngmt(int id)
        {
            List<BlogMngmt> lstblogs = new List<BlogMngmt>();

            var path = Path.Combine(Directory.GetCurrentDirectory(), _Path, _fileName);
            lstblogs = JsonConvert.DeserializeObject<List<BlogMngmt>>(GetBlogMngmt());

            BlogMngmt _blog = lstblogs.FirstOrDefault(x => x.Id == id);

            if (_blog != null)
            {
           
                int index = lstblogs.FindIndex(x => x.Id == id);
                lstblogs.RemoveAt(index);
            }

            string jSONString = JsonConvert.SerializeObject(lstblogs);
            using (var streamWriter = File.CreateText(path))
            {
                streamWriter.Write(jSONString);
            }
            return _blog;
        }

        public string GetBlogMngmt()
        {

            var path = Path.Combine(Directory.GetCurrentDirectory(), _Path, _fileName);

            string jsonResult;

            using (StreamReader streamReader = new StreamReader(path))
            {
                jsonResult = streamReader.ReadToEnd();
            }
            return jsonResult;
        }

        public BlogMngmt GetBlogMngmtById(int id)
        {
            List<BlogMngmt> lstblogs = new List<BlogMngmt>();

            var path = Path.Combine(Directory.GetCurrentDirectory(), _Path, _fileName);
            lstblogs = JsonConvert.DeserializeObject<List<BlogMngmt>>(GetBlogMngmt());

            BlogMngmt _blog = lstblogs.FirstOrDefault(x => x.Id == id);

            return _blog;
        }

        public IEnumerable<BlogMngmt> GetBlogMngmtlist()
        {
            List<BlogMngmt> lstblogs = new List<BlogMngmt>();
            lstblogs = JsonConvert.DeserializeObject<List<BlogMngmt>>(GetBlogMngmt());
            return lstblogs;
        }

        public BlogMngmt UpdateBlogMngmt(BlogMngmt blog)
        {
            List<BlogMngmt> lstblogs = new List<BlogMngmt>();

            var path = Path.Combine(Directory.GetCurrentDirectory(), _Path, _fileName);
            lstblogs = JsonConvert.DeserializeObject<List<BlogMngmt>>(GetBlogMngmt());

            BlogMngmt _blog = lstblogs.FirstOrDefault(x => x.Id == blog.Id);

            if (_blog == null)
            {
                lstblogs.Add(blog);
            }
            else
            {
                int index = lstblogs.FindIndex(x => x.Id == blog.Id);
                lstblogs[index] = blog;
            }

            string jSONString = JsonConvert.SerializeObject(lstblogs);
            using (var streamWriter = File.CreateText(path))
            {
                streamWriter.Write(jSONString);
            }
            return blog;
        }
    }
}
