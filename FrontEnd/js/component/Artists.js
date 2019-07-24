export default function Artists(artistlist){
    return `
    <h1>Artists</h1>
    <artists>
        ${artistlist.map(artist => {
        return `
            <artist>
                <an>${artist.artistName}</an>
                <img class='select-artistId__select' src=${artist.imageUrl}>
                <artistinput>
                <input class='delete-artist__id' type='hidden' value="${artist.artistId}">
                <button class='delete-artistId__delete'>Delete Artist</button> 
                </br>
                <input class='select-artist__id' type='hidden' value="${artist.artistId}">
                <input class='edit-artist__artistId' type='hidden' value="${artist.artistId}">
                <input type="text" class="edit-artist_name" placeholder="Edit an artist name.">
                <button class="edit-artist_submit">Submit</button>
                </artistinput>        
            </artist>
        `;
    })
    .join("")}
        </artists>
        <addartist> 
            <input type="text" class="add-artist_artistname" placeholder="Add an artist name.">
            <input type="text" class="add-artist_artistimage" placeholder="Add an artist Image.">
            <button class="add-artist_submit"> Submit</button>
        </addartist>
    `
    };