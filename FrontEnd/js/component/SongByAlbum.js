export default function SongByArtist(songbyid){
    return `
    

    <songs>
    ${songbyid.map(song => {
        return `
    <song>
        <songvid>
        <sst>${song.songTitle} 
        <sd> ${song.duration} seconds </sd>
        </sst> 
        <iframe width="560" height="315" src="https://www.youtube.com/embed/${song.link}" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
        </songvid>
    </song>
    `;
    })
    .join("")}
    </songs>
    `
};