export default function Albums(albumlist){
    return `
    <h1>Albums</h1>
    <ul>
        ${albumlist.map(album => {
        return `
            <li>
                <p>${album.AlbumTitle}</p>
                <img src="${album.ImageUrl}">
                <p>${album.RecordLabel}</p>               
            </li>
        `;
    })
    .join("")}
`
};