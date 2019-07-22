export default function Albums(albumlist){
    return `
    <h1>Albums</h1>
    <ul>
        ${albumlist.map(album => {
        return `
            <li>
                <p>${album.albumTitle}</p>
                <img src="${album.imageUrl}">
                <p>${album.recordLabel}</p>   
                <input class='delete-album__id' type='hidden' value="${album.albumId}">
                <button class='delete-albumId__delete'>Delete Album</button> 
                <input class='select-album__id' type='hidden' value="${album.albumId}">
                <button class='select-albumId__select'>Select Album</button>    
                
                
                <section> 
                <input class='edit-album__albumId' type='hidden' value="${album.albumId}">
                <input type="text" class="edit-album_name" placeholder="Edit an album name.">
                <button class="edit-album_submit">Submit</button>
                </section>                      
            </li>
        `;
    
    })
    .join("")}
    </ul>
    <section> 
            <input type="text" class="add-album_albumname" placeholder="Add an album title.">
            <input type="text" class="add-album_albumimage" placeholder="Add an album Image.">
            <button class="add-album_submit"> Submit</button>
        </section>
`
};