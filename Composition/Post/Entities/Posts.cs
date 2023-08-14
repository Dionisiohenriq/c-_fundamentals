using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post.Entities
{
    public class Posts
    {
        public DateTime Moment { get; set; }
        public string  Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Coment> Coments { get; set; } = new List<Coment>();

        public Posts()
        {
            
        }

        public Posts(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComent(Coment coment)
        {
            Coments.Add(coment);
        }

        public void RemoveComent(Coment coment)
        {
            Coments.Remove(coment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Coments: ");

            foreach (Coment c in Coments)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();
        }
    }
}
