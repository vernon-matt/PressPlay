export default function Artists(artistlist){
    return `
    <h1>Artists</h1>
    <ul>
        ${artistlist.map(artist => {
        return `
            <li>
                <p>${artist.artistName}</p>
                <img src=${artist.imageUrl}>
                <input class='delete-artist__id' type='hidden' value="${artist.artistId}">
                <button class='delete-artistId__delete'>Delete Artist</button> 
                <input class='select-artist__id' type='hidden' value="${artist.artistId}">
            <button class='select-artistId__select'>Select Artist</button>               
            </li>
        `;
    })
    .join("")}

        </ul>
        <section> 
            <input type="text" class="add-artist_artistname" placeholder="Add an artist name.">
            <input type="text" class="add-artist_artistimage" placeholder="Add an artist Image.">
            <button class="add-artist_submit"> Submit</button>
        </section>

    `
    };