export default function Albums(albumlist){
    return `
    <h1>Albums</h1>
    <ul>
        ${albumlist.map(album => {
        return `
            <li>
                <p>${album.albumTitle}</p>
                <img class='select-albumId__select' src="${album.imageUrl}">
                <p>${album.recordLabel}</p>   
                <input class='select-album__id' type='hidden' value="${album.albumId}">
                               
            </li>
        `;
    
    })
    .join("")}
    </ul>
`
};