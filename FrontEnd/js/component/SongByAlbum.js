export default function SongByArtist(songbyid, albumId){
    return `
    

    <songs>
    ${songbyid.map(song => {
        return `

        <song>
        <mainsong>
            <sst>${song.songTitle}</sst>  
            <sd> ${song.duration} seconds </sd>
            <iframe width="560" height="315" src="https://www.youtube.com/embed/${song.link}" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
        </mainsong>
            <songbyidinput>  
            <input class='select-song__id' type='hidden' value="${song.songId}">
            <input class='delete-song__id' type='hidden' value="${song.songId}">
            <button class='delete-songId__delete'>Delete Song</button>
            </br>    
            <input class='edit-song__songId' type='hidden' value="${song.songId}">
            <input class='edit-song_albumId' type='hidden' value="${albumId}">
            <input type="text" class="edit-song_title" placeholder="Edit a song name.">
            <input type="text" class="edit-song_duration" placeholder="Edit a song duration.">
            <input type="text" class="edit-song_link" placeholder="Edit a song link.">
            <button class="edit-song_submit">Edit Song</button>
         </songbyidinput>                         
        </song>
    `;
    })
    .join("")}
    </songs>
    <addsong>
        <h2> Add a Song </h2> 
        <input class='add-song_albumid' type='hidden' value="${albumId}">
        <input type="text" class="add-song_songtitle" placeholder="Add a song title.">
        <input type="text" class="add-song_duration" placeholder="Add a song duration.">
        <input type="text" class="add-song_link" placeholder="Add an embedded YouTube Link.">
        <button class="add-song_submit"> Submit Song</button>
    </addsong>
    `
};