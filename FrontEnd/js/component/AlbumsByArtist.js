export default function AlbumsByArtist(albumsbyid, artistId){
    return `
    
    <albumsbyid>
    ${albumsbyid.map(album => {
        return `

        <albumbyid>
            <p>${album.albumTitle}</p>
            <img class='select-albumId__select' src="${album.imageUrl}">
            <p>${album.recordLabel}</p>
            <albumbyidinput>  
            <input class='select-album__id' type='hidden' value="${album.albumId}">
            <input class='delete-album__id' type='hidden' value="${album.albumId}">
            <button class='delete-albumId__delete'>Delete Album</button>
            </br>    
            <input class='edit-album__albumId' type='hidden' value="${album.albumId}">
            <input class='edit-album_artistId' type='hidden' value="${artistId}">
            <input type="text" class="edit-album_name" placeholder="Edit an album name.">
            <input type="text" class="edit-album_label" placeholder="Edit an album label.">
            <button class="edit-album_submit">Edit Album</button>
            </albumbyidinput>                                  
            </albumbyid>
            `;
    })
    .join("")}
    </albumsbyid>
    <addalbum>
        <h2 style="font-size: 30px;"> Add an album </h2> 
        <input class='add-album_artistId' type='hidden' value="${artistId}">
        <input type="text" class="add-album_albumname" placeholder="Add an album title.">
        <input type="text" class="add-album_label" placeholder="Edit an album label.">
        <input type="text" class="add-album_albumimage" placeholder="Add an album Image.">
        <button style="padding: 0 2vw;" class="add-album_submit"> Submit</button>
    </addalbum>
    `
};