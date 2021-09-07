using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.IServices
{
    public interface IUrl
    {
        bool AddUrl(string url);
        IEnumerable<Urls> GetList();
    }
}
