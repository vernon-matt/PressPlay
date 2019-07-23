export default function AlbumsByArtist(albumsbyid, artistId){
    return `
    
    <ul>
    ${albumsbyid.map(album => {
        return `
        
        
        <li>
            <p>${album.albumTitle}</p>
            <img src="${album.imageUrl}">
            <p>${album.recordLabel}</p>  
            <input class='select-album__id' type='hidden' value="${album.albumId}">
            <button class='select-albumId__select'>Select Album</button>
            <input class='delete-album__id' type='hidden' value="${album.albumId}">
            <button class='delete-albumId__delete'>Delete Album</button>    
            <input class='edit-album__albumId' type='hidden' value="${album.albumId}">
            <input class='edit-album_artistId' type='hidden' value="${artistId}">
            <input type="text" class="edit-album_name" placeholder="Edit an album name.">
            <input type="text" class="edit-album_label" placeholder="Edit an album label.">
            <button class="edit-album_submit">Edit Album</button>                                  
            </li>
            `;
    })
    .join("")}
    </ul>
    <section> 
        <input class='add-album_artistId' type='hidden' value="${artistId}">
        <input type="text" class="add-album_albumname" placeholder="Add an album title.">
        <input type="text" class="add-album_albumimage" placeholder="Add an album Image.">
        <button class="add-album_submit"> Submit</button>
    </section>
    `
};