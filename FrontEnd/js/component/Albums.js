export default function Albums(albumlist){
    return `
    <h1>Albums</h1>
    <albums>
        ${albumlist.map(album => {
        return `
            <album>
                <atitle>${album.albumTitle}</atitle>
                <img class='select-albumId__select' src="${album.imageUrl}">
                <arl>${album.recordLabel}</arl>   
                <input class='select-album__id' type='hidden' value="${album.albumId}">
            </album>                         
        `;
    })
    .join("")}
    </albums>
`
};