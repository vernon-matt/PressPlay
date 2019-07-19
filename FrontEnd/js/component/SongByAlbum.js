export default function SongByArtist(songbyid){
    return `
    
    <ul>
    ${songbyid.map(song => {
        return `
        <h2> Selected Album</h2>
        <li>
            <p>${song.songTitle}</p>                                     
        </li>
    `;
    })
    .join("")}
    </ul>
    `
};