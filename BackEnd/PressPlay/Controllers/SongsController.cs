using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PressPlay;
using PressPlay.Models;

namespace PressPlay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private readonly SiteContext _context;

        public SongsController(SiteContext context)
        {
            _context = context;
        }

        // GET: api/Songs
        [HttpGet]
        public IEnumerable<Song> GetSong()
        {
            return _context.Song;
        }

        // GET: api/Songs/5
        [HttpGet("{id}")]
        public IEnumerable<Song> GetSong([FromRoute] int id)
        {
            return _context.Song.Where(r => r.AlbumId == id);
        }

        // PUT: api/Songs/5
        [HttpPut("{id}")]
        public async Task<IEnumerable<Song>> PutSong([FromRoute] int id, [FromBody] Song song)
        {


            _context.Entry(song).State = EntityState.Modified;

            await _context.SaveChangesAsync();    

            return _context.Song.Where(r => r.AlbumId == song.AlbumId);
        }

        // POST: api/Songs
        [HttpPost]
        public async Task<IEnumerable<Song>> PostSong([FromBody] Song song)
        {


            _context.Song.Add(song);
            await _context.SaveChangesAsync();

            return _context.Song.Where(r => r.AlbumId == song.AlbumId);
        }

        // DELETE: api/Songs/5
        [HttpDelete("{id}")]
        public async Task<IEnumerable<Song>> DeleteSong([FromRoute] int id)
        {


            var song = await _context.Song.FindAsync(id);


            _context.Song.Remove(song);
            await _context.SaveChangesAsync();

            return _context.Song.Where(r => r.AlbumId == song.AlbumId);
        }

        private bool SongExists(int id)
        {
            return _context.Song.Any(e => e.SongId == id);
        }
    }
}