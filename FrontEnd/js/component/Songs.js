export default function Songs(songlist){
    return `
    ${songlist.map(song => {
    return `
        <song>
            <songt> ${song.songTitle}</songt>  
            <dur> ${song.duration}s</dur>    
        </song>
    `;
})
.join("")}
    </songs>
`
};

