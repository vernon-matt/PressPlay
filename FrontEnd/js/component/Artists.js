export default function Artists(artistlist){
    return `
    <h1>Artists</h1>
    <ul>
        ${artistlist.map(artist => {
        return `
            <li>
                <p>${artist.artistName}</p>
                <p>${artist.artistId}</p>
                <p>${artist.imageUrl}</p>
                
            </li>
        `;
    })
    .join("")}

        </ul>
        <section> 
            <input type="text" class="add-artist_artisttext" placeholder="Add an artist.">
            <button class="add-artist_submit"> Submit</button>
        </section>

    `
    };