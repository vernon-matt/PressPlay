import { stringify } from "querystring";

export default function Artists(artistlist){
    return `
    <h1>Artists</h1>
    <ul>
        ${artistlist.map(artist => {
        return `
            <li>
                <p>${artist}</p>
                
            </li>
        `
    })}
        // .join("")}

        </ul>
    `
    };