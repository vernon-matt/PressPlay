export default function SongByArtist(songbyid){
    return `
    
    
    <songs>
    ${songbyid.map(song => {
        return `
        <song>
            <sst>${song.songTitle}</sst>  
            <sd> ${song.duration} seconds </sd>
            <slink><a href = "${song.link}">YouTube Link</a></slink>                           
        </song>
    `;
    })
    .join("")}
    </songs>
    `
};