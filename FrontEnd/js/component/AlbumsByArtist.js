export default function AlbumsByArtist(albumsbyid){
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
        </li>
    `;
    })
    .join("")}
    </ul>
    `
};