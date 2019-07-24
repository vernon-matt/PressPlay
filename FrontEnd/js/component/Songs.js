export default function Songs(songlist){
    return `
    <h1>Songs</h1>
    <ul>
    ${songlist.map(song => {
    return `
        <li>
            <p> ${song.songTitle}</p>
            <p>${song.songId}</p>          
        </li>
    `;
})
.join("")}
    </ul>
`
};

