using BusinessLayer.IServices;
using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace BusinessLayer.Services
{
    public class URL : IUrl
    {
		private readonly UrlContext context;
		public URL(UrlContext _context)
		{
			context = _context;
		}
		public bool AddUrl(string url)
        {
			try
			{
				string slug = GenerateSlug();
				Urls urls = new Urls();
				urls.Slug = slug;
				urls.URL = url;

				context.Add(urls);
				context.SaveChanges();
				return true;
			}
			catch
			{
				return false;
			}
		}

        public IEnumerable<Urls> GetList()
        {
			var urls = (from x in context.Urls select x).ToList();
			return urls;
        }
		private string GenerateSlug()
		{
			var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			var Charsarr = new char[8];
			var random = new Random();

			for (int i = 0; i < Charsarr.Length; i++)
			{
				Charsarr[i] = characters[random.Next(characters.Length)];
			}

			var segmentstring = new String(Charsarr);

			return segmentstring;
		}
	}
}
