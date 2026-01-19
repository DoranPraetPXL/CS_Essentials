using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavorieteAlbum.Models
{
    internal class Album
    {
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private DateTime _releaseDate;

		public DateTime ReleaseDate
		{
			get { return _releaseDate; }
			set { _releaseDate = value; }
		}

		private TimeSpan _duration;

		public TimeSpan Duration
		{
			get { return _duration; }
			set { _duration = value; }
		}

		private int _songs;

        public int Songs
		{
			get { return _songs; }
			set { _songs = value; }
		}

        public Album()
        {
            
        }
    }
}
