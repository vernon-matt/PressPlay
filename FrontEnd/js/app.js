import Home from "./component/home";
import Artists from "./component/Artists";
import Albums from "./component/Albums";
import Songs from "./component/Songs";
import ApiAction from "./api/api-actions";


pageBuild();

function pageBuild(){
    home();
    artists();
    albums();
    songs();

}

function home(){
    const app = document.getElementById('app');
    const home = document.getElementById('nav__Home');
    home.addEventListener('click', function(){
        app.innerHTML = Home();
    })
};

function artists(){
    const app = document.getElementById('app');
    const artists = document.getElementById('nav__Artists');
    artists.addEventListener('click', function(){
        ApiAction.getRequest("https://localhost:44378/api/artists", artistlist => {
            app.innerHTML = Artists(artistlist);
        })
    })

    document.querySelector('#app').addEventListener("click", function(){
        if(event.target.classList.contains('add-artist_submit')){
            const artist = event.target.parentElement.querySelector('.add-artist_artistname').value;
            const artistimage = event.target.parentElement.querySelector('.add-artist_artistimage').value;
            const data = {
                artistId: 0,
                artistName: artist,
                ImageUrl: artistimage
            }
            ApiAction.postRequest("https://localhost:44378/api/artists", data, artistlist => {
                document.querySelector('#app').innerHTML = Artists(artistlist)
            })
        }
    })
};
function albums(){
    const app = document.getElementById('app');
    const albums = document.getElementById('nav__Albums');
    albums.addEventListener('click', function(){
    ApiAction.getRequest("https://localhost:44378/api/albums", albumlist => {
            app.innerHTML = Albums(albumlist);
})
})
}

function songs(){
    const app = document.getElementById('app');
    const songs = document.getElementById('nav__Songs');
    songs.addEventListener('click', function(){
        app.innerHTML = Songs();
    })
};

