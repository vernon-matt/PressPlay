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
    public class AlbumsController : ControllerBase
    {
        private readonly SiteContext _context;

        public AlbumsController(SiteContext context)
        {
            _context = context;
        }

        // GET: api/Albums
        [HttpGet]
        public IEnumerable<Album> GetAlbum()
        {
            return _context.Album;
        }

        // GET: api/Albums/5
        [HttpGet("{id}")]
        public IEnumerable<Album> GetAlbum([FromRoute] int id)
        {
            return _context.Album.Where(r => r.ArtistId == id);
        }

        // PUT: api/Albums/5
        [HttpPut("{id}")]
        public async Task<IEnumerable<Album>> PutAlbum([FromRoute] int id, [FromBody] Album album)
        {


            _context.Entry(album).State = EntityState.Modified;
          
            
            await _context.SaveChangesAsync();
            

            return _context.Album.Where(r => r.ArtistId == album.ArtistId);
        }

        // POST: api/Albums
        [HttpPost]
        public async Task<IEnumerable<Album>> PostAlbumAsync([FromBody] Album album)
        {

            _context.Album.Add(album);
            await _context.SaveChangesAsync();

            return _context.Album.Where(r => r.ArtistId == album.ArtistId);
        }

        // DELETE: api/Albums/5
        [HttpDelete("{id}")]
        public async Task<IEnumerable<Album>> DeleteAlbum([FromRoute] int id)
        {          

            var album = await _context.Album.FindAsync(id);
           

            _context.Album.Remove(album);
            await _context.SaveChangesAsync();

            return _context.Album.Where(r => r.ArtistId == album.ArtistId);
        }

        private bool AlbumExists(int id)
        {
            return _context.Album.Any(e => e.AlbumId == id);
        }
    }
}