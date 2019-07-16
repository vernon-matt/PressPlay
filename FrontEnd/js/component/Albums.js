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
            </li>
        `;
    })
    .join("")}
`
};